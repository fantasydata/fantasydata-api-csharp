using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3PlayByPlayClient : BaseClient
    {
        public NFLv3PlayByPlayClient(string apiKey) : base(apiKey) { }
        public NFLv3PlayByPlayClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Play By Play
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of the home team. Example: <code>WAS</code>.</param>
        public PlayByPlay GetPlayByPlay(string season, int week, string hometeam)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("hometeam", hometeam.ToString()));
            return base.Get<PlayByPlay>("/v3/nfl/pbp/{format}/PlayByPlay/{season}/{week}/{hometeam}", parameters);
        }

        /// <summary>
        /// Play By Play Delta
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<PlayByPlay> GetPlayByPlayDelta(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<PlayByPlay>>("/v3/nfl/pbp/{format}/PlayByPlayDelta/{season}/{week}/{minutes}", parameters);
        }

    }
}

