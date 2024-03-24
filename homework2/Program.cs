using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[5];
        numbers.EnterNumbers();

        ArrayList primeList = [];
        ArrayList primeNotList = [];

        foreach (int number in numbers)
        {
            if (number.IsPrime())
                primeList.Add(number);
            else
                primeNotList.Add(number);
        }
        Console.WriteLine("***** Asal Sayılar Listesi *****");
        primeList.SortReverseList();
        
        Console.WriteLine("***** Asal Olmayan Sayılar Listesi *****");
        primeNotList.SortReverseList();   

        Console.WriteLine("Asal Sayıların Eleman Sayısı : {0}", primeList.Count);
        Console.WriteLine("Asal Sayıların Ortalaması : {0}", (Convert.ToDouble(primeList.SumTotal() / primeList.Count)));

        Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı : {0}", primeNotList.Count);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması : {0}", (Convert.ToDouble(primeNotList.SumTotal() / primeNotList.Count)));

        Console.ReadKey();
    }
}

public static class Extension
{
    
    public static int SumTotal(this ArrayList array)
    {
        int sum = 0;         
        foreach (int @int in array)
            sum += @int;
        return sum;
    }  
    public static void SortReverseList(this ArrayList arrays)
    {
        arrays.Sort();
        arrays.Reverse();
        foreach (var array in arrays) 
            Console.WriteLine(array.ToString());
    }
    public static bool IsPrime(this int @int)
    {
        int begin = 2;
        bool status = true;
        while (begin < @int)
        {
            if (@int % begin == default)
                status = false;
            begin++;
        }
        return status;
    }
    public static int[] EnterNumbers(this int[] @int)
    {
        for (int i = 0; i < @int.Length; i++)
        {
        again:
            Console.Write($"{i + 1}. Sayı Giriniz : ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number >= 2)
                @int[i] = number;
            else
            {
                Console.WriteLine("En küçük asal sayı 2'dir bu yüzden 2'den büyük pozitif sayı giriniz...");
                goto again;
            }
        }
        return @int;
    }
}