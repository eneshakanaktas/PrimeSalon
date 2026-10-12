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
    public partial class FrmIzinPuantaj : Form
    {
        // FrmIzinPuantaj formunu başlatır; Windows Form kontrollerini oluşturarak izin/puantaj ekranını kullanıma hazırlar.
        public FrmIzinPuantaj()
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

            if (cmbIzinTuru.SelectedIndex == 0 || cmbIzinTuru.Text == "Seçiniz")
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

        // İzin/puantaj tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvIzinPuantaj üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataSet ds = new DataSet();
                string Sorgu = "SELECT * FROM IzinPuantaj";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(ds, "IzinPuantaj");
                dgvIzinPuantaj.DataSource = ds.Tables["IzinPuantaj"];
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

        // İzin türü tanımı verilerini veritabanından okuyup ilgili ComboBox/listede seçim yapılabilecek şekilde hazırlar.
        public void IzinTuruListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                DataTable dt = new DataTable();
                string Sorgu = "SELECT ID, IzinTuru FROM IzinPuantajIzinTuruTanimlama";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);

                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["IzinTuru"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                cmbIzinTuru.DataSource = dt;
                cmbIzinTuru.DisplayMember = "IzinTuru";
                cmbIzinTuru.ValueMember = "ID";
                cmbIzinTuru.SelectedIndex = 0;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "İzin Türü Listeleme Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Formdaki izin/puantaj bilgilerini parametreli SQL komutuyla izin/puantaj tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"INSERT INTO IzinPuantaj
                (PersonelID, Tarih, IslemTipi, BaslangicSaat, BitisSaat, ToplamSaat, IzinTuru, OnayDurumu, Aciklama, Onaylayan, KayitTarihi, UcretliMi, KesintiTutar, Notlar)
                VALUES
                (@PersonelID, @Tarih, @IslemTipi, @BaslangicSaat, @BitisSaat, @ToplamSaat, @IzinTuru, @OnayDurumu, @Aciklama, @Onaylayan, @KayitTarihi, @UcretliMi, @KesintiTutar, @Notlar)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

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

                EkleKomut.Parameters.AddWithValue("@PersonelID", personelID);
                EkleKomut.Parameters.AddWithValue("@Tarih", dtTarih.Value);
                EkleKomut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                EkleKomut.Parameters.AddWithValue("@BaslangicSaat", dtBaslangicSaat.Value);
                EkleKomut.Parameters.AddWithValue("@BitisSaat", dtBitisSaat.Value);
                EkleKomut.Parameters.AddWithValue("@ToplamSaat", toplamSaat);
                EkleKomut.Parameters.AddWithValue("@IzinTuru", cmbIzinTuru.Text);
                EkleKomut.Parameters.AddWithValue("@OnayDurumu", cmbOnayDurumu.Text);
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@Onaylayan", txtOnaylayan.Text.Trim());
                EkleKomut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                EkleKomut.Parameters.AddWithValue("@UcretliMi", chkUcretliMi.Checked);
                EkleKomut.Parameters.AddWithValue("@KesintiTutar", kesintiTutar);
                EkleKomut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text.Trim());

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

        // İzin/puantaj formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmIzinPuantaj_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.SelectedIndex = 0;
            cmbOnayDurumu.SelectedIndex = 0;
            IzinTuruListele();
            KayitListele();
        }

        // İzin/puantaj listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbListele_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // İzin/puantaj ekleme düğmesinde zorunlu alanları denetler; alanlar geçerliyse kaydı veritabanına ekleyip listeyi yeniler.
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

        // Seçili izin/puantaj satırının tüm alanlarını izin/puantaj silme formuna aktarır; silme penceresi kapandıktan sonra ana listeyi yeniler.
        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (dgvIzinPuantaj.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            FrmIzinPuantajSil frmSil = new FrmIzinPuantajSil();

            frmSil.txtKayitID.Text = dgvIzinPuantaj.CurrentRow.Cells["KayitID"].Value.ToString();
            frmSil.txtPersonelID.Text = dgvIzinPuantaj.CurrentRow.Cells["PersonelID"].Value.ToString();
            frmSil.dtTarih.Value = Convert.ToDateTime(dgvIzinPuantaj.CurrentRow.Cells["Tarih"].Value);
            frmSil.cmbIslemTipi.Text = dgvIzinPuantaj.CurrentRow.Cells["IslemTipi"].Value.ToString();
            frmSil.dtBaslangicSaat.Value = DateTime.Today.Add((TimeSpan)dgvIzinPuantaj.CurrentRow.Cells["BaslangicSaat"].Value);
            frmSil.dtBitisSaat.Value = DateTime.Today.Add((TimeSpan)dgvIzinPuantaj.CurrentRow.Cells["BitisSaat"].Value);
            frmSil.txtToplamSaat.Text = dgvIzinPuantaj.CurrentRow.Cells["ToplamSaat"].Value.ToString();
            frmSil.cmbIzinTuru.Text = dgvIzinPuantaj.CurrentRow.Cells["IzinTuru"].Value.ToString();
            frmSil.cmbOnayDurumu.Text = dgvIzinPuantaj.CurrentRow.Cells["OnayDurumu"].Value.ToString();
            frmSil.txtOnaylayan.Text = dgvIzinPuantaj.CurrentRow.Cells["Onaylayan"].Value.ToString();
            frmSil.dtKayitTarihi.Value = Convert.ToDateTime(dgvIzinPuantaj.CurrentRow.Cells["KayitTarihi"].Value);
            frmSil.txtKesintiTutar.Text = dgvIzinPuantaj.CurrentRow.Cells["KesintiTutar"].Value.ToString();
            frmSil.chkUcretliMi.Checked = Convert.ToBoolean(dgvIzinPuantaj.CurrentRow.Cells["UcretliMi"].Value);
            frmSil.rtbAciklama.Text = dgvIzinPuantaj.CurrentRow.Cells["Aciklama"].Value.ToString();
            frmSil.rtbNotlar.Text = dgvIzinPuantaj.CurrentRow.Cells["Notlar"].Value.ToString();

            frmSil.ShowDialog();
            KayitListele();
        }

        // Seçili izin/puantaj satırındaki mevcut değerleri izin/puantaj güncelleme formuna taşır; güncelleme sonrası listeyi tekrar yükler.
        private void tsbGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvIzinPuantaj.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.");
                return;
            }

            FrmIzinPuantajGuncelle frm = new FrmIzinPuantajGuncelle();

            frm.txtKayitID.Text = dgvIzinPuantaj.CurrentRow.Cells["KayitID"].Value.ToString();
            frm.txtPersonelID.Text = dgvIzinPuantaj.CurrentRow.Cells["PersonelID"].Value.ToString();
            frm.dtTarih.Value = Convert.ToDateTime(dgvIzinPuantaj.CurrentRow.Cells["Tarih"].Value);
            frm.cmbIslemTipi.Text = dgvIzinPuantaj.CurrentRow.Cells["IslemTipi"].Value.ToString();
            frm.dtBaslangicSaat.Value = DateTime.Today.Add((TimeSpan)dgvIzinPuantaj.CurrentRow.Cells["BaslangicSaat"].Value);
            frm.dtBitisSaat.Value = DateTime.Today.Add((TimeSpan)dgvIzinPuantaj.CurrentRow.Cells["BitisSaat"].Value);
            frm.txtToplamSaat.Text = dgvIzinPuantaj.CurrentRow.Cells["ToplamSaat"].Value.ToString();
            frm.cmbIzinTuru.Text = dgvIzinPuantaj.CurrentRow.Cells["IzinTuru"].Value.ToString();
            frm.cmbOnayDurumu.Text = dgvIzinPuantaj.CurrentRow.Cells["OnayDurumu"].Value.ToString();
            frm.txtOnaylayan.Text = dgvIzinPuantaj.CurrentRow.Cells["Onaylayan"].Value.ToString();
            frm.dtKayitTarihi.Value = Convert.ToDateTime(dgvIzinPuantaj.CurrentRow.Cells["KayitTarihi"].Value);
            frm.txtKesintiTutar.Text = dgvIzinPuantaj.CurrentRow.Cells["KesintiTutar"].Value.ToString();
            frm.chkUcretliMi.Checked = Convert.ToBoolean(dgvIzinPuantaj.CurrentRow.Cells["UcretliMi"].Value);
            frm.rtbAciklama.Text = dgvIzinPuantaj.CurrentRow.Cells["Aciklama"].Value.ToString();
            frm.rtbNotlar.Text = dgvIzinPuantaj.CurrentRow.Cells["Notlar"].Value.ToString();

            frm.ShowDialog();
            KayitListele();
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

        // İzin/puantaj kayıtlarını filtrelemek için izin/puantaj sorgulama formunu modal olarak açar.
        private void tsbSorgulama_Click(object sender, EventArgs e)
        {
            FrmIzinPuantajSorgulama frm = new FrmIzinPuantajSorgulama();
            frm.ShowDialog();
        }

        // İzin/puantaj için kullanılan tanım değerlerini yönetmek üzere izin/puantaj izin türü tanımlama penceresini açar; kapanınca ilgili seçim listesini yeniler.
        private void tsbtnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmIzinPuantajIzinTuruTanimlama frm = new FrmIzinPuantajIzinTuruTanimlama();
            frm.ShowDialog();

            IzinTuruListele();
        }
    }
}