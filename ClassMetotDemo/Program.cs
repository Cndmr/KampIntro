using ClassMetotDemo;

Musteri musteri1 = new();
musteri1.Name = "Oğuz";
musteri1.Surname = "Demirel";
musteri1.PhoneNumber = "05556667799" ;

Musteri musteri2 = new();
musteri2.Name = "can";
musteri2.Surname = "demir";
musteri2.PhoneNumber = "05556667788";

Musteri musteri3 = new();
musteri3.Name = "Burak";
musteri3.Surname = "İpekçi";
musteri3.PhoneNumber = "05556667710";

MusteriManager musteriManager = new();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Sil(musteri1);
musteriManager.Sil(musteri2);
musteriManager.Sil(musteri3);
Console.WriteLine("----------------------------------");
Musteri[] musteris = new[] { musteri1, musteri2, musteri3 };
musteriManager.Listele(musteris);
