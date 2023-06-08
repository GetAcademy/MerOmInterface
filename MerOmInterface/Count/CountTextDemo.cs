using System.Linq;
using System.Reflection.PortableExecutable;

namespace MerOmInterface.Count
{
    internal class CountTextDemo
    {
        public static void Run()
        {
            //var iLineReader = new FileLineReader("Count/TextFile1.txt");
            //var iLineReader = new WebLineReader("https://www.vg.no/nyheter/i/rl39RA/stoere-regjeringen-kaller-inn-pst-og-politidirektoratet-paa-teppet");
            var iLineReader = new KeyboardLineReader();
            var service = new CountTextService(iLineReader);
            var stats = service.GetStats("ser", "Count/TextFile1.txt");
            Console.WriteLine(stats);

            //var filename = "Count/TextFile1.txt";
            //var searchWord = "ser";

            //var total = 0;
            //var exactCount = 0;
            //var ignoreCaseCount = 0;
            //var searchWordUpper = searchWord.ToUpper();

            //var fileStream = new FileStream(filename, FileMode.Open);
            //var reader = new StreamReader(fileStream);

            //var line = reader.ReadLine();
            //while (line != null)
            //{
            //    total++;
            //    if (line.Contains(searchWord)) exactCount++;
            //    if (line.ToUpper().Contains(searchWordUpper)) ignoreCaseCount++;
            //    line = reader.ReadLine();
            //}
            //var result = new Stats(total, exactCount, ignoreCaseCount);
            //Console.WriteLine(result);
        }
    }
}
