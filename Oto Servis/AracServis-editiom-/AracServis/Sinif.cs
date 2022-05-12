using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AracServis
{
    internal class Sinif
    {
        public SqlConnection baglanti()
        {
            // Metodumuza bağlantıyı yazarak form dosyalarımızda bağlantı kodunu tekrardan yazmayı engellemiş oluyoruz.
            SqlConnection baglan = new SqlConnection(@"Data Source=192.168.148.123;Initial Catalog=AracServisOtomasyon;User ID=alpay;Password=12345");
            baglan.Open();
            return baglan;
        }
    }
}
