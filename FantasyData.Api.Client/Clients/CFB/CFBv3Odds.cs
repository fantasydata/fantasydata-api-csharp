using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3OddsClient : BaseClient
    {
        public CFBv3OddsClient(string apiKey) : base(apiKey) { }
        public CFBv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get In-Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetLiveGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cfb/odds/{format}/LiveGameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetLiveGameOddsByWeek(string season, int week)
        {
            return this.GetLiveGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>8487</code> or <code>8657</code></param>
        public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cfb/odds/{format}/LiveGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>8487</code> or <code>8657</code></param>
        public List<GameInfo> GetLiveGameOddsLineMovement(int gameid)
        {
            return this.GetLiveGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cfb/odds/{format}/GameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetGameOddsByWeek(string season, int week)
        {
            return this.GetGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>8487</code> or <code>8657</code></param>
        public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cfb/odds/{format}/GameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>8487</code> or <code>8657</code></param>
        public List<GameInfo> GetGameOddsLineMovement(int gameid)
        {
            return this.GetGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetAlternateMarketGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cfb/odds/{format}/AlternateMarketGameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetAlternateMarketGameOddsByWeek(string season, int week)
        {
            return this.GetAlternateMarketGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>8487</code> or <code>8657</code></param>
        public Task<List<GameInfo>> GetAlternateMarketGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cfb/odds/{format}/AlternateMarketGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>8487</code> or <code>8657</code></param>
        public List<GameInfo> GetAlternateMarketGameOddsLineMovement(int gameid)
        {
            return this.GetAlternateMarketGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Betting Trends by Matchup Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        public Task<MatchupTrends> GetMatchupTrendsAsync(string team, string opponent)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            parameters.Add(new KeyValuePair<string, string>("opponent", opponent.ToString()));
            return Task.Run<MatchupTrends>(() =>
                base.Get<MatchupTrends>("/v3/cfb/odds/{format}/MatchupTrends/{team}/{opponent}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends by Matchup
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        public MatchupTrends GetMatchupTrends(string team, string opponent)
        {
            return this.GetMatchupTrendsAsync(team, opponent).Result;
        }

        /// <summary>
        /// Get Betting Trends by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        public Task<TeamTrends> GetTeamTrendsAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<TeamTrends>(() =>
                base.Get<TeamTrends>("/v3/cfb/odds/{format}/TeamTrends/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        public TeamTrends GetTeamTrends(string team)
        {
            return this.GetTeamTrendsAsync(team).Result;
        }

        /// <summary>
        /// Get Betting Events by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-10-17</code></param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/cfb/odds/{format}/BettingEventsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-10-17</code></param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingEventsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/cfb/odds/{format}/BettingEvents/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Season
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<BettingEvent> GetBettingEvents(string season)
        {
            return this.GetBettingEventsAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Futures by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/cfb/odds/{format}/BettingFuturesBySeason/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures by Season
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<BettingEvent> GetBettingFuturesBySeason(string season)
        {
            return this.GetBettingFuturesBySeasonAsync(season).Result;
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
                base.Get<BettingMarket>("/v3/cfb/odds/{format}/BettingMarket/{marketId}", parameters)
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
        public Task<List<BettingMarket>> GetBettingMarketsAsync(string eventId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/cfb/odds/{format}/BettingMarkets/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        public List<BettingMarket> GetBettingMarkets(string eventId)
        {
            return this.GetBettingMarketsAsync(eventId).Result;
        }

        /// <summary>
        /// Get Betting Markets by GameID Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets).</param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameIDAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/cfb/odds/{format}/BettingMarketsByGameID/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by GameID
        /// </summary>
        /// <param name="gameid">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets).</param>
        public List<BettingMarket> GetBettingMarketsByGameID(int gameid)
        {
            return this.GetBettingMarketsByGameIDAsync(gameid).Result;
        }

        /// <summary>
        /// Get Betting Markets by Market Type Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/cfb/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID).Result;
        }

        /// <summary>
        /// Get Betting Player Props by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-10-17</code></param>
        public Task<List<BettingEvent>> GetBettingPlayerPropsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/cfb/odds/{format}/BettingPlayerPropsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-10-17</code></param>
        public List<BettingEvent> GetBettingPlayerPropsByDate(string date)
        {
            return this.GetBettingPlayerPropsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<List<BettingEntityMetadata>> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BettingEntityMetadata>>(() =>
                base.Get<List<BettingEntityMetadata>>("/v3/cfb/odds/{format}/BettingMetadata", parameters)
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
        /// Get Sportsbooks (Active) Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetActiveSportsbooksAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/cfb/odds/{format}/ActiveSportsbooks", parameters)
            );
        }
        
        /// <summary>
        /// Get Sportsbooks (Active)
        /// </summary>
        public List<Sportsbook> GetActiveSportsbooks()
        {
            return this.GetActiveSportsbooksAsync().Result;
        }

        /// <summary>
        /// Get Betting Resulting By Market Asynchronous
        /// </summary>
        /// <param name="marketId">BettingMarketID of the market for which you would like to see resulted outcomes. Valid example ID <code>17819</code></param>
        public Task<BettingMarketResult> GetBettingMarketResultsAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketResult>(() =>
                base.Get<BettingMarketResult>("/v3/cfb/odds/{format}/BettingMarketResults/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Resulting By Market
        /// </summary>
        /// <param name="marketId">BettingMarketID of the market for which you would like to see resulted outcomes. Valid example ID <code>17819</code></param>
        public BettingMarketResult GetBettingMarketResults(string marketId)
        {
            return this.GetBettingMarketResultsAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Splits By BettingMarketId Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull splits.</param>
        public Task<BettingMarketSplit> GetBettingSplitsByMarketIdAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketSplit>(() =>
                base.Get<BettingMarketSplit>("/v3/cfb/odds/{format}/BettingSplitsByMarketId/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits By BettingMarketId
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull splits.</param>
        public BettingMarketSplit GetBettingSplitsByMarketId(string marketId)
        {
            return this.GetBettingSplitsByMarketIdAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Splits By GameID Asynchronous
        /// </summary>
        /// <param name="gameid">The ID of the game for which you want to receive splits for.Example <code>11778</code></param>
        public Task<GameBettingSplit> GetBettingSplitsByGameIdAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<GameBettingSplit>(() =>
                base.Get<GameBettingSplit>("/v3/cfb/odds/{format}/BettingSplitsByGameId/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits By GameID
        /// </summary>
        /// <param name="gameid">The ID of the game for which you want to receive splits for.Example <code>11778</code></param>
        public GameBettingSplit GetBettingSplitsByGameId(int gameid)
        {
            return this.GetBettingSplitsByGameIdAsync(gameid).Result;
        }

        /// <summary>
        /// Get Betting Player Props by GameID Asynchronous
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameIDAsync(int gameId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/cfb/odds/{format}/BettingPlayerPropsByGameID/{gameId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props by GameID
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        public List<BettingMarket> GetBettingPlayerPropsByGameID(int gameId)
        {
            return this.GetBettingPlayerPropsByGameIDAsync(gameId).Result;
        }

    }
}

