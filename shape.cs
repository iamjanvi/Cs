using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    abstract class shape
    {
        public virtual int area()
        {
            return 0;
        }

        public virtual int perimeter()
        {
            return 0;
        }
    }
}
