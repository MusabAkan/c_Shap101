internal partial class Program
{
    private static void Main(string[] args)
    {
        OzYenileme();

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
