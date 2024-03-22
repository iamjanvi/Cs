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
    public partial class Database_statetable : Form
    {
        public Database_statetable()
        {
            InitializeComponent();
        }
        SqlConnection cn;

        private void Database_statetable_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asus\\Documents\\db.mdf;Integrated Security=True;Connect Timeout=30";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from State";
            cmd.Connection = cn;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1]);
            }
            dr.Close();
            cmd.Dispose();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select StateCode  from State where StateName = '" + comboBox1.Text + "'";
            cmd.Connection = cn;
            int stcode = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.CommandText = "select * from City where StateCode =" + stcode;
            cmd.Connection = cn;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[1]);
            }
            dr.Close();
            cmd.Dispose();
        }
    }
}
