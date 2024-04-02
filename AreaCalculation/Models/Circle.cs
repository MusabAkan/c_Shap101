internal partial class Program
{
    // Daire sınıfı
    class Circle : Shape

    {
        private double Radius { get; set; }

        public override double CalculateArea() => Math.PI * Radius * Radius;

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override void CalculateCreate()
        {
        again:
            Console.WriteLine("Dairenin yarıçapını girin:");
            if (double.TryParse(Console.ReadLine(), out double radius))
                Radius = radius;
            else
            {
                Console.Clear();
                goto again;
            }
        }
    }
}