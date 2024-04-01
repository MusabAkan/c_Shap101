internal partial class Program
{
    public static int GetDepth()
    {
        while (true)
        {
            Console.Write("Fibonacci serisinin derinliğini girin: ");
            if (int.TryParse(Console.ReadLine(), out int depth) && depth >= 0)
                return depth;
            Console.WriteLine("Lütfen negatif olmayan bir tam sayı girin.");
        }
    }
    private static void Main(string[] args)
    {
        int depth = GetDepth();
        List<int> fibonacciSequence = Fibonacci.GenerateSequence(depth);
        double average = AverageCalculator.CalculateAverage(fibonacciSequence);
        Console.WriteLine($"Derinliğe kadar Fibonacci serisinin ortalaması {depth}: {average}");
    }

    /*
        Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
        Dikkat Edilmesi Gereken Noktalar :
        Kod tekrarından kaçınılmalıW
        Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
     */
}