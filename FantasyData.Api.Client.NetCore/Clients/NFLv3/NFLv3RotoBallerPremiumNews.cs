using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.NetCore.Model.NFLv3;

namespace FantasyData.Api.Client.NetCore
{
    public partial class NFLv3RotoBallerPremiumNewsClient : BaseClient
    {
        public NFLv3RotoBallerPremiumNewsClient(string apiKey) : base(apiKey) { }
        public NFLv3RotoBallerPremiumNewsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Premium News Asynchronous
        /// </summary>
        public Task<List<News>> GetRotoBallerPremiumNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNews", parameters)
            );
        }

        /// <summary>
        /// Get Premium News
        /// </summary>
        public List<News> GetRotoBallerPremiumNews()
        {
            return this.GetRotoBallerPremiumNewsAsync().Result;
        }

        /// <summary>
        /// Get Premium News by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<News>> GetRotoBallerPremiumNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Premium News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByDate(string date)
        {
            return this.GetRotoBallerPremiumNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Premium News by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<News>> GetRotoBallerPremiumNewsByPlayerIDAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Premium News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByPlayerID(int playerid)
        {
            return this.GetRotoBallerPremiumNewsByPlayerIDAsync(playerid).Result;
        }

        /// <summary>
        /// Get Premium News by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<News>> GetRotoBallerPremiumNewsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByTeam/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Premium News by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetRotoBallerPremiumNewsByTeam(string team)
        {
            return this.GetRotoBallerPremiumNewsByTeamAsync(team).Result;
        }

    }
}

