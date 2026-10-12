using System;
using System.Data;
using System.Data.SqlClient;

namespace PrimeSalon
{
    public static class MuhasebeServisi
    {
        private const string VarsayilanKasaAdi = "Ana Kasa";
        private const string SistemKullanicisi = "Sistem";

        public static void SemayiHazirla(SqlConnection baglanti)
        {
            bool mevcutStokKolonuVar = KolonVarMi(baglanti, "Urunler", "MevcutStok");

            ExecuteNonQuery(baglanti, @"
IF COL_LENGTH('Urunler', 'MevcutStok') IS NULL
    ALTER TABLE Urunler ADD MevcutStok INT NOT NULL CONSTRAINT DF_Urunler_MevcutStok DEFAULT(0);");

            ExecuteNonQuery(baglanti, @"
IF COL_LENGTH('KasaHareketleri', 'KaynakTablo') IS NULL
    ALTER TABLE KasaHareketleri ADD KaynakTablo NVARCHAR(50) NULL;");

            ExecuteNonQuery(baglanti, @"
IF COL_LENGTH('KasaHareketleri', 'KaynakID') IS NULL
    ALTER TABLE KasaHareketleri ADD KaynakID INT NULL;");

            ExecuteNonQuery(baglanti, @"
IF COL_LENGTH('KasaHareketleri', 'IslemKategorisi') IS NOT NULL
   AND COL_LENGTH('KasaHareketleri', 'IslemKategorisi') < 200
    ALTER TABLE KasaHareketleri ALTER COLUMN IslemKategorisi NVARCHAR(100) NULL;");

            if (!mevcutStokKolonuVar)
                StoklariHareketlerdenOlustur(baglanti);

            KasaHareketKategoriKaynaklardanGuncelle(baglanti);
            TekrarlayanKaynakKasaHareketleriniTemizle(baglanti);
            KasaBakiyeleriniYenidenHesapla(baglanti);
        }

        public static int StokHareketiEkle(
            SqlConnection baglanti,
            int urunID,
            DateTime tarih,
            string islemTipi,
            int miktar,
            decimal birimFiyat,
            decimal toplamTutar,
            string aciklama,
            string kullanici,
            int istenenOncekiStok,
            int istenenSonrakiStok,
            bool aktifMi,
            string depo)
        {
            SemayiHazirla(baglanti);

            int mevcutStok;
            bool urunVar = TryMevcutStokGetir(baglanti, urunID, out mevcutStok);
            int oncekiStok = urunVar ? mevcutStok : istenenOncekiStok;
            int sonrakiStok = aktifMi && urunVar ? SonrakiStokHesapla(islemTipi, oncekiStok, miktar, istenenSonrakiStok) : istenenSonrakiStok;
            StokNegatifKontrol(sonrakiStok);

            string sorgu = @"INSERT INTO StokHareketleri
                (UrunID, Tarih, IslemTipi, Miktar, BirimFiyat, ToplamTutar, Aciklama, Kullanici, OncekiStok, SonrakiStok, AktifMi, Depo)
                OUTPUT INSERTED.HareketID
                VALUES
                (@UrunID, @Tarih, @IslemTipi, @Miktar, @BirimFiyat, @ToplamTutar, @Aciklama, @Kullanici, @OncekiStok, @SonrakiStok, @AktifMi, @Depo)";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@UrunID", urunID);
                komut.Parameters.AddWithValue("@Tarih", tarih);
                komut.Parameters.AddWithValue("@IslemTipi", islemTipi);
                komut.Parameters.AddWithValue("@Miktar", miktar);
                komut.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                komut.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);
                komut.Parameters.AddWithValue("@Kullanici", kullanici);
                komut.Parameters.AddWithValue("@OncekiStok", oncekiStok);
                komut.Parameters.AddWithValue("@SonrakiStok", sonrakiStok);
                komut.Parameters.AddWithValue("@AktifMi", aktifMi);
                komut.Parameters.AddWithValue("@Depo", depo);

                int hareketID = Convert.ToInt32(komut.ExecuteScalar());
                if (aktifMi && urunVar)
                    UrunStokGuncelle(baglanti, urunID, sonrakiStok);
                return hareketID;
            }
        }

        public static void StokHareketiGuncelle(
            SqlConnection baglanti,
            int hareketID,
            int urunID,
            DateTime tarih,
            string islemTipi,
            int miktar,
            decimal birimFiyat,
            decimal toplamTutar,
            string aciklama,
            string kullanici,
            int istenenOncekiStok,
            int istenenSonrakiStok,
            bool aktifMi,
            string depo)
        {
            SemayiHazirla(baglanti);
            StokHareketEtkisiniGeriAl(baglanti, hareketID);

            int mevcutStok;
            bool urunVar = TryMevcutStokGetir(baglanti, urunID, out mevcutStok);
            int oncekiStok = urunVar ? mevcutStok : istenenOncekiStok;
            int sonrakiStok = aktifMi && urunVar ? SonrakiStokHesapla(islemTipi, oncekiStok, miktar, istenenSonrakiStok) : istenenSonrakiStok;
            StokNegatifKontrol(sonrakiStok);

            string sorgu = @"UPDATE StokHareketleri SET
                UrunID=@UrunID,
                Tarih=@Tarih,
                IslemTipi=@IslemTipi,
                Miktar=@Miktar,
                BirimFiyat=@BirimFiyat,
                ToplamTutar=@ToplamTutar,
                Aciklama=@Aciklama,
                Kullanici=@Kullanici,
                OncekiStok=@OncekiStok,
                SonrakiStok=@SonrakiStok,
                AktifMi=@AktifMi,
                Depo=@Depo
                WHERE HareketID=@HareketID";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@HareketID", hareketID);
                komut.Parameters.AddWithValue("@UrunID", urunID);
                komut.Parameters.AddWithValue("@Tarih", tarih);
                komut.Parameters.AddWithValue("@IslemTipi", islemTipi);
                komut.Parameters.AddWithValue("@Miktar", miktar);
                komut.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                komut.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);
                komut.Parameters.AddWithValue("@Kullanici", kullanici);
                komut.Parameters.AddWithValue("@OncekiStok", oncekiStok);
                komut.Parameters.AddWithValue("@SonrakiStok", sonrakiStok);
                komut.Parameters.AddWithValue("@AktifMi", aktifMi);
                komut.Parameters.AddWithValue("@Depo", depo);
                komut.ExecuteNonQuery();
            }

