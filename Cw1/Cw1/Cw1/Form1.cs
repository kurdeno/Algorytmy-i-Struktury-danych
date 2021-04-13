using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            int[] T = Konwertuj(tb1.Text);

            SortowanieB(T);
            l1.Text = string.Join(" ", T);
        }

        private void SortowanieB(int[] tab)
        {
            bool czyZamiana = false;

            do
            {
                czyZamiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        var tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        czyZamiana = true;
                    }
                }
            } while (czyZamiana);
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
    }
}
