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
    public partial class GirisSayfası : Form
    {
        public GirisSayfası()
        {
            InitializeComponent();
        }

        private void GirisSayfası_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(58, 86, 131);
            adSoyadTxt.BackColor = Color.FromArgb(58, 86, 131);
            sifreTxt.BackColor = Color.FromArgb(58, 86, 131);
            girisButton.ForeColor = Color.FromArgb(58, 86, 131);
        }
        public int girisTuru;
        private void girisButton_Click(object sender, EventArgs e)
        {
            

            this.Hide();

            if (girisTuru==0||girisTuru>3)
            {
                MessageBox.Show("Giriş Türü Seçiniz");
            }
            else
            {
                anaSayfa anasayfa = new anaSayfa();
                if (girisTuru == 1)
                {
                    anasayfa.girisTuru = 1;
                }
                

                anasayfa.ShowDialog();
                
            }
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            girisTuru = 1;
        }

        private void ogrenciIsleriRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            girisTuru = 2;


        }


        private void adSoyadTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sifreTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
