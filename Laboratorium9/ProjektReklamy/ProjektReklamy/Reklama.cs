using System;

namespace ProjektReklamy
{
    public class Reklama
    {
        public string Tekst;
        public PrzedzialWiekowy przedzialWiekowy;
        public Zainteresowania zainteresowania;

        public void Test()
        {
            if (!przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dorosli) && !przedzialWiekowy.HasFlag(PrzedzialWiekowy.Starsi))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ta reklama jest dla niepelnoletnich! :)");
                Console.ResetColor();
            }

            if (!przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci) && !przedzialWiekowy.HasFlag(PrzedzialWiekowy.Mlodziez))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ta reklama jest dla pelnoletnich! :o");
                Console.ResetColor();
            }
        }

        public Reklama(string tekst, PrzedzialWiekowy przedzialWiekowy, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            this.przedzialWiekowy = przedzialWiekowy;
            this.zainteresowania = zainteresowania;
        }
    }
}
