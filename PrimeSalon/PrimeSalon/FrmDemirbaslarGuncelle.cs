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
    public partial class FrmDemirbaslarGuncelle : Form
    {
        // FrmDemirbaslarGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak demirbaş ekranını kullanıma hazırlar.
        public FrmDemirbaslarGuncelle()
        {
            InitializeComponent();
        }

        // Demirbaş kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtDemirbasAdi.BackColor = Color.White;
            cmbKategori.BackColor = Color.White;
            txtMarka.BackColor = Color.White;
            txtAlimFiyati.BackColor = Color.White;
            cmbDurum.BackColor = Color.White;
            txtSorumluPersonel.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

            lblYildizKategori.Visible = false;
            lblYildizDurum.Visible = false;

            if (txtDemirbasAdi.Text.Trim() == "")
            {
                txtDemirbasAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbKategori.Text == "Seçiniz")
            {
                cmbKategori.BackColor = Color.Red;
                lblYildizKategori.Visible = true;
                bosVar = true;
            }

            if (txtMarka.Text.Trim() == "")
            {
                txtMarka.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtAlimFiyati.Text.Trim() == "")
            {
                txtAlimFiyati.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbDurum.Text == "Seçiniz")
            {
                cmbDurum.BackColor = Color.Red;
                lblYildizDurum.Visible = true;
                bosVar = true;
            }

            if (txtSorumluPersonel.Text.Trim() == "")
            {
                txtSorumluPersonel.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtDemirbasAdi.BackColor == Color.Red) txtDemirbasAdi.Focus();
                else if (cmbKategori.BackColor == Color.Red) cmbKategori.Focus();
                else if (txtMarka.BackColor == Color.Red) txtMarka.Focus();
                else if (txtAlimFiyati.BackColor == Color.Red) txtAlimFiyati.Focus();
                else if (cmbDurum.BackColor == Color.Red) cmbDurum.Focus();
                else if (txtSorumluPersonel.BackColor == Color.Red) txtSorumluPersonel.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Formdaki düzenlenmiş demirbaş bilgilerini demirbaş tablosunda günceller; bağlı muhasebe/kasa/stok hareketini yeni değerlerle eşitler.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE Demirbaslar SET
                DemirbasAdi=@DemirbasAdi,
                Kategori=@Kategori,
                Marka=@Marka,
                Model=@Model,
                AlimTarihi=@AlimTarihi,
                AlimFiyati=@AlimFiyati,
                GarantiBitis=@GarantiBitis,
                Durum=@Durum,
                SorumluPersonel=@SorumluPersonel,
                Notlar=@Notlar,
                Aktif=@Aktif
                WHERE DemirbasID=@DemirbasID";

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                komut.Parameters.AddWithValue("@DemirbasID", txtDemirbasID.Text);
                komut.Parameters.AddWithValue("@DemirbasAdi", txtDemirbasAdi.Text);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@Model", txtModel.Text);
                komut.Parameters.AddWithValue("@AlimTarihi", dtAlimTarihi.Value);

                decimal alimFiyati;
                if (!decimal.TryParse(txtAlimFiyati.Text, out alimFiyati))
                {
                    MessageBox.Show("Alım fiyatı alanına sayısal değer giriniz.");
                    txtAlimFiyati.Focus();
                    return;
                }
                komut.Parameters.AddWithValue("@AlimFiyati", alimFiyati);

                komut.Parameters.AddWithValue("@GarantiBitis", dtGarantiBitis.Value);
                komut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                komut.Parameters.AddWithValue("@SorumluPersonel", txtSorumluPersonel.Text);
                komut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);
                komut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.DemirbasKasaHareketiYaz(
                        FrmPersonel.Baglanti,
                        Convert.ToInt32(txtDemirbasID.Text),
                        dtAlimTarihi.Value,
                        cmbKategori.Text,
                        alimFiyati,
                        txtDemirbasAdi.Text,
                        chkAktif.Checked);

                    MessageBox.Show(txtDemirbasID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // Demirbaş güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
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

        // Durum seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDurum.BackColor = Color.White;
            lblYildizDurum.Visible = false;
        }
    }
}
