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
    public partial class ServisGuncelle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public ServisGuncelle()
        {
            InitializeComponent();
        }

        private void ServisGuncelle_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Servis", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

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

        private void BtnKa_Click(object sender, EventArgs e)
        {
            // ADO.NET bağlantısı kullanılarak, servis tablosuna textbox'dan bilgi alınmasıyla kayıt güncellenmesi sağlandı.
            SqlCommand servisg = new SqlCommand("Update Tbl_Servis Set Yapılan_islem=@p1,Arac_Durumu=@p2,Giris_Tarihi=@p3,Cikis_Tarihi=@p4,Iscilik_Ucreti=@p5,Toplam_Tutar=@p6 where Servis_Kodu=@p7", bgl.baglanti());
            servisg.Parameters.AddWithValue("@p1",TxtYapilan.Text);
            servisg.Parameters.AddWithValue("@p2", TxtAracK.Text);
            servisg.Parameters.AddWithValue("@p3", TxtGirisT.Text);
            servisg.Parameters.AddWithValue("@p4", TxtCikisT.Text);
            servisg.Parameters.AddWithValue("@p5", TxtİscilikU.Text);
            servisg.Parameters.AddWithValue("@p6", TxtToplamT.Text);
            servisg.Parameters.AddWithValue("@p7", TxtServisN.Text);
            servisg.ExecuteNonQuery();
            MessageBox.Show("Servis Güncellendi.", "Servis Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
