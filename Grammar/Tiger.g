grammar Tiger;
options
{
language=CSharp3;
}

tokens
{
	NIL = 'nil';
	Minus = '-';
	Assign = ':=';
	LParent = '(';
	RParent = ')';
	LCorch = '[';
	RCorch = ']';
	LKey = '{';
	RKey = '}';
	If = 'if';
	Then = 'then';
	Else = 'else';
	Break = 'break';
	While = 'while';
	Do = 'do';
	For = 'for';
	To = 'to';
	In = 'in';
	End = 'end';
	Let = 'let';
	Comma = ',';
	DotComma = ';';
	Dot = '.';
	
	/* Operators */
	Plus = '+';
	Minus = '-';
	Mult = '*';
	Div = '/';
	Equals = '=';
	NotEquals = '<>';
	GThan = '>';
	LThan = '<';
	GEThan = '>=';
	LEThan = '<=';
	And = '&';
	Or = '|';
	Type = 'type';
	ArrayOf = 'array of';
	Var = 'var';
	Function ='function';
	Quotes = '"';
	Underscore = '_';
	Of = 'of';
}

@header {
using TigerNET.AST;
}

@lexer::members {
private IList<string> _errors = new List<string>();
public IList<string> Errors { get { return _errors; }}

public override void ReportError(RecognitionException e) {
	Errors.Add(e.ToString());
}	
}

@parser::members {
private IList<string> _errors = new List<string>();
public IList<string> Errors { get { return _errors; }}

public override void ReportError(RecognitionException e) {
	Errors.Add(e.ToString());
}	
}

INT_CONST 	:	(DIGIT)+;
STRING_CONST : Quotes {Text = "";}
(
CHAR {Text += $CHAR.Text; }|
SPACE {Text += $SPACE.Text; }|
ESC {Text += $ESC.Text; }
)* Quotes;
fragment DIGIT	:	'0'..'9';
SPACE	:	('\n'|'\t'|' '|'\r') {$channel = Hidden;};
fragment ESC	:	'\\'('n'|'t'|'\\'|'"');	/* TODO: Control-C, ASCII, etc */
fragment LETTER :	'a'..'z' | 'A'..'Z';
fragment CHAR	:	~('\n'|'\t'|'\\'|'"'|' ');	
ID	:	LETTER(LETTER|DIGIT|Underscore)*;
COMMENTS 
	:	'/*' ( options {greedy=false;} : COMMENTS | . )* '*/' 
		{$channel = Hidden;};

public prog returns [ExpressionNode node] :	e = expr_or EOF { $node = $expr_or.node; };
expr_or	returns [ExpressionNode node] :	left = expr_and 
{
/* Left */
$node = $left.node; 
}
(Or right = expr_or 
{
var orOperatorNode = new OrOperatorNode($node, $right.node);
$node = orOperatorNode;
})?;
expr_and returns [ExpressionNode node]:	left = expr_logical  
{
$node = $left.node;
}
(And right = expr_and 
{
var andOperatorNode = new AndOperatorNode($node, $right.node);
$node = andOperatorNode;
}
)?;
expr_logical returns [ExpressionNode node]
	@init {RelationalBinaryOperatorNode n = null;}
	:	left = expr_arithm 
{
$node = $left.node; 
}
	(
	
	((Equals 
	{
	n = new EqualOperatorNode() { Left = $node };
	}) | 
	NotEquals 
	{
	n = new NotEqualOperatorNode() { Left = $node };
	}| 
	GThan {
	n = new GreatherOperatorNode() { Left = $node };
	}| 
	LThan 
	{
	n = new LowerOperatorNode() { Left = $node };
	}| 
	GEThan 
	{
	n = new GreatherEqualOperatorNode() { Left = $node };
	}| 
	LEThan 
	{
	n = new LowerEqualOperatorNode() { Left = $node };	
	}
	) right = expr_logical 
	{
	n.Right = $right.node;
	$node = n;
	}
	
	)?;
expr_arithm returns [ExpressionNode node]
@init {ArithmeticalBinaryOperatorNode n = null;}
	:	left = expr_factor {$node = $left.node;} 
	(
	(
	(Plus) 
	{
	n = new PlusOperatorNode() { Left = $node };
	} | 
	Minus
	{
	n = new MinusOperatorNode() { Left = $node };
	}
	) right = expr_arithm {n.Right = $right.node; $node = n;}
	)?;
expr_factor returns [ExpressionNode node]
@init {ArithmeticalBinaryOperatorNode n = null;}
	:	left = expr {$node = $left.node; }
	(
	(
	(Mult) 
	{
	n = new ProdOperatorNode() { Left = $node };
	}| 
	Div 
	{
	n = new DivOperatorNode() { Left = $node };
	}
	) right = expr_factor {n.Right = $right.node; $node = n;}
	)?;
expr	returns [ExpressionNode node]:	
	(
	STRING_CONST {$node = new StringLiteralNode($STRING_CONST.Text); }| /* string-constant */
	INT_CONST {$node = new IntegerLiteralNode(int.Parse($INT_CONST.Text)); }| /* integer-constant */
	NIL {$node = new NilLiteralNode(); }| /* nil */
	Minus e = expr_or {$node = new MinusUnaryOperatorNode($e.node); }| /* -expr */
	/* id(expr-list) */ /* type-id{field-list} */
	/* type-id[expr] of expr*/
	/* lvalue */ /* lvalue := expr */
	id = ID aux = idAux[$id.Text] {$node = $aux.node;}  |
	LParent {$node = new ExpressionSequenceNode();} (seq = exprSeq {$node = $seq.node;})? RParent | /* (expr-seq) */ 
	If cond = expr_or Then then = expr_or (Else els = expr_or)? 
	{
	$node = new IfThenElseNode($cond.node, $then.node, $els.node);
	} | /* if expr then expr */ /* if expr then expr else expr */
	While cond = expr_or Do body = expr_or 
	{
	$node = new WhileNode($cond.node, $body.node);
	}| /* while expr do expr */
	For varName = ID Assign start = expr_or To end = expr_or Do bodyFor = expr_or 
	{
	$node = new ForToDoNode($varName.Text, $start.node, $end.node, $bodyFor.node);
	}| /* for id:=expr to expr do expr */
	Break { $node = new BreakNode(); }|  /* break */
	Let declarations = declarationList {$node = new LetInEndNode($declarations.items); } In (seq = exprSeq {((LetInEndNode)$node).Expressions = $seq.node; })? End /* let declaration-list in expr-seq end */
	) lv = lvalue[$node] {$node = $lv.node; };
	
