
// Dikdörtgen sınıfı
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public override double CalculateArea() => Length * Width;
    public override double CalculatePerimeter() => 2 * (Length + Width);
    public override void CalculateCreate()
    {
    again1:
        Console.WriteLine("Dikdörtgenin uzun kenarını girin:");
        if (double.TryParse(Console.ReadLine(), out double length))
            Length = length;
        else
        {
            Console.Clear();
            goto again1;
        }
    again2:
        Console.WriteLine("Dikdörtgenin kısa kenarını girin:");
        if (double.TryParse(Console.ReadLine(), out double width))
            Width = width;
        else
        {
            Console.Clear();
            goto again2;
        }
    }

}
