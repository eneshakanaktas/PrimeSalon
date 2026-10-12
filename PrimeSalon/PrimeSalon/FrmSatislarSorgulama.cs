using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmSatislarSorgulama : Form
    {
        // FrmSatislarSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak satış ekranını kullanıma hazırlar.
        public FrmSatislarSorgulama()
        {
            InitializeComponent();
        }

        // Satış tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvSatislarSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Satislar";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Satislar");
                dgvSatislarSorgulama.DataSource = ds.Tables["Satislar"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Satış kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Satislar";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkSatisTipi.Checked == true && chkOdemeDurumu.Checked == true)
                {
                    Sorgu = "Select * from Satislar where SatisTipi=@SatisTipi and OdemeDurumu=@OdemeDurumu";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@SatisTipi", cmbSatisTipi.Text);
                    komut.Parameters.AddWithValue("@OdemeDurumu", cmbOdemeDurumu.Text);
                }
                else if (chkSatisTipi.Checked == true)
                {
                    Sorgu = "Select * from Satislar where SatisTipi=@SatisTipi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@SatisTipi", cmbSatisTipi.Text);
                }
                else if (chkOdemeDurumu.Checked == true)
                {
                    Sorgu = "Select * from Satislar where OdemeDurumu=@OdemeDurumu";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@OdemeDurumu", cmbOdemeDurumu.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Satislar");
                dgvSatislarSorgulama.DataSource = ds.Tables["Satislar"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Satış kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Satislar";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radSatisTipi.Checked == true)
                    kolonAdi = "SatisTipi";
                else if (radOdemeTipi.Checked == true)
                    kolonAdi = "OdemeTipi";
                else if (radOdemeDurumu.Checked == true)
                    kolonAdi = "OdemeDurumu";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from Satislar where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from Satislar where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from Satislar where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Satislar");
                dgvSatislarSorgulama.DataSource = ds.Tables["Satislar"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Satış formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmSatislarSorgulama_Load(object sender, EventArgs e)
        {
            cmbSatisTipi.Enabled = false;
            cmbOdemeDurumu.Enabled = false;
            cmbSatisTipi.SelectedIndex = 0;
            cmbOdemeDurumu.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // Satış Tipi filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkSatisTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSatisTipi.Checked == true)
            {
                cmbSatisTipi.Enabled = true;
                cmbSatisTipi.Focus();
            }
            else
            {
                cmbSatisTipi.Enabled = false;
                cmbSatisTipi.SelectedIndex = 0;
            }
        }

        // odeme Durumu filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkOdemeDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOdemeDurumu.Checked == true)
            {
                cmbOdemeDurumu.Enabled = true;
                cmbOdemeDurumu.Focus();
            }
            else
            {
                cmbOdemeDurumu.Enabled = false;
                cmbOdemeDurumu.SelectedIndex = 0;
            }
        }

        // Satış arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Satış listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkSatisTipi.Checked = false;
            chkOdemeDurumu.Checked = false;
            cmbSatisTipi.SelectedIndex = 0;
            cmbOdemeDurumu.SelectedIndex = 0;
            KayitListele();
        }

        // Satış Tipi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radSatisTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (radSatisTipi.Checked == true)
            {
                lblArananAlan.Text = "Satış Tipi";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // odeme Tipi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radOdemeTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (radOdemeTipi.Checked == true)
            {
                lblArananAlan.Text = "Ödeme Tipi";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // odeme Durumu hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radOdemeDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (radOdemeDurumu.Checked == true)
            {
                lblArananAlan.Text = "Ödeme Durumu";
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