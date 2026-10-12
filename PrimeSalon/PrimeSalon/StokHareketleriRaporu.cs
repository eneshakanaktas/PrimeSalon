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
    public partial class StokHareketleriRaporu : Form
    {
        // Aynı anda birden fazla yenileme çalışmasını engeller.
        private bool raporYenileniyor;

        // StokHareketleriRaporu formunu başlatır; ReportViewer ve veri seti kontrollerini raporu gösterecek şekilde hazırlar.
        public StokHareketleriRaporu()
        {
            InitializeComponent();
        }

        // Stok hareketleri raporu açılırken veri setini ortak veritabanındaki son kayıtlarla doldurur ve ReportViewer görünümünü hazırlar.
        private void StokHareketleriRaporu_Load(object sender, EventArgs e)
        {
            RaporuYenile();
        }

        // Stok hareketleri raporunun TableAdapter bağlantısını ana veritabanıyla eşitler; eski veri setini temizleyip güncel kayıtlarla yeniden doldurur.
        private void RaporuYenile()
        {
            if (raporYenileniyor)
                return;

            try
            {
                raporYenileniyor = true;
                StokHareketleriTableAdapter.Connection.ConnectionString = FrmPersonel.Baglanti.ConnectionString;
                PrimeSalonDB_PrimaryDataSet.StokHareketleri.Clear();
                StokHareketleriTableAdapter.Fill(PrimeSalonDB_PrimaryDataSet.StokHareketleri);
                reportViewer1.RefreshReport();
            }
            finally
            {
                raporYenileniyor = false;
            }
        }

        // Rapor penceresi yeniden odaklandığında veri setini tekrar okuyarak son eklenen veya değiştirilen stok hareketleri kayıtlarını gösterir.
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RaporuYenile();
        }
    }
}
