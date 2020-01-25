using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
    class Produkt
    {
        public string Nazwa { get; set; }
        double Cena { get; set; }
        string Opis { get; set; }
        DateTime DataWaznosci { get; set; }
        int Ilosc { get; set; }
        public Produkt(string nazwa, double cena, string opis, DateTime dataWaznosci, int ilosc)
        {
            Nazwa = nazwa;
            Cena = cena;
            Opis = opis;
            DataWaznosci = dataWaznosci;
            Ilosc = ilosc;
            WybranoProdukt += UruchomPodajnikEventHandler;
            WybranoProdukt += WypiszKomunikatEventHandler;
            WybranoProdukt += SprzedanoProduktEventHandler;
        }

        public string Dekonstruktor()
        {
            return $"{Nazwa}, cena: {Cena}zl";
        }

        public string Dekonstruktor2()
        {
            if (DateTime.Now.AddDays(1) > DataWaznosci)
            {
                return "MNIEJ NIZ 1 DZIEN!";
            }

            else if (DateTime.Now.AddDays(7) > DataWaznosci)
            {
                return "mniej niz tydzien";
            }

            else
            {
                return $"{Nazwa}, cena:{Cena}zl, opis: {Opis}, data waznosci{DataWaznosci.ToShortDateString()}";
            }
        }

        public event EventHandler WybranoProdukt;

        public void ProduktSprzedany()
        {
            if (Ilosc > 0)
            {
                Ilosc--;
                WybranoProdukt?.Invoke(this, EventArgs.Empty);
            }
        }

        private void UruchomPodajnikEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("Uruchomiono podajnik!");
        }

        private void WypiszKomunikatEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine($"Wypisano komunikat {DateTime.Now}");
        }

        private void SprzedanoProduktEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine($"Sprzedano produkt {Nazwa}");
        }

    }
}
