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
    public partial class FrmPersonelGuncelle : Form
    {
        // FrmPersonelGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak personel ekranını kullanıma hazırlar.
        public FrmPersonelGuncelle()
        {
            InitializeComponent();
        }

        // 🔥 GÜNCELLE
        // Formdaki düzenlenmiş personel bilgilerini personel tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Personel SET
                Ad=@Ad,
                Soyad=@Soyad,
                TcNo=@TcNo,
                Telefon=@Telefon,
                Pozisyon=@Pozisyon,
                Cinsiyet=@Cinsiyet,
                Email=@Email,
                Adres=@Adres,
                Maas=@Maas,
                IseGirisTarihi=@IseGirisTarihi,
                Aktif=@Aktif
                WHERE PersonelID=@PersonelID";

                SqlCommand cmd = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                int personelID = Convert.ToInt32(txtPersonelID.Text);
                cmd.Parameters.AddWithValue("@PersonelID", personelID);
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@TcNo", mskTcNo.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@Pozisyon", cmbPozisyon.Text);

                if (radE.Checked)
                    cmd.Parameters.AddWithValue("@Cinsiyet", "E");
                else if (radK.Checked)
                    cmd.Parameters.AddWithValue("@Cinsiyet", "K");

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Adres", rtbAdres.Text);

                decimal maas;
                if (!decimal.TryParse(txtMaas.Text, out maas))
                {
                    MessageBox.Show("Maaş alanına sayısal değer giriniz.");
                    txtMaas.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@Maas", maas);

                cmd.Parameters.AddWithValue("@IseGirisTarihi", dtIseGiris.Value);
                cmd.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.PersonelMaasKasaHareketiYaz(
                        FrmPersonel.Baglanti,
                        personelID,
                        dtIseGiris.Value,
                        cmbPozisyon.Text,
                        maas,
                        txtAd.Text.Trim() + " " + txtSoyad.Text.Trim(),
                        chkAktif.Checked);
                    MessageBox.Show("Kayıt Güncellendi");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Güncelle Hata");
            }
        }

        // 🔴 BOSLUK KONTROL
        // Personel kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            mskTcNo.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            cmbPozisyon.BackColor = Color.White;
            txtMaas.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            rtbAdres.BackColor = Color.White;

            lblYildizCinsiyet.Visible = false;
            lblYildizTarih.Visible = false;
            lblYildizPozisyon.Visible = false;

            if (txtAd.Text.Trim() == "")
            {
                txtAd.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtSoyad.Text.Trim() == "")
            {
                txtSoyad.BackColor = Color.Red;
                bosVar = true;
            }

            if (mskTcNo.Text.Length < 11 || mskTcNo.Text.Contains("_"))
            {
                mskTcNo.BackColor = Color.Red;
                bosVar = true;
            }

            if (!txtTelefon.MaskCompleted)
            {
                txtTelefon.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbPozisyon.Text == "Seçiniz")
            {
                cmbPozisyon.BackColor = Color.Red;
                lblYildizPozisyon.Visible = true;
                bosVar = true;
            }

            if (!radE.Checked && !radK.Checked)
            {
                lblYildizCinsiyet.Visible = true;
                bosVar = true;
            }

            if (txtMaas.Text.Trim() == "")
            {
                txtMaas.BackColor = Color.Red;
                bosVar = true;
            }

            if (dtIseGiris.Value.Date == DateTime.Today.Date)
            {
                lblYildizTarih.Visible = true;
                bosVar = true;
            }

            if (txtEmail.Text.Trim() == "")
            {
                txtEmail.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAdres.Text.Trim() == "")
            {
                rtbAdres.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtAd.BackColor == Color.Red) txtAd.Focus();
                else if (txtSoyad.BackColor == Color.Red) txtSoyad.Focus();
                else if (mskTcNo.BackColor == Color.Red) mskTcNo.Focus();
                else if (txtTelefon.BackColor == Color.Red) txtTelefon.Focus();
                else if (cmbPozisyon.BackColor == Color.Red) cmbPozisyon.Focus();
                else if (txtMaas.BackColor == Color.Red) txtMaas.Focus();
                else if (txtEmail.BackColor == Color.Red) txtEmail.Focus();
                else if (rtbAdres.BackColor == Color.Red) rtbAdres.Focus();
            }

            return bosVar;
        }

        // Personel güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
        }
    }
}
