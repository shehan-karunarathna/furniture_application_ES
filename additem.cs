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
using System.Xml.Linq;

namespace furnitureapp
{
    public partial class additem : Form

    {
        //connection with database(mysqlconnection)
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public additem()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void additem_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        //insert the item details into 'item' database table
        private void button1_Click_1(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = "Insert into `item`(`item_no`,`item_name`,`item_price`,`item_discription`) VALUES('" + textitemno.Text + "', '" + textitemname.Text + "', " + textitemprice.Text + ", '" + textitemdiscrip.Text + "' )";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            loadRecord();
            clear();
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        //datagridview cell content click 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            textitemno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textitemname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textitemprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textitemdiscrip.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        //load record funtion and load datagridview
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

            MySqlCommand cmd = new MySqlCommand("SELECT `item_no`, `item_name`, `item_price`, `item_discription` FROM `item` ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["item_no"].ToString(), dr["item_name"].ToString(), dr["item_price"].ToString(), dr["item_discription"].ToString());

            }
            dr.Close();
            con.Close();
            clear();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search bar
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            dataGridView1.Rows.Clear();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT `item_no`, `item_name`, `item_price`, `item_discription` FROM `item` WHERE item_no like '%" + txt_search.Text + "%' or item_name like '%" + txt_search.Text + "%' ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["item_no"].ToString(), dr["item_name"].ToString(), dr["item_price"].ToString(), dr["item_discription"].ToString());

            }
            dr.Close();
            con.Close();
            clear();


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }


        //delete button
        private void button5_Click(object sender, EventArgs e)
        {
            
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = (" DELETE From `item` WHERE  `item_no`='" + textitemno.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            loadRecord();
            clear();
        }


        //update button
        private void button4_Click(object sender, EventArgs e)
        {
            
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = (" UPDATE `item` SET `item_name`='" + textitemname.Text + "',`item_price`='" + textitemprice.Text + "',`item_discription`='" + textitemdiscrip.Text + "' WHERE  `item_no`='" + textitemno.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            loadRecord();
            clear();
        }

        private void textitemname_TextChanged(object sender, EventArgs e)
        {

        }

        //clear function
        private void clear()
        {
            textitemno.Text = "";

            textitemname.Text = "";

            textitemprice.Text = "";

            textitemdiscrip.Text = "";



        }


    }
}
