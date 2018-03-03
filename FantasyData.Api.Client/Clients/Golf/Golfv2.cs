using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.Golf;

namespace FantasyData.Api.Client
{
    public partial class Golfv2Client : BaseClient
    {
        public Golfv2Client(string apiKey) : base(apiKey) { }
        public Golfv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Injuries
        /// </summary>
        public List<Injury> GetInjuries()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Injury>>("/golf/v2/{format}/Injuries", parameters);
        }

        /// <summary>
        /// Injuries (Historical)
        /// </summary>
        public List<Injury> GetInjuriesByHistorical()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Injury>>("/golf/v2/{format}/InjuriesByHistorical", parameters);
        }

        /// <summary>
        /// Leaderboard
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Leaderboard GetLeaderboard(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return base.Get<Leaderboard>("/golf/v2/{format}/Leaderboard/{tournamentid}", parameters);
        }

        /// <summary>
        /// News
        /// </summary>
        public List<News> GetNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/golf/v2/{format}/News", parameters);
        }

        /// <summary>
        /// News by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/golf/v2/{format}/NewsByDate/{date}", parameters);
        }

        /// <summary>
        /// News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/golf/v2/{format}/NewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/golf/v2/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats (w/ World Golf Rankings)
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/golf/v2/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Tournament Projected Stats (w/ DraftKings Salaries)
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public List<PlayerTournamentProjection> GetPlayerTournamentProjectionStats(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return base.Get<List<PlayerTournamentProjection>>("/golf/v2/{format}/PlayerTournamentProjectionStats/{tournamentid}", parameters);
        }

        /// <summary>
        /// Player Tournament Stats By Player
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public PlayerTournament GetPlayerTournamentStatsByPlayer(int tournamentid, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerTournament>("/golf/v2/{format}/PlayerTournamentStatsByPlayer/{tournamentid}/{playerid}", parameters);
        }

        /// <summary>
        /// Players
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/golf/v2/{format}/Players", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        public List<Tournament> GetTournaments()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Tournament>>("/golf/v2/{format}/Tournaments", parameters);
        }

    }
}

