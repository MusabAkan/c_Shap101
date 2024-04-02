internal class Program
{

    private static void Main(string[] args)
    {
        Console.Write("Değer Gir : ");
        string input = Console.ReadLine();

        //Console.WriteLine(input.ExtractCharacterFromIndex());
        //Console.WriteLine(input.ReplacesThePreviousCharacter());
        //Console.Write(input.AbsoluteSquareSearch());
        Console.Write(input.ChangeFirstLastCharacter());

        Console.ReadKey();
    }

    /*
    Algoritma - 1
    Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

    Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

    Output: Algritma Algortma Algoritma lgoritma

    Algoritma - 2
    Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.

    Örnek: Input: Merhaba Hello Question

    Output: erhabaM elloH uestionQ

    Algoritma - 3
    Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa"toplamının   karesini ekrana yazdıran console uygulamasını yazınız.
    
    Örnek Input: 2 3 1 5 2 5 3 3
    
    Output: 5 6 7 81

    Algoritma - 4
    Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

    Örnek: Input: 56 45 68 77

    Output: 33 101

    Algoritma - 5  
    Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

    Örnek: Input: Merhaba Hello Algoritma x

    Output: aerhabM oellH algoritmA x

    */
}
