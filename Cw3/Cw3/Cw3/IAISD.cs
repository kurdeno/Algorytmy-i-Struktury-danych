using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    interface IAiSD
    {
        int Length { get; }
        void Push(int x);
        int Pop();
    }
}
