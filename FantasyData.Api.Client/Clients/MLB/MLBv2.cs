using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv2Client : BaseClient
    {
        public MLBv2Client(string apiKey) : base(apiKey) { }
        public MLBv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/mlb/v2/{format}/AreAnyGamesInProgress", parameters);
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
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/HitterVsPitcher/{hitterid}/{pitcherid}", parameters);
        }

        /// <summary>
        /// Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<BoxScore>("/mlb/v2/{format}/BoxScore/{gameid}", parameters);
        }

        /// <summary>
        /// Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/mlb/v2/{format}/BoxScores/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/mlb/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<Season>("/mlb/v2/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DfsSlate>>("/mlb/v2/{format}/DfsSlatesByDate/{date}", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/mlb/v2/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// News
        /// </summary>
        public List<News> GetNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/mlb/v2/{format}/News", parameters);
        }

        /// <summary>
        /// News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/mlb/v2/{format}/NewsByDate/{date}", parameters);
        }

        /// <summary>
        /// News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/mlb/v2/{format}/NewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// Play By Play
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public PlayByPlay GetPlayByPlay(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<PlayByPlay>("/mlb/v2/{format}/PlayByPlay/{gameid}", parameters);
        }

        /// <summary>
        /// Play By Play Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<PlayByPlay> GetPlayByPlayDelta(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<PlayByPlay>>("/mlb/v2/{format}/PlayByPlayDelta/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/mlb/v2/{format}/Players", parameters);
        }

        /// <summary>
        /// Player Details by Free Agents
        /// </summary>
        public List<Player> GetFreeAgents()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/mlb/v2/{format}/FreeAgents", parameters);
        }

        /// <summary>
        /// Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/mlb/v2/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGame>>("/mlb/v2/{format}/PlayerGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGame>("/mlb/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Away Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonAwayStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonAwayStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Home Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonHomeStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonHomeStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Split Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="split">The desired split of stats. Currently, we support vs. Left/Right/Switch handed pitchers/hitters. Possible values are: <code>L</code>, <code>R</code> and <code>S</code></param>
        public List<PlayerSeason> GetPlayerSeasonSplitStats(string season, string split)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("split", split.ToString()));
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonSplitStats/{season}/{split}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerSeason>("/mlb/v2/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Player Season Stats Split By Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsSplitByTeam(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonStatsSplitByTeam/{season}", parameters);
        }

        /// <summary>
        /// Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<Player>>("/mlb/v2/{format}/Players/{team}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGameProjection>>("/mlb/v2/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<PlayerGameProjection>>("/mlb/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Projected Player Season Stats (with ADP)
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeasonProjection> GetPlayerSeasonProjectionStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeasonProjection>>("/mlb/v2/{format}/PlayerSeasonProjectionStats/{season}", parameters);
        }

        /// <summary>
        /// Schedules
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Game> GetGames(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/mlb/v2/{format}/Games/{season}", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/mlb/v2/{format}/Stadiums", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Standing>>("/mlb/v2/{format}/Standings/{season}", parameters);
        }

        /// <summary>
        /// Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<TeamGame>>("/mlb/v2/{format}/TeamGameStatsByDate/{date}", parameters);
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
            return base.Get<List<PlayerSeason>>("/mlb/v2/{format}/TeamHittersVsPitcher/{gameid}/{team}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/mlb/v2/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/mlb/v2/{format}/teams", parameters);
        }

        /// <summary>
        /// Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/mlb/v2/{format}/AllTeams", parameters);
        }

    }
}

