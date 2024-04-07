using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {

        MyDictionary<string, int> dictionary = new();

       


        dictionary.Add("ayşe", 5);
        dictionary.Add("teyze", 6);
        dictionary.Add("Kayınço", 7);
        dictionary.Add("lale", 8);

        dictionary.GetAllList();

        Console.ReadKey();


        //MyList<string>  isimler = new MyList<string>();
        // isimler.Add("Ayşe");
        // isimler.Add("Fatma");
        // isimler.Add("Denizli");
        // isimler.Add("Rize"); 
        // isimler.Read();
        //Console.WriteLine(isimler.ToString());
    }
}