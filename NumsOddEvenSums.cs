using System;

namespace _4._3.ForEx
{
    class NumsOddEvenSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double numMaxEven = double.MinValue;
            double numMinEven = double.MaxValue;
            double sumEven = 0;

            double numMaxOdd = double.MinValue;
            double numMinOdd = double.MaxValue;
            double sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                double nums = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += nums;
                    if (nums > numMaxEven) numMaxEven = nums;
                    if (nums < numMinEven) numMinEven = nums;
                }
                else
                {
                    sumOdd += nums;
                    if (nums > numMaxOdd) numMaxOdd = nums;
                    if (nums < numMinOdd) numMinOdd = nums;
                }
            }

            Console.WriteLine($"OddSum={sumOdd:F2},");

            if (sumOdd == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={numMinOdd:F2},");
                Console.WriteLine($"OddMax={numMaxOdd:F2},");
            }

            Console.WriteLine($"EvenSum={sumEven:F2},");

            if (sumEven == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={numMinEven:F2},");
                Console.WriteLine($"EvenMax={numMaxEven:F2}");
            }      
        }
    }
}
