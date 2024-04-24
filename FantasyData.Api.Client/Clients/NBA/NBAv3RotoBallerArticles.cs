using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3RotoBallerArticlesClient : BaseClient
    {
        public NBAv3RotoBallerArticlesClient(string apiKey) : base(apiKey) { }
        public NBAv3RotoBallerArticlesClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get RotoBaller Articles Asynchronous
        /// </summary>
        public Task<List<Article>> GetRotoBallerArticlesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Article>>(() =>
                base.Get<List<Article>>("/v3/nba/articles-rotoballer/{format}/RotoBallerArticles", parameters)
            );
        }

        /// <summary>
        /// Get RotoBaller Articles
        /// </summary>
        public List<Article> GetRotoBallerArticles()
        {
            return this.GetRotoBallerArticlesAsync().Result;
        }

        /// <summary>
        /// Get RotoBaller Articles by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<Article>> GetRotoBallerArticlesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Article>>(() =>
                base.Get<List<Article>>("/v3/nba/articles-rotoballer/{format}/RotoBallerArticlesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get RotoBaller Articles by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Article> GetRotoBallerArticlesByDate(string date)
        {
            return this.GetRotoBallerArticlesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get RotoBaller Articles by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<Article>> GetRotoBallerArticlesByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<Article>>(() =>
                base.Get<List<Article>>("/v3/nba/articles-rotoballer/{format}/RotoBallerArticlesByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get RotoBaller Articles by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<Article> GetRotoBallerArticlesByPlayer(int playerid)
        {
            return this.GetRotoBallerArticlesByPlayerAsync(playerid).Result;
        }

    }
}

