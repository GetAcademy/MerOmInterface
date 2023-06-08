namespace MerOmInterface.Stars
{
    internal class BlinkingStar
    {
        private readonly string _characters = "•*+*• ";
        private int _index;
        private int _column;
        private int _row;

        public BlinkingStar(int column, int row)
        {
            _column = column;
            _row = row;
        }

        public void Show()
        {
            Console.CursorLeft = _column;
            Console.CursorTop = _row;
            var character = _characters[_index];
            Console.Write(character);
        }

        public void Update()
        {
            _index++;
            if (_index == _characters.Length) _index = 0;

            //_index = (_index + 1) % _characters.Length;

            //_index = _index == _characters.Length - 1 ? 0 : _index + 1;
        }
    }
}
