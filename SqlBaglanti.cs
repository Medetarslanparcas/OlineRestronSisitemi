using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineRestoranSiparisTakipSistemi
{
    internal class SqlBaglanti
    {
   
        public SqlConnection baglanti()
        {
            return new SqlConnection("Data Source=DESKTOP-98AUGDI\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }

    }
}
