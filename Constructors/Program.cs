internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Customer customer = new() { Id = 1, FirstName = "Yalçın", LastName = "Deniz", City = "Rize" };
        Customer customer2 = new(2, "Musab", "Akan", "İstanbul");


    }
    //bir sınıfı oluşum anında kontrol edilme işlemi yapıldığı yer

}
class Customer
{
    //default constructor
    public Customer()
    {
        Console.WriteLine("yapcı blok çalıştı");
    }

    public Customer(int ıd, string firstName, string lastName, string city)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}