using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace aplikasi_billiard_center.Controllers
{
    public class StatusMejaModel
    {
        public string NomorMeja { get; set; }
        public TimeSpan? Jam { get; set; }
        public int? Durasi { get; set; }
        public decimal? Harga { get; set; }
    }

    public class StatusMejaController
    {
        private readonly string connStr = "server=localhost;user id=root;password=;database=billiarddb;";

        public List<StatusMejaModel> GetAllStatusMeja()
        {
            List<StatusMejaModel> list = new List<StatusMejaModel>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT meja, jam, durasi, harga FROM crud";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string meja = reader["meja"].ToString();
                        string jamStr = reader["jam"].ToString();
                        TimeSpan? jam = TimeSpan.TryParse(jamStr, out TimeSpan j) ? j : null;
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
