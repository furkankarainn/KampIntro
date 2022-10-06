using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bir veri üzerinde matematiksel işlem yapmıyorsan bu verileri string olarak tanımlamak daha iyi olur veri uyumluluğu açısından.
    //CoorporateCustomer
    class TuzelMusteri: Musteri//Inheritence budur. Gercek müsteri bir müsteridir şekli, miras demek
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
