using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3ProjectionsDfsrClient : BaseClient
    {
        public MLBv3ProjectionsDfsrClient(string apiKey) : base(apiKey) { }
        public MLBv3ProjectionsDfsrClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetDfsrPlayerGameProjectionStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/mlb/projections-dfsr/{format}/DfsrPlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetDfsrPlayerGameProjectionStatsByDate(string date)
        {
            return this.GetDfsrPlayerGameProjectionStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<PlayerGameProjection>> GetDfsrPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/mlb/projections-dfsr/{format}/DfsrPlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<PlayerGameProjection> GetDfsrPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            return this.GetDfsrPlayerGameProjectionStatsByPlayerAsync(date, playerid).Result;
        }

    }
}

