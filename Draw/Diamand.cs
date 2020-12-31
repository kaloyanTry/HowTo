using System;

namespace DrawingFigures
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;

            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                var mid = n - 2 * leftRight - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }

            for (int row = 0; row <= (n - 1) / 2; row++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                var mid = n - 2 * leftRight - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight++;
            }
        }
    }
}