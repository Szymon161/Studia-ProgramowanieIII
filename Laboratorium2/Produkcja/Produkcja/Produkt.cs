namespace Produkcja
{
    public class Produkt
    {
        public uint IloscProduktu { get; set; }

        public string NazwaProduktu { get; set; }

        public Produkt(string nazwaProduktu)
        {
            NazwaProduktu = nazwaProduktu;
        }

        public void Produkuj() => IloscProduktu++;

        public override string ToString() => NazwaProduktu + "\t wyprodukowana ilosc: " + IloscProduktu;
    }
}
