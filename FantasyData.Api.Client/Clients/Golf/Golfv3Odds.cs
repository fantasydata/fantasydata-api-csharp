using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Golf;

namespace FantasyData.Api.Client
{
    public partial class Golfv3OddsClient : BaseClient
    {
        public Golfv3OddsClient(string apiKey) : base(apiKey) { }
        public Golfv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Tournament Odds Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<TournamentOdds> GetTournamentOddsAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/TournamentOdds/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Tournament Odds
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public TournamentOdds GetTournamentOdds(int tournamentid)
        {
            return this.GetTournamentOddsAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Tournament Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<TournamentOdds> GetTournamentOddsLineMovementAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/TournamentOddsLineMovement/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Tournament Odds Line Movement
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public TournamentOdds GetTournamentOddsLineMovement(int tournamentid)
        {
            return this.GetTournamentOddsLineMovementAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get In-play Tournament Odds Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<TournamentOdds> GetInplayTournamentOddsAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/InPlayTournamentOdds/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get In-play Tournament Odds
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public TournamentOdds GetInplayTournamentOdds(int tournamentid)
        {
            return this.GetInplayTournamentOddsAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get In-play Tournament Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<TournamentOdds> GetInplayTournamentOddsLineMovementAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/InPlayTournamentOddsLineMovement/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get In-play Tournament Odds Line Movement
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public TournamentOdds GetInplayTournamentOddsLineMovement(int tournamentid)
        {
            return this.GetInplayTournamentOddsLineMovementAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Sportsbooks (Active) Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/golf/odds/{format}/ActiveSportsbooks", parameters)
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
        /// Get Betting Events by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the tournament(s). Can be any of the dates for the span of a tournament (i.e. Thursday through Sunday). Examples: <code>2020-10-17</code></param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/golf/odds/{format}/BettingEventsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Date
        /// </summary>
        /// <param name="date">The date of the tournament(s). Can be any of the dates for the span of a tournament (i.e. Thursday through Sunday). Examples: <code>2020-10-17</code></param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingEventsBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/golf/odds/{format}/BettingEvents/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Season
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
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
                base.Get<BettingMarket>("/v3/golf/odds/{format}/BettingMarket/{marketId}", parameters)
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
        /// Get Betting Markets by Event Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventAsync(string eventId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarkets/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByEvent(string eventId, string include)
        {
            return this.GetBettingMarketsByEventAsync(eventId, include).Result;
        }

        /// <summary>
        /// Get Betting Markets by Market Type Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID, string include)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID, include).Result;
        }

        /// <summary>
        /// Get Betting Markets by TournamentID Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByTournamentIDAsync(int tournamentid, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarketsByTournamentID/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by TournamentID
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByTournamentID(int tournamentid, string include)
        {
            return this.GetBettingMarketsByTournamentIDAsync(tournamentid, include).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<List<BettingEntityMetadata>> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BettingEntityMetadata>>(() =>
                base.Get<List<BettingEntityMetadata>>("/v3/golf/odds/{format}/BettingMetadata", parameters)
            );
        }

        /// <summary>
        /// Get Betting Metadata
        /// </summary>
        public List<BettingEntityMetadata> GetBettingMetadata()
        {
            return this.GetBettingMetadataAsync().Result;
        }

    }
}

