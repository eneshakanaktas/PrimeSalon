using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmGiderlerSorgulama : Form
    {
        // FrmGiderlerSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak gider ekranını kullanıma hazırlar.
        public FrmGiderlerSorgulama()
        {
            InitializeComponent();
        }

        // Gider tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvGiderlerSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Giderler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Giderler");
                dgvGiderlerSorgulama.DataSource = ds.Tables["Giderler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Gider kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Giderler";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkGiderTuru.Checked == true)
                {
                    Sorgu = "Select * from Giderler where GiderTuru=@GiderTuru";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@GiderTuru", cmbGiderTuru.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Giderler");
                dgvGiderlerSorgulama.DataSource = ds.Tables["Giderler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Gider kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Giderler";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radFirma.Checked == true)
                    kolonAdi = "Firma";
                else if (radGiderTuru.Checked == true)
                    kolonAdi = "GiderTuru";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from Giderler where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from Giderler where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from Giderler where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Giderler");
                dgvGiderlerSorgulama.DataSource = ds.Tables["Giderler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Gider formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmGiderlerSorgulama_Load(object sender, EventArgs e)
        {
            cmbGiderTuru.Enabled = false;
            cmbGiderTuru.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // Gider Turu filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkGiderTuru_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGiderTuru.Checked == true)
            {
                cmbGiderTuru.Enabled = true;
                cmbGiderTuru.Focus();
            }
            else
            {
                cmbGiderTuru.Enabled = false;
                cmbGiderTuru.SelectedIndex = 0;
            }
        }

        // Gider arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Gider listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkGiderTuru.Checked = false;
            cmbGiderTuru.SelectedIndex = 0;
            KayitListele();
        }

        // Firma hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (radFirma.Checked == true)
            {
                lblArananAlan.Text = "Firma";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // Gider Turu hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radGiderTuru_CheckedChanged(object sender, EventArgs e)
        {
            if (radGiderTuru.Checked == true)
            {
                lblArananAlan.Text = "Gider Türü";
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