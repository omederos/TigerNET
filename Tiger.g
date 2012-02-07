grammar Tiger;
options {
	language = Java;
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
BINARY_OP 
	:	 Plus | Minus | Mult | Div | Equals | NotEquals | GThan | LThan | GEThan | LEThan | And | Or;
INT_CONST 	:	(DIGIT)+;
fragment DIGIT	:	'0'..'9';
fragment SPACE	:	('\n'|'\t'|' ');
fragment ESC	:	'\\'('n'|'t'|'\\'|'"');	/* TODO: Control-C, ASCII, etc */
fragment LETTER :	'a'..'z' | 'A'..'Z';
CHAR	:	~('\n'|'\t'|'\\'|'"'|' ');	
STRING_CONST	:	Quotes CHAR|SPACE|ESC Quotes;
ID	:	LETTER (LETTER|DIGIT|Underscore)*;

expr_or	:	expr_or Or expr_and;
expr_and:	expr_and And expr_logical;
expr_logical
	:	expr_logical Equals expr_arithm | 
		expr_logical NotEquals expr_arithm | 
		expr_logical GThan expr_arithm | 
		expr_logical LThan expr_arithm | 
		expr_logical GEThan expr_arithm | 
		expr_logical LEThan expr_arithm;
expr_arithm
	:	expr_arithm Plus expr_factor |
		expr_arithm Minus expr_factor;
expr_factor
	:	expr_factor Mult expr_minus |
		expr_factor Div expr_minus;
expr_minus
	:	expr |
		Minus expr;
expr	:	STRING_CONST |
		INT_CONST |
		NIL |
		lvalue |
		lvalue Assign expr | 
		ID LParent exprList RParent | 
		LParent exprSeq RParent | 
		ID LKey fieldList RKey | 
		ID LParent expr RParent Of expr | 
		If expr Then expr | 
		If expr Then expr Else expr | 
		While expr Do expr | 
		For ID Assign expr To expr Do expr | 
		Break | 
		Let declarationList In exprSeq End;
exprSeq	:	expr_or(DotComma expr_or)*;
exprList:	expr_or(Comma expr_or)*;
fieldList	:	idAssign (Comma idAssign)*;

idAssign:	ID Equals expr_or |;
lvalue	:	ID lvalueAux;
lvalueAux :	(Dot ID | LCorch expr_or RCorch )*;
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
		
		
