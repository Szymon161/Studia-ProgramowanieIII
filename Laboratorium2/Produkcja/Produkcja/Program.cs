using System;

namespace Produkcja
{
    class Program
    {
        private static readonly Produkt[] produkt = Produkt.Stworz3Produkty();

        private static byte wybrany = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                WyswietlMenu();

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
                            KoniecProgramu();
                        }
                        break;

                    case ConsoleKey.Enter:
                        {
                            switch (wybrany)
                            {
                                case 1:
                                    {
                                        produkt[0].Produkuj();
                                    }
                                    break;
                                case 2:
                                    {
                                        produkt[1].Produkuj();
                                    }
                                    break;
                                case 3:
                                    {
                                        produkt[2].Produkuj();
                                    }
                                    break;
                                case 4:
                                    {
                                        KoniecProgramu();
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

        private static void WyswietlMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t--- PRODUKCJA ---\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            switch (wybrany)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Produkt 1: " + produkt[0] + " *");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Produkt 2: " + produkt[1]);
                        Console.WriteLine("Produkt 3: " + produkt[2]);
                        Console.WriteLine("\n\t\tKoniec Produkcji");
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Produkt 1: " + produkt[0]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Produkt 2: " + produkt[1] + " *");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Produkt 3: " + produkt[2]);
                        Console.WriteLine("\n\t\tKoniec Produkcji");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Produkt 1: " + produkt[0]);
                        Console.WriteLine("Produkt 2: " + produkt[1]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Produkt 3: " + produkt[2] + " *");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\t\tKoniec Produkcji");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Produkt 1: " + produkt[0]);
                        Console.WriteLine("Produkt 2: " + produkt[1]);
                        Console.WriteLine("Produkt 3: " + produkt[2]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t\tKoniec Produkcji *");
                    }
                    break;

                default:
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\t//Nacisnij ENTER aby wyprodukowac");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void KoniecProgramu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tPodsumowanie dzisiejszej produkcji:\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Produkt 1: " + produkt[0] + "\nProdukt 2: " + produkt[1] + "\nProdukt 3: " + produkt[2]);
            Console.WriteLine("\n\tNacisnij dowolny klawisz ...");

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
