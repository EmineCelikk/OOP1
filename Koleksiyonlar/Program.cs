using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "emine", "fatmanur", "hatice" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler[3] = "hasan";
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string>()
            {
                "emine","fatmanur","hatice"
            };

            isimler2.Add("hasan");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("nazan");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);


            Console.WriteLine("\n\n\n\n****************************************\n");
            //**************************
            //eğer list diye bir şey olmasaydı list yapısını array ile nasıl yapardık?

            string[] sehirler = new string[] { "ankara", "istanbul", "izmir" };

            Console.WriteLine("şehirler listesi: ");
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }


            string sehir = "adana";

            string[] sehirler2 = new string[sehirler.Length+1];

            for (int i = 0; i < sehirler.Length; i++)
            {
                sehirler2[i] = sehirler[i];
                sehirler2[sehirler.Length] = sehir;
            }

            Console.WriteLine("\n\nşehirler yeni listesi: ");
            for (int i = 0; i < sehirler2.Length; i++)
            {
                Console.WriteLine(sehirler2[i]);
            }


        }

        
         

    }
}
