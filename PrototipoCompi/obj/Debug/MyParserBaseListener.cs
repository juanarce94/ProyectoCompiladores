//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Juan Miguel\Documents\Visual Studio 2013\Projects\PrototipoCompi\PrototipoCompi\MyParser.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PrototipoCompi {

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
	/// Enter a parse tree produced by the <c>exprsAST</c>
	/// labeled alternative in <see cref="MyParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprsAST([NotNull] MyParser.ExprsASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprsAST</c>
	/// labeled alternative in <see cref="MyParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprsAST([NotNull] MyParser.ExprsASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>epsStatAST</c>
	/// labeled alternative in <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEpsStatAST([NotNull] MyParser.EpsStatASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>epsStatAST</c>
	/// labeled alternative in <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEpsStatAST([NotNull] MyParser.EpsStatASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>asignStatAST</c>
	/// labeled alternative in <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsignStatAST([NotNull] MyParser.AsignStatASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>asignStatAST</c>
	/// labeled alternative in <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsignStatAST([NotNull] MyParser.AsignStatASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprStatAST</c>
	/// labeled alternative in <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprStatAST([NotNull] MyParser.ExprStatASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprStatAST</c>
	/// labeled alternative in <see cref="MyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprStatAST([NotNull] MyParser.ExprStatASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>idlistsAST</c>
	/// labeled alternative in <see cref="MyParser.idlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdlistsAST([NotNull] MyParser.IdlistsASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>idlistsAST</c>
	/// labeled alternative in <see cref="MyParser.idlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdlistsAST([NotNull] MyParser.IdlistsASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>statsAST</c>
	/// labeled alternative in <see cref="MyParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatsAST([NotNull] MyParser.StatsASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>statsAST</c>
	/// labeled alternative in <see cref="MyParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatsAST([NotNull] MyParser.StatsASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>termsAST</c>
	/// labeled alternative in <see cref="MyParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermsAST([NotNull] MyParser.TermsASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>termsAST</c>
	/// labeled alternative in <see cref="MyParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermsAST([NotNull] MyParser.TermsASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>sinDeclAST</c>
	/// labeled alternative in <see cref="MyParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSinDeclAST([NotNull] MyParser.SinDeclASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>sinDeclAST</c>
	/// labeled alternative in <see cref="MyParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSinDeclAST([NotNull] MyParser.SinDeclASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>conDeclAST</c>
	/// labeled alternative in <see cref="MyParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConDeclAST([NotNull] MyParser.ConDeclASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>conDeclAST</c>
	/// labeled alternative in <see cref="MyParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConDeclAST([NotNull] MyParser.ConDeclASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprFactAST([NotNull] MyParser.ExprFactASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprFactAST([NotNull] MyParser.ExprFactASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>idFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdFactAST([NotNull] MyParser.IdFactASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>idFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdFactAST([NotNull] MyParser.IdFactASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>numFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumFactAST([NotNull] MyParser.NumFactASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumFactAST([NotNull] MyParser.NumFactASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>strFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStrFactAST([NotNull] MyParser.StrFactASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>strFactAST</c>
	/// labeled alternative in <see cref="MyParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStrFactAST([NotNull] MyParser.StrFactASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>strDeclAST</c>
	/// labeled alternative in <see cref="MyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStrDeclAST([NotNull] MyParser.StrDeclASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>strDeclAST</c>
	/// labeled alternative in <see cref="MyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStrDeclAST([NotNull] MyParser.StrDeclASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>intDeclAST</c>
	/// labeled alternative in <see cref="MyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntDeclAST([NotNull] MyParser.IntDeclASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>intDeclAST</c>
	/// labeled alternative in <see cref="MyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntDeclAST([NotNull] MyParser.IntDeclASTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>declsAST</c>
	/// labeled alternative in <see cref="MyParser.declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclsAST([NotNull] MyParser.DeclsASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>declsAST</c>
	/// labeled alternative in <see cref="MyParser.declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclsAST([NotNull] MyParser.DeclsASTContext context) { }

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
	/// Enter a parse tree produced by <see cref="MyParser.declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarations([NotNull] MyParser.DeclarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarations([NotNull] MyParser.DeclarationsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] MyParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] MyParser.DeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatements([NotNull] MyParser.StatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatements([NotNull] MyParser.StatementsContext context) { }

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
	/// Enter a parse tree produced by <see cref="MyParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] MyParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] MyParser.ExpressionContext context) { }

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
	/// Enter a parse tree produced by <see cref="MyParser.idlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdlist([NotNull] MyParser.IdlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyParser.idlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdlist([NotNull] MyParser.IdlistContext context) { }

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
} // namespace PrototipoCompi
