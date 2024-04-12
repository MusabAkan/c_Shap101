using System.Reflection;

internal class Program
{
    /*
     çalışma anında çalıştığınız herhangi bir nesneneni hakkında bilgi toplamak  ve hatta topladığnız nesneye göre istediğniz çalıştırabilirisiniz. 
     
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //DortIslem islem = new DortIslem(2, 5);
        //Console.WriteLine(islem.Topla());
        //Console.WriteLine(islem.Topla(9, 4));


        //var type = typeof(DortIslem); ;
        //var instance =  (DortIslem) Activator.CreateInstance(type, 4,5); //cast işlemi yapıldı  type => Object

        //Console.WriteLine(instance.Topla());

        ////DortIslem islem = new(2, 3);
        ////islem.Topla();
        ///
        var type = typeof(DortIslem);
        //var instance = Activator.CreateInstance(type, 6, 7);

        //var methodInfo = instance.GetType().GetMethod("Topla2");
        //Console.WriteLine(methodInfo.Invoke(instance, null));
        //Console.WriteLine();


        var metodlar = type.GetMethods();
        foreach (var metod in metodlar)
        {
            Console.WriteLine("Metot adı :  {0}", metod.Name);

            foreach (var item in metod.GetParameters())
            {
                Console.WriteLine($"Parametre adı : {item.Name}");
            }
            foreach (var parameter in metod.GetCustomAttributes())
            {
                Console.WriteLine($"Öz nitelikler : {parameter.ToString()}");
            }
        }

        Console.ReadLine();
    }
}

public class DortIslem
{
    int _sayi1, _sayi2;

    public DortIslem(int sayi1, int sayi2)
    {
        _sayi1 = sayi1;
        _sayi2 = sayi2;
    }
    public int Topla()
    {
        return _sayi1 + _sayi2;
    }
    public int Topla2(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    [IslemYap]
    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2; ;
    }
}