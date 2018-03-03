using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3ProjectionsClient : BaseClient
    {
        public NBAv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public NBAv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DfsSlate>>("/v3/nba/projections/{format}/DfsSlatesByDate/{date}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Date (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGameProjection>>("/v3/nba/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Player (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public PlayerGameProjection GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGameProjection>("/v3/nba/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
        }

    }
}

