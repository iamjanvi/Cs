using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    class sqaure:shape
    {
        int l;
        public override int area()
        {
            return l * l;
        }

        public override int perimeter()
        {
            return 4 * l;
        }

        public sqaure(int length)
        {
            l = length;
        }
    }
}
