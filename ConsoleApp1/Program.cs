using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
       MyList<string>  isimler = new MyList<string>();
        isimler.Add("Ayşe");
        isimler.Add("Fatma");
        isimler.Add("Denizli");
        isimler.Add("Rize"); 
        isimler.Read();
        //Console.WriteLine(isimler.ToString());
    }
}