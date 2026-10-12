using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmStokHareketleriSil : Form
    {
        

        // FrmStokHareketleriSil formunu başlatır; Windows Form kontrollerini oluşturarak stok hareketi ekranını kullanıma hazırlar.
        public FrmStokHareketleriSil()
        {
            InitializeComponent();
        }

        // Seçili stok hareketi kaydını stok hareketi tablosundan siler; bu kayda bağlı muhasebe/kasa/stok hareketlerini de temizler.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                if (MuhasebeServisi.StokHareketiSil(FrmPersonel.Baglanti, Convert.ToInt32(txtHareketID.Text)))
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

        // Stok hareketi silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtHareketID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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
