using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.WNBA;

namespace FantasyData.Api.Client
{
    public partial class WNBAv3ScoresClient : BaseClient
    {
        public WNBAv3ScoresClient(string apiKey) : base(apiKey) { }
        public WNBAv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreAnyGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/wnba/scores/{format}/AreAnyGamesInProgress", parameters)
            );
        }

        /// <summary>
        /// Get Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            return this.GetAreAnyGamesInProgressAsync().Result;
        }

        /// <summary>
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<Season> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/wnba/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

        /// <summary>
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/wnba/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Schedule Asynchronous
        /// </summary>
        /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
        public Task<List<Game>> GetGamesAsync(string Season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("Season", Season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/wnba/scores/{format}/Games/{Season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
        public List<Game> GetGames(string Season)
        {
            return this.GetGamesAsync(Season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/wnba/scores/{format}/Stadiums", parameters)
            );
        }

        /// <summary>
        /// Get Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            return this.GetStadiumsAsync().Result;
        }

        /// <summary>
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/wnba/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

    }
}

