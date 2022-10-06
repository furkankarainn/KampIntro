using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bir veri üzerinde matematiksel işlem yapmıyorsan bu verileri string olarak tanımlamak daha iyi olur veri uyumluluğu açısından.
    //İndividialCustomer
    class GercekMusteri : Musteri//Inheritence budur. Gercek müsteri bir müsteridir şekli, miras demek
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
