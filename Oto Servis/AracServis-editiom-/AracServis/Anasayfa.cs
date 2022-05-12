
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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public string ad;

        // Grafiği arttırmak amavıyla yapılan hareketli arabanın kullanılan kodları aşığadadır.
        // Arabanın hareketi için point ve timer komutları kullanılmıştır.
        Point konum = new Point();
        int ykonum1 ;


        Sinif bgl = new Sinif();
        private void Anasayfa_Load(object sender, EventArgs e)
        {
           

            ykonum1 = pictureBox1.Location.Y;
            LblAd.Text = ad;
            int a = 1;
            if (ad=="Misafir Girişi")
            {
                BtnP.Enabled = false;
                PctX.Visible = true; 
            }

            konum.X = 1777;

            // Tablo sutünlarının genişliklerini ayarlamak için kullanılmıştır.
            SqlCommand getir = new SqlCommand("Select Servis_Kodu,Musteri_Ad,Musteri_Soyad,Musteri_Tel,Musteri_Plaka,Marka_Adi,Model_Adi,Model_Yili,Model_Renk,Kategori_Adi,Parca_Adi,Parca_Marka,Yapılan_islem,Arac_Durumu,Giris_Tarihi,Cikis_Tarihi,Parca_Fiyat,Iscilik_Ucreti,Toplam_Tutar from  Tbl_Servis inner join Tbl_Musteriler on Tbl_Musteriler.MusteriID=Tbl_Servis.MusteriID inner join Tbl_Araclar on Tbl_Servis.Arac_Kodu=Tbl_Araclar.Arac_Kodu inner join Tbl_Modeller on Tbl_Modeller.Model_id=Tbl_Araclar.Model_id inner join Tbl_Yedek_Parca on Tbl_Yedek_Parca.Yedek_ParcaID=Tbl_Servis.Yedek_ParcaID inner join Tbl_Kategoriler on Tbl_Kategoriler.KategoriID=Tbl_Yedek_Parca.KategoriID inner join Tbl_Parcalar on Tbl_Yedek_Parca.ParcaID=Tbl_Parcalar.ParcaID", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int sayac = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sayac < 10)
            {
                sayac++;
                timer2.Stop();
            }
            if (timer2.Enabled == false)
            {
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (konum.X <= 0)
            {
                timer1.Stop();
            }
            else
            {
                konum.X = konum.X - 2;
                pictureBox1.Location = new Point(konum.X, ykonum1);
                pictureBox4.Location = new Point(konum.X, ykonum1);
            }

        }
        int sayac2 = 0;
        private void BtnSTOP_Click(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2==1)
            {
                timer1.Enabled = false;
                pictureBox1.SendToBack();
                pictureBox5.BringToFront();
            }
            if (sayac2 == 2)
            {
                timer1.Enabled = true;
                pictureBox4.SendToBack();
                sayac2 = 0;
                pictureBox3.BringToFront();
            }

        }

        // Butonların üzerinde bulunan resimlere tıklandığında butonları aktif etme özelliği tanımlanmıştır.
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BtnSTOP.PerformClick();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BtnSTOP.PerformClick();
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            // Butona tıklanıldığında butonların ve resimlerin arka plan renginin değişmesi sağlanmıştır.
            BtnM.BackColor = Color.AntiqueWhite;
            PctMu.BackColor = Color.AntiqueWhite;
            BtnA.BackColor = Color.Bisque;
            PctA.BackColor = Color.Bisque;
            BtnY.BackColor = Color.Bisque;
            PctY.BackColor = Color.Bisque;
            BtnS.BackColor = Color.Bisque;
            PctS.BackColor = Color.Bisque;
            BtnP.BackColor = Color.Bisque;
            PctP.BackColor = Color.Bisque;

            PctME.Visible = true;
            PctMG.Visible = true;
            PctMS.Visible = true;
            PctAE.Visible = false;
            PctAS.Visible = false;
            PctYK.Visible = false;
            PctYG.Visible = false;
            PctYS.Visible = false;
            PctSE.Visible = false;
            PctSG.Visible = false;
            PctSS.Visible = false;
            PctPEkle.Visible = false;
            PctPGun.Visible = false;
            PctPSil.Visible = false;
            BtnME.Visible = true;
            BtnMS.Visible = true;
            BtnMG.Visible = true;
            BtnAE.Visible = false;
            BtnAS.Visible = false;
            BtnYK.Visible = false;
            BtnYS.Visible = false;
            BtnYG.Visible = false;
            BtnSE.Visible = false;
            BtnSS.Visible = false;
            BtnSG.Visible = false;
            BtnPE.Visible = false;
            BtnPS.Visible = false;
            BtnPG.Visible = false;

            PctC1.Visible = true;
            PctC2.Visible = true;
            PctC3.Visible = true;

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnM.BackColor = Color.Bisque;
            PctP.BackColor = Color.Bisque;
            BtnA.BackColor = Color.AntiqueWhite;
            PctA.BackColor = Color.AntiqueWhite;
            BtnY.BackColor = Color.Bisque;
            PctY.BackColor = Color.Bisque;
            BtnS.BackColor = Color.Bisque;
            PctS.BackColor = Color.Bisque;
            BtnP.BackColor = Color.Bisque;
            PctMu.BackColor = Color.Bisque;


            PctME.Visible = false;
            PctMG.Visible = false;
            PctMS.Visible = false;
            PctAE.Visible = true;
            PctAS.Visible = true;
            PctYK.Visible = false;
            PctYG.Visible = false;
            PctYS.Visible = false;
            PctSE.Visible = false;
            PctSG.Visible = false;
            PctSS.Visible = false;
            PctPEkle.Visible = false;
            PctPGun.Visible = false;
            PctPSil.Visible = false;
            BtnME.Visible = false;
            BtnMS.Visible = false;
            BtnMG.Visible = false;
            BtnAE.Visible = true;
            BtnAS.Visible = true;
            BtnYK.Visible = false;
            BtnYS.Visible = false;
            BtnYG.Visible = false;
            BtnSE.Visible = false;
            BtnSS.Visible = false;
            BtnSG.Visible = false;
            BtnPE.Visible = false;
            BtnPS.Visible = false;
            BtnPG.Visible = false;

            PctC1.Visible = true;
            PctC2.Visible = false;
            PctC3.Visible = true;

        }


        private void BtnY_Click(object sender, EventArgs e)
        {
            BtnM.BackColor = Color.Bisque;
            PctP.BackColor = Color.Bisque;
            BtnA.BackColor = Color.Bisque;
            PctA.BackColor = Color.Bisque;
            BtnY.BackColor = Color.AntiqueWhite;
            PctY.BackColor = Color.AntiqueWhite;
            BtnS.BackColor = Color.Bisque;
            PctS.BackColor = Color.Bisque;
            BtnP.BackColor = Color.Bisque;
            PctMu.BackColor = Color.Bisque;

            PctME.Visible = false;
            PctMG.Visible = false;
            PctMS.Visible = false;
            PctAE.Visible = false;
            PctAS.Visible = false;
            PctYK.Visible = true;
            PctYG.Visible = true;
            PctYS.Visible = true;
            PctSE.Visible = false;
            PctSG.Visible = false;
            PctSS.Visible = false;
            PctPEkle.Visible = false;
            PctPGun.Visible = false;
            PctPSil.Visible = false;
            BtnME.Visible = false;
            BtnMS.Visible = false;
            BtnMG.Visible = false;
            BtnAE.Visible = false;
            BtnAS.Visible = false;
            BtnYK.Visible = true;
            BtnYS.Visible = true;
            BtnYG.Visible = true;
            BtnSE.Visible = false;
            BtnSS.Visible = false;
            BtnSG.Visible = false;
            BtnPE.Visible = false;
            BtnPS.Visible = false;
            BtnPG.Visible = false;

            PctC1.Visible = true;
            PctC2.Visible = true;
            PctC3.Visible = true;

        }


        private void BtnS_Click(object sender, EventArgs e)
        {
            BtnM.BackColor = Color.Bisque;
            PctP.BackColor = Color.Bisque;
            BtnA.BackColor = Color.Bisque;
            PctA.BackColor = Color.Bisque;
            BtnY.BackColor = Color.Bisque;
            PctY.BackColor = Color.Bisque;
            BtnS.BackColor = Color.AntiqueWhite;
            PctS.BackColor = Color.AntiqueWhite;
            BtnP.BackColor = Color.Bisque;
            PctMu.BackColor = Color.Bisque;

            PctME.Visible = false;
            PctMG.Visible = false;
            PctMS.Visible = false;
            PctAE.Visible = false;
            PctAS.Visible = false;
            PctYK.Visible = false;
            PctYG.Visible = false;
            PctYS.Visible = false;
            PctSE.Visible = true;
            PctSG.Visible = true;
            PctSS.Visible = true;
            PctPEkle.Visible = false;
            PctPGun.Visible = false;
            PctPSil.Visible = false;
            BtnME.Visible = false;
            BtnMS.Visible = false;
            BtnMG.Visible = false;
            BtnAE.Visible = false;
            BtnAS.Visible = false;
            BtnYK.Visible = false;
            BtnYS.Visible = false;
            BtnYG.Visible = false;
            BtnSE.Visible = true;
            BtnSS.Visible = true;
            BtnSG.Visible = true;
            BtnPE.Visible = false;
            BtnPS.Visible = false;
            BtnPG.Visible = false;

            PctC1.Visible = true;
            PctC2.Visible = true;
            PctC3.Visible = true;


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            BtnM.BackColor = Color.Bisque;
            PctMu.BackColor = Color.Bisque;
            BtnA.BackColor = Color.Bisque;
            PctA.BackColor = Color.Bisque;
            BtnY.BackColor = Color.Bisque;
            PctY.BackColor = Color.Bisque;
            BtnS.BackColor = Color.Bisque;
            PctS.BackColor = Color.Bisque;
            BtnP.BackColor = Color.AntiqueWhite;
            PctP.BackColor = Color.AntiqueWhite;

            PctME.Visible = false;
            PctMG.Visible = false;
            PctMS.Visible = false;
            PctAE.Visible = false;
            PctAS.Visible = false;
            PctYK.Visible = false;
            PctYG.Visible = false;
            PctYS.Visible = false;
            PctSE.Visible = false;
            PctSG.Visible = false;
            PctSS.Visible = false;
            PctPEkle.Visible = true;
            PctPGun.Visible = true;
            PctPSil.Visible = true;
            BtnME.Visible = false;
            BtnMS.Visible = false;
            BtnMG.Visible = false;
            BtnAE.Visible = false;
            BtnAS.Visible = false;
            BtnYK.Visible = false;
            BtnYS.Visible = false;
            BtnYG.Visible = false;
            BtnSE.Visible = false;
            BtnSS.Visible = false;
            BtnSG.Visible = false;
            BtnPE.Visible = true;
            BtnPS.Visible = true;
            BtnPG.Visible = true;

            PctC1.Visible = true;
            PctC2.Visible = true;
            PctC3.Visible = true;
        }


        private void PicY_Click(object sender, EventArgs e)
        {
            BtnY.PerformClick();
        }

        private void PctA_Click(object sender, EventArgs e)
        {
            BtnA.PerformClick();
        }

        private void PctS_Click(object sender, EventArgs e)
        {
            BtnS.PerformClick();
        }

        private void PctMu_Click(object sender, EventArgs e)
        {
            BtnP.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        // Formlar arası geçiş sağlanmıştır.
        private void BtnME_Click(object sender, EventArgs e)
        {
            MusteriEkle ME = new MusteriEkle();
            ME.Show();
        }

        private void BtnMG_Click(object sender, EventArgs e)
        {
            MusteriGuncelle MG = new MusteriGuncelle();
            MG.Show();
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            MusteriSil MS = new MusteriSil();
            MS.Show();
        }

        private void BtnMS_Click_1(object sender, EventArgs e)
        {
            MusteriSil MS = new MusteriSil();
            MS.Show();
        }

        private void PctME_Click(object sender, EventArgs e)
        {
            BtnME.PerformClick();
        }

        private void PctMG_Click(object sender, EventArgs e)
        {
            BtnMG.PerformClick();
        }

        private void PctMS_Click(object sender, EventArgs e)
        {
            BtnMS.PerformClick();
        }

        private void BtnAE_Click(object sender, EventArgs e)
        {
            AracEkle AE = new AracEkle();
            AE.Show();
        }

        private void BtnAG_Click(object sender, EventArgs e)
        {
        }

        private void BtnAS_Click(object sender, EventArgs e)
        {
            AracSil AS = new AracSil();
            AS.Show();
        }

        private void PctAE_Click(object sender, EventArgs e)
        {
            BtnAE.PerformClick();
        }

        private void PctAG_Click(object sender, EventArgs e)
        {
        }

        private void PctAS_Click(object sender, EventArgs e)
        {
            BtnAS.PerformClick();
        }
        private void BtnYE_Click(object sender, EventArgs e)
        {
            YedekParcaEkle YE = new YedekParcaEkle();
            YE.Show();
        }

        private void BtnYG_Click(object sender, EventArgs e)
        {
            YedekParcaGuncelle YG = new YedekParcaGuncelle();
            YG.Show();
        }

        private void BtnYS_Click(object sender, EventArgs e)
        {
            YedekParcaSil YS = new YedekParcaSil();
            YS.Show();
        }

        private void PctYK_Click(object sender, EventArgs e)
        {
            BtnYK.PerformClick();
        }

        private void PctYG_Click(object sender, EventArgs e)
        {
            BtnYG.PerformClick();
        }

        private void PctYS_Click(object sender, EventArgs e)
        {
            BtnYS.PerformClick();
        }



        private void BtnSE_Click(object sender, EventArgs e)
        {
            ServisEkle SE = new ServisEkle();
            SE.Show();
        }

        private void BtnSG_Click(object sender, EventArgs e)
        {
            ServisGuncelle SG = new ServisGuncelle();
            SG.Show();
        }

        private void BtnSS_Click(object sender, EventArgs e)
        {
            ServisSil SS = new ServisSil();
            SS.Show();
        }

        private void PctSE_Click(object sender, EventArgs e)
        {
            BtnSE.PerformClick();
        }

        private void PctSG_Click(object sender, EventArgs e)
        {
            BtnSG.PerformClick();
        }

        private void PctSS_Click(object sender, EventArgs e)
        {
            BtnSS.PerformClick();
        }


        private void BtnPE_Click(object sender, EventArgs e)
        {
            PersonelEkle PE = new PersonelEkle();
            PE.Show();
        }

        private void BtnPG_Click(object sender, EventArgs e)
        {
            PersonelGuncelle PG = new PersonelGuncelle();
            PG.Show();
        }

        private void BtnPS_Click(object sender, EventArgs e)
        {
            PersonelSil PS = new PersonelSil();
            PS.Show();
        }

        private void PctPEkle_Click(object sender, EventArgs e)
        {
            BtnPE.PerformClick();
        }

        private void PctPGun_Click(object sender, EventArgs e)
        {
            BtnPG.PerformClick();
        }

        private void PctPSil_Click(object sender, EventArgs e)
        {
            BtnPS.PerformClick();
        }

        private void PctPE_Click(object sender, EventArgs e)
        {
            //BtnPE.PerformClick();
        }

        private void PctPG_Click(object sender, EventArgs e)
        {
            // BtnPG.PerformClick();
        }

        private void PctPS_Click(object sender, EventArgs e)
        {
            //BtnPS.PerformClick();
        }


        private void LblAd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PctMu_Click_1(object sender, EventArgs e)
        {
            BtnM.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dataset bağlantısı kullanılarak , servis tablosunu yenilemek için kullanıldı.
            SqlCommand getir = new SqlCommand("Select Servis_Kodu,Musteri_Ad,Musteri_Soyad,Musteri_Tel,Musteri_Plaka,Marka_Adi,Model_Adi,Model_Yili,Model_Renk,Kategori_Adi,Parca_Adi,Parca_Marka,Yapılan_islem,Arac_Durumu,Giris_Tarihi,Cikis_Tarihi,Parca_Fiyat,Iscilik_Ucreti,Toplam_Tutar from  Tbl_Servis inner join Tbl_Musteriler on Tbl_Musteriler.MusteriID=Tbl_Servis.MusteriID inner join Tbl_Araclar on Tbl_Servis.Arac_Kodu=Tbl_Araclar.Arac_Kodu inner join Tbl_Modeller on Tbl_Modeller.Model_id=Tbl_Araclar.Model_id inner join Tbl_Yedek_Parca on Tbl_Yedek_Parca.Yedek_ParcaID=Tbl_Servis.Yedek_ParcaID inner join Tbl_Kategoriler on Tbl_Kategoriler.KategoriID=Tbl_Yedek_Parca.KategoriID inner join Tbl_Parcalar on Tbl_Yedek_Parca.ParcaID=Tbl_Parcalar.ParcaID", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
