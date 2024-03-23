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
