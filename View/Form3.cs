using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aplikasi_billiard_center
{
    public partial class Form3 : Form
    {
        // Koneksi ke database
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=billiarddb;");

        public Form3()
        {
            InitializeComponent();
        }

        // Saat form dimuat
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Menampilkan data dari tabel crud ke DataGridView
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT id, meja, jam, durasi, (durasi * 30000) AS harga FROM crud";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        // Tombol Edit - membuka Form2 dengan data terpilih
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                    string meja = dataGridView1.CurrentRow.Cells["meja"].Value.ToString();
                    string jam = dataGridView1.CurrentRow.Cells["jam"].Value.ToString();
                    int durasi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["durasi"].Value);

                    Form2 form2 = new Form2(id, meja, jam, durasi);
                    form2.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuka form edit: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diedit terlebih dahulu.");
            }
        }

        // Tombol Tambah - kembali ke Form2 untuk tambah data
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        // Kosongkan jika tidak diperlukan
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                        conn.Open();
                        string query = "DELETE FROM crud WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Data berhasil dihapus!");
                        LoadData(); // Refresh tabel
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu.");
            }
        }
    }
}
