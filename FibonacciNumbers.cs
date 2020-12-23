using System;

namespace HowToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci First N Numbers

            int n = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(firstNumber);

                int tempNum = firstNumber;
                firstNumber = secondNumber;
                secondNumber = tempNum + secondNumber;
            }
        }
    }
}
