namespace MerOmInterface.Count
{
    internal class KeyboardLineReader : ILineReader
    {
        public string GetLine()
        {
            var line = Console.ReadLine();
            if (line == "") return null;
            return line;
        }
    }
}
