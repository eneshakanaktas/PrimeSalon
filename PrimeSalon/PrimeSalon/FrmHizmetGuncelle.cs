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
    public partial class FrmHizmetGuncelle : Form
    {
        // FrmHizmetGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak hizmet ekranını kullanıma hazırlar.
        public FrmHizmetGuncelle()
        {
            InitializeComponent();
        }

        // Hizmet kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtHizmetAdi.BackColor = Color.White;
            cmbKategori.BackColor = Color.White;
            txtUcret.BackColor = Color.White;
            txtSureDakika.BackColor = Color.White;

            lblYildizKategori.Visible = false;

            if (txtHizmetAdi.Text.Trim() == "")
            {
                txtHizmetAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbKategori.Text == "Seçiniz")
            {
                cmbKategori.BackColor = Color.Red;
                lblYildizKategori.Visible = true;
                bosVar = true;
            }

            if (txtUcret.Text.Trim() == "")
            {
                txtUcret.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtSureDakika.Text.Trim() == "")
            {
                txtSureDakika.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtHizmetAdi.BackColor == Color.Red) txtHizmetAdi.Focus();
                else if (cmbKategori.BackColor == Color.Red) cmbKategori.Focus();
                else if (txtUcret.BackColor == Color.Red) txtUcret.Focus();
                else if (txtSureDakika.BackColor == Color.Red) txtSureDakika.Focus();
            }

            return bosVar;
        }

        // Formdaki düzenlenmiş hizmet bilgilerini hizmet tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Hizmet SET
            HizmetAdi=@HizmetAdi,
            Kategori=@Kategori,
            Ucret=@Ucret,
            SureDakika=@SureDakika,
            Aciklama=@Aciklama
            WHERE HizmetID=@HizmetID";

                int hizmetID = Convert.ToInt32(txtHizmetID.Text);
                bool aktif = HizmetAktifMi(hizmetID);

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                komut.Parameters.AddWithValue("@HizmetAdi", txtHizmetAdi.Text);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);

                decimal fiyat;
                if (!decimal.TryParse(txtUcret.Text, out fiyat))
                {
                    MessageBox.Show("Fiyat sayısal olmalı");
                    txtUcret.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@Ucret", fiyat);

                int sure;
                if (!int.TryParse(txtSureDakika.Text, out sure))
                {
                    MessageBox.Show("Süre sayısal olmalı");
                    txtSureDakika.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@SureDakika", sure);

                komut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);
                komut.Parameters.AddWithValue("@HizmetID", hizmetID);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.HizmetKasaHareketiYaz(
                        FrmPersonel.Baglanti,
                        hizmetID,
                        DateTime.Now,
                        cmbKategori.Text,
                        fiyat,
                        txtHizmetAdi.Text.Trim(),
                        aktif);
                    MessageBox.Show("Kayıt Güncellendi");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        // Hizmet güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
        }

        // Verilen HizmetID için Hizmet tablosundaki Aktif değerini okur ve hizmetin kullanılır durumda olup olmadığını döndürür.
        private bool HizmetAktifMi(int hizmetID)
        {
            using (SqlCommand komut = new SqlCommand("SELECT Aktif FROM Hizmet WHERE HizmetID=@HizmetID", FrmPersonel.Baglanti))
            {
                komut.Parameters.AddWithValue("@HizmetID", hizmetID);
                object sonuc = komut.ExecuteScalar();
                return sonuc != null && sonuc != DBNull.Value && Convert.ToBoolean(sonuc);
            }
        }

        // Kategori seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKategori.BackColor = Color.White;
            lblYildizKategori.Visible = false;
        }
    }
}
