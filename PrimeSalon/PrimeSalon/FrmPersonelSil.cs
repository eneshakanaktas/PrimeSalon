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
    public partial class FrmPersonelSil : Form
    {
        // FrmPersonelSil formunu başlatır; Windows Form kontrollerini oluşturarak personel ekranını kullanıma hazırlar.
        public FrmPersonelSil()
        {
            InitializeComponent();
        }

        // Seçili personel kaydını personel tablosundan siler; bu kayda bağlı muhasebe/kasa/stok hareketlerini de temizler.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                int personelID = Convert.ToInt32(txtPersonelID.Text);
                string Sorgu = "Delete from Personel where PersonelID=@PersonelID";
                SqlCommand SilKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                SilKomut.Parameters.AddWithValue("@PersonelID", personelID);

                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MuhasebeServisi.KaynakKasaHareketleriniSil(FrmPersonel.Baglanti, "Personel", personelID);
                    MessageBox.Show("Kayıt Silindi");
                }

                FrmPersonel.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
            }
        }

        // Personel silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtPersonelID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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
