using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Furkan";
            gercekMusteri.Soyadi = "Karain";
            gercekMusteri.TcNo = "11111111111";
            /// 
            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "123456";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234567890";

            // Burada inherit alıp yapmamızın en önemli sebebi customermanager classına müsteri olarak parametre gönderiyoruz. ve biz inherit aldığımız için tüzel ve gerçek müşterinin ikisinide gönderebiliyoruz.
            //Örneğin;
            Musteri musteri = new GercekMusteri();
            Musteri musteri1 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(musteri);
            customerManager.Ekle(musteri1);
            //Gibi
        }
    }
}
