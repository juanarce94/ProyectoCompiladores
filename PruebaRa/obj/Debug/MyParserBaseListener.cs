//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\users\juan miguel\documents\visual studio 2013\Projects\PruebaRa\PruebaRa\MyParser.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PruebaRa {

using System;


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IMyParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class MyParserBaseListener : IMyParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] MyParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] MyParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.consDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConsDecl([NotNull] MyParser.ConsDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.consDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConsDecl([NotNull] MyParser.ConsDeclContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarDecl([NotNull] MyParser.VarDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarDecl([NotNull] MyParser.VarDeclContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.classDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassDecl([NotNull] MyParser.ClassDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.classDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassDecl([NotNull] MyParser.ClassDeclContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.methodDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodDecl([NotNull] MyParser.MethodDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.methodDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodDecl([NotNull] MyParser.MethodDeclContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.formPars"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormPars([NotNull] MyParser.FormParsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.formPars"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormPars([NotNull] MyParser.FormParsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] MyParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] MyParser.TypeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] MyParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] MyParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] MyParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] MyParser.BlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.actPars"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterActPars([NotNull] MyParser.ActParsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.actPars"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitActPars([NotNull] MyParser.ActParsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] MyParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] MyParser.ConditionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.condterm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondterm([NotNull] MyParser.CondtermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.condterm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondterm([NotNull] MyParser.CondtermContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.condFact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondFact([NotNull] MyParser.CondFactContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.condFact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondFact([NotNull] MyParser.CondFactContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] MyParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] MyParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] MyParser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] MyParser.TermContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactor([NotNull] MyParser.FactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactor([NotNull] MyParser.FactorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.designator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDesignator([NotNull] MyParser.DesignatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.designator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDesignator([NotNull] MyParser.DesignatorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.relop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelop([NotNull] MyParser.RelopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.relop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelop([NotNull] MyParser.RelopContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.addop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddop([NotNull] MyParser.AddopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.addop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddop([NotNull] MyParser.AddopContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.mulop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulop([NotNull] MyParser.MulopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.mulop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulop([NotNull] MyParser.MulopContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace PruebaRa
