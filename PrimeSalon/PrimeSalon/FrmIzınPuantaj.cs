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
    public partial class FrmIzınPuantaj : Form
    {
        // FrmIzınPuantaj formunu başlatır; Windows Form kontrollerini oluşturarak izin/puantaj ekranını kullanıma hazırlar.
        public FrmIzınPuantaj()
        {
            InitializeComponent();
        }

        // Formdaki izin/puantaj bilgilerini parametreli SQL komutuyla izin/puantaj tablosuna yeni kayıt olarak ekler ve sonucu kullanıcıya bildirir.
        public void KayitEkle()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = @"Insert Into IzinPuantaj
        (PersonelID, Tarih, IslemTipi, BaslangicSaat, BitisSaat, ToplamSaat, IzinTuru, OnayDurumu, Aciklama, Onaylayan, KayitTarihi, UcretliMi, KesintiTutar, Notlar)
        Values
        (@PersonelID, @Tarih, @IslemTipi, @BaslangicSaat, @BitisSaat, @ToplamSaat, @IzinTuru, @OnayDurumu, @Aciklama, @Onaylayan, @KayitTarihi, @UcretliMi, @KesintiTutar, @Notlar)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);

                int personelID;
                if (!int.TryParse(txtPersonelID.Text, out personelID))
                {
                    MessageBox.Show("Personel ID alanına sayısal değer giriniz.");
                    txtPersonelID.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@PersonelID", personelID);

                EkleKomut.Parameters.AddWithValue("@Tarih", dtTarih.Value);
                EkleKomut.Parameters.AddWithValue("@IslemTipi", cmbIslemTipi.Text);
                EkleKomut.Parameters.AddWithValue("@BaslangicSaat", dtBaslangicSaat.Value);
                EkleKomut.Parameters.AddWithValue("@BitisSaat", dtBitisSaat.Value);

                decimal toplamSaat;
                if (!decimal.TryParse(txtToplamSaat.Text, out toplamSaat))
                {
                    MessageBox.Show("Toplam saat alanına sayısal değer giriniz.");
                    txtToplamSaat.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@ToplamSaat", toplamSaat);

                EkleKomut.Parameters.AddWithValue("@IzinTuru", cmbIzinTuru.Text);
                EkleKomut.Parameters.AddWithValue("@OnayDurumu", cmbOnayDurumu.Text);
                EkleKomut.Parameters.AddWithValue("@Aciklama", rtbAciklama.Text);
                EkleKomut.Parameters.AddWithValue("@Onaylayan", txtOnaylayan.Text);
                EkleKomut.Parameters.AddWithValue("@KayitTarihi", dtKayitTarihi.Value);
                EkleKomut.Parameters.AddWithValue("@UcretliMi", chkUcretliMi.Checked);

                decimal kesintiTutar;
                if (!decimal.TryParse(txtKesintiTutar.Text, out kesintiTutar))
                {
                    MessageBox.Show("Kesinti tutar alanına sayısal değer giriniz.");
                    txtKesintiTutar.Focus();
                    return;
                }
                EkleKomut.Parameters.AddWithValue("@KesintiTutar", kesintiTutar);

                EkleKomut.Parameters.AddWithValue("@Notlar", rtbNotlar.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        // İzin/puantaj tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvIzinPuantaj üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from IzinPuantaj";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, FrmPersonel.Baglanti);
                da.Fill(ds, "IzinPuantaj");
                dgvIzinPuantaj.DataSource = ds.Tables["IzinPuantaj"];
                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        // İzin/puantaj formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmIzınPuantaj_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.SelectedIndex = 0;
            cmbOnayDurumu.SelectedIndex = 0;
            cmbIzinTuru.SelectedIndex = 0;
            KayitListele();
        }

        // İzin/puantaj listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitEkle();
            KayitListele();
        }
    }
}
