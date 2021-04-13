using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tekst 1 : abaabbaaa");
            Console.WriteLine("Tekst 2 : babab");
            Console.WriteLine(NWP("01110001101", "1101010110"));
            Console.ReadKey();
        }
        static string NWP(string slowo1, string slowo2)
        {
            slowo1 = " " + slowo1;
            slowo2 = " " + slowo2;
            int[,] tab = new int[slowo1.Length, slowo2.Length];
            for (int i = 1; i < slowo1.Length; i++)
            {
                for (int j = 1; j < slowo2.Length; j++)
                {
                    if (slowo1[i] == slowo2[j])
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    else
                    {
                        tab[i, j] = (tab[i, j - 1] > tab[i - 1, j]) ? tab[i, j - 1] : tab[i - 1, j];
                    }
                }
            }
            int x = slowo1.Length - 1;
            int y = slowo2.Length - 1;
            string wynik1 = "";
            string wynik2 = "";
            while (x != 0 && y != 0)
            {
                if (tab[x, y] == tab[x - 1, y])
                {
                    x--;
                }
                else if (tab[x, y] == tab[x, y - 1])
                {
                    y--;
                }
                else
                {
                    wynik1 = slowo2[y] + wynik1;
                    x--;
                    y--;
                }
            }
            x = slowo1.Length - 1;
            y = slowo2.Length - 1;
            while (x != 0 && y != 0)
            {
                if (tab[x, y] == tab[x, y - 1])
                {
                    y--;
                }
                else if (tab[x, y] == tab[x - 1, y])
                {
                    x--;
                }
                else
                {
                    wynik2 = slowo2[y] + wynik2;
                    x--;
                    y--;
                }
            }
            for (int i = 0; i < slowo1.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < slowo2.Length; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
            }
            return wynik1 + "\n" + wynik2;
        }
    }

}
