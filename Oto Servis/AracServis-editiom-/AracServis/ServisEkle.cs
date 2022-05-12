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
    public partial class ServisEkle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public ServisEkle()
        {
            InitializeComponent();
        }

        private void ServisEkle_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Servis", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnKa_Click(object sender, EventArgs e)
        {
            try
            {
                // ADO.NET bağlantısı kullanılarak, servis tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Servis kodu aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand servisekle = new SqlCommand("insert into Tbl_Servis (Servis_Kodu,MusteriID,Arac_Kodu,Yedek_ParcaID,Yapılan_islem,Arac_Durumu,Giris_Tarihi,Cikis_Tarihi,Iscilik_Ucreti,Toplam_Tutar) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)     ", bgl.baglanti());
                servisekle.Parameters.AddWithValue("@p1", TxtServisN.Text);
                servisekle.Parameters.AddWithValue("@p2", TxtMusteriK.Text);
                servisekle.Parameters.AddWithValue("@p3", txtarackodu.Text);
                servisekle.Parameters.AddWithValue("@p4", TxtYedekPK.Text);
                servisekle.Parameters.AddWithValue("@p5", TxtYapilan.Text);
                servisekle.Parameters.AddWithValue("@p6", TxtAracK.Text);
                servisekle.Parameters.AddWithValue("@p7", TxtGirisT.Text);
                servisekle.Parameters.AddWithValue("@p8", TxtCikisT.Text);
                servisekle.Parameters.AddWithValue("@p9", TxtİscilikU.Text);
                servisekle.Parameters.AddWithValue("@p10", TxtToplamT.Text);
                servisekle.ExecuteNonQuery();
                MessageBox.Show("Servis Eklendi.", "Servis Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Servis Kodu Zaten Var", "Araç Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtServisN.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMusteriK.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtarackodu.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtYedekPK.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYapilan.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtAracK.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtGirisT.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtCikisT.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtİscilikU.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtToplamT.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

        }

        private void BtnLi_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , servis tablosunu yenilemek İçin kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Servis", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
