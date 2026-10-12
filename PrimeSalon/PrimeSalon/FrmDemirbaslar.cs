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
    public partial class FrmDemirbaslar : Form
    {
        // FrmDemirbaslar formunu başlatır; Windows Form kontrollerini oluşturarak demirbaş ekranını kullanıma hazırlar.
        public FrmDemirbaslar()
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

            if (cmbKategori.SelectedIndex == 0 || cmbKategori.Text == "Seçiniz")
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

        // Demirbaş tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvDemirbaslar üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM Demirbaslar";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(ds, "Demirbaslar");
                dgvDemirbaslar.DataSource = ds.Tables["Demirbaslar"];
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

        // Demirbaş kategori tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void KategoriListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, Kategori FROM DemirbaslarKategoriTanimlama";
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

        // Formdaki demirbaş bilgilerini doğrulayıp demirbaş tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO Demirbaslar
                (DemirbasAdi, Kategori, Marka, Model, AlimTarihi, AlimFiyati, GarantiBitis, Durum, SorumluPersonel, Notlar, Aktif)
                OUTPUT INSERTED.DemirbasID
                VALUES
                (@DemirbasAdi, @Kategori, @Marka, @Model, @AlimTarihi, @AlimFiyati, @GarantiBitis, @Durum, @SorumluPersonel, @Notlar, @Aktif)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@DemirbasAdi", txtDemirbasAdi.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                EkleKomut.Parameters.AddWithValue("@Marka", txtMarka.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@AlimTarihi", dtAlimTarihi.Value);

                decimal alimFiyati;
                if (!decimal.TryParse(txtAlimFiyati.Text, out alimFiyati))
                {
                    MessageBox.Show("Alım fiyatı alanına sayısal değer giriniz.");
                    txtAlimFiyati.Focus();
                    return;
                }

                EkleKomut.Parameters.AddWithValue("@AlimFiyati", alimFiyati);
                EkleKomut.Parameters.AddWithValue("@GarantiBitis", dtGarantiBitis.Value);
                EkleKomut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                EkleKomut.Parameters.AddWithValue("@SorumluPersonel", txtSorumluPersonel.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                int demirbasID = Convert.ToInt32(EkleKomut.ExecuteScalar());

                MuhasebeServisi.DemirbasKasaHareketiYaz(
                    FrmPersonel.Baglanti,
                    demirbasID,
                    dtAlimTarihi.Value,
                    cmbKategori.Text,
                    alimFiyati,
                    txtDemirbasAdi.Text.Trim(),
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

        // Demirbaş formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmDemirbaslar_Load(object sender, EventArgs e)
        {
            chkAktif.Checked = true;
            KategoriListele();
            cmbDurum.SelectedIndex = 0;
            KayitListele();
        }

        // Demirbaş listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Demirbaş ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili demirbaş satırının tüm alanlarını demirbaş silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvDemirbaslar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            if (dgvDemirbaslar.CurrentRow.Cells["DemirbasID"].Value == null ||
                dgvDemirbaslar.CurrentRow.Cells["DemirbasID"].Value.ToString() == "")
            {
                MessageBox.Show("Geçerli bir kayıt seçiniz.");
                return;
            }

            FrmDemirbaslarSil frmSil = new FrmDemirbaslarSil();

            frmSil.txtDemirbasID.Text = dgvDemirbaslar.CurrentRow.Cells["DemirbasID"].Value.ToString();
            frmSil.txtDemirbasAdi.Text = dgvDemirbaslar.CurrentRow.Cells["DemirbasAdi"].Value.ToString();
            frmSil.cmbKategori.Text = dgvDemirbaslar.CurrentRow.Cells["Kategori"].Value.ToString();
            frmSil.txtMarka.Text = dgvDemirbaslar.CurrentRow.Cells["Marka"].Value.ToString();
            frmSil.txtModel.Text = dgvDemirbaslar.CurrentRow.Cells["Model"].Value.ToString();
            frmSil.dtAlimTarihi.Value = Convert.ToDateTime(dgvDemirbaslar.CurrentRow.Cells["AlimTarihi"].Value);
            frmSil.txtAlimFiyati.Text = dgvDemirbaslar.CurrentRow.Cells["AlimFiyati"].Value.ToString();
            frmSil.dtGarantiBitis.Value = Convert.ToDateTime(dgvDemirbaslar.CurrentRow.Cells["GarantiBitis"].Value);
            frmSil.cmbDurum.Text = dgvDemirbaslar.CurrentRow.Cells["Durum"].Value.ToString();
            frmSil.txtSorumluPersonel.Text = dgvDemirbaslar.CurrentRow.Cells["SorumluPersonel"].Value.ToString();
            frmSil.rtbNotlar.Text = dgvDemirbaslar.CurrentRow.Cells["Notlar"].Value.ToString();
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvDemirbaslar.CurrentRow.Cells["Aktif"].Value);

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili demirbaş satırındaki mevcut değerleri demirbaş güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDemirbaslar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmDemirbaslarGuncelle frm = new FrmDemirbaslarGuncelle();

            frm.txtDemirbasID.Text = dgvDemirbaslar.CurrentRow.Cells["DemirbasID"].Value.ToString();
            frm.txtDemirbasAdi.Text = dgvDemirbaslar.CurrentRow.Cells["DemirbasAdi"].Value.ToString();
            frm.cmbKategori.Text = dgvDemirbaslar.CurrentRow.Cells["Kategori"].Value.ToString();
            frm.txtMarka.Text = dgvDemirbaslar.CurrentRow.Cells["Marka"].Value.ToString();
            frm.txtModel.Text = dgvDemirbaslar.CurrentRow.Cells["Model"].Value.ToString();
            frm.dtAlimTarihi.Value = Convert.ToDateTime(dgvDemirbaslar.CurrentRow.Cells["AlimTarihi"].Value);
            frm.txtAlimFiyati.Text = dgvDemirbaslar.CurrentRow.Cells["AlimFiyati"].Value.ToString();
            frm.dtGarantiBitis.Value = Convert.ToDateTime(dgvDemirbaslar.CurrentRow.Cells["GarantiBitis"].Value);
            frm.cmbDurum.Text = dgvDemirbaslar.CurrentRow.Cells["Durum"].Value.ToString();
            frm.txtSorumluPersonel.Text = dgvDemirbaslar.CurrentRow.Cells["SorumluPersonel"].Value.ToString();
            frm.rtbNotlar.Text = dgvDemirbaslar.CurrentRow.Cells["Notlar"].Value.ToString();
            frm.chkAktif.Checked = Convert.ToBoolean(dgvDemirbaslar.CurrentRow.Cells["Aktif"].Value);

            frm.ShowDialog();
            KayitListele();
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

        // Demirbaş kayıtlarını filtrelemek için demirbaş sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmDemirbaslarSorgulama frm = new FrmDemirbaslarSorgulama();
            frm.ShowDialog();
        }

        // Demirbaş için kullanılan tanım değerlerini yönetmek üzere demirbaş kategori tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmDemirbaslarKategoriTanimlama frm = new FrmDemirbaslarKategoriTanimlama();
            frm.ShowDialog();

            KategoriListele();
        }
    }
}
