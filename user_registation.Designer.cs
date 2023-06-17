namespace furnitureapp
{
    partial class user_registation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtfullname = new TextBox();
            txtnamewithinit = new TextBox();
            txtDOB = new TextBox();
            txtAddress = new TextBox();
            txtnicno = new TextBox();
            txtmobileno = new TextBox();
            txtemail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtuserid = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 48);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 1;
            label1.Text = "User Registation";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 129);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 170);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "Name with init.";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 207);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 4;
            label4.Text = "Date of Birth";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 239);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 276);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 6;
            label6.Text = "NIC No.";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 315);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 7;
            label7.Text = "Mobile No.";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 356);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 8;
            label8.Text = "Email";
            label8.Click += label8_Click;
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(142, 126);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(368, 23);
            txtfullname.TabIndex = 9;
            txtfullname.TextChanged += textBox1_TextChanged;
            // 
            // txtnamewithinit
            // 
            txtnamewithinit.Location = new Point(142, 167);
            txtnamewithinit.Name = "txtnamewithinit";
            txtnamewithinit.Size = new Size(368, 23);
            txtnamewithinit.TabIndex = 10;
            txtnamewithinit.TextChanged += textBox2_TextChanged;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(142, 204);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(368, 23);
            txtDOB.TabIndex = 11;
            txtDOB.TextChanged += textBox3_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(142, 236);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(368, 23);
            txtAddress.TabIndex = 12;
            txtAddress.TextChanged += textBox4_TextChanged;
            // 
            // txtnicno
            // 
            txtnicno.Location = new Point(142, 273);
            txtnicno.Name = "txtnicno";
            txtnicno.Size = new Size(368, 23);
            txtnicno.TabIndex = 13;
            txtnicno.TextChanged += textBox5_TextChanged;
            // 
            // txtmobileno
            // 
            txtmobileno.Location = new Point(142, 312);
            txtmobileno.Name = "txtmobileno";
            txtmobileno.Size = new Size(368, 23);
            txtmobileno.TabIndex = 14;
            txtmobileno.TextChanged += textBox6_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(142, 353);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(368, 23);
            txtemail.TabIndex = 15;
            txtemail.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(435, 440);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 440);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtuserid
            // 
            txtuserid.Location = new Point(142, 85);
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(368, 23);
            txtuserid.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 88);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 18;
            label9.Text = "user_id";
            // 
            // user_registation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 555);
            Controls.Add(txtuserid);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtemail);
            Controls.Add(txtmobileno);
            Controls.Add(txtnicno);
            Controls.Add(txtAddress);
            Controls.Add(txtDOB);
            Controls.Add(txtnamewithinit);
            Controls.Add(txtfullname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "user_registation";
            Text = "user_registation";
            Load += user_registation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtfullname;
        private TextBox txtnamewithinit;
        private TextBox txtDOB;
        private TextBox txtAddress;
        private TextBox txtnicno;
        private TextBox txtmobileno;
        private TextBox txtemail;
        private Button button1;
        private Button button2;
        private TextBox txtuserid;
        private Label label9;
    }
}