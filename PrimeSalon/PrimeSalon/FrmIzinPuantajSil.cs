using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmIzinPuantajSil : Form
    {
        // FrmIzinPuantajSil formunu başlatır; Windows Form kontrollerini oluşturarak izin/puantaj ekranını kullanıma hazırlar.
        public FrmIzinPuantajSil()
        {
            InitializeComponent();
        }

        // Seçili izin/puantaj kaydını ID değerine göre izin/puantaj tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = "Delete from IzinPuantaj where KayitID=@KayitID";
                SqlCommand SilKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                SilKomut.Parameters.AddWithValue("@KayitID", Convert.ToInt32(txtKayitID.Text));

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

        // İzin/puantaj silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtKayitID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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