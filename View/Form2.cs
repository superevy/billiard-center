using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aplikasi_billiard_center
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=billiarddb;");
        private int? editingId = null;

        public Form2()
        {
            InitializeComponent();
            SetupTimePicker();
        }

        // Konstruktor untuk edit data
        public Form2(int id, string meja, string jam, int durasi)
        {
            InitializeComponent();
            SetupTimePicker();

            editingId = id;
            textBoxDurasi.Text = durasi.ToString();
            listBoxMeja.Items.AddRange(new string[] { "Meja 1", "Meja 2", "Meja 3" });
            listBoxMeja.SelectedItem = meja;

            if (TimeSpan.TryParse(jam, out TimeSpan waktu))
            {
                dateTimePicker1.Value = DateTime.Today.Add(waktu);
            }
        }

        private void SetupTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.ShowUpDown = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (listBoxMeja.Items.Count == 0)
            {
                listBoxMeja.Items.AddRange(new string[] { "Meja 1", "Meja 2", "Meja 3" });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDurasi.Text))
            {
                MessageBox.Show("Harap isi durasi terlebih dahulu!");
                return;
            }

            if (!int.TryParse(textBoxDurasi.Text, out int durasi))
            {
                MessageBox.Show("Durasi harus berupa angka!");
                return;
            }

            string meja = listBoxMeja.SelectedItem?.ToString() ?? "Meja 1";
            string jam = dateTimePicker1.Value.ToString("HH:mm");
            int harga = durasi * 30000;

            try
            {
                conn.Open();
                MySqlCommand cmd;

                if (editingId.HasValue)
                {
                    string updateQuery = "UPDATE crud SET meja = @meja, jam = @jam, durasi = @durasi, harga = @harga WHERE id = @id";
                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@id", editingId.Value);
                }
                else
                {
                    string insertQuery = "INSERT INTO crud (meja, jam, durasi, harga) VALUES (@meja, @jam, @durasi, @harga)";
                    cmd = new MySqlCommand(insertQuery, conn);
                }

                cmd.Parameters.AddWithValue("@meja", meja);
                cmd.Parameters.AddWithValue("@jam", jam);
                cmd.Parameters.AddWithValue("@durasi", durasi);
                cmd.Parameters.AddWithValue("@harga", harga);

                cmd.ExecuteNonQuery();
                conn.Close();

                string message = editingId.HasValue ? "Data berhasil diperbarui!" : "Data berhasil disimpan!";
                MessageBox.Show(message);

                ClearForm();
                editingId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
                conn.Close();
            }
        }

        private void ClearForm()
        {
            listBoxMeja.ClearSelected();
            textBoxDurasi.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // Event opsional
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string waktu = dateTimePicker1.Value.ToString("HH:mm");
            Console.WriteLine("Jam dipilih: " + waktu);
        }

        // Event tidak terpakai, boleh dihapus
        private void label3_Click(object sender, EventArgs e) { }
        private void OpenForm3() { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePickerJam_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e) { }
    }
}
