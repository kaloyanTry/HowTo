using System;

namespace DrawingFigures
{
    class RombStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(' ');
                }

                Console.Write('*');
                for (int colStar = 1; colStar < row; colStar++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = 1; row < n; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write(' ');
                }

                for (int c = 1; c < n - row; c++)
                {
                    Console.Write("* ");
                }
                Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}