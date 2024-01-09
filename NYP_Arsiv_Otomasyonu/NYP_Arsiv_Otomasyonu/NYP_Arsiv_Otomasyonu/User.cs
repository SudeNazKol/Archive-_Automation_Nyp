using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_Arsiv_Otomasyonu
{
    internal class User
    {
        public string isim_soyisim;
        public String user_name;
       // public String user_type;

        public User()
        {
        }

        public User(String user_name )
        { 
           // string connectionString = "Server=172.21.54.148;Port=3306;Database=NYP23-15;User=NYP23-15;Password=Uludag9512357.;";
            this.user_name = user_name;
            //this.user_type = user_type;
           



        }
    }



}
