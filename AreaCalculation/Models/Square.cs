
// Kare sınıfı
class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea() => Side * Side;

    public override double CalculatePerimeter() => 4 * Side;
}
