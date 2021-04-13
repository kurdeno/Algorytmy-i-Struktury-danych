using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void b1_Click(object sender, EventArgs e)
        {
            int wynik = Fib1(Convert.ToInt32(tb.Text));
            l.Text = Convert.ToString(wynik);
        }
        private void b2_Click(object sender, EventArgs e)
        {
            int wynik = Fib2(Convert.ToInt32(tb.Text));
            l.Text = Convert.ToString(wynik);
        }
        private void b3_Click(object sender, EventArgs e)
        {
            int wynik = Fib3(Convert.ToInt32(tb.Text));
            l.Text = Convert.ToString(wynik);
        }
        private void b4_Click(object sender, EventArgs e)
        {
            int wynik = NWD(Convert.ToInt32(tb2.Text), Convert.ToInt32(tb3.Text));
            l2.Text = Convert.ToString(wynik);
        }
        private void b5_Click(object sender, EventArgs e)
        {

            int[] T = Konwertuj(tb4.Text);

            MergeSort(T, 0, T.Length - 1);
            l3.Text = string.Join(" ", T);

        }
        private void b6_Click(object sender, EventArgs e)
        {
            int[] T = Konwertuj(tb4.Text);

            SortowanieB(T);
            l3.Text = string.Join(" ", T);
        }

        private int Fib1(int i)
        {
            if (i == 0)
                return 0;
            if (i == 1)
                return 1;

            return Fib1(i-1)+Fib1(i-2);
        }
        private int Fib2(int i)
        {
            List<int> wynik = new List<int>() {0, 1};
            for (int j = 2; j <= i; j++)
            {
                wynik.Add(wynik[j - 1] + wynik[j - 2]);
            }
            return wynik[i];
        }

        private int Fib3(int i)
        {
            int m1 = 1, m2 = 0, wynik = 0;

            for (int j = 2; j <= i; j++)
            {
                wynik = m1 + m2;
                m2 = m1;
                m1 = wynik;
            }
            return wynik;
        }

        private int NWD(int a, int b)
        {
            int t = a % b;
            if (t == 0)
                return b;
            return NWD(b,t);        
        }

        private void MergeSort(int[] T,int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int srodek = (lewy + prawy) / 2;
                MergeSort(T, lewy, srodek);
                MergeSort(T, srodek + 1, prawy);
                Merge(T, lewy, srodek, prawy);
            }
        }
        void Merge(int[] T, int lewy, int sr, int prawy)
        {
            int[] nowaT = new int[T.Length];
            for (int i = 0; i < T.Length; i++)
            {
                nowaT[i] = T[i];
            }
            int flag1 = lewy, flag2 = sr + 1, x = lewy;
            while (flag1 <= sr && flag2 <= prawy)
            {
                if (nowaT[flag1] <= nowaT[flag2])
                {
                    T[x] = nowaT[flag1];
                    flag1++;
                }
                else
                {
                    T[x] = nowaT[flag2];
                    flag2++;
                }
                x++;
            }
            while (flag1 <= sr)
            {
                T[x] = nowaT[flag1];
                x++;
                flag1++;
            }
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
