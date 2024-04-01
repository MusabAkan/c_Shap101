internal partial class Program
{
    private static void Main(string[] args)
    {
        int radius = UserInput.GetRadius();
        CircleDrawer.DrawCircle(radius);
    }
} 