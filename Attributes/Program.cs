using System.ComponentModel.DataAnnotations;

internal class Program
{
    //Tanım : özenitelik bir nesneye veya özelliği uygulayabileğicemiz yapılardır Anlam katmak için de kullanabilir
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Customer customer = new() { Id = 1, LastName = "Akan", Age = 26 };
        CustomerDal customerDal = new();
        customerDal.Add(customer);
    }

}

class CustomerDal
{
    [Obsolete("Don't use Add, instead use AddNew Method")] // bunu yapmam hazır açıklamaları kullanabilmek için 
    public void Add(Customer customer)
    {
        Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
    }

    public void AddNew(Customer customer)
    {
        Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
    }
}
[ToTable("Customer")]
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
[AttributeUsage(AttributeTargets.Property)] //attribute oluşturuken kurallar benimseyerek iş kuralı oluşturabiliriz.Örneğin sadece Propert için kullanılır gibi

 
class RequiredPropertyAttribute : Attribute
{

}

class ToTableAttribute : Attribute
{
    private string _tableName;

    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}
