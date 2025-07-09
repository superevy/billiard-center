using aplikasi_billiard_center.Controllers;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_billiard_center.View
{
    public partial class FormStatusMeja : Form
    {
        private readonly StatusMejaController _controller = new StatusMejaController();

        public FormStatusMeja()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStatusMeja_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            // Kolom yang ditampilkan
            dataGridView1.Columns.Add("meja", "Nomor Meja");
            dataGridView1.Columns.Add("status", "Status");
            dataGridView1.Columns.Add("jam", "Jam Mulai");
            dataGridView1.Columns.Add("selesai", "Jam Selesai");

            var dataMeja = _controller.GetAllStatusMeja();

            // Daftar meja tetap
            List<string> daftarMeja = new List<string> { "Meja 1", "Meja 2", "Meja 3", "Meja 4", "Meja 5" };

            foreach (var nomorMeja in daftarMeja)
            {
                // Ambil booking terbaru untuk meja ini
                var pemakaian = dataMeja
                    .Where(m => m.NomorMeja == nomorMeja && m.Jam.HasValue && m.Durasi.HasValue)
                    .OrderByDescending(m => m.Jam)
                    .FirstOrDefault();

                string status = "Available";
                string jamMulai = "-";
                string jamSelesai = "-";

                if (pemakaian != null)
                {
                    var sekarang = DateTime.Now.TimeOfDay;
                    var mulai = pemakaian.Jam.Value;
                    var selesai = mulai.Add(TimeSpan.FromMinutes(pemakaian.Durasi.Value));

                    if (sekarang >= mulai && sekarang < selesai)
                    {
                        status = "In Use";
                        jamMulai = mulai.ToString(@"hh\:mm");
                        jamSelesai = DateTime.Today.Add(mulai).AddMinutes(pemakaian.Durasi.Value).ToString("HH:mm");
                    }
                }

                dataGridView1.Rows.Add(nomorMeja, status, jamMulai, jamSelesai);

                // Warnai baris
                var row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                row.DefaultCellStyle.BackColor = status == "Available" ? Color.LightGreen : Color.LightCoral;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
