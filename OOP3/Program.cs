using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager,new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(tasitKrediManager,databaseLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });


            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //SOLIDIN Osu => sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.
        }
    }
}
