using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }


        //params keywords
        //params ile istediğimiz kadar parametre gönderebiliriz
        public int topla2(params int[] numbers)
        {
            return numbers.Sum();
        }
        //şu şekilde de kullanabiliriz
        //ama params kullanıyorsan params son parametre olmak zorunda
        public int topla3(int x,params int[] numbers)
        {
            return numbers.Sum();
            //bu numbers.sum da Sum hazır fonksiyondur. Ondan faydalandık.
        }
    }
}
