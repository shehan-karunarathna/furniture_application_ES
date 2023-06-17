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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mail;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace furnitureapp
{
    public partial class addoders : Form
    {
        //connection with database(mysqlconnection)
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public addoders()
        {
            InitializeComponent();
        }

        private void addoders_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // insert the oder details into 'oder' database table
        private void button2_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";

            //string mysqlconn = "server=127.0.0.1;order=root;database=furnituresystem;password=";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string query = "Insert into `oder`(`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`oder_date`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status`) VALUES('" + txtname.Text + "', '" + txtaddress.Text + "', " + txtpno.Text + ", '" + txtnic.Text + "','" + txt_date.Text + "','" + txtitemno.Text + "', '" + txtitemname.Text + "', " + txtqty.Text + ", " + txtprice.Text + ", '" + txtdelivery.Text + "'," + txttotal.Text + ",'ongoing')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            float value = cmd.ExecuteNonQuery();
            MessageBox.Show("oder Added");
            con.Close();
            clear();




        }

        private void txtdeliverymethod_CheckedChanged(object sender, EventArgs e)
        {

        }

        //clear button and call the clear() function
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void loadData()
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        //set button
        //qty * itemprive = total price
        private void button3_Click(object sender, EventArgs e)
        {
            int qty;
            float price, total;
            qty = int.Parse(txtqty.Text);
            price = float.Parse(txtprice.Text);
            total = qty * price;
            txttotal.Text = "" + total;


        }

        // clear function
        private void clear()
        {
            txtname.Text = "";
            txtaddress.Text = "";
            txtpno.Text = "";
            txtnic.Text = "";
            txttotal.Text = "";
            txtqty.Text = "";
            txtprice.Text = "";
            txtitemno.Text = "";
            txt_date.Text = "";


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdelivery.Text = txtcomboBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtdelivery.Text = txtcomboBox1.Text;
        }

        //time and date picker and assign the values
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            txt_date.Text = dt.ToString("yyyy-MM-dd hh:mm:ss");
        }

        //search button
        // select all details in item table and assign the values
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
            string item_no = txtitemno.Text;
            string item_name = txtitemname.Text;
            string item_price = txtprice.Text;

            string Query = "select * from item where item_no = '" + txtitemno.Text + "'";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtitemno.Text = reader["item_no"].ToString();
                txtitemname.Text = reader["item_name"].ToString();
                txtprice.Text = reader["item_price"].ToString();

            }
            else
            {
                MessageBox.Show("NO recoard found");
            }

            con.Close();

        }
    }
}
