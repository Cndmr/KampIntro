
Person[] persons = new Person[3]
{
    new Customer
    {
        Name="Can"
    },
    new Student
    {
        StudentNo=1
    },
new Person
{
    Name="Bla"
} 
};
foreach (var person in persons)
{
    Console.WriteLine( person.Name );
}
Console.ReadLine();
class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}
class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public int StudentNo { get; set; }
}