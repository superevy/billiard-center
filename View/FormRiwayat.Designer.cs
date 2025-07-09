namespace aplikasi_billiard_center
{
    partial class FormRiwayat
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.BackgroundImage = Properties.Resources.arrow_back;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 35);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 18);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 5;
            label2.Text = "Pesanan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(668, 271);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(73, 365);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 19;
            button2.Text = "edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Location = new Point(221, 365);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 20;
            button3.Text = "hapus";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 128);
            button4.Location = new Point(366, 365);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 21;
            button4.Text = "tambah";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // FormRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "FormRiwayat";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}