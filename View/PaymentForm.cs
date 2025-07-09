using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace aplikasi_billiard_center.View
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBRI_Click(object sender, EventArgs e)
        {
            FormBRI formbri = new FormBRI();
            formbri.Show();
            this.Hide();
        }

        private void btnMandiri_Click(object sender, EventArgs e)
        {
            FormMandiri formmandiri = new FormMandiri();
            formmandiri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
