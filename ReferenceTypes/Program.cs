internal class Program
{
    private static void Main(string[] args)
    {
        //int decimal float enum boolean value types

        int sayi = 10;
        int sayi2 = 10;

        sayi = sayi2;
        sayi2 = 100;


        //arrays, class interface ... reference types
        Console.WriteLine("Sayı 1 : " + sayi);
        int[] sayilar1 = new int[] { 1, 2, 3 };
        int[] sayilar2 = new int[] { 10, 20, 30 };

        sayilar1 = sayilar2;
        sayilar2[0] = 1000;

        Console.WriteLine("Sayılar [0] = " + sayilar1[0]);


        Person person1= new Person();
        Person person2= new Person();
        person1.FirstName = "Musab";
        
        person2 = person1;
        person1.FirstName = "Derin";//////

        Console.WriteLine(person2.FirstName);

        Customer customer = new Customer();
        customer.FirstName = "salih";
        customer.CreditCardNumber = "123413454355";

        Employee employee = new Employee();


        Person person3 = customer;
        customer.FirstName = "Ahmet";

        Console.WriteLine(((Customer)person3).CreditCardNumber);




        //Customer customer = new Customer();
        //Employee employee = new Employee();
         
        
    }
}

class PersonManager()
{
    public void Add(Employee employee)
    {

    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}