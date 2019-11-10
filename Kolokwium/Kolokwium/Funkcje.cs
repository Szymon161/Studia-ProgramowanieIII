using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Funkcje
    {
        public static bool CzyPunktNalezyDoWykresu(double x, double y)
        {
            return y == 0.5 * x * x - 10 * x + 1;
        }

        //2D
        public string SzyfrCezara(string napis, int iloscZnakow)
        {
            StringBuilder sb = new StringBuilder(napis);

            for (int i = 0; i < sb.Length; i++)
            {
                int wartosc = sb[i] + iloscZnakow;
                sb[i] = (char)wartosc;
            }

            return sb.ToString();
        }

        //3D
        public void PrzeszukiwanieTablicyPoszarpanej(int[][] tablica, int parametr)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    if (tablica[i][j] == parametr)
                    {
                        Console.WriteLine("Indeks tablicy: [" + i + "][" + j + "]");
                    }
                }
            }
        }
    }
}