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
    public partial class FrmStokHareketleriGuncelle : Form
    {
        // FrmStokHareketleriGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak stok hareketi ekranını kullanıma hazırlar.
        public FrmStokHareketleriGuncelle()
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

        // Formdaki düzenlenmiş stok hareketi bilgilerini stok hareketi tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
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

                MuhasebeServisi.StokHareketiGuncelle(
                    FrmPersonel.Baglanti,
                    Convert.ToInt32(txtHareketID.Text),
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

                MessageBox.Show(txtHareketID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Stok hareketi güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
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

        // depo seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepo.BackColor = Color.White;
            lblYildizDepo.Visible = false;
        }
    }
}