            if (aktifMi && urunVar)
                UrunStokGuncelle(baglanti, urunID, sonrakiStok);
        }

        public static bool StokHareketiSil(SqlConnection baglanti, int hareketID)
        {
            SemayiHazirla(baglanti);
            StokHareketEtkisiniGeriAl(baglanti, hareketID);

            using (SqlCommand komut = new SqlCommand("DELETE FROM StokHareketleri WHERE HareketID=@HareketID", baglanti))
            {
                komut.Parameters.AddWithValue("@HareketID", hareketID);
                return komut.ExecuteNonQuery() == 1;
            }
        }

        public static int KasaHareketiEkle(
            SqlConnection baglanti,
            DateTime tarih,
            string islemTipi,
            string islemKategorisi,
            decimal tutar,
            string odemeTipi,
            string aciklama,
            int musteriID,
            int tedarikciID,
            int personelID,
            string kasaAdi,
            string islemiYapan,
            string kaynakTablo,
            int kaynakID)
        {
            SemayiHazirla(baglanti);

            decimal bakiyeOnce = KasaBakiyesiGetir(baglanti, kasaAdi);
            decimal bakiyeSonra = bakiyeOnce + KasaDelta(islemTipi, tutar);

            string sorgu = @"INSERT INTO KasaHareketleri
                (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
                OUTPUT INSERTED.KasaHareketID
                VALUES
                (@Tarih, @IslemTipi, @IslemKategorisi, @Tutar, @OdemeTipi, @Aciklama, @MusteriID, @TedarikciID, @PersonelID, @KasaAdi, @BakiyeOnce, @BakiyeSonra, @IslemiYapan, @KaynakTablo, @KaynakID)";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@Tarih", tarih);
                komut.Parameters.AddWithValue("@IslemTipi", islemTipi);
                komut.Parameters.AddWithValue("@IslemKategorisi", MetinKirp(islemKategorisi, 100));
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@OdemeTipi", MetinKirp(odemeTipi, 20));
                komut.Parameters.AddWithValue("@Aciklama", MetinKirp(aciklama, 150));
                komut.Parameters.AddWithValue("@MusteriID", musteriID);
                komut.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@KasaAdi", MetinKirp(string.IsNullOrWhiteSpace(kasaAdi) ? VarsayilanKasaAdi : kasaAdi.Trim(), 30));
                komut.Parameters.AddWithValue("@BakiyeOnce", bakiyeOnce);
                komut.Parameters.AddWithValue("@BakiyeSonra", bakiyeSonra);
                komut.Parameters.AddWithValue("@IslemiYapan", MetinKirp(string.IsNullOrWhiteSpace(islemiYapan) ? SistemKullanicisi : islemiYapan.Trim(), 50));
                komut.Parameters.AddWithValue("@KaynakTablo", string.IsNullOrWhiteSpace(kaynakTablo) ? (object)DBNull.Value : MetinKirp(kaynakTablo, 50));
                komut.Parameters.AddWithValue("@KaynakID", kaynakID > 0 ? (object)kaynakID : DBNull.Value);

                int kasaHareketID = Convert.ToInt32(komut.ExecuteScalar());
                KasaBakiyeleriniYenidenHesapla(baglanti);
                return kasaHareketID;
            }
        }

        public static void KasaHareketiGuncelle(
            SqlConnection baglanti,
            int kasaHareketID,
            DateTime tarih,
            string islemTipi,
            string islemKategorisi,
            decimal tutar,
            string odemeTipi,
            string aciklama,
            int musteriID,
            int tedarikciID,
            int personelID,
            string kasaAdi,
            string islemiYapan)
        {
            SemayiHazirla(baglanti);

            string sorgu = @"UPDATE KasaHareketleri SET
                Tarih=@Tarih,
                IslemTipi=@IslemTipi,
                IslemKategorisi=@IslemKategorisi,
                Tutar=@Tutar,
                OdemeTipi=@OdemeTipi,
                Aciklama=@Aciklama,
                MusteriID=@MusteriID,
                TedarikciID=@TedarikciID,
                PersonelID=@PersonelID,
                KasaAdi=@KasaAdi,
                IslemiYapan=@IslemiYapan
                WHERE KasaHareketID=@KasaHareketID";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@KasaHareketID", kasaHareketID);
                komut.Parameters.AddWithValue("@Tarih", tarih);
                komut.Parameters.AddWithValue("@IslemTipi", islemTipi);
                komut.Parameters.AddWithValue("@IslemKategorisi", MetinKirp(islemKategorisi, 100));
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@OdemeTipi", MetinKirp(odemeTipi, 20));
                komut.Parameters.AddWithValue("@Aciklama", MetinKirp(aciklama, 150));
                komut.Parameters.AddWithValue("@MusteriID", musteriID);
                komut.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@KasaAdi", MetinKirp(string.IsNullOrWhiteSpace(kasaAdi) ? VarsayilanKasaAdi : kasaAdi.Trim(), 30));
                komut.Parameters.AddWithValue("@IslemiYapan", MetinKirp(string.IsNullOrWhiteSpace(islemiYapan) ? SistemKullanicisi : islemiYapan.Trim(), 50));
                komut.ExecuteNonQuery();
            }

            KasaBakiyeleriniYenidenHesapla(baglanti);
        }

        public static bool KasaHareketiSil(SqlConnection baglanti, int kasaHareketID)
        {
            SemayiHazirla(baglanti);

            using (SqlCommand komut = new SqlCommand("DELETE FROM KasaHareketleri WHERE KasaHareketID=@KasaHareketID", baglanti))
            {
                komut.Parameters.AddWithValue("@KasaHareketID", kasaHareketID);
                bool silindi = komut.ExecuteNonQuery() == 1;
                KasaBakiyeleriniYenidenHesapla(baglanti);
                return silindi;
            }
        }

        public static void KaynakKasaHareketleriniSil(SqlConnection baglanti, string kaynakTablo, int kaynakID)
        {
            SemayiHazirla(baglanti);

            using (SqlCommand komut = new SqlCommand("DELETE FROM KasaHareketleri WHERE KaynakTablo=@KaynakTablo AND KaynakID=@KaynakID", baglanti))
            {
                komut.Parameters.AddWithValue("@KaynakTablo", kaynakTablo);
                komut.Parameters.AddWithValue("@KaynakID", kaynakID);
                komut.ExecuteNonQuery();
            }

            KasaBakiyeleriniYenidenHesapla(baglanti);
        }

        public static void GiderKasaHareketiYaz(SqlConnection baglanti, int giderID, DateTime tarih, string giderTuru, decimal tutar, string odemeTipi, string aciklama, bool aktif)
        {
            KaynakKasaHareketleriniSil(baglanti, "Giderler", giderID);

            if (!aktif)
                return;

            KasaHareketiEkle(
                baglanti,
                tarih,
                "\u00d6deme",
                KategoriDegeri(giderTuru, "Gider"),
                tutar,
                odemeTipi,
                "Gider: " + aciklama,
                0,
                0,
                0,
                VarsayilanKasaAdi,
                SistemKullanicisi,
                "Giderler",
                giderID);
        }

        public static void DemirbasKasaHareketiYaz(SqlConnection baglanti, int demirbasID, DateTime tarih, string kategori, decimal tutar, string aciklama, bool aktif)
        {
            KaynakKasaHareketleriniSil(baglanti, "Demirbaslar", demirbasID);

            if (!aktif)
                return;

            KasaHareketiEkle(
                baglanti,
                tarih,
                "\u00d6deme",
                KategoriDegeri(kategori, "Demirba\u015f"),
                tutar,
                "Nakit",
                "Demirba\u015f al\u0131m\u0131: " + aciklama,
                0,
                0,
                0,
                VarsayilanKasaAdi,
                SistemKullanicisi,
                "Demirbaslar",
                demirbasID);
        }

        public static void SatisKasaHareketiYaz(SqlConnection baglanti, int satisID, DateTime tarih, string satisTipi, decimal tutar, string odemeTipi, string odemeDurumu, bool iadeMi, string aciklama, int musteriID, int personelID)
        {
            KaynakKasaHareketleriniSil(baglanti, "Satislar", satisID);

            if (MetinAnahtari(odemeDurumu) != "odendi")
                return;

            KasaHareketiEkle(
                baglanti,
                tarih,
                iadeMi ? "\u00d6deme" : "Tahsilat",
                KategoriDegeri(satisTipi, "Sat\u0131\u015f"),
                tutar,
                odemeTipi,
                (iadeMi ? "Sat\u0131\u015f iadesi: " : "Sat\u0131\u015f tahsilat\u0131: ") + aciklama,
                musteriID,
                0,
                personelID,
                VarsayilanKasaAdi,
                SistemKullanicisi,
                "Satislar",
                satisID);
        }

        public static void PersonelMaasKasaHareketiYaz(SqlConnection baglanti, int personelID, DateTime tarih, string pozisyon, decimal maas, string aciklama, bool aktif)
        {
            KaynakKasaHareketleriniSil(baglanti, "Personel", personelID);

            if (!aktif || maas <= 0)
                return;

            KasaHareketiEkle(
                baglanti,
                tarih,
                "\u00d6deme",
                KategoriDegeri(pozisyon, "Maa\u015f"),
                maas,
                "Nakit",
                "Personel maa\u015f \u00f6demesi: " + aciklama,
                0,
                0,
                personelID,
                VarsayilanKasaAdi,
                SistemKullanicisi,
                "Personel",
                personelID);
        }

        public static void HizmetKasaHareketiYaz(SqlConnection baglanti, int hizmetID, DateTime tarih, string kategori, decimal ucret, string aciklama, bool aktif)
        {
            KaynakKasaHareketleriniSil(baglanti, "Hizmet", hizmetID);

            if (!aktif || ucret <= 0)
                return;

            KasaHareketiEkle(
                baglanti,
                tarih,
                "Tahsilat",
                KategoriDegeri(kategori, "Hizmet"),
                ucret,
                "Nakit",
                "Hizmet \u00fccreti: " + aciklama,
                0,
                0,
                0,
                VarsayilanKasaAdi,
                SistemKullanicisi,
                "Hizmet",
                hizmetID);
        }

        public static void RandevuKasaHareketiYaz(SqlConnection baglanti, int randevuID, DateTime tarih, string durum, decimal tutar, string odemeDurumu, string aciklama, int musteriID, int personelID)
        {
            KaynakKasaHareketleriniSil(baglanti, "Randevu", randevuID);

            if (MetinAnahtari(odemeDurumu) != "odendi" || tutar <= 0)
                return;

            KasaHareketiEkle(
                baglanti,
                tarih,
                "Tahsilat",
                KategoriDegeri(durum, "Randevu"),
                tutar,
                "Nakit",
                "Randevu tahsilat\u0131: " + aciklama,
                musteriID,
                0,
                personelID,
                VarsayilanKasaAdi,
                SistemKullanicisi,
                "Randevu",
                randevuID);
        }

        private static string KategoriDegeri(string deger, string varsayilan)
        {
            return string.IsNullOrWhiteSpace(deger) || deger.Trim() == "Se\u00e7iniz"
                ? varsayilan
                : deger.Trim();
        }

        private static string MetinKirp(string deger, int uzunluk)
        {
            string temizDeger = string.IsNullOrWhiteSpace(deger) ? string.Empty : deger.Trim();
            return temizDeger.Length <= uzunluk ? temizDeger : temizDeger.Substring(0, uzunluk);
        }

        private static void KasaHareketKategoriKaynaklardanGuncelle(SqlConnection baglanti)
        {
            ExecuteNonQuery(baglanti, @"
UPDATE KH
SET IslemKategorisi = LEFT(G.GiderTuru, 100)
FROM KasaHareketleri KH
INNER JOIN Giderler G ON G.GiderID = KH.KaynakID
WHERE KH.KaynakTablo = N'Giderler'
  AND NULLIF(LTRIM(RTRIM(ISNULL(G.GiderTuru, N''))), N'') IS NOT NULL;");

            ExecuteNonQuery(baglanti, @"
UPDATE KH
SET IslemKategorisi = LEFT(D.Kategori, 100)
FROM KasaHareketleri KH
INNER JOIN Demirbaslar D ON D.DemirbasID = KH.KaynakID
WHERE KH.KaynakTablo = N'Demirbaslar'
  AND NULLIF(LTRIM(RTRIM(ISNULL(D.Kategori, N''))), N'') IS NOT NULL;");

            ExecuteNonQuery(baglanti, @"
UPDATE KH
SET IslemKategorisi = LEFT(S.SatisTipi, 100)
FROM KasaHareketleri KH
INNER JOIN Satislar S ON S.SatisID = KH.KaynakID
WHERE KH.KaynakTablo = N'Satislar'
  AND NULLIF(LTRIM(RTRIM(ISNULL(S.SatisTipi, N''))), N'') IS NOT NULL;");

            ExecuteNonQuery(baglanti, @"
UPDATE KH
SET IslemKategorisi = LEFT(H.Kategori, 100)
FROM KasaHareketleri KH
INNER JOIN Hizmet H ON H.HizmetID = KH.KaynakID
WHERE KH.KaynakTablo = N'Hizmet'
  AND NULLIF(LTRIM(RTRIM(ISNULL(H.Kategori, N''))), N'') IS NOT NULL;");

            ExecuteNonQuery(baglanti, @"
UPDATE KH
SET IslemKategorisi = LEFT(P.Pozisyon, 100)
FROM KasaHareketleri KH
INNER JOIN Personel P ON P.PersonelID = KH.KaynakID
WHERE KH.KaynakTablo = N'Personel'
  AND NULLIF(LTRIM(RTRIM(ISNULL(P.Pozisyon, N''))), N'') IS NOT NULL;");

            ExecuteNonQuery(baglanti, @"
UPDATE KH
SET IslemKategorisi = LEFT(R.Durum, 100)
FROM KasaHareketleri KH
INNER JOIN Randevu R ON R.RandevuID = KH.KaynakID
WHERE KH.KaynakTablo = N'Randevu'
  AND NULLIF(LTRIM(RTRIM(ISNULL(R.Durum, N''))), N'') IS NOT NULL;");
        }

        private static void TekrarlayanKaynakKasaHareketleriniTemizle(SqlConnection baglanti)
        {
            ExecuteNonQuery(baglanti, @"
DELETE KH
FROM KasaHareketleri KH
INNER JOIN
(
    SELECT KaynakTablo, KaynakID, MAX(KasaHareketID) AS SonKasaHareketID
    FROM KasaHareketleri
    WHERE KaynakTablo IS NOT NULL
      AND KaynakID IS NOT NULL
    GROUP BY KaynakTablo, KaynakID
    HAVING COUNT(*) > 1
) Tekrar ON Tekrar.KaynakTablo = KH.KaynakTablo
        AND Tekrar.KaynakID = KH.KaynakID
WHERE KH.KasaHareketID <> Tekrar.SonKasaHareketID;");
        }

        private static void EksikKaynakKasaHareketleriniOlustur(SqlConnection baglanti)
        {
            ExecuteNonQuery(baglanti, @"
INSERT INTO KasaHareketleri
    (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
SELECT
    G.Tarih,
    N'Ödeme',
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(G.GiderTuru)), N''), N'Gider'), 100),
    ABS(ISNULL(G.Tutar, 0)),
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(G.OdemeTipi)), N''), N'Nakit'), 20),
    LEFT(N'Gider: ' + ISNULL(G.Aciklama, N''), 150),
    0, 0, 0,
    N'Ana Kasa',
    0, 0,
    N'Sistem',
    N'Giderler',
    G.GiderID
FROM Giderler G
WHERE G.Aktif = 1
  AND ISNULL(G.Tutar, 0) > 0
  AND NOT EXISTS (SELECT 1 FROM KasaHareketleri KH WHERE KH.KaynakTablo=N'Giderler' AND KH.KaynakID=G.GiderID);");

            ExecuteNonQuery(baglanti, @"
INSERT INTO KasaHareketleri
    (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
SELECT
    D.AlimTarihi,
    N'Ödeme',
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(D.Kategori)), N''), N'Demirbaş'), 100),
    ABS(ISNULL(D.AlimFiyati, 0)),
    N'Nakit',
    LEFT(N'Demirbaş alımı: ' + ISNULL(D.DemirbasAdi, N''), 150),
    0, 0, 0,
    N'Ana Kasa',
    0, 0,
    N'Sistem',
    N'Demirbaslar',
    D.DemirbasID
