using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

internal class Program
{
    /*senaryo     
     Kahve dükanları içim müşteri yönetimi yapan bir sistem yazmak istiyoruz 
     TurkKahveDünyası ve Nero firması için çalışıyoruz.
    İki firmada müşterilerini veri tabanına kaydetmek istiyor. Türk kahve dünyası müşterilerini kayderderken,
    mutlaka mernis doğrulaması istioy. Nero da ise bu durum istisna.
     */
    private static void Main(string[] args)
    {
       BaseCustomerManager customerManager = new TurkCafeCustomerManager(new MernisServiceAdapter());

        customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 1, 12), Id = 1, FirstName = "Musap bilal", LastName = "Akan", NationalityId = "1853026987" });

        Console.ReadKey();


    }

}
