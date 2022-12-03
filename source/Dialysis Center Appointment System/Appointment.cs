using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialysis_Center_Appointment_System
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            diyaliz_algoritmasi_form.Randevu_al r1 = new diyaliz_algoritmasi_form.Randevu_al();
            r1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Randevu_goruntule rg1 = new Randevu_goruntule();
            rg1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem güncellenmesi henüz tamamlanmadığı için şu an bu alana erişim sağlayamazsınız.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem güncellenmesi henüz tamamlanmadığı için şu an bu alana erişim sağlayamazsınız.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
        }
    }
}
