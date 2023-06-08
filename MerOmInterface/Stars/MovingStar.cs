namespace MerOmInterface.Stars
{
    internal class MovingStar
    {
        private int _column;
        private int _row;

        public MovingStar(int column, int row, 
            int colSpeed, int rowSpeed)
        {
            _column = column;
            _row = row;
        }

        public void Show()
        {
            Console.CursorLeft = _column;
            Console.CursorTop = _row;
            Console.Write("*");
        }

        public void Update()
        {
        }
    }
}
