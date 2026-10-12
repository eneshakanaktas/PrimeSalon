using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmKasaHareketleriSil : Form
    {
        // FrmKasaHareketleriSil formunu başlatır; Windows Form kontrollerini oluşturarak kasa hareketi ekranını kullanıma hazırlar.
        public FrmKasaHareketleriSil()
        {
            InitializeComponent();
        }

        // Seçili kasa hareketi kaydını kasa hareketi tablosundan siler; bu kayda bağlı muhasebe/kasa/stok hareketlerini de temizler.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                if (MuhasebeServisi.KasaHareketiSil(FrmPersonel.Baglanti, Convert.ToInt32(txtKasaHareketID.Text)))
                {
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

        // Kasa hareketi silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtKasaHareketID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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
