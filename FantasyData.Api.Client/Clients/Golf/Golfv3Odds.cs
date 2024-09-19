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
        /// Get In-Play Tournament Odds Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<TournamentOdds> GetInPlayTournamentOddsAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/InPlayTournamentOdds/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Play Tournament Odds
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public TournamentOdds GetInPlayTournamentOdds(int tournamentid)
        {
            return this.GetInPlayTournamentOddsAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get In-Play Tournament Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public Task<TournamentOdds> GetInPlayTournamentOddsLineMovementAsync(int tournamentid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/InPlayTournamentOddsLineMovement/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Play Tournament Odds Line Movement
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        public TournamentOdds GetInPlayTournamentOddsLineMovement(int tournamentid)
        {
            return this.GetInPlayTournamentOddsLineMovementAsync(tournamentid).Result;
        }

        /// <summary>
        /// Get Sportsbooks - by Active Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/golf/odds/{format}/ActiveSportsbooks", parameters)
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
        /// Get Betting Events - by Date
        /// </summary>
        /// <param name="date">The date of the tournament(s). Can be any of the dates for the span of a tournament (i.e. Thursday through Sunday). Examples: <code>2020-10-17</code></param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events - by Season Asynchronous
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
        /// Get Betting Events - by Season
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
        /// Get Betting Markets - by Event Asynchronous
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
        /// Get Betting Markets - by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByEvent(string eventId, string include)
        {
            return this.GetBettingMarketsByEventAsync(eventId, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type Asynchronous
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
        /// Get Betting Markets - by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID, string include)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Tournament Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByTournamentAsync(int tournamentid, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarketsByTournamentID/{tournamentid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Tournament
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByTournament(int tournamentid, string include)
        {
            return this.GetBettingMarketsByTournamentAsync(tournamentid, include).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<BettingEntityMetadataCollection> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<BettingEntityMetadataCollection>(() =>
                base.Get<BettingEntityMetadataCollection>("/v3/golf/odds/{format}/BettingMetadata", parameters)
            );
        }

        /// <summary>
        /// Get Betting Metadata
        /// </summary>
        public BettingEntityMetadataCollection GetBettingMetadata()
        {
            return this.GetBettingMetadataAsync().Result;
        }

        /// <summary>
        /// Get Betting Market [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<BettingMarket> GetBettingMarketSportsbookGroupAsync(string marketId, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/golf/odds/{format}/BettingMarket/{marketId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market [Sportsbook Group]
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public BettingMarket GetBettingMarketSportsbookGroup(string marketId, string sportsbookgroup)
        {
            return this.GetBettingMarketSportsbookGroupAsync(marketId, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Event [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventSportsbookGroupAsync(string eventId, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarketsByEvent/{eventId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Event [Sportsbook Group]
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByEventSportsbookGroup(string eventId, string sportsbookgroup, string include)
        {
            return this.GetBettingMarketsByEventSportsbookGroupAsync(eventId, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeSportsbookGroupAsync(string eventId, string marketTypeID, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Market Type [Sportsbook Group]
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketTypeSportsbookGroup(string eventId, string marketTypeID, string sportsbookgroup, string include)
        {
            return this.GetBettingMarketsByMarketTypeSportsbookGroupAsync(eventId, marketTypeID, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Tournament [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByTournamentSportsbookGroupAsync(int tournamentid, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingMarketsByTournamentID/{tournamentid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Tournament [Sportsbook Group]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByTournamentSportsbookGroup(int tournamentid, string sportsbookgroup, string include)
        {
            return this.GetBettingMarketsByTournamentSportsbookGroupAsync(tournamentid, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Player Props - by Tournament [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByTournamentSportsbookGroupAsync(int tournamentid, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/golf/odds/{format}/BettingPlayerPropsByTournamentID/{tournamentid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props - by Tournament [Sportsbook Group]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of the desired tournament for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingPlayerPropsByTournamentSportsbookGroup(int tournamentid, string sportsbookgroup, string include)
        {
            return this.GetBettingPlayerPropsByTournamentSportsbookGroupAsync(tournamentid, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Tournament Odds [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<TournamentOdds> GetTournamentOddsSportsbookGroupAsync(int tournamentid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/TournamentOdds/{tournamentid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Tournament Odds [Sportsbook Group]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public TournamentOdds GetTournamentOddsSportsbookGroup(int tournamentid, string sportsbookgroup)
        {
            return this.GetTournamentOddsSportsbookGroupAsync(tournamentid, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Tournament Odds Line Movement [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<TournamentOdds> GetTournamentOddsLineMovementSportsbookGroupAsync(int tournamentid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/TournamentOddsLineMovement/{tournamentid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Tournament Odds Line Movement [Sportsbook Group]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public TournamentOdds GetTournamentOddsLineMovementSportsbookGroup(int tournamentid, string sportsbookgroup)
        {
            return this.GetTournamentOddsLineMovementSportsbookGroupAsync(tournamentid, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarket> GetBettingMarket_1701Async(string marketId)
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
        public BettingMarket GetBettingMarket_1701(string marketId)
        {
            return this.GetBettingMarket_1701Async(marketId).Result;
        }

        /// <summary>
        /// Get In-Play Tournament Odds [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<TournamentOdds> GetInPlayTournamentOddsSportsbookGroupAsync(int tournamentid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/InPlayTournamentOdds/{tournamentid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get In-Play Tournament Odds [Sportsbook Group]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public TournamentOdds GetInPlayTournamentOddsSportsbookGroup(int tournamentid, string sportsbookgroup)
        {
            return this.GetInPlayTournamentOddsSportsbookGroupAsync(tournamentid, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get In-Play Tournament Odds Line Movement [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<TournamentOdds> GetInPlayTournamentOddsLineMovementSportsbookGroupAsync(int tournamentid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tournamentid", tournamentid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<TournamentOdds>(() =>
                base.Get<TournamentOdds>("/v3/golf/odds/{format}/InPlayTournamentOddsLineMovement/{tournamentid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get In-Play Tournament Odds Line Movement [Sportsbook Group]
        /// </summary>
        /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public TournamentOdds GetInPlayTournamentOddsLineMovementSportsbookGroup(int tournamentid, string sportsbookgroup)
        {
            return this.GetInPlayTournamentOddsLineMovementSportsbookGroupAsync(tournamentid, sportsbookgroup).Result;
        }

    }
}

