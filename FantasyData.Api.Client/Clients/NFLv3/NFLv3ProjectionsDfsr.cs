using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3ProjectionsDfsrClient : BaseClient
    {
        public NFLv3ProjectionsDfsrClient(string apiKey) : base(apiKey) { }
        public NFLv3ProjectionsDfsrClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get DFSR Projected Fantasy Defense Game Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<FantasyDefenseGameProjectionDfsr>> GetDfsrFantasyDefenseProjectionsByGameAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<FantasyDefenseGameProjectionDfsr>>(() =>
                base.Get<List<FantasyDefenseGameProjectionDfsr>>("/v3/nfl/projections-dfsr/{format}/DfsrFantasyDefenseProjectionsByGame/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get DFSR Projected Fantasy Defense Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<FantasyDefenseGameProjectionDfsr> GetDfsrFantasyDefenseProjectionsByGame(string season, int week)
        {
            return this.GetDfsrFantasyDefenseProjectionsByGameAsync(season, week).Result;
        }

        /// <summary>
        /// Get DFSR Projected Player Game Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGameProjectionDfsr>> GetDfsrPlayerGameProjectionStatsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameProjectionDfsr>>(() =>
                base.Get<List<PlayerGameProjectionDfsr>>("/v3/nfl/projections-dfsr/{format}/DfsrPlayerGameProjectionStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get DFSR Projected Player Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameProjectionDfsr> GetDfsrPlayerGameProjectionStatsByWeek(string season, int week)
        {
            return this.GetDfsrPlayerGameProjectionStatsByWeekAsync(season, week).Result;
        }

    }
}

