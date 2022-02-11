using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GitarProje
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=EBUBEKIRPC\SQLEXPRESS;Initial Catalog=GitarProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
