//int,decimal,float,boolean,enum = Values Types
int sayi1 = 20;
int sayi2 = 30;
sayi1= sayi2;
sayi2 = 100;
Console.WriteLine("sayi1'in değeri" + sayi1);

//arrays, class, interfaces= Reference Types
int[] sayilar1= new int[] {1,2,3};
int[] sayilar2= new int[] {10,20,30};
sayilar1 = sayilar2;
sayilar2[0] = 1000;
Console.WriteLine("sayilar1[0]" + sayilar1[0]);