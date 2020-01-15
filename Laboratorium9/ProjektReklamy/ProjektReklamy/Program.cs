using System;

namespace ProjektReklamy
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wpisz liczbe: ");
            int liczba = int.Parse(Console.ReadLine());

            int wynik, resztaZDzielenia;
            (wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);

            Console.WriteLine($"{liczba} / 3 = {wynik} r {resztaZDzielenia}");

            string napis = "PROGRAMOWANIE to fajna rzecz jest!";

            Console.WriteLine(napis.ZliczLitery('a'));

            var reklama1 = new Reklama("Na problemy z konarami i chwastami", PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Mlodziez, Zainteresowania.Sport);
            reklama1.Test();

            var reklama2 = new Reklama("Zeszyty do matematyki. Promocja! 50gr/szt.!", PrzedzialWiekowy.Dzieci | PrzedzialWiekowy.Mlodziez, Zainteresowania.Matematyka);
            reklama2.Test();

            Console.WriteLine(reklama2.przedzialWiekowy.CzyDlaPelnoletnich());

            Console.ReadKey();
        }
    }
}
