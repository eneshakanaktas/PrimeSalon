using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public partial class FrmGiderler : Form
    {
        // FrmGiderler formunu başlatır; Windows Form kontrollerini oluşturarak gider ekranını kullanıma hazırlar.
        public FrmGiderler()
        {
            InitializeComponent();
        }

        // Gider kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            cmbGiderTuru.BackColor = Color.White;
            txtTutar.BackColor = Color.White;
            cmbOdemeTipi.BackColor = Color.White;
            txtFirma.BackColor = Color.White;
            txtKdvTutar.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;

            lblYildizGiderTuru.Visible = false;
            lblYildizOdemeTipi.Visible = false;

            if (cmbGiderTuru.SelectedIndex == 0 || cmbGiderTuru.Text == "Seçiniz")
            {
                cmbGiderTuru.BackColor = Color.Red;
                lblYildizGiderTuru.Visible = true;
                bosVar = true;
            }

            if (txtTutar.Text.Trim() == "")
            {
                txtTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbOdemeTipi.Text == "Seçiniz")
            {
                cmbOdemeTipi.BackColor = Color.Red;
                lblYildizOdemeTipi.Visible = true;
                bosVar = true;
            }

            if (txtFirma.Text.Trim() == "")
            {
                txtFirma.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtKdvTutar.Text.Trim() == "")
            {
                txtKdvTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (cmbGiderTuru.BackColor == Color.Red) cmbGiderTuru.Focus();
                else if (txtTutar.BackColor == Color.Red) txtTutar.Focus();
                else if (cmbOdemeTipi.BackColor == Color.Red) cmbOdemeTipi.Focus();
                else if (txtFirma.BackColor == Color.Red) txtFirma.Focus();
                else if (txtKdvTutar.BackColor == Color.Red) txtKdvTutar.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
            }

            return bosVar;
        }

        // Gider tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvGiderler üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM Giderler ORDER BY KayitTarihi DESC, GiderID DESC";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(ds, "Giderler");
                dgvGiderler.DataSource = ds.Tables["Giderler"];
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Gider türü tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void GiderTuruListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, GiderTuru FROM GiderlerGiderTuruTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["GiderTuru"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                cmbGiderTuru.DataSource = dt;
                cmbGiderTuru.DisplayMember = "GiderTuru";
                cmbGiderTuru.ValueMember = "ID";
                cmbGiderTuru.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Gider Türü Listeleme Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Formdaki gider bilgilerini doğrulayıp gider tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO Giderler
                (Tarih, GiderTuru, Tutar, OdemeTipi, Firma, Aciklama, KdvTutar, KayitTarihi, Aktif, TekrarlayanMi)
                OUTPUT INSERTED.GiderID
                VALUES
                (@Tarih, @GiderTuru, @Tutar, @OdemeTipi, @Firma, @Aciklama, @KdvTutar, @KayitTarihi, @Aktif, @TekrarlayanMi)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@Tarih", dtTarih.Value);
                EkleKomut.Parameters.AddWithValue("@GiderTuru", cmbGiderTuru.Text);

                decimal tutar;
                if (!decimal.TryParse(txtTutar.Text, out tutar))
                {
                    MessageBox.Show("Tutar alanına sayısal değer giriniz.");
                    txtTutar.Focus();
                    return;
                }

                decimal kdvTutar;
                if (!decimal.TryParse(txtKdvTutar.Text, out kdvTutar))
                {
                    MessageBox.Show("KDV tutar alanına sayısal değer giriniz.");
                    txtKdvTutar.Focus();
                    return;
                }

                EkleKomut.Parameters.AddWithValue("@Tutar", tutar);
                EkleKomut.Parameters.AddWithValue("@OdemeTipi", cmbOdemeTipi.Text);
                EkleKomut.Parameters.AddWithValue("@Firma", txtFirma.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@KdvTutar", kdvTutar);
                EkleKomut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);
                EkleKomut.Parameters.AddWithValue("@TekrarlayanMi", chkTekrarlayanMi.Checked);

                int giderID = Convert.ToInt32(EkleKomut.ExecuteScalar());

                MuhasebeServisi.GiderKasaHareketiYaz(
                    FrmPersonel.Baglanti,
                    giderID,
                    dtTarih.Value,
                    cmbGiderTuru.Text,
                    tutar,
                    cmbOdemeTipi.Text,
                    rtbAciklama.Text.Trim(),
                    chkAktif.Checked);

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Gider formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            chkAktif.Checked = true;
            GiderTuruListele();
            cmbOdemeTipi.SelectedIndex = 0;
            KayitListele();
        }

        // Gider listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Gider ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
        private void tsbEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
            {
                KayitEkle();
                KayitListele();
            }
        }

        // Seçili gider satırının tüm alanlarını gider silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvGiderler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmGiderlerSil frmSil = new FrmGiderlerSil();

            frmSil.txtGiderID.Text = dgvGiderler.CurrentRow.Cells["GiderID"].Value.ToString();
            frmSil.dtTarih.Value = Convert.ToDateTime(dgvGiderler.CurrentRow.Cells["Tarih"].Value);
            frmSil.cmbGiderTuru.Text = dgvGiderler.CurrentRow.Cells["GiderTuru"].Value.ToString();
            frmSil.txtTutar.Text = dgvGiderler.CurrentRow.Cells["Tutar"].Value.ToString();
            frmSil.cmbOdemeTipi.Text = dgvGiderler.CurrentRow.Cells["OdemeTipi"].Value.ToString();
            frmSil.txtFirma.Text = dgvGiderler.CurrentRow.Cells["Firma"].Value.ToString();
            frmSil.txtKdvTutar.Text = dgvGiderler.CurrentRow.Cells["KdvTutar"].Value.ToString();
            frmSil.dtKayitTarihi.Value = Convert.ToDateTime(dgvGiderler.CurrentRow.Cells["KayitTarihi"].Value);
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvGiderler.CurrentRow.Cells["Aktif"].Value);
            frmSil.chkTekrarlayanMi.Checked = Convert.ToBoolean(dgvGiderler.CurrentRow.Cells["TekrarlayanMi"].Value);
            frmSil.rtbAciklama.Text = dgvGiderler.CurrentRow.Cells["Aciklama"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili gider satırındaki mevcut değerleri gider güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvGiderler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmGiderlerGuncelle frm = new FrmGiderlerGuncelle();

            frm.txtGiderID.Text = dgvGiderler.CurrentRow.Cells["GiderID"].Value.ToString();
            frm.dtTarih.Value = Convert.ToDateTime(dgvGiderler.CurrentRow.Cells["Tarih"].Value);
            frm.cmbGiderTuru.Text = dgvGiderler.CurrentRow.Cells["GiderTuru"].Value.ToString();
            frm.txtTutar.Text = dgvGiderler.CurrentRow.Cells["Tutar"].Value.ToString();
            frm.cmbOdemeTipi.Text = dgvGiderler.CurrentRow.Cells["OdemeTipi"].Value.ToString();
            frm.txtFirma.Text = dgvGiderler.CurrentRow.Cells["Firma"].Value.ToString();
            frm.txtKdvTutar.Text = dgvGiderler.CurrentRow.Cells["KdvTutar"].Value.ToString();
            frm.dtKayitTarihi.Value = Convert.ToDateTime(dgvGiderler.CurrentRow.Cells["KayitTarihi"].Value);
            frm.chkAktif.Checked = Convert.ToBoolean(dgvGiderler.CurrentRow.Cells["Aktif"].Value);
            frm.chkTekrarlayanMi.Checked = Convert.ToBoolean(dgvGiderler.CurrentRow.Cells["TekrarlayanMi"].Value);
            frm.rtbAciklama.Text = dgvGiderler.CurrentRow.Cells["Aciklama"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
        }

        // Gider Turu seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbGiderTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGiderTuru.BackColor = Color.White;
            lblYildizGiderTuru.Visible = false;
        }

        // odeme Tipi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOdemeTipi.BackColor = Color.White;
            lblYildizOdemeTipi.Visible = false;
        }

        // Gider kayıtlarını filtrelemek için gider sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmGiderlerSorgulama frm = new FrmGiderlerSorgulama();
            frm.ShowDialog();
        }

        // Gider için kullanılan tanım değerlerini yönetmek üzere gider gider türü tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmGiderlerGiderTuruTanimlama frm = new FrmGiderlerGiderTuruTanimlama();
            frm.ShowDialog();

            GiderTuruListele();
        }
    }
}
