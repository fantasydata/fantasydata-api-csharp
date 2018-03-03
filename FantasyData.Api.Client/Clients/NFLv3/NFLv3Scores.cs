using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3ScoresClient : BaseClient
    {
        public NFLv3ScoresClient(string apiKey) : base(apiKey) { }
        public NFLv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/v3/nfl/scores/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Bye Weeks
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Bye> GetByes(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Bye>>("/v3/nfl/scores/{format}/Byes/{season}", parameters);
        }

        /// <summary>
        /// Game Stats by Season (Deprecated, use Team Game Stats instead)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Game> GetGameStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/v3/nfl/scores/{format}/GameStats/{season}", parameters);
        }

        /// <summary>
        /// Game Stats by Week (Deprecated, use Team Game Stats instead)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Game> GetGameStatsByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<Game>>("/v3/nfl/scores/{format}/GameStatsByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// News
        /// </summary>
        public List<News> GetNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/v3/nfl/scores/{format}/News", parameters);
        }

        /// <summary>
        /// News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/v3/nfl/scores/{format}/NewsByDate/{date}", parameters);
        }

        /// <summary>
        /// News by Player
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/v3/nfl/scores/{format}/NewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// News by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetNewsByTeam(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<News>>("/v3/nfl/scores/{format}/NewsByTeam/{team}", parameters);
        }

        /// <summary>
        /// Schedule
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Schedule> GetSchedules(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Schedule>>("/v3/nfl/scores/{format}/Schedules/{season}", parameters);
        }

        /// <summary>
        /// Scores by Season 
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Score> GetScores(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Score>>("/v3/nfl/scores/{format}/Scores/{season}", parameters);
        }

        /// <summary>
        /// Scores by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Score> GetScoresByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Season Current
        /// </summary>
        public int? GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/scores/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// Season Last Completed
        /// </summary>
        public int? GetLastCompletedSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedSeason", parameters);
        }

        /// <summary>
        /// Season Upcoming
        /// </summary>
        public int? GetUpcomingSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/scores/{format}/UpcomingSeason", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/v3/nfl/scores/{format}/Stadiums", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Standing>>("/v3/nfl/scores/{format}/Standings/{season}", parameters);
        }

        /// <summary>
        /// Team Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<TeamGame> GetTeamGameStats(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<TeamGame>>("/v3/nfl/scores/{format}/TeamGameStats/{season}/{week}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/nfl/scores/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams", parameters);
        }

        /// <summary>
        /// Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/nfl/scores/{format}/AllTeams", parameters);
        }

        /// <summary>
        /// Teams by Season
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Team> GetTeams(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams/{season}", parameters);
        }

        /// <summary>
        /// Timeframes
        /// </summary>
        /// <param name="type">The type of timeframes to return. Valid entries are <code>current</code> or <code>upcoming</code> or <code>completed</code> or <code>recent</code> or <code>all</code>.</param>
        public List<Timeframe> GetTimeframes(string type)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("type", type.ToString()));
            return base.Get<List<Timeframe>>("/v3/nfl/scores/{format}/Timeframes/{type}", parameters);
        }

        /// <summary>
        /// Week Current
        /// </summary>
        public int? GetCurrentWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/scores/{format}/CurrentWeek", parameters);
        }

        /// <summary>
        /// Week Last Completed
        /// </summary>
        public int? GetLastCompletedWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedWeek", parameters);
        }

        /// <summary>
        /// Week Upcoming
        /// </summary>
        public int? GetUpcomingWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/scores/{format}/UpcomingWeek", parameters);
        }

    }
}

