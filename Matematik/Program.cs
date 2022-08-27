using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5, 6);

            Console.WriteLine("****************PARAMS KEYWORDS******************");


            var result = dortIslem.topla2(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(result);
        }
    }
}
