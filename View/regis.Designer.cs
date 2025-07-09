namespace aplikasi_billiard_center.View
{
    partial class regis
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
            components = new System.ComponentModel.Container();
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 0);
            btnRegister.Location = new Point(479, 269);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Registrasi";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(426, 31);
            txtPassword.TabIndex = 19;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(165, 113);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(426, 31);
            txtUsername.TabIndex = 18;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 219);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 119);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 16;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 32);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 15;
            label2.Text = "Registrasi";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // regis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "regis";
            Text = "Form4";
            Load += regis_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}