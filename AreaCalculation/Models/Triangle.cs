
// Üçgen sınıfı
class Triangle : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public override double CalculateArea()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }
    public override double CalculatePerimeter() => Side1 + Side2 + Side3;
}
