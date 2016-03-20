parser grammar MyParser;

@header {
using System;
}

options {
language = CSharp;
tokenVocab = MyLexer;
}



program
: CLASS ID ( consDecl | varDecl | classDecl )* CORIZQ ( methodDecl )* CORDER
;

consDecl 
: CONST type ID IGUAL ( NUM | CHARCONST ) PyCOMA
;

varDecl 
: type ID ( COMA ID )* PyCOMA
;

classDecl 
: CLASS ID CORIZQ ( varDecl )* CORDER
;

methodDecl
: (type | VOID) ID PIZQ ( formPars |  ) PDER ( varDecl )* block
;

formPars
: type ID ( COMA type ID )*
;

type
: ID ( CUADIZQ CUADDER | )
;

statement
: designator ( IGUAL  expr | PIZQ ( actPars | ) PDER | MASMAS | MENOSMENOS ) PyCOMA
| IF PIZQ condition PDER statement ( ELSE statement | )
| FOR PIZQ expr PyCOMA ( condition | ) PyCOMA ( statement | ) PDER statement
| WHILE PIZQ condition PDER statement
| BREAK PyCOMA
| RETURN ( expr | ) PyCOMA
| READ PIZQ designator PDER PyCOMA
| WRITE PIZQ expr ( COMA NUM | ) PDER PyCOMA
| block
| PyCOMA
;

block
: CORIZQ (statement)* CORDER
;

actPars 
: expr (COMA expr)*
;

condition
: condterm ( VERTICALVERTICAL condterm )*
;

condterm
: condFact ( AMPAMP condFact )*
;

condFact
: expr relop expr
;

expr
: ( MENOS | ) term ( addop term )*
;

term
: factor ( mulop factor )*
;

factor
: designator ( PIZQ ( actPars | ) PDER | )
| NUM
| CHARCONST
| (TRUE | FALSE)
| NEW ID ( CUADIZQ expr CUADDER | )
| PIZQ expr PDER
;

designator
: ID ( PUNTO ID |  CUADIZQ expr CUADDER )*
;

relop
: IGUALIGUAL | DIF | MAYORQ | MAYORIGUAL | MENORQ | MENORIGUAL 
;

addop 
: MAS | MENOS
;

mulop
: MUL | DIV | PORCEN
;

 