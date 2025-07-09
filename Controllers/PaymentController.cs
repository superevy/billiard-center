using aplikasi_billiard_center.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace aplikasi_billiard_center.Controllers
{
    public class PaymentController
    {
        private readonly string _connStr = "server=localhost;user id=root;password=;database=billiarddb;";

        public string GenerateVirtualAccount(string bankCode)
        {
            Random rnd = new Random();
            return bankCode + rnd.Next(100000, 999999).ToString();
        }

        public bool ProcessPayment(int bookingId, decimal amount, string bank)
        {
            try
            {
                string va = GenerateVirtualAccount(bank == "BRI" ? "888" : "999");

                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO payments 
                                    (booking_id, amount, payment_method, virtual_account, payment_date, status) 
                                    VALUES (@bookingId, @amount, @method, @va, NOW(), 'Pending')";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@method", bank);
                        cmd.Parameters.AddWithValue("@va", va);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Payment error: {ex.Message}");
                return false;
            }
        }

        public List<Payment> GetPaymentHistory(int userId)
        {
            var payments = new List<Payment>();

            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT p.* FROM payments p
                               JOIN bookings b ON p.booking_id = b.booking_id
                               WHERE b.user_id = @userId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            payments.Add(new Payment
                            {
                                PaymentId = Convert.ToInt32(reader["payment_id"]),
                                BookingId = Convert.ToInt32(reader["booking_id"]),
                                Amount = Convert.ToDecimal(reader["amount"]),
                                PaymentMethod = reader["payment_method"].ToString(),
                                VirtualAccount = reader["virtual_account"].ToString(),
                                PaymentDate = Convert.ToDateTime(reader["payment_date"]),
                                Status = reader["status"].ToString()
                            });
                        }
                    }
                }
            }
            return payments;
        }
    }
}