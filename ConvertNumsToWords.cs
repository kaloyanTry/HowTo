using System;

namespace ConvertNombersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert to words: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", NumWordsWrapper(n));
            Console.Read();

        }

        static string NumWordsWrapper(double n)
        {
            string words = "";
            double intPart;
            double decPart = 0;

            if (n == 0)
            {
                return "zero";
            }
            try
            {
                string[] splitter = n.ToString().Split('.');
                intPart = double.Parse(splitter[0]);
                decPart = double.Parse(splitter[1]);
            }
            catch
            {
                intPart = n;
            }

            words = NumWords(intPart);

            if (decPart > 0)
            {
                if (words != "")
                {
                    words += " and ";
                }

                int counter = decPart.ToString().Length;

                switch (counter)
                {
                    case 1:
                        words += NumWords(decPart) + " tenths";
                        break;

                    case 2:
                        words += NumWords(decPart) + " hundredths";
                        break;
                    case 3:
                        words += NumWords(decPart) + "thousandths";
                        break;
                    case 4:
                        words += NumWords(decPart) + " ten-thousandths";
                        break;
                    case 5:
                        words += NumWords(decPart) + " hundredth-thousandths";
                        break;
                    case 6:
                        words += NumWords(decPart) + " milionths";
                        break;
                    case 7:
                        words += NumWords(decPart) + " ten-milionths";
                        break;
                }
            }
            return words;
        }

        static string NumWords(double n)
        {
            string[] numbersArr = new string[]
            {
                "one", "two", "three", "four", "five", 
                "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen","fifteen",
                "sixteen", "seventeen", "eighteen", "nineteen"
            };

            string[] tensArr = new string[]
            {
                "twenty", "thirty", "fourty", "fifty",
                "sixty", "seventy", "eighty", "ninty"
            };

            string[] suffixesArr = new string[]
            {
                "thousand", "million", "billion", "trillion",
                "quadrillion", "quintillion", "sextillion", "septillion",
                "octillion", "nonillion", "decillion", "undecillion",
                "duodecillion", "tredecililion", "Quattuordecillion",
                "Quindecilion", "Sexdecillion", "Septedillion", 
                "Octodecillion", "Novemdecillion", "Vigintillion"
            };

            string words = "";
            bool tens = false;

            if (n < 0)
            {
                words += "negative ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (n >= pow)
                {
                    if (n % pow > 0)
                    {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                    }
                    else if (n % pow == 0)
                    {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1];
                    }
                    n %= pow;
                }
                power -= 3;
            }
            if (n >= 1000)
            {
                if (n % 1000 > 0) words += NumWords(Math.Floor(n / 1000)) + " thousand, ";
                else words += NumWords(Math.Floor(n / 1000)) + " thousand";
                n %= 1000;
            }
            if (0 <= n && n <= 999)
            {
                if ((int)n / 100 > 0)
                {
                    words += NumWords(Math.Floor(n / 100)) + " hundred";
                    n %= 100;
                }
                if ((int)n / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                if (n < 20 && n > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? "-" + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);
                    n -= Math.Floor(n);
                }
            }

            return words;
        }
    }
}
