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
    public partial class overridefunction : Form
    {
        public overridefunction()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle c = new circle(Convert.ToInt16(textBox1.Text));
            int area = c.area();
            MessageBox.Show("Area of the circle is: " + Convert.ToString(area));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circle c = new circle(Convert.ToInt16(textBox1.Text));
            int peri = c.perimeter();
            MessageBox.Show("perimeter of the circle is: " + Convert.ToString(peri));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqaure s = new sqaure(Convert.ToInt16(textBox2.Text));
            int area = s.area();
            MessageBox.Show("Area of the square is: " + Convert.ToString(area));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqaure s = new sqaure(Convert.ToInt16(textBox2.Text));
            int peri = s.perimeter();
            MessageBox.Show("perimeter of the sqaure is: " + Convert.ToString(peri));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rectangle r = new rectangle(Convert.ToInt16(textBox3.Text),Convert.ToInt16(textBox4.Text));
            int area = r.area();
            MessageBox.Show("area of the rectangle is: " + Convert.ToString(area));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rectangle r = new rectangle(Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text));
            int peri = r.perimeter();
            MessageBox.Show("perimeter of the rectangle is: " + Convert.ToString(peri));

        }
    }
}
