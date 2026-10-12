using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmHizmetKategoriTanimlama : Form
    {
        int seciliID = 0;

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=(LocalDB)\PrimeSalonDB;Initial Catalog=PrimeSalonDB;Integrated Security=True");

        // FrmHizmetKategoriTanimlama formunu başlatır; Windows Form kontrollerini oluşturarak hizmet kategori tanımı ekranını kullanıma hazırlar.
        public FrmHizmetKategoriTanimlama()
        {
            InitializeComponent();
        }

        // Hizmet kategori tanımı tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dataGridView1 üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                string sorgu = "SELECT ID, Kategori FROM HizmetKategoriTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                da.Fill(ds, "HizmetKategoriTanimlama");
                dataGridView1.DataSource = ds.Tables["HizmetKategoriTanimlama"];

                if (dataGridView1.Columns["ID"] != null)
                    dataGridView1.Columns["ID"].Visible = false;

                if (dataGridView1.Columns["Kategori"] != null)
                    dataGridView1.Columns["Kategori"].HeaderText = "Kategori";
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

        // Formdaki hizmet kategori tanımı bilgilerini parametreli SQL komutuyla hizmet kategori tanımı tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "INSERT INTO HizmetKategoriTanimlama(Kategori) VALUES(@Kategori)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Kategori", txtKategori.Text.Trim());

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

        // Seçili hizmet kategori tanımı kaydını ID değerine göre hizmet kategori tanımı tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "DELETE FROM HizmetKategoriTanimlama WHERE ID=@ID";
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

        // Formdaki düzenlenmiş hizmet kategori tanımı bilgilerini seçili ID üzerinden hizmet kategori tanımı tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "UPDATE HizmetKategoriTanimlama SET Kategori=@Kategori WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Kategori", txtKategori.Text.Trim());
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

        // Hizmet kategori tanımı formundaki ID ve giriş alanlarını sıfırlar; yeni kayıt girişi için ekranı başlangıç durumuna getirir.
        public void Temizle()
        {
            txtKategori.Clear();
            seciliID = 0;
            txtKategori.Focus();
        }

        // Hizmet kategori tanımı formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmHizmetKategoriTanimlama_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Hizmet kategori tanımı formu tekrar etkinleştiğinde tanım/kayıt listesini yeniden okuyarak ekrandaki veriyi güncel tutar.
        private void FrmHizmetKategoriTanimlama_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Gridde seçilen hizmet kategori tanımı satırının ID ve ad/değer bilgisini form alanlarına aktararak silme veya güncelleme işlemine hazırlar.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                txtKategori.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            }
        }

        // Hizmet kategori tanımı listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text.Trim() == "")
                MessageBox.Show("Kategori boş geçilemez");
            else
            {
                KayitEkle();
                KayitListele();
                Temizle();
            }
        }

        // Hizmet kategori tanımı silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
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

        // Hizmet kategori tanımı güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Güncellenecek kaydı seçiniz");
            else if (txtKategori.Text.Trim() == "")
                MessageBox.Show("Kategori boş geçilemez");
            else
            {
                KayitGuncelle();
                KayitListele();
                Temizle();
            }
        }

        // Hizmet kategori tanımı temizleme düğmesinde form alanlarını sıfırlar ve ekranı yeni işlem için hazırlar.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
