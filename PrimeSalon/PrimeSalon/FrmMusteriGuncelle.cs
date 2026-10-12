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
    public partial class FrmMusteriGuncelle : Form
    {
        // FrmMusteriGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak müşteri ekranını kullanıma hazırlar.
        public FrmMusteriGuncelle()
        {
            InitializeComponent();
        }

        // Formdaki düzenlenmiş müşteri bilgilerini seçili ID üzerinden müşteri tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Musteri SET
                Ad=@Ad,
                Soyad=@Soyad,
                Telefon=@Telefon,
                Aktif=@Aktif,
                KayitTarihi=@KayitTarihi,
                TcNo=@TcNo,
                Email=@Email,
                Adres=@Adres,
                Notlar=@Notlar,
                Borc=@Borc,
                SonGelisTarihi=@SonGelisTarihi,
                ToplamHarcama=@ToplamHarcama
                WHERE MusteriID=@MusteriID";

                SqlCommand cmd = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                cmd.Parameters.AddWithValue("@MusteriID", txtMusteriID.Text);
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@Aktif", chkAktif.Checked);
                cmd.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                cmd.Parameters.AddWithValue("@TcNo", mskTcNo.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Adres", rtbAdres.Text);
                cmd.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);

                decimal borc, harcama;

                if (!decimal.TryParse(txtBorc.Text, out borc))
                {
                    MessageBox.Show("Borç alanına sayısal değer giriniz.");
                    txtBorc.Focus();
                    return;
                }

                if (!decimal.TryParse(txtToplamHarcama.Text, out harcama))
                {
                    MessageBox.Show("Toplam harcama alanına sayısal değer giriniz.");
                    txtToplamHarcama.Focus();
                    return;
                }

                cmd.Parameters.AddWithValue("@Borc", borc);
                cmd.Parameters.AddWithValue("@SonGelisTarihi", dtSonGelisTarihi.Value);
                cmd.Parameters.AddWithValue("@ToplamHarcama", harcama);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Güncelle Hata");
            }
        }

        // Müşteri kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            mskTcNo.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            rtbAdres.BackColor = Color.White;
            txtBorc.BackColor = Color.White;
            txtToplamHarcama.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

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

            if (!txtTelefon.MaskCompleted)
            {
                txtTelefon.BackColor = Color.Red;
                bosVar = true;
            }

            if (mskTcNo.Text.Length < 11 || mskTcNo.Text.Contains("_"))
            {
                mskTcNo.BackColor = Color.Red;
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

            if (txtBorc.Text.Trim() == "")
            {
                txtBorc.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtToplamHarcama.Text.Trim() == "")
            {
                txtToplamHarcama.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtAd.BackColor == Color.Red) txtAd.Focus();
                else if (txtSoyad.BackColor == Color.Red) txtSoyad.Focus();
                else if (txtTelefon.BackColor == Color.Red) txtTelefon.Focus();
                else if (mskTcNo.BackColor == Color.Red) mskTcNo.Focus();
                else if (txtEmail.BackColor == Color.Red) txtEmail.Focus();
                else if (rtbAdres.BackColor == Color.Red) rtbAdres.Focus();
                else if (txtBorc.BackColor == Color.Red) txtBorc.Focus();
                else if (txtToplamHarcama.BackColor == Color.Red) txtToplamHarcama.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Müşteri güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
        }
    }
}