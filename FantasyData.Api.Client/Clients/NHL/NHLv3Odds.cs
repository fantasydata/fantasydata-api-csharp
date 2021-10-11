using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NHL;

namespace FantasyData.Api.Client
{
    public partial class NHLv3OddsClient : BaseClient
    {
        public NHLv3OddsClient(string apiKey) : base(apiKey) { }
        public NHLv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get In-Game Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetLiveGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/LiveGameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<GameInfo> GetLiveGameOddsByDate(string date)
        {
            return this.GetLiveGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/LiveGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public List<GameInfo> GetLiveGameOddsLineMovement(int gameid)
        {
            return this.GetLiveGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/GameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<GameInfo> GetGameOddsByDate(string date)
        {
            return this.GetGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/GameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public List<GameInfo> GetGameOddsLineMovement(int gameid)
        {
            return this.GetGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Generated Player Props by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<PlayerProp>> GetPlayerPropsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<PlayerProp> GetPlayerPropsByDate(string date)
        {
            return this.GetPlayerPropsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Generated Player Props by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code></param>
        public Task<List<PlayerProp>> GetPlayerPropsByPlayerIDAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByPlayerID/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code></param>
        public List<PlayerProp> GetPlayerPropsByPlayerID(string date, int playerid)
        {
            return this.GetPlayerPropsByPlayerIDAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Generated Player Props by Team Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public Task<List<PlayerProp>> GetPlayerPropsByTeamAsync(string date, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByTeam/{date}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props by Team
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public List<PlayerProp> GetPlayerPropsByTeam(string date, string team)
        {
            return this.GetPlayerPropsByTeamAsync(date, team).Result;
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetAlternateMarketGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/AlternateMarketGameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<GameInfo> GetAlternateMarketGameOddsByDate(string date)
        {
            return this.GetAlternateMarketGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public Task<List<GameInfo>> GetAlternateMarketGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/AlternateMarketGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public List<GameInfo> GetAlternateMarketGameOddsLineMovement(int gameid)
        {
            return this.GetAlternateMarketGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Betting Trends by Matchup Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public Task<MatchupTrends> GetMatchupTrendsAsync(string team, string opponent)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            parameters.Add(new KeyValuePair<string, string>("opponent", opponent.ToString()));
            return Task.Run<MatchupTrends>(() =>
                base.Get<MatchupTrends>("/v3/nhl/odds/{format}/MatchupTrends/{team}/{opponent}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends by Matchup
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public MatchupTrends GetMatchupTrends(string team, string opponent)
        {
            return this.GetMatchupTrendsAsync(team, opponent).Result;
        }

        /// <summary>
        /// Get Betting Trends by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public Task<TeamTrends> GetTeamTrendsAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<TeamTrends>(() =>
                base.Get<TeamTrends>("/v3/nhl/odds/{format}/TeamTrends/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public TeamTrends GetTeamTrends(string team)
        {
            return this.GetTeamTrendsAsync(team).Result;
        }

        /// <summary>
        /// Get Betting Events by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingEventsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2020</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2020STAR</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingEventsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingEvents/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Season
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2020</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2020STAR</code>, <code>2021</code>, etc.</param>
        public List<BettingEvent> GetBettingEvents(string season)
        {
            return this.GetBettingEventsAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Futures by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc</param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingFuturesBySeason/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures by Season
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc</param>
        public List<BettingEvent> GetBettingFuturesBySeason(string season)
        {
            return this.GetBettingFuturesBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>421</code>, <code>1041</code>, etc.</param>
        public Task<BettingMarket> GetBettingMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/nhl/odds/{format}/BettingMarket/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>421</code>, <code>1041</code>, etc.</param>
        public BettingMarket GetBettingMarket(string marketId)
        {
            return this.GetBettingMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Markets by Event Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        public Task<List<BettingMarket>> GetBettingMarketsAsync(string eventId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarkets/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        public List<BettingMarket> GetBettingMarkets(string eventId)
        {
            return this.GetBettingMarketsAsync(eventId).Result;
        }

        /// <summary>
        /// Get Betting Markets by GameID Asynchronous
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameIDAsync(int gameID)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameID", gameID.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByGameID/{gameID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by GameID
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
        public List<BettingMarket> GetBettingMarketsByGameID(int gameID)
        {
            return this.GetBettingMarketsByGameIDAsync(gameID).Result;
        }

        /// <summary>
        /// Get Betting Markets by Market Type Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID).Result;
        }

        /// <summary>
        /// Get Betting Player Props by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
        public Task<List<BettingEvent>> GetBettingPlayerPropsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingPlayerPropsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
        public List<BettingEvent> GetBettingPlayerPropsByDate(string date)
        {
            return this.GetBettingPlayerPropsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<List<BettingEntityMetadata>> GetBettingmetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BettingEntityMetadata>>(() =>
                base.Get<List<BettingEntityMetadata>>("/v3/nhl/odds/{format}/Bettingmetadata", parameters)
            );
        }

        /// <summary>
        /// Get Betting Metadata
        /// </summary>
        public List<BettingEntityMetadata> GetBettingmetadata()
        {
            return this.GetBettingmetadataAsync().Result;
        }

        /// <summary>
        /// Get Sportsbooks (Active) Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetActiveSportsbooksAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/nhl/odds/{format}/ActiveSportsbooks", parameters)
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
        /// Get Betting Splits By BettingMarketId Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull splits. MarketIds are pulled from the Betting Markets endpoints.</param>
        public Task<BettingMarketSplit> GetBettingSplitsByMarketIdAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketSplit>(() =>
                base.Get<BettingMarketSplit>("/v3/nhl/odds/{format}/BettingSplitsByMarketId/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits By BettingMarketId
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull splits. MarketIds are pulled from the Betting Markets endpoints.</param>
        public BettingMarketSplit GetBettingSplitsByMarketId(string marketId)
        {
            return this.GetBettingSplitsByMarketIdAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Splits By GameID Asynchronous
        /// </summary>
        /// <param name="gameId">The ID of the game for which you want to receive splits for. GameIds are pulled from the Schedules and Games by Date endpoints.</param>
        public Task<GameBettingSplit> GetBettingSplitsByGameIdAsync(int gameId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            return Task.Run<GameBettingSplit>(() =>
                base.Get<GameBettingSplit>("/v3/nhl/odds/{format}/BettingSplitsByGameId/{gameId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits By GameID
        /// </summary>
        /// <param name="gameId">The ID of the game for which you want to receive splits for. GameIds are pulled from the Schedules and Games by Date endpoints.</param>
        public GameBettingSplit GetBettingSplitsByGameId(int gameId)
        {
            return this.GetBettingSplitsByGameIdAsync(gameId).Result;
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
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingPlayerPropsByGameID/{gameId}", parameters)
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

        /// <summary>
        /// Get Betting Results By Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarketResult> GetBettingMarketResultsAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketResult>(() =>
                base.Get<BettingMarketResult>("/v3/nhl/odds/{format}/BettingMarketResults/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Results By Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public BettingMarketResult GetBettingMarketResults(string marketId)
        {
            return this.GetBettingMarketResultsAsync(marketId).Result;
        }

    }
}

