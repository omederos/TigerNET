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
		{$channel = HIDDEN;};

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
expr	:	STRING_CONST |
		INT_CONST |
		NIL |
		Minus expr |
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
exprSeq	:	expr_or (DotComma expr_or)*;
exprList:	expr_or (Comma expr_or)*;
fieldList	:	idAssign (Comma idAssign)*;

idAssign:	ID Equals expr_or |;
lvalue	:	(Dot ID | LCorch expr_or RCorch )*;
declarationList	:	declaration+;
declaration	:	typeDeclaration | 
			variableDeclaration | 
			functionDeclaration;
typeDeclaration	:	Type ID Equals type;
type	:	ID | 
		LKey typeFields RKey | 
		ArrayOf ID;
typeFields	: 	typeField (Comma typeField)*;
typeField	:	ID TwoDots ID;

variableDeclaration	:	Var ID Assign expr_or |
				Var ID TwoDots ID Assign expr_or;
functionDeclaration	:	Function ID LParent typeFields RParent (TwoDots ID)? Equals expr;
		
		
