using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieX
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] tab = new int[10];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = random.Next(-50, 50);
            Console.WriteLine("Przed :");
            Console.WriteLine(string.Join(" ", tab));

            //BoubleSort(tab);
            //CountingSort(tab);
            //SelectSort(tab);
            //InsertSort(tab);
            //StartQuickSort(tab);
            MergeSort(tab, 0, tab.Length - 1);
            Console.WriteLine("Po :");
            Console.WriteLine(string.Join(" ", tab));

            Console.ReadKey();
        }


        static void BoubleSort(int[] tab)
        {
            bool zmiana = true;
            do
            {
                zmiana = false;
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int pom = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = pom;
                        zmiana = true;
                    }
                }
            } while (zmiana);
        }
        static void CountingSort(int[] tab)
        {
            int min = Math.Abs(tab.Min());
            int max = Math.Abs(tab.Max());
            int[] czestos = new int[min + max + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                czestos[tab[i]+ min]++;
            }
            int x = 0;
            for (int i = 0; i < czestos.Length; i++)
            {
                while (czestos[i] > 0)
                {
                    tab[x++] = i- min;
                    czestos[i]--;
                }
            }
        }
        static void SelectSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int min_value = int.MaxValue;
                int min_ind = 0;
                for (int j = i; j < tab.Length; j++)
                {
                    if (min_value > tab[j])
                    {
                        min_value = tab[j];
                        min_ind = j;
                    }
                }
                tab[min_ind] = tab[i];
                tab[i] = min_value;
            }
        }
        static void InsertSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int x = tab[i];
                int j = i - 1;
                while(j>=0&& tab[j]>x)
                {
                    tab[j + 1] = tab[j--];
                }
                tab[j + 1] = x;
            }
        }
        static void StartQuickSort(int[] tab)
        {
            QuickSort(tab, 0, tab.Length - 1);
        }
        static void QuickSort(int[] tab, int left, int right)
        {
            int i = left;
            int j = right;
            int piv = tab[(left + right) / 2];
            while (i < j)
            {
                while (tab[i] < piv) i++;
                while (tab[j] > piv) j--;
                if (i <= j)
                {
                    int pom = tab[i];
                    tab[i++] = tab[j];
                    tab[j--] = pom;
                }
            }
            if (left < j)
                QuickSort(tab, left, j);
            if (i < right)
                QuickSort(tab, i, right);
        }
        static void MergeSort(int[] T, int left, int right)
        {
            if (left < right)
            {
                int sr = (left + right) / 2;
                MergeSort(T, left, sr);
                MergeSort(T, sr + 1, right);
                Merge(T, left, sr, right);
            }

        }
        static void Merge(int[] T, int left, int sr, int right)
        {
            int[] nowaT = new int[T.Length];
            for (int i = 0; i < nowaT.Length; i++)
            {
                nowaT[i] = T[i];
            }
            int flag1 = left, flag2 = sr + 1, x = left;
            while (flag1 <= sr && flag2 <= right)
            {
                if (nowaT[flag1] < nowaT[flag2])
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
    }
}
