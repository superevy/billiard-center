using aplikasi_billiard_center.View;
using Guna.UI2.WinForms;


namespace aplikasi_billiard_center
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStatusMeja formStatusMeja = new FormStatusMeja();
            formStatusMeja.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormStatusMeja formStatusMeja = new FormStatusMeja();
            formStatusMeja.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentForm formpayment = new PaymentForm();
            formpayment.Show();
            this.Hide();
        }
    }
}
