Customer customer1 = new(1,"Can","Demir","Bitlis");
Console.WriteLine(customer1.FirstName);


Customer customer2 = new Customer { Id = 1, FirstName = "Can", LastName = "demir", City = "Bitlis" };
//Customer2 ve Customer3 kullanımı aynıdır

Customer customer3 = new();
customer3.Id = 1;
customer3.FirstName = "Can";
customer3.LastName = "Demir";
customer3.City = "Bitlis";


class Customer
{
    
    public Customer()
    {

    }
    //Default Constructor
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}