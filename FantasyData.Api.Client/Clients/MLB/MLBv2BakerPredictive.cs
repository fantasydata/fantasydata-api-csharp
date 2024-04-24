using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv2BakerPredictiveClient : BaseClient
    {
        public MLBv2BakerPredictiveClient(string apiKey) : base(apiKey) { }
        public MLBv2BakerPredictiveClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get BAKER Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Example: 2023-04-30</param>
        public Task<List<PlayerGameProjection>> GetBAKERProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/baker/v2/mlb/{format}/BakerPlayerGameProjections/{date}", parameters)
            );
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats by Date (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Example: 2023-04-30</param>
        public List<PlayerGameProjection> GetBAKERProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetBAKERProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats by Team (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Example: 2023-04-30</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerGameProjection>> GetBAKERProjectedPlayerGameStatsByTeamAsync(string date, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/baker/v2/mlb/{format}/BakerPlayerGameProjectionsByTeam/{date}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get BAKER Projected Player Game Stats by Team (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Example: 2023-04-30</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerGameProjection> GetBAKERProjectedPlayerGameStatsByTeam(string date, string team)
        {
            return this.GetBAKERProjectedPlayerGameStatsByTeamAsync(date, team).Result;
        }

    }
}

