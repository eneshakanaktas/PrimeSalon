using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmPersonelPozisyonTanimlama : Form
    {
        int seciliID = 0;

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=(LocalDB)\PrimeSalonDB;Initial Catalog=PrimeSalonDB;Integrated Security=True");

        // FrmPersonelPozisyonTanimlama formunu başlatır; Windows Form kontrollerini oluşturarak personel pozisyon tanımı ekranını kullanıma hazırlar.
        public FrmPersonelPozisyonTanimlama()
        {
            InitializeComponent();
        }

        // Personel pozisyon tanımı tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dataGridView1 üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                string sorgu = "SELECT ID, Pozisyon FROM PersonelTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                da.Fill(ds, "PersonelTanimlama");
                dataGridView1.DataSource = ds.Tables["PersonelTanimlama"];

                if (dataGridView1.Columns["ID"] != null)
                    dataGridView1.Columns["ID"].Visible = false;

                if (dataGridView1.Columns["Pozisyon"] != null)
                    dataGridView1.Columns["Pozisyon"].HeaderText = "Pozisyon";
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // Formdaki personel pozisyon tanımı bilgilerini parametreli SQL komutuyla personel pozisyon tanımı tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "INSERT INTO PersonelTanimlama(Pozisyon) VALUES(@Pozisyon)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Pozisyon", txtPozisyon.Text.Trim());

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Veri Girişi");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // Seçili personel pozisyon tanımı kaydını ID değerine göre personel pozisyon tanımı tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "DELETE FROM PersonelTanimlama WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@ID", seciliID);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Silindi", "Veri Silme");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // Formdaki düzenlenmiş personel pozisyon tanımı bilgilerini seçili ID üzerinden personel pozisyon tanımı tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "UPDATE PersonelTanimlama SET Pozisyon=@Pozisyon WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Pozisyon", txtPozisyon.Text.Trim());
                komut.Parameters.AddWithValue("@ID", seciliID);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi", "Veri Güncelleme");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // Personel pozisyon tanımı formundaki ID ve giriş alanlarını sıfırlar; yeni kayıt girişi için ekranı başlangıç durumuna getirir.
        public void Temizle()
        {
            txtPozisyon.Clear();
            seciliID = 0;
            txtPozisyon.Focus();
        }

        // Personel pozisyon tanımı formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmPersonelPozisyonTanimlama_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Personel pozisyon tanımı formu tekrar etkinleştiğinde tanım/kayıt listesini yeniden okuyarak ekrandaki veriyi güncel tutar.
        private void FrmPersonelPozisyonTanimlama_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Gridde seçilen personel pozisyon tanımı satırının ID ve ad/değer bilgisini form alanlarına aktararak silme veya güncelleme işlemine hazırlar.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                txtPozisyon.Text = dataGridView1.CurrentRow.Cells["Pozisyon"].Value.ToString();
            }
        }

        // Personel pozisyon tanımı listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPozisyon.Text.Trim() == "")
                MessageBox.Show("Pozisyon boş geçilemez");
            else
            {
                KayitEkle();
                KayitListele();
                Temizle();
            }
        }

        // Personel pozisyon tanımı silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Silinecek kaydı seçiniz");
            else
            {
                KayitSil();
                KayitListele();
                Temizle();
            }
        }

        // Personel pozisyon tanımı güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Güncellenecek kaydı seçiniz");
            else if (txtPozisyon.Text.Trim() == "")
                MessageBox.Show("Pozisyon boş geçilemez");
            else
            {
                KayitGuncelle();
                KayitListele();
                Temizle();
            }
        }

        // Personel pozisyon tanımı temizleme düğmesinde form alanlarını sıfırlar ve ekranı yeni işlem için hazırlar.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
