using System;

namespace ProjektReklamy
{
    [Flags]
    public enum PrzedzialWiekowy
    {
        Dzieci = 1,
        Mlodziez = 2,
        Dorosli = 4,
        Starsi = 8
    }

    public enum Zainteresowania
    {
        Elektronika,
        Motoryzacja,
        Sport,
        Sztuka,
        Historia,
        Matematyka
    }

}
