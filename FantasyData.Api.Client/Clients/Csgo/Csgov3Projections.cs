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
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
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
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            return this.GetPlayerGameProjectionStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
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
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameProjectionStatsByPlayerAsync(date, playerid).Result;
        }

    }
}

