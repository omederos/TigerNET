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
	TwoDots = ':';
	Var = 'var';
	Function ='function';
	Quotes = '"';
	Underscore = '_';
	Of = 'of';
}

@lexer::members {
private IList<string> _errors = new List<string>();
public IList<string> Errors { get { return _errors; }}

public override void ReportError(RecognitionException e) {
	Errors.Add(e.ToString());
}	
}

INT_CONST 	:	(DIGIT)+;
fragment DIGIT	:	'0'..'9';
fragment SPACE	:	('\n'|'\t'|' ');
fragment ESC	:	'\\'('n'|'t'|'\\'|'"');	/* TODO: Control-C, ASCII, etc */
fragment LETTER :	'a'..'z' | 'A'..'Z';
CHAR	:	~('\n'|'\t'|'\\'|'"'|' ');	
STRING_CONST	:	Quotes CHAR|SPACE|ESC Quotes;
ID	:	LETTER (LETTER|DIGIT|Underscore)*;
COMMENTS 
	:	'/*' ( options {greedy=false;} : COMMENTS | . )* '*/' 
		{$channel = Hidden;};

public program:	 expr_or EOF;
expr_or	:	expr_and (Or expr_and)*;
expr_and:	expr_logical (And expr_logical)*;
expr_logical
	:	expr_arithm (
			(((Equals) | NotEquals | GThan | LThan | GEThan | LEThan)) expr_arithm
		)*;
expr_arithm
	:	expr_factor (((Plus) | Minus) expr_factor)*;
expr_factor
	:	expr (((Mult) | Div) expr)*;
expr	:	STRING_CONST | /* string-constant */
		INT_CONST | /* integer-constant */
		NIL | /* nil */
		Minus expr_or | /* -expr */
		/* id(expr-list) */ /* type-id{field-list} */
		/* type-id[expr] of expr*/
		/* lvalue */ /* lvalue := expr */
		ID ((LParent exprList RParent | LKey fieldList RKey)? | (LCorch expr_or RCorch Of) => (LCorch expr_or RCorch Of expr_or) | (lvalue (Assign expr_or)?)) | 
		LParent exprSeq RParent | /* (expr-seq) */ 
		If expr_or Then expr_or (Else expr_or)? | /* if expr then expr */ /* if expr then expr else expr */
		While expr_or Do expr_or | /* while expr do expr */
		For ID Assign expr_or To expr_or Do expr_or | /* for id:=expr to expr do expr */
		Break |  /* break */
		Let declarationList In (exprSeq)? End; /* let declaration-list in expr-seq end */
exprSeq	:	expr_or (DotComma expr_or)*; /* una o mas expresiones separadas por punto y coma (;) */
exprList:	expr_or (Comma expr_or)*; /* una o mas expresiones separadas por comas (,) */
fieldList	:	idAssign (Comma idAssign)*; /* una o varias asignaciones (ver idAssign) separadas por comas (,) */

idAssign:	ID Equals expr_or |; /* id = expr */
lvalue	:	(Dot ID | LCorch expr_or RCorch )*; /* Asume que sera llamado con el ID ya macheado. */ /* .ID */ /* [expr] */
declarationList	:	declaration+; /* un o mas declaraciones */
declaration	:	typeDeclaration | /* una declaracion de tipo, de variable, o de funcion */
			variableDeclaration | 
			functionDeclaration;
typeDeclaration	:	Type ID Equals type; /* type type-id = type */
type	:	ID | /* type-id */
		LKey typeFields RKey | /* { type-fields_opt } */
		ArrayOf ID; /* array of type-id */
typeFields	: 	typeField (Comma typeField)*; /* uno o varios tipos separados por comas (,) */
typeField	:	ID TwoDots ID; /* id : type-id */

variableDeclaration	:	Var ID Assign expr_or | /* var id := expr */
				Var ID TwoDots ID Assign expr_or; /* var id : type-id := expr */

				/* function id (type-fields_opt) = expr*/
				/* function id (type-fields_opt) : type-id = expr*/
functionDeclaration	:	Function ID LParent typeFields RParent (TwoDots ID)? Equals expr; 
		
		
