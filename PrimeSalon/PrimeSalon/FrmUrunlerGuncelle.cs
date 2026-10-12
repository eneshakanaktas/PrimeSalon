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
    public partial class FrmUrunlerGuncelle : Form
    {
        // FrmUrunlerGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak ürün ekranını kullanıma hazırlar.
        public FrmUrunlerGuncelle()
        {
            InitializeComponent();
        }

        // Ürün kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtUrunAdi.BackColor = Color.White;
            txtMarka.BackColor = Color.White;
            cmbKategori.BackColor = Color.White;
            cmbBirim.BackColor = Color.White;
            txtAlisFiyat.BackColor = Color.White;
            txtSatisFiyat.BackColor = Color.White;
            txtMinimumStok.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;

            lblYildizKategori.Visible = false;
            lblYildizBirim.Visible = false;

            if (txtUrunAdi.Text.Trim() == "")
            {
                txtUrunAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtMarka.Text.Trim() == "")
            {
                txtMarka.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbKategori.Text == "Seçiniz")
            {
                cmbKategori.BackColor = Color.Red;
                lblYildizKategori.Visible = true;
                bosVar = true;
            }

            if (cmbBirim.Text == "Seçiniz")
            {
                cmbBirim.BackColor = Color.Red;
                lblYildizBirim.Visible = true;
                bosVar = true;
            }

            if (txtAlisFiyat.Text.Trim() == "")
            {
                txtAlisFiyat.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtSatisFiyat.Text.Trim() == "")
            {
                txtSatisFiyat.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtMinimumStok.Text.Trim() == "")
            {
                txtMinimumStok.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtUrunAdi.BackColor == Color.Red) txtUrunAdi.Focus();
                else if (txtMarka.BackColor == Color.Red) txtMarka.Focus();
                else if (cmbKategori.BackColor == Color.Red) cmbKategori.Focus();
                else if (cmbBirim.BackColor == Color.Red) cmbBirim.Focus();
                else if (txtAlisFiyat.BackColor == Color.Red) txtAlisFiyat.Focus();
                else if (txtSatisFiyat.BackColor == Color.Red) txtSatisFiyat.Focus();
                else if (txtMinimumStok.BackColor == Color.Red) txtMinimumStok.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
            }

            return bosVar;
        }

        // Formdaki düzenlenmiş ürün bilgilerini seçili ID üzerinden ürün tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Urunler SET
                UrunAdi=@UrunAdi,
                Marka=@Marka,
                Kategori=@Kategori,
                Birim=@Birim,
                AlisFiyat=@AlisFiyat,
                SatisFiyat=@SatisFiyat,
                StokTakip=@StokTakip,
                MinimumStok=@MinimumStok,
                Aktif=@Aktif,
                Aciklama=@Aciklama,
                EklenmeTarihi=@EklenmeTarihi
                WHERE UrunID=@UrunID";

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                komut.Parameters.AddWithValue("@UrunID", txtUrunID.Text);
                komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@Birim", cmbBirim.Text);

                decimal alisFiyat;
                if (!decimal.TryParse(txtAlisFiyat.Text, out alisFiyat))
                {
                    MessageBox.Show("Alış fiyat alanına sayısal değer giriniz.");
                    txtAlisFiyat.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@AlisFiyat", alisFiyat);

                decimal satisFiyat;
                if (!decimal.TryParse(txtSatisFiyat.Text, out satisFiyat))
                {
                    MessageBox.Show("Satış fiyat alanına sayısal değer giriniz.");
                    txtSatisFiyat.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@SatisFiyat", satisFiyat);

                int minimumStok;
                if (!int.TryParse(txtMinimumStok.Text, out minimumStok))
                {
                    MessageBox.Show("Minimum stok alanına sayısal değer giriniz.");
                    txtMinimumStok.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@MinimumStok", minimumStok);

                komut.Parameters.AddWithValue("@StokTakip", chkStokTakip.Checked);
                komut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);
                komut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);
                komut.Parameters.AddWithValue("@EklenmeTarihi", dtEklenmeTarihi.Value);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtUrunID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Ürün güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
                KayitGuncelle();
        }

        // Kategori seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKategori.BackColor = Color.White;
            lblYildizKategori.Visible = false;
        }

        // birim seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBirim.BackColor = Color.White;
            lblYildizBirim.Visible = false;
        }
    }
}