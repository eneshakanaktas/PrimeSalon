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
    public partial class FrmTedarikcilerGuncelle : Form
    {
        // FrmTedarikcilerGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak tedarikçi ekranını kullanıma hazırlar.
        public FrmTedarikcilerGuncelle()
        {
            InitializeComponent();
        }

        // Tedarikçi kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtFirmaAdi.BackColor = Color.White;
            txtYetkiliAdSoyad.BackColor = Color.White;
            mskTelefon.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            cmbSehir.BackColor = Color.White;
            txtIBAN.BackColor = Color.White;
            txtBanka.BackColor = Color.White;
            rtbAdres.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

            lblYildizSehir.Visible = false;

            if (txtFirmaAdi.Text.Trim() == "")
            {
                txtFirmaAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtYetkiliAdSoyad.Text.Trim() == "")
            {
                txtYetkiliAdSoyad.BackColor = Color.Red;
                bosVar = true;
            }

            if (!mskTelefon.MaskCompleted)
            {
                mskTelefon.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtEmail.Text.Trim() == "")
            {
                txtEmail.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbSehir.Text == "Seçiniz")
            {
                cmbSehir.BackColor = Color.Red;
                lblYildizSehir.Visible = true;
                bosVar = true;
            }

            if (txtIBAN.Text.Trim() == "")
            {
                txtIBAN.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtBanka.Text.Trim() == "")
            {
                txtBanka.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAdres.Text.Trim() == "")
            {
                rtbAdres.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtFirmaAdi.BackColor == Color.Red) txtFirmaAdi.Focus();
                else if (txtYetkiliAdSoyad.BackColor == Color.Red) txtYetkiliAdSoyad.Focus();
                else if (mskTelefon.BackColor == Color.Red) mskTelefon.Focus();
                else if (txtEmail.BackColor == Color.Red) txtEmail.Focus();
                else if (cmbSehir.BackColor == Color.Red) cmbSehir.Focus();
                else if (txtIBAN.BackColor == Color.Red) txtIBAN.Focus();
                else if (txtBanka.BackColor == Color.Red) txtBanka.Focus();
                else if (rtbAdres.BackColor == Color.Red) rtbAdres.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Formdaki düzenlenmiş tedarikçi bilgilerini seçili ID üzerinden tedarikçi tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Tedarikciler SET
                FirmaAdi=@FirmaAdi,
                YetkiliAdSoyad=@YetkiliAdSoyad,
                Telefon=@Telefon,
                Email=@Email,
                Sehir=@Sehir,
                Adres=@Adres,
                IBAN=@IBAN,
                Banka=@Banka,
                Notlar=@Notlar,
                KayitTarihi=@KayitTarihi,
                Aktif=@Aktif
                WHERE TedarikçiID=@TedarikçiID";

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                komut.Parameters.AddWithValue("@TedarikçiID", txtTedarikciID.Text);
                komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                komut.Parameters.AddWithValue("@YetkiliAdSoyad", txtYetkiliAdSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", mskTelefon.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.Parameters.AddWithValue("@Sehir", cmbSehir.Text);
                komut.Parameters.AddWithValue("@Adres", rtbAdres.Text);
                komut.Parameters.AddWithValue("@IBAN", txtIBAN.Text);
                komut.Parameters.AddWithValue("@Banka", txtBanka.Text);
                komut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);
                komut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                komut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtTedarikciID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Tedarikçi güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
        }

        // sehir seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSehir.BackColor = Color.White;
            lblYildizSehir.Visible = false;
        }
    }
}