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
    public partial class manuf_oder_confirmation : Form
    {
        public manuf_oder_confirmation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();


        }

        private void manuf_oder_confirmation_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtinvoiceno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcustomername.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcuntomernic.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtitemno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtoderstatus.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        //update button
        private void button1_Click(object sender, EventArgs e)
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
            string query = (" UPDATE `oder` SET `oder_status`='" + txtoderstatus.Text + "' WHERE  `Invoice_no`='" + txtinvoiceno.Text + "'");
            MySqlCommand cmd = new MySqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            MessageBox.Show(value.ToString());
            con.Close();
            MessageBox.Show("Row update successful");
            loadRecord();
            clear();
        }

        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        //clear function
        private void clear()
        {
            txtinvoiceno.Text = "";
            txtcustomername.Text = "";
            txtcuntomernic.Text = "";
            txtitemno.Text = "";
            txtoderstatus.Text = "";
            comboBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` WHERE oder_status= 'ongoing' and cus_nic like '%" + txt_search.Text + "%' or oder_status like '%" + txt_search.Text + "%' or cus_name like '%" + txt_search.Text + "%' or Invoice_no like '%" + txt_search.Text + "%'  ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtoderstatus.Text = comboBox1.Text;
        }

        //ongoing button
        private void button3_Click(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` WHERE oder_status= 'ongoing' ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();
        }

        //completed button
        private void button4_Click(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `Invoice_no`,`cus_name`,`cus_address`,`cus_mobileno`,`cus_nic`,`cus_itemno`,`cus_item`,`cus_qty`,`cus_itemprice`,`cus_deliverymethod`,`total_price`,`oder_status` FROM `oder` WHERE oder_status= 'completed' ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Invoice_no"].ToString(), dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString(), dr["cus_itemno"].ToString(), dr["cus_item"].ToString(), dr["cus_qty"].ToString(), dr["cus_itemprice"].ToString(), dr["cus_deliverymethod"].ToString(), dr["total_price"].ToString(), dr["oder_status"].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}



