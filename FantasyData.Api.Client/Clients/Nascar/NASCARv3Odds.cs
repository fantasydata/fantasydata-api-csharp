using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Nascar;

namespace FantasyData.Api.Client
{
    public partial class NASCARv3OddsClient : BaseClient
    {
        public NASCARv3OddsClient(string apiKey) : base(apiKey) { }
        public NASCARv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Race Odds Asynchronous
        /// </summary>
        /// <param name="Raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceOdds> GetRaceOddsAsync(int Raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("Raceid", Raceid.ToString()));
            return Task.Run<RaceOdds>(() =>
                base.Get<RaceOdds>("/v3/nascar/odds/{format}/RaceOdds/{Raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Race Odds
        /// </summary>
        /// <param name="Raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceOdds GetRaceOdds(int Raceid)
        {
            return this.GetRaceOddsAsync(Raceid).Result;
        }

        /// <summary>
        /// Get Race Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="Raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceOdds> GetRaceOddsLineMovementAsync(int Raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("Raceid", Raceid.ToString()));
            return Task.Run<RaceOdds>(() =>
                base.Get<RaceOdds>("/v3/nascar/odds/{format}/RaceOddsLineMovement/{Raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Race Odds Line Movement
        /// </summary>
        /// <param name="Raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceOdds GetRaceOddsLineMovement(int Raceid)
        {
            return this.GetRaceOddsLineMovementAsync(Raceid).Result;
        }

        /// <summary>
        /// Get Sportsbooks - by Active Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/nascar/odds/{format}/ActiveSportsbooks", parameters)
            );
        }

        /// <summary>
        /// Get Sportsbooks - by Active
        /// </summary>
        public List<Sportsbook> GetSportsbooksByActive()
        {
            return this.GetSportsbooksByActiveAsync().Result;
        }

        /// <summary>
        /// Get Betting Events - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the race(s). Examples: 2023-02-19.</param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nascar/odds/{format}/BettingEventsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events - by Date
        /// </summary>
        /// <param name="date">The date of the race(s). Examples: 2023-02-19.</param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events - by Season Asynchronous
        /// </summary>
        /// <param name="season">The season to get BettingEvents. Valid entries are formatted as years such as <code>2023</code></param>
        public Task<List<BettingEvent>> GetBettingEventsBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nascar/odds/{format}/BettingEvents/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events - by Season
        /// </summary>
        /// <param name="season">The season to get BettingEvents. Valid entries are formatted as years such as <code>2023</code></param>
        public List<BettingEvent> GetBettingEventsBySeason(string season)
        {
            return this.GetBettingEventsBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarket> GetBettingMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/nascar/odds/{format}/BettingMarket/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public BettingMarket GetBettingMarket(string marketId)
        {
            return this.GetBettingMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Event Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventAsync(string eventId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nascar/odds/{format}/BettingMarkets/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByEvent(string eventId, string include)
        {
            return this.GetBettingMarketsByEventAsync(eventId, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type Asynchronous
        /// </summary>
        /// <param name="eventID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: 1 for Race Lines, 2 for Driver Props, 3 for Head to Head Props, 4 for Group Props, 6 for Race Props</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventID, string marketTypeID, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventID", eventID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nascar/odds/{format}/BettingMarketsByMarketType/{eventID}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Market Type
        /// </summary>
        /// <param name="eventID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: 1 for Race Lines, 2 for Driver Props, 3 for Head to Head Props, 4 for Group Props, 6 for Race Props</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventID, string marketTypeID, string include)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventID, marketTypeID, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Race Asynchronous
        /// </summary>
        /// <param name="raceID">The RaceID of the desired race for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByRaceAsync(int raceID, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceID", raceID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nascar/odds/{format}/BettingMarketsByRaceID/{raceID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Race
        /// </summary>
        /// <param name="raceID">The RaceID of the desired race for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByRace(int raceID, string include)
        {
            return this.GetBettingMarketsByRaceAsync(raceID, include).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<BettingEntityMetadataCollection> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<BettingEntityMetadataCollection>(() =>
                base.Get<BettingEntityMetadataCollection>("/v3/nascar/odds/{format}/BettingMetaData", parameters)
            );
        }

        /// <summary>
        /// Get Betting Metadata
        /// </summary>
        public BettingEntityMetadataCollection GetBettingMetadata()
        {
            return this.GetBettingMetadataAsync().Result;
        }

    }
}

