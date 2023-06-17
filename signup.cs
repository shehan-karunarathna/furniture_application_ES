using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;

namespace furnitureapp
{
    public partial class signup : Form
    {
        //connection with database(mysqlconnection)
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
        public void loadRecord()
        {
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            dataGridView1.Rows.Clear();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT `user_id`,`username`,`password`,`usertype`FROM `login` ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["user_id"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["usertype"].ToString());

            }
            dr.Close();
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            //check password and confirm password
            try
            {
                if (txtusername.Text == "" && txtpassword.Text == "" && txtcpassword.Text == "")
                {
                    MessageBox.Show("username and pasword field are empty");
                }
                else if (txtpassword.Text == txtcpassword.Text)
                {
                    //insert the login details into 'login' database table
                    string server = "localhost";
                    string database = "furnituresystem";
                    string uid = "root";
                    string password = "";
                    string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

                    MySqlConnection con = new MySqlConnection(connectstring);
                    con.Open();
                    string query = "Insert into `login`(`user_id``username`,`password`,`usertype`) VALUES('" + txtuserid.Text + "','" + txtusername.Text + "', '" + txtpassword.Text + "' , '" + txtcomboBox1.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show(cmd.ToString());
                    MessageBox.Show("Your account has created");
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Password does not match, please check again");
                    txtpassword.Text = "";
                    txtcpassword.Text = "";
                    txtpassword.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error");
            }
#pragma warning restore CS0168 // Variable is declared but never used




        }

        //logout
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login cd = new login();
            cd.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txtcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
           
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = (" DELETE From `login` WHERE  `user_id`='" + txtuserid.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            MessageBox.Show("Row delete successful");
            loadRecord();
            clear();
        }

        //clear function
        public void clear()
        {
            txtuserid.Text = "";
            txtusername.Text = "";
            txtcomboBox1.Text = "";
            txtcpassword.Text = "";
            txtpassword.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtuserid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
