using Antlr4.Runtime;
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

                parser.RemoveErrorListeners();
                parser.AddErrorListener(MyErrorListener.INSTANCE);
                parser.program();

               /* Console.WriteLine("Aqui");
                
                IList<IToken> listaTokens = lexer.GetAllTokens();
                foreach (IToken t in listaTokens)
                {
                    Console.WriteLine("Lexema: " + t.Text + "   Token: " + t.Type);
                }
                */
                
                //parser.program();

                Console.WriteLine("-------------------------Errores-----------------");

 
                //IParseTree tree = parser.program();
                //Console.WriteLine(tree.ToStringTree(parser));
                //PrettyPrint imprimir = new PrettyPrint(null);
                //imprimir.Visit(tree);
                Console.Write(errores.ToString());

                parser.program();
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
