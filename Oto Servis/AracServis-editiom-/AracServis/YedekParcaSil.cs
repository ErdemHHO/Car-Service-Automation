using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AracServis
{
    public partial class YedekParcaSil : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public YedekParcaSil()
        {
            InitializeComponent();
        }

        private void YedekParcaSil_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select Yedek_ParcaID,Tbl_Yedek_Parca.KategoriID,Tbl_Kategoriler.Kategori_Adi,Tbl_Yedek_Parca.ParcaID,Parca_Adi,Parca_Marka,Parca_Fiyat from Tbl_Yedek_Parca inner join Tbl_Parcalar on Tbl_Parcalar.ParcaID=Tbl_Yedek_Parca.ParcaID inner join Tbl_Kategoriler on Tbl_Kategoriler.KategoriID=Tbl_Yedek_Parca.KategoriID", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void BtnKa_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , yedek parça tablosunu yenilemek İçin kullanıldı.
            SqlCommand getir = new SqlCommand("Select Yedek_ParcaID,Tbl_Yedek_Parca.KategoriID,Tbl_Kategoriler.Kategori_Adi,Tbl_Yedek_Parca.ParcaID,Parca_Adi,Parca_Marka,Parca_Fiyat from Tbl_Yedek_Parca inner join Tbl_Parcalar on Tbl_Parcalar.ParcaID=Tbl_Yedek_Parca.ParcaID inner join Tbl_Kategoriler on Tbl_Kategoriler.KategoriID=Tbl_Yedek_Parca.KategoriIDa", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ADO.NET bağlantısı kullanılarak , yedek parça tablosuna textbox'dan bilgi alınmasıyla kayıt silinmesi sağlandı.
            SqlCommand sil = new SqlCommand("Delete From Tbl_Yedek_Parca where Yedek_ParcaID =@p1",bgl.baglanti());
            sil.Parameters.AddWithValue("@p1",parcakodu.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Yedek Parça Silindi.", "Yedek Parça Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            parcakodu.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
