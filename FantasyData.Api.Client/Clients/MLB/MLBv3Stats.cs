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
        public Task<bool> GetAreAnyGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/mlb/stats/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Batter vs. Pitcher Stats Asynchronous
        /// </summary>
        /// <param name="hitterid">Unique FantasyData Player ID. Example:<code>10000031</code>.</param>
        /// <param name="pitcherid">Unique FantasyData Player ID. Example:<code>10000618</code>.</param>
        public Task<List<PlayerSeason>> GetHitterVsPitcherAsync(int hitterid, int pitcherid)
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
        public List<PlayerSeason> GetHitterVsPitcher(int hitterid, int pitcherid)
        {
            return this.GetHitterVsPitcherAsync(hitterid, pitcherid).Result;
        }

        /// <summary>
        /// Get Box Score Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<BoxScore> GetBoxScoreAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/mlb/stats/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            return this.GetBoxScoreAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            return this.GetBoxScoresAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Delta Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/mlb/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            return this.GetBoxScoresDeltaAsync(date, minutes).Result;
        }

        /// <summary>
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<Season> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/mlb/stats/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

        /// <summary>
        /// Get DFS Slates by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/mlb/stats/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            return this.GetDfsSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/mlb/stats/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
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
        /// Get News by Date Asynchronous
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
        /// Get News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/mlb/stats/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            return this.GetNewsByPlayerIDAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/stats/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            return this.GetPlayersAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Free Agents Asynchronous
        /// </summary>
        public Task<List<Player>> GetFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/stats/{format}/FreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Free Agents
        /// </summary>
        public List<Player> GetFreeAgents()
        {
            return this.GetFreeAgentsAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<Player> GetPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/mlb/stats/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Player GetPlayer(int playerid)
        {
            return this.GetPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/mlb/stats/{format}/PlayerGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            return this.GetPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Player Asynchronous
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
        /// Get Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Away Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonAwayStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonAwayStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Away Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonAwayStats(string season)
        {
            return this.GetPlayerSeasonAwayStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Home Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonHomeStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/mlb/stats/{format}/PlayerSeasonHomeStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Home Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonHomeStats(string season)
        {
            return this.GetPlayerSeasonHomeStatsAsync(season).Result;
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
        /// Get Player Season Stats By Player Asynchronous
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
        /// Get Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats by Team Asynchronous
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
        /// Get Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Player Season Stats Split By Team Asynchronous
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
        /// Get Player Season Stats Split By Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsSplitByTeam(string season)
        {
            return this.GetPlayerSeasonStatsSplitByTeamAsync(season).Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<Player>> GetPlayersAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/stats/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            return this.GetPlayersAsync(team).Result;
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
                base.Get<List<Game>>("/v3/mlb/stats/{format}/Games/{season}", parameters)
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
        /// Get Team Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/stats/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            return this.GetTeamGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Team Hitting vs. Starting Pitcher Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetTeamHittersVsPitcherAsync(int gameid, string team)
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
        public List<PlayerSeason> GetTeamHittersVsPitcher(int gameid, string team)
        {
            return this.GetTeamHittersVsPitcherAsync(gameid, team).Result;
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
        /// Get Teams (Active) Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/mlb/stats/{format}/teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

        /// <summary>
        /// Get Teams (All) Asynchronous
        /// </summary>
        public Task<List<Team>> GetAllTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/mlb/stats/{format}/AllTeams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            return this.GetAllTeamsAsync().Result;
        }

    }
}

