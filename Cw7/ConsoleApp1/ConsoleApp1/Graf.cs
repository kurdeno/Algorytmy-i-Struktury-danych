using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Graf
    {
        public List<Node> nodes;
        public List<Krawedz> krawedzie;
        List<Node> odwiedzone;
        List<Node> kolejka;

        public Graf()
        {
            this.nodes = new List<Node>();
            this.krawedzie = new List<Krawedz>();
        }

        public List<Krawedz> ZnajdzKrawedz(Node n)
        {
            List<Krawedz> wynik = new List<Krawedz>();
            for (int i = 0; i < this.krawedzie.Count; i++)
            {
                var k = this.krawedzie[i];
                if (k.start == n || k.koniec == n)
                {
                    wynik.Add(this.krawedzie[i]);
                }
            }
            return wynik;
            //return this.krawedzie.Where(k => k.start == n || k.koniec == n).ToList();
        }
        public bool CzyNalezy(List<Node> lista, Node n)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == n)
                    return true;
            }
            return false;
            //return lista.Contains(n);
        }

        public void PrzechodzenieDFS(Node start)
        {
            this.odwiedzone = new List<Node>();
            this.DFS(start);
            foreach (var x in this.odwiedzone)
                Console.Write(x.wartosc + " ");

        }
        void DFS(Node n)
        {
            if (this.odwiedzone.Contains(n))
                return;
            this.odwiedzone.Add(n);
            var krawedzieOd = this.ZnajdzKrawedz(n);
            foreach (var k in krawedzieOd)
            {
                var drugi = k.ZnajdzDrugi(n);
                DFS(drugi);
            }
        }

        public void PrzechodzenieBFS(Node start)
        {
            this.odwiedzone = new List<Node>();
            this.kolejka = new List<Node>() { start };

            for (int i = 0; i < this.kolejka.Count; i++)
            {
                BFS(this.kolejka[i]);
            }
            foreach (var x in this.odwiedzone)
                Console.Write(x.wartosc + " ");
            Console.Write("\n");
            foreach (var x in this.kolejka)
                Console.Write(x.wartosc + " ");
        }
        void BFS(Node n)
        {
            if (this.odwiedzone.Contains(n))
                return;
            this.odwiedzone.Add(n);
            foreach (var k in ZnajdzKrawedz(n))
                this.kolejka.Add(k.ZnajdzDrugi(n));
        }

        public void Dji(Node start)
        {
            this.odwiedzone = new List<Node>() { start };
            Dictionary<Node, Para> tabelka = new Dictionary<Node, Para>();
            var KrawedzieOd = ZnajdzKrawedz(start);
            for (int i = 0; i < KrawedzieOd.Count(); i++)
            {
                tabelka.Add(KrawedzieOd[i].ZnajdzDrugi(start), new Para(start, KrawedzieOd[i].waga));
            }
            while (true)
            {
                var element = tabelka.OrderBy(x => x.Value.odleglosc).FirstOrDefault(x => !this.odwiedzone.Contains(x.Key));
                if (element.Key == null)
                    break;  //jak nie break to wywołuje metode która obskoczy jeden node i odl
                //Metoda(element.Key, element.Value.odleglosc);
                this.odwiedzone.Add(element.Key);
                KrawedzieOd = ZnajdzKrawedz(element.Key);

                for (int i = 0; i < KrawedzieOd.Count(); i++)
                {
                    if (odwiedzone.Contains(KrawedzieOd[i].ZnajdzDrugi(element.Key)))
                        continue;
                    if (tabelka.Keys.Contains(KrawedzieOd[i].ZnajdzDrugi(element.Key)))
                    {
                        if (tabelka[KrawedzieOd[i].ZnajdzDrugi(element.Key)].odleglosc > KrawedzieOd[i].waga + element.Value.odleglosc)
                        {
                            tabelka[KrawedzieOd[i].ZnajdzDrugi(element.Key)] = new Para(element.Key, KrawedzieOd[i].waga + element.Value.odleglosc);
                        }
                    }
                    else
                    {
                        tabelka.Add(KrawedzieOd[i].ZnajdzDrugi(element.Key), new Para(element.Key, KrawedzieOd[i].waga + element.Value.odleglosc));
                    }
                }

            }
            foreach (var x in tabelka)
            {
                Console.Write(x.Key.wartosc + " " + x.Value.prev.wartosc + " " + x.Value.odleglosc + "\n");
            }
        }

        //1
        public Graf(Krawedz k)
        {
            this.nodes = new List<Node>() { k.start, k.koniec };
            this.krawedzie = new List<Krawedz>() { k };
        }
        //2
        public List<Node> DodajKrawedz(Krawedz k)
        {
            this.krawedzie.Add(k);
            List<Node> tmp = new List<Node>();
            if (!this.nodes.Contains(k.start))
            {
                this.nodes.Add(k.start);
                tmp.Add(k.start);
            }
            if (!this.nodes.Contains(k.koniec))
            {
                this.nodes.Add(k.koniec);
                tmp.Add(k.koniec);
            }
            return tmp;
        }
        //3
        public int SprawdzKrawedz(Krawedz k)
        {
            int wynik = 0;
            if (!this.nodes.Contains(k.start))
                wynik++;
            if (!this.nodes.Contains(k.koniec))
                wynik++;
            return wynik;
        }
        //4
        public void Polacz(Graf g)
        {
            this.nodes.AddRange(g.nodes);
            this.krawedzie.AddRange(g.krawedzie);
        }

        public void Kruskal()
        {
            var S = this.krawedzie;
            var L = this.nodes;
            this.krawedzie = new List<Krawedz>();
            this.nodes = new List<Node>();

            var k = S.OrderBy(x => x.waga).First();
            Polacz(new Graf(k));
            S.Remove(k);

            List<Graf> pom = new List<Graf>();

            while (S.Count > 0 && this.nodes.Count() < L.Count())
            {
                k = S.OrderBy(x => x.waga).First();
                S.Remove(k);
                for (int i = 0; i < pom.Count; i++)
                {
                    if ((this.nodes.Contains(k.start) && pom[i].nodes.Contains(k.koniec)) || (this.nodes.Contains(k.koniec) && pom[i].nodes.Contains(k.start)))
                    {
                        this.krawedzie.Add(k);
                        Polacz(pom[i]);
                        pom.Remove(pom[i]);
                    }
                }
                if (SprawdzKrawedz(k) == 0)
                {
                    continue;
                }
                if (SprawdzKrawedz(k) == 1)
                {
                    DodajKrawedz(k);
                }
                if (SprawdzKrawedz(k) == 2)
                {
                    pom.Add(new Graf(k));
                }
            }
            foreach (var x in this.krawedzie)
                Console.WriteLine(x);
        }
        public Graf(Node x)
        {
            this.nodes = new List<Node>() { x };
            this.krawedzie = new List<Krawedz>();
        }

        List<Krawedz> kollejka;
        public Graf StartPrim(Node start)
        {
            Node n = start;
            var mDrzewo = new Graf(start);
            kollejka = new List<Krawedz>();
            while (true)
            {
                PrimNode(n);
                if (kollejka.Count < 1)
                    break;
                var k = this.kollejka.OrderBy(x => x.waga).FirstOrDefault();
                var tmp = mDrzewo.DodajKrawedz(k);
                n = tmp.First();
            }
            return mDrzewo;
        }
        void PrimNode(Node n)
        {
            var kr = this.ZnajdzKrawedz(n);
            foreach (var k in kr)
            {
                if (this.kollejka.Contains(k))
                    this.kollejka.Remove(k);
                else
                    this.kollejka.Add(k);
            }
        }

    }
}