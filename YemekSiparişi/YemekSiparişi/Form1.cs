using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string isim;
        string tarih;
        string adres;

        private void button1_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            tarih = dateTimePicker1.Text;
            adres = textBox2.Text;
            MessageBox.Show(isim + ", Siparişiniz " + tarih + " Tarihine Alındı, Adres : " + adres);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            MessageBox.Show(isim + " Siparişiniz İptal Edildi");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim = comboBox1.SelectedItem.ToString();
            switch (secim)
            {
                case "Kebap":
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\kebapresmi.jpg";
                    break;
                case "Döner":
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\döner.jpg";
                    break;
                case "Hamburger":
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\hamburger.jpg";
                    break;
                case "Pirzola":
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\pirzola.jpg";
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
