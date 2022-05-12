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
    public partial class YedekParcaEkle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public YedekParcaEkle()
        {
            InitializeComponent();
        }

        private void ServisEkle_Load(object sender, EventArgs e)
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
            try
            {
                // ADO.NET bağlantısı kullanılarak, yedek parça tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Yedek Parça kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand yedekparca = new SqlCommand("insert into Tbl_Yedek_Parca (Yedek_ParcaID,KategoriID,ParcaID) values (@p1,@p2,@p3) ", bgl.baglanti());
                yedekparca.Parameters.AddWithValue("p1", yedekparcakod.Text);
                yedekparca.Parameters.AddWithValue("p2", kategorikodu.Text);
                yedekparca.Parameters.AddWithValue("p3", parcakodu.Text);
                yedekparca.ExecuteNonQuery();
                MessageBox.Show("Yedek Parça Eklendi", "Yedek Parça Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {

                MessageBox.Show("Yedek Parça Kodu Zaten Var", "Yedek Parça Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ADO.NET bağlantısı kullanılarak, kategori tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Kategori kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand kategoriekle = new SqlCommand("insert into Tbl_Kategoriler (KategoriID,Kategori_Adi) values (@p1,@p2)", bgl.baglanti());
                kategoriekle.Parameters.AddWithValue("@p1", kategorikodu.Text);
                kategoriekle.Parameters.AddWithValue("@p2", kategoriad.Text);
                kategoriekle.ExecuteNonQuery();
                MessageBox.Show("Kategori Eklendi", "Kategori Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {

                MessageBox.Show("Kategori Kodu Zaten Var.", "Kategori Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // ADO.NET bağlantısı kullanılarak, parçalar tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Parça kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand parcaekle = new SqlCommand("insert into Tbl_Parcalar (ParcaID,Parca_Adi,Parca_Marka,Parca_Fiyat) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                parcaekle.Parameters.AddWithValue("@p1", parcakodu.Text);
                parcaekle.Parameters.AddWithValue("@p2", parcad.Text);
                parcaekle.Parameters.AddWithValue("@p3", parcamarka.Text);
                parcaekle.Parameters.AddWithValue("@p4", parcafiyat.Text);
                parcaekle.ExecuteNonQuery();
                MessageBox.Show("Parça Eklendi.", "Parça Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Parça Kodu Zaten Var.", "Parça Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            yedekparcakod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            kategorikodu.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kategoriad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            parcakodu.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            parcad.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            parcamarka.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            parcafiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void BtnLi_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , yedek parça tablosunu yenilemek İçin kullanıldı.
            SqlCommand getir = new SqlCommand("Select Yedek_ParcaID,Tbl_Yedek_Parca.KategoriID,Tbl_Kategoriler.Kategori_Adi,Tbl_Yedek_Parca.ParcaID,Parca_Adi,Parca_Marka,Parca_Fiyat from Tbl_Yedek_Parca inner join Tbl_Parcalar on Tbl_Parcalar.ParcaID=Tbl_Yedek_Parca.ParcaID inner join Tbl_Kategoriler on Tbl_Kategoriler.KategoriID=Tbl_Yedek_Parca.KategoriID", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
