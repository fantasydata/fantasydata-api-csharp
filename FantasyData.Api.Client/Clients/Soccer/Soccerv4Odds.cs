using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv4OddsClient : BaseClient
    {
        public Soccerv4OddsClient(string apiKey) : base(apiKey) { }
        public Soccerv4OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Betting Events by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v4/soccer/odds/{format}/BettingEventsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<BettingEvent> GetBettingEventsByDate(string competition, string date)
        {
            return this.GetBettingEventsByDateAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Betting Events by Season Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingEventsBySeasonAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v4/soccer/odds/{format}/BettingEventsBySeason/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Season
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<BettingEvent> GetBettingEventsBySeason(string competition, string season)
        {
            return this.GetBettingEventsBySeasonAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Betting Futures by Season Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v4/soccer/odds/{format}/BettingFuturesBySeason/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures by Season
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<BettingEvent> GetBettingFuturesBySeason(string competition, string season)
        {
            return this.GetBettingFuturesBySeasonAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Betting Market Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarket> GetBettingMarketAsync(string competition, string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v4/soccer/odds/{format}/BettingMarket/{competition}/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public BettingMarket GetBettingMarket(string competition, string marketId)
        {
            return this.GetBettingMarketAsync(competition, marketId).Result;
        }

        /// <summary>
        /// Get Betting Markets by Event Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventAsync(string competition, string eventId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v4/soccer/odds/{format}/BettingMarkets/{competition}/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Event
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        public List<BettingMarket> GetBettingMarketsByEvent(string competition, string eventId)
        {
            return this.GetBettingMarketsByEventAsync(competition, eventId).Result;
        }

        /// <summary>
        /// Get Betting Markets by GameID Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets).</param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameIDAsync(string competition, int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v4/soccer/odds/{format}/BettingMarketsByGameID/{competition}/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by GameID
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets).</param>
        public List<BettingMarket> GetBettingMarketsByGameID(string competition, int gameid)
        {
            return this.GetBettingMarketsByGameIDAsync(competition, gameid).Result;
        }

        /// <summary>
        /// Get Betting Markets by Market Type Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string competition, string eventId, string marketTypeID)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v4/soccer/odds/{format}/BettingMarketsByMarketType/{competition}/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Market Type
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string competition, string eventId, string marketTypeID)
        {
            return this.GetBettingMarketsByMarketTypeAsync(competition, eventId, marketTypeID).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<BettingEntityMetadataCollection> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<BettingEntityMetadataCollection>(() =>
                base.Get<BettingEntityMetadataCollection>("/v4/soccer/odds/{format}/BettingMetadata", parameters)
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
        /// Get Betting Player Props by GameID Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameIDAsync(string competition, int gameId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v4/soccer/odds/{format}/BettingPlayerPropsByGameID/{competition}/{gameId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props by GameID
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        public List<BettingMarket> GetBettingPlayerPropsByGameID(string competition, int gameId)
        {
            return this.GetBettingPlayerPropsByGameIDAsync(competition, gameId).Result;
        }

        /// <summary>
        /// Get In-Game Odds by Date by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2018-06-20</code>, <code>2018-06-23</code>.</param>
        public Task<List<GameInfo>> GetInGameOddsByDateByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v4/soccer/odds/{format}/LiveGameOddsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds by Date by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2018-06-20</code>, <code>2018-06-23</code>.</param>
        public List<GameInfo> GetInGameOddsByDateByCompetition(string competition, string date)
        {
            return this.GetInGameOddsByDateByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>14060</code>, <code>14061</code>, etc.</param>
        public Task<List<GameInfo>> GetInGameOddsLineMovementAsync(string competition, int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v4/soccer/odds/{format}/LiveGameOddsLineMovement/{competition}/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>14060</code>, <code>14061</code>, etc.</param>
        public List<GameInfo> GetInGameOddsLineMovement(string competition, int gameid)
        {
            return this.GetInGameOddsLineMovementAsync(competition, gameid).Result;
        }

        /// <summary>
        /// Get Period Game Odds By Date By Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<GameInfo>> GetPeriodGameOddsByDateByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v4/soccer/odds/{format}/AlternateMarketGameOddsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Period Game Odds By Date By Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<GameInfo> GetPeriodGameOddsByDateByCompetition(string competition, string date)
        {
            return this.GetPeriodGameOddsByDateByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Period Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>41323</code></param>
        public Task<List<GameInfo>> GetPeriodGameOddsLineMovementAsync(string competition, int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v4/soccer/odds/{format}/AlternateMarketGameOddsLineMovement/{competition}/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Period Game Odds Line Movement
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>41323</code></param>
        public List<GameInfo> GetPeriodGameOddsLineMovement(string competition, int gameid)
        {
            return this.GetPeriodGameOddsLineMovementAsync(competition, gameid).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds by Date by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<GameInfo>> GetPreGameOddsByDateByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v4/soccer/odds/{format}/GameOddsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds by Date by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<GameInfo> GetPreGameOddsByDateByCompetition(string competition, string date)
        {
            return this.GetPreGameOddsByDateByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>14060</code>, <code>14061</code>, etc.</param>
        public Task<List<GameInfo>> GetPreGameOddsLineMovementAsync(string competition, int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v4/soccer/odds/{format}/GameOddsLineMovement/{competition}/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>14060</code>, <code>14061</code>, etc.</param>
        public List<GameInfo> GetPreGameOddsLineMovement(string competition, int gameid)
        {
            return this.GetPreGameOddsLineMovementAsync(competition, gameid).Result;
        }

        /// <summary>
        /// Get Sportsbooks (Active) Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v4/soccer/odds/{format}/ActiveSportsbooks", parameters)
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

