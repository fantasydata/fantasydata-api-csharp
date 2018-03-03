using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3RotoBallerArticlesClient : BaseClient
    {
        public MLBv3RotoBallerArticlesClient(string apiKey) : base(apiKey) { }
        public MLBv3RotoBallerArticlesClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// RotoBaller Articles
        /// </summary>
        public List<Article> GetRotoBallerArticles()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Article>>("/v3/mlb/articles-rotoballer/{format}/RotoBallerArticles", parameters);
        }

        /// <summary>
        /// RotoBaller Articles By Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Article> GetRotoBallerArticlesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Article>>("/v3/mlb/articles-rotoballer/{format}/RotoBallerArticlesByDate/{date}", parameters);
        }

        /// <summary>
        /// RotoBaller Articles By Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<Article> GetRotoBallerArticlesByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<Article>>("/v3/mlb/articles-rotoballer/{format}/RotoBallerArticlesByPlayerID/{playerid}", parameters);
        }

    }
}

