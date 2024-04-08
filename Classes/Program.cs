using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new ();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ();
        productManager.Add();
        productManager.Update();


        Customer customer = new Customer();
        customer.FirstName = "Gamze";
        customer.LastName = "Aydın";
        customer.City = "Turkey";
        customer.Id = 1;
        customer.Gender = Gender.Female;


        Customer customer2 = new Customer()
        {
            Id = 2,
            FirstName = "Ahmet",
            LastName = "Tekin",
            City = "Turkey",
            Gender = Gender.Male,

        };


        Console.WriteLine(customer2.ToString());

        Console.ReadKey();

        


    }


}