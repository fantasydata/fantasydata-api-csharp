using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.NetCore.Model.MLB;

namespace FantasyData.Api.Client.NetCore
{
    public partial class MLBv3PlayByPlayClient : BaseClient
    {
        public MLBv3PlayByPlayClient(string apiKey) : base(apiKey) { }
        public MLBv3PlayByPlayClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Play By Play Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<PlayByPlay> GetPlayByPlayAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<PlayByPlay>(() =>
                base.Get<PlayByPlay>("/v3/mlb/pbp/{format}/PlayByPlay/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Play By Play
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public PlayByPlay GetPlayByPlay(int gameid)
        {
            return this.GetPlayByPlayAsync(gameid).Result;
        }

        /// <summary>
        /// Get Play By Play Delta Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<PlayByPlay>> GetPlayByPlayDeltaAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<PlayByPlay>>(() =>
                base.Get<List<PlayByPlay>>("/v3/mlb/pbp/{format}/PlayByPlayDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Play By Play Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<PlayByPlay> GetPlayByPlayDelta(string date, string minutes)
        {
            return this.GetPlayByPlayDeltaAsync(date, minutes).Result;
        }

    }
}

