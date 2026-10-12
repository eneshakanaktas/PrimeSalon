using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmDemirbaslarSorgulama : Form
    {
        // FrmDemirbaslarSorgulama formunu başlatır; Windows Form kontrollerini oluşturarak demirbaş ekranını kullanıma hazırlar.
        public FrmDemirbaslarSorgulama()
        {
            InitializeComponent();
        }

        // Demirbaş tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvDemirbaslarSorgulama üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Demirbaslar";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Demirbaslar");
                dgvDemirbaslarSorgulama.DataSource = ds.Tables["Demirbaslar"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Demirbaş kayıtlarını işaretlenen filtre alanlarına göre parametreli SQL sorgusuyla arar ve sonuçları rapor/liste ekranına aktarır.
        public void KayitAra()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "Select * from Demirbaslar";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                if (chkDemirbasAdi.Checked == true && chkKategori.Checked == true)
                {
                    Sorgu = "Select * from Demirbaslar where DemirbasAdi=@DemirbasAdi and Kategori=@Kategori";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@DemirbasAdi", txtDemirbasAdi.Text);
                    komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                }
                else if (chkDemirbasAdi.Checked == true)
                {
                    Sorgu = "Select * from Demirbaslar where DemirbasAdi=@DemirbasAdi";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@DemirbasAdi", txtDemirbasAdi.Text);
                }
                else if (chkKategori.Checked == true)
                {
                    Sorgu = "Select * from Demirbaslar where Kategori=@Kategori";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                }
                else
                {
                    komut.CommandText = Sorgu;
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Demirbaslar");
                dgvDemirbaslarSorgulama.DataSource = ds.Tables["Demirbaslar"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        // Demirbaş kayıtlarında seçilen hızlı arama alanına göre başlayan, biten veya içeren metin filtresi uygular.
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
                string Sorgu = "Select * from Demirbaslar";
                SqlCommand komut = new SqlCommand();
                komut.Connection = FrmPersonel.Baglanti;

                string kolonAdi = "";

                if (radDemirbasAdi.Checked == true)
                    kolonAdi = "DemirbasAdi";
                else if (radMarka.Checked == true)
                    kolonAdi = "Marka";
                else if (radModel.Checked == true)
                    kolonAdi = "Model";
                else if (radSorumlu.Checked == true)
                    kolonAdi = "SorumluPersonel";
                else
                {
                    FrmPersonel.Baglanti.Close();
                    MessageBox.Show("Lütfen arama yapılacak alanı seçiniz.");
                    return;
                }

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    Sorgu = "Select * from Demirbaslar where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", txtHizliAra.Text + "%");
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    Sorgu = "Select * from Demirbaslar where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text);
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    Sorgu = "Select * from Demirbaslar where " + kolonAdi + " like @Aranan";
                    komut.CommandText = Sorgu;
                    komut.Parameters.AddWithValue("@Aranan", "%" + txtHizliAra.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(ds, "Demirbaslar");
                dgvDemirbaslarSorgulama.DataSource = ds.Tables["Demirbaslar"];

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        // Demirbaş formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmDemirbaslarSorgulama_Load(object sender, EventArgs e)
        {
            txtDemirbasAdi.Enabled = false;
            cmbKategori.Enabled = false;
            cmbKategori.SelectedIndex = 0;

            cmbAramaTuru.SelectedIndex = 0;
            lblArananAlan.Text = "Aranan Alan";
            txtHizliAra.Clear();

            KayitListele();
        }

        // Demirbaş Adi filtresi işaretlenince ilgili giriş alanını aktif eder; işaret kaldırılınca alanı temizleyip filtreyi devre dışı bırakır.
        private void chkDemirbasAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDemirbasAdi.Checked == true)
            {
                txtDemirbasAdi.Enabled = true;
                txtDemirbasAdi.Focus();
            }
            else
            {
                txtDemirbasAdi.Enabled = false;
                txtDemirbasAdi.Clear();
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

        // Demirbaş arama düğmesinde seçilen filtreleri kullanarak sorguyu çalıştırır ve sonuç listesini yeniler.
        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // Demirbaş listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            chkDemirbasAdi.Checked = false;
            chkKategori.Checked = false;
            txtDemirbasAdi.Clear();
            cmbKategori.SelectedIndex = 0;
            KayitListele();
        }

        // Demirbaş Adi hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radDemirbasAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (radDemirbasAdi.Checked == true)
            {
                lblArananAlan.Text = "Demirbaş Adı";
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

        // model hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radModel_CheckedChanged(object sender, EventArgs e)
        {
            if (radModel.Checked == true)
            {
                lblArananAlan.Text = "Model";
                txtHizliAra.Clear();
                txtHizliAra.Focus();
            }
        }

        // sorumlu hızlı arama alanı seçildiğinde arama etiketini günceller, arama kutusunu temizler ve kullanıcıyı yeni kritere odaklar.
        private void radSorumlu_CheckedChanged(object sender, EventArgs e)
        {
            if (radSorumlu.Checked == true)
            {
                lblArananAlan.Text = "Sorumlu";
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