using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmGiderlerSil : Form
    {
        // FrmGiderlerSil formunu başlatır; Windows Form kontrollerini oluşturarak gider ekranını kullanıma hazırlar.
        public FrmGiderlerSil()
        {
            InitializeComponent();
        }

        // Seçili gider kaydını gider tablosundan siler; bu kayda bağlı muhasebe/kasa/stok hareketlerini de temizler.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = "Delete from Giderler where GiderID=@ID";
                SqlCommand cmd = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtGiderID.Text));

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.KaynakKasaHareketleriniSil(FrmPersonel.Baglanti, "Giderler", Convert.ToInt32(txtGiderID.Text));
                    MessageBox.Show("Kayıt Silindi");
                    this.Close();
                }

                FrmPersonel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
        }

        // Gider silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            var cevap = MessageBox.Show(
                txtGiderID.Text+ " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
                ;

            if (cevap == DialogResult.Yes)
                KayitSil();
        }
    }
}
