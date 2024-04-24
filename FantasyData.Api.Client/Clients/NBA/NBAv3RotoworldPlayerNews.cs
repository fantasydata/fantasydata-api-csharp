﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3RotoworldPlayerNewsClient : BaseClient
    {
        public NBAv3RotoworldPlayerNewsClient(string apiKey) : base(apiKey) { }
        public NBAv3RotoworldPlayerNewsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Rotoworld Player News (Recent) Asynchronous
        /// </summary>
        public Task<List<RotoworldPlayerNewsItem>> GetRotoworldPlayerNewsRecentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<RotoworldPlayerNewsItem>>(() =>
                base.Get<List<RotoworldPlayerNewsItem>>("/v3/nba/rotoworld/{format}/RotoworldPlayerNews", parameters)
            );
        }

        /// <summary>
        /// Get Rotoworld Player News (Recent)
        /// </summary>
        public List<RotoworldPlayerNewsItem> GetRotoworldPlayerNewsRecent()
        {
            return this.GetRotoworldPlayerNewsRecentAsync().Result;
        }

        /// <summary>
        /// Get Rotoworld Player News by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2022-JUL-31</code>, <code>2022-SEP-01</code>.</param>
        public Task<List<RotoworldPlayerNewsItem>> GetRotoworldPlayerNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<RotoworldPlayerNewsItem>>(() =>
                base.Get<List<RotoworldPlayerNewsItem>>("/v3/nba/rotoworld/{format}/RotoworldPlayerNewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Rotoworld Player News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2022-JUL-31</code>, <code>2022-SEP-01</code>.</param>
        public List<RotoworldPlayerNewsItem> GetRotoworldPlayerNewsByDate(string date)
        {
            return this.GetRotoworldPlayerNewsByDateAsync(date).Result;
        }

    }
}

