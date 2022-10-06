using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Dependence injection(Method injection)=> hangi kredi türü  ve hangi loglayıcı olucak enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
