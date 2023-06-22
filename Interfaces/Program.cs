
PersonManager personManager = new PersonManager();
personManager.Add(new Customer { Id = 1, Name = "Can", LastName = "Demir" });
Student student = new Student
{
    Id = 1,
    Name = "can",
    LastName = "Demir"
};
personManager.Add(student);
Console.ReadLine();

interface IPersons
{
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set; }
}
class Customer : IPersons
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}
class Student : IPersons
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}
class PersonManager
{
    public void Add(IPersons persons)
    {
        Console.WriteLine(persons.Name);
    }
}