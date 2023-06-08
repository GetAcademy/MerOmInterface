using System.Linq;
using System.Reflection.PortableExecutable;

namespace MerOmInterface.Count
{
    internal class CountTextDemo
    {
        public static void Run()
        {
            var filename = "Count/TextFile1.txt";
            var searchWord = "ser";

            var total = 0;
            var exactCount = 0;
            var ignoreCaseCount = 0;
            var searchWordUpper = searchWord.ToUpper();

            var fileStream = new FileStream(filename, FileMode.Open);
            var reader = new StreamReader(fileStream);

            var line = reader.ReadLine();
            while(line != null)
            {
                total++;
                if (line.Contains(searchWord)) exactCount++;
                if (line.ToUpper().Contains(searchWordUpper)) ignoreCaseCount++;
                line = reader.ReadLine();
            }
            var result = new Stats(total, exactCount, ignoreCaseCount);
            Console.WriteLine(result);
        }
    }
}
