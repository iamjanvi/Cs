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
    public partial class windows_Exploser : Form
    {
        public windows_Exploser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
            refreshListBox();

           
        }

        private void refreshListBox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            String[] dirs;
            dirs = System.IO.Directory.GetDirectories(label2.Text);

            foreach (String str in dirs)
            {
                listBox1.Items.Add(str);

            }
            String[] files;
            files = System.IO.Directory.GetFiles(label2.Text);
            foreach(String str in files)
            {
                listBox2.Items.Add(str);
            }
        }

        private void unit3_7_Load(object sender, EventArgs e)
        {
            String[] drvs;
            drvs = System.IO.Directory.GetLogicalDrives();
            foreach(String str in drvs)
            {
                comboBox1.Items.Add(str);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
            refreshListBox();

        }
    }
}
