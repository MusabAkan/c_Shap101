namespace ClassMetotDemo.Models
{

    public class CustomerManager
    {
        List<Customer> Customers = new();

        public CustomerManager()
        {
            Customers.Add(new Customer { Id = Guid.NewGuid(), Name = "Musab", Surname = "Akan" });
            Customers.Add(new Customer { Id = Guid.NewGuid(), Name = "Tahir", Surname = "Canbayır" });
            Customers.Add(new Customer { Id = Guid.NewGuid(), Name = "Kerim", Surname = "Durmaz" });
        }
        private class Customer
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        public void AddCustomerManager(string name, string surname)
        {
            Customers.Add(new Customer { Id = Guid.NewGuid(), Name = name, Surname = surname });
            Console.WriteLine("Müşteri veritabanına eklenmiştir.");
            Console.ReadKey();

        }

        public void UpdateCustomerManager(string id, string name, string surname)
        {

            if (Guid.TryParse(id, out Guid guidId))
            {
                Console.WriteLine("Guid ID doğru giriniz");
                return;
            }
            var exist = Customers.Where(x => x.Id == guidId).FirstOrDefault();

            if (exist == null)
            {
                Console.WriteLine("Müşteri  bulunamadı");
                return;
            }

            Customers.Remove(exist);
            Customers.Add(new Customer { Id = guidId, Name = name, Surname = surname });
            Console.WriteLine("Müşteri veritabanında güncellenmiştir.");
            Console.ReadKey();

        }


        public void GetAllCustomerManager()
        {
            Console.WriteLine("Müşteriler Listesi");

            foreach (var customer in Customers)
                Console.WriteLine($"ID : {customer.Id}, Adı : {customer.Name}, Soyadı : {customer.Surname}");
            Console.ReadKey();

        }
        public void RemoveCustomerManager(string id)
        {
            if (Guid.TryParse(id, out Guid guidId))
            {
                Console.WriteLine("Guid ID doğru giriniz");
                return;
            }
            var exist = Customers.Where(x => x.Id == guidId).FirstOrDefault();

            if (exist == null)
            {
                Console.WriteLine("Müşteri  bulunamadı");
                return;
            }
            //throw new Exception("Müşteri  bulunamadı");


            Customers.Remove(exist);
            Console.WriteLine("Müşteri veritabanından silinmiştir.");
            Console.ReadKey();

        }


    }
}
