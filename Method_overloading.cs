using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit3
{
    public partial class Method_overloading : Form
    {
        public Method_overloading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.getdata(1);
            obj.getdata(2, "prograamming in c#.net");
            obj.getdata(3, "mastering .net", 575);
        }
    }
}
