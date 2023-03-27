using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_5
{

    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SAKIP02;Initial Catalog=fenil;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Que1 where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Successfully login");
                button1.Visible= false;
                button2.Visible= true;
                con.Close();
                label3.Text = "Welcome "+textBox1.Text;
            }
            else
            {
                MessageBox.Show("User Dont Exist");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text="logout successfully";
            button1.Visible = true;
            button2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
