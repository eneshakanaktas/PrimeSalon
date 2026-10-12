using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmUrunlerSil : Form
    {
        // FrmUrunlerSil formunu başlatır; Windows Form kontrollerini oluşturarak ürün ekranını kullanıma hazırlar.
        public FrmUrunlerSil()
        {
            InitializeComponent();
        }

        // Seçili ürün kaydını ID değerine göre ürün tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = "Delete from Urunler where UrunID=@UrunID";
                SqlCommand SilKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                SilKomut.Parameters.AddWithValue("@UrunID", Convert.ToInt32(txtUrunID.Text));

                if (SilKomut.ExecuteNonQuery() == 1)
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

        // Ürün silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtUrunID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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