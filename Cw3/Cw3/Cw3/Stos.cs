using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    public class Stos : SD, IAiSD
    {
        public Stos() : base()
        {

        }
        public override int Pop()
        {
            int a = this.T[0];
            int[] nowa = new int[this.T.Length - 1];
            for (int i = 0; i < this.T.Length - 1; i++)
            {
                nowa[i] = this.T[i];
            }
            this.T = nowa;
            return a;
        }
    }
}
