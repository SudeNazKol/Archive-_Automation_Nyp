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

        //kullaniciAdi

        public ProfilSayfasi (string kullaniciAdi)
        {

            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            this.kullaniciAdi = kullaniciAdi;
            var user = new User(kullaniciAdi);
            getUserData(kullaniciAdi);
        }
        public ProfilSayfasi()
        {

        }

        public int girisTuru;

        private string kullaniciAdi;
        private string isim_soyisim;
        private User user;
        internal User User { get => user; set => user = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }

        

        private void ProfilSayfasi_Load(object sender, EventArgs e)
        {
            var user = new User(kullaniciAdi);
            if (user.user_name == "admin")
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }
            

            /*
            if (girisTuru == 1)
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }*/

            pictureBox1.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox2.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox3.BackColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            
            ajandaButton.BackColor = Color.FromArgb(58, 86, 131);
            arsivButton.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriButton.BackColor = Color.FromArgb(58, 86, 131);
            
            exitButton.BackColor = Color.FromArgb(58, 86, 131);
            ajandaTxt.BackColor = Color.FromArgb(58, 86, 131);
            arsivTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriTxt.BackColor = Color.FromArgb(58, 86, 131);
           
            personelEkleButton.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleTxt.BackColor = Color.FromArgb(58, 86, 131);
            adSoyad.ForeColor = Color.FromArgb(58, 86, 131);
            kullaniciAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            sifre.ForeColor = Color.FromArgb(58, 86, 131);
            labelAdSoyad.ForeColor = Color.FromArgb(58, 86, 131);
            labelKullaniciAdi.ForeColor = Color.FromArgb(58, 86, 131);
            labelSifre.ForeColor = Color.FromArgb(58, 86, 131);
            labelUnvan.ForeColor = Color.FromArgb(58, 86, 131);
            pictureBox7.BackColor = Color.FromArgb(43, 67, 106);
            profilButton.BackColor = Color.FromArgb(43, 67, 106);
           profilTxt.BackColor = Color.FromArgb(43, 67, 106);
            pictureBox2.BringToFront();
           profilButton.BringToFront();
            profilTxt.BringToFront();
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
                                // Örneğin, verilerin bir TextBox'a yazdırılması
                                isim_soyisim = reader["Adi_Soyadi"].ToString();
                                //Console.WriteLine(isim_soyisim);
                                //MessageBox.Show(isim_soyisim);

                                labelAdSoyad.Text = reader["Adi_Soyadi"].ToString();
                                labelKullaniciAdi.Text = reader["Kullanici_Adi"].ToString();
                                labelUnvan.Text = reader["Unvan"].ToString();
                                labelSifre.Text = reader["Parola"].ToString();
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
        private void ajandaButton_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa(kullaniciAdi);
            anasayfa.ShowDialog();
            this.Close();
        }

        private void ajandaTxt_Click(object sender, EventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa(kullaniciAdi);
            anasayfa.ShowDialog();
            this.Close();
        }

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi(kullaniciAdi);
            arsivSayfasi.ShowDialog();
            this.Close();
        }

        private void arsivTxt_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi(kullaniciAdi);
            arsivSayfasi.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri Teslimbilgileri = new teslimbilgileri(kullaniciAdi);
            Teslimbilgileri.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri Teslimbilgileri = new teslimbilgileri(kullaniciAdi);
            Teslimbilgileri.ShowDialog();
            this.Close();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle(kullaniciAdi);
            personelekle.ShowDialog();
            this.Close();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle personelekle = new personelEkle(kullaniciAdi);
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
