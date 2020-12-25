using System;

namespace _5._2.WhileLoops
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0.0;

            while (input != "NoMoreMoney")
            {
                double income = double.Parse(input);
                if (income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += income;
                Console.WriteLine($"Increase: {income:F2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
