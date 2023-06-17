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
    public partial class manufacture_dashboard : Form
    {
        public manufacture_dashboard()
        {
            InitializeComponent();
        }

        //show the user name top of the form
        private void manufacture_dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = userlogname.username;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            opennewform(new manuf_oder_confirmation());

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
        //logout
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login cd = new login();
            cd.Show();
        }
    }
}
