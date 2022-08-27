using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? => (30)



            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? => (999)
            //referans tiplerden geliyor olay, yani sayilar2 nin referans numarasını sayilar1 in referans numarasına veriyorsun
            //o sebeple sayilar2 yi değiştirdiğinde sayilar1de aynı referans numarasına baktığı için onunda 0 ıncı elemanı değişmiş gözükür. pointer deniyor bunada
            // sayilar1in ilk referans numarasını tuttuğu adresteki diziyse çöp toplayıcısı bir süre sonra silip bellekten atıcak. Çünkü kullanılmıyor.

            //int,decimal,float,double,bool = değer tip
            //array,class,interface = referans tip0

        }
    }
}
