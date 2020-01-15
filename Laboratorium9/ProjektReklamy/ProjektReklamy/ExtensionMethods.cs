namespace ProjektReklamy
{
    public static class ExtensionMethods
    {
        public static (int, int) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int ZliczLitery(this string tekst, char litera)
        {
            int licznik = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == litera)
                {
                    licznik++;
                }
            }

            return licznik;
        }

        public static int ZliczLitery(this string tekst, char znak, bool caseInsensitive)
        {
            if (caseInsensitive)
            {
                tekst.ToLower();
                char.ToLower(znak);
            }

            return tekst.ZliczLitery(znak);
        }

        public static bool CzyDlaPelnoletnich(this PrzedzialWiekowy przedzialWiekowy)
        {
            return !przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci) || !przedzialWiekowy.HasFlag(PrzedzialWiekowy.Mlodziez);
        }
    }
}