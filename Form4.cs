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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Practical_5
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SAKIP02;Initial Catalog=AdharCard;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //comboBox Data Bind
            //code that will not allow user to enrter the data in comboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxDataBind();
        }

        private void ComBoxDataBind()
        {

            //CREATE TABLE AdharCard.dbo.tblAadharcard(
            //AadharCardNo INT PRIMARY KEY,
            //FirstName VARCHAR(50) NOT NULL,
            //MiddleName VARCHAR(50),
            //LastName VARCHAR(50) NOT NULL,
            //Gender CHAR(1) CHECK(Gender IN('M', 'F', 'O')),
            //Birthdate DATE NOT NULL,
            // Nationality VARCHAR(50) NOT NULL,
            //Religious VARCHAR(50),
            //Address VARCHAR(100) NOT NULL,
            // City VARCHAR(50) NOT NULL,
            // Dist VARCHAR(50) NOT NULL,
            //State VARCHAR(50) NOT NULL,
            // ContactNo VARCHAR(10) UNIQUE NOT NULL,
            // IdentityProof VARCHAR(50) NOT NULL,
            // CastCategories VARCHAR(50)
            //);


            //that will bind the data of comboBox
            //[Note: For City, District and State, fill three comboboxes first for State, second for District
            //and third for City, when the user selects State the corresponding District will bind the
            //District and when the user selects District the corresponding City will bind the City.]

            //table creation query
            // create table City
            // (
            //    CityId int primary key identity(1,1),
            //    CityName varchar(50),
            //    DistrictId int foreign key references District(DistrictId)
            // )
            // create table District
            // (
            //    DistrictId int primary key identity(1,1),
            //    DistrictName varchar(50),
            //    StateId int foreign key references State(StateId)
            // )
            // create table State
            // (
            //    StateId int primary key identity(1,1),
            //    StateName varchar(50)
            // )

            //insert query for state
            //insert into State(StateName) values('Gujarat')
            //insert into State(StateName) values('Maharashtra')
            //insert into State(StateName) values('Rajasthan')
            //insert into State(StateName) values('Madhya Pradesh')
            //insert into State(StateName) values('Goa')

            //insert query for district
            //insert into District(DistrictName,StateId) values('Ahmedabad',1)
            //insert into District(DistrictName,StateId) values('Surat',1)
            //insert into District(DistrictName,StateId) values('Vadodara',1)
            //insert into District(DistrictName,StateId) values('Rajkot',1)
            //insert into District(DistrictName,StateId) values('Bharuch',1)
            //insert into District(DistrictName,StateId) values('Mumbai',2)
            //insert into District(DistrictName,StateId) values('Pune',2)
            //insert into District(DistrictName,StateId) values('Nagpur',2)
            //insert into District(DistrictName,StateId) values('Nashik',2)
            //insert into District(DistrictName,StateId) values('Aurangabad',2)
            //insert into District(DistrictName,StateId) values('Jaipur',3)
            //insert into District(DistrictName,StateId) values('Jodhpur',3)
            //insert into District(DistrictName,StateId) values('Udaipur',3)
            //insert into District(DistrictName,StateId) values('Ajmer',3)
            //insert into District(DistrictName,StateId) values('Bikaner',3)
            //insert into District(DistrictName,StateId) values('Indore',4)
            //insert into District(DistrictName,StateId) values('Bhopal',4)
            //insert into District(DistrictName,StateId) values('Dewas',4)
            //insert into District(DistrictName,StateId) values('Gwalior',4)
            //insert into District(DistrictName,StateId) values('Jabalpur',4)
            //insert into District(DistrictName,StateId) values('Panaji',5)
            //insert into District(DistrictName,StateId) values('Margao',5)
            //insert into District(DistrictName,StateId) values('Mapusa',5)
            //insert into District(DistrictName,StateId) values('Vasco da Gama',5)
            //insert into District(DistrictName,StateId) values('Verna',5)


            //insert query for city
            //insert into City(CityName,DistrictId) values('Ahmedabad',1)
            //insert into City(CityName,DistrictId) values('Anand',1)
            //insert into City(CityName,DistrictId) values('Bharuch',1)
            //insert into City(CityName,DistrictId) values('Bhavnagar',1)
            //insert into City(CityName,DistrictId) values('Surat',2)
            //insert into City(CityName,DistrictId) values('Navsari',2)
            //insert into City(CityName,DistrictId) values('Valsad',2)
            //insert into City(CityName,DistrictId) values('Vapi',2)
            //insert into City(CityName,DistrictId) values('Vadodara',3)
            //insert into City(CityName,DistrictId) values('Ankleshwar',3)
            //insert into City(CityName,DistrictId) values('Baroda',3)
            //insert into City(CityName,DistrictId) values('Bharuch',3)
            //insert into City(CityName,DistrictId) values('Rajkot',4)
            //insert into City(CityName,DistrictId) values('Jamnagar',4)
            //insert into City(CityName,DistrictId) values('Junagadh',4)
            //insert into City(CityName,DistrictId) values('Kandla',4)
            //insert into City(CityName,DistrictId) values('Mumbai',5)
            //insert into City(CityName,DistrictId) values('Navi Mumbai',5)
            //insert into City(CityName,DistrictId) values('Thane',5)
            //insert into City(CityName,DistrictId) values('Pune',6)
            //insert into City(CityName,DistrictId) values('Nashik',6)
            //insert into City(CityName,DistrictId) values('Nagpur',6)
            //insert into City(CityName,DistrictId) values('Aurangabad',6)
            //insert into City(CityName,DistrictId) values('Jaipur',7)
            //insert into City(CityName,DistrictId) values('Jodhpur',7)


            //code that will bind data into the combobox's using join query

            //select StateName from State

            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StateName from State", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["StateName"]);
            }
            con.Close();

            //shows only selected states district

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            //clear the comboBox2 clear

            comboBox2.Items.Clear();

            SqlCommand cmd1 = new SqlCommand("select DistrictName from District where StateId=(select StateId from State where StateName='" + comboBox1.Text + "')", con);


            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["DistrictName"]);
            }

            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();

            comboBox3.Items.Clear();

            //select city name according to a District Name

            SqlCommand cmd2 = new SqlCommand("select CityName from City where DistrictId=(select DistrictId from District where DistrictName='" + comboBox2.Text + "')", con);

            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["CityName"]);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();

            con.Open();

            SqlCommand cmd1 = new SqlCommand(
                "insert into tblAdharcard values(" + textBox1.Text+ ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox4.Text+"','" + dateTimePicker1.Text +"','"+textBox6.Text+ "','"+textBox7.Text+"'" 
                "               );
        }
    }
}
