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
    public partial class PersonelEkle : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public PersonelEkle()
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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            // Sutünların genişliklerini ayarlamak için kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Personel", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, MouseEventArgs e)
        {
           
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
            // ADO.NET bağlantısı kullanılarak , personel tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
            try
            {
                // ADO.NET bağlantısı kullanılarak, personel tablosuna textbox'dan bilgi alınmasıyla kayıt eklenmesi sağlandı.
                // Kullanıcı adı aynı girilirse , hata mesajı verilsin diye try catch komutu kullınıldı.
                SqlCommand ekleme = new SqlCommand("insert into Tbl_Personel (PersonelKullaniciAdi,Personel_Ad,Personel_Soyad,Personel_Sifre) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                ekleme.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                ekleme.Parameters.AddWithValue("@p2", txtAd.Text);
                ekleme.Parameters.AddWithValue("@p3", TxtSoyad.Text);
                ekleme.Parameters.AddWithValue("@p4", TxtPar.Text);

                ekleme.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Eklendi.", "Personel Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Kodu Zaten Var.", "Personel Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void BtnLi_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , personel tablosunu yenilemek İçin kullanıldı.
            SqlCommand getir = new SqlCommand("Select * from Tbl_Personel", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
