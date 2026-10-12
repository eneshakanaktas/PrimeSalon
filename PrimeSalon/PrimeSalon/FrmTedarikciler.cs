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
    public partial class FrmTedarikciler : Form
    {
        // FrmTedarikciler formunu başlatır; Windows Form kontrollerini oluşturarak tedarikçi ekranını kullanıma hazırlar.
        public FrmTedarikciler()
        {
            InitializeComponent();
        }

        // Tedarikçi kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtFirmaAdi.BackColor = Color.White;
            txtYetkiliAdSoyad.BackColor = Color.White;
            mskTelefon.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            cmbSehir.BackColor = Color.White;
            rtbAdres.BackColor = Color.White;
            txtIBAN.BackColor = Color.White;
            txtBanka.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

            lblYildizSehir.Visible = false;

            if (txtFirmaAdi.Text.Trim() == "")
            {
                txtFirmaAdi.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtYetkiliAdSoyad.Text.Trim() == "")
            {
                txtYetkiliAdSoyad.BackColor = Color.Red;
                bosVar = true;
            }

            if (!mskTelefon.MaskCompleted)
            {
                mskTelefon.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtEmail.Text.Trim() == "")
            {
                txtEmail.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbSehir.SelectedIndex == 0 || cmbSehir.Text == "Seçiniz")
            {
                cmbSehir.BackColor = Color.Red;
                lblYildizSehir.Visible = true;
                bosVar = true;
            }

            if (rtbAdres.Text.Trim() == "")
            {
                rtbAdres.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtIBAN.Text.Trim() == "")
            {
                txtIBAN.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtBanka.Text.Trim() == "")
            {
                txtBanka.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtFirmaAdi.BackColor == Color.Red) txtFirmaAdi.Focus();
                else if (txtYetkiliAdSoyad.BackColor == Color.Red) txtYetkiliAdSoyad.Focus();
                else if (mskTelefon.BackColor == Color.Red) mskTelefon.Focus();
                else if (txtEmail.BackColor == Color.Red) txtEmail.Focus();
                else if (cmbSehir.BackColor == Color.Red) cmbSehir.Focus();
                else if (rtbAdres.BackColor == Color.Red) rtbAdres.Focus();
                else if (txtIBAN.BackColor == Color.Red) txtIBAN.Focus();
                else if (txtBanka.BackColor == Color.Red) txtBanka.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Tedarikçi tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvTedarikciler üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM Tedarikciler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(ds, "Tedarikciler");
                dgvTedarikciler.DataSource = ds.Tables["Tedarikciler"];
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

        // Tedarikçi şehir tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void SehirListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, Sehir FROM TedarikcilerSehirTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["Sehir"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                cmbSehir.DataSource = dt;
                cmbSehir.DisplayMember = "Sehir";
                cmbSehir.ValueMember = "ID";
                cmbSehir.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Şehir Listeleme Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Formdaki tedarikçi bilgilerini parametreli SQL komutuyla tedarikçi tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO Tedarikciler
                (FirmaAdi, YetkiliAdSoyad, Telefon, Email, Sehir, Adres, IBAN, Banka, Notlar, KayitTarihi, Aktif)
                VALUES
                (@FirmaAdi, @YetkiliAdSoyad, @Telefon, @Email, @Sehir, @Adres, @IBAN, @Banka, @Notlar, @KayitTarihi, @Aktif)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@YetkiliAdSoyad", txtYetkiliAdSoyad.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Telefon", mskTelefon.Text);
                EkleKomut.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Sehir", cmbSehir.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", rtbAdres.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Banka", txtBanka.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

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

        // Tedarikçi formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmTedarikciler_Load(object sender, EventArgs e)
        {
            SehirListele();
            KayitListele();
        }

        // Tedarikçi listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Tedarikçi ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili tedarikçi satırının tüm alanlarını tedarikçi silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvTedarikciler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmTedarikcilerSil frmSil = new FrmTedarikcilerSil();

            frmSil.txtTedarikciID.Text = dgvTedarikciler.CurrentRow.Cells["TedarikçiID"].Value.ToString();
            frmSil.txtFirmaAdi.Text = dgvTedarikciler.CurrentRow.Cells["FirmaAdi"].Value.ToString();
            frmSil.txtYetkiliAdSoyad.Text = dgvTedarikciler.CurrentRow.Cells["YetkiliAdSoyad"].Value.ToString();
            frmSil.mskTelefon.Text = dgvTedarikciler.CurrentRow.Cells["Telefon"].Value.ToString();
            frmSil.txtEmail.Text = dgvTedarikciler.CurrentRow.Cells["Email"].Value.ToString();
            frmSil.cmbSehir.Text = dgvTedarikciler.CurrentRow.Cells["Sehir"].Value.ToString();
            frmSil.rtbAdres.Text = dgvTedarikciler.CurrentRow.Cells["Adres"].Value.ToString();
            frmSil.txtIBAN.Text = dgvTedarikciler.CurrentRow.Cells["IBAN"].Value.ToString();
            frmSil.txtBanka.Text = dgvTedarikciler.CurrentRow.Cells["Banka"].Value.ToString();
            frmSil.rtbNotlar.Text = dgvTedarikciler.CurrentRow.Cells["Notlar"].Value.ToString();
            frmSil.dtKayitTarihi.Value = Convert.ToDateTime(dgvTedarikciler.CurrentRow.Cells["KayitTarihi"].Value);
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvTedarikciler.CurrentRow.Cells["Aktif"].Value);

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili tedarikçi satırındaki mevcut değerleri tedarikçi güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvTedarikciler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmTedarikcilerGuncelle frm = new FrmTedarikcilerGuncelle();

            frm.txtTedarikciID.Text = dgvTedarikciler.CurrentRow.Cells["TedarikçiID"].Value.ToString();
            frm.txtFirmaAdi.Text = dgvTedarikciler.CurrentRow.Cells["FirmaAdi"].Value.ToString();
            frm.txtYetkiliAdSoyad.Text = dgvTedarikciler.CurrentRow.Cells["YetkiliAdSoyad"].Value.ToString();
            frm.mskTelefon.Text = dgvTedarikciler.CurrentRow.Cells["Telefon"].Value.ToString();
            frm.txtEmail.Text = dgvTedarikciler.CurrentRow.Cells["Email"].Value.ToString();
            frm.cmbSehir.Text = dgvTedarikciler.CurrentRow.Cells["Sehir"].Value.ToString();
            frm.rtbAdres.Text = dgvTedarikciler.CurrentRow.Cells["Adres"].Value.ToString();
            frm.txtIBAN.Text = dgvTedarikciler.CurrentRow.Cells["IBAN"].Value.ToString();
            frm.txtBanka.Text = dgvTedarikciler.CurrentRow.Cells["Banka"].Value.ToString();
            frm.rtbNotlar.Text = dgvTedarikciler.CurrentRow.Cells["Notlar"].Value.ToString();
            frm.dtKayitTarihi.Value = Convert.ToDateTime(dgvTedarikciler.CurrentRow.Cells["KayitTarihi"].Value);
            frm.chkAktif.Checked = Convert.ToBoolean(dgvTedarikciler.CurrentRow.Cells["Aktif"].Value);

            frm.ShowDialog();
            KayitListele();
        }

        // sehir seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSehir.BackColor = Color.White;
            lblYildizSehir.Visible = false;
        }

        // Tedarikçi kayıtlarını filtrelemek için tedarikçi sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmTedarikcilerSorgulama frm = new FrmTedarikcilerSorgulama();
            frm.ShowDialog();
        }

        // Tedarikçi için kullanılan tanım değerlerini yönetmek üzere tedarikçi şehir tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmTedarikcilerSehirTanimlama frm = new FrmTedarikcilerSehirTanimlama();
            frm.ShowDialog();

            SehirListele();
        }
    }
}