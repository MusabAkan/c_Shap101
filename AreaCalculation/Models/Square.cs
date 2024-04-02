
// Kare sınıfı
class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea() => Side * Side;

    public override double CalculatePerimeter() => 4 * Side;

    public override void CalculateCreate()
    {
    again:
        Console.WriteLine("Karenin bir kenar uzunluğunu girin:");
        if(double.TryParse(Console.ReadLine(), out double side))
            Side = side;
        else
        {
            Console.Clear();
            goto again;
        }
    }
}
