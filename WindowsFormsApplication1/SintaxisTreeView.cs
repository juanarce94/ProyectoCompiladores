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
    public partial class SintaxisTreeView : Form
    {
        public SintaxisTreeView(List<PrintableNode> tree)
        {
            
            InitializeComponent();
            imprimirArbol(tree);


        }

        private void imprimirArbol(List<PrintableNode> tree)
        {

            if (tree.Count == 0) return;

            treeView1.Nodes.Add(tree[0].text);
            TreeNode firstTreeNode = treeView1.Nodes[0];            
            agregarNodos(firstTreeNode, 0, tree);

            firstTreeNode.ExpandAll();
            


        }

        private void agregarNodos(TreeNode treeNode, int father, List<PrintableNode> tree){

            int cont = -1;

            for (int i = 1; i < tree.Count; i++)
            {
                PrintableNode sonTemp = tree[i];
                int fatherTemp = sonTemp.father;

                if (fatherTemp == father) {
                    cont++;

                    treeNode.Nodes.Add(sonTemp.text);
                    TreeNode newTreeNode = treeNode.Nodes[cont];

                    agregarNodos(newTreeNode, i, tree);

                }
            }
                
        }

    }
}
