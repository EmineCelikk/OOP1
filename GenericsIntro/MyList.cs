using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] dizi1;
        public MyList()
        {
            dizi1 = new T[0];
        }
        public void Add(T item)
        {
            T[] geciciDizi = dizi1;

            dizi1 = new T[dizi1.Length + 1];

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                dizi1[i] = geciciDizi[i];
            }
            dizi1[dizi1.Length-1] = item;


        }


    }
}
