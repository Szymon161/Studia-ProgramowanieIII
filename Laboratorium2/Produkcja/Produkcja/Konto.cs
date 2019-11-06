using System.Collections.Generic;

namespace Produkcja
{
    class Konto
    {
        internal readonly string login;
        internal readonly string haslo;
        internal const string ŚcieżkaDoKatalogu = "D:/Program";
        internal readonly string ŚcieżkaDoPliku;

        internal List<Produkt> listaProduktów;

        private Konto(string login, string haslo, string produkt1, string produkt2, string produkt3)
        {
            this.login = login;
            this.haslo = haslo;

            ŚcieżkaDoPliku = $"D:/Program/{login}.txt";

            listaProduktów = new List<Produkt>()
            {
                new Produkt(produkt1),
                new Produkt(produkt2),
                new Produkt(produkt3)
            };
        }

        static public List<Konto> StwórzKonta()
        {
            List<Konto> konta = new List<Konto>()
            {
                new Konto("szymon", "szymon", "Mleko", "Sok  ", "Kawa "),
                new Konto("haker", "123", "Nektar ", "Herbata", "Keczup "),
                new Konto("programowanie", "ATH", "Marmolada", "Czekolada", "Musztarda")
            };

            return konta;
        }
    }
}
