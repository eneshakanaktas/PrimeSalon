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
    public partial class FrmStokHareketleri : Form
    {
        // FrmStokHareketleri formunu başlatır; Windows Form kontrollerini oluşturarak stok hareketi ekranını kullanıma hazırlar.
        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        // Stok hareketi kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtUrunID.BackColor = Color.White;
            cmbIslemTipi.BackColor = Color.White;
            txtMiktar.BackColor = Color.White;
            cmbDepo.BackColor = Color.White;
            txtBirimFiyat.BackColor = Color.White;
            txtToplamTutar.BackColor = Color.White;
            txtOncekiStok.BackColor = Color.White;
            txtSonrakiStok.BackColor = Color.White;
            txtKullanici.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;

            lblYildizIslemTipi.Visible = false;
            lblYildizDepo.Visible = false;

            if (txtUrunID.Text.Trim() == "")
            {
                txtUrunID.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbIslemTipi.Text == "Seçiniz")
            {
                cmbIslemTipi.BackColor = Color.Red;
                lblYildizIslemTipi.Visible = true;
                bosVar = true;
            }

            if (txtMiktar.Text.Trim() == "")
            {
                txtMiktar.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbDepo.Text == "Seçiniz")
            {
                cmbDepo.BackColor = Color.Red;
                lblYildizDepo.Visible = true;
                bosVar = true;
            }

            if (txtBirimFiyat.Text.Trim() == "")
            {
                txtBirimFiyat.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtToplamTutar.Text.Trim() == "")
            {
                txtToplamTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtOncekiStok.Text.Trim() == "")
            {
                txtOncekiStok.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtSonrakiStok.Text.Trim() == "")
            {
                txtSonrakiStok.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtKullanici.Text.Trim() == "")
            {
                txtKullanici.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtUrunID.BackColor == Color.Red) txtUrunID.Focus();
                else if (cmbIslemTipi.BackColor == Color.Red) cmbIslemTipi.Focus();
                else if (txtMiktar.BackColor == Color.Red) txtMiktar.Focus();
                else if (cmbDepo.BackColor == Color.Red) cmbDepo.Focus();
                else if (txtBirimFiyat.BackColor == Color.Red) txtBirimFiyat.Focus();
                else if (txtToplamTutar.BackColor == Color.Red) txtToplamTutar.Focus();
                else if (txtOncekiStok.BackColor == Color.Red) txtOncekiStok.Focus();
                else if (txtSonrakiStok.BackColor == Color.Red) txtSonrakiStok.Focus();
                else if (txtKullanici.BackColor == Color.Red) txtKullanici.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
            }

            return bosVar;
        }

        // Stok hareketi tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvStokHareketleri üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from StokHareketleri";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "StokHareketleri");
                dgvStokHareketleri.DataSource = ds.Tables["StokHareketleri"];
                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Formdaki stok hareketi bilgilerini doğrulayıp stok hareketi tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                int urunID;
                if (!int.TryParse(txtUrunID.Text, out urunID))
                {
                    MessageBox.Show("Ürün ID alanına sayısal değer giriniz.");
                    txtUrunID.Focus();
                    return;
                }

                int miktar;
                if (!int.TryParse(txtMiktar.Text, out miktar))
                {
                    MessageBox.Show("Miktar alanına sayısal değer giriniz.");
                    txtMiktar.Focus();
                    return;
                }

                decimal birimFiyat;
                if (!decimal.TryParse(txtBirimFiyat.Text, out birimFiyat))
                {
                    MessageBox.Show("Birim fiyat alanına sayısal değer giriniz.");
                    txtBirimFiyat.Focus();
                    return;
                }

                decimal toplamTutar;
                if (!decimal.TryParse(txtToplamTutar.Text, out toplamTutar))
                {
                    MessageBox.Show("Toplam tutar alanına sayısal değer giriniz.");
                    txtToplamTutar.Focus();
                    return;
                }

                int oncekiStok;
                if (!int.TryParse(txtOncekiStok.Text, out oncekiStok))
                {
                    MessageBox.Show("Önceki stok alanına sayısal değer giriniz.");
                    txtOncekiStok.Focus();
                    return;
                }

                int sonrakiStok;
                if (!int.TryParse(txtSonrakiStok.Text, out sonrakiStok))
                {
                    MessageBox.Show("Sonraki stok alanına sayısal değer giriniz.");
                    txtSonrakiStok.Focus();
                    return;
                }

                MuhasebeServisi.StokHareketiEkle(
                    FrmPersonel.Baglanti,
                    urunID,
                    dtTarih.Value,
                    cmbIslemTipi.Text,
                    miktar,
                    birimFiyat,
                    toplamTutar,
                    rtbAciklama.Text,
                    txtKullanici.Text,
                    oncekiStok,
                    sonrakiStok,
                    chkAktifMi.Checked,
                    cmbDepo.Text);

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        // Stok hareketi formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.SelectedIndex = 0;
            cmbDepo.SelectedIndex = 0;
            KayitListele();
        }

        // Stok hareketi listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Stok hareketi ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili stok hareketi satırının tüm alanlarını stok hareketi silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvStokHareketleri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmStokHareketleriSil frmSil = new FrmStokHareketleriSil();

            frmSil.txtHareketID.Text = dgvStokHareketleri.CurrentRow.Cells["HareketID"].Value.ToString();
            frmSil.txtUrunID.Text = dgvStokHareketleri.CurrentRow.Cells["UrunID"].Value.ToString();
            frmSil.dtTarih.Value = Convert.ToDateTime(dgvStokHareketleri.CurrentRow.Cells["Tarih"].Value);
            frmSil.cmbIslemTipi.Text = dgvStokHareketleri.CurrentRow.Cells["IslemTipi"].Value.ToString();
            frmSil.txtMiktar.Text = dgvStokHareketleri.CurrentRow.Cells["Miktar"].Value.ToString();
            frmSil.txtBirimFiyat.Text = dgvStokHareketleri.CurrentRow.Cells["BirimFiyat"].Value.ToString();
            frmSil.txtToplamTutar.Text = dgvStokHareketleri.CurrentRow.Cells["ToplamTutar"].Value.ToString();
            frmSil.txtOncekiStok.Text = dgvStokHareketleri.CurrentRow.Cells["OncekiStok"].Value.ToString();
            frmSil.txtSonrakiStok.Text = dgvStokHareketleri.CurrentRow.Cells["SonrakiStok"].Value.ToString();
            frmSil.cmbDepo.Text = dgvStokHareketleri.CurrentRow.Cells["Depo"].Value.ToString();
            frmSil.txtKullanici.Text = dgvStokHareketleri.CurrentRow.Cells["Kullanici"].Value.ToString();
            frmSil.chkAktifMi.Checked = Convert.ToBoolean(dgvStokHareketleri.CurrentRow.Cells["AktifMi"].Value);
            frmSil.rtbAciklama.Text = dgvStokHareketleri.CurrentRow.Cells["Aciklama"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili stok hareketi satırındaki mevcut değerleri stok hareketi güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvStokHareketleri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmStokHareketleriGuncelle frm = new FrmStokHareketleriGuncelle();

            frm.txtHareketID.Text = dgvStokHareketleri.CurrentRow.Cells["HareketID"].Value.ToString();
            frm.txtUrunID.Text = dgvStokHareketleri.CurrentRow.Cells["UrunID"].Value.ToString();
            frm.dtTarih.Value = Convert.ToDateTime(dgvStokHareketleri.CurrentRow.Cells["Tarih"].Value);
            frm.cmbIslemTipi.Text = dgvStokHareketleri.CurrentRow.Cells["IslemTipi"].Value.ToString();
            frm.txtMiktar.Text = dgvStokHareketleri.CurrentRow.Cells["Miktar"].Value.ToString();
            frm.txtBirimFiyat.Text = dgvStokHareketleri.CurrentRow.Cells["BirimFiyat"].Value.ToString();
            frm.txtToplamTutar.Text = dgvStokHareketleri.CurrentRow.Cells["ToplamTutar"].Value.ToString();
            frm.txtOncekiStok.Text = dgvStokHareketleri.CurrentRow.Cells["OncekiStok"].Value.ToString();
            frm.txtSonrakiStok.Text = dgvStokHareketleri.CurrentRow.Cells["SonrakiStok"].Value.ToString();
            frm.cmbDepo.Text = dgvStokHareketleri.CurrentRow.Cells["Depo"].Value.ToString();
            frm.txtKullanici.Text = dgvStokHareketleri.CurrentRow.Cells["Kullanici"].Value.ToString();
            frm.chkAktifMi.Checked = Convert.ToBoolean(dgvStokHareketleri.CurrentRow.Cells["AktifMi"].Value);
            frm.rtbAciklama.Text = dgvStokHareketleri.CurrentRow.Cells["Aciklama"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
        }

        // ıslem Tipi seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIslemTipi.BackColor = Color.White;
            lblYildizIslemTipi.Visible = false;
        }

        // depo seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepo.BackColor = Color.White;
            lblYildizDepo.Visible = false;
        }

        // Stok hareketi kayıtlarını filtrelemek için stok hareketi sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmStokHareketleriSorgulama frm = new FrmStokHareketleriSorgulama();
            frm.ShowDialog();
        }
    }
}
