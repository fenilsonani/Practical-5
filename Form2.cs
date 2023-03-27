using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_5
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SAKIP02;Initial Catalog=fenil;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert value from textbox1 to textbox10
            //coluns are 
            //       CREATE TABLE[dbo].[Student] (
            // [id]         INT NULL,
            //  [en_no]      VARCHAR(50) NULL,
            //  [first_name] VARCHAR(50) NULL,
            // [last_name] VARCHAR(50) NULL,
            // [city] VARCHAR(50) NULL,
            //[co_no] VARCHAR(50) NULL,
            // [sub_1] INT NULL,
            // [sub_2]      INT NULL,
            //[sub_3]      INT NULL,
            //[sub_4]      INT NULL,
            // [sub_5]      INT NULL
            //);
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"',"+textBox6.Text+","+textBox7.Text+","+textBox8.Text+","+textBox9.Text+","+textBox10.Text+")",con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearTextBox();
            MessageBox.Show("Data Inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code for updation
            con.Close();
            con.Open();
            //coluns are 
             //       CREATE TABLE[dbo].[Student] (
           // [id]         INT NULL,
          //  [en_no]      VARCHAR(50) NULL,
          //  [first_name] VARCHAR(50) NULL,
           // [last_name] VARCHAR(50) NULL,
           // [city] VARCHAR(50) NULL,
            //[co_no] VARCHAR(50) NULL,
           // [sub_1] INT NULL,
           // [sub_2]      INT NULL,
            //[sub_3]      INT NULL,
            //[sub_4]      INT NULL,
           // [sub_5]      INT NULL
             //);
            SqlCommand cmd=new SqlCommand("update Student set en_no='"+textBox1.Text+"',first_name='"+textBox2.Text+"',last_name='"+textBox3.Text+"',city='"+textBox4.Text+"',co_no='"+textBox5.Text+"',sub_1='"+textBox6.Text+"',sub_2='"+textBox7.Text+"',sub_3='"+textBox8.Text+"',sub_4='"+textBox9.Text+"',sub_5='"+textBox10.Text+ "' where en_no='" + textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearTextBox();
            MessageBox.Show("Data Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code for deletion
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Student where en_no='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearTextBox();
            MessageBox.Show("Data Deleted");
        }

        public void clearTextBox()
        {
            //clear the textbox1 to textbox10
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //navigation of records and search specific records based on enrolment no.and city.
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student where en_no='"+textBox1.Text+"' or city='"+textBox4.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //shows the data in richtextbox1
                richTextBox1.Text = " Enrolment No. : " + dr[0] + "\n"+
                    " Name : "+ dr[1] + dr[2] + 
                    "\n City : " + dr[3]+
                    "\n Contact No. : " + dr[4] +
                    "\n Marks in Subject 1 : " + dr[5] +
                    "\n Marks in Subject 2 : " + dr[6] +
                    "\n Marks in Subject 3 : " + dr[7] +
                    "\n Marks in Subject 4 : " + dr[8] +
                    "\n Marks in Subject 5 : " + dr[9];
            }
            else
            {
                MessageBox.Show("Record Not Found");
                con.Close();
            }
        }
    }
}
