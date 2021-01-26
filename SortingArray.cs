using System;
using System.Linq;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }

                    int temp = numbers[i];
                    numbers[i] = numbers[min];
                    numbers[min] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    Console.Write(numbers[i] + " ");
                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }
        }
    }
}
