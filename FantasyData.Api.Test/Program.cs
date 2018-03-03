using System;
using System.Linq;

namespace FantasyData.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to client
            var key = new Guid("ce41fccc60494450bbb3c858a9bdf8be");
            var client = new FantasyData.Api.Client.Golfv2Client(key);

            // Get slates
            var slates = client.GetLeaderboard(255);
            foreach (var p in slates.Players.OrderBy(p => p.Rank))
            {
                Console.WriteLine(p.Name);
            }


            //// Get teams and write to console
            //var teams = client.GetTeams("2017");
            //teams.ForEach(t => Console.WriteLine(t.FullName + " (" + t.StadiumDetails.Name + ")"));

            //// Get scores and write to console
            //var boxScores = client.GetBoxScores("2017post", 2);
            //foreach (var boxScore in boxScores)
            //{
            //    Console.WriteLine($"{boxScore.Score.AwayTeam} : {boxScore.Score.AwayScore} @ {boxScore.Score.HomeTeam} : {boxScore.Score.HomeScore}");
            //}

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
