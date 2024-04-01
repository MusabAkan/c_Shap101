internal partial class Program
{
    public class UserInput
    {
        public static int GetRadius()
        {
            while (true)
            {
                Console.Write("Çemberin yarıçapını girin: ");
                if (int.TryParse(Console.ReadLine(), out int radius) && radius > 0)
                {
                    return radius;
                }
                Console.WriteLine("Lütfen pozitif bir tamsayı girin");
            }
        }
    }
}