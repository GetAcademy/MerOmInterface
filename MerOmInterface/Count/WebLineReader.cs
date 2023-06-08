using System.Net;

namespace MerOmInterface.Count
{
    internal class WebLineReader : ILineReader
    {
        private StreamReader _reader;

        public WebLineReader(string url)
        {
            var webClient = new WebClient();
            var openRead = webClient.OpenRead(url);
            _reader = new StreamReader(openRead);
        }
        public string GetLine()
        {
            return _reader.ReadLine();
        }
    }
}
