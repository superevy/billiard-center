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

            dataGridView1.Columns.Add("meja", "Nomor Meja");
            dataGridView1.Columns.Add("status", "Status");
            dataGridView1.Columns.Add("jam", "Jam Mulai");
            dataGridView1.Columns.Add("selesai", "Jam Selesai");
            dataGridView1.Columns.Add("durasi", "Durasi (menit)");
            dataGridView1.Columns.Add("harga", "Harga");
            dataGridView1.Columns.Add("customer", "Customer");

            var list = _controller.GetAllStatusMeja();

            foreach (var meja in list)
            {
                string jamMulai = meja.Jam?.ToString(@"hh\:mm") ?? "-";
                string jamSelesai = meja.Jam.HasValue && meja.Durasi.HasValue
                    ? DateTime.Today.Add(meja.Jam.Value).AddMinutes(meja.Durasi.Value).ToString("HH:mm")
                    : "-";

                dataGridView1.Rows.Add(
                    meja.NomorMeja,
                    meja.Status,
                    jamMulai,
                    jamSelesai,
                    meja.Durasi?.ToString() ?? "-",
                    meja.Harga?.ToString("N0") ?? "-",
                    meja.NamaCustomer
                );

                var row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                row.DefaultCellStyle.BackColor = meja.Status == "Available" ? Color.LightGreen : Color.LightCoral;
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
