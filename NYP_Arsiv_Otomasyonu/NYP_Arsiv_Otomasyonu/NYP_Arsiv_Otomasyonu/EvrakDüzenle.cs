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
    public partial class EvrakDüzenle : Form
    {
        public EvrakDüzenle()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void EvrakDüzenle_Load(object sender, EventArgs e)
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
            evrakAdi.ForeColor = Color.FromArgb(58, 86, 131);
           evrakAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakDüzenlemeTarihi.ForeColor = Color.FromArgb(58, 86, 131);
            evrakDuzenlemeTarihiDateTime.ForeColor = Color.FromArgb(58, 86, 131);
            evrakKodu.ForeColor = Color.FromArgb(58, 86, 131);
            evrakKoduTxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            unvanComboBox.ForeColor = Color.FromArgb(58, 86, 131);
            duzenlemeNedeni.ForeColor = Color.FromArgb(58, 86, 131);
            duzenlemeNedeniTxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakEkleButton.BackColor = Color.FromArgb(58, 86, 131);
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
            teslimbilgileri TeslimBilgileri = new teslimbilgileri();
            TeslimBilgileri.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri TeslimBilgileri = new teslimbilgileri();
            TeslimBilgileri.ShowDialog();
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

        private void profilButton_Click(object sender, EventArgs e)
        {
           /* ProfilSayfasi profilSayfasi = new ProfilSayfasi();
            profilSayfasi.ShowDialog();
            this.Close();*/
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
            /* ProfilSayfasi profilSayfasi = new ProfilSayfasi();
           profilSayfasi.ShowDialog();
           this.Close();*/
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSAyfasi = new GirisSayfası();
            girisSAyfasi.ShowDialog();
            this.Close();
        }
    }
}
