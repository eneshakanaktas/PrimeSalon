using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class PersonelRaporu : Form
    {
        // Aynı anda birden fazla yenileme çalışmasını engeller.
        private bool raporYenileniyor;

        // PersonelRaporu formunu başlatır; ReportViewer ve veri seti kontrollerini raporu gösterecek şekilde hazırlar.
        public PersonelRaporu()
        {
            InitializeComponent();
        }

        // Personel raporu açılırken veri setini ortak veritabanındaki son kayıtlarla doldurur ve ReportViewer görünümünü hazırlar.
        private void PersonelRaporu_Load(object sender, EventArgs e)
        {
            RaporuYenile();
        }

        // Personel raporunun TableAdapter bağlantısını ana veritabanıyla eşitler; eski veri setini temizleyip güncel kayıtlarla yeniden doldurur.
        private void RaporuYenile()
        {
            if (raporYenileniyor)
                return;

            try
            {
                raporYenileniyor = true;
                PersonelTableAdapter.Connection.ConnectionString = FrmPersonel.Baglanti.ConnectionString;
                PrimeSalonDB_PrimaryDataSet.Personel.Clear();
                PersonelTableAdapter.Fill(PrimeSalonDB_PrimaryDataSet.Personel);
                reportViewer1.RefreshReport();
            }
            finally
            {
                raporYenileniyor = false;
            }
        }

        // Rapor penceresi yeniden odaklandığında veri setini tekrar okuyarak son eklenen veya değiştirilen personel kayıtlarını gösterir.
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RaporuYenile();
        }
    }
}
