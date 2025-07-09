using System;
using System.Data;
using System.Windows.Forms;
using aplikasi_billiard_center.Controllers;

namespace aplikasi_billiard_center
{
    public partial class FormRiwayat : Form
    {
        private BookingController controller = new BookingController();

        public FormRiwayat()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = controller.GetAllBookings();
            dataGridView1.DataSource = dt;
        }

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
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                    if (controller.DeleteBooking(id, out string error))
                    {
                        MessageBox.Show("Data berhasil dihapus!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data: " + error);
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
