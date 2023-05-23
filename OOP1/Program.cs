using OOP1;

Product product1 = new();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product 
{
    Id = 2, 
    CategoryId = 5, 
    ProductName = "Kalem", 
    UnitPrice = 20, 
    UnitsInStock = 5 
};

ProductManager productManager = new();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);