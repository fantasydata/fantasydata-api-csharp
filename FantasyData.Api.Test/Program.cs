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
            var client = new  NFLv3ScoresClient("<api_key_goes_here>");
            var scores = client.GetSchedules("2023POST");

            // Write data to console
            foreach (var score in scores)
            {
                Console.WriteLine($"{score.AwayTeam} @ {score.HomeTeam}");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

