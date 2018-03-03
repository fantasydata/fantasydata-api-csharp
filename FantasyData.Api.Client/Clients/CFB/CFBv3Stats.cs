using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3StatsClient : BaseClient
    {
        public CFBv3StatsClient(string apiKey) : base(apiKey) { }
        public CFBv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/v3/cfb/stats/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>1148</code> or <code>1149</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<BoxScore>("/v3/cfb/stats/{format}/BoxScore/{gameid}", parameters);
        }

        /// <summary>
        /// Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-JAN-01</code>, <code>2017-JAN-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByDate/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<BoxScore> GetBoxScoresByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Box Scores by Week Delta
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetBoxScoresByWeekDelta(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeekDelta/{season}/{week}/{minutes}", parameters);
        }

        /// <summary>
        /// Conference Hierarchy (with Teams)
        /// </summary>
        public List<Conference> GetLeagueHierarchy()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Conference>>("/v3/cfb/stats/{format}/LeagueHierarchy", parameters);
        }

        /// <summary>
        /// Current Season
        /// </summary>
        public int GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int>("/v3/cfb/stats/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// Current Week
        /// </summary>
        public int? GetCurrentWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/cfb/stats/{format}/CurrentWeek", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/v3/cfb/stats/{format}/GamesByDate/{date}", parameters);
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
            return base.Get<List<Game>>("/v3/cfb/stats/{format}/GamesByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/cfb/stats/{format}/Players", parameters);
        }

        /// <summary>
        /// Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<Player> GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<Player>>("/v3/cfb/stats/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Details by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<Player>>("/v3/cfb/stats/{format}/Players/{team}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByPlayer(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsByPlayer/{season}/{week}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<PlayerGame> GetPlayerGameStatsByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<Game> GetGames(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/v3/cfb/stats/{format}/Games/{season}", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/v3/cfb/stats/{format}/Stadiums", parameters);
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
            return base.Get<List<TeamGame>>("/v3/cfb/stats/{format}/TeamGameStatsByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Team Season Stats & Standings
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/cfb/stats/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/cfb/stats/{format}/Teams", parameters);
        }

    }
}

