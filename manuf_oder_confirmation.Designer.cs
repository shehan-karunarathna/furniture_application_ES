namespace furnitureapp
{
    partial class manuf_oder_confirmation
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
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            txtoderstatus = new TextBox();
            txtitemno = new TextBox();
            txtcuntomernic = new TextBox();
            txtcustomername = new TextBox();
            txtinvoiceno = new TextBox();
            txt_search = new TextBox();
            Invoice = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1032, 79);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 0;
            label1.Text = "oder check and confirmation";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(txtoderstatus);
            panel2.Controls.Add(txtitemno);
            panel2.Controls.Add(txtcuntomernic);
            panel2.Controls.Add(txtcustomername);
            panel2.Controls.Add(txtinvoiceno);
            panel2.Controls.Add(txt_search);
            panel2.Controls.Add(Invoice);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 475);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(873, 93);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 20;
            button4.Text = "Completed oders";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(873, 40);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 19;
            button3.Text = "Ongoing oders";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridView1.Location = new Point(50, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(867, 218);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Invoice_no";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "cus_name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "cus_address";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "cus_mobileno";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "cus_nic";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "cus_itemno";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "cus_item";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "cus_qty";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "cus_itemprice";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "cus_deliverymethod";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "total_price";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "oder_status";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(365, 128);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 17;
            label9.Text = "Oder status ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 64);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 16;
            label7.Text = "oder status type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 139);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 15;
            label8.Text = "customer NIC";
            // 
            // button2
            // 
            button2.Location = new Point(637, 175);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(453, 175);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ongoing", "completed" });
            comboBox1.Location = new Point(492, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtoderstatus
            // 
            txtoderstatus.Location = new Point(492, 120);
            txtoderstatus.Name = "txtoderstatus";
            txtoderstatus.Size = new Size(174, 23);
            txtoderstatus.TabIndex = 11;
            // 
            // txtitemno
            // 
            txtitemno.Location = new Point(159, 175);
            txtitemno.Name = "txtitemno";
            txtitemno.Size = new Size(174, 23);
            txtitemno.TabIndex = 10;
            // 
            // txtcuntomernic
            // 
            txtcuntomernic.Location = new Point(159, 136);
            txtcuntomernic.Name = "txtcuntomernic";
            txtcuntomernic.Size = new Size(174, 23);
            txtcuntomernic.TabIndex = 9;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(159, 98);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(174, 23);
            txtcustomername.TabIndex = 8;
            // 
            // txtinvoiceno
            // 
            txtinvoiceno.Location = new Point(159, 61);
            txtinvoiceno.Name = "txtinvoiceno";
            txtinvoiceno.Size = new Size(174, 23);
            txtinvoiceno.TabIndex = 7;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(159, 21);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(174, 23);
            txt_search.TabIndex = 6;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // Invoice
            // 
            Invoice.AutoSize = true;
            Invoice.Location = new Point(50, 69);
            Invoice.Name = "Invoice";
            Invoice.Size = new Size(62, 15);
            Invoice.TabIndex = 5;
            Invoice.Text = "Invoice no";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 183);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Item no";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 139);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 3;
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 101);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 2;
            label4.Text = "customer name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 24);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "search";
            label2.Click += label2_Click;
            // 
            // manuf_oder_confirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 554);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "manuf_oder_confirmation";
            Text = "manuf_oder_confirmation";
            Load += manuf_oder_confirmation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtcuntomernic;
        private TextBox txtcustomername;
        private TextBox txtinvoiceno;
        private TextBox txt_search;
        private Label Invoice;
        private Label label6;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox txtoderstatus;
        private TextBox txtitemno;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private Label label9;
        private Label label7;
        private Button button4;
        private Button button3;
    }
}