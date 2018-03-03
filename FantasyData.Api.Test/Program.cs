using System;
using System.Linq;

namespace FantasyData.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to client
            var client = new FantasyData.Api.Client.NFLv3ScoresClient("<Your license key goes here>");

            // Get teams and write to console
            var teams = client.GetTeams();
            teams.ForEach(t => Console.WriteLine(t.FullName + " (" + t.HeadCoach + ")"));
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

