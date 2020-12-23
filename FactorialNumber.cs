using System;

namespace HowToConsole
{
    class FactorialNumber
    {
        static void Main(string[] args)
        {
            //Factorial Number

            int n = int.Parse(Console.ReadLine());

            int factorialNumber = 1;

            for (int i = n; i > 1; i--)
            {
                factorialNumber *= i;
                
            }
            Console.WriteLine(factorialNumber);
        }
    }
}
