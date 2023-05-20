// See https://aka.ms/new-console-template for more information
//Type safety - Tip güvenliği
// do not repeat yourself - kendini tekrar etme
// değer tutucu, alias
string kategorietiketi = "kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmismi = true;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");

}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi Butonu");
}


if (sistemeGirisYapmismi== true)
{
    Console.WriteLine("Kullanıcı Ayarları butonu ");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}
Console.WriteLine(kategorietiketi); 
 
