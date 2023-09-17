using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj_Takip_Sistemi
{
    public class sqlbaglanti    
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OSNDT9I\SQLEXPRESS;Initial Catalog=stajtakip;Integrated Security=True");
    }
}
