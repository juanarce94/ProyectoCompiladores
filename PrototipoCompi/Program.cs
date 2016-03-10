using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoCompi
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
            

            /*

            System.IO.StreamReader archivoPrueba;
            archivoPrueba = new System.IO.StreamReader("C:/prueba.txt");
            AntlrInputStream input = new AntlrInputStream(archivoPrueba);

            try
            {

                MyLexer lexer = new MyLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                MyParser parser = new MyParser(tokens);

                //impresion de los tokens
                Console.WriteLine("Tokens:");

                IList<IToken> tokensIList = lexer.GetAllTokens();

                foreach (IToken i in tokensIList)
                {

                    Console.WriteLine("Lexema: " + i.Text + " Type: " + i.Type);

                }


                parser.program();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
            */
        }


    }
}
