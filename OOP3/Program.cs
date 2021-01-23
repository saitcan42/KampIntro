using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            IKrediManager konutKrediManager2 = new KonutKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();
 

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager2);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager2, tasitKrediManager2};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
