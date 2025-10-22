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
        /// Get In-Game Odds - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetInGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/LiveGameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<GameInfo> GetInGameOddsByDate(string date)
        {
            return this.GetInGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public Task<List<GameInfo>> GetInGameOddsLineMovementAsync(int gameid)
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
        public List<GameInfo> GetInGameOddsLineMovement(int gameid)
        {
            return this.GetInGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetPreGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/GameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<GameInfo> GetPreGameOddsByDate(string date)
        {
            return this.GetPreGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public Task<List<GameInfo>> GetPreGameOddsLineMovementAsync(int gameid)
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
        public List<GameInfo> GetPreGameOddsLineMovement(int gameid)
        {
            return this.GetPreGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Generated Player Props - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<PlayerProp>> GetGeneratedPlayerPropsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<PlayerProp> GetGeneratedPlayerPropsByDate(string date)
        {
            return this.GetGeneratedPlayerPropsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Generated Player Props - by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code></param>
        public Task<List<PlayerProp>> GetGeneratedPlayerPropsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByPlayerID/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props - by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code></param>
        public List<PlayerProp> GetGeneratedPlayerPropsByPlayer(string date, int playerid)
        {
            return this.GetGeneratedPlayerPropsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Generated Player Props - by Team Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public Task<List<PlayerProp>> GetGeneratedPlayerPropsByTeamAsync(string date, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByTeam/{date}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props - by Team
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public List<PlayerProp> GetGeneratedPlayerPropsByTeam(string date, string team)
        {
            return this.GetGeneratedPlayerPropsByTeamAsync(date, team).Result;
        }

        /// <summary>
        /// Get Period Game Odds - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetPeriodGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/AlternateMarketGameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Period Game Odds - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<GameInfo> GetPeriodGameOddsByDate(string date)
        {
            return this.GetPeriodGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Period Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public Task<List<GameInfo>> GetPeriodGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/AlternateMarketGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Period Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        public List<GameInfo> GetPeriodGameOddsLineMovement(int gameid)
        {
            return this.GetPeriodGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Betting Trends - by Matchup Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public Task<MatchupTrends> GetBettingTrendsByMatchupAsync(string team, string opponent)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            parameters.Add(new KeyValuePair<string, string>("opponent", opponent.ToString()));
            return Task.Run<MatchupTrends>(() =>
                base.Get<MatchupTrends>("/v3/nhl/odds/{format}/MatchupTrends/{team}/{opponent}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends - by Matchup
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public MatchupTrends GetBettingTrendsByMatchup(string team, string opponent)
        {
            return this.GetBettingTrendsByMatchupAsync(team, opponent).Result;
        }

        /// <summary>
        /// Get Betting Trends - by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public Task<TeamTrends> GetBettingTrendsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<TeamTrends>(() =>
                base.Get<TeamTrends>("/v3/nhl/odds/{format}/TeamTrends/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends - by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
        public TeamTrends GetBettingTrendsByTeam(string team)
        {
            return this.GetBettingTrendsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Betting Events - by Date Asynchronous
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
        /// Get Betting Events - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events - by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2020</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2020STAR</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingEventsBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingEvents/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events - by Season
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2020</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2020STAR</code>, <code>2021</code>, etc.</param>
        public List<BettingEvent> GetBettingEventsBySeason(string season)
        {
            return this.GetBettingEventsBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Futures - by Season Asynchronous
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
        /// Get Betting Futures - by Season
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
        /// Get Betting Markets - by Event Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventAsync(string eventId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarkets/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByEvent(string eventId, string include)
        {
            return this.GetBettingMarketsByEventAsync(eventId, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Game Asynchronous
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameAsync(int gameID, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameID", gameID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByGameID/{gameID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Game
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByGame(int gameID, string include)
        {
            return this.GetBettingMarketsByGameAsync(gameID, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID, string include)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID, include).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<BettingEntityMetadataCollection> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<BettingEntityMetadataCollection>(() =>
                base.Get<BettingEntityMetadataCollection>("/v3/nhl/odds/{format}/Bettingmetadata", parameters)
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
        /// Get Sportsbooks - by Active Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/nhl/odds/{format}/ActiveSportsbooks", parameters)
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
        /// Get Betting Splits - by Betting Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull splits. MarketIds are pulled from the Betting Markets endpoints.</param>
        public Task<BettingMarketSplit> GetBettingSplitsByBettingMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketSplit>(() =>
                base.Get<BettingMarketSplit>("/v3/nhl/odds/{format}/BettingSplitsByMarketId/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits - by Betting Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull splits. MarketIds are pulled from the Betting Markets endpoints.</param>
        public BettingMarketSplit GetBettingSplitsByBettingMarket(string marketId)
        {
            return this.GetBettingSplitsByBettingMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Splits - by Game Asynchronous
        /// </summary>
        /// <param name="gameId">The ID of the game for which you want to receive splits for. GameIds are pulled from the Schedules and Games by Date endpoints.</param>
        public Task<GameBettingSplit> GetBettingSplitsByGameAsync(int gameId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            return Task.Run<GameBettingSplit>(() =>
                base.Get<GameBettingSplit>("/v3/nhl/odds/{format}/BettingSplitsByGameId/{gameId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits - by Game
        /// </summary>
        /// <param name="gameId">The ID of the game for which you want to receive splits for. GameIds are pulled from the Schedules and Games by Date endpoints.</param>
        public GameBettingSplit GetBettingSplitsByGame(int gameId)
        {
            return this.GetBettingSplitsByGameAsync(gameId).Result;
        }

        /// <summary>
        /// Get Betting Player Props - by Game Asynchronous
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameAsync(int gameId, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingPlayerPropsByGameID/{gameId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props - by Game
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingPlayerPropsByGame(int gameId, string include)
        {
            return this.GetBettingPlayerPropsByGameAsync(gameId, include).Result;
        }

        /// <summary>
        /// Get Betting Results - by Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarketResult> GetBettingResultsByMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketResult>(() =>
                base.Get<BettingMarketResult>("/v3/nhl/odds/{format}/BettingMarketResults/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Results - by Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public BettingMarketResult GetBettingResultsByMarket(string marketId)
        {
            return this.GetBettingResultsByMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Futures - by Season [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonSportsbookGroupAsync(string season, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingFuturesBySeason/{season}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures - by Season [Sportsbook Group]
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<BettingEvent> GetBettingFuturesBySeasonSportsbookGroup(string season, string sportsbookgroup)
        {
            return this.GetBettingFuturesBySeasonSportsbookGroupAsync(season, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Market [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>421</code>, <code>1041</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<BettingMarket> GetBettingMarketSportsbookGroupAsync(string marketId, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/nhl/odds/{format}/BettingMarket/{marketId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market [Sportsbook Group]
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>421</code>, <code>1041</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public BettingMarket GetBettingMarketSportsbookGroup(string marketId, string sportsbookgroup)
        {
            return this.GetBettingMarketSportsbookGroupAsync(marketId, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Event [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventSportsbookGroupAsync(string eventId, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByEvent/{eventId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Event [Sportsbook Group]
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByEventSportsbookGroup(string eventId, string sportsbookgroup, string include)
        {
            return this.GetBettingMarketsByEventSportsbookGroupAsync(eventId, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Game [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameSportsbookGroupAsync(int gameID, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameID", gameID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByGameID/{gameID}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Game [Sportsbook Group]
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByGameSportsbookGroup(int gameID, string sportsbookgroup, string include)
        {
            return this.GetBettingMarketsByGameSportsbookGroupAsync(gameID, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeSportsbookGroupAsync(string eventId, string marketTypeID, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Market Type [Sportsbook Group]
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketTypeSportsbookGroup(string eventId, string marketTypeID, string sportsbookgroup, string include)
        {
            return this.GetBettingMarketsByMarketTypeSportsbookGroupAsync(eventId, marketTypeID, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Player Props - by Game [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameSportsbookGroupAsync(int gameId, string sportsbookgroup, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingPlayerPropsByGameID/{gameId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props - by Game [Sportsbook Group]
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of <code>available</code> is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingPlayerPropsByGameSportsbookGroup(int gameId, string sportsbookgroup, string include)
        {
            return this.GetBettingPlayerPropsByGameSportsbookGroupAsync(gameId, sportsbookgroup, include).Result;
        }

        /// <summary>
        /// Get Betting Results - by Market [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<BettingMarketResult> GetBettingResultsByMarketSportsbookGroupAsync(string marketId, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<BettingMarketResult>(() =>
                base.Get<BettingMarketResult>("/v3/nhl/odds/{format}/BettingResultsByMarket/{marketId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Results - by Market [Sportsbook Group]
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public BettingMarketResult GetBettingResultsByMarketSportsbookGroup(string marketId, string sportsbookgroup)
        {
            return this.GetBettingResultsByMarketSportsbookGroupAsync(marketId, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get In-Game Odds - by Date [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<GameInfo>> GetInGameOddsByDateSportsbookGroupAsync(string date, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/InGameOddsByDate/{date}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds - by Date [Sportsbook Group]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<GameInfo> GetInGameOddsByDateSportsbookGroup(string date, string sportsbookgroup)
        {
            return this.GetInGameOddsByDateSportsbookGroupAsync(date, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<GameInfo>> GetInGameOddsLineMovementSportsbookGroupAsync(int gameid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/InGameLineMovement/{gameid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement [Sportsbook Group]
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<GameInfo> GetInGameOddsLineMovementSportsbookGroup(int gameid, string sportsbookgroup)
        {
            return this.GetInGameOddsLineMovementSportsbookGroupAsync(gameid, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Pre-Game and Period Game Odds - by Date [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<GameInfo>> GetPreGameAndPeriodGameOddsByDateSportsbookGroupAsync(string date, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/PreGameOddsByDate/{date}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game and Period Game Odds - by Date [Sportsbook Group]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<GameInfo> GetPreGameAndPeriodGameOddsByDateSportsbookGroup(string date, string sportsbookgroup)
        {
            return this.GetPreGameAndPeriodGameOddsByDateSportsbookGroupAsync(date, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Pre-Game and Period Game Odds Line Movement [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<GameInfo>> GetPreGameAndPeriodGameOddsLineMovementSportsbookGroupAsync(int gameid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nhl/odds/{format}/PreGameOddsLineMovement/{gameid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game and Period Game Odds Line Movement [Sportsbook Group]
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<GameInfo> GetPreGameAndPeriodGameOddsLineMovementSportsbookGroup(int gameid, string sportsbookgroup)
        {
            return this.GetPreGameAndPeriodGameOddsLineMovementSportsbookGroupAsync(gameid, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement with Resulting [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<GameInfoResult>> GetInGameOddsLineMovementWithResultingSportsbookGroupAsync(int gameid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<GameInfoResult>>(() =>
                base.Get<List<GameInfoResult>>("/v3/nhl/odds/{format}/InGameLineMovementWithResulting/{gameid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement with Resulting [Sportsbook Group]
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<GameInfoResult> GetInGameOddsLineMovementWithResultingSportsbookGroup(int gameid, string sportsbookgroup)
        {
            return this.GetInGameOddsLineMovementWithResultingSportsbookGroupAsync(gameid, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Pre-Game and Period Game Odds Line Movement with Resulting [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<GameInfoResult>> GetPreGameAndPeriodGameOddsLineMovementWithResultingSportsbookGroupAsync(int gameid, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<GameInfoResult>>(() =>
                base.Get<List<GameInfoResult>>("/v3/nhl/odds/{format}/PreGameOddsLineMovementWithResulting/{gameid}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game and Period Game Odds Line Movement with Resulting [Sportsbook Group]
        /// </summary>
        /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<GameInfoResult> GetPreGameAndPeriodGameOddsLineMovementWithResultingSportsbookGroup(int gameid, string sportsbookgroup)
        {
            return this.GetPreGameAndPeriodGameOddsLineMovementWithResultingSportsbookGroupAsync(gameid, sportsbookgroup).Result;
        }

    }
}

