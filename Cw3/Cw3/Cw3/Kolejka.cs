using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    public class Kolejka : SD, IAiSD
    {

        public Kolejka() : base()
        {

        }
        public override int Pop()
        {
            int a = this.T[0];
            int[] nowaT = new int[this.T.Length - 1];
            for (int i = 0; i < this.T.Length - 1; i++)
            {
                nowaT[i] = this.T[i + 1];
            }
            this.T = nowaT;
            return a;
        }
    }
}
