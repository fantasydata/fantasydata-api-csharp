using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MMA;

namespace FantasyData.Api.Client
{
    public partial class MMAv3OddsClient : BaseClient
    {
        public MMAv3OddsClient(string apiKey) : base(apiKey) { }
        public MMAv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Event Fight Odds Asynchronous
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public Task<EventOdds> GetEventFightOddsAsync(string eventid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventid", eventid.ToString()));
            return Task.Run<EventOdds>(() =>
                base.Get<EventOdds>("/v3/mma/odds/{format}/EventOdds/{eventid}", parameters)
            );
        }

        /// <summary>
        /// Get Event Fight Odds
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public EventOdds GetEventFightOdds(string eventid)
        {
            return this.GetEventFightOddsAsync(eventid).Result;
        }

        /// <summary>
        /// Get Event Fight Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public Task<EventOdds> GetEventFightOddsLineMovementAsync(string eventid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventid", eventid.ToString()));
            return Task.Run<EventOdds>(() =>
                base.Get<EventOdds>("/v3/mma/odds/{format}/EventOddsLineMovement/{eventid}", parameters)
            );
        }

        /// <summary>
        /// Get Event Fight Odds Line Movement
        /// </summary>
        /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
        public EventOdds GetEventFightOddsLineMovement(string eventid)
        {
            return this.GetEventFightOddsLineMovementAsync(eventid).Result;
        }

        /// <summary>
        /// Get Sportsbooks (Active) Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/mma/odds/{format}/ActiveSportsbooks", parameters)
            );
        }

        /// <summary>
        /// Get Sportsbooks (Active)
        /// </summary>
        public List<Sportsbook> GetSportsbooksActive()
        {
            return this.GetSportsbooksActiveAsync().Result;
        }

        /// <summary>
        /// Get Betting Events By Event Asynchronous
        /// </summary>
        /// <param name="eventId">The top level EventId for the event (i.e. UFC 250). Distinct from the BettingEventId.</param>
        public Task<List<BettingEvent>> GetBettingEventsByEventAsync(string eventId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/mma/odds/{format}/BettingEventsByEvent/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events By Event
        /// </summary>
        /// <param name="eventId">The top level EventId for the event (i.e. UFC 250). Distinct from the BettingEventId.</param>
        public List<BettingEvent> GetBettingEventsByEvent(string eventId)
        {
            return this.GetBettingEventsByEventAsync(eventId).Result;
        }

        /// <summary>
        /// Get Betting Market Asynchronous
        /// </summary>
        /// <param name="marketId">The BettingMarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarket> GetBettingMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/mma/odds/{format}/BettingMarket/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market
        /// </summary>
        /// <param name="marketId">The BettingMarketId of the desired market for which to pull all outcomes/bets.</param>
        public BettingMarket GetBettingMarket(string marketId)
        {
            return this.GetBettingMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Markets By Betting Event Asynchronous
        /// </summary>
        /// <param name="bettingEventId">The BettingEventId for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByBettingEventAsync(string bettingEventId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("bettingEventId", bettingEventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/mma/odds/{format}/BettingMarketsByBettingEvent/{bettingEventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets By Betting Event
        /// </summary>
        /// <param name="bettingEventId">The BettingEventId for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByBettingEvent(string bettingEventId, string include)
        {
            return this.GetBettingMarketsByBettingEventAsync(bettingEventId, include).Result;
        }

        /// <summary>
        /// Get Betting Markets by Market Type Asynchronous
        /// </summary>
        /// <param name="eventId">The top level EventId for the event (i.e. UFC 250). Distinct from the BettingEventId.</param>
        /// <param name="marketTypeId">The BettingMarketTypeId of the desired market types to pull. See BettingMetaData endpoint for all of the types.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeId", marketTypeId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/mma/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Market Type
        /// </summary>
        /// <param name="eventId">The top level EventId for the event (i.e. UFC 250). Distinct from the BettingEventId.</param>
        /// <param name="marketTypeId">The BettingMarketTypeId of the desired market types to pull. See BettingMetaData endpoint for all of the types.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeId, string include)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeId, include).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<List<BettingEntityMetadata>> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BettingEntityMetadata>>(() =>
                base.Get<List<BettingEntityMetadata>>("/v3/mma/odds/{format}/BettingMetadata", parameters)
            );
        }

        /// <summary>
        /// Get Betting Metadata
        /// </summary>
        public List<BettingEntityMetadata> GetBettingMetadata()
        {
            return this.GetBettingMetadataAsync().Result;
        }

        /// <summary>
        /// Get Betting Fighter Props By Event Asynchronous
        /// </summary>
        /// <param name="eventId">The top level EventId for the event (i.e. UFC 250). Distinct from the BettingEventId.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingFighterPropsByEventAsync(string eventId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/mma/odds/{format}/BettingFighterPropsByEvent/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Fighter Props By Event
        /// </summary>
        /// <param name="eventId">The top level EventId for the event (i.e. UFC 250). Distinct from the BettingEventId.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingFighterPropsByEvent(string eventId, string include)
        {
            return this.GetBettingFighterPropsByEventAsync(eventId, include).Result;
        }

        /// <summary>
        /// Get Upcoming Betting Events Asynchronous
        /// </summary>
        public Task<List<BettingEvent>> GetUpcomingBettingEventsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/mma/odds/{format}/UpcomingBettingEvents", parameters)
            );
        }

        /// <summary>
        /// Get Upcoming Betting Events
        /// </summary>
        public List<BettingEvent> GetUpcomingBettingEvents()
        {
            return this.GetUpcomingBettingEventsAsync().Result;
        }

    }
}

