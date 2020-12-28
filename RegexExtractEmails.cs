using System;
using System.Text.RegularExpressions;

namespace ExractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string patternEmail = @"(\s[a-z]+[\w.-]+\w)@([a-z]+[-a-z]*?([.][a-z]+)+)\b";
            Regex regexEmail = new Regex(patternEmail);

            string input = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine, regexEmail.Matches(input)));
        }
    }
}
