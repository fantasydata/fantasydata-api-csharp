using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv4ProjectionsClient : BaseClient
    {
        public Soccerv4ProjectionsClient(string apiKey) : base(apiKey) { }
        public Soccerv4ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get DFS Slates - by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v4/soccer/projections/{format}/DfsSlatesByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
        public List<DfsSlate> GetDFSSlatesByDate(string competition, string date)
        {
            return this.GetDFSSlatesByDateAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Player Details - by Injured Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<Player>> GetPlayerDetailsByInjuredAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v4/soccer/projections/{format}/InjuredPlayers/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Injured
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<Player> GetPlayerDetailsByInjured(string competition)
        {
            return this.GetPlayerDetailsByInjuredAsync(competition).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v4/soccer/projections/{format}/PlayerGameProjectionStatsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string competition, string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Upcoming DFS Slates - by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<DfsSlate>> GetUpcomingDFSSlatesByCompetitionAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v4/soccer/projections/{format}/UpcomingDfsSlatesByCompetition/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Upcoming DFS Slates - by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<DfsSlate> GetUpcomingDFSSlatesByCompetition(string competition)
        {
            return this.GetUpcomingDFSSlatesByCompetitionAsync(competition).Result;
        }

    }
}

