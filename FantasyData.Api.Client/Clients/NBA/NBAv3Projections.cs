using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3ProjectionsClient : BaseClient
    {
        public NBAv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public NBAv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get DFS Slates by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/nba/projections/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
        public List<DfsSlate> GetDFSSlatesByDate(string date)
        {
            return this.GetDFSSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/nba/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public Task<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGameProjection>(() =>
                base.Get<PlayerGameProjection>("/v3/nba/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public PlayerGameProjection GetProjectedPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public Task<List<PlayerSeasonProjection>> GetProjectedPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonProjection>>(() =>
                base.Get<List<PlayerSeasonProjection>>("/v3/nba/projections/{format}/PlayerSeasonProjectionStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public List<PlayerSeasonProjection> GetProjectedPlayerSeasonStats(string season)
        {
            return this.GetProjectedPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public Task<PlayerSeasonProjection> GetProjectedPlayerSeasonStatsByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerSeasonProjection>(() =>
                base.Get<PlayerSeasonProjection>("/v3/nba/projections/{format}/PlayerSeasonProjectionStatsByPlayer/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats by Player
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public PlayerSeasonProjection GetProjectedPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetProjectedPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>PHI</code>.</param>
        public Task<List<PlayerSeasonProjection>> GetProjectedPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeasonProjection>>(() =>
                base.Get<List<PlayerSeasonProjection>>("/v3/nba/projections/{format}/PlayerSeasonProjectionStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>PHI</code>.</param>
        public List<PlayerSeasonProjection> GetProjectedPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetProjectedPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Starting Lineups by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2021-OCT-12</code>, <code>2021-DEC-09</code>.</param>
        public Task<List<StartingLineups>> GetStartingLineupsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<StartingLineups>>(() =>
                base.Get<List<StartingLineups>>("/v3/nba/projections/{format}/StartingLineupsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Starting Lineups by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2021-OCT-12</code>, <code>2021-DEC-09</code>.</param>
        public List<StartingLineups> GetStartingLineupsByDate(string date)
        {
            return this.GetStartingLineupsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Injured Players Asynchronous
        /// </summary>
        public Task<List<Player>> GetInjuredPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nba/projections/{format}/InjuredPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Injured Players
        /// </summary>
        public List<Player> GetInjuredPlayers()
        {
            return this.GetInjuredPlayersAsync().Result;
        }

        /// <summary>
        /// Get Depth Charts Asynchronous
        /// </summary>
        public Task<List<TeamDepthChart>> GetDepthChartsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamDepthChart>>(() =>
                base.Get<List<TeamDepthChart>>("/v3/nba/projections/{format}/DepthCharts", parameters)
            );
        }

        /// <summary>
        /// Get Depth Charts
        /// </summary>
        public List<TeamDepthChart> GetDepthCharts()
        {
            return this.GetDepthChartsAsync().Result;
        }

    }
}

