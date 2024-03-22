using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    class rectangle:shape
    {


        int l, b;

        public override int area()
        {
            return l * b;

        }

        public override int perimeter()
        {
            return 2 * (l + b);
        }

        public rectangle(int length,int bredth)
        {
            l = length;
            b = bredth;
        }
    }
}
