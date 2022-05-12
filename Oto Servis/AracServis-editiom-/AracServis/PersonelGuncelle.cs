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
using System.Data.Common;

namespace AracServis
{
    public partial class PersonelGuncelle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public PersonelGuncelle()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Personel Şifresinin görünürlüğünü açık veya kapalı olmasını sağlamak için kullanıldı.
            if (TxtPar.PasswordChar.ToString() == "*")
            {
                TxtPar.PasswordChar = char.Parse("\0");
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TxtPar.PasswordChar = char.Parse("*");
            }
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("Select * from Tbl_Personel", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void BtnLi_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , personel tablosunu yenilemek İçin kullanıldı.
            //DataSet2TableAdapters.Tbl_PersonelTableAdapter ds = new DataSet2TableAdapters.Tbl_PersonelTableAdapter();

            SqlCommand getir = new SqlCommand("Select * from Tbl_Personel", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tabloya çift tıklandığında bilgileri textbox'lara yazılması için kullanıldı.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void BtnKa_Click(object sender, EventArgs e)
        {
            // ADO.NET bağlantısı kullanılarak , personel tablosuna textbox'dan bilgi alınmasıyla kayıt güncellenmesi sağlandı.
            SqlCommand guncelle = new SqlCommand("Update Tbl_Personel Set Personel_Ad =@p2,Personel_Soyad =@p3,Personel_Sifre =@p4 where PersonelKullaniciAdi = @p1", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            guncelle.Parameters.AddWithValue("@p2", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p4", TxtPar.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi.", "Personel Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
