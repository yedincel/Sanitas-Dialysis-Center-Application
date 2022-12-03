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
    public partial class Randevu_goruntule : Form
    {
        public Randevu_goruntule()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Randevu_goruntule_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           Appointment a1 = new Appointment();
            a1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label5.Text = diyaliz_algoritmasi_form.Randevu_al.patient.date;
            label6.Text = diyaliz_algoritmasi_form.Randevu_al.patient.hours.ToString();
            label7.Text = diyaliz_algoritmasi_form.Randevu_al.patient.room;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
