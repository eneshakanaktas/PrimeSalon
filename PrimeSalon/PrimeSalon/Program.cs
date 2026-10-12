using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSalon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                FrmPersonel.BaglantiAc();
                MuhasebeServisi.SemayiHazirla(FrmPersonel.Baglanti);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Muhasebe Şema Hazırlama Hatası");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }

            Application.Run(new FrmAnaMenu());
        }
    }
}
