namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici olarak oluşturuldu
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
                items[i] = tempArray[i];
            items[items.Length - 1] = item; // eklenmesi gereken elemanı şuanda eklenmesi 
        }
        public int Length
        {
            get { return items.Length; } 
        }
        public T[] Items { get { return items; } }

        public void Read()
        {
            foreach (T item in items)
                Console.WriteLine(item);
        }
    }
}
