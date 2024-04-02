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
                ((Circle)shape).CalculateCreate();
                break;

            case "kare":
                shape = new Square();
                ((Square)shape).CalculateCreate();
                break;

            case "dikdörtgen":
                shape = new Rectangle();
                ((Rectangle)shape).CalculateCreate();
                break;

            case "üçgen":
                shape = new Triangle();
                ((Triangle)shape).CalculateCreate();
                break;

            default:
                Console.WriteLine("Geçersiz şekil seçildi.");
                return;
        }

        Console.WriteLine("Hesaplamak istediğiniz boyutu seçin: (alan, çevre)");
        string calculationType = Console.ReadLine().ToLower();

        CalculateShape(shape, calculationType);
    }

    private static void CalculateShape(Shape shape, string calculationType)
    {
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