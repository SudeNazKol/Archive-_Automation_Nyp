using MySql.Data.MySqlClient;
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
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();
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
        private void girisButton_Click(object sender, EventArgs e)
        {

            

            string kullaniciAdi = adSoyadTxt.Text;
            string sifre = sifreTxt.Text;


            if (AdminKontrol(kullaniciAdi, sifre))
            {
                this.Hide();               
                
            }

            if (GirisKontrol(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş Başarılı!");
                anaSayfa anasayfa = new anaSayfa();
                anasayfa.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
                GirisSayfası girissayfası= new GirisSayfası();
                girissayfası.ShowDialog(); 
            }
            this.Hide();

        }
        private bool AdminKontrol(string kullaniciAdi, string sifre)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM personal WHERE Kullanici_Adi = @kullaniciAdi AND Parola = @sifre AND Kullanici_Adi= 'admin'";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            command.Parameters.AddWithValue("@sifre", sifre);

            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return count > 0;
        }
        private bool GirisKontrol(string kullaniciAdi, string sifre)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM personal WHERE Kullanici_Adi = @kullaniciAdi AND Parola = @sifre";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            command.Parameters.AddWithValue("@sifre", sifre);

            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return count > 0;

        }
        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ogrenciIsleriRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void adSoyadTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sifreTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void adSoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
