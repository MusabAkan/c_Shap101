public class UserInput
{
    public static int GetSize()
    {
        while (true)
        {
            Console.Write("Enter the size of the triangle: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
                return size;
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
