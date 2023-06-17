using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furnitureapp
{
    public partial class user_registation : Form
    {
        public user_registation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // insert user details into 'user details' database table 
        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = "Insert into `user_details`(`user_ID`,`Full_name`,`Name_with_init`,`DOB`,`Address`,`NIC_No`,`Mobile_no`,`Email`) VALUES('" + txtuserid.Text + "', '" + txtfullname.Text + "','" + txtnamewithinit.Text + "', '" + txtDOB.Text + "', '" + txtAddress.Text + "', '" + txtnicno.Text + "', '" + txtmobileno.Text + "', '" + txtemail.Text + "' )";
            MySqlCommand cmd = new MySqlCommand(query, con);
            float value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
        
            clear();
        }

        //clear function - clear selectrd textboxes into empty
        public void clear()
        {
            txtuserid.Text = "";
            txtfullname.Text = "";
            txtnamewithinit.Text = "";
            txtDOB.Text = "";
            txtAddress.Text = "";
            txtnicno.Text = "";
            txtmobileno.Text = "";
            txtemail.Text = "";


        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void user_registation_Load(object sender, EventArgs e)
        {

        }
    }
}
