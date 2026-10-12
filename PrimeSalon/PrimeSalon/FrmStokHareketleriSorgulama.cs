using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmStokHareketleriSorgulama : Form
    {
        // FrmStokHareketleriSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak stok hareketi ekranını kullanıma hazırlar.
        public FrmStokHareketleriSorgulama()
        {
            InitializeComponent();
        }

        // Stok hareketi tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvStokHareketleriSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from StokHareketleri";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "StokHareketleri");
                dgvStokHareketleriSorgulama.DataSource = ds.Tables["StokHareketleri"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Stok hareketi kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from StokHareketleri";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkDepo.Checked == true)
                {
                    Sorgu = "Select * from StokHareketleri where Depo=@Depo";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Depo", cmbDepo.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "StokHareketleri");
                dgvStokHareketleriSorgulama.DataSource = ds.Tables["StokHareketleri"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Stok hareketi kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from StokHareketleri";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radKullanici.Checked == true)
                    kolonAdi = "Kullanici";
                else if (radIslemTipi.Checked == true)
                    kolonAdi = "IslemTipi";
                else if (radDepo.Checked == true)
                    kolonAdi = "Depo";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from StokHareketleri where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from StokHareketleri where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from StokHareketleri where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "StokHareketleri");
                dgvStokHareketleriSorgulama.DataSource = ds.Tables["StokHareketleri"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Stok hareketi formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmStokHareketleriSorgulama_Load(object sender, EventArgs e)
        {
            cmbDepo.Enabled = false;
            cmbDepo.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // depo filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkDepo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDepo.Checked == true)
            {
                cmbDepo.Enabled = true;
                cmbDepo.Focus();
            }
            else
            {
                cmbDepo.Enabled = false;
                cmbDepo.SelectedIndex = 0;
            }
        }

        // Stok hareketi arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Stok hareketi listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkDepo.Checked = false;
            cmbDepo.SelectedIndex = 0;
            KayitListele();
        }

        // kullanici hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radKullanici_CheckedChanged(object sender, EventArgs e)
        {
            if (radKullanici.Checked == true)
            {
                lblArananAlan.Text = "Kullanıcı";
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

        // depo hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radDepo_CheckedChanged(object sender, EventArgs e)
        {
            if (radDepo.Checked == true)
            {
                lblArananAlan.Text = "Depo";
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