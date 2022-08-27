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

            sepetManager.Ekle2("Armut", "Yeşil armut", 12 , 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır armut", 12, 8);



            Console.ReadLine();
        }
    }
}

//DRY---CLEAN CODE--- BEST PRACTICE(EN İYİ UYGULAMA TEKNİKLERİ)