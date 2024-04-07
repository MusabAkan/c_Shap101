namespace GenericsIntro
{
    class MyDictionary<Key, Value>
    {
        Key[] _keys;
        Value[] _values;
        public MyDictionary()
        {
            _keys = new Key[0];
            _values = new Value[0];
        }

        public void GetAllList()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine($"Key [{i}] : {_keys[i]}, Value [{i}] : {_values[i]}");
            }
        }

        public void Add(Key keys, Value values)
        {
            Key[] _tempKeys = _keys;
            Value[] _tempValues = _values;

            _keys = new Key[_keys.Length + 1];
            _values = new Value[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length -1] = keys;
            _values[_values.Length - 1] = values;
        }
    }


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
