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
    public partial class FrmHizmetSil : Form
    {
        // FrmHizmetSil formunu başlatır; Windows Form kontrollerini oluşturarak hizmet ekranını kullanıma hazırlar.
        public FrmHizmetSil()
        {
            InitializeComponent();
        }

        // Seçili hizmet kaydını hizmet tablosundan siler; bu kayda bağlı muhasebe/kasa/stok hareketlerini de temizler.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                int hizmetID = Convert.ToInt32(txtHizmetID.Text);
                string Sorgu = "Delete from Hizmet where HizmetID=@HizmetID";
                SqlCommand SilKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                SilKomut.Parameters.AddWithValue("@HizmetID", hizmetID);

                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.KaynakKasaHareketleriniSil(FrmPersonel.Baglanti, "Hizmet", hizmetID);
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

        // Hizmet silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtHizmetID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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
