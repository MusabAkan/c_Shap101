
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
    public override void CalculateCreate()
    {
        Console.WriteLine("Üçgenin ilk kenarını girin:");
        Side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Üçgenin ikinci kenarını girin:");
        Side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Üçgenin üçüncü kenarını girin:");
        Side3 = double.Parse(Console.ReadLine());
    }


}
