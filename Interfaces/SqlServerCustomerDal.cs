namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Customer added!");
        }

        public void Delete()
        {

            Console.WriteLine("Customer deleted!");
        }

        public void Update()
        {

            Console.WriteLine("Customer updated!");
        }
    }
}
