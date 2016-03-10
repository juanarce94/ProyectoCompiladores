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

namespace PrototipoCompi
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenFile()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Abrir un archivo";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            DialogResult result = theDialog.ShowDialog();            
            //DialogResult result = 

            if (result == DialogResult.OK) // Test result.
            {
                string file = theDialog.FileName;
                try
                {
                    richTextBox1.Text = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }
            }
        }
        private void NewFile()
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Nuevo archivo";
            theDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult result = theDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                
                using(Stream s = File.Open(theDialog.FileName, FileMode.Create))
                using(StreamWriter sw = new StreamWriter(s))

                try
                {
                    sw.Write(richTextBox1.Text);
                }
                catch (IOException)
                {
                    MessageBox.Show("No se puedo crear el archivo");
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

    }
}
