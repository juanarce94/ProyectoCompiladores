using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TreeViewPrint : MyParserBaseVisitor<Object>
    {

        private List<PrintableNode> tree = new List<PrintableNode>();
        private int father = -1;


        public List<PrintableNode> getPrintableTree() {

            return this.tree;

        }

        public override Object VisitClassDeclAST([NotNull] MyParser.ClassDeclASTContext context) {

            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.varDecl() != null) {

                for (int i = 0; i < context.varDecl().Length; i++ )
                {
                    Visit(context.varDecl(i));
                }

            }      

            father = myFather;
            return null;        
        }

        public override Object VisitConsDeclAST([NotNull] MyParser.ConsDeclASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();

            if (context.CHARCONST() != null) {
                nn.text = "CharConst -> " + context.CHARCONST().GetText();
            }
            else if (context.NUM() != null)
            {
                nn.text = "NumConst -> " + context.NUM().GetText();
            }

           
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            Visit(context.type());

            father = myFather;
            return null;
        }
        
        public override Object VisitProgramAST([NotNull] MyParser.ProgramASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);


            if (context.consDecl() != null) {

                for (int i = 0; i < context.consDecl().Length; i++)
                {
                    
                    Visit(context.consDecl(i));
                    
                }
            }
            if (context.varDecl() != null)
            {
                for (int i = 0; i < context.varDecl().Length; i++)
                {
                    Visit(context.varDecl(i));
                }
            }
            if (context.classDecl() != null)
            {
                for (int i = 0; i < context.classDecl().Length; i++)
                {
                    Visit(context.classDecl(i));
                }
            }
            if (context.methodDecl() != null)
            {
                for (int i = 0; i < context.methodDecl().Length; i++)
                {
                    Visit(context.methodDecl(i));
                }
            }
            
            father = myFather;
            return null;
        }
    
        public override Object VisitMethodDeclAST([NotNull] MyParser.MethodDeclASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);


            if(context.type() != null){
                Visit(context.type());
            }

            if(context.formPars() != null){
                Visit(context.formPars());
            }

            if(context.varDecl() != null){
                for(int i = 0; i < context.varDecl().Length; i++){
                    Visit(context.varDecl(i));
                }
            }

            if(context.block() != null){
                Visit(context.block());
            }


            father = myFather;
            return null;
        }

        public override Object VisitTypeAST([NotNull] MyParser.TypeASTContext context)
        {            
            PrintableNode nn = new PrintableNode();
            nn.text = context.ID().GetText();
            nn.father = father;         
            tree.Add(nn);                     
            return null;
        }

        public override Object VisitFormParsAST([NotNull] MyParser.FormParsASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if(context.type() != null){
                for (int i = 0; i < context.type().Length; i++)
                {
                    Visit(context.type(i));
                }
            }

            father = myFather;
            return null;
        }

        public override Object VisitActParsAST([NotNull] MyParser.ActParsASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.expr() != null)
            {
                for (int i = 0; i < context.expr().Length; i++)
                {
                    Visit(context.expr(i));
                }
            }
            
            father = myFather;
            return null;
        }

        public override Object VisitDesignatorAST([NotNull] MyParser.DesignatorASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if(context.expr() != null){
                for (int i = 0; i < context.expr().Length; i++){
                    Visit(context.expr(i));
                }
            }

            father = myFather;
            return null;
        }

        public override Object VisitCondFactAST([NotNull] MyParser.CondFactASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.expr(0) != null) {
                Visit(context.expr(0));
            }

            if (context.relop() != null) {
                Visit(context.relop());
            }

            if (context.expr(1) != null)
            {
                Visit(context.expr(1));
            }

            father = myFather;
            return null;
        }

        public override Object VisitConditionAST([NotNull] MyParser.ConditionASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);
         
            if (context.condterm() != null)
            {
                for (int i = 0; i < context.condterm().Length; i++)
                {
                    Visit(context.condterm(i));
                }
            }
            father = myFather;
            return null;
        }

        public override Object VisitStatementREADAST([NotNull] MyParser.StatementREADASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);            

            if (context.designator() != null){
                Visit(context.designator());
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementFORAST([NotNull] MyParser.StatementFORASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);            

            if (context.expr() != null) {
                Visit(context.expr());
            }

            if(context.condition() != null){
                Visit(context.condition());
            }

            if (context.statement(0) != null) {
                Visit(context.statement(0));
            }

            if (context.statement(1) != null)
            {
                Visit(context.statement(1));
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementWHILEAST([NotNull] MyParser.StatementWHILEASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.condition() != null)
            {
                Visit(context.condition());
            }

            if (context.statement() != null)
            {
                Visit(context.statement());
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementWRITEAST([NotNull] MyParser.StatementWRITEASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);
            
            if(context.expr() != null){
                Visit(context.expr());
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementBlockAST([NotNull] MyParser.StatementBlockASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.block() != null) {
                Visit(context.block());
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementDesignatorAST([NotNull] MyParser.StatementDesignatorASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);
            

            if(context.designator() != null){
                Visit(context.designator());
            }

            if(context.expr() != null){
                Visit(context.expr());
            }

            if(context.actPars() != null){
                Visit(context.actPars());
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementRETURNAST([NotNull] MyParser.StatementRETURNASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if(context.expr() != null){
                Visit(context.expr());
            }

            father = myFather;
            return null;
        }

        public override Object VisitStatementPyCOMEAST([NotNull] MyParser.StatementPyCOMEASTContext context)
        {
            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;            
            tree.Add(nn);
            return null;
        }

        public override Object VisitStatementBREAKAST([NotNull] MyParser.StatementBREAKASTContext context)
        {            
            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;            
            tree.Add(nn);            
            return null;
        }

        public override Object VisitStatementIFAST([NotNull] MyParser.StatementIFASTContext context)
        {

            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);
                       

            if(context.condition() != null){
                Visit(context.condition());
            }

            if(context.statement(0) != null){
                Visit(context.statement(0));
            }

            if(context.statement(1) != null){
                Visit(context.statement(1));
            }        


            father = myFather;
            return null;
        }

        public override Object VisitBlockAST([NotNull] MyParser.BlockASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);            

            if (context.statement() != null) {
                for (int i = 0; i < context.statement().Length; i++) {
                    Visit(context.statement(i));
                }
            }

            father = myFather;
            return null;
        }

        public override Object VisitCondtermAST([NotNull] MyParser.CondtermASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.condFact() != null)
            {
                for (int i = 0; i < context.condFact().Length; i++)
                {
                    Visit(context.condFact(i));
                }
            }

            father = myFather;
            return null;
        }

        public override Object VisitExprAST([NotNull] MyParser.ExprASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.term(0) != null)
            {
                Visit(context.term(0));
            }

            for (int i = 0; i < context.addop().Length; i++)
            {
                Visit(context.addop(i));
                Visit(context.term(i + 1));
            }

            father = myFather;
            return null;
        }

        public override Object VisitTermAST([NotNull] MyParser.TermASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if(context.factor(0) != null){
                Visit(context.factor(0));
            }

            for (int i = 0; i < context.mulop().Length; i++) {
                Visit(context.mulop(i));
                Visit(context.factor(i+1));
            }

                father = myFather;
            return null;
        }

        public override Object VisitFactorCHARCONSTAST([NotNull] MyParser.FactorCHARCONSTASTContext context)
        {
            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;
            tree.Add(nn);
            return null;
        }

        public override Object VisitFactorNEWAST([NotNull] MyParser.FactorNEWASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.expr() != null) {
                Visit(context.expr());
            }

            father = myFather;
            return null;
        }

        public override Object VisitFactorNUMAST([NotNull] MyParser.FactorNUMASTContext context)
        {
            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;
            tree.Add(nn);                        
            return null;
        }

        public override Object VisitFactorTrueFalseAST([NotNull] MyParser.FactorTrueFalseASTContext context)
        {
            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;
            tree.Add(nn);
            return null;
        }

        public override Object VisitFactorDesignatorAST([NotNull] MyParser.FactorDesignatorASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if(context.designator() != null){
                Visit(context.designator());
            }

            if(context.actPars() != null){
                Visit(context.actPars());
            }

            father = myFather;
            return null;
        }

        public override Object VisitFactorExprAST([NotNull] MyParser.FactorExprASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();
            nn.text = context.GetType().Name;
            nn.father = father;

            father = tree.Count;
            tree.Add(nn);

            if (context.expr() != null)
            {
                Visit(context.expr());
            }

            father = myFather;
            return null;
        }

        public override Object VisitVarDeclAST([NotNull] MyParser.VarDeclASTContext context)
        {
            int myFather = father;

            PrintableNode nn = new PrintableNode();

            string text = "";
            for (int i = 0; i < context.ID().Length; i++)
            {
                text = text + context.ID(i).GetText() + ", ";
            }
            nn.text = context.GetType().Name;                    



            nn.father = father;

            father = tree.Count;
            tree.Add(nn);
           
            Visit(context.type());

            father = myFather;
            return null;
        }
    }
}
