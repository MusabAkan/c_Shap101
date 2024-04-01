internal partial class Program
{
    public class AverageCalculator
    {
        public static double CalculateAverage(List<int> sequence)
        {
            return sequence.Any() ? sequence.Average() : 0;
        }
    }
}