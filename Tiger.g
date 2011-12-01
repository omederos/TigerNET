grammar Tiger;
options {
	language = Java;
}

@header {
	using System;
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

expr 	:	STRING_CONST | 
		INT_CONST | 
		NIL | 
		lvalue | 
		Minus expr | 
		expr BINARY_OP expr | 
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
exprSeq	: 	expr (DotComma expr)*;
exprList:	expr (Comma expr)*;

fieldList	:	idAssign (Comma idAssign)*;

idAssign:	ID Equals expr |;
lvalue	:	ID lvalueAux;;
lvalueAux :	(Dot ID | LCorch expr RCorch )*;
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

variableDeclaration	:	Var ID Assign expr |
				Var ID TwoDots ID Assign expr;
functionDeclaration	:	Function ID LParent typeFields RParent (TwoDots ID)? Equals expr;