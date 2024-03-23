public static class Library
{

    public static void WriteTextsBackwards(this string[] arrays)
    {
        for (int i = arrays.Length; i != 0; i--)
            Console.WriteLine(arrays[i - 1]);
        Console.ReadKey();
    }

    public static void WordSplit(this string text)
    {
        string[] splits = text.Split(' ');

        int totalLetter = 0, totalWord = 0;

        for (int i = 0; i < splits.Length; i++)
            if (splits[i].Trim() != string.Empty)
                totalWord++;

        foreach (string? split in splits)
            totalLetter += split.Trim().Length;


        Console.WriteLine("Toplam Girilen Cümle : " + totalWord);
        Console.WriteLine("Toplam Girilen Harf : " + totalLetter);

        Console.ReadKey();
    }

    public static string[] EnterTextArray(this string[] arrys)
    {
        for (int i = 0; i < arrys.Length; i++)
        {
            Console.Write($"{i + 1}. Metin Giriniz : ");
            string text = Console.ReadLine();
            arrys[i] = text;
        }
        return arrys;
    }
}
