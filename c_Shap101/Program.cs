using static System.Runtime.InteropServices.JavaScript.JSType;

internal partial class Program
{
    private static void Main(string[] args)
    {
        //OzYenileme();
        //homework_1_1();
        //homework_1_2();

    }

    private static void homework_1_2()
    {
        int[] positiveDivisors = new int[2];
        positiveDivisors.EnterNumberArray();

        Console.Write("Adet Sayısı Giriniz : ");
        int.TryParse(Console.ReadLine(), out int piece);

        piece.IsPostive();

        int[] numbers = new int[piece];

        numbers.EnterNumberArray();

        foreach (var number in numbers)
        {
            if (number % positiveDivisors[0] == default && number % positiveDivisors[1] == default)
                number.PrintWindow();
        }
    }

    private static void homework_1_1()
    {
        int piece;

        Console.Write("Adet Sayısı Giriniz : ");
        int.TryParse(Console.ReadLine(), out piece);

        piece.IsPostive();

        int[] numberList = new int[piece];

        for (int i = 0; i < piece; i++)
        {
            Console.Write($"{i + 1}. Sayı Giriniz : ");
            int.TryParse(Console.ReadLine(), out int evenNumber);

            if (evenNumber.IsPositiveEvenNumber())
                numberList[i] = evenNumber;
        }

        numberList.PrintPositiveEvenNumber();
    }

    private static void OzYenileme()
    {

        //Test();

        //rekürsif öz yenilemeli
        //Console.Write("Sayı giriniz");
        //int sayi = Convert.ToInt32(Console.ReadLine());


        //Console.Write("Üs giriniz");
        //int us = Convert.ToInt32(Console.ReadLine());

        //Islemler ıslemler = new();

        //Console.WriteLine(ıslemler.Expo(sayi, us));
        //Console.ReadKey();

        //extension  metotlar

        string ifade = "Musab B. Akan";

        ifade.CheckSpaces()
              .PrintToScreen();

        ifade.RemoveWithSpaces()
              .PrintToScreen();


        int[] dizi = { 1, 7, 5, 9, 11, 2185, -1 };

        dizi.SortArray();
        dizi.PrintToScreenNumberListArray();

        ifade.GetFirstCharacter()
            .PrintToScreen();


        Console.ReadKey();
    }

    private static void Test()
    {
        //try
        //{
        //    Console.WriteLine("Bir sayı giriniz");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Girmiş olduğunuz sayi " + sayi);

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Hata :" + ex.Message.ToString());    

        //}
        //finally
        //{
        //    Console.WriteLine("İşlem tamamlandı");
        //}
        Console.Write("Dizi eleman sayısı  giriniz: ");
        int elemanSayi = int.Parse(Console.ReadLine());
        int[] diziler = new int[elemanSayi];

        for (int i = 0; i < elemanSayi; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayısı giriniz : ");
            diziler[i] = int.Parse(Console.ReadLine());
        }


        Array.Sort(diziler);
        int toplam = 0;

        foreach (int dizi in diziler)
            toplam += dizi;

        Console.WriteLine("Ortalama : " + toplam / elemanSayi);
    }
}
public static class PositiveNumber
{
    
    public static int[] EnterNumberArray(this int[] arrys)
    {
        for (int i = 0; i < arrys.Length; i++)
        {
        again:
            Console.Write($"{i + 1}. Sayı Giriniz : ");
            int.TryParse(Console.ReadLine(), out int number);

            if (number.IsPostive())
                arrys[i] = number;
            else
                goto again;
        }
        return arrys;
    }

    public static bool IsPositiveEvenNumber(this int number)
    {
        return number % 2 == 0 && number > 0;
    }
    public static void PrintWindow(this int @int)
    {
        Console.WriteLine(@int);
        Console.ReadKey();
    }
    public static void PrintPositiveEvenNumber(this int[] ints)
    {

        Array.Sort(ints);

        foreach (int @int in ints)
            if (@int.IsPositiveEvenNumber())
                Console.WriteLine(@int);

        Console.ReadKey();
    }



    public static bool IsPostive(this int value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Sayı 0'dan büyük olmalıdır");
            return false;
        }
        return true;
    }
}
