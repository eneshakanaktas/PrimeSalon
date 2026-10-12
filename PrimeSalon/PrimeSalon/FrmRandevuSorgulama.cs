using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmRandevuSorgulama : Form
    {
        // FrmRandevuSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak randevu ekranını kullanıma hazırlar.
        public FrmRandevuSorgulama()
        {
            InitializeComponent();
        }

        // Randevu tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvRandevuSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Randevu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Randevu");
                dgvRandevuSorgulama.DataSource = ds.Tables["Randevu"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Randevu kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Randevu";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkDurum.Checked == true)
                {
                    Sorgu = "Select * from Randevu where Durum=@Durum";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Randevu");
                dgvRandevuSorgulama.DataSource = ds.Tables["Randevu"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Randevu kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Randevu";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radDurum.Checked == true)
                    kolonAdi = "Durum";
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
                    Sorgu = "Select * from Randevu where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from Randevu where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from Randevu where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Randevu");
                dgvRandevuSorgulama.DataSource = ds.Tables["Randevu"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Randevu formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmRandevuSorgulama_Load(object sender, EventArgs e)
        {
            cmbDurum.Enabled = false;
            cmbDurum.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // Durum filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDurum.Checked == true)
            {
                cmbDurum.Enabled = true;
                cmbDurum.Focus();
            }
            else
            {
                cmbDurum.Enabled = false;
                cmbDurum.SelectedIndex = 0;
            }
        }

        // Randevu arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Randevu listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkDurum.Checked = false;
            cmbDurum.SelectedIndex = 0;
            KayitListele();
        }

        // Durum hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (radDurum.Checked == true)
            {
                lblArananAlan.Text = "Durum";
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