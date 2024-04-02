internal partial class Program
{
    /*
     Alan Hesaplama
     C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.
     
     İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
     Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
     Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
     Hesap sonucunu anlaşılır şekilde geri döndürmeli.
     Dikkat Edilmesi Gereken Noktalar :
     
     Kod tekrarından kaçınılmalı
     Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir geometrik şekil seçin: (Daire, Üçgen, Kare, Dikdörtgen)");
        string shapeType = Console.ReadLine().ToLower();

        Shape shape;

        switch (shapeType)
        {
            case "daire":
                shape = new Circle();
                Console.WriteLine("Dairenin yarıçapını girin:");
                ((Circle)shape).Radius = double.Parse(Console.ReadLine());
                break;
            case "kare":
                shape = new Square();
                Console.WriteLine("Karenin bir kenar uzunluğunu girin:");
                ((Square)shape).Side = double.Parse(Console.ReadLine());
                break;
            case "dikdörtgen":
                shape = new Rectangle();
                Console.WriteLine("Dikdörtgenin uzun kenarını girin:");
                ((Rectangle)shape).Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin kısa kenarını girin:");
                ((Rectangle)shape).Width = double.Parse(Console.ReadLine());
                break;
            case "üçgen":
                shape = new Triangle();
                Console.WriteLine("Üçgenin ilk kenarını girin:");
                ((Triangle)shape).Side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin ikinci kenarını girin:");
                ((Triangle)shape).Side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin üçüncü kenarını girin:");
                ((Triangle)shape).Side3 = double.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Geçersiz şekil seçildi.");
                return;
        }

        Console.WriteLine("Hesaplamak istediğiniz boyutu seçin: (alan, çevre)");
        string calculationType = Console.ReadLine().ToLower();

        double result;

        switch (calculationType)
        {
            case "alan":
                result = shape.CalculateArea();
                break;
            case "çevre":
                result = shape.CalculatePerimeter();
                break;
            default:
                Console.WriteLine("Geçersiz hesaplama türü seçildi.");
                return;
        }

        Console.WriteLine($"Sonuç: {result}");
    }
}