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
            

            this.Controls.Add(dgvKullanicilar);
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
            this.BackColor = Color.FromArgb(58, 86, 131);
            buttonekle.BackColor = Color.FromArgb(58, 86, 131);
            güncellebutton.BackColor = Color.FromArgb(58, 86, 131);
            silbutton.BackColor = Color.FromArgb(58, 86, 131);
            arabutton.BackColor = Color.FromArgb(58, 86, 131);
            evrakAdiTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimAlanTxt.BackColor = Color.FromArgb(58, 86, 131);
            unvanTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimAlmaTarihiTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimBırakmaTarihiTxt.BackColor = Color.FromArgb(58, 86, 131);
            teslimAlmaNedeniTxt.BackColor = Color.FromArgb(58, 86, 131);
            arabutton.BackColor = Color.FromArgb(58, 86, 131);
           kodTxt.BackColor = Color.FromArgb(58, 86, 131);
           aranacakKodTxt.BackColor = Color.FromArgb(58, 86, 131);
            TabloyuDoldur();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO users (evrakadi,teslimalan,unvan,teslimalmatarihi,teslimbirakmatarihi,teslimneden,konum) VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6)", connection);
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
            }
        }

        private void güncelbutton_Click(object sender, EventArgs e)
        {
            connection.Open ();
            MySqlCommand komut = new MySqlCommand("update users set evrakadi='" + txtevrakadı.Text + "',teslimalan='" + txtteslimalan.Text + "',unvan='" + ünvancombo.Text +  "',teslimalmatarihi='" + txtteslimalmatarih.Text + "',teslimbirakmatarihi='" + txtteslimbırakmatarih.Text + "',teslimneden='" + txtteslimneden.Text + "'where konum='" + txtkonum.Text + "'", connection);
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
            MySqlCommand komut =new MySqlCommand("Select * from users where konum like%" +txtara.Text+"'%",connection);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvKullanicilar.DataSource = ds.Tables[0];
            connection.Close();



        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dgvKullanicilar.SelectedCells[0].RowIndex;
            string evrakadi = dgvKullanicilar.Rows[seçilialan].Cells[1].Value.ToString();
            string teslimalan = dgvKullanicilar.Rows[seçilialan].Cells[2].Value.ToString();
            string unvan = dgvKullanicilar.Rows[seçilialan].Cells[3].Value.ToString();
            string teslimalmatarihi = dgvKullanicilar.Rows[seçilialan].Cells[4].Value.ToString();
            string teslimbirakmatarihi = dgvKullanicilar.Rows[seçilialan].Cells[5].Value.ToString();
            string teslimneden = dgvKullanicilar.Rows[seçilialan].Cells[6].Value.ToString();
            string konum = dgvKullanicilar.Rows[seçilialan].Cells[7].Value.ToString();
            txtevrakadı.Text = evrakadi;
            txtteslimalan.Text = teslimalan;
            ünvancombo.Text = unvan;
            txtteslimalmatarih.Text = teslimalmatarihi;
            txtteslimbırakmatarih.Text = teslimbirakmatarihi;
            txtteslimneden.Text = teslimneden;
            txtkonum.Text = konum;
        }

        private void txtevrakadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtteslimalan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

