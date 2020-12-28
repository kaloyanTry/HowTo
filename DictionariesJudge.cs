using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class DictionatiesJudge
    {
        static void Main(string[] args)
        {
            //You will receive several input lines. The constestName and userName are strings, the given points will be an integer number.You need to keep track of every contest and individual statistics of every user. You should check if such contest already exists, and if not, add it, otherwise check if the current user Is participating in the contest, if he is participating take the higher score, otherwise just add it. 
            // Also you need to keep individual statistics for each user - the total points of all constests. You should end your program when you receive the command "no more time".
            // At that point you should print each contest in order of input, for each contest print the participants ordered by points in desecending order, than ordered by name in ascending order.After that, you should print individual statistics for every participant ordered by total points in desecnding order, and then by alphabetical order

         Dictionary<string, Dictionary<string, int>> contestsInfo = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individualStandings = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "no more time")
            {
                string[] inputArr = inputLine.Split(" -> ");
                string studentName = inputArr[0];
                string contestName = inputArr[1];
                int points = int.Parse(inputArr[2]);

                if (!contestsInfo.ContainsKey(contestName))
                {
                    contestsInfo.Add(contestName, new Dictionary<string, int>());
                }

                if (!contestsInfo[contestName].ContainsKey(studentName))
                {
                    contestsInfo[contestName].Add(studentName, 0);
                }

                if (contestsInfo[contestName][studentName] < points)
                {
                    contestsInfo[contestName][studentName] = points;
                }

                if (!individualStandings.ContainsKey(studentName))
                {
                    individualStandings.Add(studentName, new Dictionary<string, int>());
                }

                if (!individualStandings[studentName].ContainsKey(contestName))
                {
                    individualStandings[studentName].Add(contestName, 0);
                }

                if (individualStandings[studentName][contestName] < points)
                {
                    individualStandings[studentName][contestName] = points;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var contest in contestsInfo)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int counter = 1;

                foreach (var student in contest.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}");
                    
                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");
            int count = 1;
            foreach (var student in individualStandings.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{count}. {student.Key} -> {student.Value.Values.Sum()}");
                count++;
            }
        }
    }
}
