using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium
{
    class Program
    {
        static private Random rand = new Random();

        static DateTime LosujDate()
        {
            return new DateTime((long)rand.Next()*100000000);
        }

        static void Main()
        {
            var kolekcja = new List<DateTime>();

            for (int i = 0; i < 200; i++)
            {
                kolekcja.Add(LosujDate());
            }

            Console.WriteLine(LosujDate());

            IEnumerable ienumerable = kolekcja;

            var puszkaPepsi = new Produkt("Pepsi", 2.99, "zwykla puszka pepsi", new DateTime(2020, 12, 6), 3);

            puszkaPepsi.ProduktSprzedany();

            Console.ReadKey();
        }
    }
}
