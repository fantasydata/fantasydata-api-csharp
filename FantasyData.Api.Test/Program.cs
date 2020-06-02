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
            var client = new Lolv3ScoresClient("23f3696056164352b61722b32f5abaa0");
            var competitions = client.GetCompetitions();

            // Write data to console
            foreach(var competition in competitions)
            {
                Console.WriteLine($"{competition.CompetitionId} - {competition.Name} ({competition.AreaName})");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

