using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3ScoresClient : BaseClient
    {
        public CFBv3ScoresClient(string apiKey) : base(apiKey) { }
        public CFBv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/v3/cfb/scores/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Conference Hierarchy (with Teams)
        /// </summary>
        public List<Conference> GetLeagueHierarchy()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Conference>>("/v3/cfb/scores/{format}/LeagueHierarchy", parameters);
        }

        /// <summary>
        /// Current Season
        /// </summary>
        public int GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int>("/v3/cfb/scores/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// Current Week
        /// </summary>
        public int? GetCurrentWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/cfb/scores/{format}/CurrentWeek", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/v3/cfb/scores/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// Games by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<Game> GetGamesByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<Game>>("/v3/cfb/scores/{format}/GamesByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<Game> GetGames(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/v3/cfb/scores/{format}/Games/{season}", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/v3/cfb/scores/{format}/Stadiums", parameters);
        }

        /// <summary>
        /// Team Game Stats by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<TeamGame> GetTeamGameStatsByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<TeamGame>>("/v3/cfb/scores/{format}/TeamGameStatsByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Team Season Stats & Standings
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/cfb/scores/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/cfb/scores/{format}/Teams", parameters);
        }

    }
}

