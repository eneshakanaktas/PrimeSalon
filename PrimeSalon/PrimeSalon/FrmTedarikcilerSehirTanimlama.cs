using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmTedarikcilerSehirTanimlama : Form
    {
        int seciliID = 0;

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=(LocalDB)\PrimeSalonDB;Initial Catalog=PrimeSalonDB;Integrated Security=True");

        // FrmTedarikcilerSehirTanimlama formunu başlatır; Windows Form kontrollerini oluşturarak tedarikçi şehir tanımı ekranını kullanıma hazırlar.
        public FrmTedarikcilerSehirTanimlama()
        {
            InitializeComponent();
        }

        // Tedarikçi şehir tanımı tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dataGridView1 üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                string sorgu = "SELECT ID, Sehir FROM TedarikcilerSehirTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                da.Fill(ds, "TedarikcilerSehirTanimlama");
                dataGridView1.DataSource = ds.Tables["TedarikcilerSehirTanimlama"];

                if (dataGridView1.Columns["ID"] != null)
                    dataGridView1.Columns["ID"].Visible = false;

                if (dataGridView1.Columns["Sehir"] != null)
                    dataGridView1.Columns["Sehir"].HeaderText = "Şehir";
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

        // Formdaki tedarikçi şehir tanımı bilgilerini parametreli SQL komutuyla tedarikçi şehir tanımı tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "INSERT INTO TedarikcilerSehirTanimlama(Sehir) VALUES(@Sehir)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Sehir", txtSehir.Text.Trim());

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

        // Seçili tedarikçi şehir tanımı kaydını ID değerine göre tedarikçi şehir tanımı tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "DELETE FROM TedarikcilerSehirTanimlama WHERE ID=@ID";
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

        // Formdaki düzenlenmiş tedarikçi şehir tanımı bilgilerini seçili ID üzerinden tedarikçi şehir tanımı tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "UPDATE TedarikcilerSehirTanimlama SET Sehir=@Sehir WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Sehir", txtSehir.Text.Trim());
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

        // Tedarikçi şehir tanımı formundaki ID ve giriş alanlarını sıfırlar; yeni kayıt girişi için ekranı başlangıç durumuna getirir.
        public void Temizle()
        {
            txtSehir.Clear();
            seciliID = 0;
            txtSehir.Focus();
        }

        // Tedarikçi şehir tanımı formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmTedarikcilerSehirTanimlama_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Tedarikçi şehir tanımı formu tekrar etkinleştiğinde tanım/kayıt listesini yeniden okuyarak ekrandaki veriyi güncel tutar.
        private void FrmTedarikcilerSehirTanimlama_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Gridde seçilen tedarikçi şehir tanımı satırının ID ve ad/değer bilgisini form alanlarına aktararak silme veya güncelleme işlemine hazırlar.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                txtSehir.Text = dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();
            }
        }

        // Tedarikçi şehir tanımı listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSehir.Text.Trim() == "")
                MessageBox.Show("Şehir boş geçilemez");
            else
            {
                KayitEkle();
                KayitListele();
                Temizle();
            }
        }

        // Tedarikçi şehir tanımı silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
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

        // Tedarikçi şehir tanımı güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Güncellenecek kaydı seçiniz");
            else if (txtSehir.Text.Trim() == "")
                MessageBox.Show("Şehir boş geçilemez");
            else
            {
                KayitGuncelle();
                KayitListele();
                Temizle();
            }
        }

        // Tedarikçi şehir tanımı temizleme düğmesinde form alanlarını sıfırlar ve ekranı yeni işlem için hazırlar.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
