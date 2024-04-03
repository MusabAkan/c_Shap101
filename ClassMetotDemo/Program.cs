using ClassMetotDemo.Models;

internal class Program
{

    /*
     Şimdi Github hesabınıza biraz hit alalım :)
    ClassMetotDemo isimli bir proje oluşturunuz.
    Bunu Github'a aktarınız.
    Projeniz şunu yapacak.

    Bir bankada müşteri takibi yapmak istiyorsunuz.
    Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
    MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
     */
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new();
    again:
        Console.Clear();
        string id, name, surname;

        Console.WriteLine("Müşteri Takip Programı V1");
        Console.WriteLine("1-Müşteri Listele");
        Console.WriteLine("2-Müşteri Ekle");
        Console.WriteLine("3-Müşteri Güncelle");
        Console.WriteLine("4-Müşteri Sille");
        Console.WriteLine("Q-Çıkış yap");

        Console.Write("Lütfen yapılacak işlemin (1-4) numarasını giriniz: ");
        string processing = Console.ReadLine().ToUpper();

        switch (processing)
        {
            case "1":
                customerManager.GetAllCustomerManager();
                break;

            case "2":
                KeyPress(out name, out surname);
                customerManager.AddCustomerManager(name, surname);
                break;

            case "3":
                KeyPress(out id, out name, out surname);
                customerManager.UpdateCustomerManager(id, name, surname);
                break;

            case "4":
                KeyPress(out id);
                customerManager.RemoveCustomerManager(id);
                break;

            case "Q":
                return;
            default:
                Console.WriteLine("Hatalı tuşlama yaptınız.");
                goto again;
        }
        goto again;




    }
    /// <summary>
    /// Sadace id gir
    /// </summary>
    /// <param name="id"></param>
    private static void KeyPress(out string id)
    {
        Console.Write("Id : ");
        id = Console.ReadLine();
    }/// <summary>
     /// Ad ve soyad gir
     /// </summary>
     /// <param name="name"></param>
     /// <param name="surname"></param>
    private static void KeyPress(out string name, out string surname)
    {
        Console.Write("Adı : ");
        name = Console.ReadLine();

        Console.Write("Soyadı : ");
        surname = Console.ReadLine();
    }
    /// <summary>
    /// hepsini gir
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="surname"></param>
    private static void KeyPress(out string id, out string name, out string surname)
    {
        Console.Write("Id : ");
        id = Console.ReadLine();

        Console.Write("Adı : ");
        name = Console.ReadLine();

        Console.Write("Soyadı : ");
        surname = Console.ReadLine();
    }
}