using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Tennis;

namespace FantasyData.Api.Client
{
    public partial class Tennisv3OddsClient : BaseClient
    {
        public Tennisv3OddsClient(string apiKey) : base(apiKey) { }
        public Tennisv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Match Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date for which to pull matches. Ex: <code> 2023-01-03 </code></param>
        public Task<List<Match>> GetMatchOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Match>>(() =>
                base.Get<List<Match>>("/v3/tennis/odds/{format}/MatchOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Match Odds by Date
        /// </summary>
        /// <param name="date">The date for which to pull matches. Ex: <code> 2023-01-03 </code></param>
        public List<Match> GetMatchOddsByDate(string date)
        {
            return this.GetMatchOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Match Odds by Date and Season Asynchronous
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to filter data. Example: <code>27</code></param>
        /// <param name="date">The date for which to pull matches. Ex: <code> 2023-01-03 </code></param>
        public Task<List<Match>> GetMatchOddsByDateAndSeasonAsync(int seasonid, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Match>>(() =>
                base.Get<List<Match>>("/v3/tennis/odds/{format}/MatchOddsBySeasonAndDate/{seasonid}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Match Odds by Date and Season
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to filter data. Example: <code>27</code></param>
        /// <param name="date">The date for which to pull matches. Ex: <code> 2023-01-03 </code></param>
        public List<Match> GetMatchOddsByDateAndSeason(int seasonid, string date)
        {
            return this.GetMatchOddsByDateAndSeasonAsync(seasonid, date).Result;
        }

        /// <summary>
        /// Get Match Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="matchid">The MatchId for which to pull details. Ex: <code> 2 </code></param>
        public Task<List<Match>> GetMatchOddsLineMovementAsync(string matchid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("matchid", matchid.ToString()));
            return Task.Run<List<Match>>(() =>
                base.Get<List<Match>>("/v3/tennis/odds/{format}/MatchOddsLineMovement/{matchid}", parameters)
            );
        }

        /// <summary>
        /// Get Match Odds Line Movement
        /// </summary>
        /// <param name="matchid">The MatchId for which to pull details. Ex: <code> 2 </code></param>
        public List<Match> GetMatchOddsLineMovement(string matchid)
        {
            return this.GetMatchOddsLineMovementAsync(matchid).Result;
        }

        /// <summary>
        /// Get Sportsbooks (Active) Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/tennis/odds/{format}/ActiveSportsbooks", parameters)
            );
        }

        /// <summary>
        /// Get Sportsbooks (Active)
        /// </summary>
        public List<Sportsbook> GetSportsbooksActive()
        {
            return this.GetSportsbooksActiveAsync().Result;
        }

    }
}

