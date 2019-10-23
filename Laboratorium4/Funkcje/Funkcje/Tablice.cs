using System;

namespace Funkcje
{
    static class Tablice<T>
    {
        internal static void WypiszTablice(T[] tablica)
        {
            foreach (T item in tablica)
            {
                Console.Write(item.ToString() + ' ');
            }
            Console.WriteLine();
        }

        internal static void WypiszTablice(T[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(1); i++)
            {
                for (int j = 0; j < tablica.GetLength(0); j++)
                {
                    Console.Write(tablica[i, j].ToString() + ' ');
                }
            }
            Console.WriteLine();
        }

        internal static void WypiszTablice(T[][] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    Console.Write(tablica[i][j].ToString() + ' ');
                }
            }
            Console.WriteLine();
        }

        internal static T[] KopiowanieTablicy(T[] tablicaOryginalna)
        {
            var kopia = new T[tablicaOryginalna.Length];

            for (int i = 0; i < tablicaOryginalna.Length; i++)
            {
                kopia[i] = tablicaOryginalna[i];
            }

            return kopia;
        }

        internal static T[,] KopiowanieTablicyDwuwymiarowej(T[,] tablicaOryginalna)
        {
            var kopia = new T[tablicaOryginalna.GetLength(1), tablicaOryginalna.GetLength(0)];

            for (int i = 0; i < tablicaOryginalna.GetLength(1); i++)
            {
                for (int j = 0; j < tablicaOryginalna.GetLength(0); j++)
                {
                    kopia[i, j] = tablicaOryginalna[i, j];
                }
            }

            return kopia;
        }

        internal static T[][] KopiowanieTablicyPoszarpanej(T[][] tablicaOryginalna)
        {
            var kopia = new T[tablicaOryginalna.Length][];

            for (int i = 0; i < tablicaOryginalna.Length; i++)
            {
                kopia[i] = new T[tablicaOryginalna[i].Length];

                for (int j = 0; j < tablicaOryginalna[i].Length; j++)
                {
                    kopia[i][j] = tablicaOryginalna[i][j];
                }
            }

            return kopia;
        }
    }
}