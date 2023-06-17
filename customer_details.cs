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
    public partial class customer_details : Form
    {
        public customer_details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("SELECT `cus_name`,`cus_address`,`cus_mobileno`,`cus_nic` FROM `oder` ", con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["cus_name"].ToString(), dr["cus_address"].ToString(), dr["cus_mobileno"].ToString(), dr["cus_nic"].ToString());

            }
            dr.Close();
            con.Close();


        }

        private void customer_details_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
    }
}
