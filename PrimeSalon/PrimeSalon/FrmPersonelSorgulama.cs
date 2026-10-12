using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmPersonelSorgulama : Form
    {
        // FrmPersonelSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak personel ekranını kullanıma hazırlar.
        public FrmPersonelSorgulama()
        {
            InitializeComponent();
        }

        // Personel tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvPersonelSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Personel";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Personel");
                dgvPersonelSorgulama.DataSource = ds.Tables["Personel"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Personel kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Personel";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkAd.Checked == true && chkSoyad.Checked == true)
                {
                    Sorgu = "Select * from Personel where Ad=@Ad and Soyad=@Soyad";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                }
                else if (chkAd.Checked == true)
                {
                    Sorgu = "Select * from Personel where Ad=@Ad";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                }
                else if (chkSoyad.Checked == true)
                {
                    Sorgu = "Select * from Personel where Soyad=@Soyad";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Personel");
                dgvPersonelSorgulama.DataSource = ds.Tables["Personel"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Personel kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Personel";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radAd.Checked == true)
                    kolonAdi = "Ad";
                else if (radSoyad.Checked == true)
                    kolonAdi = "Soyad";
                else if (radTelefon.Checked == true)
                    kolonAdi = "Telefon";
                else if (radTcNo.Checked == true)
                    kolonAdi = "TcNo";
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
                        Sorgu = "Select * from Personel where Telefon like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "(" + txtHizliAra.Text + "%");
                    }
                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        Sorgu = "Select * from Personel where Telefon like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        Sorgu = "Select * from Personel where Telefon like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                    }
                }
                else
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        Sorgu = "Select * from Personel where " + kolonAdi + " like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                    }
                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        Sorgu = "Select * from Personel where " + kolonAdi + " like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        Sorgu = "Select * from Personel where " + kolonAdi + " like @Aranan";
                        komut.CommandText = Sorgu;
                        komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Personel");
                dgvPersonelSorgulama.DataSource = ds.Tables["Personel"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Personel formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmPersonelSorgulama_Load(object sender, EventArgs e)
        {
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // ad filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkAd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAd.Checked == true)
            {
                txtAd.Enabled = true;
                txtAd.Focus();
            }
            else
            {
                txtAd.Enabled = false;
                txtAd.Clear();
            }
        }

        // soyad filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoyad.Checked == true)
            {
                txtSoyad.Enabled = true;
                txtSoyad.Focus();
            }
            else
            {
                txtSoyad.Enabled = false;
                txtSoyad.Clear();
            }
        }

        // Personel arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Personel listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkAd.Checked = false;
            chkSoyad.Checked = false;
            txtAd.Clear();
            txtSoyad.Clear();
            KayitListele();
        }

        // ad hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radAd_CheckedChanged(object sender, EventArgs e)
        {
            if (radAd.Checked == true)
            {
                lblArananAlan.Text = "Ad";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // soyad hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoyad.Checked == true)
            {
                lblArananAlan.Text = "Soyad";
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

        // tc No hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radTcNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radTcNo.Checked == true)
            {
                lblArananAlan.Text = "TC No";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }
    }
}