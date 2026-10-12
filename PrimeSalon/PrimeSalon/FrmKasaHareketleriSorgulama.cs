using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmKasaHareketleriSorgulama : Form
    {
        // FrmKasaHareketleriSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak kasa hareketi ekranını kullanıma hazırlar.
        public FrmKasaHareketleriSorgulama()
        {
            InitializeComponent();
        }

        // Kasa hareketi tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvKasaHareketleriSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from KasaHareketleri";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "KasaHareketleri");
                dgvKasaHareketleriSorgulama.DataSource = ds.Tables["KasaHareketleri"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Kasa hareketi kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from KasaHareketleri";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkIslemTipi.Checked == true && chkIslemKategorisi.Checked == true)
                {
                    Sorgu = "Select * from KasaHareketleri where IslemTipi=@IslemTipi and IslemKategorisi=@IslemKategorisi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                    komut.Parameters.AddWithValue("@IslemKategorisi", cmbIslemKategorisi.Text);
                }
                else if (chkIslemTipi.Checked == true)
                {
                    Sorgu = "Select * from KasaHareketleri where IslemTipi=@IslemTipi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                }
                else if (chkIslemKategorisi.Checked == true)
                {
                    Sorgu = "Select * from KasaHareketleri where IslemKategorisi=@IslemKategorisi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@IslemKategorisi", cmbIslemKategorisi.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "KasaHareketleri");
                dgvKasaHareketleriSorgulama.DataSource = ds.Tables["KasaHareketleri"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Kasa hareketi kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
        public void HizliAra()
        {
            try
            {
                if (cmbAramaTuru.Text == "Seçiniz")
                {
                    KayitListele();
                    return;
                }

                if (txtHizliAra.Text.Trim() == "")
                {
                    KayitListele();
                    return;
                }

                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from KasaHareketleri";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radIslemiYapan.Checked == true)
                    kolonAdi = "IslemiYapan";
                else if (radIslemTipi.Checked == true)
                    kolonAdi = "IslemTipi";
                else if (radIslemKategorisi.Checked == true)
                    kolonAdi = "IslemKategorisi";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from KasaHareketleri where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from KasaHareketleri where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from KasaHareketleri where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "KasaHareketleri");
                dgvKasaHareketleriSorgulama.DataSource = ds.Tables["KasaHareketleri"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Kasa hareketi formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmKasaHareketleriSorgulama_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.Enabled = false;
            cmbIslemKategorisi.Enabled = false;
            cmbIslemTipi.SelectedIndex = 0;
            cmbIslemKategorisi.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // ıslem Tipi filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkIslemTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIslemTipi.Checked == true)
            {
                cmbIslemTipi.Enabled = true;
                cmbIslemTipi.Focus();
            }
            else
            {
                cmbIslemTipi.Enabled = false;
                cmbIslemTipi.SelectedIndex = 0;
            }
        }

        // ıslem Kategorisi filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkIslemKategorisi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIslemKategorisi.Checked == true)
            {
                cmbIslemKategorisi.Enabled = true;
                cmbIslemKategorisi.Focus();
            }
            else
            {
                cmbIslemKategorisi.Enabled = false;
                cmbIslemKategorisi.SelectedIndex = 0;
            }
        }

        // Kasa hareketi arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Kasa hareketi listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkIslemTipi.Checked = false;
            chkIslemKategorisi.Checked = false;
            cmbIslemTipi.SelectedIndex = 0;
            cmbIslemKategorisi.SelectedIndex = 0;
            KayitListele();
        }

        // ıslemi Yapan hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radIslemiYapan_CheckedChanged(object sender, EventArgs e)
        {
            if (radIslemiYapan.Checked == true)
            {
                lblArananAlan.Text = "İşlemi Yapan";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // ıslem Tipi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radIslemTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (radIslemTipi.Checked == true)
            {
                lblArananAlan.Text = "İşlem Tipi";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // ıslem Kategorisi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radIslemKategorisi_CheckedChanged(object sender, EventArgs e)
        {
            if (radIslemKategorisi.Checked == true)
            {
                lblArananAlan.Text = "İşlem Kategorisi";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // Hızlı arama metni her değiştiğinde seçili arama alanı ve arama türüne göre listeyi anlık olarak filtreler.
        private void txtHizliAra_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        // arama Turu seçimindeki değeri ilgili form alanına aktarır; kayıt ekleme veya güncelleme sırasında seçilen metnin kullanılmasını sağlar.
        private void cmbAramaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHizliAra.Clear();
            txtHizliAra.Focus();
        }
    }
}