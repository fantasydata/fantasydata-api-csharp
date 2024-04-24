using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv2BakerPredictiveClient : BaseClient
    {
        public NBAv2BakerPredictiveClient(string apiKey) : base(apiKey) { }
        public NBAv2BakerPredictiveClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get BAKER Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Example: 2023-04-04</param>
        public Task<List<PlayerGameProjection>> GetBAKERProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/baker/v2/nba/{format}/BakerPlayerGameProjections/{date}", parameters)
            );
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats by Date (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Example: 2023-04-04</param>
        public List<PlayerGameProjection> GetBAKERProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetBAKERProjectedPlayerGameStatsByDateAsync(date).Result;
        }

    }
}

