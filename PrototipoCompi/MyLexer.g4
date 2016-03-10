lexer grammar MyLexer;

WS
: ' ' -> channel(HIDDEN)
;

NEWLINE 
: ('\n' | '\r') -> channel(HIDDEN)
;

INT : 'int';

STRING : 'string';

BREAK : 'break';
CLASS : 'class';

PyCOMA : ';' ;
COMA : ',' ;
ASIGN : '=' ;
PIZQ : '(' ;
PDER : ')' ;
SUMA : '+' ;
MUL : '*' ;

NUM : '0' | '1'..'9' ('0'..'9')* ;

ID : CharInicial CharContenido* ;

LQUOTE : '"' -> more, mode(STRI) ;

fragment
CharContenido
: CharInicial
| '0'..'9'
| '_'
;

fragment
CharInicial
: 'A'..'Z' | 'a'..'z'
;

mode STRI;
STR : '"' -> mode(DEFAULT_MODE) ; 
TEXT : . -> more ;