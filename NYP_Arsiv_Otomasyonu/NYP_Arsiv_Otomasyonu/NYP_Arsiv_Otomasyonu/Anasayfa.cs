using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_Arsiv_Otomasyonu
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://uludag.edu.tr/duyuru/index");
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        public int girisTuru;
        private void girisSayfası_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(58, 86, 131);
            notlarTxt.BackColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            searchButton.BackColor = Color.FromArgb(58, 86, 131);
            ajandaButton.BackColor = Color.FromArgb(58, 86, 131);
            arsivButton.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriButton.BackColor = Color.FromArgb(58, 86, 131);
            profilButton.BackColor = Color.FromArgb(58, 86, 131);
           exitButton.BackColor= Color.FromArgb(58, 86, 131);
            ajandaTxt.BackColor = Color.FromArgb(58, 86, 131);
            arsivTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriTxt.BackColor = Color.FromArgb(58, 86, 131);
            profilTxt.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleButton.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleTxt.BackColor = Color.FromArgb(58, 86, 131);
            if(girisTuru==1)
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }
        }

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfası arsivSayfası = new ArsivSayfası();
            arsivSayfası.ShowDialog();
           this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.ShowDialog();
            this.Hide();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri tslm = new teslimbilgileri();
            tslm.ShowDialog();
            this.Hide();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle prs = new personelEkle();
            prs.ShowDialog();
            this.Hide();
        }
    }
}
