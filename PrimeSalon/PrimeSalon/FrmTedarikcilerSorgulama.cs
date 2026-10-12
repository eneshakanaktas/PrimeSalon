using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmTedarikcilerSorgulama : Form
    {
        // FrmTedarikcilerSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak tedarikçi ekranını kullanıma hazırlar.
        public FrmTedarikcilerSorgulama()
        {
            InitializeComponent();
        }

        // Tedarikçi tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvTedarikcilerSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Tedarikciler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Tedarikciler");
                dgvTedarikcilerSorgulama.DataSource = ds.Tables["Tedarikciler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Tedarikçi kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Tedarikciler";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkFirmaAdi.Checked == true && chkYetkili.Checked == true)
                {
                    Sorgu = "Select * from Tedarikciler where FirmaAdi=@FirmaAdi and YetkiliAdSoyad=@YetkiliAdSoyad";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                    komut.Parameters.AddWithValue("@YetkiliAdSoyad", txtYetkili.Text);
                }
                else if (chkFirmaAdi.Checked == true)
                {
                    Sorgu = "Select * from Tedarikciler where FirmaAdi=@FirmaAdi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                }
                else if (chkYetkili.Checked == true)
                {
                    Sorgu = "Select * from Tedarikciler where YetkiliAdSoyad=@YetkiliAdSoyad";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@YetkiliAdSoyad", txtYetkili.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Tedarikciler");
                dgvTedarikcilerSorgulama.DataSource = ds.Tables["Tedarikciler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Tedarikçi kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Tedarikciler";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radFirmaAdi.Checked == true)
                    kolonAdi = "FirmaAdi";
                else if (radYetkili.Checked == true)
                    kolonAdi = "YetkiliAdSoyad";
                else if (radTelefon.Checked == true)
                    kolonAdi = "Telefon";
                else if (radBanka.Checked == true)
                    kolonAdi = "Banka";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (radTelefon.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        Sorgu = "Select * from Tedarikciler where Telefon like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "(" + txtHizliAra.Text + "%");
                    }
                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        Sorgu = "Select * from Tedarikciler where Telefon like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        Sorgu = "Select * from Tedarikciler where Telefon like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                    }
                }
                else
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        Sorgu = "Select * from Tedarikciler where " + kolonAdi + " like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                    }
                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        Sorgu = "Select * from Tedarikciler where " + kolonAdi + " like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        Sorgu = "Select * from Tedarikciler where " + kolonAdi + " like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Tedarikciler");
                dgvTedarikcilerSorgulama.DataSource = ds.Tables["Tedarikciler"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Tedarikçi formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmTedarikcilerSorgulama_Load(object sender, EventArgs e)
        {
            txtFirmaAdi.Enabled = false;
            txtYetkili.Enabled = false;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // Firma Adi filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkFirmaAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFirmaAdi.Checked == true)
            {
                txtFirmaAdi.Enabled = true;
                txtFirmaAdi.Focus();
            }
            else
            {
                txtFirmaAdi.Enabled = false;
                txtFirmaAdi.Clear();
            }
        }

        // yetkili filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkYetkili_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYetkili.Checked == true)
            {
                txtYetkili.Enabled = true;
                txtYetkili.Focus();
            }
            else
            {
                txtYetkili.Enabled = false;
                txtYetkili.Clear();
            }
        }

        // Tedarikçi arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Tedarikçi listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkFirmaAdi.Checked = false;
            chkYetkili.Checked = false;
            txtFirmaAdi.Clear();
            txtYetkili.Clear();
            KayitListele();
        }

        // Firma Adi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radFirmaAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (radFirmaAdi.Checked == true)
            {
                lblArananAlan.Text = "Firma Adı";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // yetkili hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radYetkili_CheckedChanged(object sender, EventArgs e)
        {
            if (radYetkili.Checked == true)
            {
                lblArananAlan.Text = "Yetkili";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // telefon hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radTelefon_CheckedChanged(object sender, EventArgs e)
        {
            if (radTelefon.Checked == true)
            {
                lblArananAlan.Text = "Telefon";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // banka hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radBanka_CheckedChanged(object sender, EventArgs e)
        {
            if (radBanka.Checked == true)
            {
                lblArananAlan.Text = "Banka";
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