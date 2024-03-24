using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //question_1();
        //question_2();
    }

    private static void question_2()
    {
        int[] numbers = new int[20];
        numbers.EnterNumbers();

        ArrayList numberList = new(numbers);

        numberList.SortReverseList();

        int counter = 0, minSum = 0, maxSum = 0;
        double minAvg = 0, maxAvg = 0;
        foreach (int number in numberList)
        {
            if (counter < 3)
                maxSum = number;
            if (counter >= 17)
                minSum = number;
            counter++;
        }
        minAvg = Convert.ToDouble(minSum / 3);
        maxAvg = Convert.ToDouble(maxSum / 3);

        Console.WriteLine($"En Büyük 3 Sayılar : {numberList[0]},{numberList[1]},{numberList[3]}");
        Console.WriteLine("En Büyük 3 Sayıların Ortalaması" + minAvg);

        Console.WriteLine($"En Küçük 3 Sayılar : {numberList[17]},{numberList[18]},{numberList[19]}");
        Console.WriteLine("En Küçük 3 Sayıların Ortalaması :" + maxAvg);

        Console.WriteLine("Tüm Sayıların Ortalaması : " + maxAvg + minAvg);

        Console.ReadKey();
    }

    private static void question_1()
    {
        int[] numbers = new int[20];
        numbers.EnterPrimeNumbers();

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
        primeList.PrintScreen();

        Console.WriteLine("***** Asal Olmayan Sayılar Listesi *****");
        primeNotList.SortReverseList();
        primeList.PrintScreen();

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
    public static void PrintScreen(this ArrayList arrays)
    {
        foreach (var array in arrays)
            Console.WriteLine(array.ToString());
    }



    public static void SortReverseList(this ArrayList arrays)
    {
        arrays.Sort();
        arrays.Reverse();
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

            Console.Write($"{i + 1}. Sayı Giriniz : ");
            int.TryParse(Console.ReadLine(), out int number);
            @int[i] = number;
        }
        return @int;
    }

    public static int[] EnterPrimeNumbers(this int[] @int)
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

    /*
    Ödev - 2
    Aşağıdaki 3 soruyu ayrı ayrı console uygulamaları açarak yazınız. Koleksiyonlar-Soru-1, Koleksiyonlar-Soru-2, Koleksiyonlar-Soru-3 isimlerini kullanınız.

    Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

    Negatif ve numeric olmayan girişleri engelleyin.
    Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
    Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

    Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
     
     
     */
}