idAux [string id] returns [ExpressionNode node] 
@init{$node = new VariableAccessNode(id); }
:
	LParent {$node = new CallableNode(id, new List<ExpressionNode>()); }(list = exprList { $node = new CallableNode(id, $list.items); } )? RParent |
	(
		(LKey RKey) => 
			 LKey RKey {$node = new RecordLiteralNode(id, new List<FieldAssignmentNode>()); }|
			 LKey fields = fieldList 
			 {
			 $node = new RecordLiteralNode(id, $fields.items);
			 } 
			 RKey
	)|
	((LCorch expr_or RCorch Of) => 
	(
	LCorch length = expr_or RCorch Of initialValue = expr_or 
	{
	$node = new ArrayLiteralNode(id, $length.node, $initialValue.node); 
	}
	) | 
	lv = lvalue[$node] {$node = $lv.node; }(Assign body = expr_or {$node = new AssignmentNode((AccessNode)$node, $body.node);})?
	);
exprSeq	returns [ExpressionSequenceNode node] 
@init {$node = new ExpressionSequenceNode();}
:	e1 = expr_or {((ExpressionSequenceNode)$node).AddToSequence($e1.node); }(DotComma e2 = expr_or {((ExpressionSequenceNode)$node).AddToSequence($e2.node); })*; /* una o mas expresiones separadas por punto y coma (;) */

exprList returns [IList<ExpressionNode> items]	
@init {items = new List<ExpressionNode>();}
: e1 = expr_or {items.Add($e1.node);} (Comma e2 = expr_or {items.Add($e2.node);})*; /* una o mas expresiones separadas por comas (,) */

fieldList returns [IList<FieldAssignmentNode> items]
@init{$items = new List<FieldAssignmentNode>(); }	:
	id = idAssign {$items.Add($id.node);} (Comma id = idAssign {$items.Add($id.node);})*; /* una o varias asignaciones (ver idAssign) separadas por comas (,) */

idAssign returns [FieldAssignmentNode node]:	
fieldName = ID Equals body = expr_or {$node = new FieldAssignmentNode($fieldName.Text, $body.node);}; /* id = expr */

lvalue[ExpressionNode accessNode] returns [ExpressionNode node]	:	
{node = accessNode;}
(
Dot fieldName = ID {$node = new RecordAccessNode($node, $fieldName.Text);}| 
LCorch index = expr_or RCorch {$node = new ArrayAccessNode($node, $index.node); }
)*; /* Asume que sera llamado con el ID ya macheado. */ /* .ID */ /* [expr] */

declarationList	returns [IList<DeclarationNode> items]
@init{$items = new List<DeclarationNode>();}:
	(dec = declaration {$items.Add($dec.node);} )+ ; /* un o mas declaraciones */
declaration returns [DeclarationNode node]	:	
/* una declaracion de tipo, de variable, o de funcion */
t = typeDeclaration { $node = $t.node; } |
v = variableDeclaration { $node = $v.node; }| 
f = functionDeclaration {$node = $f.node; };

typeDeclaration	returns [TypeDeclarationNode node] :	
Type name = ID Equals t = type[$name.Text] {$node = $t.node;} ; /* type type-id = type */

type[string name] returns [TypeDeclarationNode node]	:	
	id = ID {$node = new AliasDeclarationNode(name, $id.Text); }| /* type-id */
	LKey {$node = new RecordDeclarationNode(name); }(fields = typeFields {((RecordDeclarationNode)$node).Fields = $fields.items;})? RKey | /* { type-fields_opt } */
	ArrayOf typeName = ID {$node = new ArrayDeclarationNode(name, $typeName.Text);}; /* array of type-id */

typeFields returns [IList<TypeField> items]
@init{$items = new List<TypeField>();}	: 	
t = typeField {$items.Add($t.value); } (Comma t = typeField {$items.Add($t.value);})*; /* uno o varios tipos separados por comas (,) */

typeField returns [TypeField value]	:	id = ID ':' typeId = ID {$value = new TypeField($id.Text, $typeId.Text);};/* id : type-id */

variableDeclaration returns [VariableDeclarationNode node]
@init{string typeName = null;} :
Var name = ID (':' tName = ID {typeName = $tName.Text;})? Assign body = expr_or 
{$node = new VariableDeclarationNode($name.Text, $body.node, typeName);}; /* var id := expr */ /* var id : type-id := expr */

				/* function id (type-fields_opt) = expr*/
				/* function id (type-fields_opt) : type-id = expr*/
functionDeclaration returns [CallableDeclarationNode node]	
@init {
IList<TypeField> fields = new List<TypeField>();
string typeName = null;
}
:	
Function name = ID LParent (f = typeFields {fields = $f.items;})? RParent (':' tName = ID {typeName = $tName.Text;})? Equals body = expr_or
{return new CallableDeclarationNode($name.Text, fields, $body.node, typeName);}
; 