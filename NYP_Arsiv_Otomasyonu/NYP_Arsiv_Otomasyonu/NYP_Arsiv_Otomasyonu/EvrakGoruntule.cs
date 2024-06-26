﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_Arsiv_Otomasyonu
{
    public partial class EvrakGoruntule : Form
    {
        private string kullaniciAdi;
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }

        public EvrakGoruntule(string kullaniciAdi)
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            
            this.kullaniciAdi=kullaniciAdi;
            this.Controls.Add(evraklistelemedata);
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        private DataTable GetData(string sqlCommand)
        {


            MySqlCommand command = new MySqlCommand(sqlCommand, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }

        void TabloyuDoldur()
        {
            connection.Open();
            bindingSource1.DataSource = GetData("Select * From archives");
            evraklistelemedata.DataSource = bindingSource1;
            connection.Close();
        }
        public int girisTuru;

        private void EvrakGoruntule_Load(object sender, EventArgs e)
        {
            var user = new User(kullaniciAdi);

            if (user.user_name == "admin")
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }


            TabloyuDoldur();
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
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            aratxt.ForeColor = Color.FromArgb(58, 86, 131);
            label1.ForeColor = Color.FromArgb(58, 86, 131);
            label2.ForeColor = Color.FromArgb(58, 86, 131);
            evraklistelemedata.DefaultCellStyle.ForeColor = Color.FromArgb(58, 86, 131);
            pictureBox7.BackColor = Color.FromArgb(43, 67, 106);
            arsivTxt.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BringToFront();
            arsivTxt.BringToFront();
            label2.Text = $"{evraklistelemedata.RowCount-1}";
        }

        private void ajandaButton_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa(kullaniciAdi);
            anasayfa.ShowDialog();
            this.Hide();
        }

        private void ajandaTxt_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa(kullaniciAdi);
            anasayfa.ShowDialog();
            this.Hide();
        }

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi(kullaniciAdi);
            arsivSayfasi.ShowDialog();
            this.Hide();
        }

        private void arsivTxt_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi(kullaniciAdi);
            arsivSayfasi.ShowDialog();
            this.Hide();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri(kullaniciAdi);
            teslimBilgileri.ShowDialog();
            this.Hide();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri(kullaniciAdi);
            teslimBilgileri.ShowDialog();
            this.Hide();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle(kullaniciAdi);
            personelekle.ShowDialog();
            this.Hide();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle(kullaniciAdi);
            personelekle.ShowDialog();
            this.Hide();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
           ProfilSayfasi profilsayfasi = new ProfilSayfasi(kullaniciAdi);
            profilsayfasi.ShowDialog();
            this.Hide();
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
             ProfilSayfasi profilsayfasi = new ProfilSayfasi(kullaniciAdi);
            profilsayfasi.ShowDialog();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.ShowDialog();
            this.Hide();
        }

        private void aratxt_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from archives where Konum like '%" + aratxt.Text + "%'", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            evraklistelemedata.DataSource = ds.Tables[0];
            connection.Close();
            label2.Text = $"{evraklistelemedata.RowCount-1}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aratxt_TextChanged_1(object sender, EventArgs e)
        {
             connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from archives where Konum like '%" + aratxt.Text + "%'", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
             evraklistelemedata.DataSource = ds.Tables[0];
            connection.Close(); 
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void evraklistelemedata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
