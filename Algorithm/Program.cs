﻿internal class Program
{

    private static void Main(string[] args)
    {
        Console.Write("Değer Gir : ");
        string input = Console.ReadLine();

        Console.WriteLine(input.ExtractCharacterFromIndex());
        Console.ReadKey();

    }

    /*
Algoritma
Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

Output: Algritma Algortma Algoritma lgoritma

*/
}
