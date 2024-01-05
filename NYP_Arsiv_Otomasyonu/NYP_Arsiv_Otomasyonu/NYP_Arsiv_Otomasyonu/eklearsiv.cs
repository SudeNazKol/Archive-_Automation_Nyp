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
    public partial class eklearsiv : Form
    {
        public eklearsiv()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            this.Controls.Add(eklearsivdata);
            InitializeDateTimePicker();
        }
         private void InitializeDateTimePicker()
        {
            evrakbırakmadate.Format = DateTimePickerFormat.Custom;
            evrakbırakmadate.CustomFormat = "dd-MM-yyyy";
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO archives (Evrak_Adi,Unvan,Evrak_Tarih,Konum,Evrak_Turu,Raf_No) VALUES (@p0,@p1,@p2,@p3,@p4,@p5)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", evrakaditxt.Text);
            commandToAdd.Parameters.AddWithValue("@p1", unvancombobox.Text);
            commandToAdd.Parameters.AddWithValue("@p2", evrakbırakmadate.Text);
            commandToAdd.Parameters.AddWithValue("@p3", evrakkodutxt.Text);
            commandToAdd.Parameters.AddWithValue("@p4", evragınTuruComboBox.Text);
            commandToAdd.Parameters.AddWithValue("@p5", rafNoTxt.Text);


            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();

            MessageBox.Show("Evrak Eklendi!");
            
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
            eklearsivdata.DataSource = bindingSource1;
            connection.Close();
        }
        private void eklearsiv_Load(object sender, EventArgs e)
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
            rafNo.ForeColor = Color.FromArgb(58, 86, 131);
            rafNoTxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakaditxt.ForeColor = Color.FromArgb(58, 86, 131);
            evrakAdi.ForeColor = Color.FromArgb(58, 86, 131);
            evrakbırakmadate.ForeColor = Color.FromArgb(58, 86, 131);
            evrakBırakmaTarihi.ForeColor = Color.FromArgb(58, 86, 131);
            evrakKodu.ForeColor = Color.FromArgb(58, 86, 131);
            evrakkodutxt.ForeColor = Color.FromArgb(58, 86, 131);
            unvan.ForeColor = Color.FromArgb(58, 86, 131);
           unvancombobox.ForeColor = Color.FromArgb(58, 86, 131);
            evrakEkleButton.BackColor = Color.FromArgb(58, 86, 131);
           saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            evragınTuru.ForeColor = Color.FromArgb(58, 86, 131);
            evragınTuruComboBox.ForeColor = Color.FromArgb(58, 86, 131);
            eklearsivdata.DefaultCellStyle.ForeColor = Color.FromArgb(58, 86, 131);
            pictureBox7.BackColor = Color.FromArgb(43, 67, 106);
            arsivTxt.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BackColor = Color.FromArgb(43, 67, 106);
            arsivButton.BringToFront();
            arsivTxt.BringToFront();

            // eklearsivdata.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9pt, FontStyle.Bold);
        }

        private void ajandaButton_Click(object sender, EventArgs e)
        {
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
            ProfilSayfasi profilsayfasi = new ProfilSayfasi();
            profilsayfasi.ShowDialog();
            this.Close();
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
             ProfilSayfasi profilsayfasi = new ProfilSayfasi();
            profilsayfasi.ShowDialog();
            this.Close();
        }

        private void arsivButton_Click(object sender, EventArgs e)
        {
            ArsivSayfasi arsivsayfası = new ArsivSayfasi();
            arsivsayfası.ShowDialog();
            this.Close();
        }

        private void evrakAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void eklearsivdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void evrakkodutxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
