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
    public partial class FrmKasaHareketleriGuncelle : Form
    {
        // FrmKasaHareketleriGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak kasa hareketi ekranını kullanıma hazırlar.
        public FrmKasaHareketleriGuncelle()
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

        // Formdaki düzenlenmiş kasa hareketi bilgilerini kasa hareketi tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
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

                MuhasebeServisi.KasaHareketiGuncelle(
                    FrmPersonel.Baglanti,
                    Convert.ToInt32(txtKasaHareketID.Text),
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
                    txtIslemiYapan.Text);

                MessageBox.Show(txtKasaHareketID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Kasa hareketi güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
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
    }
}
