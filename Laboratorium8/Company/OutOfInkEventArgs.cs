namespace Company
{
    public class OutOfInkEventArgs : System.EventArgs
    {
        public InkColor Color { get; private set; }

        public OutOfInkEventArgs(InkColor color)
        {
            Color = color;
        }
    }
}