using System;
using System.Linq;
using FantasyData.Api.Client;

namespace FantasyData.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to client and get data
            var client = new  NFLv3ScoresClient("paste_api_key_here");
            var scores = client.GetGamesBasicByWeekLiveFinal("2025", 7);

            // Write data to console
            foreach (var score in scores)
            {
                Console.WriteLine($"{score.AwayTeam} {score.AwayScore} @ {score.HomeTeam} {score.HomeScore}");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

