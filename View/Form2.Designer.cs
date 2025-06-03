namespace aplikasi_billiard_center
{
    partial class Form2
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            listBoxMeja = new ListBox();
            label3 = new Label();
            label5 = new Label();
            button5 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBoxDurasi = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.BackgroundImage = Properties.Resources.arrow_back;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(25, 25);
            button1.Name = "button1";
            button1.Size = new Size(30, 35);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 31);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 3;
            label2.Text = "Booking Meja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 73);
            label1.Name = "label1";
            label1.Size = new Size(54, 24);
            label1.TabIndex = 4;
            label1.Text = "Meja";
            // 
            // listBoxMeja
            // 
            listBoxMeja.FormattingEnabled = true;
            listBoxMeja.ItemHeight = 25;
            listBoxMeja.Items.AddRange(new object[] { "Meja 1", "Meja 2", "Meja 3", "Meja 4", "Meja 5" });
            listBoxMeja.Location = new Point(77, 109);
            listBoxMeja.Name = "listBoxMeja";
            listBoxMeja.Size = new Size(460, 29);
            listBoxMeja.TabIndex = 5;
            listBoxMeja.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 151);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 6;
            label3.Text = "Jam";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 316);
            label5.Name = "label5";
            label5.Size = new Size(66, 24);
            label5.TabIndex = 10;
            label5.Text = "Harga";
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(608, 386);
            button5.Name = "button5";
            button5.Size = new Size(180, 52);
            button5.TabIndex = 13;
            button5.Text = "VIEW ORDER";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(608, 329);
            button2.Name = "button2";
            button2.Size = new Size(180, 52);
            button2.TabIndex = 15;
            button2.Text = "ORDER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 234);
            label4.Name = "label4";
            label4.Size = new Size(168, 24);
            label4.TabIndex = 8;
            label4.Text = "sewa berapa jam";
            // 
            // textBoxDurasi
            // 
            textBoxDurasi.Location = new Point(77, 270);
            textBoxDurasi.Name = "textBoxDurasi";
            textBoxDurasi.Size = new Size(460, 31);
            textBoxDurasi.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 348);
            label6.Name = "label6";
            label6.Size = new Size(217, 25);
            label6.TabIndex = 21;
            label6.Text = "Harga per jam nya 30.000";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(77, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(460, 31);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(textBoxDurasi);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxMeja);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private ListBox listBoxMeja;
        private Label label3;
        private Label label5;
        private Button button5;
        private Button button2;
        private Label label4;
        private TextBox textBoxDurasi;
        private TextBox textBoxHarga;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}