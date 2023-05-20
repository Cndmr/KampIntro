using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";
urun1.StokAdedi = 3;

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 60;
urun2.Aciklama = "Diyarbakır Karpuzu";
urun2.StokAdedi = 2;
Urun[] uruns = new Urun[] {urun1, urun2};

foreach (var item in uruns)
{
    //Type Safe -- Tip Güvenlidir 
    Console.WriteLine(item.Adi);
    Console.WriteLine(item.Fiyati + "TL");
    Console.WriteLine(item.Aciklama);
    Console.WriteLine(item.StokAdedi);
    Console.WriteLine("--------------------");
}
Console.WriteLine("----------METOTLAR-----------");
//Encapsulation
//instance - örnek
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);