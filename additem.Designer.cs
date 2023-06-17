namespace furnitureapp
{
    partial class additem
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
            txt_search = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            textitemdiscrip = new TextBox();
            textitemprice = new TextBox();
            textitemname = new TextBox();
            textitemno = new TextBox();
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
            panel1.Size = new Size(1225, 74);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(txt_search);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textitemdiscrip);
            panel2.Controls.Add(textitemprice);
            panel2.Controls.Add(textitemname);
            panel2.Controls.Add(textitemno);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 481);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(603, 34);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(183, 23);
            txt_search.TabIndex = 26;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 42);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 25;
            label6.Text = "search";
            label6.Click += label6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(548, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(536, 296);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "#";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Item no";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 68;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Item name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 82;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Item price";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 79;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Item discription";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 106;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(52, 23);
            label10.Name = "label10";
            label10.Size = new Size(70, 32);
            label10.TabIndex = 21;
            label10.Text = "ADD ";
            // 
            // button5
            // 
            button5.Location = new Point(192, 351);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 20;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(388, 295);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 19;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(388, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(192, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textitemdiscrip
            // 
            textitemdiscrip.Location = new Point(192, 220);
            textitemdiscrip.Name = "textitemdiscrip";
            textitemdiscrip.Size = new Size(271, 23);
            textitemdiscrip.TabIndex = 7;
            // 
            // textitemprice
            // 
            textitemprice.Location = new Point(192, 180);
            textitemprice.Name = "textitemprice";
            textitemprice.Size = new Size(271, 23);
            textitemprice.TabIndex = 6;
            // 
            // textitemname
            // 
            textitemname.Location = new Point(192, 131);
            textitemname.Name = "textitemname";
            textitemname.Size = new Size(271, 23);
            textitemname.TabIndex = 5;
            textitemname.TextChanged += textitemname_TextChanged;
            // 
            // textitemno
            // 
            textitemno.Location = new Point(192, 87);
            textitemno.Name = "textitemno";
            textitemno.Size = new Size(100, 23);
            textitemno.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 223);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 3;
            label5.Text = "ITEM DISCRIPTION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 183);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 2;
            label4.Text = "ITEM PRICE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 139);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "ITEM NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 95);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "ITEM NO";
            // 
            // additem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 555);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "additem";
            Text = "add item";
            Load += additem_Load;
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
        private TextBox textitemdiscrip;
        private TextBox textitemprice;
        private TextBox textitemname;
        private TextBox textitemno;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label10;
        private Button button5;
        private Button button4;
        private TextBox txt_search;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}