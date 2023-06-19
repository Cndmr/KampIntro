using OOP2;

GercekMusteri musteri1 = new();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Can";
musteri1.Soyadi = "Demir";
musteri1.TcNo = "29200998331";

TuzelMusteri musteri2 = new();
musteri2.Id = 2;
musteri2.MusteriNo="123";
musteri2.SirketAdi = "Demir Yazılım";
musteri2.VergiNo = "16223";

MusteriManager musteriManager=new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);