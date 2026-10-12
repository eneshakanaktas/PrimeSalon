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
    public partial class FrmMusteriSil : Form
    {
        // FrmMusteriSil formunu başlatır; Windows Form kontrollerini oluşturarak müşteri ekranını kullanıma hazırlar.
        public FrmMusteriSil()
        {
            InitializeComponent();
        }

        // Seçili müşteri kaydını ID değerine göre müşteri tablosundan siler ve silme sonucunu kullanıcıya bildirir.
        public void KayitSil()
        {
            try
            {
                FrmPersonel.BaglantiAc();

                string Sorgu = "Delete from Musteri where MusteriID=@MusteriID";
                SqlCommand SilKomut = new SqlCommand(Sorgu, FrmPersonel.Baglanti);
                SilKomut.Parameters.AddWithValue("@MusteriID", Convert.ToInt32(txtMusteriID.Text));

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

        // Müşteri silme düğmesinde seçili kaydı veritabanından kaldırır; işlem tamamlanınca silme penceresini kapatır.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                txtMusteriID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor musunuz?",
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