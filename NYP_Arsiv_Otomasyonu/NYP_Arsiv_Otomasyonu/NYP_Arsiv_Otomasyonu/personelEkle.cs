﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_Arsiv_Otomasyonu
{
    public partial class personelEkle : Form
    {
        public personelEkle()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void personelEkle_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(58, 86, 131);
           
            ajandaButton.BackColor = Color.FromArgb(58, 86, 131);
            arsivButton.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriButton.BackColor = Color.FromArgb(58, 86, 131);
            profilButton.BackColor = Color.FromArgb(58, 86, 131);
            exitButton.BackColor = Color.FromArgb(58, 86, 131);
            ajandaTxt.BackColor = Color.FromArgb(58, 86, 131);
            arsivTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriTxt.BackColor = Color.FromArgb(58, 86, 131);
            profilTxt.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleButton.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleTxt.BackColor = Color.FromArgb(58, 86, 131);
            AdSoyad.ForeColor = Color.FromArgb(58, 86, 131);
            adSoyadTxt.ForeColor = Color.FromArgb(58, 86, 131);
            kullaniciAdi.ForeColor = Color.FromArgb(58, 86, 131);
            kullaniciAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            unvanComboBox.ForeColor = Color.FromArgb(58, 86, 131);
            sifre.ForeColor = Color.FromArgb(58, 86, 131);
            SifreTxt.ForeColor = Color.FromArgb(58, 86, 131);
            silButton.BackColor = Color.FromArgb(58, 86, 131);
            düzenleButton.BackColor = Color.FromArgb(58, 86, 131);
            ekleButton.BackColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);

        }

        private void ajandaButton_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.ShowDialog();
            this.Close();
        }

        private void ajandaTxt_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.ShowDialog();
            this.Close();
        }

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivsayfası = new ArsivSayfasi();
            arsivsayfası.ShowDialog();
            this.Close();
        }

        private void arsivTxt_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivsayfası = new ArsivSayfasi();
            arsivsayfası.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri();
            teslimBilgileri.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri();
            teslimBilgileri.ShowDialog();
            this.Close();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
          /*  ProfilSayfasi profilsayfasi = new ProfilSayfasi();
            profilsayfasi.ShowDialog();
            this.Close();*/
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
            /*  ProfilSayfasi profilsayfasi = new ProfilSayfasi();
            profilsayfasi.ShowDialog();
            this.Close();*/
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.ShowDialog();
            this.Close();
        }
    }
}
