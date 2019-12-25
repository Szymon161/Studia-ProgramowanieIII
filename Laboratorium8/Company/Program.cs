using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Boss companyBoss = new Boss(printer);

            printer.Info();

            printer.Print("Hello world!");

            Console.WriteLine();
            Console.WriteLine(printer.RefillPaper(20));
            Console.WriteLine(printer.YellowInk.Refill(5));
            Console.WriteLine(printer.MagentaInk.Refill(5));
            Console.WriteLine(printer.CyanInk.Refill(5));
            Console.WriteLine(printer.BlackInk.Refill(15));

            printer.Info();

            printer.Print("Hello world!");

            Console.ReadKey();
        }
    }

    class Boss
    {
        private const string informationForLazyWorkers = "Boss is angry, because nobody refilled paper!";

        public Boss(Printer companyPrinter)
        {
            companyPrinter.OutOfPaper += Fury;
        }

        private void Fury(object sender, EventArgs args)
        {
            ConsoleColor currentBackgroundColor = Console.BackgroundColor;
            ConsoleColor currentForegroundColor = Console.ForegroundColor;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(informationForLazyWorkers);

            Console.BackgroundColor = currentBackgroundColor;
            Console.ForegroundColor = currentForegroundColor;
        }
    }
}
