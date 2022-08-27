using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Fiyat = 120;
            urun3.Aciklama = "Sason Çileği";

            Urun[] uruns = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun item in uruns)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("****************************************METODLAR*******************************************************");

            //instance(class örneği oluşturmak.)
            //encapsulation(kapsülleme) (methodun parametresini artırdık. stokadedi ekledik. sadece classa eklediğimizde hiçbir yerde patlamıyor. Çünkü biz urun tipinde gonderdik. Hiçbir yeri değiştirmemize gerek kalmadı.)
            //ayrı ayrı yazıcağın yapıyı bir kapsülün içine sokup düzenli yazmak demek => encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır armut", 12, 8);

            Console.WriteLine("--------------------------------------------------");


            int number1 = 20;
            int number2 = 100;
            var result = add3(number1, number2);
            //dersek burda number1 değerini yazdırırsak gene 20 yazıcaktır
            //AMA

            int number3 = 20;
            int number4 = 100;
            var result2 = add3(ref number3, number4);
            //dersek ref olarka gönderdiği için number3 yazdırdığımızda 30 yazıcaktır.
            //VE


            int number5;
            int number6 = 100;
            var result3 = add4(out number5, number6);

            //ref ve out aynı kullanılır. tek farkları refte göndermeden değer atamak gereki. ama outta değer atamadan gönderebilirsin.

            Console.ReadLine();
        }

        static int add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int add3(ref int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
        }
        static int add4(out int number5, int number6)
        {
            number5 = 30;
            return number5 + number6;
        }
    }

}

//DRY---CLEAN CODE--- BEST PRACTICE(EN İYİ UYGULAMA TEKNİKLERİ)