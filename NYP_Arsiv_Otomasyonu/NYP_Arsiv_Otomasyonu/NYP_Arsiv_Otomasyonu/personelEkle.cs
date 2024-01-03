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
    public partial class personelEkle : Form
    {
        public personelEkle()
        {
            InitializeComponent();
           
            this.Controls.Add(personelekledata);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        private DataTable GetData(string sqlCommand)
        {


            MySqlCommand command = new MySqlCommand(sqlCommand, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }

        void TabloyuDoldur()
        {
            connection.Open();
            bindingSource1.DataSource = GetData("Select * From personal");
            personelekledata.DataSource = bindingSource1;
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void personelEkle_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();

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
            personelEkleTxt.BackColor = Color.FromArgb(58, 86, 131);
            AdSoyad.ForeColor = Color.FromArgb(58, 86, 131);
            adSoyadTxt.ForeColor = Color.FromArgb(58, 86, 131);
            kullaniciAdi.ForeColor = Color.FromArgb(58, 86, 131);
            kullaniciAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            unvanComboBox.ForeColor = Color.FromArgb(58, 86, 131);
            sifre.ForeColor = Color.FromArgb(58, 86, 131);
            SifreTxt.ForeColor = Color.FromArgb(58, 86, 131);
            silButton.BackColor = Color.FromArgb(58, 86, 131);
            düzenleButton.BackColor = Color.FromArgb(58, 86, 131);
            ekleButton.BackColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            personelekledata.DefaultCellStyle.ForeColor = Color.FromArgb(58, 86, 131);

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
            ArsivSayfasi arsivsayfası = new ArsivSayfasi();
            arsivsayfası.ShowDialog();
            this.Close();
        }

        private void arsivTxt_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivsayfası = new ArsivSayfasi();
            arsivsayfası.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriButton_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri();
            teslimBilgileri.ShowDialog();
            this.Close();
        }

        private void teslimBilgileriTxt_Click(object sender, EventArgs e)
        {
            teslimbilgileri teslimBilgileri = new teslimbilgileri();
            teslimBilgileri.ShowDialog();
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
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO personal (Adi_Soyadi,Kullanici_Adi,Parola,Unvan) VALUES (@p0,@p1,@p2,@p3)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", adSoyadTxt.Text);
            commandToAdd.Parameters.AddWithValue("@p1", kullaniciAdiTxt.Text);
            commandToAdd.Parameters.AddWithValue("@p2", SifreTxt.Text);
            commandToAdd.Parameters.AddWithValue("@p3", unvanComboBox.Text);


            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();

            MessageBox.Show("Personel Eklendi!");
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string deleteSql = "DELETE FROM personal WHERE Kullanici_Adi = @1";
            MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection);
            if (connection.State == ConnectionState.Open)
            {
                deleteCommand.Parameters.AddWithValue
                        ("@1", kullaniciAdiTxt.Text);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Persomel Silindi!");
                connection.Close();
                TabloyuDoldur();
            }
        }

        private void düzenleButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("update personal set Adi_Soyadi='" + adSoyadTxt.Text + "',Parola='" + SifreTxt.Text + "',Unvan='" + unvanComboBox.Text + "' where Kullanici_Adi='" +kullaniciAdiTxt.Text + "'", connection);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Güncellendi");
            connection.Close();

            TabloyuDoldur();
        }

        private void personelekledata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = personelekledata.SelectedCells[0].RowIndex;
            string Adi_Soyadi = personelekledata.Rows[seçilialan].Cells[1].Value.ToString();
            string Kullanici_Adi = personelekledata.Rows[seçilialan].Cells[2].Value.ToString();
            string Parola = personelekledata.Rows[seçilialan].Cells[3].Value.ToString();
            string Unvan = personelekledata.Rows[seçilialan].Cells[4].Value.ToString();
           
            adSoyadTxt.Text = Adi_Soyadi;
            kullaniciAdiTxt.Text = Kullanici_Adi;
            SifreTxt.Text = Parola;
            unvanComboBox.Text = Unvan;
            
        }

        private void unvanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
