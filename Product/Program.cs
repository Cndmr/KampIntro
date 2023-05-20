Product Prd1 = new Product();
Prd1.PrdName = "Computer";
Prd1.PrdMark = "Monster";
Prd1.PrdPrice = 16000;

Product Prd2 = new Product();
Prd2.PrdName = "Phone";
Prd2.PrdMark = "Iphone";
Prd2.PrdPrice = 15000;

Product Prd3 = new Product();
Prd3.PrdName = "Tablet";
Prd3.PrdMark = "Ipad";
Prd3.PrdPrice = 9000;

Product[] products = new Product[] { Prd1, Prd2, Prd3 };

foreach (var item in products)
{
    Console.WriteLine(item.PrdName +"|"+item.PrdMark+"|"+item.PrdPrice+"|");
}

int t = 0;
while (t < products.Length)
{
    Console.WriteLine(products[t].PrdName + " " + products[t].PrdMark + " : " + products[t].PrdPrice);
    t++;
}

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].PrdName + " : " +
    products[i].PrdMark + " : " + products[i].PrdPrice);
}
class Product
{
    public string PrdName { get; set; }
    public string PrdMark { get; set; }
    public int PrdPrice { get; set; }
}
