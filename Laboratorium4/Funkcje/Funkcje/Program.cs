using System;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = { "AAA", "BBB", "CCC", "DDD", "EEE" };
            
            int[,] tablicaDwuwymiarowa =
            { 
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
            };

            int[][] tablicaPoszarpana = 
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 3 },
                new int[] { 1 }
            };

            Console.Write("Tablica:\t");
            Tablice<string>.WypiszTablice(tablica);

            Console.Write("Kopia Tablicy:\t");
            Tablice<string>.WypiszTablice(Tablice<string>.KopiowanieTablicy(tablica));

            Console.Write("Tablica Dwuwymiarowa:\t\t");
            Tablice<int>.WypiszTablice(tablicaDwuwymiarowa);

            Console.Write("Kopia Tablicy Dwuwymiarowej:\t");
            Tablice<int>.WypiszTablice(Tablice<int>.KopiowanieTablicyDwuwymiarowej(tablicaDwuwymiarowa));

            Console.Write("Tablica Poszarpana:\t\t");
            Tablice<int>.WypiszTablice(tablicaPoszarpana);

            Console.Write("Kopia Tablicy Poszarpanej:\t");
            Tablice<int>.WypiszTablice(Tablice<int>.KopiowanieTablicyPoszarpanej(tablicaPoszarpana));

            int liczba1 = 1;
            int liczba2 = 2;

            Fun(liczba1);
            FunRef(ref liczba2);
            FunOut(out int liczba3);

            Console.WriteLine($"Liczba1: {liczba1}\nLiczba2: {liczba2}\nLiczba3: {liczba3}");

            Console.ReadKey();
        }

        static void Fun(int n)
        {
            n = 456;
        }

        static void FunRef(ref int n)
        {
            n = 456;
        }

        static void FunOut(out int n)
        {
            n = 456;
        }
    }
}