using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //başvuran bilgileri değerlendirme
            //
            //kredi hesaplarız

            //* eğer aşağıdaki gibi hesaplama yapar isek tüm
            //başvuru değerlendirmelerini konut kredisine göre yapmış oluruz
            //bu da yanlış bir uygulama

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //**bu yüzden başvuru yaparken hangi kredi türünde 
            //başvuru gerçekleşiyor bilmek için parametre alalım...


            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

    }
}
