namespace Interfaces
{
    class OracleCustomeDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {

            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {

            Console.WriteLine("Oracle updated!");
        }
    }
}
