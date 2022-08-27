using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Void git şunu yap demek. Yani yap bişey döndürme.
        //sonuç döndürmek istiyorsak ne döndürceksek void yerine döndürmek istediğimiz veri tipini yazıcaz. Örn: int ise public int ekle gibi

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi." + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama , double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi." + urunAdi);
        }

        // eğer burada public void Ekle2(string string urunAdi, string aciklama , double fiyat , int stokAdedi=10) nda stokadedi yerine =10 yazarsak default değer 10 demek.Yani parametre verilirse kullan verilmezse 10 kullanır.
        // buradaki önemli husus ise default değer verdiğin parametre en sonda olmak zorundadır. Örneğin fiyata default verseydik çalışmazdı. 



    }

}
