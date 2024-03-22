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


namespace unit3
{
    public partial class Database_logintable : Form
    {
        public Database_logintable()
        {
            InitializeComponent();
        }
        public static SqlConnection cn;
        SqlCommand cmd;

        private void Database_logintable_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asus\\Documents\\db.mdf;Integrated Security=True;Connect Timeout=30";
            cn.Open();
            MessageBox.Show(cn.State.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "select UName from Login where Uname = '" + textBox1.Text + "'";
            cmd.Connection = cn;
            string usernam, pass;
            usernam = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "select Upass from Login where UPass = '" + textBox2.Text + "' ";
            pass = Convert.ToString(cmd.ExecuteScalar());
            if (pass != "")
            {
                if (pass == textBox2.Text && usernam == textBox1.Text)
                {
                    Database_login2 frm = new Database_login2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error!!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter Password", "Information!!");
               
                textBox1.Text = "";
                textBox2.Focus();
            }
        }
    }
}
