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
    public partial class FrmAnaMenu : Form
    {
        // Ana menü formunu başlatır; muhasebe ve stok alt menüsünü dinamik form kısayollarıyla hazırlar.
        public FrmAnaMenu()
        {
            InitializeComponent();
            MuhasebeStokAltMenusuHazirla();
        }

        // YENİ MENUSTRIP

        // Ana menüdeki muhasebe ve stok başlığını temizler; tüm işlem formlarına giden alt menü seçeneklerini yeniden oluşturur.
        private void MuhasebeStokAltMenusuHazirla()
        {
            muhasebeVeStokIslemleriToolStripMenuItem.DropDownItems.Clear();

            MuhasebeStokMenuEkle("Muhasebe ve Stok İşlemleri", delegate { new FrmMuhasebeStokIslemleri().ShowDialog(); });
            muhasebeVeStokIslemleriToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            MuhasebeStokMenuEkle("Personel", delegate { new FrmPersonel().ShowDialog(); });
            MuhasebeStokMenuEkle("Müşteri", delegate { new FrmMusteri().ShowDialog(); });
            MuhasebeStokMenuEkle("Hizmet", delegate { new FrmHizmet().ShowDialog(); });
            MuhasebeStokMenuEkle("Demirbaşlar", delegate { new FrmDemirbaslar().ShowDialog(); });
            MuhasebeStokMenuEkle("Giderler", delegate { new FrmGiderler().ShowDialog(); });
            MuhasebeStokMenuEkle("Ürünler", delegate { new FrmUrunler().ShowDialog(); });
            MuhasebeStokMenuEkle("Stok Hareketleri", delegate { new FrmStokHareketleri().ShowDialog(); });
            MuhasebeStokMenuEkle("Satışlar", delegate { new FrmSatislar().ShowDialog(); });
            MuhasebeStokMenuEkle("Kasa Hareketleri", delegate { new FrmKasaHareketleri().ShowDialog(); });
            MuhasebeStokMenuEkle("İzin / Puantaj", delegate { new FrmIzinPuantaj().ShowDialog(); });
            MuhasebeStokMenuEkle("Randevu", delegate { new FrmRandevu().ShowDialog(); });
        }

        // Verilen menü metni ve açma işlemiyle yeni ToolStripMenuItem üretir ve muhasebe/stok alt menüsüne bağlar.
        private void MuhasebeStokMenuEkle(string metin, Action ac)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(metin);
            menuItem.Click += delegate { ac(); };
            muhasebeVeStokIslemleriToolStripMenuItem.DropDownItems.Add(menuItem);
        }

        // Personel ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void personelIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }

        // Personel ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }

        // Personel ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void personelGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }

        // Personel ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }

        // Personel ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }

        // Personel sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void personelSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelSorgulama frm = new FrmPersonelSorgulama();
            frm.ShowDialog();
        }

        // Müşteri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void musteriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.ShowDialog();
        }

        // Müşteri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.ShowDialog();
        }

        // Müşteri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void musteriGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.ShowDialog();
        }

        // Müşteri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void musteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.ShowDialog();
        }

        // Müşteri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void musteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.ShowDialog();
        }

        // Müşteri sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void musteriSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriSorgulama frm = new FrmMusteriSorgulama();
            frm.ShowDialog();
        }

        // Hizmet ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void hizmetİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHizmet frm = new FrmHizmet();
            frm.ShowDialog();
        }

        // Hizmet ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void hizmetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHizmet frm = new FrmHizmet();
            frm.ShowDialog();
        }

        // Hizmet ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void hizmetGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHizmet frm = new FrmHizmet();
            frm.ShowDialog();
        }

        // Hizmet ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void hizmetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHizmet frm = new FrmHizmet();
            frm.ShowDialog();
        }

        // Hizmet ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void hizmetListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHizmet frm = new FrmHizmet();
            frm.ShowDialog();
        }

        // Hizmet sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void hizmetSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHizmetSorgulama frm = new FrmHizmetSorgulama();
            frm.ShowDialog();
        }

        // Tedarikçi ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void tedarikİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikciler frm = new FrmTedarikciler();
            frm.ShowDialog();
        }

        // Tedarikçi ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void tedarikçiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikciler frm = new FrmTedarikciler();
            frm.ShowDialog();
        }

        // Tedarikçi ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void tedarikciGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikciler frm = new FrmTedarikciler();
            frm.ShowDialog();
        }

        // Tedarikçi ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void tedarikciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikciler frm = new FrmTedarikciler();
            frm.ShowDialog();
        }

        // Tedarikçi ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void tedarikciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikciler frm = new FrmTedarikciler();
            frm.ShowDialog();
        }

        // Tedarikçi sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void tedarikçiSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikcilerSorgulama frm = new FrmTedarikcilerSorgulama();
            frm.ShowDialog();
        }

        // Demirbaş ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void demirbasİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar frm = new FrmDemirbaslar();
            frm.ShowDialog();
        }

        // Demirbaş ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void demirbasEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar frm = new FrmDemirbaslar();
            frm.ShowDialog();
        }

        // Demirbaş ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void demirbasGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar frm = new FrmDemirbaslar();
            frm.ShowDialog();
        }

        // Demirbaş ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void demirbasSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar frm = new FrmDemirbaslar();
            frm.ShowDialog();
        }

        // Demirbaş ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void demirbasListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar frm = new FrmDemirbaslar();
            frm.ShowDialog();
        }

        // Demirbaş sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void demirbasSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDemirbaslarSorgulama frm = new FrmDemirbaslarSorgulama();
            frm.ShowDialog();
        }

        // Gider ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void giderİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.ShowDialog();
        }

        // Gider ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.ShowDialog();
        }

        // Gider ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void giderGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.ShowDialog();
        }

        // Gider ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void giderSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.ShowDialog();
        }

        // Gider ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void giderListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.ShowDialog();
        }

        // Gider sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void giderSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderlerSorgulama frm = new FrmGiderlerSorgulama();
            frm.ShowDialog();
        }

        // Ürün ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void urunİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        // Ürün ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        // Ürün ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void urunGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        // Ürün ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void urunSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        // Ürün ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void urunListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        // Ürün sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void urunSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunlerSorgulama frm = new FrmUrunlerSorgulama();
            frm.ShowDialog();
        }

        // Stok hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void stokİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
        }

        // Stok hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
        }

        // Stok hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void stokGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
        }

        // Stok hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void stokSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
        }

        // Stok hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void stokListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
        }

        // Stok hareketleri sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void stokSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleriSorgulama frm = new FrmStokHareketleriSorgulama();
            frm.ShowDialog();
        }

        // Satış ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatislar frm = new FrmSatislar();
            frm.ShowDialog();
        }

        // Satış ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void satışEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatislar frm = new FrmSatislar();
            frm.ShowDialog();
        }

        // Satış ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void satışGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatislar frm = new FrmSatislar();
            frm.ShowDialog();
        }

        // Satış ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void satışSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatislar frm = new FrmSatislar();
            frm.ShowDialog();
        }

        // Satış ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void satışListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatislar frm = new FrmSatislar();
            frm.ShowDialog();
        }

        // Satış sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void satışSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatislarSorgulama frm = new FrmSatislarSorgulama();
            frm.ShowDialog();
        }

        // Kasa hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void kasaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.ShowDialog();
        }

        // Kasa hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void kasaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.ShowDialog();
        }

        // Kasa hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void kasaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.ShowDialog();
        }

        // Kasa hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void kasaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.ShowDialog();
        }

        // Kasa hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void kasaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.ShowDialog();
        }

        // Kasa hareketleri sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void kasaSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleriSorgulama frm = new FrmKasaHareketleriSorgulama();
            frm.ShowDialog();
        }

        // İzin/puantaj ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void izinPuantajİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinPuantaj frm = new FrmIzinPuantaj();
            frm.ShowDialog();
        }

        // İzin/puantaj ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void izinPuantajEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinPuantaj frm = new FrmIzinPuantaj();
            frm.ShowDialog();
        }

        // İzin/puantaj ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void izinPuantajGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinPuantaj frm = new FrmIzinPuantaj();
            frm.ShowDialog();
        }

        // İzin/puantaj ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void izinPuantajSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinPuantaj frm = new FrmIzinPuantaj();
            frm.ShowDialog();
        }

        // İzin/puantaj ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void izinPuantajListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinPuantaj frm = new FrmIzinPuantaj();
            frm.ShowDialog();
        }

        // İzin/puantaj sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void izinPuantajSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzinPuantajSorgulama frm = new FrmIzinPuantajSorgulama();
            frm.ShowDialog();
        }

        // Randevu ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void randevuİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevu frm = new FrmRandevu();
            frm.ShowDialog();
        }

        // Randevu ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevu frm = new FrmRandevu();
            frm.ShowDialog();
        }

        // Randevu ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void randevuGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevu frm = new FrmRandevu();
            frm.ShowDialog();
        }

        // Randevu ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void randevuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevu frm = new FrmRandevu();
            frm.ShowDialog();
        }

        // Randevu ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void randevuListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevu frm = new FrmRandevu();
            frm.ShowDialog();
        }

        // Randevu sorgulama penceresini açar; kullanıcı bu ekranda filtreli arama yapıp kayıtları sorgular.
        private void randevuSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRandevuSorgulama frm = new FrmRandevuSorgulama();
            frm.ShowDialog();
        }

        // Muhasebe ve stok işlemleri panelini açar; kasa, stok ve finansal hareketler bu ekranda birlikte izlenir.
        private void muhasebeStokGenelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMuhasebeStokIslemleri frm = new FrmMuhasebeStokIslemleri();
            frm.ShowDialog();
        }

        // Kasa hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void muhasebeStokKasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.ShowDialog();
        }

        // Stok hareketleri ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void muhasebeStokStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
        }

        // Gider ekranını açar; ekleme, silme, güncelleme ve listeleme işlemleri bu formdaki araç çubuğundan yapılır.
        private void muhasebeStokGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.ShowDialog();
        }

        // Menü çubuğunda tıklanan öğeyi yakalar; gerektiğinde seçilen menü komutuna göre ilgili işlem akışını başlatır.
        private void menuStripAna_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Personel raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelRaporu frm = new PersonelRaporu();
            frm.ShowDialog();
        }

        // Müşteri raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void müşteriRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriRaporu frm = new MusteriRaporu();
            frm.ShowDialog();
        }

        // Tedarikçi raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void tedarikçiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciRaporu frm = new TedarikciRaporu();
            frm.ShowDialog();
        }

        // Demirbaş raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void demirbaşlarRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemirbaslarRaporu frm = new DemirbaslarRaporu();
            frm.ShowDialog();
        }

        // Gider raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void giderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderlerRaporu frm = new GiderlerRaporu();
            frm.ShowDialog();
        }

        // Ürün raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void ürünRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunlerRaporu frm = new UrunlerRaporu();
            frm.ShowDialog();
        }

        // Stok hareketleri raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void stokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokHareketleriRaporu frm = new StokHareketleriRaporu();
            frm.ShowDialog();
        }

        // Satış raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatislarRaporu frm = new SatislarRaporu();
            frm.ShowDialog();
        }

        // Kasa hareketleri raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void kasaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasaHareketleriRaporu frm = new KasaHareketleriRaporu();
            frm.ShowDialog();
        }

        // İzin/puantaj raporu penceresini açar; rapor açılışta ortak veritabanından güncel kayıtları yükler.
        private void izinPuantajRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzinRaporu frm = new IzinRaporu();
            frm.ShowDialog();
        }
    }
}
