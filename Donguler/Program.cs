string kurs1 = "Yazılım geliştirici Kursu";
string kurs2 = "Programlama Temelleri";
string kurs3 = "Java kursumuz";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);
Console.WriteLine("--------------------------------------------Kendini tekrar eden kod kısmı bitti  ");

// array - dizi
string[] kurslar = new string[] { "Yazılım geliştirici Kursu", "Programlama Temelleri", "Java kursumuz" };


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("--------------------------------------------For Bitti");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("--------------------------------------------Sayfa sonu");