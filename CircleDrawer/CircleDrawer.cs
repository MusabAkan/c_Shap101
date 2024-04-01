internal partial class Program
{
    public class CircleDrawer
    {
        public static void DrawCircle(int radius)
        {
            double centerX = radius + 0.5; // 0.5 ekleyerek ortalamaları alıyoruz
            double centerY = radius + 0.5; // 0.5 ekleyerek ortalamaları alıyoruz

            for (int i = 0; i <= 2 * radius; i++)
            {
                for (int j = 0; j <= 2 * radius; j++)
                {
                    double distanceToCenter = Math.Sqrt(Math.Pow(i - centerX, 2) + Math.Pow(j - centerY, 2));
                    if (distanceToCenter > radius - 0.5 && distanceToCenter < radius + 0.5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}