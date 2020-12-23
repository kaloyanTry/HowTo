using System;

namespace HowToConsole
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            //Reverse Number

            int number = int.Parse(Console.ReadLine());

            int reverseNumber = 0;

            while (number != 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);

                number /= 10;
            }

            Console.WriteLine(reverseNumber);
        }
    }
}
