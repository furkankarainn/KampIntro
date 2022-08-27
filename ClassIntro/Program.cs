using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 25;
            Kurs kurs1 = new Kurs(); // kurs tipinde(int,string gibi) kurs1 oluşturduk.
            //Parametreleri şu şekilde tanımlarız:
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Furkan";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Furkan";
            kurs2.IzlenmeOrani = 23;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Furkan";
            kurs3.IzlenmeOrani = 100;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Go";
            kurs4.Egitmen = "birisi";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " : " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    //Kurs adlı class açtık ve içine değişkenleri tanımladık.
}
