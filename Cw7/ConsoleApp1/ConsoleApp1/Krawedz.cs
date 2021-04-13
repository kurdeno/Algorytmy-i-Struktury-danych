using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Krawedz
    {
        public Node start;
        public Node koniec;
        public int waga;

        public Krawedz(Node s ,Node k, int w = 1)
        {
            this.start = s;
            this.koniec = k;
            this.waga = w;
        }

        public override string ToString()
        {
            return $"{this.start} - { this.koniec} ({this.waga})";
        }

        public Node ZnajdzDrugi(Node n)
        {
            return n == this.start ? this.koniec : this.start;
        }
    }
}
