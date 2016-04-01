lexer grammar MyLexer;

WS
	:	' ' -> channel(HIDDEN)
	;

NEWLINE 
: ('\n' | '\r') -> channel(HIDDEN)
;

TAB
: '\t' -> channel(HIDDEN)
;


BREAK
: 'break';

CLASS
: 'class';

CONST
: 'const';

ELSE
: 'else';

IF
: 'if';

NEW
: 'new';

TRUE
: 'true'
;

FALSE
: 'false'
;

READ
: 'read';

RETURN
: 'return';

VOID
: 'void';

WHILE
: 'while';

WRITE
: 'write';

FOREACH
: 'foreach';

FOR
: 'for';

PyCOMA : ';' ;
COMA : ',' ;
IGUAL : '=' ;
IGUALIGUAL: '==';
DIF : '!=';
PIZQ : '(' ;
PDER : ')' ;
SUMA : '+' ;
MASMAS: '++' ;
MUL : '*' ;
MENOS : '-' ;
MENOSMENOS : '--' ;
DIV : '/';
EXCLA : '!';
NUMERAL : '#';
DOLAR : '$';
PORCEN : '%';
AMP : '&';
AMPAMP : '&&' ; 
PUNTO : '.';
MENORQ : '<';
MENORIGUAL : '<=';
MAYORQ : '>';
MAYORIGUAL : '>=' ;
PREG : '?';
ARROBA : '@';
GUIOBAJO : '_';
SQUOTE : '\'';
VERTICAL : '|';
VERTICALVERTICAL : '||' ;
CORDER : '}';
CORIZQ : '{';
CUADDER : ']';
CUADIZQ : '[';
COMENT: '//';
COMENTBLOCK1: '/*';
COMENTBLOCK2: '*/';


NUM
: '0' | '1'..'9' ('0'..'9')*
;

ID
: CharInicial CharContenido* 
;


PRINTABLECHAR
: CharInicial
| NUM
|'!'
|'"'
|'#'
|'$'
|'%'
|'&'
|'\''
|'('
|')'
|'*'
|'+'
|','
|'-'
|'.'
|'/'
|':'
|';'
|'<'
|'='
|'>'
|'?'
|'@'
;
CHARCONST
: SQUOTE (PRINTABLECHAR | NEWLINE) SQUOTE
;



COMENTARIO
: '//' .*? '\n'  -> channel(HIDDEN)
;

COMENTARIOBLOQUE
: '/*' (COMENTARIOBLOQUE|.)*? '*/' -> channel(HIDDEN)
;


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
TEXT : .* -> more ;