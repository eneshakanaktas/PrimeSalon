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
    public partial class FrmIzinPuantajGuncelle : Form
    {
        // FrmIzinPuantajGuncelle formunu başlatır; Windows Form kontrollerini oluşturarak izin/puantaj ekranını kullanıma hazırlar.
        public FrmIzinPuantajGuncelle()
        {
            InitializeComponent();
        }

        // İzin/puantaj kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtPersonelID.BackColor = Color.White;
            cmbIslemTipi.BackColor = Color.White;
            cmbOnayDurumu.BackColor = Color.White;
            txtToplamSaat.BackColor = Color.White;
            cmbIzinTuru.BackColor = Color.White;
            txtKesintiTutar.BackColor = Color.White;
            txtOnaylayan.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

            lblYildizIslemTipi.Visible = false;
            lblYildizOnayDurumu.Visible = false;
            lblYildizIzinTuru.Visible = false;

            if (txtPersonelID.Text.Trim() == "")
            {
                txtPersonelID.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbIslemTipi.Text == "Seçiniz")
            {
                cmbIslemTipi.BackColor = Color.Red;
                lblYildizIslemTipi.Visible = true;
                bosVar = true;
            }

            if (cmbOnayDurumu.Text == "Seçiniz")
            {
                cmbOnayDurumu.BackColor = Color.Red;
                lblYildizOnayDurumu.Visible = true;
                bosVar = true;
            }

            if (txtToplamSaat.Text.Trim() == "")
            {
                txtToplamSaat.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbIzinTuru.Text == "Seçiniz")
            {
                cmbIzinTuru.BackColor = Color.Red;
                lblYildizIzinTuru.Visible = true;
                bosVar = true;
            }

            if (txtKesintiTutar.Text.Trim() == "")
            {
                txtKesintiTutar.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtOnaylayan.Text.Trim() == "")
            {
                txtOnaylayan.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtPersonelID.BackColor == Color.Red) txtPersonelID.Focus();
                else if (cmbIslemTipi.BackColor == Color.Red) cmbIslemTipi.Focus();
                else if (cmbOnayDurumu.BackColor == Color.Red) cmbOnayDurumu.Focus();
                else if (txtToplamSaat.BackColor == Color.Red) txtToplamSaat.Focus();
                else if (cmbIzinTuru.BackColor == Color.Red) cmbIzinTuru.Focus();
                else if (txtKesintiTutar.BackColor == Color.Red) txtKesintiTutar.Focus();
                else if (txtOnaylayan.BackColor == Color.Red) txtOnaylayan.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Formdaki düzenlenmiş izin/puantaj bilgilerini seçili ID üzerinden izin/puantaj tablosuna kaydeder.
        public void KayitGuncelle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"UPDATE IzinPuantaj SET
                PersonelID=@PersonelID,
                Tarih=@Tarih,
                IslemTipi=@IslemTipi,
                BaslangicSaat=@BaslangicSaat,
                BitisSaat=@BitisSaat,
                ToplamSaat=@ToplamSaat,
                IzinTuru=@IzinTuru,
                OnayDurumu=@OnayDurumu,
                Aciklama=@Aciklama,
                Onaylayan=@Onaylayan,
                KayitTarihi=@KayitTarihi,
                UcretliMi=@UcretliMi,
                KesintiTutar=@KesintiTutar,
                Notlar=@Notlar
                WHERE KayitID=@KayitID";

                SqlCommand komut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                int personelID;
                if (!int.TryParse(txtPersonelID.Text, out personelID))
                {
                    MessageBox.Show("Personel ID alanına sayısal değer giriniz.");
                    txtPersonelID.Focus();
                    return;
                }

                decimal toplamSaat;
                if (!decimal.TryParse(txtToplamSaat.Text, out toplamSaat))
                {
                    MessageBox.Show("Toplam saat alanına sayısal değer giriniz.");
                    txtToplamSaat.Focus();
                    return;
                }

                decimal kesintiTutar;
                if (!decimal.TryParse(txtKesintiTutar.Text, out kesintiTutar))
                {
                    MessageBox.Show("Kesinti tutar alanına sayısal değer giriniz.");
                    txtKesintiTutar.Focus();
                    return;
                }

                komut.Parameters.AddWithValue("@KayitID", txtKayitID.Text);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@Tarih", dtTarih.Value);
                komut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                komut.Parameters.AddWithValue("@BaslangicSaat", dtBaslangicSaat.Value);
                komut.Parameters.AddWithValue("@BitisSaat", dtBitisSaat.Value);
                komut.Parameters.AddWithValue("@ToplamSaat", toplamSaat);
                komut.Parameters.AddWithValue("@IzinTuru", cmbIzinTuru.Text);
                komut.Parameters.AddWithValue("@OnayDurumu", cmbOnayDurumu.Text);
                komut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);
                komut.Parameters.AddWithValue("@Onaylayan", txtOnaylayan.Text);
                komut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                komut.Parameters.AddWithValue("@UcretliMi", chkUcretliMi.Checked);
                komut.Parameters.AddWithValue("@KesintiTutar", kesintiTutar);
                komut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtKayitID.Text + " Nolu Kayıt Güncellendi", "Güncelleme");

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
            }
        }

        // İzin/puantaj güncelleme düğmesinde alan kontrolünü yapar, geçerliyse düzenlenen kaydı veritabanına kaydedip pencereyi kapatır.
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

        // onay Durumu seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbOnayDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOnayDurumu.BackColor = Color.White;
            lblYildizOnayDurumu.Visible = false;
        }

        // İzin türü seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbIzinTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIzinTuru.BackColor = Color.White;
            lblYildizIzinTuru.Visible = false;
        }
    }
}