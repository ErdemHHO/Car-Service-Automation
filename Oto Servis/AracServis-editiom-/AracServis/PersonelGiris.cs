using System.Windows.Forms;
using System.Data.SqlClient;
namespace AracServis
{
    public partial class PersonelGiris : Form
    {
        // SQL Adresini Sinif.cs adındaki sınıf ile metod yardımıyla çağırarak komutlarda kullanıldı.
        Sinif bgl = new Sinif();
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            // Personel Şifresinin görünürlüğünü açık veya kapalı olmasını sağlamak için kullanıldı.
            if (TxtPar.PasswordChar.ToString()=="*")
            {
                TxtPar.PasswordChar = char.Parse("\0");
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TxtPar.PasswordChar = char.Parse("*");
            }
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {


        }

        private void Btnsus_Click(object sender, System.EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
        
        }
        Anasayfa Asf = new Anasayfa();
        private void BtnGiris_Click(object sender, System.EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Personel where PersonelKullaniciAdi = @p1 and Personel_Sifre = @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKul.Text);
            komut.Parameters.AddWithValue("@p2", TxtPar.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa ansf = new Anasayfa();
                ansf.ad = TxtKul.Text;
                ansf.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parolanız Hatalıdır.", "Giriş", MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            bgl.baglanti().Close();
        
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Anasayfa Asf = new Anasayfa();
            Asf.ad = "Misafir Girişi";
            Asf.Show();
            this.Hide();
        }
    }
}
