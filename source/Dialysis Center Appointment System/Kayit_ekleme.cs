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
    public partial class Kayit_ekleme : Form
    {
        static string cinsiyet;
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.Ace.OleDb.12.0; Data Source = sanitas.accdb");

        public Kayit_ekleme()
        {
            InitializeComponent();     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            bool kayitkontrol = false;
            baglanti.Open();
            OleDbCommand selectsorgu3 = new OleDbCommand("select * from hasta_giris where tcno='" + maskedTextBox1.Text + "'", baglanti);
            OleDbDataReader kayitokuma3 = selectsorgu3.ExecuteReader();

            while (kayitokuma3.Read())
            {
                kayitkontrol = true;
                break;
            }
            baglanti.Close();

            if (kayitkontrol == false)
            {

                if (maskedTextBox1.TextLength < 11)
                {
                    label1.ForeColor = Color.Red;
                    MessageBox.Show("T.C. Kimlik Numarası 11 Haneli Olmalıdır!");
                }
                else
                    label1.ForeColor = Color.Black;

                if (maskedTextBox2.TextLength < 2)
                {
                    label2.ForeColor = Color.Red;
                    MessageBox.Show("Geçerli bir isim giriniz");
                }
                else
                    label2.ForeColor = Color.Black;

                if (maskedTextBox3.TextLength < 2)
                {
                    label3.ForeColor = Color.Red;
                    MessageBox.Show("Geçerli bir soy isim giriniz");
                }
                else
                    label3.ForeColor = Color.Black;

                if (maskedTextBox4.TextLength < 10)
                {
                    label6.ForeColor = Color.Red;
                    MessageBox.Show("Telefon Numarası 10 Haneli Olmalıdır!");
                }
                else
                    errorProvider1.Clear();

                if (maskedTextBox5.TextLength < 8)
                {
                    label7.ForeColor = Color.Red;
                    errorProvider1.SetError(maskedTextBox5, "Parolar 8 karakterden daha uzun olmalıdır. !");
                }
                else
                    errorProvider1.Clear();

                if (maskedTextBox5.Text != maskedTextBox6.Text)
                {
                    label8.ForeColor = Color.Red;
                    errorProvider1.SetError(maskedTextBox6, "Parolar uyuşmuyor !");
                }

                else
                    label8.ForeColor = Color.Black;
                {
                    try
                    {
                        baglanti.Open();
                        OleDbCommand eklekomut = new OleDbCommand("insert into hasta_giris values ('" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "', '" + maskedTextBox3.Text + "','" + cinsiyet + "','" + maskedTextBox7.Text + "','" + maskedTextBox5.Text + "','" + "Kullanıcı" + "','" + maskedTextBox4.Text + "')", baglanti);
                        eklekomut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("KAYIT OLUŞTURULDU");
                    }
                    catch (Exception hatamsj)

                    {
                        MessageBox.Show(hatamsj.Message);

                        baglanti.Close();
                    }
                }
            }
            else
                MessageBox.Show("Dikkat ! Bu T.C. Kimlik Numarası İle Daha Önce Kayıt Açılmıştır.");
        }
                
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Kayit_ekleme_Load(object sender, EventArgs e)
        {
            ///baglanti.Open();
            //OleDbCommand selectsorgu1 = new OleDbCommand("select * from yönetici_login", baglanti); // sorguyu yazarak login isimli bağlantımızda aramayı gerçekleştirdik.             
            //OleDbDataReader kayitokuma1 = selectsorgu1.ExecuteReader();   // veri okuyucu tanımlandı , select sorgusu sonuçlarını getir ve kayitokuma datasında saklanır.
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}