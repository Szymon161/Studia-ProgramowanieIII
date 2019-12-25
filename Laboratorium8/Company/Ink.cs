using System;

namespace Company
{
    public enum InkColor
    {
        Yellow = 1,
        Magenta,
        Cyan,
        Black
    }

    public class Ink
    {
        public InkColor Color { get; private set; }
        public byte Amount { get; private set; }

        public Ink(InkColor color)
        {
            Color = color;
            Amount = 0;
        }

        public Ink(InkColor color, byte amount)
        {
            Color = color;
            Amount = amount;
        }

        public string Refill(byte amount)
        {
            Amount += amount;

            return amount > 0 ? $"Ink refilled at {DateTime.Now.ToShortTimeString()} | {DateTime.Now.ToShortDateString()}" : "Failed attempt";
        }

        public bool Use()
        {
            if (Amount > 0)
            {
                Amount--;
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
