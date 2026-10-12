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
    public partial class FrmKasaHareketleri : Form
    {
        // FrmKasaHareketleri formunu başlatır; Windows Form kontrollerini oluşturarak kasa hareketi ekranını kullanıma hazırlar.
        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        // Kasa hareketi kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            cmbIslemTipi.BackColor = Color.White;
            cmbIslemKategorisi.BackColor = Color.White;
            txtTutar.BackColor = Color.White;
            cmbOdemeTipi.BackColor = Color.White;
            txtMusteriID.BackColor = Color.White;
            txtTedarikciID.BackColor = Color.White;
            txtPersonelID.BackColor = Color.White;
            txtKasaAdi.BackColor = Color.White;
            txtBakiyeOnce.BackColor = Color.White;
            txtBakiyeSonra.BackColor = Color.White;
            txtIslemiYapan.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;

            lblYildizIslemTipi.Visible = false;
            lblYildizIslemKategorisi.Visible = false;
            lblYildizOdemeTipi.Visible = false;

            if (cmbIslemTipi.Text == "Seçiniz")
            {
                cmbIslemTipi.BackColor = Color.Red;
                lblYildizIslemTipi.Visible = true;
                bosVar = true;
            }

            if (cmbIslemKategorisi.Text == "Seçiniz")
            {
                cmbIslemKategorisi.BackColor = Color.Red;
                lblYildizIslemKategorisi.Visible = true;
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

            if (txtMusteriID.Text.Trim() == "")
            {
                txtMusteriID.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtTedarikciID.Text.Trim() == "")
            {
                txtTedarikciID.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtPersonelID.Text.Trim() == "")
            {
                txtPersonelID.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtKasaAdi.Text.Trim() == "")
            {
                txtKasaAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtBakiyeOnce.Text.Trim() == "")
            {
                txtBakiyeOnce.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtBakiyeSonra.Text.Trim() == "")
            {
                txtBakiyeSonra.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtIslemiYapan.Text.Trim() == "")
            {
                txtIslemiYapan.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (cmbIslemTipi.BackColor == Color.Red) cmbIslemTipi.Focus();
                else if (cmbIslemKategorisi.BackColor == Color.Red) cmbIslemKategorisi.Focus();
                else if (txtTutar.BackColor == Color.Red) txtTutar.Focus();
                else if (cmbOdemeTipi.BackColor == Color.Red) cmbOdemeTipi.Focus();
                else if (txtMusteriID.BackColor == Color.Red) txtMusteriID.Focus();
                else if (txtTedarikciID.BackColor == Color.Red) txtTedarikciID.Focus();
                else if (txtPersonelID.BackColor == Color.Red) txtPersonelID.Focus();
                else if (txtKasaAdi.BackColor == Color.Red) txtKasaAdi.Focus();
                else if (txtBakiyeOnce.BackColor == Color.Red) txtBakiyeOnce.Focus();
                else if (txtBakiyeSonra.BackColor == Color.Red) txtBakiyeSonra.Focus();
                else if (txtIslemiYapan.BackColor == Color.Red) txtIslemiYapan.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
            }

            return bosVar;
        }

        // Kasa hareketi tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvKasaHareketleri üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from KasaHareketleri";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "KasaHareketleri");
                dgvKasaHareketleri.DataSource = ds.Tables["KasaHareketleri"];
                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Formdaki kasa hareketi bilgilerini doğrulayıp kasa hareketi tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                decimal tutar;
                if (!decimal.TryParse(txtTutar.Text, out tutar))
                {
                    MessageBox.Show("Tutar alanına sayısal değer giriniz.");
                    txtTutar.Focus();
                    return;
                }

                int musteriID;
                if (!int.TryParse(txtMusteriID.Text, out musteriID))
                {
                    MessageBox.Show("Müşteri ID alanına sayısal değer giriniz.");
                    txtMusteriID.Focus();
                    return;
                }

                int tedarikciID;
                if (!int.TryParse(txtTedarikciID.Text, out tedarikciID))
                {
                    MessageBox.Show("Tedarikçi ID alanına sayısal değer giriniz.");
                    txtTedarikciID.Focus();
                    return;
                }

                int personelID;
                if (!int.TryParse(txtPersonelID.Text, out personelID))
                {
                    MessageBox.Show("Personel ID alanına sayısal değer giriniz.");
                    txtPersonelID.Focus();
                    return;
                }

                decimal bakiyeOnce;
                if (!decimal.TryParse(txtBakiyeOnce.Text, out bakiyeOnce))
                {
                    MessageBox.Show("Bakiye önce alanına sayısal değer giriniz.");
                    txtBakiyeOnce.Focus();
                    return;
                }

                decimal bakiyeSonra;
                if (!decimal.TryParse(txtBakiyeSonra.Text, out bakiyeSonra))
                {
                    MessageBox.Show("Bakiye sonra alanına sayısal değer giriniz.");
                    txtBakiyeSonra.Focus();
                    return;
                }

                MuhasebeServisi.KasaHareketiEkle(
                    FrmPersonel.Baglanti,
                    dtTarih.Value,
                    cmbIslemTipi.Text,
                    cmbIslemKategorisi.Text,
                    tutar,
                    cmbOdemeTipi.Text,
                    rtbAciklama.Text,
                    musteriID,
                    tedarikciID,
                    personelID,
                    txtKasaAdi.Text,
                    txtIslemiYapan.Text,
                    null,
                    0);

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        // Kasa hareketi formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.SelectedIndex = 0;
            cmbIslemKategorisi.SelectedIndex = 0;
            cmbOdemeTipi.SelectedIndex = 0;
            KayitListele();
        }

        // Kasa hareketi listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Kasa hareketi ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili kasa hareketi satırının tüm alanlarını kasa hareketi silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvKasaHareketleri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmKasaHareketleriSil frmSil = new FrmKasaHareketleriSil();

            frmSil.txtKasaHareketID.Text = dgvKasaHareketleri.CurrentRow.Cells["KasaHareketID"].Value.ToString();
            frmSil.dtTarih.Value = Convert.ToDateTime(dgvKasaHareketleri.CurrentRow.Cells["Tarih"].Value);
            frmSil.cmbIslemTipi.Text = dgvKasaHareketleri.CurrentRow.Cells["IslemTipi"].Value.ToString();
            frmSil.cmbIslemKategorisi.Text = dgvKasaHareketleri.CurrentRow.Cells["IslemKategorisi"].Value.ToString();
            frmSil.txtTutar.Text = dgvKasaHareketleri.CurrentRow.Cells["Tutar"].Value.ToString();
            frmSil.cmbOdemeTipi.Text = dgvKasaHareketleri.CurrentRow.Cells["OdemeTipi"].Value.ToString();
            frmSil.txtMusteriID.Text = dgvKasaHareketleri.CurrentRow.Cells["MusteriID"].Value.ToString();
            frmSil.txtTedarikciID.Text = dgvKasaHareketleri.CurrentRow.Cells["TedarikciID"].Value.ToString();
            frmSil.txtPersonelID.Text = dgvKasaHareketleri.CurrentRow.Cells["PersonelID"].Value.ToString();
            frmSil.txtKasaAdi.Text = dgvKasaHareketleri.CurrentRow.Cells["KasaAdi"].Value.ToString();
            frmSil.txtBakiyeOnce.Text = dgvKasaHareketleri.CurrentRow.Cells["BakiyeOnce"].Value.ToString();
            frmSil.txtBakiyeSonra.Text = dgvKasaHareketleri.CurrentRow.Cells["BakiyeSonra"].Value.ToString();
            frmSil.txtIslemiYapan.Text = dgvKasaHareketleri.CurrentRow.Cells["IslemiYapan"].Value.ToString();
            frmSil.rtbAciklama.Text = dgvKasaHareketleri.CurrentRow.Cells["Aciklama"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili kasa hareketi satırındaki mevcut değerleri kasa hareketi güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKasaHareketleri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmKasaHareketleriGuncelle frm = new FrmKasaHareketleriGuncelle();

            frm.txtKasaHareketID.Text = dgvKasaHareketleri.CurrentRow.Cells["KasaHareketID"].Value.ToString();
            frm.dtTarih.Value = Convert.ToDateTime(dgvKasaHareketleri.CurrentRow.Cells["Tarih"].Value);
            frm.cmbIslemTipi.Text = dgvKasaHareketleri.CurrentRow.Cells["IslemTipi"].Value.ToString();
            frm.cmbIslemKategorisi.Text = dgvKasaHareketleri.CurrentRow.Cells["IslemKategorisi"].Value.ToString();
            frm.txtTutar.Text = dgvKasaHareketleri.CurrentRow.Cells["Tutar"].Value.ToString();
            frm.cmbOdemeTipi.Text = dgvKasaHareketleri.CurrentRow.Cells["OdemeTipi"].Value.ToString();
            frm.txtMusteriID.Text = dgvKasaHareketleri.CurrentRow.Cells["MusteriID"].Value.ToString();
            frm.txtTedarikciID.Text = dgvKasaHareketleri.CurrentRow.Cells["TedarikciID"].Value.ToString();
            frm.txtPersonelID.Text = dgvKasaHareketleri.CurrentRow.Cells["PersonelID"].Value.ToString();
            frm.txtKasaAdi.Text = dgvKasaHareketleri.CurrentRow.Cells["KasaAdi"].Value.ToString();
            frm.txtBakiyeOnce.Text = dgvKasaHareketleri.CurrentRow.Cells["BakiyeOnce"].Value.ToString();
            frm.txtBakiyeSonra.Text = dgvKasaHareketleri.CurrentRow.Cells["BakiyeSonra"].Value.ToString();
            frm.txtIslemiYapan.Text = dgvKasaHareketleri.CurrentRow.Cells["IslemiYapan"].Value.ToString();
            frm.rtbAciklama.Text = dgvKasaHareketleri.CurrentRow.Cells["Aciklama"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
        }

        // ıslem Tipi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIslemTipi.BackColor = Color.White;
            lblYildizIslemTipi.Visible = false;
        }

        // ıslem Kategorisi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbIslemKategorisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIslemKategorisi.BackColor = Color.White;
            lblYildizIslemKategorisi.Visible = false;
        }

        // odeme Tipi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOdemeTipi.BackColor = Color.White;
            lblYildizOdemeTipi.Visible = false;
        }

        // Kasa hareketi kayıtlarını filtrelemek için kasa hareketi sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleriSorgulama frm = new FrmKasaHareketleriSorgulama();
            frm.ShowDialog();
        }
    }
}
