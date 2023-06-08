namespace MerOmInterface.Count
{
    internal class CountTextService
    {
        private ILineReader _lineReader;

        public CountTextService(ILineReader lineReader)
        {
            _lineReader = lineReader;
        }

        public Stats GetStats(string searchWord, string filename)
        {
            var total = 0;
            var exactCount = 0;
            var ignoreCaseCount = 0;
            var searchWordUpper = searchWord.ToUpper();

            var line = _lineReader.GetLine();
            while (line != null)
            {
                total++;
                if (line.Contains(searchWord)) exactCount++;
                if (line.ToUpper().Contains(searchWordUpper)) ignoreCaseCount++;
                line = _lineReader.GetLine();
            }
            var result = new Stats(total, exactCount, ignoreCaseCount);
            return result;
        }
    }
}
