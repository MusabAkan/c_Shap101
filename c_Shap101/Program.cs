internal class Program
{
    private static void Main(string[] args)
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

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, --us) * sayi;

        }
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
public static class Extension
{
    private const char Separator = ' ';
    /// <summary>
    /// Space is check ?
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(Separator);
    }
    /// <summary>
    /// Remove space
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    public static string RemoveWithSpaces(this string param)
    {
        string[] split = param.Split(Separator);
        return string.Join(string.Empty, split);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    /// <summary>
    /// Sort array list.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] SortArray(this int[] arrList)
    {
        Array.Sort(arrList);
        return arrList;
    }
    /// <summary>
    /// String Print to screen
    /// </summary>
    /// <param name="param"></param>
    public static void PrintToScreen(this string param)
    {
        Console.WriteLine(param);
    }
    /// <summary>
    /// Bool Print To Screen
    /// </summary>
    /// <param name="param"></param>
    public static void PrintToScreen(this bool param)
    {
        Console.WriteLine(param);
    }

    public static void PrintToScreenNumberListArray(this int[] arrList)
    {
        foreach (int arr in arrList)
            Console.WriteLine(arr);
    }

    public static bool IsEvenNumber(this int num)
    {
        return num % 2 == 0;
    }

    public static string GetFirstCharacter(this string str)
    {    
        return str.Substring(0, 1);
    }
}