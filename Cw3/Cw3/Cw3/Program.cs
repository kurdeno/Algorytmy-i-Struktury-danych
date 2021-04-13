using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stos T1 = new Stos();
            T1.Push(5);
            T1.Push(1);
            T1.Push(8);
            T1.Push(3);
            Console.WriteLine("Stos oryginalny :");
            for (int i = 0; i < T1.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i + 1, T1[i]);
            }
            Console.WriteLine("Stos po Pop'ie:");
            T1.Pop();
            for (int i = 0; i < T1.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i + 1, T1[i]);
            }
            Kolejka T2 = new Kolejka();
            T2.Push(7);
            T2.Push(2);
            T2.Push(5);
            T2.Push(9);
            Console.WriteLine("Kolejka oryginalna :");
            for (int i = 0; i < T2.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i + 1, T2[i]);
            }
            Console.WriteLine("Kolejka po Pop'ie:");
            T2.Pop();
            for (int i = 0; i < T2.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i + 1, T2[i]);
            }
            
            Console.ReadKey();
        }
    }
}
