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
    public partial class ArsivSayfasi : Form
    {
        private string kullaniciAdi;
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }


        public ArsivSayfasi(string kullaniciAdi)
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            this.kullaniciAdi = kullaniciAdi;

            getUserData(kullaniciAdi);
        }

        public ArsivSayfasi()
        {
            InitializeComponent();
        }

        public void getUserData(string kullaniciAdi)
        {
            // SQL Server bağlantı dizesi
            string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;";

            // SqlConnection nesnesi oluşturulması
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Bağlantı açılır
                    connection.Open();

                    // SQL sorgusu
                    //string sqlQuery = @"SELECT * FROM personal WHERE Kullanici_Adi='${kullaniciAdi}'";
                    string sqlQuery = "SELECT * FROM personal WHERE Kullanici_Adi='" + kullaniciAdi + "'";


                    // SqlCommand nesnesi oluşturulması
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // SqlDataReader nesnesi ile verilerin okunması
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Verilerin işlenmesi
                            while (reader.Read())
                            {
                                string isim;
                                
                                // Örneğin, verilerin bir TextBox'a yazdırılması
                                isim = reader["Adi_Soyadi"].ToString();
                                //Console.WriteLine(isim_soyisim);
                                //MessageBox.Show(isim_soyisim);

                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumu
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
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
            teslimbilgileri tslm = new teslimbilgileri(kullaniciAdi);
            tslm.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EvrakGoruntule evrakGoruntule = new EvrakGoruntule(kullaniciAdi);
            evrakGoruntule.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            eklearsiv eklarsv = new eklearsiv(kullaniciAdi);
            eklarsv.ShowDialog();
            this.Close();
        }
        

        private void ArsivSayfasi_Load(object sender, EventArgs e)
        {
           var user = new User(kullaniciAdi);

            if (user.user_name == "admin")
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }

            /*if (girisTuru == 1)
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }
            */

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

            EvrakGoruntule evrakGoruntule = new EvrakGoruntule(kullaniciAdi);
            evrakGoruntule.ShowDialog();
            this.Close();
        }

        private void ajandaTxt_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa(kullaniciAdi);
            anasayfa.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri tslm = new teslimbilgileri(kullaniciAdi);
            tslm.ShowDialog();
            this.Close();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle(kullaniciAdi);
            personelekle.ShowDialog();
            this.Close();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle(kullaniciAdi);
            personelekle.ShowDialog();
            this.Close();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            ProfilSayfasi profilsayfasi = new ProfilSayfasi(kullaniciAdi);
            profilsayfasi.ShowDialog();
            this.Close();
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
             ProfilSayfasi profilsayfasi = new ProfilSayfasi(kullaniciAdi);
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
            eklearsiv eklarsv = new eklearsiv(kullaniciAdi);
            eklarsv.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EvrakDüzenle evrakDüzenle = new EvrakDüzenle(kullaniciAdi);
            evrakDüzenle.ShowDialog();
            this.Close();
        }

        private void evrakDuzenleTxt_Click(object sender, EventArgs e)
        {
            EvrakDüzenle evrakDüzenle = new EvrakDüzenle(kullaniciAdi);
            evrakDüzenle.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
