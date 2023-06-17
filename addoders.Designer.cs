namespace furnitureapp
{
    partial class addoders
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
            panel2 = new Panel();
            txt_date = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label15 = new Label();
            txtnic = new TextBox();
            txtaddress = new TextBox();
            txtpno = new TextBox();
            txtname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            txtitemname = new TextBox();
            button4 = new Button();
            label14 = new Label();
            txtcomboBox1 = new ComboBox();
            txtdelivery = new TextBox();
            txtitemno = new TextBox();
            label13 = new Label();
            button3 = new Button();
            txttotal = new TextBox();
            label10 = new Label();
            txtprice = new TextBox();
            label12 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtqty = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "ADD Oders";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(txt_date);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtnic);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(txtpno);
            panel2.Controls.Add(txtname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 197);
            panel2.TabIndex = 1;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(536, 85);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(200, 23);
            txt_date.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-mm-dd hh:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(536, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(459, 53);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 11;
            label15.Text = "Oder date";
            // 
            // txtnic
            // 
            txtnic.Location = new Point(130, 150);
            txtnic.Name = "txtnic";
            txtnic.Size = new Size(253, 23);
            txtnic.TabIndex = 10;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(130, 82);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(253, 23);
            txtaddress.TabIndex = 9;
            // 
            // txtpno
            // 
            txtpno.Location = new Point(130, 114);
            txtpno.Name = "txtpno";
            txtpno.Size = new Size(253, 23);
            txtpno.TabIndex = 8;
            // 
            // txtname
            // 
            txtname.Location = new Point(130, 45);
            txtname.Name = "txtname";
            txtname.Size = new Size(253, 23);
            txtname.TabIndex = 7;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 153);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 6;
            label6.Text = "NIC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 117);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 5;
            label5.Text = "Mobile no.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 85);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 53);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 13);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 2;
            label2.Text = "Customer Details";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtitemname);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtcomboBox1);
            panel3.Controls.Add(txtdelivery);
            panel3.Controls.Add(txtitemno);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(txttotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtprice);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtqty);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 392);
            panel3.TabIndex = 2;
            // 
            // txtitemname
            // 
            txtitemname.Location = new Point(117, 121);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(171, 23);
            txtitemname.TabIndex = 28;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Location = new Point(245, 56);
            button4.Name = "button4";
            button4.Size = new Size(61, 23);
            button4.TabIndex = 27;
            button4.Text = "search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(684, 16);
            label14.Name = "label14";
            label14.Size = new Size(151, 25);
            label14.TabIndex = 26;
            label14.Text = "Delivery Method";
            // 
            // txtcomboBox1
            // 
            txtcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcomboBox1.DropDownWidth = 121;
            txtcomboBox1.FormattingEnabled = true;
            txtcomboBox1.IntegralHeight = false;
            txtcomboBox1.Items.AddRange(new object[] { "with delivery", "without delivery" });
            txtcomboBox1.Location = new Point(684, 60);
            txtcomboBox1.Name = "txtcomboBox1";
            txtcomboBox1.Size = new Size(121, 23);
            txtcomboBox1.TabIndex = 0;
            txtcomboBox1.SelectedIndexChanged += txtcomboBox1_SelectedIndexChanged;
            // 
            // txtdelivery
            // 
            txtdelivery.Location = new Point(684, 113);
            txtdelivery.Name = "txtdelivery";
            txtdelivery.Size = new Size(147, 23);
            txtdelivery.TabIndex = 1;
            txtdelivery.TextChanged += textBox2_TextChanged;
            // 
            // txtitemno
            // 
            txtitemno.Location = new Point(117, 57);
            txtitemno.Name = "txtitemno";
            txtitemno.Size = new Size(118, 23);
            txtitemno.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(50, 60);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 24;
            label13.Text = "item no.";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(40, 75, 99);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(344, 194);
            button3.Name = "button3";
            button3.Size = new Size(78, 28);
            button3.TabIndex = 23;
            button3.Text = "SET";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(117, 194);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(158, 23);
            txttotal.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 197);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 21;
            label10.Text = "Total Price";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(432, 59);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(163, 23);
            txtprice.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(362, 62);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 19;
            label12.Text = "Item Price";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 75, 99);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(344, 292);
            button2.Name = "button2";
            button2.Size = new Size(108, 28);
            button2.TabIndex = 15;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 75, 99);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(117, 292);
            button1.Name = "button1";
            button1.Size = new Size(108, 28);
            button1.TabIndex = 14;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtqty
            // 
            txtqty.Location = new Point(432, 116);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(163, 23);
            txtqty.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 119);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 9;
            label9.Text = "QTY";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 124);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 4;
            label8.Text = "Item name";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 16);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 3;
            label7.Text = "Items";
            // 
            // addoders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 652);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addoders";
            Text = "Form1";
            Load += addoders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtnic;
        private TextBox txtaddress;
        private TextBox txtpno;
        private TextBox txtname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private RadioButton radioButton2;
        private RadioButton txtdeliverymethod;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button2;
        private Button button1;
        private TextBox txtqty;
        private TextBox txtprice;
        private Label label12;
        private Button button3;
        private TextBox txttotal;
        private Label label10;
#pragma warning disable CS0169 // The field 'addoders.textBox1' is never used
        private TextBox txt_date;
#pragma warning restore CS0169 // The field 'addoders.textBox1' is never used
        private Label label13;
        private TextBox txtitemno;
        private ComboBox txtcomboBox1;
        private TextBox txtdelivery;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private Label label15;
        private TextBox txtitemname;
        private Button button4;
    }
}