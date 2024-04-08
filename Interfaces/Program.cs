using Interfaces;
using System.Net.Http.Headers;

internal partial class Program
{
    //bir programcı olarak interface kullanım amaçına göre kullanıyor olman gerekiyor ki işi kavarayabilirsin
    //interface tek başına bir anlam ifade etmez şanlon veya imza gibi
    //belli bir arayüze implente ediliyor
    //interfaces kesinlikle new'lenemezler.
    //buradaki amaç bağımlılığı azaltmak  depency injection devereye girer
    
    //poliformizm çok biçimlilik InterfaceTEst ve CustomerDal örneğine bakalbilirsin.

    //SOLID Interfaces Segration


    private static void Main(string[] args)
    {
        //InterfacesIntro();

        //InterfacesTest();
        //Interfacespoliformizm2();

        IWork[] works = new IWork[3]
        {
            new Manager(),
            new Works(),
            new Robot()
        };

        foreach (var work in works)
            work.Work();


        Console.ReadLine();
    }



    interface IGetSalary
    {
        void GetSalary();
    }
    interface IEat
    {
        void Eat();
    }
    interface IWork
    {
        //void Eat();
        //void GetSalary();
        void Work();
    }

    class Robot : IWork
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Works : IWork, IEat, IGetSalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Manager : IWork, IGetSalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    private static void Interfacespoliformizm2()
    {
        ICustomerDal[] customerDals = new ICustomerDal[] {
            new SqlServerCustomerDal(),
            new OracleCustomeDal(),
            new MySqlCustomerDal()
        };


        foreach (var customerDal in customerDals)
            customerDal.Add();
    }

    private static void Interfacespoliformizm1()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());

        customerManager.Update(new OracleCustomeDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager personManager = new();

        personManager.Add(new Customer { Id = 1, FirstName = "Musab", LastName = "AKan", Address = "Rize" });

        var customer = new Student
        {
            Id = 1,
            FirstName = "Derin",
            Department = "Sakarya Üniversitesi",
            LastName = "Aydın"
        };


        personManager.Add(customer);
    }
}