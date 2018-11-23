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
        public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
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
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            return this.GetDfsSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
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
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            return this.GetPlayerGameProjectionStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public Task<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
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
        public PlayerGameProjection GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameProjectionStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsAsync(string season)
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
        public List<PlayerSeasonProjection> GetPlayerSeasonProjectionStats(string season)
        {
            return this.GetPlayerSeasonProjectionStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public Task<PlayerSeasonProjection> GetPlayerSeasonProjectionStatsByPlayerAsync(string season, int playerid)
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
        public PlayerSeasonProjection GetPlayerSeasonProjectionStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonProjectionStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>PHI</code>.</param>
        public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsByTeamAsync(string season, string team)
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
        public List<PlayerSeasonProjection> GetPlayerSeasonProjectionStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonProjectionStatsByTeamAsync(season, team).Result;
        }

    }
}

