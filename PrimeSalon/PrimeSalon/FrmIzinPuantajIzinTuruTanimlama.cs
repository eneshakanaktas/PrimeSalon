using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmIzinPuantajIzinTuruTanimlama : Form
    {
        int seciliID = 0;

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=(LocalDB)\PrimeSalonDB;Initial Catalog=PrimeSalonDB;Integrated Security=True");

        // FrmIzinPuantajIzinTuruTanimlama formunu başlatır; Windows Form kontrollerini oluşturarak izin/puantaj izin türü tanımı ekranını kullanıma hazırlar.
        public FrmIzinPuantajIzinTuruTanimlama()
        {
            InitializeComponent();
        }

        // İzin türü tanımı tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dataGridView1 üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                string sorgu = "SELECT ID, IzinTuru FROM IzinPuantajIzinTuruTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                da.Fill(ds, "IzinPuantajIzinTuruTanimlama");
                dataGridView1.DataSource = ds.Tables["IzinPuantajIzinTuruTanimlama"];

                if (dataGridView1.Columns["ID"] != null)
                    dataGridView1.Columns["ID"].Visible = false;

                if (dataGridView1.Columns["IzinTuru"] != null)
                    dataGridView1.Columns["IzinTuru"].HeaderText = "İzin Türü";
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

        // Formdaki izin/puantaj izin türü tanımı bilgilerini parametreli SQL komutuyla izin türü tanımı tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "INSERT INTO IzinPuantajIzinTuruTanimlama(IzinTuru) VALUES(@IzinTuru)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@IzinTuru", txtIzinTuru.Text.Trim());

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

        // Seçili izin/puantaj izin türü tanımı kaydını ID değerine göre izin türü tanımı tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "DELETE FROM IzinPuantajIzinTuruTanimlama WHERE ID=@ID";
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

        // Formdaki düzenlenmiş izin/puantaj izin türü tanımı bilgilerini seçili ID üzerinden izin türü tanımı tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "UPDATE IzinPuantajIzinTuruTanimlama SET IzinTuru=@IzinTuru WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@IzinTuru", txtIzinTuru.Text.Trim());
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

        // İzin/puantaj izin türü tanımı formundaki ID ve giriş alanlarını sıfırlar; yeni kayıt girişi için ekranı başlangıç durumuna getirir.
        public void Temizle()
        {
            txtIzinTuru.Clear();
            seciliID = 0;
            txtIzinTuru.Focus();
        }

        // İzin/puantaj izin türü tanımı formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmIzinPuantajIzinTuruTanimlama_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // İzin/puantaj izin türü tanımı formu tekrar etkinleştiğinde tanım/kayıt listesini yeniden okuyarak ekrandaki veriyi güncel tutar.
        private void FrmIzinPuantajIzinTuruTanimlama_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Gridde seçilen izin/puantaj izin türü tanımı satırının ID ve ad/değer bilgisini form alanlarına aktararak silme veya güncelleme işlemine hazırlar.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                txtIzinTuru.Text = dataGridView1.CurrentRow.Cells["IzinTuru"].Value.ToString();
            }
        }

        // İzin/puantaj izin türü tanımı listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIzinTuru.Text.Trim() == "")
                MessageBox.Show("İzin türü boş geçilemez");
            else
            {
                KayitEkle();
                KayitListele();
                Temizle();
            }
        }

        // İzin/puantaj izin türü tanımı silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
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

        // İzin/puantaj izin türü tanımı güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Güncellenecek kaydı seçiniz");
            else if (txtIzinTuru.Text.Trim() == "")
                MessageBox.Show("İzin türü boş geçilemez");
            else
            {
                KayitGuncelle();
                KayitListele();
                Temizle();
            }
        }

        // İzin/puantaj izin türü tanımı temizleme düğmesinde form alanlarını sıfırlar ve ekranı yeni işlem için hazırlar.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
