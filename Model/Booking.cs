using System;
using MySql.Data.MySqlClient;

namespace aplikasi_billiard_center.Model
{
    public class Booking
    {
        public int? Id { get; set; }
        public string Meja { get; set; }
        public string Jam { get; set; }
        public int Durasi { get; set; }
        public int Harga => Durasi * 30000;

        private static MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=billiarddb;");

        public bool Save()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd;

                if (Id.HasValue)
                {
                    string updateQuery = "UPDATE crud SET meja = @meja, jam = @jam, durasi = @durasi, harga = @harga WHERE id = @id";
                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@id", Id.Value);
                }
                else
                {
                    string insertQuery = "INSERT INTO crud (meja, jam, durasi, harga) VALUES (@meja, @jam, @durasi, @harga)";
                    cmd = new MySqlCommand(insertQuery, conn);
                }

                cmd.Parameters.AddWithValue("@meja", Meja);
                cmd.Parameters.AddWithValue("@jam", Jam);
                cmd.Parameters.AddWithValue("@durasi", Durasi);
                cmd.Parameters.AddWithValue("@harga", Harga);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Gagal menyimpan data: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
