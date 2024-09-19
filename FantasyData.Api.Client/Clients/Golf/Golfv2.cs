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
        /// Get Player Details - by Injured Asynchronous
        /// </summary>
        public Task<List<Injury>> GetPlayerDetailsByInjuredAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Injury>>(() =>
                base.Get<List<Injury>>("/golf/v2/{format}/Injuries", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Injured
        /// </summary>
        public List<Injury> GetPlayerDetailsByInjured()
        {
            return this.GetPlayerDetailsByInjuredAsync().Result;
        }

        /// <summary>
        /// Get Injuries (Historical) Asynchronous
        /// </summary>
        public Task<List<Injury>> GetInjuriesHistoricalAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Injury>>(() =>
                base.Get<List<Injury>>("/golf/v2/{format}/InjuriesByHistorical", parameters)
            );
        }

        /// <summary>
        /// Get Injuries (Historical)
        /// </summary>
        public List<Injury> GetInjuriesHistorical()
        {
            return this.GetInjuriesHistoricalAsync().Result;
        }

        /// <summary>
        /// Get Leaderboard [Live & Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<Leaderboard> GetLeaderboardLiveFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<Leaderboard>(() =>
                base.Get<Leaderboard>("/golf/v2/{format}/Leaderboard/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard [Live & Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Leaderboard GetLeaderboardLiveFinal(int tournamentid)
        {
            return this.GetLeaderboardLiveFinalAsync(tournamentid).Result;
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
        /// Get News - by Date Asynchronous
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
        /// Get News - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News - by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public Task<List<News>> GetNewsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/golf/v2/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public List<News> GetNewsByPlayer(int playerid)
        {
            return this.GetNewsByPlayerAsync(playerid).Result;
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
        /// Get Rankings Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public Task<List<PlayerSeason>> GetRankingsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/golf/v2/{format}/Rankings/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Rankings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<PlayerSeason> GetRankings(string season)
        {
            return this.GetRankingsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Projected Stats - by Tournament Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public Task<List<PlayerTournamentProjection>> GetPlayerProjectedStatsByTournamentAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<PlayerTournamentProjection>>(() =>
                base.Get<List<PlayerTournamentProjection>>("/golf/v2/{format}/PlayerTournamentProjectionStats/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Projected Stats - by Tournament
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public List<PlayerTournamentProjection> GetPlayerProjectedStatsByTournament(int tournamentid)
        {
            return this.GetPlayerProjectedStatsByTournamentAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Player Tournament Stats - by Player Asynchronous
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
        /// Get Player Tournament Stats - by Player
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
        public PlayerTournament GetPlayerTournamentStatsByPlayer(int tournamentid, int playerid)
        {
            return this.GetPlayerTournamentStatsByPlayerAsync(tournamentid, playerid).Result;
        }

        /// <summary>
        /// Get Player Profiles - All Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/golf/v2/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - All
        /// </summary>
        public List<Player> GetPlayerProfilesAll()
        {
            return this.GetPlayerProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        public Task<List<Tournament>> GetSchedulesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Tournament>>(() =>
                base.Get<List<Tournament>>("/golf/v2/{format}/Tournaments", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        public List<Tournament> GetSchedules()
        {
            return this.GetSchedulesAsync().Result;
        }

        /// <summary>
        /// Get DFS Slates - by Tournament Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByTournamentAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/golf/v2/{format}/DfsSlatesByTournament/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Tournament
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public List<DfsSlate> GetDFSSlatesByTournament(int tournamentid)
        {
            return this.GetDFSSlatesByTournamentAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Schedule - by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public Task<List<Tournament>> GetScheduleBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Tournament>>(() =>
                base.Get<List<Tournament>>("/golf/v2/{format}/Tournaments/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule - by Season
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<Tournament> GetScheduleBySeason(string season)
        {
            return this.GetScheduleBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<Season> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/golf/v2/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Current
        /// </summary>
        public Season GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Courses Asynchronous
        /// </summary>
        public Task<List<Courses>> GetCoursesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Courses>>(() =>
                base.Get<List<Courses>>("/golf/v2/{format}/Courses", parameters)
            );
        }

        /// <summary>
        /// Get Courses
        /// </summary>
        public List<Courses> GetCourses()
        {
            return this.GetCoursesAsync().Result;
        }

        /// <summary>
        /// Get Leaderboard (Basic) Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<LeaderboardBasic> GetLeaderboardBasicAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<LeaderboardBasic>(() =>
                base.Get<LeaderboardBasic>("/golf/v2/{format}/LeaderboardBasic/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard (Basic)
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public LeaderboardBasic GetLeaderboardBasic(int tournamentid)
        {
            return this.GetLeaderboardBasicAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Leaderboard (Basic) [Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<LeaderboardBasic> GetLeaderboardBasicFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<LeaderboardBasic>(() =>
                base.Get<LeaderboardBasic>("/golf/v2/{format}/LeaderboardBasicFinal/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard (Basic) [Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public LeaderboardBasic GetLeaderboardBasicFinal(int tournamentid)
        {
            return this.GetLeaderboardBasicFinalAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Leaderboard [Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<Leaderboard> GetLeaderboardFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<Leaderboard>(() =>
                base.Get<Leaderboard>("/golf/v2/{format}/LeaderboardFinal/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard [Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Leaderboard GetLeaderboardFinal(int tournamentid)
        {
            return this.GetLeaderboardFinalAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Fantasy Points - by Tournament Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public Task<FantasyTournament> GetFantasyPointsByTournamentAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<FantasyTournament>(() =>
                base.Get<FantasyTournament>("/golf/v2/{format}/FantasyGameStatsByTournament/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Points - by Tournament
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
        public FantasyTournament GetFantasyPointsByTournament(int tournamentid)
        {
            return this.GetFantasyPointsByTournamentAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Player Hole Scores - by Tournament [Live & Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<List<PlayerTournamentBasic>> GetPlayerHoleScoresByTournamentLiveFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<PlayerTournamentBasic>>(() =>
                base.Get<List<PlayerTournamentBasic>>("/golf/v2/{format}/PlayerTournamentHoleScores/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Hole Scores - by Tournament [Live & Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public List<PlayerTournamentBasic> GetPlayerHoleScoresByTournamentLiveFinal(int tournamentid)
        {
            return this.GetPlayerHoleScoresByTournamentLiveFinalAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Player Hole Scores - by Tournament [Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<List<PlayerTournamentBasic>> GetPlayerHoleScoresByTournamentFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<PlayerTournamentBasic>>(() =>
                base.Get<List<PlayerTournamentBasic>>("/golf/v2/{format}/PlayerTournamentHoleScoresFinal/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Hole Scores - by Tournament [Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public List<PlayerTournamentBasic> GetPlayerHoleScoresByTournamentFinal(int tournamentid)
        {
            return this.GetPlayerHoleScoresByTournamentFinalAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Scores - by Tournament [Live & Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<List<TournamentRound>> GetScoresByTournamentLiveFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<TournamentRound>>(() =>
                base.Get<List<TournamentRound>>("/golf/v2/{format}/PlayerTournamentRoundScores/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Scores - by Tournament [Live & Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public List<TournamentRound> GetScoresByTournamentLiveFinal(int tournamentid)
        {
            return this.GetScoresByTournamentLiveFinalAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Scores - by Tournament [Final] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<List<TournamentRound>> GetScoresByTournamentFinalAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<List<TournamentRound>>(() =>
                base.Get<List<TournamentRound>>("/golf/v2/{format}/PlayerTournamentRoundScoresFinal/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Scores - by Tournament [Final]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public List<TournamentRound> GetScoresByTournamentFinal(int tournamentid)
        {
            return this.GetScoresByTournamentFinalAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
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
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

    }
}

