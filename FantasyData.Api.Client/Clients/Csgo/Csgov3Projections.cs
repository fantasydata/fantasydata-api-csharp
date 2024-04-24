using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Csgo;

namespace FantasyData.Api.Client
{
    public partial class Csgov3ProjectionsClient : BaseClient
    {
        public Csgov3ProjectionsClient(string apiKey) : base(apiKey) { }
        public Csgov3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Projected Player Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/csgo/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/csgo/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Dfs Slates By Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</br></param>
        public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/csgo/projections/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Dfs Slates By Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</br></param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            return this.GetDfsSlatesByDateAsync(date).Result;
        }

    }
}

