using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3RotoBallerPremiumNewsClient : BaseClient
    {
        public NFLv3RotoBallerPremiumNewsClient(string apiKey) : base(apiKey) { }
        public NFLv3RotoBallerPremiumNewsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Premium News
        /// </summary>
        public List<News> GetRotoBallerPremiumNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNews", parameters);
        }

        /// <summary>
        /// Premium News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByDate/{date}", parameters);
        }

        /// <summary>
        /// Premium News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// Premium News by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByTeam(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByTeam/{team}", parameters);
        }

    }
}

