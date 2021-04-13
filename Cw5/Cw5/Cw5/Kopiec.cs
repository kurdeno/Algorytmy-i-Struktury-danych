using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw5
{
    class Kopiec
    {
        public Wezel korzen;
        int lenght = 1;

        public Kopiec(Wezel korzen)
        {
            this.korzen = korzen;
        }
        public void Push(int n)
        {
            Wezel dziecko = new Wezel(n);
            if (korzen == null)
            {
                korzen = dziecko;
                return;
            }
            else
            {
                Wezel rodzic = ZnajdzRodzica(lenght);
                if (lenght % 2 == 1)
                    rodzic.lewe = dziecko;
                else
                    rodzic.prawe = dziecko;
                dziecko.rodzic = rodzic;
                lenght++;
                SortujKopiec(dziecko);
            }
        }
        void SortujKopiec(Wezel n)
        {
            if (n.rodzic == null)
                return;
            else
            {
                if (n.wartosc > n.rodzic.wartosc)
                {
                    int pom = n.wartosc;
                    n.wartosc = n.rodzic.wartosc;
                    n.rodzic.wartosc = pom;
                    SortujKopiec(n.rodzic);
                }
            }
        }
        public void Sortuj()
        {
            for (int i = 0; i < lenght; i++)
            {
                Sort(korzen);
            }
        }
        void Sort(Wezel rodzic)
        {
            if (rodzic == null)
                return;
            if (rodzic.lewe == null && rodzic.prawe == null)
                return;
            if (rodzic.lewe != null && rodzic.prawe == null)
            {
                if (rodzic.wartosc < rodzic.lewe.wartosc)
                {
                    int x = new int();
                    x = rodzic.wartosc;
                    rodzic.wartosc = rodzic.lewe.wartosc;
                    rodzic.lewe.wartosc = x;
                }
                Sort(rodzic.lewe);
                return;
            }
            if (rodzic.lewe == null && rodzic.prawe != null)
            {
                if (rodzic.wartosc < rodzic.prawe.wartosc)
                {
                    int x = new int();
                    x = rodzic.wartosc;
                    rodzic.wartosc = rodzic.prawe.wartosc;
                    rodzic.prawe.wartosc = x;
                }
                Sort(rodzic.prawe);
                return;
            }
            if (rodzic.lewe != null && rodzic.prawe != null)
            {
                if (rodzic.lewe.wartosc > rodzic.prawe.wartosc)
                {
                    if (rodzic.wartosc < rodzic.lewe.wartosc)
                    {
                        int x = new int();
                        x = rodzic.wartosc;
                        rodzic.wartosc = rodzic.lewe.wartosc;
                        rodzic.lewe.wartosc = x;
                    }
                }
                else
                {
                    if (rodzic.wartosc < rodzic.prawe.wartosc)
                    {
                        int x = new int();
                        x = rodzic.wartosc;
                        rodzic.wartosc = rodzic.prawe.wartosc;
                        rodzic.prawe.wartosc = x;
                    }
                }
                Sort(rodzic.lewe);
                Sort(rodzic.prawe);
                return;
            }
        }
        Wezel ZnajdzRodzica(int len)
        {
            List<int> droga = new List<int>();
            int n = len;
            while (n > 0)
            {
                n--;
                n = n / 2;
                droga.Add(n);
            }
            Wezel Rodzic = korzen;
            droga.Reverse();
            for (int i = 1; i < droga.Count; i++)
            {
                if (droga[i] % 2 == 1)
                    Rodzic = Rodzic.lewe;
                else
                    Rodzic = Rodzic.prawe;
            }
            return Rodzic;
        }
        public string WypiszKopiec()
        {
            string wynik = "";
            while (korzen != null)
            {
                wynik += " " + korzen.wartosc.ToString();
                Zmianawartosci(korzen);
            }
            lenght = 1;
            return wynik;
        }
        void Zmianawartosci(Wezel n)
        {
            if (n.lewe == null & n.prawe == null & n == korzen)
            {
                korzen = null;
                return;
            }
            if (n.lewe != null && n.prawe != null)
            {
                if (n.prawe.wartosc > n.lewe.wartosc)
                {
                    n.wartosc = n.prawe.wartosc;
                    if (n.prawe.prawe == null & n.prawe.lewe == null)
                        n.prawe = null;
                    else
                        Zmianawartosci(n.prawe);
                }
                else
                {
                    n.wartosc = n.lewe.wartosc;
                    if (n.lewe.prawe == null & n.lewe.lewe == null)
                        n.lewe = null;
                    else
                        Zmianawartosci(n.lewe);
                    return;
                }
            }
            if (n.lewe != null && n.prawe == null)
            {
                n.wartosc = n.lewe.wartosc;
                if (n.lewe.prawe == null & n.lewe.lewe == null)
                    n.lewe = null;
                else
                    Zmianawartosci(n.lewe);
                return;
            }
            if (n.lewe == null && n.prawe != null)
            {
                n.wartosc = n.prawe.wartosc;
                if (n.prawe.prawe == null & n.prawe.lewe == null)
                    n.prawe = null;
                else
                    Zmianawartosci(n.prawe);
                return;
            }


        }
    }
}

