using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kargomanagement
{
    class sqlbaglanti
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KCV5GRGM\\SQLEXPRESS;Initial Catalog=kargomanagement;Integrated Security=True");
            baglan.Open();
            return baglan;

        }

    }
}
