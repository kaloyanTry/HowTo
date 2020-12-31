using System;

namespace DrawingFigures
{
    class CristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 0; row <= n; row++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - row), new string('*', row));
            }
        }
    }
}