namespace furnitureapp
{
    partial class ongoing_oders
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
            txtdate = new TextBox();
            txtoderdate = new Label();
            txtinvoiceno = new TextBox();
            invoiceno = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txt_search = new TextBox();
            label13 = new Label();
            txtoderstatus = new TextBox();
            txttotalprice = new TextBox();
            txtdeliverymethod = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtitemprice = new TextBox();
            txtqty = new TextBox();
            txtitemname = new TextBox();
            txtitemno = new TextBox();
            txtnic = new TextBox();
            txtmobileno = new TextBox();
            txtaddress = new TextBox();
            txtname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
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
            panel1.Size = new Size(1258, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 1;
            label1.Text = "Ongoing Oders";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtdate);
            panel2.Controls.Add(txtoderdate);
            panel2.Controls.Add(txtinvoiceno);
            panel2.Controls.Add(invoiceno);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txt_search);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtoderstatus);
            panel2.Controls.Add(txttotalprice);
            panel2.Controls.Add(txtdeliverymethod);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtitemprice);
            panel2.Controls.Add(txtqty);
            panel2.Controls.Add(txtitemname);
            panel2.Controls.Add(txtitemno);
            panel2.Controls.Add(txtnic);
            panel2.Controls.Add(txtmobileno);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(txtname);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1258, 588);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(121, 219);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(151, 23);
            txtdate.TabIndex = 35;
            // 
            // txtoderdate
            // 
            txtoderdate.AutoSize = true;
            txtoderdate.Location = new Point(25, 222);
            txtoderdate.Name = "txtoderdate";
            txtoderdate.Size = new Size(59, 15);
            txtoderdate.TabIndex = 34;
            txtoderdate.Text = "Oder date";
            // 
            // txtinvoiceno
            // 
            txtinvoiceno.Location = new Point(121, 11);
            txtinvoiceno.Name = "txtinvoiceno";
            txtinvoiceno.Size = new Size(151, 23);
            txtinvoiceno.TabIndex = 33;
            // 
            // invoiceno
            // 
            invoiceno.AutoSize = true;
            invoiceno.Location = new Point(25, 19);
            invoiceno.Name = "invoiceno";
            invoiceno.Size = new Size(64, 15);
            invoiceno.TabIndex = 32;
            invoiceno.Text = "Invoice No";
            // 
            // button7
            // 
            button7.Location = new Point(741, 18);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 31;
            button7.Text = "ALL ODERS";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(952, 18);
            button6.Name = "button6";
            button6.Size = new Size(86, 23);
            button6.TabIndex = 30;
            button6.Text = "COMPLETED";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(849, 18);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 29;
            button5.Text = "ONGOING";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(311, 355);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 28;
            button4.Text = "SET";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 254);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(311, 207);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(311, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(466, 19);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(203, 23);
            txt_search.TabIndex = 24;
            txt_search.TextChanged += textBox12_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(406, 22);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 23;
            label13.Text = "search";
            label13.Click += label13_Click;
            // 
            // txtoderstatus
            // 
            txtoderstatus.Location = new Point(121, 529);
            txtoderstatus.Name = "txtoderstatus";
            txtoderstatus.Size = new Size(151, 23);
            txtoderstatus.TabIndex = 22;
            // 
            // txttotalprice
            // 
            txttotalprice.Location = new Point(121, 486);
            txttotalprice.Name = "txttotalprice";
            txttotalprice.Size = new Size(151, 23);
            txttotalprice.TabIndex = 21;
            // 
            // txtdeliverymethod
            // 
            txtdeliverymethod.Location = new Point(121, 440);
            txtdeliverymethod.Name = "txtdeliverymethod";
            txtdeliverymethod.Size = new Size(151, 23);
            txtdeliverymethod.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 532);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 19;
            label10.Text = "oder status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 489);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 18;
            label11.Text = "Total Price";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 443);
            label12.Name = "label12";
            label12.Size = new Size(90, 15);
            label12.TabIndex = 17;
            label12.Text = "deliverymethod";
            // 
            // txtitemprice
            // 
            txtitemprice.Location = new Point(121, 401);
            txtitemprice.Name = "txtitemprice";
            txtitemprice.Size = new Size(151, 23);
            txtitemprice.TabIndex = 16;
            // 
            // txtqty
            // 
            txtqty.Location = new Point(121, 355);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(151, 23);
            txtqty.TabIndex = 15;
            txtqty.TextChanged += txtqty_TextChanged;
            // 
            // txtitemname
            // 
            txtitemname.Location = new Point(121, 312);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(151, 23);
            txtitemname.TabIndex = 14;
            // 
            // txtitemno
            // 
            txtitemno.Location = new Point(121, 264);
            txtitemno.Name = "txtitemno";
            txtitemno.Size = new Size(151, 23);
            txtitemno.TabIndex = 13;
            // 
            // txtnic
            // 
            txtnic.Location = new Point(121, 179);
            txtnic.Name = "txtnic";
            txtnic.Size = new Size(151, 23);
            txtnic.TabIndex = 12;
            // 
            // txtmobileno
            // 
            txtmobileno.Location = new Point(121, 142);
            txtmobileno.Name = "txtmobileno";
            txtmobileno.Size = new Size(151, 23);
            txtmobileno.TabIndex = 11;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(121, 94);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(151, 23);
            txtaddress.TabIndex = 10;
            // 
            // txtname
            // 
            txtname.Location = new Point(121, 54);
            txtname.Name = "txtname";
            txtname.Size = new Size(151, 23);
            txtname.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 404);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 8;
            label9.Text = "item price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 361);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 7;
            label8.Text = "qty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 315);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 6;
            label7.Text = "item name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 267);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "item no";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 182);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "NIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 148);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "mobile no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 100);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "address";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "name";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column13, Column2, Column3, Column4, Column5, Column14, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridView1.Location = new Point(392, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(802, 392);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Invoice_no";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "cus_name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "cus_address";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "cus_mobileno";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "cus_nic";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "oder_date";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "item_no";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "item_name";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "qty";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "item_price";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "deliverymethod";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "total_price";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "oder_status";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // ongoing_oders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 636);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ongoing_oders";
            Text = "ongoing_oders";
            Load += ongoing_oders_Load_1;
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
        private DataGridView dataGridView1;
        private TextBox txtqty;
        private TextBox txtitemname;
        private TextBox txtitemno;
        private TextBox txtnic;
        private TextBox txtmobileno;
        private TextBox txtaddress;
        private TextBox txtname;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txt_search;
        private Label label13;
        private TextBox txtoderstatus;
        private TextBox txttotalprice;
        private TextBox txtdeliverymethod;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtitemprice;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;
        private TextBox txtinvoiceno;
        private Label invoiceno;

        private Label txtoderdate;
        private TextBox txtdate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}