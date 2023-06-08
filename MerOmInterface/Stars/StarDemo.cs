using System.Text;

namespace MerOmInterface.Stars
{
    internal class StarDemo
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var star = new BlinkingStar(40, 5);
            while (true)
            {
                Console.Clear();
                star.Show();
                star.Update();
                Thread.Sleep(2000);
            }
        }
    }
}
