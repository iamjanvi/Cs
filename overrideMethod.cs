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
    public partial class overrideMethod : Form
    {
        public overrideMethod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            faculty f = new faculty();
            f.getdetails("ABCD", "Ahmedabad", "abc@gamil.com", "MCA", "25050");
            MessageBox.Show(f.showdetails());

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.getdetails("kush", "rajkot","kush123@gmail.com", "90", "95%");
            MessageBox.Show(s.showdetails());
        }
    }
}
