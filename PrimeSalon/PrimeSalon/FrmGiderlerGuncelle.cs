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
    public partial class FrmGiderlerGuncelle : Form
    {
        // FrmGiderlerGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak gider ekranını kullanıma hazırlar.
        public FrmGiderlerGuncelle()
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

            if (cmbGiderTuru.Text == "Seçiniz")
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

        // Formdaki düzenlenmiş gider bilgilerini gider tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Giderler SET
                Tarih=@Tarih,
                GiderTuru=@GiderTuru,
                Tutar=@Tutar,
                OdemeTipi=@OdemeTipi,
                Firma=@Firma,
                Aciklama=@Aciklama,
                KdvTutar=@KdvTutar,
                KayitTarihi=@KayitTarihi,
                Aktif=@Aktif,
                TekrarlayanMi=@TekrarlayanMi
                WHERE GiderID=@GiderID";

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                komut.Parameters.AddWithValue("@GiderID", txtGiderID.Text);
                komut.Parameters.AddWithValue("@Tarih", dtTarih.Value);
                komut.Parameters.AddWithValue("@GiderTuru", cmbGiderTuru.Text);

                decimal tutar;
                if (!decimal.TryParse(txtTutar.Text, out tutar))
                {
                    MessageBox.Show("Tutar alanına sayısal değer giriniz.");
                    txtTutar.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@Tutar", tutar);

                komut.Parameters.AddWithValue("@OdemeTipi", cmbOdemeTipi.Text);
                komut.Parameters.AddWithValue("@Firma", txtFirma.Text);
                komut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);

                decimal kdvTutar;
                if (!decimal.TryParse(txtKdvTutar.Text, out kdvTutar))
                {
                    MessageBox.Show("KDV tutar alanına sayısal değer giriniz.");
                    txtKdvTutar.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@KdvTutar", kdvTutar);

                komut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                komut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);
                komut.Parameters.AddWithValue("@TekrarlayanMi", chkTekrarlayanMi.Checked);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.GiderKasaHareketiYaz(
                        FrmPersonel.Baglanti,
                        Convert.ToInt32(txtGiderID.Text),
                        dtTarih.Value,
                        cmbGiderTuru.Text,
                        tutar,
                        cmbOdemeTipi.Text,
                        rtbAciklama.Text,
                        chkAktif.Checked);

                    MessageBox.Show(txtGiderID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Gider güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
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
    }
}
