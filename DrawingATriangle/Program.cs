internal partial class Program
{
    private static void Main(string[] args)
    {
        int size = UserInput.GetSize();
        TriangleDrawer.DrawTriangle(size);
    }
}