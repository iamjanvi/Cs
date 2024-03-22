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
    public partial class constructor_Overlooading : Form
    {
        public constructor_Overlooading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee e1 = new employee();
            MessageBox.Show(e1.showdata());

            employee e2 = new employee(5);
            MessageBox.Show(e2.showdata());

            employee e3 = new employee(5,"ABCD",25000);
            MessageBox.Show(e3.showdata());
        }

        private void constructor_Overlooading_Load(object sender, EventArgs e)
        {

        }
    }
}
