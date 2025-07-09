namespace aplikasi_billiard_center
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            button4 = new Button();
            panel3 = new Panel();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 27);
            label1.Name = "label1";
            label1.Size = new Size(133, 64);
            label1.TabIndex = 0;
            label1.Text = "BILLIARD \r\nCENTER";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com;
            pictureBox1.Location = new Point(44, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 126);
            label2.Name = "label2";
            label2.Size = new Size(233, 29);
            label2.TabIndex = 2;
            label2.Text = "SELAMAT DATANG\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(28, 14);
            button1.Name = "button1";
            button1.Size = new Size(69, 61);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(244, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 121);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 76);
            label3.Name = "label3";
            label3.Size = new Size(83, 42);
            label3.TabIndex = 4;
            label3.Text = "BOOKING\r\nMEJA\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(380, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 121);
            panel2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 78);
            label6.Name = "label6";
            label6.Size = new Size(67, 42);
            label6.TabIndex = 7;
            label6.Text = "STATUS\r\nMEJA\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.BackgroundImage = Properties.Resources.status;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(28, 14);
            button4.Name = "button4";
            button4.Size = new Size(69, 61);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(380, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(122, 121);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 76);
            label4.Name = "label4";
            label4.Size = new Size(82, 42);
            label4.TabIndex = 5;
            label4.Text = "RIWAYAT \r\nSEWA\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.BackgroundImage = Properties.Resources.history;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(28, 14);
            button2.Name = "button2";
            button2.Size = new Size(69, 61);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 89);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 6;
            label5.Text = "PEMBAYARAN\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(244, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(122, 121);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.BackgroundImage = Properties.Resources.transaksi;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(28, 14);
            button3.Name = "button3";
            button3.Size = new Size(69, 61);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.BackgroundImage = Properties.Resources.status;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(27, 18);
            button5.Name = "button5";
            button5.Size = new Size(69, 61);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Billiard Center";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button5;
    }
}
