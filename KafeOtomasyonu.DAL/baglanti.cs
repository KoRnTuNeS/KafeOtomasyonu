using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.DAL
{
    class baglanti
    {
        public static SqlConnection conn = new SqlConnection("Server=ALPERPC\\SQLEXPRESS;DataBase=KafeOtomasyonDB;Integrated Security=true");
    }
}
