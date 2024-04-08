namespace Interfaces
{
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added!");
        }

        public void Delete()
        {

            Console.WriteLine("MySql deleted!");
        }

        public void Update()
        {

            Console.WriteLine("MySql updated!");
        }
    }
}
