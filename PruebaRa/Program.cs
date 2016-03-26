using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRa
{
    class Program
    {
        public static StringBuilder errores = new StringBuilder();

        static void Main(string[] args)
        {
            
            System.IO.StreamReader archivoPrueba;
            archivoPrueba = new System.IO.StreamReader("C:/prueba.txt");            
            AntlrInputStream input = new AntlrInputStream(archivoPrueba);            
            try
            {
                MyLexer lexer = new MyLexer(input);                
                CommonTokenStream tokens = new CommonTokenStream(lexer);                
                MyParser parser = new MyParser(tokens);
                
                /*Console.WriteLine("Codigo");

                IList<IToken> listaTokens = lexer.GetAllTokens();

                Console.WriteLine("Cantidad de tokens: " + listaTokens.Count);

                foreach (IToken t in listaTokens)
                {
                    Console.WriteLine("Lexema: " + t.Text + "   Token: " + t.Type);
                }
                */
                //parser.program();
                parser.RemoveErrorListeners();
                parser.AddErrorListener(MyErrorListener.INSTANCE);

                IParseTree tree = parser.program();

                Console.WriteLine("------------------------------Errores-------------------------------------");
                Console.Write(errores.ToString());
                
                //Console.WriteLine(tree.ToStringTree(parser));
                TreeViewPrint imprimir = new TreeViewPrint();
                imprimir.Visit(tree);
                Console.WriteLine("-----------------------------impresion------------------------------------");
                
                List<PrintableNode> pTree = imprimir.getPrintableTree();

                Console.WriteLine("index\tFather\t| Name");
                Console.WriteLine("___________________________________________________________________________");
                for (int i = 0; i < pTree.Count; i++)
                {   
                    Console.WriteLine(i + "|\t " + pTree[i].father + "\t| " + pTree[i].text);
                    Console.WriteLine("___________________________________________________________________________");
                }

              
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                Console.ReadKey();
                archivoPrueba.Close();
            }
        }
    }
}
