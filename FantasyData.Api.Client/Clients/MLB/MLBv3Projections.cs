using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3ProjectionsClient : BaseClient
    {
        public MLBv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public MLBv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get DFS Slates - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/mlb/projections/{format}/DfsSlatesByDate/{date}", parameters)
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
        /// Get Projected Player Game Stats - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/mlb/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/mlb/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeasonProjection>> GetProjectedPlayerSeasonStatsWithADPAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonProjection>>(() =>
                base.Get<List<PlayerSeasonProjection>>("/v3/mlb/projections/{format}/PlayerSeasonProjectionStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<PlayerSeasonProjection> GetProjectedPlayerSeasonStatsWithADP(string season)
        {
            return this.GetProjectedPlayerSeasonStatsWithADPAsync(season).Result;
        }

        /// <summary>
        /// Get Player Details - by Injured Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByInjuredAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/projections/{format}/InjuredPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Injured
        /// </summary>
        public List<Player> GetPlayerDetailsByInjured()
        {
            return this.GetPlayerDetailsByInjuredAsync().Result;
        }

        /// <summary>
        /// Get Starting Lineups - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<StartingLineups>> GetStartingLineupsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<StartingLineups>>(() =>
                base.Get<List<StartingLineups>>("/v3/mlb/projections/{format}/StartingLineupsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Starting Lineups - by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<StartingLineups> GetStartingLineupsByDate(string date)
        {
            return this.GetStartingLineupsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Depth Charts Asynchronous
        /// </summary>
        public Task<List<TeamDepthChart>> GetDepthChartsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamDepthChart>>(() =>
                base.Get<List<TeamDepthChart>>("/v3/mlb/projections/{format}/DepthCharts", parameters)
            );
        }

        /// <summary>
        /// Get Depth Charts
        /// </summary>
        public List<TeamDepthChart> GetDepthCharts()
        {
            return this.GetDepthChartsAsync().Result;
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2023-JUL-31</code>, <code>2023-SEP-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetBAKERProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/mlb/projections/{format}/BakerPlayerGameProjections/{date}", parameters)
            );
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2023-JUL-31</code>, <code>2023-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetBAKERProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetBAKERProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2023-JUL-31</code>, <code>2023-SEP-01</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerGameProjection>> GetBAKERProjectedPlayerGameStatsByDate_1441Async(string date, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/mlb/projections/{format}/BakerPlayerGameProjectionsByTeam/{date}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2023-JUL-31</code>, <code>2023-SEP-01</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerGameProjection> GetBAKERProjectedPlayerGameStatsByDate_1441(string date, string team)
        {
            return this.GetBAKERProjectedPlayerGameStatsByDate_1441Async(date, team).Result;
        }

    }
}

