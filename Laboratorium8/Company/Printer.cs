using System;

namespace Company
{
    public class Printer
    {
        public byte PaperAmount { get; private set; }

        public Ink YellowInk { get; private set; }
        public Ink MagentaInk { get; private set; }
        public Ink CyanInk { get; private set; }
        public Ink BlackInk { get; private set; }

        public event EventHandler OutOfPaper;
        public event EventHandler<OutOfInkEventArgs> OutOfInk;

        public Printer()
        {
            PaperAmount = 0;
            YellowInk = new Ink(InkColor.Yellow);
            MagentaInk = new Ink(InkColor.Magenta);
            CyanInk = new Ink(InkColor.Cyan);
            BlackInk = new Ink(InkColor.Black);
            OutOfPaper += OutOfPaperEventHandler;
            OutOfInk += OutOfInkEventHandler;
        }

        public void Print(string text)
        {
            if (CanPrint())
            {
                PaperAmount--;
                YellowInk.Use();
                MagentaInk.Use();
                CyanInk.Use();
                BlackInk.Use();
                Console.WriteLine("Printing...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(text);
            }
        }

        private bool CanPrint()
        {
            bool canPrint = true;

            if (!IsPaperEnough())
            {
                canPrint = false;
            }

            if (!IsInkEnough(YellowInk))
            {
                canPrint = false;
            }

            if (!IsInkEnough(MagentaInk))
            {
                canPrint = false;
            }

            if (!IsInkEnough(CyanInk))
            {
                canPrint = false;
            }

            if (!IsInkEnough(BlackInk))
            {
                canPrint = false;
            }

            return canPrint;
        }

        private bool IsInkEnough(Ink ink)
        {
            bool enough = true;

            if (ink.Amount < 1)
            {
                OutOfInk?.Invoke(this, new OutOfInkEventArgs(ink.Color));
                enough = false;
            }

            return enough;
        }
        
        private bool IsPaperEnough()
        {
            bool enough = true;

            if (PaperAmount < 1)
            {
                OutOfPaper?.Invoke(this, EventArgs.Empty);
                enough = false;
            }

            return enough;
        }

        public string RefillPaper(byte amount)
        {
            PaperAmount += amount;

            return amount > 0 ? $"Paper refilled at {DateTime.Now.ToShortTimeString()} | {DateTime.Now.ToShortDateString()}" : "Failed attempt";
        }

        public void Info()
        {
            ConsoleColor currentBackgroundColor = Console.BackgroundColor;
            ConsoleColor currentForegroundColor = Console.ForegroundColor;

            Console.WriteLine("------------------------------------");

            Console.WriteLine($" Amount of paper remaining:       {PaperAmount} ");

            Console.WriteLine("------------------------------------");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($" Amount of yellow ink remaining:  {YellowInk.Amount} ");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($" Amount of magenta ink remaining: {MagentaInk.Amount} ");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($" Amount of cyan ink remaining:    {CyanInk.Amount} ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" Amount of black ink remaining:   {BlackInk.Amount} ");

            Console.BackgroundColor = currentBackgroundColor;
            Console.ForegroundColor = currentForegroundColor;

            Console.WriteLine("------------------------------------");
        }

        private void OutOfPaperEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine($"Out of paper! [ {DateTime.Now.ToShortTimeString()} | {DateTime.Now.ToShortDateString()} ]");
        }

        private void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"Out of {args.Color} ink! [ {DateTime.Now.ToShortTimeString()} | {DateTime.Now.ToShortDateString()} ]");
        }
    }
}
