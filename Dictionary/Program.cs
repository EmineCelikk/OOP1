using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();

            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add(4, "four");

            foreach (KeyValuePair<int,string> item in numberNames)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }


            Console.WriteLine("\n*****************************\n");
            MyDictList<int, string> numberNames2 = new MyDictList<int, string>();
            numberNames2.Add(3, "three");
            numberNames2.Add(2, "Two");
            numberNames2.Add(3, "Three");
            numberNames2.Add(4, "four");

            numberNames2.Getir();

            

        }
    }

    class MyDictList<K, V>
    {
        K[] diziKey;
        V[] diziValue;

        K[] diziKeyTemp;
        V[] diziValueTemp;


        public MyDictList()
        {
            diziKey = new K[0];
            diziValue = new V[0];

        }
        public void Add(K item1,V item2)
        {
            diziKeyTemp = diziKey;
            diziValueTemp = diziValue;

            diziKey = new K[diziKey.Length + 1];
            diziValue = new V[diziValue.Length + 1];

            for (int i = 0; i < diziKeyTemp.Length; i++)
            {
                diziKey[i] = diziKeyTemp[i];
                diziValue[i] = diziValueTemp[i];

            }
            diziKey[diziKey.Length - 1] = item1;
            diziValue[diziValue.Length - 1] = item2;

        }
        

        public void Getir()
        {
            for (int i = 0; i < diziValue.Length; i++)
            {
                Console.WriteLine(diziKey[i]+" - "+diziValue[i]);
            }
        }

    }


}
