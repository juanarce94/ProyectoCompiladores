parser grammar MyParser;

@header {
using System;
}

options {
language = CSharp;
tokenVocab = MyLexer;
}



program
: CLASS ID ( consDecl | varDecl | classDecl )* CORIZQ ( methodDecl )* CORDER							#programAST
;

consDecl 
: CONST type ID IGUAL ( NUM | CHARCONST ) PyCOMA														#consDeclAST
;

varDecl 
: type ID ( COMA ID )* PyCOMA																			#varDeclAST
;

classDecl 
: CLASS ID CORIZQ ( varDecl )* CORDER																	#classDeclAST
;

methodDecl
: (type | VOID) ID PIZQ ( formPars |  ) PDER ( varDecl )* block											#methodDeclAST
;

formPars
: type ID ( COMA type ID )*																				#formParsAST
;

type
: ID ( CUADIZQ CUADDER | )																				#typeAST
;

statement
: designator ( IGUAL  expr | PIZQ ( actPars | ) PDER | MASMAS | MENOSMENOS ) PyCOMA						#statementDesignatorAST
| IF PIZQ condition PDER statement ( ELSE statement | )													#statementIFAST
| FOR PIZQ expr PyCOMA ( condition | ) PyCOMA ( statement | ) PDER statement							#statementFORAST
| WHILE PIZQ condition PDER statement																	#statementWHILEAST
| BREAK PyCOMA																							#statementBREAKAST
| RETURN ( expr | ) PyCOMA																				#statementRETURNAST
| READ PIZQ designator PDER PyCOMA																		#statementREADAST
| WRITE PIZQ expr ( COMA NUM | ) PDER PyCOMA															#statementWRITEAST
| block																									#statementBlockAST
| PyCOMA																								#statementPyCOMEAST
;

block
: CORIZQ (statement)* CORDER																			#blockAST
;

actPars 
: expr (COMA expr)*																						#actParsAST
;

condition
: condterm ( VERTICALVERTICAL condterm )*																#conditionAST
;

condterm
: condFact ( AMPAMP condFact )*																			#condtermAST
;

condFact
: expr relop expr																						#condFactAST
;

expr
: ( MENOS | ) term ( addop term )*																		#exprAST
;

term
: factor ( mulop factor )*																				#termAST
;

factor
: designator ( PIZQ ( actPars | ) PDER | )																#factorDesignatorAST
| NUM																									#factorNUMAST
| CHARCONST																								#factorCHARCONSTAST
| (TRUE | FALSE)																						#factorTrueFalseAST
| NEW ID ( CUADIZQ expr CUADDER | )																		#factorNEWAST
| PIZQ expr PDER																						#factorExprAST
;

designator
: ID ( PUNTO ID |  CUADIZQ expr CUADDER )*																#designatorAST
;

relop
: IGUALIGUAL | DIF | MAYORQ | MAYORIGUAL | MENORQ | MENORIGUAL											#relopAST
;

addop 
: SUMA | MENOS																							#addopAST
;

mulop
: MUL | DIV | PORCEN																					#mulopAST
;