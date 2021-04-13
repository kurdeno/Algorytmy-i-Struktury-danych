using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw5
{
    public class Drzewo
    {
        public Wezel korzen;
        public int Length;
        public int glebokosc;
        public List<int> Pre = new List<int>();
        public List<int> In = new List<int>();
        public List<int> Post = new List<int>();
        public Drzewo(int wartosc)
        {
            this.korzen = new Wezel(wartosc);
            this.Length = 1;
            this.glebokosc = 0;
        }
        public void ShowPRE(Wezel w)
        {
            if (w == null)
            {
                return;
            }

            Pre.Add(w.wartosc);
            ShowPRE(w.lewe);
            ShowPRE(w.prawe);
        }
        public void ShowIN(Wezel w)
        {
            if (w == null)
            {
                return;
            }
            ShowIN(w.lewe);
            In.Add(w.wartosc);
            ShowIN(w.prawe);
        }
        public void ShowPOST(Wezel w)
        {
            if (w == null)
            {
                return;
            }
            ShowPOST(w.lewe);
            ShowPOST(w.prawe);
            Post.Add(w.wartosc);
        }
        public void PushBST(int wartosc, Wezel w)
        {
            if (wartosc >= w.wartosc)
            {
                if (w.prawe == null)
                {
                    w.prawe = new Wezel(wartosc);
                }
                else
                {
                    PushBST(wartosc, w.prawe);
                }
            }
            else
            {
                if (w.lewe == null)
                {
                    w.lewe = new Wezel(wartosc);
                }
                else
                {
                    PushBST(wartosc, w.lewe);
                }
            }
        }
        public void Push(int wartosc)
        {
            var dziecko = new Wezel(wartosc);
            var rodzic = this.ZnajdzRodzica(this.Length);
            dziecko.rodzic = rodzic;

            if (this.Length % 2 == 1)
            {
                rodzic.lewe = dziecko;
            }
            else
            {
                rodzic.prawe = dziecko;
            }
            this.Length++;
            this.JakGlebokie();
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
        public int Pop()
        {
            var rodzic = this.ZnajdzRodzica(this.Length - 1);
            int x;
            if (this.Length % 2 == 0)
            {
                x = rodzic.lewe.wartosc;
                rodzic.lewe = null;
            }
            else
            {
                x = rodzic.prawe.wartosc;
                rodzic.prawe = null;
            }
            this.Length--;
            JakGlebokie();
            return x;
        }
        public int JakGlebokie()
        {
            int glebokosc = 0;
            int dlugosc = this.Length;
            while (dlugosc > 0)
            {
                dlugosc /= 2;
                glebokosc++;
            }
            this.glebokosc = glebokosc - 1;
            return this.glebokosc;
        }

    }
}



