using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // data kütüphanesi
using System.Text.RegularExpressions;  // regular kütüphanesi hazır güvenl parola oluşturur
using System.IO; // giriş çıkış işlemleri

namespace Dialysis_Center_Appointment_System
{
    public partial class Hasta_goruntule : Form
    {
       OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.Ace.OleDb.12.0; Data Source = sanitas.accdb");

        private void kullanicilari_listele()
        {
          try
            {
                baglanti.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select tcno AS[Tc KİMLİK NO], ad AS[AD], soyad AS[SOYAD], cinsiyet AS[CİNSİYET], dogum_tarihi AS[DOĞUM TARİHİ],  parola AS[PAROLA], yetki AS[YETKİ], telefon AS[TELEFON] from hasta_giris Order By ad ASC", baglanti);

                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];             
            }
            
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SANİTAS DİYALİZ MERKEZİ", MessageBoxButtons.OK);
                baglanti.Close();
            }
        }

        public Hasta_goruntule()
        {
            InitializeComponent();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hasta_goruntule_Load(object sender, EventArgs e)
        {
            kullanicilari_listele();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m1 = new Management();
            m1.ShowDialog();
        }
    }
}
