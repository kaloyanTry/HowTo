using System;
using System.Linq;

namespace ArrayReverseNumbers
{
    class ArrayReverseString
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split().ToArray();

            string[] reversedArray = new string[stringArray.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = stringArray[stringArray.Length - i - 1];
            }

            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
