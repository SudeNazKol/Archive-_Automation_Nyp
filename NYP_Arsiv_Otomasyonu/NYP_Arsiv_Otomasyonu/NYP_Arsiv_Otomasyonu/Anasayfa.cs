using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NYP_Arsiv_Otomasyonu
{
    public partial class anaSayfa : Form
    {

        private string kullaniciAdi;
        private string isim_soyisim;
        private string veri;
        private string rol;
        private User user;
        internal User User { get => user; set => user = value; }


        public anaSayfa(string kullaniciAdi)
        {

            InitializeComponent();
            webBrowser1.Navigate("http://uludag.edu.tr/duyuru/index");
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            this.kullaniciAdi = kullaniciAdi;
            //lblKullaniciAdi.Text = "Hoşgeldin "+kullaniciAdi;
            getUserData(kullaniciAdi);

            var user = new User(kullaniciAdi);
        }
        public anaSayfa()
        {

        }

        /*
         1- SQL select sorgusu yazacağız.
         2- Koşul olacak. koşul kullanici adi olacak.
         Yani: "SELECT * FROM personal WHERE Kullanici_Adi=kullaniciAdi"
         Bu sorgu sadece istediğimiz kullanici adina sahip olan kişinin verilerini getirecek.
         1 tane veri gelecek.
         veri[0]: id, veri[1]: adsoyad, veri[2]: Kullanici_Adi
         lblKullaniciAdi.Text = veri[1].ToString();
         
         */



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
                    string sqlQuery = "SELECT * FROM personal WHERE Kullanici_Adi='"+ kullaniciAdi +"'";


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

                                lblKullaniciAdi.Text = "Hoşgeldin " + reader["Adi_Soyadi"].ToString();
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



       
        //constructor: class çalışıtğı anda ilk çalışan metod.
        //sınıf ismi aynı isimde olan bir metod.

        //public int girisTuru;
        //public string ad;

        
        private void girisSayfası_Load(object sender, EventArgs e)
        { 
            var user = new User(kullaniciAdi);
            if (user.user_name =="admin")
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }
            


           /* if(rol == "admin")
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }*/

            /*if(girisTuru==1)
            {
                personelEkleButton.Visible = true;
                personelEkleTxt.Visible = true;
            }*/
            pictureBox1.BackColor = Color.FromArgb(58, 86, 131);
            notlarTxt.BackColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            textBox1.ForeColor = Color.FromArgb(58, 86, 131);
            lblKullaniciAdi.ForeColor = Color.FromArgb(58, 86, 131);
            arsivButton.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriButton.BackColor = Color.FromArgb(58, 86, 131);
            profilButton.BackColor = Color.FromArgb(58, 86, 131);
           exitButton.BackColor= Color.FromArgb(58, 86, 131);
            kaydetButton.BackColor = Color.FromArgb(58, 86, 131);
            arsivTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimBilgileriTxt.BackColor = Color.FromArgb(58, 86, 131);
            profilTxt.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleButton.BackColor = Color.FromArgb(58, 86, 131);
            personelEkleTxt.BackColor = Color.FromArgb(58, 86, 131);
            pictureBox7.BackColor = Color.FromArgb(43, 67, 106);
            ajandaButton.BackColor = Color.FromArgb(43, 67, 106);
            ajandaTxt.BackColor = Color.FromArgb(43, 67, 106);
            ajandaButton.BringToFront();
            ajandaTxt.BringToFront();
            
            
                // SQL sorgusu
                string query = "SELECT * FROM notlar";

            // SQL bağlantısını açın

            connection.Open();

            // SQL komutunu oluşturun
            using (MySqlCommand command = new MySqlCommand(query, connection))

            {
                // Veriyi okuyun
                MySqlDataReader reader = command.ExecuteReader();
                {
                    // Veriyi TextBox'a yükleyin
                    while (reader.Read());
                    {
                        textBox1.Text += reader["notlar"].ToString() + Environment.NewLine;
                    }

                    // Okuyucuyu kapatın
                    reader.Close();
                }

            }
                
        connection.Close();
        }
        

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi(kullaniciAdi);
            arsivSayfasi.ShowDialog();
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
            teslimbilgileri tslm = new teslimbilgileri(kullaniciAdi);
            tslm.ShowDialog();
            this.Hide();
        }

        private void personelEkleButton_Click(object sender, EventArgs e)
        {
            
            personelEkle prs = new personelEkle(kullaniciAdi);
            prs.ShowDialog();
            this.Hide();
        }

        private void arsivTxt_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivSayfasi = new ArsivSayfasi(kullaniciAdi);
            arsivSayfasi.ShowDialog();
            this.Hide();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri tslm = new teslimbilgileri(kullaniciAdi);
            tslm.ShowDialog();
            this.Hide();
        }

        private void personelEkleTxt_Click(object sender, EventArgs e)
        {
            personelEkle prs = new personelEkle(kullaniciAdi);
            prs.ShowDialog();
            this.Hide();
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
            ProfilSayfasi profilsayfasi = new ProfilSayfasi(kullaniciAdi);
            profilsayfasi.ShowDialog();
            this.Hide();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {

            ProfilSayfasi profilsayfasi = new ProfilSayfasi (kullaniciAdi);
            profilsayfasi.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void ajandaButton_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MysqlCommand = "SELECT name FROM mytable WHERE not = 1";
            TextBox textBox1 = new TextBox();
            connection.Close();
            
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kaydet = "INSERT INTO notlar (notlar) VALUES (@p1)";
            MySqlCommand insertCommand = new MySqlCommand(kaydet, connection);
            if (connection.State == ConnectionState.Open)
            {
                insertCommand.Parameters.AddWithValue("@p1", textBox1.Text);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Not Kaydedildi!");
                connection.Close();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void avatar_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
