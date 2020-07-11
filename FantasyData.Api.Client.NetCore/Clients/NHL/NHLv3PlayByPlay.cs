using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.NetCore.Model.NHL;

namespace FantasyData.Api.Client.NetCore
{
    public partial class NHLv3PlayByPlayClient : BaseClient
    {
        public NHLv3PlayByPlayClient(string apiKey) : base(apiKey) { }
        public NHLv3PlayByPlayClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Play By Play Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<PlayByPlay> GetPlayByPlayAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<PlayByPlay>(() =>
                base.Get<PlayByPlay>("/v3/nhl/pbp/{format}/PlayByPlay/{gameid}", parameters)
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
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<PlayByPlay>> GetPlayByPlayDeltaAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<PlayByPlay>>(() =>
                base.Get<List<PlayByPlay>>("/v3/nhl/pbp/{format}/PlayByPlayDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Play By Play Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<PlayByPlay> GetPlayByPlayDelta(string date, string minutes)
        {
            return this.GetPlayByPlayDeltaAsync(date, minutes).Result;
        }

    }
}

