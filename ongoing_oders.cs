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
    public partial class ongoing_oders : Form
    {
        //connection with database(mysqlconnection)
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public ongoing_oders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //load the datagridview   
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`oder_date`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["oder_date"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ongoing_oders_Load(object sender, EventArgs e)

        {



        }
        //datagridview cellcontectclick 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtinvoiceno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtaddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmobileno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtnic.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtdate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtitemno.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtitemname.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtqty.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtitemprice.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtdeliverymethod.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txttotalprice.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtoderstatus.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }

        private void ongoing_oders_Load_1(object sender, EventArgs e)
        {
            loadRecord();
        }
        //search bar
        private void textBox12_TextChanged(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`oder_date`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` WHERE oder_status= 'ongoing' and cus_nic like '%" + txt_search.Text + "%' or oder_status like '%" + txt_search.Text + "%' or cus_name like '%" + txt_search.Text + "%' or Invoice_no like '%" + txt_search.Text + "%'or oder_date like '%" + txt_search.Text + "%'  ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["oder_date"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadRecord();
        }

        //ongoing button
        private void button5_Click(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`oder_date`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` WHERE oder_status= 'ongoing' ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["oder_date"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();
        }

        //completed button
        private void button6_Click(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`oder_date`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` WHERE oder_status= 'completed' ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["oder_date"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();
        }

        //clear button and call the clear function
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }


        //clear functon
        public void clear()
        {
            txtinvoiceno.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtmobileno.Text = "";
            txtnic.Text = "";
            txtitemno.Text = "";
            txtitemname.Text = "";
            txtqty.Text = "";
            txtitemprice.Text = "";
            txtdeliverymethod.Text = "";
            txttotalprice.Text = "";
            txtoderstatus.Text = "";


        }

        //update button 
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
            string query = (" UPDATE `oder` SET `cus_name`='" + txtname.Text + "',`cus_address`='" + txtaddress.Text + "',`cus_mobileno`='" + txtmobileno.Text + "',`cus_nic`='" + txtnic.Text + "',`cus_itemno`='" + txtitemno.Text + "',`cus_item`='" + txtitemname.Text + "',`cus_qty`='" + txtqty.Text + "',`cus_itemprice`='" + txtitemprice.Text + "',`cus_deliverymethod`='" + txtdeliverymethod.Text + "',`total_price`='" + txttotalprice.Text + "',`oder_status`='" + txtoderstatus.Text + "' WHERE  `cus_nic`='" + txtnic.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            MessageBox.Show("Row update successful");
            loadRecord();
            clear();
        }


        //delete button
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
            string query = (" DELETE From `oder` WHERE  `cus_nic`='" + txtnic.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            MessageBox.Show("Row delete successful");
            loadRecord();
            clear();
        }

        //qty * itemprice = total price
        private void button4_Click(object sender, EventArgs e)
        {
            int qty;
            float price, total;
            qty = int.Parse(txtqty.Text);
            price = float.Parse(txtitemprice.Text);
            total = qty * price;
            txttotalprice.Text = "" + total;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
