using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmDemirbaslarKategoriTanimlama : Form
    {
        int seciliID = 0;

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=(LocalDB)\PrimeSalonDB;Initial Catalog=PrimeSalonDB;Integrated Security=True");

        // FrmDemirbaslarKategoriTanimlama formunu başlatır; Windows Form kontrollerini oluşturarak demirbaş kategori tanımı ekranını kullanıma hazırlar.
        public FrmDemirbaslarKategoriTanimlama()
        {
            InitializeComponent();
        }

        // Demirbaş kategori tanımı tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dataGridView1 üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                string sorgu = "SELECT ID, Kategori FROM DemirbaslarKategoriTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                da.Fill(ds, "DemirbaslarKategoriTanimlama");
                dataGridView1.DataSource = ds.Tables["DemirbaslarKategoriTanimlama"];

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

        // Formdaki demirbaş kategori tanımı bilgilerini parametreli SQL komutuyla demirbaş kategori tanımı tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "INSERT INTO DemirbaslarKategoriTanimlama(Kategori) VALUES(@Kategori)";
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

        // Seçili demirbaş kategori tanımı kaydını ID değerine göre demirbaş kategori tanımı tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "DELETE FROM DemirbaslarKategoriTanimlama WHERE ID=@ID";
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

        // Formdaki düzenlenmiş demirbaş kategori tanımı bilgilerini seçili ID üzerinden demirbaş kategori tanımı tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "UPDATE DemirbaslarKategoriTanimlama SET Kategori=@Kategori WHERE ID=@ID";
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

        // Demirbaş kategori tanımı formundaki ID ve giriş alanlarını sıfırlar; yeni kayıt girişi için ekranı başlangıç durumuna getirir.
        public void Temizle()
        {
            txtKategori.Clear();
            seciliID = 0;
            txtKategori.Focus();
        }

        // Demirbaş kategori tanımı formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmDemirbaslarKategoriTanimlama_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Demirbaş kategori tanımı formu tekrar etkinleştiğinde tanım/kayıt listesini yeniden okuyarak ekrandaki veriyi güncel tutar.
        private void FrmDemirbaslarKategoriTanimlama_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Gridde seçilen demirbaş kategori tanımı satırının ID ve ad/değer bilgisini form alanlarına aktararak silme veya güncelleme işlemine hazırlar.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                seciliID = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["ID"].Value);

                txtKategori.Text =
                    dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            }
        }

        // Demirbaş kategori tanımı listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
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

        // Demirbaş kategori tanımı silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
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

        // Demirbaş kategori tanımı güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
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

        // Demirbaş kategori tanımı temizleme düğmesinde form alanlarını sıfırlar ve ekranı yeni işlem için hazırlar.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
