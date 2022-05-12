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
    public partial class ServisSil : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public ServisSil()
        {
            InitializeComponent();
        }

        private void ServisSil_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Servis", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void BtnKa_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , servis tablosunu yenilemek İçin kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Servis", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ADO.NET bağlantısı kullanılarak, servis tablosuna textbox'dan bilgi alınmasıyla kayıt silinmesi sağlandı.
            SqlCommand sil = new SqlCommand("Delete From Tbl_Servis Where Servis_Kodu=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1",servisno.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Servis Silinmiştir.", "Servis Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgilerin textbox'a yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            servisno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
