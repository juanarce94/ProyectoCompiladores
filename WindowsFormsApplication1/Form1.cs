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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public static StringBuilder errores = new StringBuilder();
        private List<PrintableNode> printableTree = new List<PrintableNode>();
            
        public Form1()
        {
            InitializeComponent();
            initiate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void initiate(){

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

                this.consoleTextBox.Text = this.consoleTextBox.Text + errores.ToString();

                //Console.WriteLine(tree.ToStringTree(parser));
                TreeViewPrint imprimir = new TreeViewPrint();
                imprimir.Visit(tree);
                //Console.WriteLine("-----------------------------impresion------------------------------------");

                printableTree = imprimir.getPrintableTree();

                //Console.WriteLine("index\tFather\t| Name");
                //Console.WriteLine("___________________________________________________________________________");
                //for (int i = 0; i < pTree.Count; i++)
                //{
                    //Console.WriteLine(i + "|\t " + pTree[i].father + "\t| " + pTree[i].text);
                    //Console.WriteLine("___________________________________________________________________________");
                //}


            }
            catch (Exception e)
            {
                //Console.Write(e.Message);
            }
            finally
            {
                //Console.ReadKey();
                archivoPrueba.Close();
            }

        }

        private void imprimirArbolDeSintaxisToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SintaxisTreeView stv = new SintaxisTreeView(this.printableTree);
            stv.Show();


        }

    }
}
