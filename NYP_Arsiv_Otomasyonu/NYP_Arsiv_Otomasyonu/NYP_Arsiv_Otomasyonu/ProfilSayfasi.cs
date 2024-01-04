using MySql.Data.MySqlClient;
using System;
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
    public partial class ProfilSayfasi : Form
    {
        private MySqlConnection connection;
        private User loggedInUser;

        public ProfilSayfasi()
        {
            InitializeComponent();
            
        }


        public ProfilSayfasi(MySqlConnection connection, User user)
        {
            this.connection = connection;
            this.loggedInUser = user;
            InitializeComponent();
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            // Kullanıcının bilgilerini form kontrollerine atayarak görüntüleme yapabilirsiniz.
            // Örneğin:
            labelAdSoyad.Text = "Ad Soyad: " + loggedInUser.AdSoyad;
            labelKullaniciAdi.Text = "Kullanıcı Adı: " + loggedInUser.KullaniciAdi;
            labelUnvan.Text = "Unvan: " + loggedInUser.Unvan;
            labelSifre.Text = "Şifre: " + loggedInUser.Sifre;
        }


















        private void ProfilSayfasi_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(58, 86, 131);
           

            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            
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
            adSoyad.ForeColor = Color.FromArgb(58, 86, 131);
            kullaniciAdi.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            sifre.ForeColor = Color.FromArgb(58, 86, 131);
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
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi();
            arsivSayfasi.ShowDialog();
            this.Close();
        }

        private void arsivTxt_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi();
            arsivSayfasi.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri Teslimbilgileri = new teslimbilgileri();
            Teslimbilgileri.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri Teslimbilgileri = new teslimbilgileri();
            Teslimbilgileri.ShowDialog();
            this.Close();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle();
            personelekle.ShowDialog();
            this.Close();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle();
            personelekle.ShowDialog();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void labelKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
