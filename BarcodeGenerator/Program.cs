using System.Drawing;
using ZXing;
using ZXing.Common;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Barcode Oluştur");
        Console.WriteLine("2. Barcode Oku");
        Console.Write("Seçiminizi yapın: ");
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    GenerateBarcode();
                    break;
                case 2:
                    ReadBarcode();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
    }

    static void GenerateBarcode()
    {
        Console.Write("Barcode içeriğini girin: ");
        string content = Console.ReadLine();
        Console.Write("Dosya adını girin (uzantı olmadan): ");
        string fileName = Console.ReadLine() + ".png";

        //BarcodeWriter barcodeWriter = new()
        //{
        //    Format = BarcodeFormat.QR_CODE,
        //    Options = new EncodingOptions { Height = 325, Width = 325 }
        //};

        //Bitmap bitmap = barcodeWriter.Write(content);
        //bitmap.Save(fileName);
        Console.WriteLine($"Barcode dosyaya kaydedildi: {fileName}");
    }

    static void ReadBarcode()
    {
        Console.Write("Okunacak dosyanın adını girin (uzantı olmadan): ");
        string fileName = Console.ReadLine() + ".png";

        BarcodeReader barcodeReader = new();
        var image = Image.FromFile(fileName);

        byte[] imageBytes = ImageToByteArray(image);
        var result = barcodeReader.Decode(imageBytes);

        if (result != null)
        {
            Console.WriteLine($"Okunan Barcode içeriği: {result.Text}");
        }
        else
        {
            Console.WriteLine("Barcode bulunamadı veya okunamadı!");
        }
    }

    private static byte[] ImageToByteArray(Image image)
    {
        using (MemoryStream memoryStream = new())
        {
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
    }
}
