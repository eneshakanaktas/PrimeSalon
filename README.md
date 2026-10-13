# PrimeSalon – Berber Otomasyonu

PrimeSalon, bir **berber dükkanının günlük işlerini tek programdan yönetmek** için yazılmış bir Windows masaüstü programıdır. Müşteri, randevu, satış, stok, personel ve kasa gibi işler defter ve kâğıt yerine bilgisayarda tutulur.

## Ne işe yarar?

Berber sahibinin şu sorularına cevap vermesi için yapıldı:

- Bugün hangi müşterilerin randevusu var, hangi çalışan kimle ilgileniyor?
- Hangi hizmetten ne kadar kazandım, kasada ne kadar para var?
- Hangi üründen (şampuan, krem, jilet vb.) kaç adet kaldı, ne zaman azaldı?
- Bu ay ne kadar masraf yaptım (kira, fatura, malzeme)?
- Çalışanlarım kaç gün izin kullandı, maaşları ne?

## Programın bölümleri

| Bölüm | Ne yapılır? |
|---|---|
| **Müşteri** | Müşteri kayıtlarını tutma |
| **Personel** | Çalışanlar, pozisyonları ve maaşları |
| **İzin / Puantaj** | Çalışanların izin ve devam takibi |
| **Hizmet** | Sunulan hizmetler (tıraş, saç kesimi vb.), kategorileri ve ücretleri |
| **Randevu** | Randevu oluşturma; süre, indirim, tutar ve ödeme durumu |
| **Satışlar** | Satış ve iade kayıtları; ara toplam, indirim, KDV, genel toplam, ödeme tipi |
| **Ürünler** | Dükkanda kullanılan ve satılan ürünler |
| **Stok Hareketleri** | Ürün giriş ve çıkışları, önceki ve sonraki stok miktarı |
| **Tedarikçiler** | Ürün aldığınız firmalar |
| **Demirbaşlar** | Dükkanın eşya ve cihazları |
| **Giderler** | Kira, fatura gibi masraflar ve gider türleri |
| **Kasa Hareketleri** | Paranın girişi ve çıkışı, kasa bakiyesi |
| **Muhasebe ve Stok İşlemleri** | Yukarıdakilere tek ekrandan ulaşma |

Her bölümde aynı düzen vardır: **ekle, güncelle, sil ve sorgula**. Zorunlu alanlar boş bırakılırsa program o alanı kırmızı yapıp uyarır.

Müşteri, personel, izin, ürün, tedarikçi, satış, gider, demirbaş, stok ve kasa için **yazdırılabilir raporlar** da bulunur.

## Kendiliğinden yapılan işler

- **Kasa otomatik tutulur.** Satış, randevu, gider, demirbaş alımı ve personel maaşı kasaya kendiliğinden yazılır.
- **Stok otomatik hesaplanır.** Her stok hareketinde ürünün güncel adedi güncellenir. Stok eksiye düşecek işlem engellenir.
- **Veritabanı kendini düzeltir.** Program her açılışta eksik alanları ekler, çift yazılmış kasa kayıtlarını temizler ve kasa bakiyesini yeniden hesaplar.

## Teknik bilgiler

- Dil ve arayüz: C# · Windows Forms
- Çalışma ortamı: .NET Framework 4.7.2 (Windows)
- Veritabanı: SQL Server LocalDB (`(localdb)\PrimeSalonDB`)
- Raporlar: Microsoft ReportViewer
- Kurulum paketi: `PrimeSalonSetup` projesi

## Çalıştırma

1. Visual Studio 2019 veya üstü ile `PrimeSalon/PrimeSalon.sln` dosyasını açın.
2. Bilgisayarda SQL Server LocalDB kurulu olmalı. `PrimeSalonDB` adlı veritabanını depodaki `PrimeSalonDB.dacpac` dosyasından oluşturun.
3. Projeyi derleyip çalıştırın.

## Notlar

- Programda şu an kullanıcı girişi (şifre) yoktur.
- Depoda veritabanı dosyaları (`.mdf`, `.ldf`) da bulunur; gerçek müşteri bilgisi içeren bir veritabanını depoya yüklemeyin.
