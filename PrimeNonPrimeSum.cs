using System;

namespace _6._3.SumPrimesNon
{
    class PrimeNonPrimeSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrimes = 0;
            int sumNums = 0;

            while (input != "stop")
            {
                if (input == "stop") break;

                int nums = int.Parse(input);
                bool isPrime = true;

                if (nums < 0)
                {
                    nums = 0;
                    Console.WriteLine("Number is negative.");
                }
                else if (nums == 1)
                {
                    isPrime = false;
                }
                else
                {
                    int div = 2;
                    int maxDiv = (int)Math.Sqrt(nums);
                    while (div <= maxDiv)
                    {
                        if (nums % div == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        div++;
                    }
                    if (isPrime) sumPrimes += nums;
                    else sumNums += nums;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNums}");
        }
    }
}
