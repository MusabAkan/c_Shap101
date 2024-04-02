
// Dikdörtgen sınıfı
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public override double CalculateArea() => Length * Width;
    public override double CalculatePerimeter() => 2 * (Length + Width);
}
