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
    public partial class FrmMusteri : Form
    {
        // Müşteri tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvMusteri üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Musteri";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "Musteri");
                dgvMusteri.DataSource = ds.Tables["Musteri"];
                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // Müşteri kaydı için zorunlu alanları denetler; eksik veya hatalı alanları kırmızı yapıp kullanıcıyı ilk sorunlu kontrole yönlendirir.
        public bool BoslukKontrol()
        {
            bool bosVar = false;

            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            mskTcNo.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            rtbAdres.BackColor = Color.White;
            txtBorc.BackColor = Color.White;
            txtToplamHarcama.BackColor = Color.White;
            rtbNotlar.BackColor = Color.White;

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

            if (txtBorc.Text.Trim() == "")
            {
                txtBorc.BackColor = Color.Red;
                bosVar = true;
            }

            if (txtToplamHarcama.Text.Trim() == "")
            {
                txtToplamHarcama.BackColor = Color.Red;
                bosVar = true;
            }

            if (rtbNotlar.Text.Trim() == "")
            {
                rtbNotlar.BackColor = Color.Red;
                bosVar = true;
            }

            if (bosVar)
            {
                if (txtAd.BackColor == Color.Red) txtAd.Focus();
                else if (txtSoyad.BackColor == Color.Red) txtSoyad.Focus();
                else if (mskTcNo.BackColor == Color.Red) mskTcNo.Focus();
                else if (txtTelefon.BackColor == Color.Red) txtTelefon.Focus();
                else if (txtEmail.BackColor == Color.Red) txtEmail.Focus();
                else if (rtbAdres.BackColor == Color.Red) rtbAdres.Focus();
                else if (txtBorc.BackColor == Color.Red) txtBorc.Focus();
                else if (txtToplamHarcama.BackColor == Color.Red) txtToplamHarcama.Focus();
                else if (rtbNotlar.BackColor == Color.Red) rtbNotlar.Focus();
            }

            return bosVar;
        }

        // Formdaki müşteri bilgilerini parametreli SQL komutuyla müşteri tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO Musteri
        (Ad, Soyad, Telefon, Aktif, KayitTarihi, TcNo, Email, Adres, Notlar, Borc, SonGelisTarihi, ToplamHarcama)
        VALUES
        (@Ad, @Soyad, @Telefon, @Aktif, @KayitTarihi, @TcNo, @Email, @Adres, @Notlar, @Borc, @SonGelisTarihi, @ToplamHarcama)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                EkleKomut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                EkleKomut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                EkleKomut.Parameters.AddWithValue("@TcNo", mskTcNo.Text);
                EkleKomut.Parameters.AddWithValue("@Email", txtEmail.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", rtbAdres.Text);
                EkleKomut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);

                decimal borc;
                if (!decimal.TryParse(txtBorc.Text, out borc))
                {
                    MessageBox.Show("Borç alanına sayısal değer giriniz.");
                    txtBorc.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@Borc", borc);

                EkleKomut.Parameters.AddWithValue("@SonGelisTarihi", dtSonGelisTarihi.Value);

                decimal harcama;
                if (!decimal.TryParse(txtToplamHarcama.Text, out harcama))
                {
                    MessageBox.Show("Toplam harcama alanına sayısal değer giriniz.");
                    txtToplamHarcama.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@ToplamHarcama", harcama);

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        // FrmMusteri formunu başlatır; Windows Form kontrollerini oluşturarak müşteri ekranını kullanıma hazırlar.
        public FrmMusteri()
        {
            InitializeComponent();
        }

        // Müşteri formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Müşteri ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili müşteri satırının tüm alanlarını müşteri silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmMusteriSil frmSil = new FrmMusteriSil();

            frmSil.txtMusteriID.Text = dgvMusteri.CurrentRow.Cells["MusteriID"].Value.ToString();
            frmSil.txtAd.Text = dgvMusteri.CurrentRow.Cells["Ad"].Value.ToString();
            frmSil.txtSoyad.Text = dgvMusteri.CurrentRow.Cells["Soyad"].Value.ToString();
            frmSil.txtTelefon.Text = dgvMusteri.CurrentRow.Cells["Telefon"].Value.ToString();
            frmSil.chkAktif.Checked = Convert.ToBoolean(dgvMusteri.CurrentRow.Cells["Aktif"].Value);
            frmSil.dtKayitTarihi.Value = Convert.ToDateTime(dgvMusteri.CurrentRow.Cells["KayitTarihi"].Value);
            frmSil.mskTcNo.Text = dgvMusteri.CurrentRow.Cells["TcNo"].Value.ToString();
            frmSil.txtEmail.Text = dgvMusteri.CurrentRow.Cells["Email"].Value.ToString();
            frmSil.rtbAdres.Text = dgvMusteri.CurrentRow.Cells["Adres"].Value.ToString();
            frmSil.rtbNotlar.Text = dgvMusteri.CurrentRow.Cells["Notlar"].Value.ToString();
            frmSil.txtBorc.Text = dgvMusteri.CurrentRow.Cells["Borc"].Value.ToString();
            frmSil.dtSonGelisTarihi.Value = Convert.ToDateTime(dgvMusteri.CurrentRow.Cells["SonGelisTarihi"].Value);
            frmSil.txtToplamHarcama.Text = dgvMusteri.CurrentRow.Cells["ToplamHarcama"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili müşteri satırındaki mevcut değerleri müşteri güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmMusteriGuncelle frm = new FrmMusteriGuncelle();

            frm.txtMusteriID.Text = dgvMusteri.CurrentRow.Cells["MusteriID"].Value.ToString();
            frm.txtAd.Text = dgvMusteri.CurrentRow.Cells["Ad"].Value.ToString();
            frm.txtSoyad.Text = dgvMusteri.CurrentRow.Cells["Soyad"].Value.ToString();
            frm.txtTelefon.Text = dgvMusteri.CurrentRow.Cells["Telefon"].Value.ToString();
            frm.mskTcNo.Text = dgvMusteri.CurrentRow.Cells["TcNo"].Value.ToString();
            frm.txtEmail.Text = dgvMusteri.CurrentRow.Cells["Email"].Value.ToString();
            frm.rtbAdres.Text = dgvMusteri.CurrentRow.Cells["Adres"].Value.ToString();
            frm.rtbNotlar.Text = dgvMusteri.CurrentRow.Cells["Notlar"].Value.ToString();

            frm.txtBorc.Text = dgvMusteri.CurrentRow.Cells["Borc"].Value.ToString();
            frm.txtToplamHarcama.Text = dgvMusteri.CurrentRow.Cells["ToplamHarcama"].Value.ToString();

            frm.chkAktif.Checked = Convert.ToBoolean(dgvMusteri.CurrentRow.Cells["Aktif"].Value);

            frm.dtKayitTarihi.Value = Convert.ToDateTime(dgvMusteri.CurrentRow.Cells["KayitTarihi"].Value);
            frm.dtSonGelisTarihi.Value = Convert.ToDateTime(dgvMusteri.CurrentRow.Cells["SonGelisTarihi"].Value);

            frm.ShowDialog();

            KayitListele();
        }

        // Müşteri listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Müşteri kayıtlarını filtrelemek için müşteri sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmMusteriSorgulama frm = new FrmMusteriSorgulama();
            frm.ShowDialog();
        }
    }
}