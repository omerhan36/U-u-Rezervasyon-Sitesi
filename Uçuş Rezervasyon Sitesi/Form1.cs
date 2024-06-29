using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçuş_Rezervasyon_Sitesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + cbxNereden.Text + " - " + cbxNereye.Text + "Tarih: " + dateUcusTarihi.Text + "Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri ~ Ad: " + textBox1.Text + " TC: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        //Bu butona basıldığında Nereden comboboxunda yazan değer ile nereye comboboxunda yazan değer yer değiştirecektir.
        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = cbxNereye.Text;
            cbxNereye.Text = cbxNereden.Text;
            cbxNereden.Text = label9.Text;
        }
    }
}
