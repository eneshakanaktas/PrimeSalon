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
    public partial class FrmUrunler : Form
    {
        // FrmUrunler formunu başlatır; Windows Form kontrollerini oluşturarak ürün ekranını kullanıma hazırlar.
        public FrmUrunler()
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

            if (cmbKategori.SelectedIndex == 0 || cmbKategori.Text == "Seçiniz")
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

        // Ürün tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvUrunler üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM Urunler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(ds, "Urunler");
                dgvUrunler.DataSource = ds.Tables["Urunler"];
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

        // Ürün kategori tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void KategoriListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, Kategori FROM UrunlerKategoriTanimlama";
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

        // Formdaki ürün bilgilerini parametreli SQL komutuyla ürün tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO Urunler
                (UrunAdi, Marka, Kategori, Birim, AlisFiyat, SatisFiyat, StokTakip, MinimumStok, Aktif, Aciklama, EklenmeTarihi)
                VALUES
                (@UrunAdi, @Marka, @Kategori, @Birim, @AlisFiyat, @SatisFiyat, @StokTakip, @MinimumStok, @Aktif, @Aciklama, @EklenmeTarihi)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Marka", txtMarka.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                EkleKomut.Parameters.AddWithValue("@Birim", cmbBirim.Text);

                decimal alisFiyat;
                if (!decimal.TryParse(txtAlisFiyat.Text, out alisFiyat))
                {
                    MessageBox.Show("Alış fiyat alanına sayısal değer giriniz.");
                    txtAlisFiyat.Focus();
                    return;
                }

                decimal satisFiyat;
                if (!decimal.TryParse(txtSatisFiyat.Text, out satisFiyat))
                {
                    MessageBox.Show("Satış fiyat alanına sayısal değer giriniz.");
                    txtSatisFiyat.Focus();
                    return;
                }

                int minimumStok;
                if (!int.TryParse(txtMinimumStok.Text, out minimumStok))
                {
                    MessageBox.Show("Minimum stok alanına sayısal değer giriniz.");
                    txtMinimumStok.Focus();
                    return;
                }

                EkleKomut.Parameters.AddWithValue("@AlisFiyat", alisFiyat);
                EkleKomut.Parameters.AddWithValue("@SatisFiyat", satisFiyat);
                EkleKomut.Parameters.AddWithValue("@MinimumStok", minimumStok);
                EkleKomut.Parameters.AddWithValue("@StokTakip", chkStokTakip.Checked);
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@EklenmeTarihi", dtEklenmeTarihi.Value);

                if (EkleKomut.ExecuteNonQuery() == 1)
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

        // Ürün formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            KategoriListele();
            cmbBirim.SelectedIndex = 0;
            KayitListele();
        }

        // Ürün listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Ürün ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili ürün satırının tüm alanlarını ürün silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmUrunlerSil frmSil = new FrmUrunlerSil();

            frmSil.txtUrunID.Text = dgvUrunler.CurrentRow.Cells["UrunID"].Value.ToString();
            frmSil.txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
            frmSil.txtMarka.Text = dgvUrunler.CurrentRow.Cells["Marka"].Value.ToString();
            frmSil.cmbKategori.Text = dgvUrunler.CurrentRow.Cells["Kategori"].Value.ToString();
            frmSil.cmbBirim.Text = dgvUrunler.CurrentRow.Cells["Birim"].Value.ToString();
            frmSil.txtAlisFiyat.Text = dgvUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
            frmSil.txtSatisFiyat.Text = dgvUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
            frmSil.txtMinimumStok.Text = dgvUrunler.CurrentRow.Cells["MinimumStok"].Value.ToString();
            frmSil.dtEklenmeTarihi.Value = Convert.ToDateTime(dgvUrunler.CurrentRow.Cells["EklenmeTarihi"].Value);
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvUrunler.CurrentRow.Cells["Aktif"].Value);
            frmSil.chkStokTakip.Checked = Convert.ToBoolean(dgvUrunler.CurrentRow.Cells["StokTakip"].Value);
            frmSil.rtbAciklama.Text = dgvUrunler.CurrentRow.Cells["Aciklama"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili ürün satırındaki mevcut değerleri ürün güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmUrunlerGuncelle frm = new FrmUrunlerGuncelle();

            frm.txtUrunID.Text = dgvUrunler.CurrentRow.Cells["UrunID"].Value.ToString();
            frm.txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
            frm.txtMarka.Text = dgvUrunler.CurrentRow.Cells["Marka"].Value.ToString();
            frm.cmbKategori.Text = dgvUrunler.CurrentRow.Cells["Kategori"].Value.ToString();
            frm.cmbBirim.Text = dgvUrunler.CurrentRow.Cells["Birim"].Value.ToString();
            frm.txtAlisFiyat.Text = dgvUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
            frm.txtSatisFiyat.Text = dgvUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
            frm.txtMinimumStok.Text = dgvUrunler.CurrentRow.Cells["MinimumStok"].Value.ToString();
            frm.dtEklenmeTarihi.Value = Convert.ToDateTime(dgvUrunler.CurrentRow.Cells["EklenmeTarihi"].Value);
            frm.chkAktif.Checked = Convert.ToBoolean(dgvUrunler.CurrentRow.Cells["Aktif"].Value);
            frm.chkStokTakip.Checked = Convert.ToBoolean(dgvUrunler.CurrentRow.Cells["StokTakip"].Value);
            frm.rtbAciklama.Text = dgvUrunler.CurrentRow.Cells["Aciklama"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
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

        // Ürün kayıtlarını filtrelemek için ürün sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmUrunlerSorgulama frm = new FrmUrunlerSorgulama();
            frm.ShowDialog();
        }

        // Ürün için kullanılan tanım değerlerini yönetmek üzere ürün kategori tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmUrunlerKategoriTanimlama frm = new FrmUrunlerKategoriTanimlama();
            frm.ShowDialog();

            KategoriListele();
        }
    }
}