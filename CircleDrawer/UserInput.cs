internal partial class Program
{
    public class UserInput
    {
        public static int GetRadius()
        {
            while (true)
            {
                Console.Write("Enter the radius of the circle: ");
                if (int.TryParse(Console.ReadLine(), out int radius) && radius > 0)
                {
                    return radius;
                }
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}