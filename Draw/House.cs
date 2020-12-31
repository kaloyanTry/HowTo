using System;

namespace DrawingFigures
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 1;
            if (n % 2 == 0)
            {
                stars++;
            }

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                int padding = (n - stars) / 2;
                Console.WriteLine("{0}{1}{0}", new string('-', padding), new string('*', stars));

                stars += 2;
            }

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}