using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Produkcja
{
    class ManagerProgramu
    {
        private static List<Konto> konta = Konto.StwórzKonta();

        public static void Zaloguj()
        {
            byte iloscPrób = 0;
            bool poprawnyTylkoLogin = false;
            bool wszystkoŹle = false;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t--- PRODUKCJA ---\n");

                if (poprawnyTylkoLogin)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Niepoprawne haslo");
                }
                else if (wszystkoŹle)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Niepoprawny login i haslo");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Zaloguj sie");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n\n\tPodaj login: ");
                string l = Console.ReadLine();
                Console.Write("\tPodaj haslo: ");
                string h = Console.ReadLine();

                iloscPrób++;

                if (iloscPrób >= 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\t--- PRODUKCJA ---\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Zalogowano sie niepoprawnie po raz trzeci!\n Sproboj ponownie pozniej.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                poprawnyTylkoLogin = konta.Any(k => k.login == l && k.haslo != h);
                wszystkoŹle = konta.All(k => k.login != l);

                for (int i = 0; i < konta.Count; i++)
                {
                    if (l == konta[i].login && h == konta[i].haslo)
                    {
                        WczytajDane(konta[i]);

                        Menu(konta[i]);
                    }
                }
            }
        }

        private static void WczytajDane(Konto k)
        {
            try
            {
                Directory.CreateDirectory(Konto.ŚcieżkaDoKatalogu);

                if (File.Exists(k.ŚcieżkaDoPliku))
                {
                    using (StreamReader sr = new StreamReader(k.ŚcieżkaDoPliku))
                    {
                        uint[] ilosc = new uint[3];

                        for (int j = 0; j < k.listaProduktów.Count; j++)
                        {
                            uint.TryParse(sr.ReadLine(), out ilosc[j]);
                            k.listaProduktów[j].IloscProduktu = ilosc[j];
                        }
                    }
                }
                else
                {
                    FileStream fs = File.Create(k.ŚcieżkaDoPliku);

                    for (int j = 0; j < k.listaProduktów.Count; j++)
                    {
                        k.listaProduktów[j].IloscProduktu = 0;
                    }

                    fs.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nie udalo sie wczytac danych");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static void Menu(Konto k)
        {
            byte wybrany = 1;

            while (true)
            {
                Console.Clear();

                WyświetlMenu(k, wybrany);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (wybrany <= 1)
                            {
                                wybrany = 4;
                            }
                            else wybrany--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        {
                            if (wybrany >= 4)
                            {
                                wybrany = 1;
                            }
                            else wybrany++;
                        }
                        break;

                    case ConsoleKey.Escape:
                        {
                            Wyloguj(k);
                        }
                        break;

                    case ConsoleKey.Enter:
                        {
                            switch (wybrany)
                            {
                                case 1:
                                    {
                                        k.listaProduktów[0].Produkuj();
                                    }
                                    break;
                                case 2:
                                    {
                                        k.listaProduktów[1].Produkuj();
                                    }
                                    break;
                                case 3:
                                    {
                                        k.listaProduktów[2].Produkuj();
                                    }
                                    break;
                                case 4:
                                    {
                                        Wyloguj(k);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private static void WyświetlMenu(Konto k, byte wybrany)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t--- PRODUKCJA ---\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            switch (wybrany)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Produkt 1: " + k.listaProduktów[0] + " *");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Produkt 2: " + k.listaProduktów[1]);
                        Console.WriteLine("Produkt 3: " + k.listaProduktów[2]);
                        Console.WriteLine("\n\tZapisz i wyloguj sie");
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Produkt 1: " + k.listaProduktów[0]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Produkt 2: " + k.listaProduktów[1] + " *");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Produkt 3: " + k.listaProduktów[2]);
                        Console.WriteLine("\n\tZapisz i wyloguj sie");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Produkt 1: " + k.listaProduktów[0]);
                        Console.WriteLine("Produkt 2: " + k.listaProduktów[1]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Produkt 3: " + k.listaProduktów[2] + " *");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\tZapisz i wyloguj sie");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Produkt 1: " + k.listaProduktów[0]);
                        Console.WriteLine("Produkt 2: " + k.listaProduktów[1]);
                        Console.WriteLine("Produkt 3: " + k.listaProduktów[2]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\tZapisz i wyloguj sie *");
                    }
                    break;

                default:
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\t//Nacisnij ENTER aby wyprodukowac");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void ZapiszDane(Konto k)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(k.ŚcieżkaDoPliku))
                {
                    for (int j = 0; j < k.listaProduktów.Count; j++)
                    {
                        sw.WriteLine(k.listaProduktów[j].IloscProduktu);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nie udalo sie zapisac danych");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static void Wyloguj(Konto k)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tPodsumowanie produkcji:\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Produkt 1: " + k.listaProduktów[0] + "\nProdukt 2: " + k.listaProduktów[1] + "\nProdukt 3: " + k.listaProduktów[2]);
            Console.WriteLine("\n\tNacisnij dowolny klawisz ...");

            ZapiszDane(k);
            Console.ReadKey();
            Zaloguj();
        }
    }
}
