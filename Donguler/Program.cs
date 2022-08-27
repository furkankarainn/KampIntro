using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java","C#" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("-" + kurslar[i]);
            }
            Console.WriteLine("---------------------------------");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("-" + kurs);
            }
        }
    }
}
