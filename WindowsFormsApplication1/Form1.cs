using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private String DEFAULT_FILES_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\proyectoCompiJuanDaryn"; 

        private RichTextBox selectedTextBox;        
            
        public Form1()
        {
            InitializeComponent();
            
            //se crea el folder donde se guardan los archivos por defecto            
            System.IO.Directory.CreateDirectory(DEFAULT_FILES_PATH);
            
            //initiate();
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


        private void compilarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            String name = DEFAULT_FILES_PATH + "\\" + this.tabControl1.SelectedTab.Text + ".txt";
            TextWriter tw = null;
            if (File.Exists(name))
            {
                MessageBox.Show("exist");                
            }
            else 
            {
                MessageBox.Show("not exist");
                tw = new StreamWriter(name);
            }

            if (this.selectedTextBox == null) return;

            try {
                System.IO.File.WriteAllText(name, this.selectedTextBox.Text);            
            }
            catch(Exception a){
                MessageBox.Show("Can't compile file. File may be in use\n" + a.Message);
            }
                

            this.consoleTextBox.Text = "";
            errores = new StringBuilder();

            System.IO.StreamReader archivo;
            archivo = new System.IO.StreamReader(name);
            

            AntlrInputStream input = new AntlrInputStream(archivo);
            String codeString = this.selectedTextBox.Text;


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
            catch (Exception exception) { }
            finally {
                archivo.Close();
            }
                                        
        }


        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarLineaColumna();
        }

        private void actualizarLineaColumna() {
            if (selectedTextBox != null)
            {
                int index = this.selectedTextBox.SelectionStart;
                int line = this.selectedTextBox.GetLineFromCharIndex(index);

                int firstChar = this.selectedTextBox.GetFirstCharIndexFromLine(line);
                int column = index - firstChar;

                toolStripStatusLabel1.Text = "Columna: " + column.ToString();
                toolStripStatusLabel2.Text = "Linea: " + line.ToString();
            }        
        }

        private void genericRichTextBox_Click(object sender, System.EventArgs e)
        {
            this.selectedTextBox = (RichTextBox)sender;
            this.actualizarLineaColumna();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "File" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
          
            RichTextBox rt = new RichTextBox();
            
            rt.Dock = System.Windows.Forms.DockStyle.Fill;
            rt.Click += new EventHandler(genericRichTextBox_Click);

            this.selectedTextBox = rt;
            myTabPage.Controls.Add(rt);

            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
        }



        private void tabControl1_Click(object sender, EventArgs e)
        {
            actualizarLineaColumna();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

    }
}
