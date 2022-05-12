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
    public partial class AracEkle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public AracEkle()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select Tbl_Araclar.Arac_Kodu,Tbl_Araclar.Marka_Adi,Tbl_Modeller.Model_Adi,Tbl_Modeller.Model_id,Tbl_Modeller.Model_Yili,Tbl_Modeller.Model_Renk from Tbl_Araclar inner join Tbl_Modeller on Tbl_Modeller.Model_id=Tbl_Araclar.Model_id", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void BtnKa_Click(object sender, EventArgs e)
        {
            try
            {
                // ADO.NET bağlantısı kullanılarak, araç tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Araç kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand arac = new SqlCommand("insert into Tbl_Araclar (Arac_Kodu,Marka_Adi,Model_id) values (@p3,@p4,@p5)", bgl.baglanti());
                arac.Parameters.AddWithValue("@p3", TxtAracKodu.Text);
                arac.Parameters.AddWithValue("@p4", Txtmarka.Text);
                arac.Parameters.AddWithValue("@p5", txtmodelid.Text);
                arac.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Araç Eklendi.","Araç Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information );

            }
            catch (Exception)
            {

                MessageBox.Show("Araç Kodu Zaten Var.", "Araç Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLi_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , araç tablosunu yenilemek İçin kullanıldı.
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Markalar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // ADO.NET bağlantısı kullanılarak, marka tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Marka kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand marka = new SqlCommand("insert into Tbl_Markalar (Marka_Adi) values (@p4)", bgl.baglanti());
                marka.Parameters.AddWithValue("@p4", Txtmarka.Text);
                marka.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Marka Eklendi.", "Marka Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Araç Markası Zaten Var.", "Marka Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // ADO.NET bağlantısı kullanılarak, model tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Model kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand model = new SqlCommand("insert into Tbl_Modeller (Model_id, Model_Adi,Model_Yili,Model_Renk) values (@p10,@p2,@p11,@p12)", bgl.baglanti());
                model.Parameters.AddWithValue("@p10", txtmodelid.Text);

                model.Parameters.AddWithValue("@p2", Txtmodel.Text);
                model.Parameters.AddWithValue("@p11", txtModelYil.Text);
                model.Parameters.AddWithValue("@p12", TxtModelRenk.Text);


                model.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Model Eklendi.", "Model Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Araç Modeli Zaten Var.", "Model Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
     


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtmarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmodelid.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Txtmodel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtModelYil.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtModelRenk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtAracKodu.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("Select Tbl_Araclar.Arac_Kodu,Tbl_Araclar.Marka_Adi,Tbl_Modeller.Model_Adi,Tbl_Modeller.Model_id,Tbl_Modeller.Model_Yili,Tbl_Modeller.Model_Renk from Tbl_Araclar inner join Tbl_Modeller on Tbl_Modeller.Model_id=Tbl_Araclar.Model_id", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