FROM Demirbaslar D
WHERE D.Aktif = 1
  AND ISNULL(D.AlimFiyati, 0) > 0
  AND NOT EXISTS (SELECT 1 FROM KasaHareketleri KH WHERE KH.KaynakTablo=N'Demirbaslar' AND KH.KaynakID=D.DemirbasID);");

            ExecuteNonQuery(baglanti, @"
INSERT INTO KasaHareketleri
    (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
SELECT
    S.Tarih,
    CASE WHEN S.IadeMi = 1 THEN N'Ödeme' ELSE N'Tahsilat' END,
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(S.SatisTipi)), N''), N'Satış'), 100),
    ABS(ISNULL(S.GenelToplam, 0)),
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(S.OdemeTipi)), N''), N'Nakit'), 20),
    LEFT(CASE WHEN S.IadeMi = 1 THEN N'Satış iadesi: ' ELSE N'Satış tahsilatı: ' END + ISNULL(S.Aciklama, N''), 150),
    S.MusteriID,
    0,
    S.PersonelID,
    N'Ana Kasa',
    0, 0,
    N'Sistem',
    N'Satislar',
    S.SatisID
FROM Satislar S
WHERE (S.OdemeDurumu = N'Ödendi' OR S.OdemeDurumu = N'Odendi')
  AND ISNULL(S.GenelToplam, 0) > 0
  AND NOT EXISTS (SELECT 1 FROM KasaHareketleri KH WHERE KH.KaynakTablo=N'Satislar' AND KH.KaynakID=S.SatisID);");

            ExecuteNonQuery(baglanti, @"
INSERT INTO KasaHareketleri
    (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
SELECT
    P.IseGirisTarihi,
    N'Ödeme',
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(P.Pozisyon)), N''), N'Maaş'), 100),
    ABS(ISNULL(P.Maas, 0)),
    N'Nakit',
    LEFT(N'Personel maaş ödemesi: ' + LTRIM(RTRIM(ISNULL(P.Ad, N'') + N' ' + ISNULL(P.Soyad, N''))), 150),
    0, 0,
    P.PersonelID,
    N'Ana Kasa',
    0, 0,
    N'Sistem',
    N'Personel',
    P.PersonelID
