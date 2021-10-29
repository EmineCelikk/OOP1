using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //konutKrediManager.Hesapla();
            //tasitKrediManager.Hesapla();

            BasvuruManager basvuru = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            basvuru.BasvuruYap(konutKrediManager,databaseLoggerService);
            basvuru.BasvuruYap(tasitKrediManager, new SmsLoggerService());
            basvuru.BasvuruYap(ihtiyacKrediManager,new FileLoggerService());

            Console.WriteLine("\n*********************************\n");
            //***********bir çok başvuru için değerlendirme yapmak için
            List<IKrediManager> krediler = new List<IKrediManager>() {
                ihtiyacKrediManager,
                tasitKrediManager
            };
            basvuru.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
