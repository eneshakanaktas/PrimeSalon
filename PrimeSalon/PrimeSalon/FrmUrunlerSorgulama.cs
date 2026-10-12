using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmUrunlerSorgulama : Form
    {
        // FrmUrunlerSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak ürün ekranını kullanıma hazırlar.
        public FrmUrunlerSorgulama()
        {
            InitializeComponent();
        }

        // Ürün tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvUrunlerSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Urunler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Urunler");
                dgvUrunlerSorgulama.DataSource = ds.Tables["Urunler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Ürün kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Urunler";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkMarka.Checked == true && chkKategori.Checked == true)
                {
                    Sorgu = "Select * from Urunler where Marka=@Marka and Kategori=@Kategori";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                    komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                }
                else if (chkMarka.Checked == true)
                {
                    Sorgu = "Select * from Urunler where Marka=@Marka";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                }
                else if (chkKategori.Checked == true)
                {
                    Sorgu = "Select * from Urunler where Kategori=@Kategori";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Urunler");
                dgvUrunlerSorgulama.DataSource = ds.Tables["Urunler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Ürün kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Urunler";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radUrunAdi.Checked == true)
                    kolonAdi = "UrunAdi";
                else if (radMarka.Checked == true)
                    kolonAdi = "Marka";
                else if (radKategori.Checked == true)
                    kolonAdi = "Kategori";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from Urunler where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from Urunler where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from Urunler where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Urunler");
                dgvUrunlerSorgulama.DataSource = ds.Tables["Urunler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Ürün formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmUrunlerSorgulama_Load(object sender, EventArgs e)
        {
            txtMarka.Enabled = false;
            cmbKategori.Enabled = false;
            cmbKategori.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // marka filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkMarka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarka.Checked == true)
            {
                txtMarka.Enabled = true;
                txtMarka.Focus();
            }
            else
            {
                txtMarka.Enabled = false;
                txtMarka.Clear();
            }
        }

        // Kategori filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKategori.Checked == true)
            {
                cmbKategori.Enabled = true;
                cmbKategori.Focus();
            }
            else
            {
                cmbKategori.Enabled = false;
                cmbKategori.SelectedIndex = 0;
            }
        }

        // Ürün arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Ürün listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkMarka.Checked = false;
            chkKategori.Checked = false;
            txtMarka.Clear();
            cmbKategori.SelectedIndex = 0;
            KayitListele();
        }

        // Ürün Adi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radUrunAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (radUrunAdi.Checked == true)
            {
                lblArananAlan.Text = "Ürün Adı";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // marka hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radMarka_CheckedChanged(object sender, EventArgs e)
        {
            if (radMarka.Checked == true)
            {
                lblArananAlan.Text = "Marka";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // Kategori hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (radKategori.Checked == true)
            {
                lblArananAlan.Text = "Kategori";
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