using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    abstract class person
    {
        String name, city, email;
        public virtual String showdetails()
        {
            String str;
            str = "Name:" + name + "\ncity:" + city + "\nemail:" + email;
            return str;
        }

        protected void getdetails(String _name,String _city, String _email)
        {
            name = _name;
            city = _city;
            email = _email;
        }
    }
}
