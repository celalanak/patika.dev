using System;

namespace patika.dev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.Write("İsminizi girin: ");
            string name = Console.ReadLine();

            System.Console.Write("Soyisminizi girin: ");
            string surName = Console.ReadLine();

            System.Console.Write("Merhaba {0} {1}", name,surName);

            Console.ReadKey();
        }
    }
}
