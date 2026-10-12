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
    public partial class FrmRandevuGuncelle : Form
    {
        // FrmRandevuGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak randevu ekranını kullanıma hazırlar.
        public FrmRandevuGuncelle()
        {
            InitializeComponent();
        }

        // Randevu kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtMusteriID.BackColor = Color.White;
            txtPersonelID.BackColor = Color.White;
            txtSureDakika.BackColor = Color.White;
            txtIndirimMiktar.BackColor = Color.White;
            txtToplamTutar.BackColor = Color.White;
            cmbOdemeDurumu.BackColor = Color.White;
            cmbDurum.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

            lblYildizOdemeDurumu.Visible = false;
            lblYildizDurum.Visible = false;

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

            if (txtSureDakika.Text.Trim() == "")
            {
                txtSureDakika.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtIndirimMiktar.Text.Trim() == "")
            {
                txtIndirimMiktar.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtToplamTutar.Text.Trim() == "")
            {
                txtToplamTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbOdemeDurumu.Text == "Seçiniz")
            {
                cmbOdemeDurumu.BackColor = Color.Red;
                lblYildizOdemeDurumu.Visible = true;
                bosVar = true;
            }

            if (cmbDurum.Text == "Seçiniz")
            {
                cmbDurum.BackColor = Color.Red;
                lblYildizDurum.Visible = true;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtMusteriID.BackColor == Color.Red) txtMusteriID.Focus();
                else if (txtPersonelID.BackColor == Color.Red) txtPersonelID.Focus();
                else if (txtSureDakika.BackColor == Color.Red) txtSureDakika.Focus();
                else if (txtIndirimMiktar.BackColor == Color.Red) txtIndirimMiktar.Focus();
                else if (txtToplamTutar.BackColor == Color.Red) txtToplamTutar.Focus();
                else if (cmbOdemeDurumu.BackColor == Color.Red) cmbOdemeDurumu.Focus();
                else if (cmbDurum.BackColor == Color.Red) cmbDurum.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Formdaki düzenlenmiş randevu bilgilerini randevu tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Randevu SET
                MusteriID=@MusteriID,
                PersonelID=@PersonelID,
                RandevuTarih=@RandevuTarih,
                RandevuSaat=@RandevuSaat,
                SureDakika=@SureDakika,
                Durum=@Durum,
                OlusturmaTarihi=@OlusturmaTarihi,
                IndirimMiktar=@IndirimMiktar,
                ToplamTutar=@ToplamTutar,
                OdemeDurumu=@OdemeDurumu,
                Notlar=@Notlar
                WHERE RandevuID=@RandevuID";

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

                int sureDakika;
                if (!int.TryParse(txtSureDakika.Text, out sureDakika))
                {
                    MessageBox.Show("Süre alanına sayısal değer giriniz.");
                    txtSureDakika.Focus();
                    return;
                }

                decimal indirimMiktar;
                if (!decimal.TryParse(txtIndirimMiktar.Text, out indirimMiktar))
                {
                    MessageBox.Show("İndirim alanına sayısal değer giriniz.");
                    txtIndirimMiktar.Focus();
                    return;
                }

                decimal toplamTutar;
                if (!decimal.TryParse(txtToplamTutar.Text, out toplamTutar))
                {
                    MessageBox.Show("Toplam tutar alanına sayısal değer giriniz.");
                    txtToplamTutar.Focus();
                    return;
                }

                int randevuID = Convert.ToInt32(txtRandevuID.Text);
                komut.Parameters.AddWithValue("@RandevuID", randevuID);
                komut.Parameters.AddWithValue("@MusteriID", musteriID);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@RandevuTarih", dtRandevuTarih.Value.Date);
                komut.Parameters.AddWithValue("@RandevuSaat", dtRandevuSaat.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@SureDakika", sureDakika);
                komut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                komut.Parameters.AddWithValue("@OlusturmaTarihi", dtOlusturmaTarihi.Value);
                komut.Parameters.AddWithValue("@IndirimMiktar", indirimMiktar);
                komut.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                komut.Parameters.AddWithValue("@OdemeDurumu", cmbOdemeDurumu.Text);
                komut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.RandevuKasaHareketiYaz(
                        FrmPersonel.Baglanti,
                        randevuID,
                        dtRandevuTarih.Value.Date,
                        cmbDurum.Text,
                        toplamTutar,
                        cmbOdemeDurumu.Text,
                        rtbNotlar.Text,
                        musteriID,
                        personelID);
                    MessageBox.Show(txtRandevuID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Randevu güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
        }

        // odeme Durumu seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbOdemeDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOdemeDurumu.BackColor = Color.White;
            lblYildizOdemeDurumu.Visible = false;
        }

        // Durum seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDurum.BackColor = Color.White;
            lblYildizDurum.Visible = false;
        }
    }
}
