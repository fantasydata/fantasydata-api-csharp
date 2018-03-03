using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3RotoBallerPremiumNewsClient : BaseClient
    {
        public MLBv3RotoBallerPremiumNewsClient(string apiKey) : base(apiKey) { }
        public MLBv3RotoBallerPremiumNewsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Premium News
        /// </summary>
        public List<News> GetRotoBallerPremiumNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/v3/mlb/news-rotoballer/{format}/RotoBallerPremiumNews", parameters);
        }

        /// <summary>
        /// Premium News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/v3/mlb/news-rotoballer/{format}/RotoBallerPremiumNewsByDate/{date}", parameters);
        }

        /// <summary>
        /// Premium News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/v3/mlb/news-rotoballer/{format}/RotoBallerPremiumNewsByPlayerID/{playerid}", parameters);
        }

    }
}

