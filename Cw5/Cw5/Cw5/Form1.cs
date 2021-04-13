using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw5
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
        void Show1(Drzewo tree)
        {
            ShowNode(tree.korzen, treeView1.Nodes.Add("Korzen: "));
        }
        void Show2(Kopiec k)
        {
            ShowNode(k.korzen, treeView1.Nodes.Add("Korzen: "));
        }

        private void InitializeTreeView()
        {

            treeView1.BeginUpdate();
            treeView1.EndUpdate();
        }

        public void b1_Click(object sender, EventArgs e)
        {
            int[] T = Konwertuj(tb1.Text);
            Drzewo tree1 = new Drzewo(T[0]);
            for (int i = 1; i < T.Length; i++)
            {
                tree1.PushBST(T[i], tree1.korzen);

            }
            Show1(tree1);
            tree1.ShowPRE(tree1.korzen);
            tree1.ShowIN(tree1.korzen);
            tree1.ShowPOST(tree1.korzen);

            l1.Text = String.Join(" ", tree1.Pre);
            l2.Text = String.Join(" ", tree1.In);
            l3.Text = String.Join(" ", tree1.Post);

        }


        int[] Konwertuj(string cyfry)
        {
            var wynikS = cyfry.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] wynik = new int[wynikS.Length];
            for (int i = 0; i < wynikS.Length; i++)
            {
                wynik[i] = int.Parse(wynikS[i].Trim());
            }

            return wynik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] T = Konwertuj(tb1.Text);
            Kopiec k = new Kopiec(new Wezel(T[0]));
            for (int i = 1; i < T.Length; i++)
            {
                k.Push(T[i]);

            }
            Show2(k);
            int[] x = Konwertuj(k.WypiszKopiec());
            label1.Text = string.Join(" ", x.Reverse());
        }
    }
}
