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
    public partial class FrmHizmet : Form
    {
        // FrmHizmet formunu başlatır; Windows Form kontrollerini oluşturarak hizmet ekranını kullanıma hazırlar.
        public FrmHizmet()
        {
            InitializeComponent();
        }

        // Hizmet kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtHizmetAdi.BackColor = Color.White;
            txtSureDakika.BackColor = Color.White;
            txtUcret.BackColor = Color.White;
            cmbKategori.BackColor = Color.White;
            rtbAciklama.BackColor = Color.White;

            lblYildizKategori.Visible = false;

            if (txtHizmetAdi.Text.Trim() == "")
            {
                txtHizmetAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtSureDakika.Text.Trim() == "")
            {
                txtSureDakika.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtUcret.Text.Trim() == "")
            {
                txtUcret.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbKategori.SelectedIndex == 0 || cmbKategori.Text == "Seçiniz")
            {
                cmbKategori.BackColor = Color.Red;
                lblYildizKategori.Visible = true;
                bosVar = true;
            }

            if (rtbAciklama.Text.Trim() == "")
            {
                rtbAciklama.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtHizmetAdi.BackColor == Color.Red) txtHizmetAdi.Focus();
                else if (txtSureDakika.BackColor == Color.Red) txtSureDakika.Focus();
                else if (txtUcret.BackColor == Color.Red) txtUcret.Focus();
                else if (cmbKategori.BackColor == Color.Red) cmbKategori.Focus();
                else if (rtbAciklama.BackColor == Color.Red) rtbAciklama.Focus();
            }

            return bosVar;
        }

        // Hizmet tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvHizmet üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM Hizmet";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(ds, "Hizmet");
                dgvHizmet.DataSource = ds.Tables["Hizmet"];
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Hizmet kategori tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void KategoriListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, Kategori FROM HizmetKategoriTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["Kategori"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "Kategori";
                cmbKategori.ValueMember = "ID";
                cmbKategori.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kategori Listeleme Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Formdaki hizmet bilgilerini doğrulayıp hizmet tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO Hizmet
                (HizmetAdi, Ucret, SureDakika, Aktif, Kategori, Aciklama)
                OUTPUT INSERTED.HizmetID
                VALUES
                (@HizmetAdi, @Ucret, @SureDakika, @Aktif, @Kategori, @Aciklama)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@HizmetAdi", txtHizmetAdi.Text.Trim());

                decimal ucret;
                if (!decimal.TryParse(txtUcret.Text, out ucret))
                {
                    MessageBox.Show("Ücret alanına sayısal değer giriniz.");
                    txtUcret.Focus();
                    return;
                }

                int sure;
                if (!int.TryParse(txtSureDakika.Text, out sure))
                {
                    MessageBox.Show("Süre alanına sayısal değer giriniz.");
                    txtSureDakika.Focus();
                    return;
                }

                EkleKomut.Parameters.AddWithValue("@Ucret", ucret);
                EkleKomut.Parameters.AddWithValue("@SureDakika", sure);
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);
                EkleKomut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text.Trim());

                int hizmetID = Convert.ToInt32(EkleKomut.ExecuteScalar());
                MuhasebeServisi.HizmetKasaHareketiYaz(
                    FrmPersonel.Baglanti,
                    hizmetID,
                    DateTime.Now,
                    cmbKategori.Text,
                    ucret,
                    txtHizmetAdi.Text.Trim(),
                    chkAktif.Checked);

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Hizmet formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmHizmet_Load(object sender, EventArgs e)
        {
            chkAktif.Checked = true;
            KategoriListele();
            KayitListele();
        }

        // Hizmet listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Hizmet ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili hizmet satırının tüm alanlarını hizmet silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvHizmet.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmHizmetSil frmSil = new FrmHizmetSil();

            frmSil.txtHizmetID.Text = dgvHizmet.CurrentRow.Cells["HizmetID"].Value.ToString();
            frmSil.txtHizmetAdi.Text = dgvHizmet.CurrentRow.Cells["HizmetAdi"].Value.ToString();
            frmSil.txtUcret.Text = dgvHizmet.CurrentRow.Cells["Ucret"].Value.ToString();
            frmSil.txtSureDakika.Text = dgvHizmet.CurrentRow.Cells["SureDakika"].Value.ToString();
            frmSil.cmbKategori.Text = dgvHizmet.CurrentRow.Cells["Kategori"].Value.ToString();
            frmSil.rtbAciklama.Text = dgvHizmet.CurrentRow.Cells["Aciklama"].Value.ToString();
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvHizmet.CurrentRow.Cells["Aktif"].Value);

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili hizmet satırındaki mevcut değerleri hizmet güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvHizmet.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmHizmetGuncelle frm = new FrmHizmetGuncelle();

            frm.txtHizmetID.Text = dgvHizmet.CurrentRow.Cells["HizmetID"].Value.ToString();
            frm.txtHizmetAdi.Text = dgvHizmet.CurrentRow.Cells["HizmetAdi"].Value.ToString();
            frm.cmbKategori.Text = dgvHizmet.CurrentRow.Cells["Kategori"].Value.ToString();
            frm.txtUcret.Text = dgvHizmet.CurrentRow.Cells["Ucret"].Value.ToString();
            frm.txtSureDakika.Text = dgvHizmet.CurrentRow.Cells["SureDakika"].Value.ToString();
            frm.rtbAciklama.Text = dgvHizmet.CurrentRow.Cells["Aciklama"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
        }

        // Kategori seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKategori.BackColor = Color.White;
            lblYildizKategori.Visible = false;
        }

        // Hizmet kayıtlarını filtrelemek için hizmet sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmHizmetSorgulama frm = new FrmHizmetSorgulama();
            frm.ShowDialog();
        }

        // Hizmet için kullanılan tanım değerlerini yönetmek üzere hizmet kategori tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmHizmetKategoriTanimlama frm = new FrmHizmetKategoriTanimlama();
            frm.ShowDialog();

            KategoriListele();
        }
    }
}
