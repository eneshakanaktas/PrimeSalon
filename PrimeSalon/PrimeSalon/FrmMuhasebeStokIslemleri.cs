using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeSalon
{
    public partial class FrmMuhasebeStokIslemleri : Form
    {
        // Muhasebe ve stok ekranını başlatır; üst işlem araç çubuğunu ilgili modül kısayollarıyla kurar.
        public FrmMuhasebeStokIslemleri()
        {
            InitializeComponent();
            IslemMenusuHazirla();
        }

        // Muhasebe ve stok işlemleri tablosundaki güncel kayıtları veritabanından çeker ve sonuçları dgvTumHareketler üzerinde listeler.
        public void KayitListele()
        {
            try
            {
                FrmPersonel.BaglantiAc();
                MuhasebeServisi.SemayiHazirla(FrmPersonel.Baglanti);

                dgvTumHareketler.DataSource = VeriGetir(TumHareketlerSorgusu());
                dgvKasaHareketleri.DataSource = VeriGetir(KasaHareketleriSorgusu());
                dgvStokHareketleri.DataSource = VeriGetir(StokHareketleriSorgusu());
                dgvFinansalKaynaklar.DataSource = VeriGetir(FinansalKaynaklarSorgusu());

                OzetleriGuncelle();
                GridleriDuzenle();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Muhasebe ve Stok İşlemleri Hata Penceresi");
            }
            finally
            {
                if (FrmPersonel.Baglanti.State == ConnectionState.Open)
                    FrmPersonel.Baglanti.Close();
            }
        }

        // Gönderilen SQL sorgusunu mevcut bağlantıyla çalıştırır ve sonucu DataTable olarak listeleme kontrollerine döndürür.
        private DataTable VeriGetir(string sorgu)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter(sorgu, FrmPersonel.Baglanti))
            {
                da.Fill(dt);
            }

            return dt;
        }

        // Kasa bakiyesi, tahsilat, ödeme ve stok hareketi özetlerini güncel veritabanı değerleriyle hesaplayıp ekrandaki etiketlere yazar.
        private void OzetleriGuncelle()
        {
            lblKasaBakiye.Text = "Kasa Bakiye: " + ParaDegeri(OzetDegeri(@"
SELECT ISNULL((
    SELECT SUM(SonBakiye)
    FROM
    (
        SELECT
            BakiyeSonra AS SonBakiye,
            ROW_NUMBER() OVER (
                PARTITION BY ISNULL(NULLIF(LTRIM(RTRIM(KasaAdi)), N''), N'Ana Kasa')
                ORDER BY KasaHareketID DESC
            ) AS Sira
        FROM KasaHareketleri
    ) KasaSonlari
    WHERE Sira = 1
), 0)"));

            lblTahsilat.Text = "Tahsilat: " + ParaDegeri(OzetDegeri("SELECT ISNULL(SUM(Tutar), 0) FROM KasaHareketleri WHERE IslemTipi=N'Tahsilat'"));
            lblOdeme.Text = "\u00d6deme: " + ParaDegeri(OzetDegeri("SELECT ISNULL(SUM(Tutar), 0) FROM KasaHareketleri WHERE IslemTipi=N'\u00d6deme'"));
            lblStokHareket.Text = "Stok Hareket: " + TamSayiDegeri("SELECT COUNT(*) FROM StokHareketleri");
            lblSonGuncelleme.Text = "Son G\u00fcncelleme: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        // Tek hücre döndüren SQL özet sorgusunu çalıştırır; boş sonuçları sıfır kabul ederek decimal değer döndürür.
        private decimal OzetDegeri(string sorgu)
        {
            using (SqlCommand komut = new SqlCommand(sorgu, FrmPersonel.Baglanti))
            {
                object sonuc = komut.ExecuteScalar();
                return sonuc == null || sonuc == DBNull.Value ? 0 : Convert.ToDecimal(sonuc);
            }
        }

        // Sayaç amaçlı SQL sorgusunu çalıştırır; sonucu tam sayıya çevirip ekranda gösterilecek metne dönüştürür.
        private string TamSayiDegeri(string sorgu)
        {
            using (SqlCommand komut = new SqlCommand(sorgu, FrmPersonel.Baglanti))
            {
                object sonuc = komut.ExecuteScalar();
                return Convert.ToInt32(sonuc == null || sonuc == DBNull.Value ? 0 : sonuc).ToString();
            }
        }

        // Decimal tutarları iki basamaklı para görünümüne çevirerek özet etiketlerinde okunabilir hale getirir.
        private string ParaDegeri(decimal deger)
        {
            return deger.ToString("N2");
        }

        // Muhasebe ve stok ekranındaki tüm gridleri salt okunur, tek satır seçilebilir ve düzenli sütun görünümüne göre ayarlar.
        private void GridleriDuzenle()
        {
            GridDuzenle(dgvTumHareketler);
            GridDuzenle(dgvKasaHareketleri);
            GridDuzenle(dgvStokHareketleri);
            GridDuzenle(dgvFinansalKaynaklar);
        }

        // Verilen DataGridView kontrolünün satır seçimi, sütun boyutu ve gizli sıralama kolonları gibi ortak görünüm ayarlarını yapar.
        private void GridDuzenle(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grid.RowHeadersVisible = false;
            grid.BackgroundColor = Color.White;

            if (grid.Columns.Contains("SiraTarihi"))
                grid.Columns["SiraTarihi"].Visible = false;
            if (grid.Columns.Contains("SiraKasaID"))
                grid.Columns["SiraKasaID"].Visible = false;
            if (grid.Columns.Contains("SiraKayitID"))
                grid.Columns["SiraKayitID"].Visible = false;
        }

        // Muhasebe/stok araç çubuğunu temizler; yenileme ve modül geçiş düğmelerini sırayla ekler.
        private void IslemMenusuHazirla()
        {
            toolStripIslemler.Items.Clear();

            MenuButonuEkle("Yenile", 90, delegate { KayitListele(); });
            MenuAyiriciEkle();
            MenuButonuEkle("Personel", 95, delegate { PersonelFormAc(); });
            MenuButonuEkle("Müşteri", 90, delegate { MusteriFormAc(); });
            MenuButonuEkle("Hizmet", 85, delegate { HizmetFormAc(); });
            MenuButonuEkle("Demirbaş", 95, delegate { DemirbasFormAc(); });
            MenuButonuEkle("Giderler", 90, delegate { GiderlerFormAc(); });
            MenuButonuEkle("Ürünler", 85, delegate { UrunlerFormAc(); });
            MenuButonuEkle("Stok Hareketleri", 135, delegate { StokHareketleriFormAc(); });
            MenuButonuEkle("Satışlar", 85, delegate { SatislarFormAc(); });
            MenuButonuEkle("Kasa Hareketleri", 135, delegate { KasaHareketleriFormAc(); });
            MenuButonuEkle("İzin / Puantaj", 120, delegate { IzinPuantajFormAc(); });
            MenuButonuEkle("Randevu", 90, delegate { RandevuFormAc(); });
        }

        // Araç çubuğuna sabit genişlikte bir işlem düğmesi ekler ve tıklama olayını gönderilen metoda bağlar.
        private void MenuButonuEkle(string metin, int genislik, EventHandler tiklama)
        {
            ToolStripButton buton = new ToolStripButton(metin);
            buton.AutoSize = false;
            buton.Size = new Size(genislik, 25);
            buton.ImageTransparentColor = Color.Magenta;
            buton.Click += tiklama;
            toolStripIslemler.Items.Add(buton);
        }

        // Araç çubuğundaki işlem gruplarını görsel olarak ayırmak için ToolStripSeparator ekler.
        private void MenuAyiriciEkle()
        {
            toolStripIslemler.Items.Add(new ToolStripSeparator());
        }

        // Muhasebe ve stok işlemleri ekranında listelenecek verileri üreten SQL sorgu metnini hazırlar ve çağıran metoda döndürür.
        private string TumHareketlerSorgusu()
        {
            return @"
SELECT
    CASE
        WHEN KH.KaynakTablo=N'Personel' THEN N'Maaş Ödemesi'
        WHEN KH.KaynakTablo=N'Hizmet' THEN N'Hizmet Tahsilatı'
        WHEN KH.KaynakTablo=N'Randevu' THEN N'Randevu Tahsilatı'
        WHEN KH.KaynakTablo=N'Demirbaslar' THEN N'Demirbaş Gideri'
        WHEN KH.KaynakTablo=N'Giderler' THEN N'Gider Ödemesi'
        WHEN KH.KaynakTablo=N'Satislar' AND KH.IslemTipi=N'Ödeme' THEN N'Satış İadesi'
        WHEN KH.KaynakTablo=N'Satislar' THEN N'Satış Tahsilatı'
        ELSE ISNULL(KH.IslemKategorisi, N'Kasa Hareketi')
    END AS HareketTuru,
    KH.KasaHareketID AS HareketID,
    KH.Tarih,
    KH.IslemTipi,
    KH.IslemKategorisi AS Kategori,
    KH.Tutar,
    CAST(NULL AS INT) AS Miktar,
    KH.KasaAdi AS Yer,
    KH.BakiyeOnce AS OncekiDeger,
    KH.BakiyeSonra AS SonrakiDeger,
    KH.KaynakTablo,
    KH.KaynakID,
    KH.Aciklama,
    KH.KasaHareketID AS SiraKasaID,
    KH.KasaHareketID AS SiraKayitID,
    KH.Tarih AS SiraTarihi
FROM KasaHareketleri KH
WHERE KH.KaynakTablo IS NULL
   OR KH.KaynakID IS NULL
   OR KH.KasaHareketID = (
        SELECT MAX(KH2.KasaHareketID)
        FROM KasaHareketleri KH2
        WHERE KH2.KaynakTablo = KH.KaynakTablo
          AND KH2.KaynakID = KH.KaynakID
   )
UNION ALL
SELECT
    CASE
        WHEN SH.IslemTipi=N'Giriş' THEN N'Stok Girişi'
        WHEN SH.IslemTipi=N'Çıkış' THEN N'Stok Çıkışı'
        ELSE N'Stok Hareketi'
    END AS HareketTuru,
    SH.HareketID,
    SH.Tarih,
    SH.IslemTipi,
    ISNULL(U.UrunAdi, 'UrunID: ' + CAST(SH.UrunID AS NVARCHAR(20))) AS Kategori,
    SH.ToplamTutar AS Tutar,
    SH.Miktar,
    SH.Depo AS Yer,
    CAST(SH.OncekiStok AS DECIMAL(18,2)) AS OncekiDeger,
    CAST(SH.SonrakiStok AS DECIMAL(18,2)) AS SonrakiDeger,
    'StokHareketleri' AS KaynakTablo,
    SH.HareketID AS KaynakID,
    SH.Aciklama,
    0 AS SiraKasaID,
    SH.HareketID AS SiraKayitID,
    SH.Tarih AS SiraTarihi
FROM StokHareketleri SH
LEFT JOIN Urunler U ON U.UrunID = SH.UrunID
ORDER BY SiraKasaID DESC, SiraKayitID DESC, SiraTarihi DESC, HareketID DESC";
        }

        // Muhasebe ve stok işlemleri ekranında listelenecek verileri üreten SQL sorgu metnini hazırlar ve çağıran metoda döndürür.
        private string KasaHareketleriSorgusu()
        {
            return @"
SELECT
    KasaHareketID,
    CASE
        WHEN KaynakTablo=N'Personel' THEN N'Maaş Ödemesi'
        WHEN KaynakTablo=N'Hizmet' THEN N'Hizmet Tahsilatı'
        WHEN KaynakTablo=N'Randevu' THEN N'Randevu Tahsilatı'
        WHEN KaynakTablo=N'Demirbaslar' THEN N'Demirbaş Gideri'
        WHEN KaynakTablo=N'Giderler' THEN N'Gider Ödemesi'
        WHEN KaynakTablo=N'Satislar' AND IslemTipi=N'Ödeme' THEN N'Satış İadesi'
        WHEN KaynakTablo=N'Satislar' THEN N'Satış Tahsilatı'
        ELSE ISNULL(IslemKategorisi, N'Kasa Hareketi')
    END AS HareketTuru,
    Tarih,
    IslemTipi,
    IslemKategorisi,
    Tutar,
    OdemeTipi,
    KasaAdi,
    BakiyeOnce,
    BakiyeSonra,
    KaynakTablo,
    KaynakID,
    Aciklama,
    MusteriID,
    TedarikciID,
    PersonelID,
    IslemiYapan
FROM KasaHareketleri KH
WHERE KH.KaynakTablo IS NULL
   OR KH.KaynakID IS NULL
   OR KH.KasaHareketID = (
        SELECT MAX(KH2.KasaHareketID)
        FROM KasaHareketleri KH2
        WHERE KH2.KaynakTablo = KH.KaynakTablo
          AND KH2.KaynakID = KH.KaynakID
   )
ORDER BY KasaHareketID DESC";
        }

        // Muhasebe ve stok işlemleri ekranında listelenecek verileri üreten SQL sorgu metnini hazırlar ve çağıran metoda döndürür.
        private string StokHareketleriSorgusu()
        {
            return @"
SELECT
    SH.HareketID,
    CASE
        WHEN SH.IslemTipi=N'Giriş' THEN N'Stok Girişi'
        WHEN SH.IslemTipi=N'Çıkış' THEN N'Stok Çıkışı'
        ELSE N'Stok Hareketi'
    END AS HareketTuru,
    SH.UrunID,
    ISNULL(U.UrunAdi, 'UrunID: ' + CAST(SH.UrunID AS NVARCHAR(20))) AS UrunAdi,
    SH.Tarih,
    SH.IslemTipi,
    SH.Miktar,
    SH.BirimFiyat,
    SH.ToplamTutar,
    SH.OncekiStok,
    SH.SonrakiStok,
    SH.AktifMi,
    SH.Depo,
    SH.Kullanici,
    SH.Aciklama
FROM StokHareketleri SH
LEFT JOIN Urunler U ON U.UrunID = SH.UrunID
ORDER BY SH.HareketID DESC";
        }

        // Muhasebe ve stok işlemleri ekranında listelenecek verileri üreten SQL sorgu metnini hazırlar ve çağıran metoda döndürür.
        private string FinansalKaynaklarSorgusu()
        {
            return @"
SELECT
    KaynakTablo,
    KaynakID,
    Tarih,
    HareketTuru,
    Kategori,
    IslemTipi,
    Tutar,
    Miktar,
    Aciklama,
    KasaEtkisi
FROM (" + FinansalKaynaklarCekirdekSorgusu() + @") FK
OUTER APPLY (
    SELECT MAX(KH.KasaHareketID) AS SonKasaHareketID
    FROM KasaHareketleri KH
    WHERE KH.KaynakTablo = FK.KaynakTablo
      AND KH.KaynakID = FK.KaynakID
) KS
ORDER BY ISNULL(KS.SonKasaHareketID, 0) DESC, KaynakID DESC, Tarih DESC, KaynakTablo";
        }

        // Muhasebe ve stok işlemleri ekranında listelenecek verileri üreten SQL sorgu metnini hazırlar ve çağıran metoda döndürür.
        private string FinansalKaynaklarCekirdekSorgusu()
        {
            return @"
SELECT
    N'Personel' AS KaynakTablo,
    PersonelID AS KaynakID,
    IseGirisTarihi AS Tarih,
    CASE WHEN Aktif=1 AND ISNULL(Maas, 0)>0 THEN N'Maaş Ödemesi' ELSE N'Personel Maaş Bilgisi' END AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(Pozisyon)), N''), N'Personel') AS Kategori,
    CASE WHEN Aktif=1 THEN N'Ödeme' ELSE N'Pasif' END AS IslemTipi,
    CAST(ISNULL(Maas, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(NULL AS DECIMAL(18,2)) AS Miktar,
    LTRIM(RTRIM(ISNULL(Ad, '') + ' ' + ISNULL(Soyad, ''))) AS Aciklama,
    CASE WHEN Aktif=1 AND ISNULL(Maas, 0)>0 THEN N'Kasa Ödeme' ELSE N'Kasa Yok' END AS KasaEtkisi
FROM Personel
UNION ALL
SELECT
    N'Hizmet' AS KaynakTablo,
    HizmetID AS KaynakID,
    CAST(NULL AS DATETIME) AS Tarih,
    CASE WHEN Aktif=1 AND ISNULL(Ucret, 0)>0 THEN N'Hizmet Tahsilatı' ELSE N'Hizmet Ücret Tanımı' END AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(Kategori)), N''), N'Hizmet') AS Kategori,
    CASE WHEN Aktif=1 THEN N'Tahsilat' ELSE N'Pasif' END AS IslemTipi,
    CAST(ISNULL(Ucret, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(ISNULL(SureDakika, 0) AS DECIMAL(18,2)) AS Miktar,
    ISNULL(HizmetAdi, '') AS Aciklama,
    CASE WHEN Aktif=1 AND ISNULL(Ucret, 0)>0 THEN N'Kasa Tahsilat' ELSE N'Kasa Yok' END AS KasaEtkisi
FROM Hizmet
UNION ALL
SELECT
    N'Randevu' AS KaynakTablo,
    RandevuID AS KaynakID,
    RandevuTarih AS Tarih,
    CASE WHEN OdemeDurumu=N'Ödendi' AND ISNULL(ToplamTutar, 0)>0 THEN N'Randevu Tahsilatı' ELSE N'Randevu Ödeme Durumu' END AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(Durum)), N''), N'Randevu') AS Kategori,
    ISNULL(OdemeDurumu, '') AS IslemTipi,
    CAST(ISNULL(ToplamTutar, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(ISNULL(SureDakika, 0) AS DECIMAL(18,2)) AS Miktar,
    ISNULL(Notlar, '') AS Aciklama,
    CASE WHEN OdemeDurumu=N'Ödendi' AND ISNULL(ToplamTutar, 0)>0 THEN N'Kasa Tahsilat' ELSE N'Kasa Yok' END AS KasaEtkisi
FROM Randevu
UNION ALL
SELECT
    N'Musteri' AS KaynakTablo,
    MusteriID AS KaynakID,
    KayitTarihi AS Tarih,
    N'Müşteri Borcu' AS HareketTuru,
    N'Müşteri Borç' AS Kategori,
    N'Borç' AS IslemTipi,
    CAST(ISNULL(Borc, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(NULL AS DECIMAL(18,2)) AS Miktar,
    LTRIM(RTRIM(ISNULL(Ad, '') + ' ' + ISNULL(Soyad, ''))) AS Aciklama,
    N'Kasa Yok' AS KasaEtkisi
FROM Musteri
UNION ALL
SELECT
    N'Musteri' AS KaynakTablo,
    MusteriID AS KaynakID,
    KayitTarihi AS Tarih,
    N'Müşteri Harcaması' AS HareketTuru,
    N'Müşteri Harcama' AS Kategori,
    N'Toplam Harcama' AS IslemTipi,
    CAST(ISNULL(ToplamHarcama, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(NULL AS DECIMAL(18,2)) AS Miktar,
    LTRIM(RTRIM(ISNULL(Ad, '') + ' ' + ISNULL(Soyad, ''))) AS Aciklama,
    N'Kasa Yok' AS KasaEtkisi
FROM Musteri
UNION ALL
SELECT
    N'Urunler' AS KaynakTablo,
    UrunID AS KaynakID,
    EklenmeTarihi AS Tarih,
    N'Ürün Alış Fiyatı' AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(Kategori)), N''), N'Ürün') AS Kategori,
    N'Alış Fiyatı' AS IslemTipi,
    CAST(ISNULL(AlisFiyat, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(ISNULL(MevcutStok, 0) AS DECIMAL(18,2)) AS Miktar,
    ISNULL(UrunAdi, '') AS Aciklama,
    N'Stok Hareketinde Etkiler' AS KasaEtkisi
FROM Urunler
UNION ALL
SELECT
    N'Urunler' AS KaynakTablo,
    UrunID AS KaynakID,
    EklenmeTarihi AS Tarih,
    N'Ürün Satış Fiyatı' AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(Kategori)), N''), N'Ürün') AS Kategori,
    N'Satış Fiyatı' AS IslemTipi,
    CAST(ISNULL(SatisFiyat, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(ISNULL(MevcutStok, 0) AS DECIMAL(18,2)) AS Miktar,
    ISNULL(UrunAdi, '') AS Aciklama,
    N'Satışta Etkiler' AS KasaEtkisi
FROM Urunler
UNION ALL
SELECT
    N'IzinPuantaj' AS KaynakTablo,
    KayitID AS KaynakID,
    Tarih,
    N'Maaş Kesintisi' AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(IzinTuru)), N''), N'Personel Kesinti') AS Kategori,
    ISNULL(IslemTipi, '') AS IslemTipi,
    CAST(ISNULL(KesintiTutar, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(ISNULL(ToplamSaat, 0) AS DECIMAL(18,2)) AS Miktar,
    ISNULL(Aciklama, '') AS Aciklama,
    N'Maaş Kesintisi' AS KasaEtkisi
FROM IzinPuantaj
UNION ALL
SELECT
    N'Demirbaslar' AS KaynakTablo,
    DemirbasID AS KaynakID,
    AlimTarihi AS Tarih,
    CASE WHEN Aktif=1 AND ISNULL(AlimFiyati, 0)>0 THEN N'Demirbaş Gideri' ELSE N'Demirbaş Bilgisi' END AS HareketTuru,
    ISNULL(NULLIF(LTRIM(RTRIM(Kategori)), N''), N'Demirbaş') AS Kategori,
    CASE WHEN Aktif=1 THEN N'Ödeme' ELSE N'Pasif' END AS IslemTipi,
    CAST(ISNULL(AlimFiyati, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(NULL AS DECIMAL(18,2)) AS Miktar,
    ISNULL(DemirbasAdi, '') AS Aciklama,
    CASE WHEN Aktif=1 AND ISNULL(AlimFiyati, 0)>0 THEN N'Kasa Ödeme' ELSE N'Kasa Yok' END AS KasaEtkisi
FROM Demirbaslar
UNION ALL
SELECT
    N'Giderler' AS KaynakTablo,
    GiderID AS KaynakID,
    Tarih,
    CASE WHEN Aktif=1 AND ISNULL(Tutar, 0)>0 THEN N'Gider Ödemesi' ELSE N'Gider Bilgisi' END AS HareketTuru,
    ISNULL(GiderTuru, N'Gider') AS Kategori,
    CASE WHEN Aktif=1 THEN N'Ödeme' ELSE N'Pasif' END AS IslemTipi,
    CAST(ISNULL(Tutar, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(NULL AS DECIMAL(18,2)) AS Miktar,
    ISNULL(Aciklama, '') AS Aciklama,
    CASE WHEN Aktif=1 AND ISNULL(Tutar, 0)>0 THEN N'Kasa Ödeme' ELSE N'Kasa Yok' END AS KasaEtkisi
FROM Giderler
UNION ALL
SELECT
    N'Satislar' AS KaynakTablo,
    SatisID AS KaynakID,
    Tarih,
    CASE WHEN IadeMi=1 THEN N'Satış İadesi'
         WHEN OdemeDurumu=N'Ödendi' THEN N'Satış Tahsilatı'
         ELSE N'Satış Kaydı' END AS HareketTuru,
    ISNULL(SatisTipi, N'Satış') AS Kategori,
    CASE WHEN IadeMi=1 THEN N'İade' ELSE ISNULL(OdemeDurumu, '') END AS IslemTipi,
    CAST(ISNULL(GenelToplam, 0) AS DECIMAL(18,2)) AS Tutar,
    CAST(NULL AS DECIMAL(18,2)) AS Miktar,
    ISNULL(Aciklama, '') AS Aciklama,
    CASE WHEN OdemeDurumu=N'Ödendi' AND IadeMi=1 THEN N'Kasa Ödeme'
         WHEN OdemeDurumu=N'Ödendi' THEN N'Kasa Tahsilat'
         ELSE N'Kasa Yok' END AS KasaEtkisi
FROM Satislar";
        }

        // Muhasebe ve stok işlemleri formu açılırken varsayılan seçimleri ayarlar, gerekli tanım listelerini yükler ve ekrandaki kayıt listesini doldurur.
        private void FrmMuhasebeStokIslemleri_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Muhasebe ve stok işlemleri formu tekrar etkinleştiğinde tanım/kayıt listesini yeniden okuyarak ekrandaki veriyi güncel tutar.
        private void FrmMuhasebeStokIslemleri_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Muhasebe ve stok işlemleri listeleme düğmesinde veritabanındaki güncel kayıtları yeniden okuyup grid listesini tazeler.
        private void tsbYenile_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        // Araç çubuğundaki kısayol düğmesi ilgili hareket formunu açar; dönüşte muhasebe ve stok özetlerini yeniler.
        private void tsbKasaHareketleri_Click(object sender, EventArgs e)
        {
            KasaHareketleriFormAc();
        }

        // Araç çubuğundaki kısayol düğmesi ilgili hareket formunu açar; dönüşte muhasebe ve stok özetlerini yeniler.
        private void tsbStokHareketleri_Click(object sender, EventArgs e)
        {
            StokHareketleriFormAc();
        }

        // Araç çubuğundaki kısayol düğmesi ilgili hareket formunu açar; dönüşte muhasebe ve stok özetlerini yeniler.
        private void tsbGiderler_Click(object sender, EventArgs e)
        {
            GiderlerFormAc();
        }

        // Gönderilen kaynak formunu güvenli şekilde açar; form kapandıktan sonra hareket listelerini ve özet bilgilerini mutlaka yeniler.
        private void KaynakFormAc(Action formAc)
        {
            try
            {
                formAc();
            }
            finally
            {
                KayitListele();
            }
        }

        // Muhasebe/stok panelinden personel formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void PersonelFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmPersonel frm = new FrmPersonel();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden müşteri formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void MusteriFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmMusteri frm = new FrmMusteri();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden hizmet formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void HizmetFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmHizmet frm = new FrmHizmet();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden demirbaş formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void DemirbasFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmDemirbaslar frm = new FrmDemirbaslar();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden gider formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void GiderlerFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmGiderler frm = new FrmGiderler();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden ürün formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void UrunlerFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmUrunler frm = new FrmUrunler();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden stok hareketi formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void StokHareketleriFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmStokHareketleri frm = new FrmStokHareketleri();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden satış formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void SatislarFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmSatislar frm = new FrmSatislar();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden kasa hareketi formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void KasaHareketleriFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmKasaHareketleri frm = new FrmKasaHareketleri();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden izin/puantaj formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void IzinPuantajFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmIzinPuantaj frm = new FrmIzinPuantaj();
                frm.ShowDialog();
            });
        }

        // Muhasebe/stok panelinden randevu formunu açar; form kapandıktan sonra hareket listeleri ve özet bilgileri yeniler.
        private void RandevuFormAc()
        {
            KaynakFormAc(delegate
            {
                FrmRandevu frm = new FrmRandevu();
                frm.ShowDialog();
            });
        }
    }
}
