using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace furnitureapp
{
    public partial class login : Form
    {
        // connection with database 
        MySqlConnection con;

        MySqlCommand cmd;


        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");


        public login()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {


        }

        private void clear()
        {
            throw new NotImplementedException();
        }

        //login button
        private void button1_Click(object sender, EventArgs e)
        {
            //check username,password and usertype 
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            string server = "localhost";
            string database = "furnituresystem";
            string uid = "root";
            string password = "";
            string connectstring = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + uid + ";" + "password=" + password + ";";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();

            getuserloginname.username = txtusername.Text;

            //check username,password  
            string query = "select * from login where username = '" + txtusername.Text + "' and password='" + txtpassword.Text + "' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);


            string cmbItemvalue = comboBox1.SelectedItem.ToString();

            // check usertype and access into dashboards
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {



                    if (dt.Rows[i]["usertype"].ToString() == cmbItemvalue)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            userlogname.username = txtusername.Text;
                            this.Hide();
                            admin_dashboard cd = new admin_dashboard();
                            cd.Show();
                        }

                        else if (comboBox1.SelectedIndex == 1)
                        {
                            userlogname.username = txtusername.Text;
                            this.Hide();
                            chashier_dashboard cd = new chashier_dashboard();
                            cd.Show();
                        }

                        else
                        {
                            userlogname.username = txtusername.Text;
                            this.Hide();
                            manufacture_dashboard cd = new manufacture_dashboard();
                            cd.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("user type is not match or not selected");
                    }
                }
            }
            else
            {
                MessageBox.Show("username or password incorect!!!");

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup cd = new signup();
            cd.Show();
        }

        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
