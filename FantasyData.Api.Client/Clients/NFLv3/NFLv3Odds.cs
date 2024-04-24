using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3OddsClient : BaseClient
    {
        public NFLv3OddsClient(string apiKey) : base(apiKey) { }
        public NFLv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get In-Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetInGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/LiveGameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetInGameOddsByWeek(string season, int week)
        {
            return this.GetInGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get In-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public Task<List<GameInfo>> GetInGameOddsLineMovementAsync(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/LiveGameOddsLineMovement/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public List<GameInfo> GetInGameOddsLineMovement(int scoreid)
        {
            return this.GetInGameOddsLineMovementAsync(scoreid).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetPreGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/GameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetPreGameOddsByWeek(string season, int week)
        {
            return this.GetPreGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public Task<List<GameInfo>> GetPreGameOddsLineMovementAsync(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/GameOddsLineMovement/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public List<GameInfo> GetPreGameOddsLineMovement(int scoreid)
        {
            return this.GetPreGameOddsLineMovementAsync(scoreid).Result;
        }

        /// <summary>
        /// Get Generated Player Props by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example: <code>17920</code>, <code>16771</code>, etc.</param>
        public Task<List<PlayerProp>> GetGeneratedPlayerPropsByPlayerAsync(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nfl/odds/{format}/PlayerPropsByPlayerID/{season}/{week}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example: <code>17920</code>, <code>16771</code>, etc.</param>
        public List<PlayerProp> GetGeneratedPlayerPropsByPlayer(string season, int week, int playerid)
        {
            return this.GetGeneratedPlayerPropsByPlayerAsync(season, week, playerid).Result;
        }

        /// <summary>
        /// Get Generated Player Props by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
        /// <param name="team">Abbreviation of the team. Example: <code>PHI</code>, <code>NE</code>, etc.</param>
        public Task<List<PlayerProp>> GetGeneratedPlayerPropsByTeamAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nfl/odds/{format}/PlayerPropsByTeam/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
        /// <param name="team">Abbreviation of the team. Example: <code>PHI</code>, <code>NE</code>, etc.</param>
        public List<PlayerProp> GetGeneratedPlayerPropsByTeam(string season, int week, string team)
        {
            return this.GetGeneratedPlayerPropsByTeamAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get Generated Player Props by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
        public Task<List<PlayerProp>> GetGeneratedPlayerPropsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/nfl/odds/{format}/PlayerPropsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Generated Player Props by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
        public List<PlayerProp> GetGeneratedPlayerPropsByWeek(string season, int week)
        {
            return this.GetGeneratedPlayerPropsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Period Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetPeriodGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/AlternateMarketGameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Period Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetPeriodGameOddsByWeek(string season, int week)
        {
            return this.GetPeriodGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Period Game Odds Line Movement  Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public Task<List<GameInfo>> GetPeriodGameOddsLineMovementAsync(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/AlternateMarketGameOddsLineMovement/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Period Game Odds Line Movement 
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public List<GameInfo> GetPeriodGameOddsLineMovement(int scoreid)
        {
            return this.GetPeriodGameOddsLineMovementAsync(scoreid).Result;
        }

        /// <summary>
        /// Get Betting Trends by Matchup Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of a team. Example: <code>PHI</code>.</param>
        /// <param name="opponent">Abbreviation of an opponent. Example: <code>NE</code>.</param>
        public Task<MatchupTrends> GetBettingTrendsByMatchupAsync(string team, string opponent)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            parameters.Add(new KeyValuePair<string, string>("opponent", opponent.ToString()));
            return Task.Run<MatchupTrends>(() =>
                base.Get<MatchupTrends>("/v3/nfl/odds/{format}/MatchupTrends/{team}/{opponent}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends by Matchup
        /// </summary>
        /// <param name="team">Abbreviation of a team. Example: <code>PHI</code>.</param>
        /// <param name="opponent">Abbreviation of an opponent. Example: <code>NE</code>.</param>
        public MatchupTrends GetBettingTrendsByMatchup(string team, string opponent)
        {
            return this.GetBettingTrendsByMatchupAsync(team, opponent).Result;
        }

        /// <summary>
        /// Get Betting Trends by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of a team. Example: <code>PHI</code>.</param>
        public Task<TeamTrends> GetBettingTrendsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<TeamTrends>(() =>
                base.Get<TeamTrends>("/v3/nfl/odds/{format}/TeamTrends/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends by Team
        /// </summary>
        /// <param name="team">Abbreviation of a team. Example: <code>PHI</code>.</param>
        public TeamTrends GetBettingTrendsByTeam(string team)
        {
            return this.GetBettingTrendsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Betting Events by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-09-10</code>, <code>2020-09-13</code>.</param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingEventsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-09-10</code>, <code>2020-09-13</code>.</param>
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
                base.Get<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingEvents/{season}", parameters)
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
        /// Get Betting Futures by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2020REG</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2021</code>, etc.</param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingFuturesBySeason/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures by Season
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2020REG</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2021</code>, etc.</param>
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
                base.Get<BettingMarket>("/v3/nfl/odds/{format}/BettingMarket/{marketId}", parameters)
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
                base.Get<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingMarkets/{eventId}", parameters)
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
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID, string include)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID, include).Result;
        }

        /// <summary>
        /// Get Betting Markets by GameID (formerly Betting Markets by ScoreID) Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of the desired game/score for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameIDFormerlyBettingMarketsByScoreIDAsync(int scoreid, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingMarketsByScoreID/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets by GameID (formerly Betting Markets by ScoreID)
        /// </summary>
        /// <param name="scoreid">The ScoreID of the desired game/score for which to pull all betting markets (includes outcomes/bets).</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingMarketsByGameIDFormerlyBettingMarketsByScoreID(int scoreid, string include)
        {
            return this.GetBettingMarketsByGameIDFormerlyBettingMarketsByScoreIDAsync(scoreid, include).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<List<BettingEntityMetadata>> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BettingEntityMetadata>>(() =>
                base.Get<List<BettingEntityMetadata>>("/v3/nfl/odds/{format}/BettingMetadata", parameters)
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
        public Task<List<Sportsbook>> GetSportsbooksActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/nfl/odds/{format}/ActiveSportsbooks", parameters)
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
        /// Get Betting Splits By BettingMarketId Asynchronous
        /// </summary>
        /// <param name="marketId">The BettingMarketID of the market you would like to get splits for. Note that markets we do not have split information on will return an empty response.</param>
        public Task<BettingMarketSplit> GetBettingSplitsByBettingMarketIdAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketSplit>(() =>
                base.Get<BettingMarketSplit>("/v3/nfl/odds/{format}/BettingSplitsByMarketId/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits By BettingMarketId
        /// </summary>
        /// <param name="marketId">The BettingMarketID of the market you would like to get splits for. Note that markets we do not have split information on will return an empty response.</param>
        public BettingMarketSplit GetBettingSplitsByBettingMarketId(string marketId)
        {
            return this.GetBettingSplitsByBettingMarketIdAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Splits By GameID (formerly Betting Splits By ScoreID) Asynchronous
        /// </summary>
        /// <param name="scoreId">The ScoreID of the desired game to get Betting Market Splits for</param>
        public Task<GameBettingSplit> GetBettingSplitsByGameIDFormerlyBettingSplitsByScoreIDAsync(int scoreId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreId", scoreId.ToString()));
            return Task.Run<GameBettingSplit>(() =>
                base.Get<GameBettingSplit>("/v3/nfl/odds/{format}/BettingSplitsByScoreId/{scoreId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Splits By GameID (formerly Betting Splits By ScoreID)
        /// </summary>
        /// <param name="scoreId">The ScoreID of the desired game to get Betting Market Splits for</param>
        public GameBettingSplit GetBettingSplitsByGameIDFormerlyBettingSplitsByScoreID(int scoreId)
        {
            return this.GetBettingSplitsByGameIDFormerlyBettingSplitsByScoreIDAsync(scoreId).Result;
        }

        /// <summary>
        /// Get Betting Results By Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public Task<BettingMarketResult> GetBettingResultsByMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarketResult>(() =>
                base.Get<BettingMarketResult>("/v3/nfl/odds/{format}/BettingMarketResults/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Results By Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
        public BettingMarketResult GetBettingResultsByMarket(string marketId)
        {
            return this.GetBettingResultsByMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Player Props by GameID (formerly Betting Player Props by ScoreID) Asynchronous
        /// </summary>
        /// <param name="scoreid">The unique ScoreID of the game in question.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameIDFormerlyBettingPlayerPropsByScoreIDAsync(int scoreid, string include)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("include", include.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingPlayerPropsByScoreID/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props by GameID (formerly Betting Player Props by ScoreID)
        /// </summary>
        /// <param name="scoreid">The unique ScoreID of the game in question.</param>
        /// <param name="include">This parameter indicates which <code>BettingOutcome</code> records to return in the payload. By default, this endpoint only returns available outcomes, excluding the unlisted bets. <b>Important Note:</b> the default parameter of available is much faster and provides the best performance. Passing unlisted will return unlisted odds, but these are cached for much longer and may be several minutes old. For best performance, the default parameter is highly recommended. Possible values include: <code>available</code> - excludes any betting outcomes that have been removed/unlisted by the respective sportsbook. This is more lightweight and delivers odds much faster than using unlisted. <code>unlisted</code> - includes the most recently available betting outcome per sportsbook, for each listed market, even those outcomes are expired/unlisted or otherwise unavailable from the respective sportsbook. This is a far heavier payload, and it's cached for much longer than available.</param>
        public List<BettingMarket> GetBettingPlayerPropsByGameIDFormerlyBettingPlayerPropsByScoreID(int scoreid, string include)
        {
            return this.GetBettingPlayerPropsByGameIDFormerlyBettingPlayerPropsByScoreIDAsync(scoreid, include).Result;
        }

    }
}

