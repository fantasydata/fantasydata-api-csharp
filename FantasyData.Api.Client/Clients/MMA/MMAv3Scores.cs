using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MMA;

namespace FantasyData.Api.Client
{
    public partial class MMAv3ScoresClient : BaseClient
    {
        public MMAv3ScoresClient(string apiKey) : base(apiKey) { }
        public MMAv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Event Asynchronous
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public Task<EventDetail> GetEventAsync(string eventid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventid", eventid.ToString()));
            return Task.Run<EventDetail>(() =>
                base.Get<EventDetail>("/v3/mma/scores/{format}/Event/{eventid}", parameters)
            );
        }

        /// <summary>
        /// Get Event
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public EventDetail GetEvent(string eventid)
        {
            return this.GetEventAsync(eventid).Result;
        }

        /// <summary>
        /// Get Fighter Profile - By Fighter Asynchronous
        /// </summary>
        /// <param name="fighterid">Each fighter has a unique ID assigned by FantasyData. Fighter IDs can be determined by pulling player related data. Example: <code>140000098</code></param>
        public Task<Fighter> GetFighterProfileByFighterAsync(string fighterid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("fighterid", fighterid.ToString()));
            return Task.Run<Fighter>(() =>
                base.Get<Fighter>("/v3/mma/scores/{format}/Fighter/{fighterid}", parameters)
            );
        }

        /// <summary>
        /// Get Fighter Profile - By Fighter
        /// </summary>
        /// <param name="fighterid">Each fighter has a unique ID assigned by FantasyData. Fighter IDs can be determined by pulling player related data. Example: <code>140000098</code></param>
        public Fighter GetFighterProfileByFighter(string fighterid)
        {
            return this.GetFighterProfileByFighterAsync(fighterid).Result;
        }

        /// <summary>
        /// Get Fighter Profiles - All Asynchronous
        /// </summary>
        public Task<List<Fighter>> GetFighterProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Fighter>>(() =>
                base.Get<List<Fighter>>("/v3/mma/scores/{format}/Fighters", parameters)
            );
        }

        /// <summary>
        /// Get Fighter Profiles - All
        /// </summary>
        public List<Fighter> GetFighterProfilesAll()
        {
            return this.GetFighterProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Leagues Asynchronous
        /// </summary>
        public Task<List<League>> GetLeaguesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<League>>(() =>
                base.Get<List<League>>("/v3/mma/scores/{format}/Leagues", parameters)
            );
        }

        /// <summary>
        /// Get Leagues
        /// </summary>
        public List<League> GetLeagues()
        {
            return this.GetLeaguesAsync().Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="league">The name of the league. Examples: <code>UFC</code>, etc</param>
        /// <param name="season">Year of the season. Examples: <code>2019</code>, <code>2020</code>, etc.</param>
        public Task<List<Event>> GetSchedulesAsync(string league, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("league", league.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Event>>(() =>
                base.Get<List<Event>>("/v3/mma/scores/{format}/Schedule/{league}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="league">The name of the league. Examples: <code>UFC</code>, etc</param>
        /// <param name="season">Year of the season. Examples: <code>2019</code>, <code>2020</code>, etc.</param>
        public List<Event> GetSchedules(string league, string season)
        {
            return this.GetSchedulesAsync(league, season).Result;
        }

        /// <summary>
        /// Get Fighter Profiles (Basic) - All Asynchronous
        /// </summary>
        public Task<List<FighterBasic>> GetFighterProfilesBasicAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<FighterBasic>>(() =>
                base.Get<List<FighterBasic>>("/v3/mma/scores/{format}/FightersBasic", parameters)
            );
        }

        /// <summary>
        /// Get Fighter Profiles (Basic) - All
        /// </summary>
        public List<FighterBasic> GetFighterProfilesBasicAll()
        {
            return this.GetFighterProfilesBasicAllAsync().Result;
        }

    }
}

