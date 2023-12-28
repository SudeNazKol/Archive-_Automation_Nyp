using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NYP_Arsiv_Otomasyonu
{
    public partial class teslimbilgileri : Form
    {
        public teslimbilgileri()
        {
            InitializeComponent();
            saatTxt.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();


            this.Controls.Add(dgvKullanicilar);
            InitializeDateTimePicker();
        }
        private void InitializeDateTimePicker()
        {
            txtteslimalmatarih.Format = DateTimePickerFormat.Custom;
            txtteslimalmatarih.CustomFormat = "dd-MM-yyyy";
            txtteslimbırakmatarih.Format = DateTimePickerFormat.Custom;
            txtteslimbırakmatarih.CustomFormat = "dd-MM-yyyy";

        }


        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        
        private void label4_Click(object sender, EventArgs e)
        {

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
            bindingSource1.DataSource = GetData("Select * From users");
            dgvKullanicilar.DataSource = bindingSource1;
            connection.Close();
        }

        private void teslimbilgileri_Load(object sender, EventArgs e)
        { 
            int kayitsayisi =dgvKullanicilar.Rows.Count;
            label9.Text=kayitsayisi.ToString();
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
            evrakAdiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtevrakadı.ForeColor = Color.FromArgb(58, 86, 131);
            teslimAlanTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtteslimalan.ForeColor = Color.FromArgb(58, 86, 131);
            unvanTxt.ForeColor = Color.FromArgb(58, 86, 131);
            ünvancombo.ForeColor = Color.FromArgb(58, 86, 131);
            teslimAlmaTarihiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtteslimalmatarih.ForeColor = Color.FromArgb(58, 86, 131);
            teslimBırakmaTarihiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtteslimbırakmatarih.ForeColor = Color.FromArgb(58, 86, 131);
            teslimAlmaNedeniTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtteslimneden.ForeColor = Color.FromArgb(58, 86, 131);
            kodTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtkonum.ForeColor = Color.FromArgb(58, 86, 131);
            aranacakKodTxt.ForeColor = Color.FromArgb(58, 86, 131);
            txtara.ForeColor = Color.FromArgb(58, 86, 131);
            buttonekle.BackColor = Color.FromArgb(58, 86, 131);
            güncellebutton.BackColor = Color.FromArgb(58, 86, 131);
            silbutton.BackColor = Color.FromArgb(58, 86, 131);
            arabutton.BackColor = Color.FromArgb(58, 86, 131);
            katSayisiTxt.ForeColor = Color.FromArgb(58, 86, 131);
            label9.ForeColor = Color.FromArgb(58, 86, 131);
            saatTxt.BackColor = Color.FromArgb(58, 86, 131);
            TabloyuDoldur();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO users (Evrak_adi,Teslim_Alan,Unvan,Teslim_Alma_Tarihi,Teslim_Birakma_Tarihi,Teslim_Neden,Konum) VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", txtevrakadı.Text);
            commandToAdd.Parameters.AddWithValue("@p1", txtteslimalan.Text);
            commandToAdd.Parameters.AddWithValue("@p2", ünvancombo.Text);
            commandToAdd.Parameters.AddWithValue("@p3", txtteslimalmatarih.Text);
            commandToAdd.Parameters.AddWithValue("@p4", txtteslimbırakmatarih.Text);
            commandToAdd.Parameters.AddWithValue("@p5", txtteslimneden.Text);
            commandToAdd.Parameters.AddWithValue("@p6", txtkonum.Text);

            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
            
            MessageBox.Show("Eklendi!");




        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string deleteSql = "DELETE FROM users WHERE konum = @6";
            MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection);
            if (connection.State == ConnectionState.Open)
            {
                deleteCommand.Parameters.AddWithValue
                        ("@6", txtkonum.Text);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi!");
                connection.Close();
                TabloyuDoldur();
               
            }
        }

        private void güncelbutton_Click(object sender, EventArgs e)
        {
            connection.Open ();
            MySqlCommand komut = new MySqlCommand("update users set Evrak_adi='" + txtevrakadı.Text + "',Teslim_Alan='" + txtteslimalan.Text + "',Unvan='" + ünvancombo.Text +  "',Teslim_Alma_Tarihi='" + txtteslimalmatarih.Text + "',Teslim_Birakma_Tarihi='" + txtteslimbırakmatarih.Text + "',Teslim_Neden='" + txtteslimneden.Text + "' where Konum='" + txtkonum.Text + "'", connection);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            connection.Close ();

            TabloyuDoldur();
            
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void arabutton_Click(object sender, EventArgs e)
        {connection.Open();
            MySqlCommand komut =new MySqlCommand("Select * from users where konum like '%" +txtara.Text+"%'",connection);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvKullanicilar.DataSource = ds.Tables[0];
            connection.Close();



        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dgvKullanicilar.SelectedCells[0].RowIndex;
            string Evrak_adi = dgvKullanicilar.Rows[seçilialan].Cells[1].Value.ToString();
            string Teslim_Alan = dgvKullanicilar.Rows[seçilialan].Cells[2].Value.ToString();
            string Unvan = dgvKullanicilar.Rows[seçilialan].Cells[3].Value.ToString();
            string Teslim_Alma_Tarihi = dgvKullanicilar.Rows[seçilialan].Cells[4].Value.ToString();
            string Teslim_Birakma_Tarihi = dgvKullanicilar.Rows[seçilialan].Cells[5].Value.ToString();
            string Teslim_Neden = dgvKullanicilar.Rows[seçilialan].Cells[6].Value.ToString();
            string Konum = dgvKullanicilar.Rows[seçilialan].Cells[7].Value.ToString();
            txtevrakadı.Text = Evrak_adi;
            txtteslimalan.Text = Teslim_Alan;
            ünvancombo.Text = Unvan;
            txtteslimalmatarih.Text = Teslim_Alma_Tarihi;
            txtteslimbırakmatarih.Text = Teslim_Birakma_Tarihi;
            txtteslimneden.Text = Teslim_Neden;
            txtkonum.Text = Konum;
        }

        private void txtevrakadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtteslimalan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtteslimbırakmatarih_TextChanged(object sender, EventArgs e)
        {

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
           /* ProfilSayfasi profilSayfasi = new ProfilSayfası();
            profilSayfasi.ShowDialog();
            this.Close();*/
        }

        private void profilTxt_Click(object sender, EventArgs e)
        {
            /* ProfilSayfasi profilSayfasi = new ProfilSayfası();
            profilSayfasi.ShowDialog();
            this.Close();*/
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.ShowDialog();
            this.Close();
        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtteslimalmatarih_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

