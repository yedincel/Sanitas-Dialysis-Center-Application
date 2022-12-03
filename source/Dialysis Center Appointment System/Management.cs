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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hasta_goruntule h1 = new Hasta_goruntule();
            h1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem güncellenmesi henüz tamamlanmadığı için şu an bu alana erişim sağlayamazsınız.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem güncellenmesi henüz tamamlanmadığı için şu an bu alana erişim sağlayamazsınız.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistem güncellenmesi henüz tamamlanmadığı için şu an bu alana erişim sağlayamazsınız.");
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
        }
    }
}
