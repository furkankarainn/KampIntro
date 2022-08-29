using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaries<int> myDictionary = new MyDictionaries<int>();
            myDictionary.Add(112);
            myDictionary.Add(112);
            myDictionary.Add(112);
            myDictionary.Add(112);
            myDictionary.Add(112);
            Console.WriteLine(myDictionary.Count);

            Console.ReadLine();
        }
    }
}
