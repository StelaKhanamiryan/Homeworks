using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    public class Class
    {
        public Func<int, int, int, int, int, int> maxNumber = delegate (int a, int b, int c, int d, int e)
        {
            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;
            //if (d > max) max = d;
            //if (e > max) max = e;
            //return max;

            return Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));

        };
    }
}
