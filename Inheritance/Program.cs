using System.Runtime.InteropServices;

internal class Program
{
    //kalıtım veya miras yapılardır
    //
    private static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer(){FirstName ="Musab"}            ,
            new Student (){FirstName ="Ayşe"},
            new Person(){FirstName="İnsan"}
        };

        foreach (Person person in persons)
            Console.WriteLine(person.FirstName);
    }

}
class Student : Person
{
    public string Class { get; set; }
}
class Customer : Person //,IPerson, IWorker gibi yanyana interfaces kullanabiliri.
{
    public string City { get; set; }
}
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}