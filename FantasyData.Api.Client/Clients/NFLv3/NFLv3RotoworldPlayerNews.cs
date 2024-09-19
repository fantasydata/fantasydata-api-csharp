using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3RotoworldPlayerNewsClient : BaseClient
    {
        public NFLv3RotoworldPlayerNewsClient(string apiKey) : base(apiKey) { }
        public NFLv3RotoworldPlayerNewsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Rotoworld Player News - by Recent Asynchronous
        /// </summary>
        public Task<List<RotoworldPlayerNewsItem>> GetRotoworldPlayerNewsByRecentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<RotoworldPlayerNewsItem>>(() =>
                base.Get<List<RotoworldPlayerNewsItem>>("/v3/nfl/rotoworld/{format}/RotoworldPlayerNews", parameters)
            );
        }

        /// <summary>
        /// Get Rotoworld Player News - by Recent
        /// </summary>
        public List<RotoworldPlayerNewsItem> GetRotoworldPlayerNewsByRecent()
        {
            return this.GetRotoworldPlayerNewsByRecentAsync().Result;
        }

        /// <summary>
        /// Get Rotoworld Player News - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2022-JUL-31</code>, <code>2022-SEP-01</code>.</param>
        public Task<List<RotoworldPlayerNewsItem>> GetRotoworldPlayerNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<RotoworldPlayerNewsItem>>(() =>
                base.Get<List<RotoworldPlayerNewsItem>>("/v3/nfl/rotoworld/{format}/RotoworldPlayerNewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Rotoworld Player News - by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2022-JUL-31</code>, <code>2022-SEP-01</code>.</param>
        public List<RotoworldPlayerNewsItem> GetRotoworldPlayerNewsByDate(string date)
        {
            return this.GetRotoworldPlayerNewsByDateAsync(date).Result;
        }

    }
}

