using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoCompi
{
    public partial class Form1 : Form
    {

        public static StringBuilder errores = new StringBuilder();

        private string texto;

        public Form1()
        {
            InitializeComponent();
            inicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicio() {
    
            System.IO.StreamReader archivoPrueba;
            archivoPrueba = new System.IO.StreamReader("C:/prueba.txt");
            AntlrInputStream input = new AntlrInputStream(archivoPrueba);

            try
            {

                MyLexer lexer = new MyLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                MyParser parser = new MyParser(tokens);

                //impresion de los tokens
              
                
                texto = richTextBox1.Text;
                richTextBox1.Text = texto + "Tokens:\n";

                IList<IToken> tokensIList = lexer.GetAllTokens();

                foreach (IToken i in tokensIList)
                {
                    
                    texto = richTextBox1.Text;
                    richTextBox1.Text = texto + i.Text + "  ID: " + i.Type +"\n";

                }

                /*
                //quita los errores por defecto y agrega los mios
                parser.RemoveErrorListeners();
                parser.AddErrorListener(MyErrorListener.INSTANCE);                

                IParseTree arbol = parser.program();
                //Console.WriteLine(arbol.ToString());

                richTextBox1.Text = richTextBox1.Text + errores + "\n";
                 * */
            }
            catch (Exception e)
            {

            }
           
        
        }
    }
}
