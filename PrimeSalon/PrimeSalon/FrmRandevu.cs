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
    public partial class FrmRandevu : Form
    {
        // FrmRandevu formunu başlatır; Windows Form kontrollerini oluşturarak randevu ekranını kullanıma hazırlar.
        public FrmRandevu()
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

        // Randevu tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvRandevu üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Randevu";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Randevu");
                dgvRandevu.DataSource = ds.Tables["Randevu"];
                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Formdaki randevu bilgilerini doğrulayıp randevu tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"Insert Into Randevu
        (MusteriID, PersonelID, RandevuTarih, RandevuSaat, SureDakika, Durum, OlusturmaTarihi, IndirimMiktar, ToplamTutar, OdemeDurumu, Notlar)
        OUTPUT INSERTED.RandevuID
        Values
        (@MusteriID, @PersonelID, @RandevuTarih, @RandevuSaat, @SureDakika, @Durum, @OlusturmaTarihi, @IndirimMiktar, @ToplamTutar, @OdemeDurumu, @Notlar)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                int musteriID;
                if (!int.TryParse(txtMusteriID.Text, out musteriID))
                {
                    MessageBox.Show("Müşteri ID alanına sayısal değer giriniz.");
                    txtMusteriID.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@MusteriID", musteriID);

                int personelID;
                if (!int.TryParse(txtPersonelID.Text, out personelID))
                {
                    MessageBox.Show("Personel ID alanına sayısal değer giriniz.");
                    txtPersonelID.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@PersonelID", personelID);

                EkleKomut.Parameters.AddWithValue("@RandevuTarih", dtRandevuTarih.Value.Date);
                EkleKomut.Parameters.AddWithValue("@RandevuSaat", dtRandevuSaat.Value.TimeOfDay);

                int sureDakika;
                if (!int.TryParse(txtSureDakika.Text, out sureDakika))
                {
                    MessageBox.Show("Süre alanına sayısal değer giriniz.");
                    txtSureDakika.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@SureDakika", sureDakika);

                EkleKomut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                EkleKomut.Parameters.AddWithValue("@OlusturmaTarihi", dtOlusturmaTarihi.Value);

                decimal indirimMiktar;
                if (!decimal.TryParse(txtIndirimMiktar.Text, out indirimMiktar))
                {
                    MessageBox.Show("İndirim alanına sayısal değer giriniz.");
                    txtIndirimMiktar.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@IndirimMiktar", indirimMiktar);

                decimal toplamTutar;
                if (!decimal.TryParse(txtToplamTutar.Text, out toplamTutar))
                {
                    MessageBox.Show("Toplam tutar alanına sayısal değer giriniz.");
                    txtToplamTutar.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@ToplamTutar", toplamTutar);

                EkleKomut.Parameters.AddWithValue("@OdemeDurumu", cmbOdemeDurumu.Text);
                EkleKomut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);

                int randevuID = Convert.ToInt32(EkleKomut.ExecuteScalar());
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

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        // Randevu formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            cmbOdemeDurumu.SelectedIndex = 0;
            cmbDurum.SelectedIndex = 0;
            KayitListele();
        }

        // Randevu listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Randevu ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
        private void tsbEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz");
            else
            {
                KayitEkle();
                KayitListele();
            }
        }

        // Seçili randevu satırının tüm alanlarını randevu silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvRandevu.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmRandevuSil frmSil = new FrmRandevuSil();

            frmSil.txtRandevuID.Text = dgvRandevu.CurrentRow.Cells["RandevuID"].Value.ToString();
            frmSil.txtMusteriID.Text = dgvRandevu.CurrentRow.Cells["MusteriID"].Value.ToString();
            frmSil.txtPersonelID.Text = dgvRandevu.CurrentRow.Cells["PersonelID"].Value.ToString();
            frmSil.dtRandevuTarih.Value = Convert.ToDateTime(dgvRandevu.CurrentRow.Cells["RandevuTarih"].Value);
            frmSil.dtRandevuSaat.Value = DateTime.Today.Add((TimeSpan)dgvRandevu.CurrentRow.Cells["RandevuSaat"].Value);
            frmSil.txtSureDakika.Text = dgvRandevu.CurrentRow.Cells["SureDakika"].Value.ToString();
            frmSil.txtIndirimMiktar.Text = dgvRandevu.CurrentRow.Cells["IndirimMiktar"].Value.ToString();
            frmSil.txtToplamTutar.Text = dgvRandevu.CurrentRow.Cells["ToplamTutar"].Value.ToString();
            frmSil.cmbOdemeDurumu.Text = dgvRandevu.CurrentRow.Cells["OdemeDurumu"].Value.ToString();
            frmSil.dtOlusturmaTarihi.Value = Convert.ToDateTime(dgvRandevu.CurrentRow.Cells["OlusturmaTarihi"].Value);
            frmSil.cmbDurum.Text = dgvRandevu.CurrentRow.Cells["Durum"].Value.ToString();
            frmSil.rtbNotlar.Text = dgvRandevu.CurrentRow.Cells["Notlar"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili randevu satırındaki mevcut değerleri randevu güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvRandevu.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmRandevuGuncelle frm = new FrmRandevuGuncelle();

            frm.txtRandevuID.Text = dgvRandevu.CurrentRow.Cells["RandevuID"].Value.ToString();
            frm.txtMusteriID.Text = dgvRandevu.CurrentRow.Cells["MusteriID"].Value.ToString();
            frm.txtPersonelID.Text = dgvRandevu.CurrentRow.Cells["PersonelID"].Value.ToString();
            frm.dtRandevuTarih.Value = Convert.ToDateTime(dgvRandevu.CurrentRow.Cells["RandevuTarih"].Value);
            frm.dtRandevuSaat.Value = DateTime.Today.Add((TimeSpan)dgvRandevu.CurrentRow.Cells["RandevuSaat"].Value);
            frm.txtSureDakika.Text = dgvRandevu.CurrentRow.Cells["SureDakika"].Value.ToString();
            frm.txtIndirimMiktar.Text = dgvRandevu.CurrentRow.Cells["IndirimMiktar"].Value.ToString();
            frm.txtToplamTutar.Text = dgvRandevu.CurrentRow.Cells["ToplamTutar"].Value.ToString();
            frm.cmbOdemeDurumu.Text = dgvRandevu.CurrentRow.Cells["OdemeDurumu"].Value.ToString();
            frm.dtOlusturmaTarihi.Value = Convert.ToDateTime(dgvRandevu.CurrentRow.Cells["OlusturmaTarihi"].Value);
            frm.cmbDurum.Text = dgvRandevu.CurrentRow.Cells["Durum"].Value.ToString();
            frm.rtbNotlar.Text = dgvRandevu.CurrentRow.Cells["Notlar"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
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

        // Randevu kayıtlarını filtrelemek için randevu sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmRandevuSorgulama frm = new FrmRandevuSorgulama();
            frm.ShowDialog();
        }
    }
}
