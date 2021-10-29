using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 56;
            musteri1.MusteriNu = "12345";
            musteri1.MusteriAd = "emine";
            musteri1.MusteriSoyad = "çelik";
            musteri1.TcNu = "31318666442";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 12;
            musteri2.MusteriNu = "54321";
            musteri2.SirketAdi = "sena grup";
            musteri2.VergiNu = "123456789";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);




        }
    }
}
