using System;
using System.Text;

namespace Kolokwium
{
    //grupa D
    class Program
    {

        static void Main(string[] args)
        {
            int[][] tablica =
            {
                new[] { 3, 4 },
                new[] { 2, 6, 1, },
                new[] { 11, 5, 123, }
            };

            Console.WriteLine(Funkcje.CzyPunktNalezyDoWykresu(0, 1));

            var f = new Funkcje();

            Console.WriteLine(f.SzyfrCezara("abcDEF", 1));

            f.PrzeszukiwanieTablicyPoszarpanej(tablica, 6);

            Console.ReadKey();
        }
    }
}
