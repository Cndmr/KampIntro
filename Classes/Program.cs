using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Updated();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Updated();

Customer customer = new Customer();
customer.Id = 1;
customer.Name = "Can";
customer.LastName = "Demir";
customer.City = "İstanbul";

Console.WriteLine(customer.Name);