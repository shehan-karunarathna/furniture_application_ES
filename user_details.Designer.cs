namespace furnitureapp
{
    partial class user_details
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
            button2 = new Button();
            button1 = new Button();
            txtemail = new TextBox();
            txtmobileno = new TextBox();
            txtnicno = new TextBox();
            txtAddress = new TextBox();
            txtDOB = new TextBox();
            txtnamewithinit = new TextBox();
            txtfullname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            txtuserid = new TextBox();
            label9 = new Label();
            txtsearch = new TextBox();
            label10 = new Label();
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 48);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "User Details";
            // 
            // button2
            // 
            button2.Location = new Point(547, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(695, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(663, 197);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(368, 23);
            txtemail.TabIndex = 31;
            // 
            // txtmobileno
            // 
            txtmobileno.Location = new Point(663, 156);
            txtmobileno.Name = "txtmobileno";
            txtmobileno.Size = new Size(368, 23);
            txtmobileno.TabIndex = 30;
            // 
            // txtnicno
            // 
            txtnicno.Location = new Point(663, 115);
            txtnicno.Name = "txtnicno";
            txtnicno.Size = new Size(368, 23);
            txtnicno.TabIndex = 29;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(663, 78);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(368, 23);
            txtAddress.TabIndex = 28;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(142, 201);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(368, 23);
            txtDOB.TabIndex = 27;
            // 
            // txtnamewithinit
            // 
            txtnamewithinit.Location = new Point(142, 161);
            txtnamewithinit.Name = "txtnamewithinit";
            txtnamewithinit.Size = new Size(368, 23);
            txtnamewithinit.TabIndex = 26;
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(142, 120);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(368, 23);
            txtfullname.TabIndex = 25;
            txtfullname.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(547, 200);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 24;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(547, 159);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 23;
            label7.Text = "Mobile No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 118);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 22;
            label6.Text = "NIC No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 81);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 21;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 204);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 20;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 164);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 19;
            label3.Text = "Name with init.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 123);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 18;
            label2.Text = "Full Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column9, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(26, 380);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(945, 150);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(402, 264);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 35;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtuserid
            // 
            txtuserid.Location = new Point(142, 76);
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(368, 23);
            txtuserid.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 79);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 36;
            label9.Text = "User_ID";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(86, 331);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(228, 23);
            txtsearch.TabIndex = 39;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 334);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 38;
            label10.Text = "Search";
            // 
            // Column9
            // 
            Column9.HeaderText = "#";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "User_ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Full_Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Name_with_init";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "DOB";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Address";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "NIC_No";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mobile_no";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // user_details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 607);
            Controls.Add(txtsearch);
            Controls.Add(label10);
            Controls.Add(txtuserid);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
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
            Name = "user_details";
            Text = "user_details";
            Load += user_details_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox txtemail;
        private TextBox txtmobileno;
        private TextBox txtnicno;
        private TextBox txtAddress;
        private TextBox txtDOB;
        private TextBox txtnamewithinit;
        private TextBox txtfullname;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox txtuserid;
        private Label label9;
        private TextBox txtsearch;
        private Label label10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}