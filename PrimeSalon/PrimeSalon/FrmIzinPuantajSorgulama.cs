using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmIzinPuantajSorgulama : Form
    {
        // FrmIzinPuantajSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak izin/puantaj ekranını kullanıma hazırlar.
        public FrmIzinPuantajSorgulama()
        {
            InitializeComponent();
        }

        // İzin/puantaj tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvIzinPuantajSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from IzinPuantaj";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "IzinPuantaj");
                dgvIzinPuantajSorgulama.DataSource = ds.Tables["IzinPuantaj"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // İzin/puantaj kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from IzinPuantaj";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkIslemTipi.Checked == true && chkOnayDurumu.Checked == true)
                {
                    Sorgu = "Select * from IzinPuantaj where IslemTipi=@IslemTipi and OnayDurumu=@OnayDurumu";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                    komut.Parameters.AddWithValue("@OnayDurumu", cmbOnayDurumu.Text);
                }
                else if (chkIslemTipi.Checked == true)
                {
                    Sorgu = "Select * from IzinPuantaj where IslemTipi=@IslemTipi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                }
                else if (chkOnayDurumu.Checked == true)
                {
                    Sorgu = "Select * from IzinPuantaj where OnayDurumu=@OnayDurumu";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@OnayDurumu", cmbOnayDurumu.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "IzinPuantaj");
                dgvIzinPuantajSorgulama.DataSource = ds.Tables["IzinPuantaj"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // İzin/puantaj kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from IzinPuantaj";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radOnaylayan.Checked == true)
                    kolonAdi = "Onaylayan";
                else if (radIslemTipi.Checked == true)
                    kolonAdi = "IslemTipi";
                else if (radOnayDurumu.Checked == true)
                    kolonAdi = "OnayDurumu";
                else if (radIzinTuru.Checked == true)
                    kolonAdi = "IzinTuru";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from IzinPuantaj where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from IzinPuantaj where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from IzinPuantaj where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "IzinPuantaj");
                dgvIzinPuantajSorgulama.DataSource = ds.Tables["IzinPuantaj"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // İzin/puantaj formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmIzinPuantajSorgulama_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.Enabled = false;
            cmbOnayDurumu.Enabled = false;
            cmbIslemTipi.SelectedIndex = 0;
            cmbOnayDurumu.SelectedIndex = 0;

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

        // onay Durumu filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkOnayDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnayDurumu.Checked == true)
            {
                cmbOnayDurumu.Enabled = true;
                cmbOnayDurumu.Focus();
            }
            else
            {
                cmbOnayDurumu.Enabled = false;
                cmbOnayDurumu.SelectedIndex = 0;
            }
        }

        // İzin/puantaj arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // İzin/puantaj listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkIslemTipi.Checked = false;
            chkOnayDurumu.Checked = false;
            cmbIslemTipi.SelectedIndex = 0;
            cmbOnayDurumu.SelectedIndex = 0;
            KayitListele();
        }

        // onaylayan hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radOnaylayan_CheckedChanged(object sender, EventArgs e)
        {
            if (radOnaylayan.Checked == true)
            {
                lblArananAlan.Text = "Onaylayan";
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

        // onay Durumu hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radOnayDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (radOnayDurumu.Checked == true)
            {
                lblArananAlan.Text = "Onay Durumu";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // İzin türü hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radIzinTuru_CheckedChanged(object sender, EventArgs e)
        {
            if (radIzinTuru.Checked == true)
            {
                lblArananAlan.Text = "İzin Türü";
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