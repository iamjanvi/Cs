using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    class employee
    {
        int empCode;
        String empName;
        Single salary;
        public employee()
        {
        }

        public employee(int Ecode)
        {
            empCode = Ecode;
        }

        public employee(int Ecode,String Ename,Single sal)
        {
            empCode = Ecode;
            empName = Ename;
            salary = sal;

        }

        public String showdata()
        {
            String str;
            str = "EmpCode: " + empCode + "\nName:" + empName + "\nsalary:" + salary;
            return str;
        }
    }
}
