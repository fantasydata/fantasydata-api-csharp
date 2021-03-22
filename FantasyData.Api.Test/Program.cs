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
            var client = new  NFLv3ScoresClient("4512f3fb84064c699b18704f70f1708c");
            var scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");
            scores = client.GetScores("2020POST");

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

