using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    class circle:shape
    {
        int r;

        public override int area()
        {
            return Convert.ToInt16(Math.PI*r*r);
        }

        public override int perimeter()
        {
            return Convert.ToInt16(2*Math.PI * r );
        }

        public circle(int radius)
        {
            r=radius;
        }
    }
}
