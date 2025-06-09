using MySql.Data.MySqlClient;
using System.Data;

namespace aplikasi_billiard_center.Model
{
    public class Booking
    {
        public int? Id { get; set; }
        public string Meja { get; set; }
        public string Jam { get; set; }
        public int Durasi { get; set; }

        public int Harga => Durasi * 30000;

        public bool Save(out string errorMessage)
        {
            try
            {
                using (var conn = new MySqlConnection("server=localhost;user id=root;password=;database=billiarddb;"))
                {
                    conn.Open();
                    string query;
                    MySqlCommand cmd;

                    if (Id.HasValue)
                    {
                        query = "UPDATE crud SET meja = @meja, jam = @jam, durasi = @durasi, harga = @harga WHERE id = @id";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", Id.Value);
                    }
                    else
                    {
                        query = "INSERT INTO crud (meja, jam, durasi, harga) VALUES (@meja, @jam, @durasi, @harga)";
                        cmd = new MySqlCommand(query, conn);
                    }

                    cmd.Parameters.AddWithValue("@meja", Meja);
                    cmd.Parameters.AddWithValue("@jam", Jam);
                    cmd.Parameters.AddWithValue("@durasi", Durasi);
                    cmd.Parameters.AddWithValue("@harga", Harga);

                    cmd.ExecuteNonQuery();
                    errorMessage = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new MySqlConnection("server=localhost;user id=root;password=;database=billiarddb;"))
                {
                    conn.Open();
                    string query = "SELECT id, meja, jam, durasi, (durasi * 30000) AS harga FROM crud";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
            }
            catch (Exception)
            {
                // Optionally log error
            }
            return dt;
        }

        // Hapus data booking
        public static bool Delete(int id, out string errorMessage)
        {
            try
            {
                using (var conn = new MySqlConnection("server=localhost;user id=root;password=;database=billiarddb;"))
                {
                    conn.Open();
                    string query = "DELETE FROM crud WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    errorMessage = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
