using System.Text;

namespace MerOmInterface.Stars
{
    internal class StarDemo
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var star1 = new BlinkingStar(40, 5);
            var star2 = new MovingStar(
                5, 10, 1, 0);
            var stars = new IStar[] { star1, star2 };

            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Thread.Sleep(200);
            }
        }
    }
}
