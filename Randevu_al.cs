using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyaliz_algoritmasi_form
{
    public partial class Randevu_al : Form
    {
        public Randevu_al()
        {
            InitializeComponent();
        }

        public class machine1
        {
            static public double[,] pazartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] sali = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] carsamba = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] persembe = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cuma = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cumartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
        }

        public class machine2
        {
            static public double[,] pazartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] sali = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] carsamba = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] persembe = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cuma = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cumartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
        }

        public class machine3
        {
            static public double[,] pazartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] sali = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] carsamba = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] persembe = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cuma = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cumartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
        }

        public class machine4
        {
            static public double[,] pazartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] sali = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] carsamba = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] persembe = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cuma = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cumartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
        }

        public class machine5
        {
            static public double[,] pazartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] sali = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] carsamba = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] persembe = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cuma = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
            static public double[,] cumartesi = { { 9.00, 0 }, { 10.00, 0 }, { 11.00, 0 }, { 12.00, 0 }, { 13.00, 0 }, { 14.00, 0 }, { 15.00, 0 }, { 16.00, 0 }, { 17.00, 0 }, { 18.00, 0 } };
        }

        public static class patient
        {
            static public string date;
            static public double hours;
            static public string room;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Sali");
            comboBox1.Items.Add("Carsamba");
            comboBox1.Items.Add("Persembe");
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Cumartesi");

            comboBox5.Items.Add("Oda 1");
            comboBox5.Items.Add("Oda 2");
            comboBox5.Items.Add("Oda 3");
            comboBox5.Items.Add("Oda 4");
            comboBox5.Items.Add("Oda 5");


            comboBox2.Items.Add(9.00);
            comboBox2.Items.Add(10.00);
            comboBox2.Items.Add(11.00);
            comboBox2.Items.Add(12.00);
            comboBox2.Items.Add(13.00);
            comboBox2.Items.Add(14.00);
            comboBox2.Items.Add(15.00);
            comboBox2.Items.Add(16.00);
            comboBox2.Items.Add(17.00);
            comboBox2.Items.Add(18.00);      

            comboBox3.Items.Add(1);
            comboBox3.Items.Add(2);
            comboBox3.Items.Add(3);
            comboBox3.Items.Add(4);
            comboBox3.Items.Add(5);

            comboBox4.Items.Add("Makine 1");
            comboBox4.Items.Add("Makine 2");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {   if (comboBox5.SelectedIndex == 0)
                Machine1();

            if (comboBox5.SelectedIndex == 1)
                Machine2();

            if (comboBox5.SelectedIndex == 2)
                Machine3();

            if (comboBox5.SelectedIndex == 3)
                Machine4();

            if (comboBox5.SelectedIndex == 4)
                Machine5();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = patient.date;
            label5.Text = Convert.ToString(patient.hours);
            label8.Text = patient.room;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {}

        public void Machine1()
        {
            bool durum = false;
            string randevu_gunu = comboBox1.SelectedItem.ToString();
            double randevu_saati = Convert.ToDouble(comboBox2.SelectedItem);
            int randevu_uzunluk = Convert.ToInt32(comboBox3.SelectedItem), indis = 0, tmp_indis, i;
            
            if (comboBox1.SelectedIndex == 0)
            {
                for (i = 0; i < machine1.pazartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.pazartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine1.pazartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine1.pazartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }

            }

            if (comboBox1.SelectedIndex == 1)
            {
                for (i = 0; i < machine1.sali.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.sali[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine1.sali[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine1.sali[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
         
            }

            if (comboBox1.SelectedIndex == 2)
            {
                for (i = 0; i < machine1.carsamba.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.carsamba[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine1.carsamba[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine1.carsamba[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                for (i = 0; i < machine1.persembe.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.persembe[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine1.persembe[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine1.persembe[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 4)
            {
                for (i = 0; i < machine1.cuma.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.cuma[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine1.cuma[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine1.cuma[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 5)
            {
                for (i = 0; i < machine1.cumartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.cumartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine1.cumartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine1.cumartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

        }

        public void Machine2()
        {
            bool durum = false;
            string randevu_gunu = comboBox1.SelectedItem.ToString();
            double randevu_saati = Convert.ToDouble(comboBox2.SelectedItem);
            int randevu_uzunluk = Convert.ToInt32(comboBox3.SelectedItem), indis = 0, tmp_indis, i;

            if (comboBox1.SelectedIndex == 0)
            {
                for (i = 0; i < machine2.pazartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine2.pazartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine2.pazartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine2.pazartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                for (i = 0; i < machine2.sali.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine2.sali[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine2.sali[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine2.sali[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                for (i = 0; i < machine2.carsamba.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine2.carsamba[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine2.carsamba[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine2.carsamba[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                for (i = 0; i < machine2.persembe.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine2.persembe[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine2.persembe[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine2.persembe[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 4)
            {
                for (i = 0; i < machine2.cuma.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine2.cuma[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine2.cuma[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine2.cuma[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 5)
            {
                for (i = 0; i < machine2.cumartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine1.cumartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine2.cumartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine2.cumartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

        }
        public void Machine3()
        {
            bool durum = false;
            string randevu_gunu = comboBox1.SelectedItem.ToString();
            double randevu_saati = Convert.ToDouble(comboBox2.SelectedItem);
            int randevu_uzunluk = Convert.ToInt32(comboBox3.SelectedItem), indis = 0, tmp_indis, i;

            if (comboBox1.SelectedIndex == 0)
            {
                for (i = 0; i < machine3.pazartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine3.pazartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine3.pazartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine3.pazartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                for (i = 0; i < machine3.sali.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine3.sali[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine3.sali[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine3.sali[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                for (i = 0; i < machine3.carsamba.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine3.carsamba[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine3.carsamba[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine3.carsamba[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                for (i = 0; i < machine3.persembe.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine3.persembe[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine3.persembe[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine3.persembe[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 4)
            {
                for (i = 0; i < machine3.cuma.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine3.cuma[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine3.cuma[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine3.cuma[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 5)
            {
                for (i = 0; i < machine3.cumartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine3.cumartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine3.cumartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine3.cumartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }
        }
        
        public void Machine4()
        {
            bool durum = false;
            string randevu_gunu = comboBox1.SelectedItem.ToString();
            double randevu_saati = Convert.ToDouble(comboBox2.SelectedItem);
            int randevu_uzunluk = Convert.ToInt32(comboBox3.SelectedItem), indis = 0, tmp_indis, i;

            if (comboBox1.SelectedIndex == 0)
            {
                for (i = 0; i < machine4.pazartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine4.pazartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine4.pazartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine4.pazartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                for (i = 0; i < machine4.sali.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine4.sali[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine4.sali[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine4.sali[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                for (i = 0; i < machine4.carsamba.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine4.carsamba[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine4.carsamba[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine4.carsamba[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                for (i = 0; i < machine4.persembe.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine4.persembe[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine4.persembe[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine4.persembe[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 4)
            {
                for (i = 0; i < machine4.cuma.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine4.cuma[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine4.cuma[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine4.cuma[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 5)
            {
                for (i = 0; i < machine4.cumartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine4.cumartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine4.cumartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine4.cumartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

        }
        public void Machine5()
        {
            bool durum = false;
            string randevu_gunu = comboBox1.SelectedItem.ToString();
            double randevu_saati = Convert.ToDouble(comboBox2.SelectedItem);
            int randevu_uzunluk = Convert.ToInt32(comboBox3.SelectedItem), indis = 0, tmp_indis, i;

            if (comboBox1.SelectedIndex == 0)
            {
                for (i = 0; i < machine5.pazartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine5.pazartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine5.pazartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine5.pazartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                for (i = 0; i < machine5.sali.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine5.sali[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine5.sali[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine5.sali[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                for (i = 0; i < machine5.carsamba.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine5.carsamba[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine5.carsamba[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine5.carsamba[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                for (i = 0; i < machine5.persembe.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine5.persembe[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine5.persembe[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine5.persembe[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 4)
            {
                for (i = 0; i < machine5.cuma.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine5.cuma[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine5.cuma[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine5.cuma[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

            if (comboBox1.SelectedIndex == 5)
            {
                for (i = 0; i < machine5.cumartesi.Length - 10; i++)
                {
                    if (Convert.ToDouble(comboBox2.SelectedItem) == machine5.cumartesi[i, 0])
                    {
                        indis = i;
                    }
                }

                tmp_indis = indis;

                for (int s = 0; s < randevu_uzunluk; s++)
                {

                    if (machine5.cumartesi[tmp_indis, 1] == 1)
                    {

                        MessageBox.Show("Randevu alamazsiniz saat dolu");
                        durum = false;
                        break;
                    }
                    else { durum = true; }
                    tmp_indis++;
                }


                if (durum)
                {
                    MessageBox.Show("Randevu Kaydınız Başarıyla Oluşturuldu");
                    patient.date = randevu_gunu;
                    patient.hours = randevu_saati;

                    for (int y = 0; y < randevu_uzunluk; y++)
                    {
                        machine5.cumartesi[indis, 1] = 1;
                        indis++;
                    }

                    patient.room = Convert.ToString(comboBox5.SelectedItem);
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dialysis_Center_Appointment_System.Appointment a1 = new Dialysis_Center_Appointment_System.Appointment();
            a1.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
