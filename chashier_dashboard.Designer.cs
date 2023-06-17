namespace furnitureapp
{
    partial class chashier_dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chashier_dashboard));
            panel1 = new Panel();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 75, 99);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 738);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(30, 31, 64);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(0, 99);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(108, 66);
            button6.TabIndex = 2;
            button6.Text = "  Add Items";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_03_20_at_00_44_28;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 75, 99);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(108, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 96);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1081, 34);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "User";
            // 
            // button2
            // 
            button2.Location = new Point(1155, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(30, 31, 64);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(402, 3);
            button5.Name = "button5";
            button5.Size = new Size(76, 79);
            button5.TabIndex = 5;
            button5.Text = "Oder \r\nDetails";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 31, 64);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(297, 3);
            button3.Name = "button3";
            button3.Size = new Size(76, 79);
            button3.TabIndex = 4;
            button3.Text = "Ongoing\r\nOders";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 31, 64);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = Properties.Resources.icons8_add_to_inbox_45__1_;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(192, 3);
            button1.Name = "button1";
            button1.Size = new Size(76, 79);
            button1.TabIndex = 2;
            button1.Text = "Add \r\nOders";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(180, 50);
            label1.TabIndex = 2;
            label1.Text = "DR Furniture system\r\n Cashier Dashboard";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(108, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 642);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2023_03_20_at_00_44_28;
            pictureBox2.Location = new Point(388, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(381, 295);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(1032, 36);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 8;
            label3.Text = "User";
            // 
            // chashier_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 738);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "chashier_dashboard";
            Text = "DR furniture system";
            Load += chashier_dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button6;
        private Panel panel3;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}