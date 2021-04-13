using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        void ShowNode(Wezel node, TreeNode treeNode)
        {
            treeNode.Text += node.wartosc;
            if (node.lewe != null)
            {
                ShowNode(node.lewe, treeNode.Nodes.Add("Lewe: "));
            }
            if (node.prawe != null)
            {
                ShowNode(node.prawe, treeNode.Nodes.Add("Prawe: "));
            }
        }
        void Show(Drzewo tree)
        {
            ShowNode(tree.korzen, treeView1.Nodes.Add("Korzen: "));
        }

        private void InitializeTreeView()
        {
            Drzewo tree1 = new Drzewo(1);

            for (int i = 2; i <=8; i++)
            {
                tree1.Push(i);
            }
            
            treeView1.BeginUpdate();
            Show(tree1);
            Console.WriteLine("Głębokość drzewa : " + tree1.glebokosc);
            Console.WriteLine("Wartość z Pop()'a : " + tree1.Pop());
            Show(tree1);
            Console.WriteLine("Głębokość drzewa : " + tree1.glebokosc);
            //Console.WriteLine("Długość drzewa : " + tree1.length);
            treeView1.EndUpdate();
        }
    }
}
