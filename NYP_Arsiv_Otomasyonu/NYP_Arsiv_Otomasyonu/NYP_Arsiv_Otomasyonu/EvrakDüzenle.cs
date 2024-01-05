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
    public partial class EvrakDüzenle : Form
    {
        public EvrakDüzenle()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            this.Controls.Add(evrakduzenledata);
            InitializeDateTimePicker();
        }
        private void InitializeDateTimePicker()
        {
            evrakduzenlemedate.Format = DateTimePickerFormat.Custom;
            evrakduzenlemedate.CustomFormat = "dd-MM-yyyy";
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        private void EvrakDüzenle_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();
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
            evrakaditxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakDüzenlemeTarihi.ForeColor = Color.FromArgb(58, 86, 131);
            evrakduzenlemedate.ForeColor = Color.FromArgb(58, 86, 131);
            evrakKodu.ForeColor = Color.FromArgb(58, 86, 131);
            evrakkodutxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
            unvancombobox.ForeColor = Color.FromArgb(58, 86, 131);
            evraksilbutton.BackColor = Color.FromArgb(58, 86, 131);
            evragınTuru.ForeColor = Color.FromArgb(58, 86, 131);
            evragınTuruComboBox.ForeColor = Color.FromArgb(58, 86, 131);
            rafNo.ForeColor = Color.FromArgb(58, 86, 131);
            rafNoTxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakdüzeneklebutton.BackColor = Color.FromArgb(58, 86, 131);
            evrakduzenledata.DefaultCellStyle.ForeColor = Color.FromArgb(58, 86, 131);
            pictureBox7.BackColor = Color.FromArgb(43, 67, 106);
            arsivTxt.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BringToFront();
            arsivTxt.BringToFront();
        }
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
            bindingSource1.DataSource = GetData("Select * From archives");
            evrakduzenledata.DataSource = bindingSource1;
            connection.Close();
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
             ProfilSayfasi profilSayfasi = new ProfilSayfasi();
             profilSayfasi.ShowDialog();
             this.Close();
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
           ProfilSayfasi profilSayfasi = new ProfilSayfasi();
           profilSayfasi.ShowDialog();
           this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSAyfasi = new GirisSayfası();
            girisSAyfasi.ShowDialog();
            this.Close();
        }

        private void evrakAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void evrakdüzeneklebutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("update archives set Evrak_Adi='" + evrakaditxt.Text + "', Unvan='" + unvancombobox.Text + "', Evrak_Tarih='" + evrakduzenlemedate.Text +"',Evrak_Turu='" + evragınTuruComboBox + "',Raf_No='" + rafNoTxt.Text + "'  where Konum='" + evrakkodutxt.Text + "'", connection);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            connection.Close();
            TabloyuDoldur();
        }

        private void evrakduzenledata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = evrakduzenledata.SelectedCells[0].RowIndex;
            string Evrak_Adi = evrakduzenledata.Rows[seçilialan].Cells[1].Value.ToString();
            string Unvan = evrakduzenledata.Rows[seçilialan].Cells[2].Value.ToString();
            string Evrak_Tarih = evrakduzenledata.Rows[seçilialan].Cells[3].Value.ToString();
            string Konum = evrakduzenledata.Rows[seçilialan].Cells[4].Value.ToString();
            string Evrak_Turu = evrakduzenledata.Rows[seçilialan].Cells[5].Value.ToString();
            string Raf_No = evrakduzenledata.Rows[seçilialan].Cells[6].Value.ToString();


            evrakaditxt.Text = Evrak_Adi;
            unvancombobox.Text = Unvan;
            evrakduzenlemedate.Text = Evrak_Tarih;
            evrakkodutxt.Text = Konum;
            evragınTuruComboBox.Text = Evrak_Turu;
            rafNoTxt.Text = Raf_No;


        }

        private void evraksilbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string deleteSql = "DELETE FROM archives WHERE Konum = @3";
            MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection);
            if (connection.State == ConnectionState.Open)
            {
                deleteCommand.Parameters.AddWithValue
                        ("@3", evrakkodutxt.Text);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi!");
                connection.Close();
                TabloyuDoldur();
            }
        }

        private void evrakduzenlemedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void evragınTuruComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void evrakduzenledata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void evrakkodutxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
