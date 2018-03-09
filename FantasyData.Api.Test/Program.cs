using System;
using System.Linq;
using FantasyData.Api.Client;

namespace FantasyData.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to client
            var client = new NFLv3ScoresClient("<Your license key goes here>");

            // Get NFL scores
            var scores = client.GetScoresByWeek("2017", 1);
            foreach(var score in scores)
            {
                Console.WriteLine($"{score.AwayTeam} - {score.AwayScore} @ {score.HomeTeam} - {score.HomeScore}");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

