using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace aplikasi_billiard_center.Controllers
{
    public class StatusMejaController
    {
        private readonly string _connectionString = "server=localhost;user id=root;database=billiarddb;password=";

        public List<StatusMejaModel> GetAllStatusMeja()
        {
            var list = new List<StatusMejaModel>();

            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT meja, jam, durasi, harga FROM crud";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string meja = reader["meja"].ToString();
                        TimeSpan? jam = TimeSpan.TryParse(reader["jam"].ToString(), out TimeSpan j) ? j : null;
                        int? durasi = reader["durasi"] != DBNull.Value ? Convert.ToInt32(reader["durasi"]) : null;
                        decimal? harga = reader["harga"] != DBNull.Value ? Convert.ToDecimal(reader["harga"]) : null;

                        list.Add(new StatusMejaModel
                        {
                            NomorMeja = meja,
                            Jam = jam,
                            Durasi = durasi,
                            Harga = harga
                        });
                    }
                }
            }

            return list;
        }
    }
}
