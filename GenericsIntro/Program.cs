using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("emine");
            isimler.Add("fatmanur");



            Console.WriteLine("Hello World!");
        }
    }
}
