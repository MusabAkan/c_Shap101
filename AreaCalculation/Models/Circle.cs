internal partial class Program
{
    // Daire sınıfı
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea() => Math.PI * Radius * Radius;

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }
}