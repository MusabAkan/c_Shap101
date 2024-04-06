internal class Program
{
    private static void Main(string[] args)
    {

        List<string> list = new List<string>();
        list.Add("Merhaba");
        Console.WriteLine(list.Count);


        MyList<string> myList = new MyList<string>();//arka tarafın da arraylar yönetiler
        myList.Add("Merhaba");
        Console.WriteLine(myList.Count);
    }
}

class MyList<T> //Generic  arakada 
{
    T[] _array;
    public MyList()
    {
        _array = new T[0];
    }

    public int Count
    {
        get { return _array.Length; }
    }
    /// <summary>
    /// Generic Array  eklem
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        T[] _tempArray = _array;

        _array = new T[_array.Length + 1];

        for (int i = 0; i < _array.Length; i++)
            _array[i] = _tempArray[i];

        _array[_array.Length - 1] = item;

    }
}