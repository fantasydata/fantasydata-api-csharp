using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3StatsClient : BaseClient
    {
        public MLBv3StatsClient(string apiKey) : base(apiKey) { }
        public MLBv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/mlb/stats/{format}/AreAnyGamesInProgress", parameters)
            );
        }

        /// <summary>
        /// Get Are Games In Progress
        /// </summary>
        public bool GetAreGamesInProgress()
        {
            return this.GetAreGamesInProgressAsync().Result;
        }

        /// <summary>
        /// Get Batter vs. Pitcher Stats Asynchronous
        /// </summary>
        /// <param name="hitterid">Unique FantasyData Player ID. Example:<code>10000031</code>.</param>
        /// <param name="pitcherid">Unique FantasyData Player ID. Example:<code>10000618</code>.</param>
        public Task<List<PlayerSeason>> GetBatterVsPitcherStatsAsync(int hitterid, int pitcherid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("hitterid", hitterid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("pitcherid", pitcherid.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/HitterVsPitcher/{hitterid}/{pitcherid}", parameters)
            );
        }

        /// <summary>
        /// Get Batter vs. Pitcher Stats
        /// </summary>
        /// <param name="hitterid">Unique FantasyData Player ID. Example:<code>10000031</code>.</param>
        /// <param name="pitcherid">Unique FantasyData Player ID. Example:<code>10000618</code>.</param>
        public List<PlayerSeason> GetBatterVsPitcherStats(int hitterid, int pitcherid)
        {
            return this.GetBatterVsPitcherStatsAsync(hitterid, pitcherid).Result;
        }

        /// <summary>
        /// Get Box Score [Live & Final] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<BoxScore> GetBoxScoreLiveFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/mlb/stats/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Live & Final]
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScoreLiveFinal(int gameid)
        {
            return this.GetBoxScoreLiveFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateLiveFinal(string date)
        {
            return this.GetBoxScoresByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores Delta - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaByDateAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Delta - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDeltaByDate(string date, string minutes)
        {
            return this.GetBoxScoresDeltaByDateAsync(date, minutes).Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<Season> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/mlb/stats/{format}/CurrentSeason", parameters)
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
        /// Get DFS Slates - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/mlb/stats/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<DfsSlate> GetDFSSlatesByDate(string date)
        {
            return this.GetDFSSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<Game>> GetGamesByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/mlb/stats/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Game> GetGamesByDateLiveFinal(string date)
        {
            return this.GetGamesByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get News Asynchronous
        /// </summary>
        public Task<List<News>> GetNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/mlb/stats/{format}/News", parameters)
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
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<News>> GetNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/mlb/stats/{format}/NewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get News - by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News - by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<News>> GetNewsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/mlb/stats/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayer(int playerid)
        {
            return this.GetNewsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details - by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/stats/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Active
        /// </summary>
        public List<Player> GetPlayerDetailsByActive()
        {
            return this.GetPlayerDetailsByActiveAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Free Agents Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/stats/{format}/FreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Free Agents
        /// </summary>
        public List<Player> GetPlayerDetailsByFreeAgents()
        {
            return this.GetPlayerDetailsByFreeAgentsAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<Player> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/mlb/stats/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Player GetPlayerDetailsByPlayer(int playerid)
        {
            return this.GetPlayerDetailsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/mlb/stats/{format}/PlayerGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDateLiveFinal(string date)
        {
            return this.GetPlayerGameStatsByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<PlayerGame> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGame>(() =>
                base.Get<PlayerGame>("/v3/mlb/stats/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Away Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByAwayAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonAwayStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Away
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByAway(string season)
        {
            return this.GetPlayerSeasonStatsByAwayAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Home Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByHomeAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonHomeStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Home
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByHome(string season)
        {
            return this.GetPlayerSeasonStatsByHomeAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Split Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="split">The desired split of stats. Currently, we support vs. Left/Right/Switch handed pitchers/hitters. Possible values are: <code>L</code>, <code>R</code> and <code>S</code></param>
        public Task<List<PlayerSeason>> GetPlayerSeasonSplitStatsAsync(string season, string split)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("split", split.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonSplitStats/{season}/{split}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Split Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="split">The desired split of stats. Currently, we support vs. Left/Right/Switch handed pitchers/hitters. Possible values are: <code>L</code>, <code>R</code> and <code>S</code></param>
        public List<PlayerSeason> GetPlayerSeasonSplitStats(string season, string split)
        {
            return this.GetPlayerSeasonSplitStatsAsync(season, split).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<PlayerSeason> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerSeason>(() =>
                base.Get<PlayerSeason>("/v3/mlb/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Player Season Stats Split - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsSplitByTeamAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonStatsSplitByTeam/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats Split - by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsSplitByTeam(string season)
        {
            return this.GetPlayerSeasonStatsSplitByTeamAsync(season).Result;
        }

        /// <summary>
        /// Get Players - by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<Player>> GetPlayersByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/stats/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players - by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayersByTeam(string team)
        {
            return this.GetPlayersByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Game>> GetSchedulesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/mlb/stats/{format}/Games/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Game> GetSchedules(string season)
        {
            return this.GetSchedulesAsync(season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/mlb/stats/{format}/Stadiums", parameters)
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
        /// Get Standings Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<Standing>> GetStandingsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/v3/mlb/stats/{format}/Standings/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            return this.GetStandingsAsync(season).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/stats/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateLiveFinal(string date)
        {
            return this.GetTeamGameStatsByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Hitting vs. Starting Pitcher Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetTeamHittingVsStartingPitcherAsync(int gameid, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/TeamHittersVsPitcher/{gameid}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Team Hitting vs. Starting Pitcher
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetTeamHittingVsStartingPitcher(int gameid, string team)
        {
            return this.GetTeamHittingVsStartingPitcherAsync(gameid, team).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/mlb/stats/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            return this.GetTeamSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Team Profiles - by Active Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/mlb/stats/{format}/teams", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - by Active
        /// </summary>
        public List<Team> GetTeamProfilesByActive()
        {
            return this.GetTeamProfilesByActiveAsync().Result;
        }

        /// <summary>
        /// Get Team Profiles - All Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/mlb/stats/{format}/AllTeams", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - All
        /// </summary>
        public List<Team> GetTeamProfilesAll()
        {
            return this.GetTeamProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Player Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10001365</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<PlayerGame>> GetPlayerGameLogsBySeasonAsync(string season, int playerid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/mlb/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10001365</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<PlayerGame> GetPlayerGameLogsBySeason(string season, int playerid, string numberofgames)
        {
            return this.GetPlayerGameLogsBySeasonAsync(season, playerid, numberofgames).Result;
        }

        /// <summary>
        /// Get Team Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 12 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<TeamGame>> GetTeamGameLogsBySeasonAsync(string season, int teamid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/stats/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 12 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Box Score [Final] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<BoxScore> GetBoxScoreFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/mlb/stats/{format}/BoxScoreFinal/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Final]
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScoreFinal(int gameid)
        {
            return this.GetBoxScoreFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScoresFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateFinal(string date)
        {
            return this.GetBoxScoresByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/mlb/stats/{format}/PlayerGameStatsByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDateFinal(string date)
        {
            return this.GetPlayerGameStatsByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/stats/{format}/TeamGameStatsByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateFinal(string date)
        {
            return this.GetTeamGameStatsByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Fantasy Points - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<FantasyGame>> GetFantasyPointsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<FantasyGame>>(() =>
                base.Get<List<FantasyGame>>("/v3/mlb/stats/{format}/FantasyGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Points - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<FantasyGame> GetFantasyPointsByDate(string date)
        {
            return this.GetFantasyPointsByDateAsync(date).Result;
        }

    }
}

