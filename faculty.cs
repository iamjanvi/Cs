using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    class faculty:person
    {
        String degree;
        String salary;

        public void getdetails(String _name, String _city, String _email,String _degree,String _salary)
        {
            base.getdetails(_name, _city, _email);
            degree = _degree;
            salary = _salary;
        }

        public override string showdetails()
        {
            String str;
            str = base.showdetails();
            str = str + "\nDegree: " + degree + "\nSalary:" + Convert.ToString(salary);
            return str;
        }
    }
}
