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
    public partial class AracSil : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public AracSil()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AracSil_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Araclar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtkod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ADO.NET bağlantısı kullanılarak , araç tablosuna textbox'dan bilgi alınmasıyla kayıt silinmesi sağlandı.
            SqlCommand sil = new SqlCommand("Delete from Tbl_Araclar Where Arac_Kodu = @p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1",txtkod.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç Silindi.", "Araç Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnKa_Click(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("Select * from Tbl_Araclar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
