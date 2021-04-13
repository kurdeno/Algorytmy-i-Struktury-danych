using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw4
{
    class Drzewo
    {
        public Wezel korzen;
        public int length;
        public int glebokosc;

        public Drzewo(int wartosc)
        {
            this.korzen = new Wezel(wartosc);
            //this.korzen.wartosc = wartosc; wyrzucamy
            this.length = 1;
            this.glebokosc = 0;
        }

        public void Push(int wartosc)
        {
            var dziecko = new Wezel(wartosc);
            var rodzic = this.ZnajdzRodzica(this.length);
            dziecko.rodzic = rodzic;

            if (this.length % 2 == 1)
            {
                rodzic.lewe = dziecko;
            }
            else
            {
                rodzic.prawe = dziecko;
            }
            this.length++;
            this.JakGlebokie();
            //glebokosc  czy sie zwikszyla czy nie, do domu + pop !!!!
        }
        public Wezel ZnajdzRodzica(int numer)
        {
            List<int> droga = new List<int>();

            while (numer > 0)
            {
                numer = (numer - 1) / 2;
                droga.Add(numer);
            }

            droga.Reverse();
            var rodzic = this.korzen;
            for (int i = 1; i < droga.Count; i++)
            {
                if (droga[i] % 2 == 1)
                {
                    rodzic = rodzic.lewe;
                }
                else
                {
                    rodzic = rodzic.prawe;
                }
            }
            return rodzic;
        }       
        public  int Pop()
        {
            var rodzic = this.ZnajdzRodzica(this.length-1);
            int x;
            if (this.length % 2 == 0)
            {
                x = rodzic.lewe.wartosc;
                rodzic.lewe = null;
            }
            else
            {
                x = rodzic.prawe.wartosc;
                rodzic.prawe = null;
            }
            this.length--;
            JakGlebokie();
            return x;
        }
        public int JakGlebokie()
        {
            int glebokosc = 0;
            int dlugosc =this.length;
            while (dlugosc > 0)
            {
                dlugosc /= 2;
                glebokosc++;
            }
            this.glebokosc = glebokosc-1;
            return this.glebokosc;
        }
    }
}

