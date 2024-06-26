﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal partial class Program
{
    private static void Main(string[] args)
    {
        List<int> sayilarListesi = [13, 24, 332, 44];

        List<string> metinListesi = new();

        metinListesi.Add($"{Environment.NewLine} Kırmız");
        metinListesi.Add($"{Environment.NewLine} Yeşil");
        metinListesi.Add($"{Environment.NewLine} Pembe");
        metinListesi.Add($"{Environment.NewLine} Turuncu");


        foreach (int i in sayilarListesi)
            Console.WriteLine(i);

        metinListesi.ForEach(i => Console.WriteLine(i));



    }

    private static void homework_1_4()
    {
        Console.Write("Metin Giriniz : ");
        string text = Convert.ToString(Console.ReadLine());
        text.WordSplit();
    }



    #region homework
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

    private static void homework_1_3()
    {
        Console.Write("Adet Sayısı Giriniz : ");
        int.TryParse(Console.ReadLine(), out int piece);

        piece.IsPostive();

        string[] words = new string[piece];

        words.EnterTextArray();
        words.WriteTextsBackwards();
    }
    #endregion    
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
