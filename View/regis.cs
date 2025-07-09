using aplikasi_billiard_center.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_billiard_center.View
{
    public partial class regis : Form
    {
        private readonly AuthController _authController;
        public regis()
        {
            InitializeComponent();
            _authController = new AuthController();
            // Inisialisasi tambahan
            txtPassword.PasswordChar = '*';
            btnRegister.Text = "Daftar";
        }

        private void regis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username harus diisi", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Proses registrasi
            try
            {
                if (_authController.Register(username, password))
                {
                    MessageBox.Show("Registrasi berhasil!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Tutup form setelah registrasi berhasil
                }
                else
                {
                    MessageBox.Show("Username sudah digunakan", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 20)
            {
                errorProvider1.SetError(txtUsername, "Maksimal 20 karakter");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
