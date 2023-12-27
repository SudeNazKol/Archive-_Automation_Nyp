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
    public partial class eklearsiv : Form
    {
        public eklearsiv()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void eklearsiv_Load(object sender, EventArgs e)
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

            evrakAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakAdi.ForeColor = Color.FromArgb(58, 86, 131);
            evrakBırakmaTarihiDateTime.ForeColor = Color.FromArgb(58, 86, 131);
            evrakBırakmaTarihi.ForeColor = Color.FromArgb(58, 86, 131);
            evrakKodu.ForeColor = Color.FromArgb(58, 86, 131);
            evrekKoduTxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
           unvanComboBox.ForeColor = Color.FromArgb(58, 86, 131);
            evrakEkleButton.BackColor = Color.FromArgb(58, 86, 131);
           saatTxt.BackColor = Color.FromArgb(58, 86, 131);
        }

        private void ajandaButton_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri();
            teslimBilgileri.ShowDialog();
            this.Close();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle();
            personelekle.ShowDialog();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girissayfası = new GirisSayfası();
            girissayfası.ShowDialog();
            this.Close();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
           /* ProfilSayfası profilsayfası = new ProfilSayfası();
            profilsayfasi.ShowDialog();
            this.Close();*/
        }

        private void ajandaTxt_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri();
            teslimBilgileri.ShowDialog();
            this.Close();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle();
            personelekle.ShowDialog();
            this.Close();
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
            /* ProfilSayfası profilsayfası = new ProfilSayfası();
            profilsayfasi.ShowDialog();
            this.Close();*/
        }

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivsayfası = new ArsivSayfasi();
            arsivsayfası.ShowDialog();
            this.Close();
        }
    }
}
