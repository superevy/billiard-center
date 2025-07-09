using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplikasi_billiard_center.Controllers;

namespace aplikasi_billiard_center.View
{
    public partial class login : Form
    {
        private readonly AuthController _authController;
        public login()
        {
            InitializeComponent();
            _authController = new AuthController();

            // UI improvements
            textBox2.PasswordChar = '*'; // Make password field show asterisks
            button1.Text = "Login";
            linkLabel1.Text = "Don't have an account? Register here";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_authController.Authenticate(username, password))
                {
                    MessageBox.Show("Login successful!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var mainForm = new Form1();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Authentication Failed",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            regis registerForm = new regis();
            registerForm.Show();
        }
    }
}
