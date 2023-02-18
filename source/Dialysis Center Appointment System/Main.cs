using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Dialysis_Center_Appointment_System  // HASTA GİRİŞİ: 66411122200 Zeynep123. 
{                                            // YÖNETİCİ GİRİŞİ: yedincel Yed1234%     
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.Ace.OleDb.12.0; Data Source = sanitas.accdb");
        //OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Ace.OleDb.12.0;Data Source=" + Application.StartupPath + "sanitas_login.accdb;Persist Security Info=False");
        public static string tcno, ad, soyad, cinsiyet, dogum_tarihi, parola, yetki, telefon;
        public static string mail, kullanici_adi;
        public static bool erisim = false;
        
        //public static int hak = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sanitas Diyaliz Merkezine Hoşgeldiniz");
            this.AcceptButton = button1; // enter tuşu giriş yapar
            this.CancelButton = button2; // esc tuşu çıkış yapar
            this.StartPosition = FormStartPosition.CenterScreen; // formun konumu
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand selectsorgu1 = new OleDbCommand("select * from yonetici_giris", baglanti); // sorguyu yazarak login isimli bağlantımızda aramayı gerçekleştirdik.             
            OleDbDataReader kayitokuma1 = selectsorgu1.ExecuteReader();   // veri okuyucu tanımlandı , select sorgusu sonuçlarını getir ve kayitokuma datasında saklanır.

            OleDbCommand selectsorgu2 = new OleDbCommand("select * from hasta_giris", baglanti);
            OleDbDataReader kayitokuma_2 = selectsorgu2.ExecuteReader();

            while (kayitokuma1.Read() == true && kayitokuma_2.Read() == true)
            {
                if (radioButton1.Checked == true)
                {
                    if (kayitokuma1["kullanici_adi"].ToString() == textBox1.Text &&
                        kayitokuma1["parola"].ToString() == textBox2.Text &&
                        kayitokuma1["yetki"].ToString() == "Yönetici")
                    {
                        erisim = true;
                        this.Hide();
                        Management m1 = new Management();
                        m1.ShowDialog();
                    }               
                    else
                        MessageBox.Show("Kullanıcı adı ya da parola yanlış");
                    break;
                }

                if (radioButton2.Checked == true)
                {               
                    if (kayitokuma_2["tcno"].ToString() == textBox1.Text &&
                        kayitokuma_2["parola"].ToString() == textBox2.Text &&
                        kayitokuma_2["yetki"].ToString() == "Kullanıcı")
                    {
                        erisim = true;
                        tcno = kayitokuma_2.GetValue(0).ToString();
                        ad = kayitokuma_2.GetValue(1).ToString();
                        soyad = kayitokuma_2.GetValue(2).ToString();
                        cinsiyet = kayitokuma_2.GetValue(3).ToString();
                        dogum_tarihi = kayitokuma_2.GetValue(4).ToString();
                        parola = kayitokuma_2.GetValue(5).ToString();
                        yetki = kayitokuma_2.GetValue(6).ToString();
                        telefon = kayitokuma_2.GetValue(7).ToString();
                        this.Hide();
                        Appointment a1 = new Appointment();
                        a1.ShowDialog();                       
                    }              
                    else
                        MessageBox.Show("Kullanıcı adı ya da parola yanlış");
                    break;
                }
            }
            baglanti.Close();
        }
                
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayit_ekleme k1 = new Kayit_ekleme();
            k1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
