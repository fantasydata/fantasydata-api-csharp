using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MMA;

namespace FantasyData.Api.Client
{
    public partial class MMAv3StatsClient : BaseClient
    {
        public MMAv3StatsClient(string apiKey) : base(apiKey) { }
        public MMAv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Event Asynchronous
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public Task<EventDetail> GetEventAsync(string eventid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventid", eventid.ToString()));
            return Task.Run<EventDetail>(() =>
                base.Get<EventDetail>("/v3/mma/stats/{format}/Event/{eventid}", parameters)
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
        /// Get Fight Asynchronous
        /// </summary>
        /// <param name="fightid">The unique ID of this fight. Examples: <code>1100</code>, etc.</param>
        public Task<FightDetail> GetFightAsync(string fightid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("fightid", fightid.ToString()));
            return Task.Run<FightDetail>(() =>
                base.Get<FightDetail>("/v3/mma/stats/{format}/Fight/{fightid}", parameters)
            );
        }

        /// <summary>
        /// Get Fight
        /// </summary>
        /// <param name="fightid">The unique ID of this fight. Examples: <code>1100</code>, etc.</param>
        public FightDetail GetFight(string fightid)
        {
            return this.GetFightAsync(fightid).Result;
        }

        /// <summary>
        /// Get Fighter Asynchronous
        /// </summary>
        /// <param name="fighterid">Each fighter has a unique ID assigned by FantasyData. Fighter IDs can be determined by pulling player related data. Example: <code>140000098</code></param>
        public Task<Fighter> GetFighterAsync(string fighterid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("fighterid", fighterid.ToString()));
            return Task.Run<Fighter>(() =>
                base.Get<Fighter>("/v3/mma/stats/{format}/Fighter/{fighterid}", parameters)
            );
        }

        /// <summary>
        /// Get Fighter
        /// </summary>
        /// <param name="fighterid">Each fighter has a unique ID assigned by FantasyData. Fighter IDs can be determined by pulling player related data. Example: <code>140000098</code></param>
        public Fighter GetFighter(string fighterid)
        {
            return this.GetFighterAsync(fighterid).Result;
        }

        /// <summary>
        /// Get Fighters Asynchronous
        /// </summary>
        public Task<List<Fighter>> GetFightersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Fighter>>(() =>
                base.Get<List<Fighter>>("/v3/mma/stats/{format}/Fighters", parameters)
            );
        }

        /// <summary>
        /// Get Fighters
        /// </summary>
        public List<Fighter> GetFighters()
        {
            return this.GetFightersAsync().Result;
        }

        /// <summary>
        /// Get Leagues Asynchronous
        /// </summary>
        public Task<List<League>> GetLeaguesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<League>>(() =>
                base.Get<List<League>>("/v3/mma/stats/{format}/Leagues", parameters)
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
        /// Get Schedule Asynchronous
        /// </summary>
        /// <param name="league">The name of the league. Examples: <code>UFC</code>, etc</param>
        /// <param name="season">Year of the season. Examples: <code>2019</code>, <code>2020</code>, etc.</param>
        public Task<List<Event>> GetScheduleAsync(string league, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("league", league.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Event>>(() =>
                base.Get<List<Event>>("/v3/mma/stats/{format}/Schedule/{league}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="league">The name of the league. Examples: <code>UFC</code>, etc</param>
        /// <param name="season">Year of the season. Examples: <code>2019</code>, <code>2020</code>, etc.</param>
        public List<Event> GetSchedule(string league, string season)
        {
            return this.GetScheduleAsync(league, season).Result;
        }

    }
}

