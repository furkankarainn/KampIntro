using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> myDictionary = new MyDictionary<int>();
            myDictionary.Add(112);
            myDictionary.Add(112);
            myDictionary.Add(112);
            Console.WriteLine(myDictionary.Count);

            Console.ReadLine();
        }
    }

    class MyDictionary<T>
    {
        T[] _array;
        public MyDictionary()
        {
            _array = new T[0];
        }
        
        public void Add(T item)
        {
            T[] _tempArray = _array;

            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_tempArray.Length] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }


    }
}
