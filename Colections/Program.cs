﻿internal class Program

{
    private static void Main(string[] args)
    {
        //string[] isimler = new string[] { "Musab", "Bilal", "Mustafa", "Sabit" };

        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);
        //isimler = new string[5];
        //isimler[4] = "Tayip ";
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[0]);

        List<string> isimler = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
        Console.WriteLine(isimler[0]);
        Console.WriteLine(isimler[1]);
        Console.WriteLine(isimler[2]);
        Console.WriteLine(isimler[3]);
        isimler.Add("İlker");




    }
}