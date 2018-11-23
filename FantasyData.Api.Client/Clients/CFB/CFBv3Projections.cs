using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3ProjectionsClient : BaseClient
    {
        public CFBv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public CFBv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Projected Player Game Stats by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018REG</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/cfb/projections/{format}/ProjectedPlayerGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018REG</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByWeek(string season, int week)
        {
            return this.GetProjectedPlayerGameStatsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get DFS Slates by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2018-SEP-15</code>, <code>2018-SEP-22</code>, etc.</param>
        public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/cfb/projections/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2018-SEP-15</code>, <code>2018-SEP-22</code>, etc.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            return this.GetDfsSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get DFS Slates by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018REG</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>3</code>, <code>4</code>, etc.</param>
        public Task<List<DfsSlate>> GetDfsSlatesByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/cfb/projections/{format}/DfsSlatesByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018REG</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>3</code>, <code>4</code>, etc.</param>
        public List<DfsSlate> GetDfsSlatesByWeek(string season, int week)
        {
            return this.GetDfsSlatesByWeekAsync(season, week).Result;
        }

    }
}

