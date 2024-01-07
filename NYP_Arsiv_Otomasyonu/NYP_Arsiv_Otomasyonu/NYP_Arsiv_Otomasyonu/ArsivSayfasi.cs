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
    public partial class ArsivSayfasi : Form
    {
        public ArsivSayfasi()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void ajandaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri tslm = new teslimbilgileri();
            tslm.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EvrakGoruntule evrakGoruntule = new EvrakGoruntule();
            evrakGoruntule.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            eklearsiv eklarsv = new eklearsiv();
            eklarsv.ShowDialog();
            this.Close();
        }

        private void ArsivSayfasi_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox2.BackColor = Color.FromArgb(58, 86, 131);
            arsivButton.BackColor = Color.FromArgb(58, 86, 131);
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
            evrakGoruntuleTxt.BackColor = Color.FromArgb(58, 86, 131);
            evrakDuzenleTxt.BackColor = Color.FromArgb(58, 86, 131);
            evrakEkleTxt.BackColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox3.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox4.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox5.BackColor = Color.FromArgb(58, 86, 131);
            ajandaButton.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox7.BackColor = Color.FromArgb(43, 67, 106);
            arsivTxt.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BringToFront();
            arsivTxt.BringToFront();
        }

        private void evrakGoruntuleTxt_Click(object sender, EventArgs e)
        {

            EvrakGoruntule evrakGoruntule = new EvrakGoruntule();
            evrakGoruntule.ShowDialog();
            this.Close();
        }

        private void ajandaTxt_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa("");
            anasayfa.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri tslm = new teslimbilgileri();
            tslm.ShowDialog();
            this.Close();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle();
            personelekle.ShowDialog();
            this.Close();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle();
            personelekle.ShowDialog();
            this.Close();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            ProfilSayfasi profilsayfasi = new ProfilSayfasi();
            profilsayfasi.ShowDialog();
            this.Close();
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
             ProfilSayfasi profilsayfasi = new ProfilSayfasi();
           profilsayfasi.ShowDialog();
           this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfasi = new GirisSayfası();
            girisSayfasi.ShowDialog();
            this.Close();
        }

        private void evrakEkleTxt_Click(object sender, EventArgs e)
        {
            eklearsiv eklarsv = new eklearsiv();
            eklarsv.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EvrakDüzenle evrakDüzenle = new EvrakDüzenle();
            evrakDüzenle.ShowDialog();
            this.Close();
        }

        private void evrakDuzenleTxt_Click(object sender, EventArgs e)
        {
            EvrakDüzenle evrakDüzenle = new EvrakDüzenle();
            evrakDüzenle.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
    
}
