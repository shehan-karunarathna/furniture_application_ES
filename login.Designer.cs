namespace furnitureapp
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(159, 134, 192);
            label1.Location = new Point(94, 58);
            label1.Name = "label1";
            label1.Size = new Size(68, 35);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(28, 107);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(28, 177);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Passward";
            label3.Click += label3_Click;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.ScrollBar;
            txtusername.Location = new Point(28, 125);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(199, 23);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.ScrollBar;
            txtpassword.Location = new Point(28, 195);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(199, 23);
            txtpassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 134, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 326);
            button1.Name = "button1";
            button1.Size = new Size(199, 32);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(159, 134, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(28, 374);
            button2.Name = "button2";
            button2.Size = new Size(199, 32);
            button2.TabIndex = 6;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 37);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 7;
            label4.Text = "DR Furniture System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(28, 249);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 20;
            label5.Text = "select user type";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Cashier", "Manufacture" });
            comboBox1.Location = new Point(28, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(259, 477);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
    }
}