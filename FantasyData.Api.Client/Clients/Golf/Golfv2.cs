using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Golf;

namespace FantasyData.Api.Client
{
    public partial class Golfv2Client : BaseClient
    {
        public Golfv2Client(string apiKey) : base(apiKey) { }
        public Golfv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Injuries Asynchronous
        /// </summary>
        public Task<List<Injury>> GetInjuriesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Injury>>(() =>
                base.Get<List<Injury>>("/golf/v2/{format}/Injuries", parameters)
            );
        }

        /// <summary>
        /// Get Injuries
        /// </summary>
        public List<Injury> GetInjuries()
        {
            return this.GetInjuriesAsync().Result;
        }

        /// <summary>
        /// Get Injuries (Historical) Asynchronous
        /// </summary>
        public Task<List<Injury>> GetInjuriesByHistoricalAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Injury>>(() =>
                base.Get<List<Injury>>("/golf/v2/{format}/InjuriesByHistorical", parameters)
            );
        }

        /// <summary>
        /// Get Injuries (Historical)
        /// </summary>
        public List<Injury> GetInjuriesByHistorical()
        {
            return this.GetInjuriesByHistoricalAsync().Result;
        }

        /// <summary>
        /// Get Leaderboard Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<Leaderboard> GetLeaderboardAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<Leaderboard>(() =>
                base.Get<Leaderboard>("/golf/v2/{format}/Leaderboard/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Leaderboard GetLeaderboard(int tournamentid)
        {
            return this.GetLeaderboardAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get News Asynchronous
        /// </summary>
        public Task<List<News>> GetNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/golf/v2/{format}/News", parameters)
            );
        }

        /// <summary>
        /// Get News
        /// </summary>
        public List<News> GetNews()
        {
            return this.GetNewsAsync().Result;
        }

        /// <summary>
        /// Get News by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<News>> GetNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/golf/v2/{format}/NewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get News by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/golf/v2/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            return this.GetNewsByPlayerIDAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public Task<Player> GetPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/golf/v2/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public Player GetPlayer(int playerid)
        {
            return this.GetPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats (w/ World Golf Rankings) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/golf/v2/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats (w/ World Golf Rankings)
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Tournament Projected Stats (w/ DraftKings Salaries) Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public Task<List<PlayerTournamentProjection>> GetPlayerTournamentProjectionStatsAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<PlayerTournamentProjection>>(() =>
                base.Get<List<PlayerTournamentProjection>>("/golf/v2/{format}/PlayerTournamentProjectionStats/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Tournament Projected Stats (w/ DraftKings Salaries)
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public List<PlayerTournamentProjection> GetPlayerTournamentProjectionStats(int tournamentid)
        {
            return this.GetPlayerTournamentProjectionStatsAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Player Tournament Stats By Player Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public Task<PlayerTournament> GetPlayerTournamentStatsByPlayerAsync(int tournamentid, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerTournament>(() =>
                base.Get<PlayerTournament>("/golf/v2/{format}/PlayerTournamentStatsByPlayer/{tournamentid}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Tournament Stats By Player
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public PlayerTournament GetPlayerTournamentStatsByPlayer(int tournamentid, int playerid)
        {
            return this.GetPlayerTournamentStatsByPlayerAsync(tournamentid, playerid).Result;
        }

        /// <summary>
        /// Get Players Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/golf/v2/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Players
        /// </summary>
        public List<Player> GetPlayers()
        {
            return this.GetPlayersAsync().Result;
        }

        /// <summary>
        /// Get Schedule Asynchronous
        /// </summary>
        public Task<List<Tournament>> GetTournamentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Tournament>>(() =>
                base.Get<List<Tournament>>("/golf/v2/{format}/Tournaments", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        public List<Tournament> GetTournaments()
        {
            return this.GetTournamentsAsync().Result;
        }

        /// <summary>
        /// Get DFS Slates Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<List<DfsSlate>> GetDfsSlatesByTournamentAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/golf/v2/{format}/DfsSlatesByTournament/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public List<DfsSlate> GetDfsSlatesByTournament(int tournamentid)
        {
            return this.GetDfsSlatesByTournamentAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Schedule by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public Task<List<Tournament>> GetTournamentsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Tournament>>(() =>
                base.Get<List<Tournament>>("/golf/v2/{format}/Tournaments/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule by Season
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<Tournament> GetTournaments(string season)
        {
            return this.GetTournamentsAsync(season).Result;
        }

        /// <summary>
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<Season> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/golf/v2/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

    }
}

