using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3StatsClient : BaseClient
    {
        public MLBv3StatsClient(string apiKey) : base(apiKey) { }
        public MLBv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/v3/mlb/stats/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Batter vs. Pitcher Stats
        /// </summary>
        /// <param name="hitterid">Unique FantasyData Player ID. Example:<code>10000031</code>.</param>
        /// <param name="pitcherid">Unique FantasyData Player ID. Example:<code>10000618</code>.</param>
        public List<PlayerSeason> GetHitterVsPitcher(int hitterid, int pitcherid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("hitterid", hitterid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("pitcherid", pitcherid.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/HitterVsPitcher/{hitterid}/{pitcherid}", parameters);
        }

        /// <summary>
        /// Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<BoxScore>("/v3/mlb/stats/{format}/BoxScore/{gameid}", parameters);
        }

        /// <summary>
        /// Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScores/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<Season>("/v3/mlb/stats/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DfsSlate>>("/v3/mlb/stats/{format}/DfsSlatesByDate/{date}", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/v3/mlb/stats/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// News
        /// </summary>
        public List<News> GetNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/v3/mlb/stats/{format}/News", parameters);
        }

        /// <summary>
        /// News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/v3/mlb/stats/{format}/NewsByDate/{date}", parameters);
        }

        /// <summary>
        /// News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/v3/mlb/stats/{format}/NewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/mlb/stats/{format}/Players", parameters);
        }

        /// <summary>
        /// Player Details by Free Agents
        /// </summary>
        public List<Player> GetFreeAgents()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/mlb/stats/{format}/FreeAgents", parameters);
        }

        /// <summary>
        /// Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/v3/mlb/stats/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGame>>("/v3/mlb/stats/{format}/PlayerGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGame>("/v3/mlb/stats/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Away Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonAwayStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonAwayStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Home Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonHomeStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonHomeStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Split Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="split">The desired split of stats. Currently, we support vs. Left/Right/Switch handed pitchers/hitters. Possible values are: <code>L</code>, <code>R</code> and <code>S</code></param>
        public List<PlayerSeason> GetPlayerSeasonSplitStats(string season, string split)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("split", split.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonSplitStats/{season}/{split}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerSeason>("/v3/mlb/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Player Season Stats Split By Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsSplitByTeam(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonStatsSplitByTeam/{season}", parameters);
        }

        /// <summary>
        /// Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<Player>>("/v3/mlb/stats/{format}/Players/{team}", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<Game> GetGames(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/v3/mlb/stats/{format}/Games/{season}", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/v3/mlb/stats/{format}/Stadiums", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Standing>>("/v3/mlb/stats/{format}/Standings/{season}", parameters);
        }

        /// <summary>
        /// Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<TeamGame>>("/v3/mlb/stats/{format}/TeamGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Team Hitting vs. Starting Pitcher
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetTeamHittersVsPitcher(int gameid, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/TeamHittersVsPitcher/{gameid}/{team}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/mlb/stats/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/mlb/stats/{format}/teams", parameters);
        }

        /// <summary>
        /// Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/mlb/stats/{format}/AllTeams", parameters);
        }

    }
}

