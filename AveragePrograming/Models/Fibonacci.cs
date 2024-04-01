internal partial class Program
{
    public class Fibonacci
    {
        public static List<int> GenerateSequence(int n)
        {
            List<int> fibonacciSequence = new List<int> { 0, 1 };
            for (int i = 2; i < n; i++)
            {
                fibonacciSequence.Add(fibonacciSequence[i - 1] + fibonacciSequence[i - 2]);
            }
            return fibonacciSequence;
        }
    }
}