internal partial class Program
{
    class PersonManager
    {
        public void Add(IPerson customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisi eklendi");
        }
    }
}