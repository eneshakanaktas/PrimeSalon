using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmRandevuSil : Form
    {
        // FrmRandevuSil formunu başlatır; Windows Form kontrollerini oluşturarak randevu ekranını kullanıma hazırlar.
        public FrmRandevuSil()
        {
            InitializeComponent();
        }

        // Seçili randevu kaydını randevu tablosundan siler; bu kayda bağlı muhasebe/kasa/stok hareketlerini de temizler.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                int randevuID = Convert.ToInt32(txtRandevuID.Text);
                string Sorgu = "Delete from Randevu where RandevuID=@RandevuID";
                SqlCommand SilKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                SilKomut.Parameters.AddWithValue("@RandevuID", randevuID);

                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.KaynakKasaHareketleriniSil(FrmPersonel.Baglanti, "Randevu", randevuID);
                    MessageBox.Show("Kayıt Silindi");
                    FrmPersonel.Baglanti.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı.");
                    FrmPersonel.Baglanti.Close();
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
            }
        }

        // Randevu silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtRandevuID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (cevap == DialogResult.Yes)
                KayitSil();
            else
                MessageBox.Show("Silme İşlemi İptal Edildi", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
