using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    public abstract class SD
    {
        protected int[] T;
        public int Length => this.T.Length;
        public SD()
        {
            this.T = new int[0];
        }

        public void Push(int wartosc)
        {
            int[] nowa = Przepisz();
            nowa[nowa.Length - 1] = wartosc;
            this.T = nowa;

        }
        public abstract int Pop();
        int[] Przepisz()
        {
            int[] nowaT = new int[this.T.Length + 1];
            for (int i = 0; i < this.T.Length; i++)
            {
                nowaT[i] = this.T[i];
            }
            return nowaT;
        }
        public int this[int index]

        {
            get
            {
                return this.T[index];
            }
            set
            {
                this.T[index] = value;
            }
        }
    }
}
