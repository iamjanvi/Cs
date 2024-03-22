using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace unit3
{
    public partial class Database_Booktable : Form
    {
        public Database_Booktable()
        {
            InitializeComponent();
        }
        public static SqlConnection cn = new SqlConnection();
        public static SqlDataAdapter da = new SqlDataAdapter("select * from Book", cn);
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);

        int pos;
        Boolean addmode;






        private void Database_Booktable_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asus\\Documents\\db.mdf;Integrated Security=True;Connect Timeout=30";
            cn.Open();
            da.Fill(ds, "Book");
            pos = 0;
            showData();
        }


        private void showData()
        {
            textBox1.Text = ds.Tables[0].Rows[pos].ItemArray[0].ToString();
             textBox2.Text = ds.Tables[0].Rows[pos].ItemArray[1].ToString();
            textBox3.Text = ds.Tables[0].Rows[pos].ItemArray[2].ToString();
            textBox4.Text = ds.Tables[0].Rows[pos].ItemArray[3].ToString();
            textBox5.Text = ds.Tables[0].Rows[pos].ItemArray[4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pos < ds.Tables[0].Rows.Count - 1)
            {
                pos = pos + 1;
                showData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = ds.Tables[0].Rows.Count - 1;
            showData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
            addmode = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (addmode == true)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = textBox1.Text;
                dr[1] = textBox2.Text;
                dr[2] = textBox3.Text;
                dr[3] = textBox4.Text;
                dr[4] = textBox5.Text;
                ds.Tables[0].Rows.Add(dr);
                da.Update(ds, "Book");
                addmode = false;
                MessageBox.Show("Record inserted successfully");
            }
            else  
            {
                DataRow dr = ds.Tables[0].Rows[pos];
                dr[0] = textBox1.Text;
                dr[1] = textBox2.Text;
                dr[2] = textBox3.Text;
                dr[3] = textBox4.Text;
                dr[4] = textBox5.Text;
                da.Update(ds, "Book");
                MessageBox.Show("Record updated successfully");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Are you sure? Do you want to delete this record?", "Confirm!!",
                MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                ds.Tables[0].Rows[pos].Delete();
                da.Update(ds, "Book");
                pos = 0;
                showData();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
