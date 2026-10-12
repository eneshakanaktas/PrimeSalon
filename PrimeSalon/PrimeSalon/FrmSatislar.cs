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
    public partial class FrmSatislar : Form
    {
        // FrmSatislar formunu başlatır; Windows Form kontrollerini oluşturarak satış ekranını kullanıma hazırlar.
        public FrmSatislar()
        {
            InitializeComponent();
        }

        // Satış kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtMusteriID.BackColor = Color.White;
            txtPersonelID.BackColor = Color.White;
            cmbSatisTipi.BackColor = Color.White;
            txtAraToplam.BackColor = Color.White;
            txtIndirimTutar.BackColor = Color.White;
            txtKdvTutar.BackColor = Color.White;
            txtGenelToplam.BackColor = Color.White;
            cmbOdemeTipi.BackColor = Color.White;
            cmbOdemeDurumu.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;

            lblYildizSatisTipi.Visible = false;
            lblYildizOdemeTipi.Visible = false;
            lblYildizOdemeDurumu.Visible = false;

            if (txtMusteriID.Text.Trim() == "")
            {
                txtMusteriID.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtPersonelID.Text.Trim() == "")
            {
                txtPersonelID.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbSatisTipi.Text == "Seçiniz")
            {
                cmbSatisTipi.BackColor = Color.Red;
                lblYildizSatisTipi.Visible = true;
                bosVar = true;
            }

            if (txtAraToplam.Text.Trim() == "")
            {
                txtAraToplam.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtIndirimTutar.Text.Trim() == "")
            {
                txtIndirimTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtKdvTutar.Text.Trim() == "")
            {
                txtKdvTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtGenelToplam.Text.Trim() == "")
            {
                txtGenelToplam.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbOdemeTipi.Text == "Seçiniz")
            {
                cmbOdemeTipi.BackColor = Color.Red;
                lblYildizOdemeTipi.Visible = true;
                bosVar = true;
            }

            if (cmbOdemeDurumu.Text == "Seçiniz")
            {
                cmbOdemeDurumu.BackColor = Color.Red;
                lblYildizOdemeDurumu.Visible = true;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtMusteriID.BackColor == Color.Red) txtMusteriID.Focus();
                else if (txtPersonelID.BackColor == Color.Red) txtPersonelID.Focus();
                else if (cmbSatisTipi.BackColor == Color.Red) cmbSatisTipi.Focus();
                else if (txtAraToplam.BackColor == Color.Red) txtAraToplam.Focus();
                else if (txtIndirimTutar.BackColor == Color.Red) txtIndirimTutar.Focus();
                else if (txtKdvTutar.BackColor == Color.Red) txtKdvTutar.Focus();
                else if (txtGenelToplam.BackColor == Color.Red) txtGenelToplam.Focus();
                else if (cmbOdemeTipi.BackColor == Color.Red) cmbOdemeTipi.Focus();
                else if (cmbOdemeDurumu.BackColor == Color.Red) cmbOdemeDurumu.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
            }

            return bosVar;
        }

        // Satış tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvSatislar üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Satislar";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Satislar");
                dgvSatislar.DataSource = ds.Tables["Satislar"];
                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Formdaki satış bilgilerini doğrulayıp satış tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"Insert Into Satislar
        (Tarih, MusteriID, PersonelID, SatisTipi, AraToplam, IndirimTutar, KdvTutar, GenelToplam, OdemeTipi, OdemeDurumu, Aciklama, IadeMi, IadeNedeni)
        OUTPUT INSERTED.SatisID
        Values
        (@Tarih, @MusteriID, @PersonelID, @SatisTipi, @AraToplam, @IndirimTutar, @KdvTutar, @GenelToplam, @OdemeTipi, @OdemeDurumu, @Aciklama, @IadeMi, @IadeNedeni)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@Tarih", dtTarih.Value);

                int musteriID;
                if (!int.TryParse(txtMusteriID.Text, out musteriID))
                {
                    MessageBox.Show("Müşteri ID alanına sayısal değer giriniz.");
                    txtMusteriID.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@MusteriID", musteriID);

                int personelID;
                if (!int.TryParse(txtPersonelID.Text, out personelID))
                {
                    MessageBox.Show("Personel ID alanına sayısal değer giriniz.");
                    txtPersonelID.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@PersonelID", personelID);

                EkleKomut.Parameters.AddWithValue("@SatisTipi", cmbSatisTipi.Text);

                decimal araToplam;
                if (!decimal.TryParse(txtAraToplam.Text, out araToplam))
                {
                    MessageBox.Show("Ara toplam alanına sayısal değer giriniz.");
                    txtAraToplam.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@AraToplam", araToplam);

                decimal indirimTutar;
                if (!decimal.TryParse(txtIndirimTutar.Text, out indirimTutar))
                {
                    MessageBox.Show("İndirim tutar alanına sayısal değer giriniz.");
                    txtIndirimTutar.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@IndirimTutar", indirimTutar);

                decimal kdvTutar;
                if (!decimal.TryParse(txtKdvTutar.Text, out kdvTutar))
                {
                    MessageBox.Show("KDV tutar alanına sayısal değer giriniz.");
                    txtKdvTutar.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@KdvTutar", kdvTutar);

                decimal genelToplam;
                if (!decimal.TryParse(txtGenelToplam.Text, out genelToplam))
                {
                    MessageBox.Show("Genel toplam alanına sayısal değer giriniz.");
                    txtGenelToplam.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@GenelToplam", genelToplam);

                EkleKomut.Parameters.AddWithValue("@OdemeTipi", cmbOdemeTipi.Text);
                EkleKomut.Parameters.AddWithValue("@OdemeDurumu", cmbOdemeDurumu.Text);
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);
                EkleKomut.Parameters.AddWithValue("@IadeMi", chkIadeMi.Checked);
                EkleKomut.Parameters.AddWithValue("@IadeNedeni", rtbIadeNedeni.Text);

                int satisID = Convert.ToInt32(EkleKomut.ExecuteScalar());

                MuhasebeServisi.SatisKasaHareketiYaz(
                    FrmPersonel.Baglanti,
                    satisID,
                    dtTarih.Value,
                    cmbSatisTipi.Text,
                    genelToplam,
                    cmbOdemeTipi.Text,
                    cmbOdemeDurumu.Text,
                    chkIadeMi.Checked,
                    rtbAciklama.Text,
                    musteriID,
                    personelID);

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        // Satış formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            cmbSatisTipi.SelectedIndex = 0;
            cmbOdemeTipi.SelectedIndex = 0;
            cmbOdemeDurumu.SelectedIndex = 0;
            KayitListele();
        }

        // Satış listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Satış ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili satış satırının tüm alanlarını satış silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvSatislar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmSatislarSil frmSil = new FrmSatislarSil();

            frmSil.txtSatisID.Text = dgvSatislar.CurrentRow.Cells["SatisID"].Value.ToString();
            frmSil.dtTarih.Value = Convert.ToDateTime(dgvSatislar.CurrentRow.Cells["Tarih"].Value);
            frmSil.txtMusteriID.Text = dgvSatislar.CurrentRow.Cells["MusteriID"].Value.ToString();
            frmSil.txtPersonelID.Text = dgvSatislar.CurrentRow.Cells["PersonelID"].Value.ToString();
            frmSil.cmbSatisTipi.Text = dgvSatislar.CurrentRow.Cells["SatisTipi"].Value.ToString();
            frmSil.txtAraToplam.Text = dgvSatislar.CurrentRow.Cells["AraToplam"].Value.ToString();
            frmSil.txtIndirimTutar.Text = dgvSatislar.CurrentRow.Cells["IndirimTutar"].Value.ToString();
            frmSil.txtKdvTutar.Text = dgvSatislar.CurrentRow.Cells["KdvTutar"].Value.ToString();
            frmSil.txtGenelToplam.Text = dgvSatislar.CurrentRow.Cells["GenelToplam"].Value.ToString();
            frmSil.cmbOdemeTipi.Text = dgvSatislar.CurrentRow.Cells["OdemeTipi"].Value.ToString();
            frmSil.cmbOdemeDurumu.Text = dgvSatislar.CurrentRow.Cells["OdemeDurumu"].Value.ToString();
            frmSil.chkIadeMi.Checked = Convert.ToBoolean(dgvSatislar.CurrentRow.Cells["IadeMi"].Value);
            frmSil.rtbAciklama.Text = dgvSatislar.CurrentRow.Cells["Aciklama"].Value.ToString();
            frmSil.rtbIadeNedeni.Text = dgvSatislar.CurrentRow.Cells["IadeNedeni"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili satış satırındaki mevcut değerleri satış güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvSatislar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmSatislarGuncelle frm = new FrmSatislarGuncelle();

            frm.txtSatisID.Text = dgvSatislar.CurrentRow.Cells["SatisID"].Value.ToString();
            frm.dtTarih.Value = Convert.ToDateTime(dgvSatislar.CurrentRow.Cells["Tarih"].Value);
            frm.txtMusteriID.Text = dgvSatislar.CurrentRow.Cells["MusteriID"].Value.ToString();
            frm.txtPersonelID.Text = dgvSatislar.CurrentRow.Cells["PersonelID"].Value.ToString();
            frm.cmbSatisTipi.Text = dgvSatislar.CurrentRow.Cells["SatisTipi"].Value.ToString();
            frm.txtAraToplam.Text = dgvSatislar.CurrentRow.Cells["AraToplam"].Value.ToString();
            frm.txtIndirimTutar.Text = dgvSatislar.CurrentRow.Cells["IndirimTutar"].Value.ToString();
            frm.txtKdvTutar.Text = dgvSatislar.CurrentRow.Cells["KdvTutar"].Value.ToString();
            frm.txtGenelToplam.Text = dgvSatislar.CurrentRow.Cells["GenelToplam"].Value.ToString();
            frm.cmbOdemeTipi.Text = dgvSatislar.CurrentRow.Cells["OdemeTipi"].Value.ToString();
            frm.cmbOdemeDurumu.Text = dgvSatislar.CurrentRow.Cells["OdemeDurumu"].Value.ToString();
            frm.chkIadeMi.Checked = Convert.ToBoolean(dgvSatislar.CurrentRow.Cells["IadeMi"].Value);
            frm.rtbAciklama.Text = dgvSatislar.CurrentRow.Cells["Aciklama"].Value.ToString();
            frm.rtbIadeNedeni.Text = dgvSatislar.CurrentRow.Cells["IadeNedeni"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
        }

        // Satış Tipi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbSatisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSatisTipi.BackColor = Color.White;
            lblYildizSatisTipi.Visible = false;
        }

        // odeme Tipi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOdemeTipi.BackColor = Color.White;
            lblYildizOdemeTipi.Visible = false;
        }

        // odeme Durumu seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbOdemeDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOdemeDurumu.BackColor = Color.White;
            lblYildizOdemeDurumu.Visible = false;
        }

        // Satış kayıtlarını filtrelemek için satış sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmSatislarSorgulama frm = new FrmSatislarSorgulama();
            frm.ShowDialog();
        }
    }
}
