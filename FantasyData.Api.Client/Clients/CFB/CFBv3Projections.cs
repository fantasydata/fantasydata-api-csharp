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

    }
}

