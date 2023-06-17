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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace furnitureapp
{
    public partial class user_details : Form
    {
        public user_details()
        {
            InitializeComponent();
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

            MySqlCommand cmd = new MySqlCommand("SELECT `user_ID`,`Full_name`,`Name_with_init`,`DOB`,`Address`,`NIC_No`,`Mobile_no`,`Email` FROM `user_details` ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["user_ID"].ToString(), dr["Full_name"].ToString(), dr["Name_with_init"].ToString(), dr["DOB"].ToString(), dr["Address"].ToString(), dr["NIC_No"].ToString(), dr["Mobile_no"].ToString(), dr["Email"].ToString());

            }
            dr.Close();
            con.Close();


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_details_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtuserid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtfullname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtnamewithinit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDOB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtnicno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtmobileno.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = (" UPDATE `user_details` SET `user_ID`='" + txtuserid + "',`Full_name`='" + txtfullname.Text + "',`Name_with_init`='" + txtnamewithinit.Text + "',`DOB`='" + txtDOB.Text + "',`Address`='" + txtAddress.Text + "',`NIC_No`='" + txtnicno.Text + "',`Mobile_no`='" + txtmobileno.Text + "',`Email`='" + txtemail.Text + " WHERE  `user_ID`='" + txtuserid.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            MessageBox.Show("Row update successful");
            loadRecord();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //delete
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = (" DELETE From `user_details` WHERE  `user_ID`='" + txtuserid.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            MessageBox.Show("Row delete successful");
            loadRecord();
            clear();

        }


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

        private void txtsearch_TextChanged(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `user_ID`,`Full_name`,`Name_with_init`,`DOB`,`Address`,`NIC_No`,`Mobile_no`,`Email` FROM `user_details` WHERE user_ID like '%" + txtsearch.Text + "%' or Name_with_init like '%" + txtsearch.Text + "%' or NIC_No like '%" + txtsearch.Text + "%' or Full_name like '%" + txtsearch.Text + "%'or Mobile_no like '%" + txtsearch.Text + "%' ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["user_ID"].ToString(), dr["Full_name"].ToString(), dr["Name_with_init"].ToString(), dr["DOB"].ToString(), dr["Address"].ToString(), dr["NIC_No"].ToString(), dr["Mobile_no"].ToString(), dr["Email"].ToString());

            }
            dr.Close();
            con.Close();

        }
    }
}
