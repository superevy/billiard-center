using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using BCrypt.Net; 

namespace aplikasi_billiard_center.Controllers
{
    public class AuthController
    {
        private readonly string _connectionString;

        public AuthController()
        {
            _connectionString = "server=localhost;user id=root;password=;database=billiarddb;";
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT password_hash FROM users WHERE username = @username";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        var storedHash = cmd.ExecuteScalar()?.ToString();
                        if (storedHash != null)
                        {
                            return BCrypt.Net.BCrypt.Verify(password, storedHash);
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}");
                return false;
            }
        }

        public bool Register(string username, string password)
            {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    // Cek username sudah ada (gunakan kolom yang benar)
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            return false;
                        }
                    }

                    // Hash password
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                    // Query insert yang sesuai dengan struktur tabel
                    string insertQuery = "INSERT INTO users (username, password_hash) VALUES (@username, @password_hash)";
                    using (var insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password_hash", passwordHash);

                        return insertCmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
        }
        }
}