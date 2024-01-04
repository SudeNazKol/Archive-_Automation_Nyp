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
       /* private string kullaniciAdi;
        private MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");

        public ProfilSayfasi(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }


        private void VeritabanindanBilgileriCek()
        {
            try
            {
                connection.Open();
                string query = "SELECT Adi_Soyadi, Unvan FROM personal WHERE Kullanici_Adi = @labelKullaniciAdi";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullaniciAdi", labelullaniciAdi);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string adSoyad = reader["Adi_Soyadi"].ToString();
                        string unvan = reader["Unvan"].ToString();

                        labelAdSoyad.Text = "Ad Soyad: " + adSoyad;
                        labelUnvan.Text = "Unvan: " + unvan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından bilgileri çekerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    
        */


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
            kullaniciAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            sifre.ForeColor = Color.FromArgb(58, 86, 131);

            //labelKullaniciAdi.Text = "Kullanıcı Adı: " + kullaniciAdi;
           // VeritabanindanBilgileriCek();
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

        private void labelAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void labelUnvan_Click(object sender, EventArgs e)
        {

        }

        private void labelSifre_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
