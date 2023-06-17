namespace furnitureapp
{
    partial class signup
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
            button2 = new Button();
            button1 = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtcpassword = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            textBox1 = new TextBox();
            txtcomboBox1 = new ComboBox();
            label8 = new Label();
            button3 = new Button();
            txtuserid = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(159, 134, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(43, 467);
            button2.Name = "button2";
            button2.Size = new Size(199, 32);
            button2.TabIndex = 14;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 134, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(43, 419);
            button1.Name = "button1";
            button1.Size = new Size(199, 32);
            button1.TabIndex = 13;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.ScrollBar;
            txtpassword.Location = new Point(43, 297);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(199, 23);
            txtpassword.TabIndex = 12;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.ScrollBar;
            txtusername.Location = new Point(43, 170);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(199, 23);
            txtusername.TabIndex = 11;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(43, 279);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 10;
            label3.Text = "Passward";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(43, 146);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(159, 134, 192);
            label1.Location = new Point(43, 51);
            label1.Name = "label1";
            label1.Size = new Size(144, 35);
            label1.TabIndex = 8;
            label1.Text = "USER SIGN UP";
            // 
            // txtcpassword
            // 
            txtcpassword.BackColor = SystemColors.ScrollBar;
            txtcpassword.Location = new Point(43, 365);
            txtcpassword.Name = "txtcpassword";
            txtcpassword.Size = new Size(199, 23);
            txtcpassword.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(43, 347);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 16;
            label5.Text = "Confirm Passward";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 48);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(28, 9);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 1;
            label6.Text = "User Sign up";
            label6.Click += label6_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(343, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 232);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "#";
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.HeaderText = "user_id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "username";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "password";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "usertype";
            Column4.Name = "Column4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 93);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 20;
            label7.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 21;
            // 
            // txtcomboBox1
            // 
            txtcomboBox1.BackColor = SystemColors.ScrollBar;
            txtcomboBox1.FormattingEnabled = true;
            txtcomboBox1.Items.AddRange(new object[] { "Admin", "Manufacture", "Cashier" });
            txtcomboBox1.Location = new Point(43, 229);
            txtcomboBox1.Name = "txtcomboBox1";
            txtcomboBox1.Size = new Size(121, 23);
            txtcomboBox1.TabIndex = 22;
            txtcomboBox1.SelectedIndexChanged += txtcomboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(43, 209);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 23;
            label8.Text = "User type";
            // 
            // button3
            // 
            button3.Location = new Point(343, 424);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtuserid
            // 
            txtuserid.BackColor = SystemColors.ScrollBar;
            txtuserid.Location = new Point(43, 113);
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(199, 23);
            txtuserid.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(43, 89);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 25;
            label4.Text = "User id";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 542);
            Controls.Add(txtuserid);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(txtcomboBox1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(txtcpassword);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signup";
            Load += signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtcpassword;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label7;
        private TextBox textBox1;
        private ComboBox txtcomboBox1;
        private Label label8;
        private Button button3;
        private TextBox txtuserid;
        private Label label4;
    }
}