namespace Produkcja
{
    public class Produkt
    {
        private static System.Random random = new System.Random();

        private uint iloscProduktu = 0;

        private readonly string nazwaProduktu;

        private Produkt() => nazwaProduktu = LosujNazweProduktu();

        private string LosujNazweProduktu()
        {
            string[] nazwy = { "Czekolada", "Marmolada", "Herbata  ", "Kawa     ", "Kakao    ", "Sok      ",
            "Mleko    ", "Krem     ", "Cukierki ", "Lizaki   ", "Jogurt   ", "Kefir    " };

            return nazwy[random.Next(nazwy.Length)];
        }

        public static Produkt[] Stworz3Produkty()
        {
            Produkt[] produkty = { new Produkt(), new Produkt(), new Produkt() };
            return produkty;
        }

        public void Produkuj() => iloscProduktu++;

        public override string ToString() => nazwaProduktu + "\t wyprodukowana ilosc: " + iloscProduktu;
    }
}
