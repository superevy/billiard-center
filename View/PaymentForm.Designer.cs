namespace aplikasi_billiard_center.View
{
    partial class PaymentForm
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
            btnBRI = new Button();
            btnMandiri = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Pembayaran";
            label1.Click += label1_Click;
            // 
            // btnBRI
            // 
            btnBRI.Location = new Point(221, 192);
            btnBRI.Name = "btnBRI";
            btnBRI.Size = new Size(146, 52);
            btnBRI.TabIndex = 1;
            btnBRI.Text = "BRI";
            btnBRI.UseVisualStyleBackColor = true;
            btnBRI.Click += btnBRI_Click;
            // 
            // btnMandiri
            // 
            btnMandiri.Location = new Point(399, 192);
            btnMandiri.Name = "btnMandiri";
            btnMandiri.Size = new Size(146, 52);
            btnMandiri.TabIndex = 2;
            btnMandiri.Text = "Mandiri";
            btnMandiri.UseVisualStyleBackColor = true;
            btnMandiri.Click += btnMandiri_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.BackgroundImage = Properties.Resources.arrow_back;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(41, 35);
            button1.Name = "button1";
            button1.Size = new Size(30, 35);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnMandiri);
            Controls.Add(btnBRI);
            Controls.Add(label1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBRI;
        private Button btnMandiri;
        private Button button1;
    }
}