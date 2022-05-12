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
    public partial class MusteriGuncelle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Musteriler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void BtnLi_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , müşteri tablosunu yenilemek İçin kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Musteriler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            musteriad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            musterisoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            musteritel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            aracplaka.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            musteriid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }


        private void BtnKa_Click(object sender, EventArgs e)
        {
            // ADO.NET bağlantısı kullanılarak , müşteri tablosuna textbox'dan bilgi alınmasıyla kayıt güncellenmesi sağlandı.
            SqlCommand guncelle = new SqlCommand("Update Tbl_Musteriler Set Musteri_Ad=@p1,Musteri_Soyad=@p2,Musteri_Tel=@p3,Musteri_Plaka=@p4 Where MusteriID=@p5 ",bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",musteriad.Text);
            guncelle.Parameters.AddWithValue("@p2", musterisoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", musteritel.Text);
            guncelle.Parameters.AddWithValue("@p4", aracplaka.Text);
            guncelle.Parameters.AddWithValue("@p5", musteriid.Text);

            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Güncellendi.", "Müşteri Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

