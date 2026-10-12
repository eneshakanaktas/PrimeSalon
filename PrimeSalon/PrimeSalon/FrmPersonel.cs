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
    public partial class FrmPersonel : Form
    {
        // Uygulamadaki formların ortak kullandığı SQL Server bağlantı nesnesini tanımlar.
        public static SqlConnection Baglanti = new SqlConnection(
            "Data Source=(localdb)\\PrimeSalonDB;Initial Catalog=PrimeSalonDB;Integrated Security=True");

        // Uygulamanın ortak SQL bağlantısını kontrol eder; bağlantı kapalıysa açarak sonraki veritabanı işlemlerinin çalışmasını sağlar.
        public static void BaglantiAc()
        {
            try
            {
                if (Baglanti.State == ConnectionState.Closed)
                    Baglanti.Open();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }

        // FrmPersonel formunu başlatır; Windows Form kontrollerini oluşturarak personel ekranını kullanıma hazırlar.
        public FrmPersonel()
        {
            InitializeComponent();
        }

        // Personel tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvPersonel üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM Personel";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Baglanti);

                da.Fill(ds, "Personel");
                dgvPersonel.DataSource = ds.Tables["Personel"];
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
            finally
            {
                if (Baglanti.State == ConnectionState.Open)
                    Baglanti.Close();
            }
        }

        // Personel pozisyon tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void PozisyonListele()
        {
            try
            {
                BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, Pozisyon FROM PersonelTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Baglanti);

                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["Pozisyon"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                cmbPozisyon.DataSource = dt;
                cmbPozisyon.DisplayMember = "Pozisyon";
                cmbPozisyon.ValueMember = "ID";
                cmbPozisyon.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Pozisyon Listeleme Hata Penceresi");
            }
            finally
            {
                if (Baglanti.State == ConnectionState.Open)
                    Baglanti.Close();
            }
        }

        // Formdaki personel bilgilerini doğrulayıp personel tablosuna ekler; işlemle bağlantılı muhasebe/kasa/stok hareketini de oluşturur.
        public void KayitEkle()
        {
            try
            {
                BaglantiAc();

                string Sorgu = @"INSERT INTO Personel
                (Ad, Soyad, TcNo, Telefon, Pozisyon, Cinsiyet, Email, Adres, Maas, IseGirisTarihi, Aktif)
                OUTPUT INSERTED.PersonelID
                VALUES
                (@Ad, @Soyad, @TcNo, @Telefon, @Pozisyon, @Cinsiyet, @Email, @Adres, @Maas, @IseGirisTarihi, @Aktif)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, Baglanti);

                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@TcNo", mskTcNo.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                EkleKomut.Parameters.AddWithValue("@Pozisyon", cmbPozisyon.Text);

                if (radE.Checked)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "E");
                else if (radK.Checked)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "K");

                EkleKomut.Parameters.AddWithValue("@Email", txtEmail.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", rtbAdres.Text);

                decimal maas;
                if (!decimal.TryParse(txtMaas.Text, out maas))
                {
                    MessageBox.Show("Maaş alanına sayısal değer giriniz.");
                    txtMaas.Focus();
                    return;
                }

                EkleKomut.Parameters.AddWithValue("@Maas", maas);
                EkleKomut.Parameters.AddWithValue("@IseGirisTarihi", dtIseGiris.Value);
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                int personelID = Convert.ToInt32(EkleKomut.ExecuteScalar());
                MuhasebeServisi.PersonelMaasKasaHareketiYaz(
                    Baglanti,
                    personelID,
                    dtIseGiris.Value,
                    cmbPozisyon.Text,
                    maas,
                    txtAd.Text.Trim() + " " + txtSoyad.Text.Trim(),
                    chkAktif.Checked);

                MessageBox.Show("Kayıt Eklendi", "Veri Girişi");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
            finally
            {
                if (Baglanti.State == ConnectionState.Open)
                    Baglanti.Close();
            }
        }

        // Personel kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            mskTcNo.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            cmbPozisyon.BackColor = Color.White;
            txtMaas.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            rtbAdres.BackColor = Color.White;

            lblYildiz1.Visible = false;
            lblYildiz2.Visible = false;
            lblYildizPozisyon.Visible = false;

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

            if (mskTcNo.Text.Trim().Length < 11 || mskTcNo.Text.Contains("_"))
            {
                mskTcNo.BackColor = Color.Red;
                bosVar = true;
            }

            if (!txtTelefon.MaskCompleted)
            {
                txtTelefon.BackColor = Color.Red;
                bosVar = true;
            }

            if (cmbPozisyon.SelectedIndex == 0 || cmbPozisyon.Text == "Seçiniz")
            {
                cmbPozisyon.BackColor = Color.Red;
                lblYildizPozisyon.Visible = true;
                bosVar = true;
            }

            if (!radE.Checked && !radK.Checked)
            {
                lblYildiz1.Visible = true;
                bosVar = true;
            }

            if (txtMaas.Text.Trim() == "")
            {
                txtMaas.BackColor = Color.Red;
                bosVar = true;
            }

            if (dtIseGiris.Value.Date == DateTime.Today.Date)
            {
                lblYildiz2.Visible = true;
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

            if (bosVar)
            {
                if (txtAd.BackColor == Color.Red) txtAd.Focus();
                else if (txtSoyad.BackColor == Color.Red) txtSoyad.Focus();
                else if (mskTcNo.BackColor == Color.Red) mskTcNo.Focus();
                else if (txtTelefon.BackColor == Color.Red) txtTelefon.Focus();
                else if (cmbPozisyon.BackColor == Color.Red) cmbPozisyon.Focus();
                else if (txtMaas.BackColor == Color.Red) txtMaas.Focus();
                else if (txtEmail.BackColor == Color.Red) txtEmail.Focus();
                else if (rtbAdres.BackColor == Color.Red) rtbAdres.Focus();
            }

            return bosVar;
        }

        // Personel formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            chkAktif.Checked = true;
            KayitListele();
            PozisyonListele();
        }

        // Personel ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili personel satırının tüm alanlarını personel silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmPersonelSil frmSil = new FrmPersonelSil();

            frmSil.txtPersonelID.Text = dgvPersonel.CurrentRow.Cells["PersonelID"].Value.ToString();
            frmSil.txtAd.Text = dgvPersonel.CurrentRow.Cells["Ad"].Value.ToString();
            frmSil.txtSoyad.Text = dgvPersonel.CurrentRow.Cells["Soyad"].Value.ToString();
            frmSil.mskTcNo.Text = dgvPersonel.CurrentRow.Cells["TcNo"].Value.ToString();
            frmSil.txtTelefon.Text = dgvPersonel.CurrentRow.Cells["Telefon"].Value.ToString();
            frmSil.cmbPozisyon.Text = dgvPersonel.CurrentRow.Cells["Pozisyon"].Value.ToString();

            if (dgvPersonel.CurrentRow.Cells["Cinsiyet"].Value.ToString() == "E")
                frmSil.radE.Checked = true;
            else if (dgvPersonel.CurrentRow.Cells["Cinsiyet"].Value.ToString() == "K")
                frmSil.radK.Checked = true;

            frmSil.txtEmail.Text = dgvPersonel.CurrentRow.Cells["Email"].Value.ToString();
            frmSil.rtbAdres.Text = dgvPersonel.CurrentRow.Cells["Adres"].Value.ToString();
            frmSil.txtMaas.Text = dgvPersonel.CurrentRow.Cells["Maas"].Value.ToString();
            frmSil.dtIseGiris.Value = Convert.ToDateTime(dgvPersonel.CurrentRow.Cells["IseGirisTarihi"].Value);
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvPersonel.CurrentRow.Cells["Aktif"].Value);

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili personel satırındaki mevcut değerleri personel güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmPersonelGuncelle frm = new FrmPersonelGuncelle();

            frm.txtPersonelID.Text = dgvPersonel.CurrentRow.Cells["PersonelID"].Value.ToString();
            frm.txtAd.Text = dgvPersonel.CurrentRow.Cells["Ad"].Value.ToString();
            frm.txtSoyad.Text = dgvPersonel.CurrentRow.Cells["Soyad"].Value.ToString();
            frm.mskTcNo.Text = dgvPersonel.CurrentRow.Cells["TcNo"].Value.ToString();
            frm.txtTelefon.Text = dgvPersonel.CurrentRow.Cells["Telefon"].Value.ToString();
            frm.cmbPozisyon.Text = dgvPersonel.CurrentRow.Cells["Pozisyon"].Value.ToString();

            if (dgvPersonel.CurrentRow.Cells["Cinsiyet"].Value.ToString() == "E")
                frm.radE.Checked = true;
            else
                frm.radK.Checked = true;

            frm.txtEmail.Text = dgvPersonel.CurrentRow.Cells["Email"].Value.ToString();
            frm.rtbAdres.Text = dgvPersonel.CurrentRow.Cells["Adres"].Value.ToString();
            frm.txtMaas.Text = dgvPersonel.CurrentRow.Cells["Maas"].Value.ToString();
            frm.dtIseGiris.Value = Convert.ToDateTime(dgvPersonel.CurrentRow.Cells["IseGirisTarihi"].Value);
            frm.chkAktif.Checked = Convert.ToBoolean(dgvPersonel.CurrentRow.Cells["Aktif"].Value);

            frm.ShowDialog();
            KayitListele();
        }

        // Personel listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Personel kayıtlarını filtrelemek için personel sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmPersonelSorgulama frm = new FrmPersonelSorgulama();
            frm.ShowDialog();
        }

        // Personel için kullanılan tanım değerlerini yönetmek üzere personel pozisyon tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmPersonelPozisyonTanimlama frm = new FrmPersonelPozisyonTanimlama();
            frm.ShowDialog();

            PozisyonListele();
        }

        // Pozisyon seçimi değiştiğinde zorunlu alan uyarı rengini ve yıldız göstergesini temizler.
        private void cmbPozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPozisyon.BackColor = Color.White;
            lblYildizPozisyon.Visible = false;
        }

        // Personel gridinde hücre tıklama olayı için ayrılmıştır; şu an ek işlem gerekmediği için boş bırakılmıştır.
        private void dgvPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
