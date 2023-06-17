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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //log out button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login cd = new login();
            cd.Show();
        }

        //additem button
        private void button6_Click(object sender, EventArgs e)
        {
            opennewform(new additem());
        }

        //customer details button
        private void button5_Click(object sender, EventArgs e)
        {
            opennewform(new customer_details());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //add oders button
        private void button1_Click(object sender, EventArgs e)
        {

            addoders asp = new addoders();
            asp.Show();
        }

        //ongoing oders button
        private void button3_Click(object sender, EventArgs e)
        {
            opennewform(new ongoing_oders());
        }

        private Form activeForm = null;

        //open new forms in same panel
        private void opennewform(Form newform)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }

            activeForm = newform;
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            panel3.Controls.Add(newform);
            panel3.Tag = newform;
            newform.BringToFront();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opennewform(new manuf_oder_confirmation());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opennewform(new user_registation());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opennewform(new user_details());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            opennewform(new signup());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //show thw username top of the window
        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = userlogname.username;
        }
    }
}
