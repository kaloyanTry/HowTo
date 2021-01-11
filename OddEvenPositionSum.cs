using System;

namespace _6._3.EqualSumsOddEven
{
    class OddEvenPositionSum
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                string numString = i.ToString();
                
                int evenSum = 0;
                int oddSum = 0;

                for (int sc = 0; sc < numString.Length; sc++)
                {
                    char numChar = numString[sc];
                    int numDigit = int.Parse(numChar.ToString());

                    if (sc % 2 == 0)
                    {
                        evenSum += numDigit;
                    }
                    else
                    {
                        oddSum += numDigit;
                    }
                }

                if (evenSum == oddSum) 
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
