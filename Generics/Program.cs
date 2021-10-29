using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("adana");

        }


        class MyList<T>
        {
            T[] dizi;
            
            public MyList()
            {
                dizi = new T[0];

            }

            public void Add(T item)
            {

                T[] geciciDizi = dizi;
                dizi = new T[dizi.Length + 1];

                for (int i = 0; i < geciciDizi.Length; i++)
                {
                    geciciDizi[i] = dizi[i];
                }

                dizi[dizi.Length - 1] = item;

            }


        }

    }
}
