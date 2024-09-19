using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3RotoBallerPremiumNewsClient : BaseClient
    {
        public NFLv3RotoBallerPremiumNewsClient(string apiKey) : base(apiKey) { }
        public NFLv3RotoBallerPremiumNewsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Premium News Asynchronous
        /// </summary>
        public Task<List<News>> GetPremiumNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNews", parameters)
            );
        }

        /// <summary>
        /// Get Premium News
        /// </summary>
        public List<News> GetPremiumNews()
        {
            return this.GetPremiumNewsAsync().Result;
        }

        /// <summary>
        /// Get Premium News - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<News>> GetPremiumNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Premium News - by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetPremiumNewsByDate(string date)
        {
            return this.GetPremiumNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Premium News - by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<News>> GetPremiumNewsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Premium News - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetPremiumNewsByPlayer(int playerid)
        {
            return this.GetPremiumNewsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Premium News - by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<News>> GetPremiumNewsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByTeam/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Premium News - by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetPremiumNewsByTeam(string team)
        {
            return this.GetPremiumNewsByTeamAsync(team).Result;
        }

    }
}

