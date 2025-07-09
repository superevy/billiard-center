using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;

namespace aplikasi_billiard_center.Model
{
    public class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User GetUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                id = Convert.ToInt32(reader["id"]),
                                username = reader["username"].ToString(),
                                password_hash = reader["password"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool AddUser(User user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", user.password_hash);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}