using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmHizmetSorgulama : Form
    {
        // FrmHizmetSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak hizmet ekranını kullanıma hazırlar.
        public FrmHizmetSorgulama()
        {
            InitializeComponent();
        }

        // Hizmet tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvHizmetSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Hizmet";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Hizmet");
                dgvHizmetSorgulama.DataSource = ds.Tables["Hizmet"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Hizmet kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Hizmet";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkHizmetAdi.Checked == true && chkKategori.Checked == true)
                {
                    Sorgu = "Select * from Hizmet where HizmetAdi=@HizmetAdi and Kategori=@Kategori";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@HizmetAdi", txtHizmetAdi.Text);
                    komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                }
                else if (chkHizmetAdi.Checked == true)
                {
                    Sorgu = "Select * from Hizmet where HizmetAdi=@HizmetAdi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@HizmetAdi", txtHizmetAdi.Text);
                }
                else if (chkKategori.Checked == true)
                {
                    Sorgu = "Select * from Hizmet where Kategori=@Kategori";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Hizmet");
                dgvHizmetSorgulama.DataSource = ds.Tables["Hizmet"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Hizmet kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Hizmet";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radHizmetAdi.Checked == true)
                    kolonAdi = "HizmetAdi";
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
                    Sorgu = "Select * from Hizmet where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from Hizmet where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from Hizmet where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Hizmet");
                dgvHizmetSorgulama.DataSource = ds.Tables["Hizmet"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Hizmet formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmHizmetSorgulama_Load(object sender, EventArgs e)
        {
            txtHizmetAdi.Enabled = false;
            cmbKategori.Enabled = false;
            cmbKategori.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // Hizmet Adi filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkHizmetAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHizmetAdi.Checked == true)
            {
                txtHizmetAdi.Enabled = true;
                txtHizmetAdi.Focus();
            }
            else
            {
                txtHizmetAdi.Enabled = false;
                txtHizmetAdi.Clear();
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

        // Hizmet arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Hizmet listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkHizmetAdi.Checked = false;
            chkKategori.Checked = false;
            txtHizmetAdi.Clear();
            cmbKategori.SelectedIndex = 0;
            KayitListele();
        }

        // Hizmet Adi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radHizmetAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (radHizmetAdi.Checked == true)
            {
                lblArananAlan.Text = "Hizmet Adı";
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