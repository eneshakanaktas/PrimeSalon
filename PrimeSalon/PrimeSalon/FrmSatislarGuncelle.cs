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
    public partial class FrmSatislarGuncelle : Form
    {
        // FrmSatislarGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak satış ekranını kullanıma hazırlar.
        public FrmSatislarGuncelle()
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

        // Formdaki düzenlenmiş satış bilgilerini satış tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Satislar SET
                Tarih=@Tarih,
                MusteriID=@MusteriID,
                PersonelID=@PersonelID,
                SatisTipi=@SatisTipi,
                AraToplam=@AraToplam,
                IndirimTutar=@IndirimTutar,
                KdvTutar=@KdvTutar,
                GenelToplam=@GenelToplam,
                OdemeTipi=@OdemeTipi,
                OdemeDurumu=@OdemeDurumu,
                Aciklama=@Aciklama,
                IadeMi=@IadeMi,
                IadeNedeni=@IadeNedeni
                WHERE SatisID=@SatisID";

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                int musteriID;
                if (!int.TryParse(txtMusteriID.Text, out musteriID))
                {
                    MessageBox.Show("Müşteri ID alanına sayısal değer giriniz.");
                    txtMusteriID.Focus();
                    return;
                }

                int personelID;
                if (!int.TryParse(txtPersonelID.Text, out personelID))
                {
                    MessageBox.Show("Personel ID alanına sayısal değer giriniz.");
                    txtPersonelID.Focus();
                    return;
                }

                decimal araToplam;
                if (!decimal.TryParse(txtAraToplam.Text, out araToplam))
                {
                    MessageBox.Show("Ara toplam alanına sayısal değer giriniz.");
                    txtAraToplam.Focus();
                    return;
                }

                decimal indirimTutar;
                if (!decimal.TryParse(txtIndirimTutar.Text, out indirimTutar))
                {
                    MessageBox.Show("İndirim tutar alanına sayısal değer giriniz.");
                    txtIndirimTutar.Focus();
                    return;
                }

                decimal kdvTutar;
                if (!decimal.TryParse(txtKdvTutar.Text, out kdvTutar))
                {
                    MessageBox.Show("KDV tutar alanına sayısal değer giriniz.");
                    txtKdvTutar.Focus();
                    return;
                }

                decimal genelToplam;
                if (!decimal.TryParse(txtGenelToplam.Text, out genelToplam))
                {
                    MessageBox.Show("Genel toplam alanına sayısal değer giriniz.");
                    txtGenelToplam.Focus();
                    return;
                }

                komut.Parameters.AddWithValue("@SatisID", txtSatisID.Text);
                komut.Parameters.AddWithValue("@Tarih", dtTarih.Value);
                komut.Parameters.AddWithValue("@MusteriID", musteriID);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@SatisTipi", cmbSatisTipi.Text);
                komut.Parameters.AddWithValue("@AraToplam", araToplam);
                komut.Parameters.AddWithValue("@IndirimTutar", indirimTutar);
                komut.Parameters.AddWithValue("@KdvTutar", kdvTutar);
                komut.Parameters.AddWithValue("@GenelToplam", genelToplam);
                komut.Parameters.AddWithValue("@OdemeTipi", cmbOdemeTipi.Text);
                komut.Parameters.AddWithValue("@OdemeDurumu", cmbOdemeDurumu.Text);
                komut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);
                komut.Parameters.AddWithValue("@IadeMi", chkIadeMi.Checked);
                komut.Parameters.AddWithValue("@IadeNedeni", rtbIadeNedeni.Text);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.SatisKasaHareketiYaz(
                        FrmPersonel.Baglanti,
                        Convert.ToInt32(txtSatisID.Text),
                        dtTarih.Value,
                        cmbSatisTipi.Text,
                        genelToplam,
                        cmbOdemeTipi.Text,
                        cmbOdemeDurumu.Text,
                        chkIadeMi.Checked,
                        rtbAciklama.Text,
                        musteriID,
                        personelID);

                    MessageBox.Show(txtSatisID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Satış güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
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
    }
}
