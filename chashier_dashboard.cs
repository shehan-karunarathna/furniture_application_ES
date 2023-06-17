using System.Windows.Forms;

namespace furnitureapp
{
    public partial class chashier_dashboard : Form
    {
        public chashier_dashboard()
        {
            InitializeComponent();
        }

        //shoe user name in top of the window
        private void chashier_dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = userlogname.username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //page change in addorder

            addoders asp = new addoders();
            asp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //page change in additem
            opennewform(new additem());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //log out button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login cd = new login();
            cd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //page change in ongoing oders
            opennewform(new ongoing_oders());
        }
        private Form activeForm = null;

        //open forms in same panel
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

        private void button5_Click(object sender, EventArgs e)
        {
            //page change in customer details
            opennewform(new customer_details());
        }
    }
}