FROM Personel P
WHERE P.Aktif = 1
  AND ISNULL(P.Maas, 0) > 0
  AND NOT EXISTS (SELECT 1 FROM KasaHareketleri KH WHERE KH.KaynakTablo=N'Personel' AND KH.KaynakID=P.PersonelID);");

            ExecuteNonQuery(baglanti, @"
INSERT INTO KasaHareketleri
    (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
SELECT
    GETDATE(),
    N'Tahsilat',
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(H.Kategori)), N''), N'Hizmet'), 100),
    ABS(ISNULL(H.Ucret, 0)),
    N'Nakit',
    LEFT(N'Hizmet ücreti: ' + ISNULL(H.HizmetAdi, N''), 150),
    0, 0, 0,
    N'Ana Kasa',
    0, 0,
    N'Sistem',
    N'Hizmet',
    H.HizmetID
FROM Hizmet H
WHERE H.Aktif = 1
  AND ISNULL(H.Ucret, 0) > 0
  AND NOT EXISTS (SELECT 1 FROM KasaHareketleri KH WHERE KH.KaynakTablo=N'Hizmet' AND KH.KaynakID=H.HizmetID);");

            ExecuteNonQuery(baglanti, @"
INSERT INTO KasaHareketleri
    (Tarih, IslemTipi, IslemKategorisi, Tutar, OdemeTipi, Aciklama, MusteriID, TedarikciID, PersonelID, KasaAdi, BakiyeOnce, BakiyeSonra, IslemiYapan, KaynakTablo, KaynakID)
SELECT
    R.RandevuTarih,
    N'Tahsilat',
    LEFT(ISNULL(NULLIF(LTRIM(RTRIM(R.Durum)), N''), N'Randevu'), 100),
    ABS(ISNULL(R.ToplamTutar, 0)),
    N'Nakit',
    LEFT(N'Randevu tahsilatı: ' + ISNULL(R.Notlar, N''), 150),
    R.MusteriID,
    0,
    R.PersonelID,
    N'Ana Kasa',
    0, 0,
    N'Sistem',
    N'Randevu',
    R.RandevuID
FROM Randevu R
WHERE (R.OdemeDurumu = N'Ödendi' OR R.OdemeDurumu = N'Odendi')
  AND ISNULL(R.ToplamTutar, 0) > 0
  AND NOT EXISTS (SELECT 1 FROM KasaHareketleri KH WHERE KH.KaynakTablo=N'Randevu' AND KH.KaynakID=R.RandevuID);");
        }

        private static void StokHareketEtkisiniGeriAl(SqlConnection baglanti, int hareketID)
        {
            using (SqlCommand komut = new SqlCommand("SELECT UrunID, OncekiStok, SonrakiStok, AktifMi FROM StokHareketleri WHERE HareketID=@HareketID", baglanti))
            {
                komut.Parameters.AddWithValue("@HareketID", hareketID);

                using (SqlDataReader okuyucu = komut.ExecuteReader())
                {
                    if (!okuyucu.Read())
                        return;

                    int urunID = Convert.ToInt32(okuyucu["UrunID"]);
                    int oncekiStok = Convert.ToInt32(okuyucu["OncekiStok"]);
                    int sonrakiStok = Convert.ToInt32(okuyucu["SonrakiStok"]);
                    bool aktifMi = Convert.ToBoolean(okuyucu["AktifMi"]);
                    okuyucu.Close();

                    if (!aktifMi)
                        return;

                    int mevcutStok;
                    if (!TryMevcutStokGetir(baglanti, urunID, out mevcutStok))
                        return;

                    int geriAlinmisStok = mevcutStok - (sonrakiStok - oncekiStok);
                    StokNegatifKontrol(geriAlinmisStok);
                    UrunStokGuncelle(baglanti, urunID, geriAlinmisStok);
                }
            }
        }

        private static int SonrakiStokHesapla(string islemTipi, int oncekiStok, int miktar, int istenenSonrakiStok)
        {
            string islemAnahtari = MetinAnahtari(islemTipi);

            if (islemAnahtari == "giris")
                return oncekiStok + miktar;

            if (islemAnahtari == "cikis")
                return oncekiStok - miktar;

            return istenenSonrakiStok;
        }

        private static int MevcutStokGetir(SqlConnection baglanti, int urunID)
        {
            int mevcutStok;

            if (!TryMevcutStokGetir(baglanti, urunID, out mevcutStok))
                throw new InvalidOperationException("\u00dcr\u00fcn bulunamad\u0131.");

            return mevcutStok;
        }

        private static bool TryMevcutStokGetir(SqlConnection baglanti, int urunID, out int mevcutStok)
        {
            using (SqlCommand komut = new SqlCommand("SELECT MevcutStok FROM Urunler WHERE UrunID=@UrunID", baglanti))
            {
                komut.Parameters.AddWithValue("@UrunID", urunID);
                object sonuc = komut.ExecuteScalar();

                if (sonuc == null || sonuc == DBNull.Value)
                {
                    mevcutStok = 0;
                    return false;
                }

                mevcutStok = Convert.ToInt32(sonuc);
                return true;
            }
        }

        private static void UrunStokGuncelle(SqlConnection baglanti, int urunID, int mevcutStok)
        {
            using (SqlCommand komut = new SqlCommand("UPDATE Urunler SET MevcutStok=@MevcutStok WHERE UrunID=@UrunID", baglanti))
            {
                komut.Parameters.AddWithValue("@UrunID", urunID);
                komut.Parameters.AddWithValue("@MevcutStok", mevcutStok);
                komut.ExecuteNonQuery();
            }
        }

        private static bool KolonVarMi(SqlConnection baglanti, string tablo, string kolon)
        {
            using (SqlCommand komut = new SqlCommand("SELECT CASE WHEN COL_LENGTH(@Tablo, @Kolon) IS NULL THEN 0 ELSE 1 END", baglanti))
            {
                komut.Parameters.AddWithValue("@Tablo", tablo);
                komut.Parameters.AddWithValue("@Kolon", kolon);
                return Convert.ToInt32(komut.ExecuteScalar()) == 1;
            }
        }

        private static void StoklariHareketlerdenOlustur(SqlConnection baglanti)
        {
            ExecuteNonQuery(baglanti, @"
;WITH SonHareket AS
(
    SELECT UrunID, SonrakiStok,
           ROW_NUMBER() OVER (PARTITION BY UrunID ORDER BY Tarih DESC, HareketID DESC) AS Sira
    FROM StokHareketleri
    WHERE AktifMi = 1
)
UPDATE U
SET MevcutStok = S.SonrakiStok
FROM Urunler U
INNER JOIN SonHareket S ON S.UrunID = U.UrunID AND S.Sira = 1;");
        }

        private static void StokNegatifKontrol(int stok)
        {
            if (stok < 0)
                throw new InvalidOperationException("Stok miktar\u0131 eksiye d\u00fc\u015femez.");
        }

        private static decimal KasaBakiyesiGetir(SqlConnection baglanti, string kasaAdi)
        {
            using (SqlCommand komut = new SqlCommand(@"
SELECT ISNULL((
    SELECT TOP 1 BakiyeSonra
    FROM KasaHareketleri
    WHERE KasaAdi=@KasaAdi
    ORDER BY KasaHareketID DESC
), 0)", baglanti))
            {
                komut.Parameters.AddWithValue("@KasaAdi", string.IsNullOrWhiteSpace(kasaAdi) ? VarsayilanKasaAdi : kasaAdi.Trim());
                return Convert.ToDecimal(komut.ExecuteScalar());
            }
        }

        private static decimal KasaDelta(string islemTipi, decimal tutar)
        {
            decimal pozitifTutar = Math.Abs(tutar);

            string islemAnahtari = MetinAnahtari(islemTipi);

            if (islemAnahtari == "tahsilat")
                return pozitifTutar;

            if (islemAnahtari == "odeme")
                return -pozitifTutar;

            throw new InvalidOperationException("Kasa hareketi i\u015flem tipi Tahsilat veya \u00d6deme olmal\u0131d\u0131r.");
        }

        private static string MetinAnahtari(string deger)
        {
            if (deger == null)
                return string.Empty;

            return deger.Trim()
                .ToLowerInvariant()
                .Replace("\u0131", "i")
                .Replace("\u00f6", "o")
                .Replace("\u00fc", "u")
                .Replace("\u015f", "s")
                .Replace("\u00e7", "c")
                .Replace("\u011f", "g");
        }

        private static void KasaBakiyeleriniYenidenHesapla(SqlConnection baglanti)
        {
            DataTable hareketler = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter(@"
SELECT KasaHareketID, IslemTipi, Tutar, KasaAdi
FROM KasaHareketleri
ORDER BY KasaAdi, KasaHareketID", baglanti))
            {
                da.Fill(hareketler);
            }

            string aktifKasa = null;
            decimal bakiye = 0;

            foreach (DataRow satir in hareketler.Rows)
            {
                string kasaAdi = Convert.ToString(satir["KasaAdi"]);

                if (!string.Equals(aktifKasa, kasaAdi, StringComparison.CurrentCultureIgnoreCase))
                {
                    aktifKasa = kasaAdi;
                    bakiye = 0;
                }

                decimal once = bakiye;
                bakiye += KasaDelta(Convert.ToString(satir["IslemTipi"]), Convert.ToDecimal(satir["Tutar"]));

                using (SqlCommand komut = new SqlCommand("UPDATE KasaHareketleri SET BakiyeOnce=@BakiyeOnce, BakiyeSonra=@BakiyeSonra WHERE KasaHareketID=@KasaHareketID", baglanti))
                {
                    komut.Parameters.AddWithValue("@KasaHareketID", Convert.ToInt32(satir["KasaHareketID"]));
                    komut.Parameters.AddWithValue("@BakiyeOnce", once);
                    komut.Parameters.AddWithValue("@BakiyeSonra", bakiye);
                    komut.ExecuteNonQuery();
                }
            }
        }

        private static void ExecuteNonQuery(SqlConnection baglanti, string sorgu)
        {
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.ExecuteNonQuery();
            }
        }
    }
}

