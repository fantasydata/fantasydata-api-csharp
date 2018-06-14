using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3ScoresClient : BaseClient
    {
        public CFBv3ScoresClient(string apiKey) : base(apiKey) { }
        public CFBv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreAnyGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/cfb/scores/{format}/AreAnyGamesInProgress", parameters)
            );
        }

        /// <summary>
        /// Get Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            return this.GetAreAnyGamesInProgressAsync().Result;
        }

        /// <summary>
        /// Get Conference Hierarchy (with Teams) Asynchronous
        /// </summary>
        public Task<List<Conference>> GetLeagueHierarchyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Conference>>(() =>
                base.Get<List<Conference>>("/v3/cfb/scores/{format}/LeagueHierarchy", parameters)
            );
        }

        /// <summary>
        /// Get Conference Hierarchy (with Teams)
        /// </summary>
        public List<Conference> GetLeagueHierarchy()
        {
            return this.GetLeagueHierarchyAsync().Result;
        }

        /// <summary>
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<int> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int>(() =>
                base.Get<int>("/v3/cfb/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Current Season
        /// </summary>
        public int GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

        /// <summary>
        /// Get Current Week Asynchronous
        /// </summary>
        public Task<int?> GetCurrentWeekAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/cfb/scores/{format}/CurrentWeek", parameters)
            );
        }

        /// <summary>
        /// Get Current Week
        /// </summary>
        public int? GetCurrentWeek()
        {
            return this.GetCurrentWeekAsync().Result;
        }

        /// <summary>
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Games by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<Game>> GetGamesByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/scores/{format}/GamesByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<Game> GetGamesByWeek(string season, int week)
        {
            return this.GetGamesByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Game>> GetGamesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/scores/{format}/Games/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Game> GetGames(string season)
        {
            return this.GetGamesAsync(season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/cfb/scores/{format}/Stadiums", parameters)
            );
        }

        /// <summary>
        /// Get Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            return this.GetStadiumsAsync().Result;
        }

        /// <summary>
        /// Get Team Game Stats by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cfb/scores/{format}/TeamGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<TeamGame> GetTeamGameStatsByWeek(string season, int week)
        {
            return this.GetTeamGameStatsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Team Season Stats & Standings Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/cfb/scores/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats & Standings
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            return this.GetTeamSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/cfb/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

    }
}

