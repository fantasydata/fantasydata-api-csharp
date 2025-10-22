using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.WNBA;

namespace FantasyData.Api.Client
{
    public partial class WNBAv3ScoresClient : BaseClient
    {
        public WNBAv3ScoresClient(string apiKey) : base(apiKey) { }
        public WNBAv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/wnba/scores/{format}/AreAnyGamesInProgress", parameters)
            );
        }

        /// <summary>
        /// Get Are Games In Progress
        /// </summary>
        public bool GetAreGamesInProgress()
        {
            return this.GetAreGamesInProgressAsync().Result;
        }

        /// <summary>
        /// Get Season - Current Asynchronous
        /// </summary>
        public Task<Season> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/wnba/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season - Current
        /// </summary>
        public Season GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public Task<List<Game>> GetGamesByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/wnba/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public List<Game> GetGamesByDateLiveFinal(string date)
        {
            return this.GetGamesByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
        public Task<List<Game>> GetSchedulesAsync(string Season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("Season", Season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/wnba/scores/{format}/Games/{Season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
        public List<Game> GetSchedules(string Season)
        {
            return this.GetSchedulesAsync(Season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/wnba/scores/{format}/Stadiums", parameters)
            );
        }

        /// <summary>
        /// Get Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            return this.GetStadiumsAsync().Result;
        }

        /// <summary>
        /// Get Team Profiles - All Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/wnba/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - All
        /// </summary>
        public List<Team> GetTeamProfilesAll()
        {
            return this.GetTeamProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Pre-Game Odds - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public Task<List<GameInfo>> GetPreGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/wnba/scores/{format}/GameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public List<GameInfo> GetPreGameOddsByDate(string date)
        {
            return this.GetPreGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The unique GameID of the game for which to pull data.</param>
        public Task<List<GameInfo>> GetPreGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/wnba/scores/{format}/GameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The unique GameID of the game for which to pull data.</param>
        public List<GameInfo> GetPreGameOddsLineMovement(int gameid)
        {
            return this.GetPreGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Sportsbooks - by Active Asynchronous
        /// </summary>
        public Task<List<Sportsbook>> GetSportsbooksByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Sportsbook>>(() =>
                base.Get<List<Sportsbook>>("/v3/wnba/scores/{format}/ActiveSportsbooks", parameters)
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
        /// Get Games - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public Task<List<Game>> GetGamesByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/wnba/scores/{format}/GamesByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
        public List<Game> GetGamesByDateFinal(string date)
        {
            return this.GetGamesByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Schedules (Basic) Asynchronous
        /// </summary>
        /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
        public Task<List<SchedulesBasic>> GetSchedulesBasicAsync(string Season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("Season", Season.ToString()));
            return Task.Run<List<SchedulesBasic>>(() =>
                base.Get<List<SchedulesBasic>>("/v3/wnba/scores/{format}/SchedulesBasic/{Season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules (Basic)
        /// </summary>
        /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
        public List<SchedulesBasic> GetSchedulesBasic(string Season)
        {
            return this.GetSchedulesBasicAsync(Season).Result;
        }

        /// <summary>
        /// Get Box Score [Final] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an WNBA game. GameIDs can be found in the Games API. Valid entries are <code>1686</code>, <code>1899</code>, etc.</param>
        public Task<BoxScore> GetBoxScoreFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/wnba/scores/{format}/BoxScoreFinal/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Final]
        /// </summary>
        /// <param name="gameid">The GameID of an WNBA game. GameIDs can be found in the Games API. Valid entries are <code>1686</code>, <code>1899</code>, etc.</param>
        public BoxScore GetBoxScoreFinal(int gameid)
        {
            return this.GetBoxScoreFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Score [Live & Final] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an WNBA game. GameIDs can be found in the Games API. Valid entries are <code>1686</code>, <code>1899</code>, etc.</param>
        public Task<BoxScore> GetBoxScoreLiveFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/wnba/scores/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Live & Final]
        /// </summary>
        /// <param name="gameid">The GameID of an WNBA game. GameIDs can be found in the Games API. Valid entries are <code>1686</code>, <code>1899</code>, etc.</param>
        public BoxScore GetBoxScoreLiveFinal(int gameid)
        {
            return this.GetBoxScoreLiveFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2024-MAY-16</code>, <code>2023-OCT-20</code>, etc.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/wnba/scores/{format}/BoxScoresFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2024-MAY-16</code>, <code>2023-OCT-20</code>, etc.</param>
        public List<BoxScore> GetBoxScoresByDateFinal(string date)
        {
            return this.GetBoxScoresByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2024-MAY-16</code>, <code>2024-OCT-20</code>, etc.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/wnba/scores/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2024-MAY-16</code>, <code>2024-OCT-20</code>, etc.</param>
        public List<BoxScore> GetBoxScoresByDateLiveFinal(string date)
        {
            return this.GetBoxScoresByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date"></param>
        public Task<List<ScoreBasic>> GetGamesBasicByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/wnba/scores/{format}/ScoresBasicFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Final]
        /// </summary>
        /// <param name="date"></param>
        public List<ScoreBasic> GetGamesBasicByDateFinal(string date)
        {
            return this.GetGamesBasicByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date"></param>
        public Task<List<ScoreBasic>> GetGamesBasicByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/wnba/scores/{format}/ScoresBasic/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Live & Final]
        /// </summary>
        /// <param name="date"></param>
        public List<ScoreBasic> GetGamesBasicByDateLiveFinal(string date)
        {
            return this.GetGamesBasicByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Details - by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/wnba/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Active
        /// </summary>
        public List<Player> GetPlayerDetailsByActive()
        {
            return this.GetPlayerDetailsByActiveAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>LA</code>, <code>IND</code>.</param>
        public Task<List<Player>> GetPlayerDetailsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/wnba/scores/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>LA</code>, <code>IND</code>.</param>
        public List<Player> GetPlayerDetailsByTeam(string team)
        {
            return this.GetPlayerDetailsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season"></param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/wnba/scores/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season"></param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season"></param>
        /// <param name="team"></param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/wnba/scores/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Team
        /// </summary>
        /// <param name="season"></param>
        /// <param name="team"></param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date"></param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/wnba/scores/{format}/TeamGameStatsByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final]
        /// </summary>
        /// <param name="date"></param>
        public List<TeamGame> GetTeamGameStatsByDateFinal(string date)
        {
            return this.GetTeamGameStatsByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date"></param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/wnba/scores/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="date"></param>
        public List<TeamGame> GetTeamGameStatsByDateLiveFinal(string date)
        {
            return this.GetTeamGameStatsByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="season"></param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/wnba/scores/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="season"></param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            return this.GetTeamSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Events - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2025-05-30</code>, <code>2025-MAY-28</code>.</param>
        public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/wnba/scores/{format}/BettingEventsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2025-05-30</code>, <code>2025-MAY-28</code>.</param>
        public List<BettingEvent> GetBettingEventsByDate(string date)
        {
            return this.GetBettingEventsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Betting Events - by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Just the api year, no season codes. Examples: <code>2025</code>, etc</param>
        public Task<List<BettingEvent>> GetBettingEventsBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/wnba/scores/{format}/BettingEvents/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Events - by Season
        /// </summary>
        /// <param name="season">Year of the season. Just the api year, no season codes. Examples: <code>2025</code>, etc</param>
        public List<BettingEvent> GetBettingEventsBySeason(string season)
        {
            return this.GetBettingEventsBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Futures - by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Just the api year, no season codes. Examples: <code>2025</code>, etc</param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/wnba/scores/{format}/BettingFuturesBySeason/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures - by Season
        /// </summary>
        /// <param name="season">Year of the season. Just the api year, no season codes. Examples: <code>2025</code>, etc</param>
        public List<BettingEvent> GetBettingFuturesBySeason(string season)
        {
            return this.GetBettingFuturesBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Betting Futures - by Season [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Just the api year, no season codes. Examples: <code>2025</code>, etc</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<BettingEvent>> GetBettingFuturesBySeasonSportsbookGroupAsync(string season, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<BettingEvent>>(() =>
                base.Get<List<BettingEvent>>("/v3/wnba/scores/{format}/BettingFuturesBySeason/{season}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Futures - by Season [Sportsbook Group]
        /// </summary>
        /// <param name="season">Year of the season. Just the api year, no season codes. Examples: <code>2025</code>, etc</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<BettingEvent> GetBettingFuturesBySeasonSportsbookGroup(string season, string sportsbookgroup)
        {
            return this.GetBettingFuturesBySeasonSportsbookGroupAsync(season, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Market Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>36</code>, <code>342</code>, etc.</param>
        public Task<BettingMarket> GetBettingMarketAsync(string marketId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/wnba/scores/{format}/BettingMarket/{marketId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>36</code>, <code>342</code>, etc.</param>
        public BettingMarket GetBettingMarket(string marketId)
        {
            return this.GetBettingMarketAsync(marketId).Result;
        }

        /// <summary>
        /// Get Betting Market [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>36</code>, <code>342</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code>, <code>G1001</code></param>
        public Task<BettingMarket> GetBettingMarketSportsbookGroupAsync(string marketId, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("marketId", marketId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<BettingMarket>(() =>
                base.Get<BettingMarket>("/v3/wnba/scores/{format}/BettingMarket/{marketId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Market [Sportsbook Group]
        /// </summary>
        /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>36</code>, <code>342</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code>, <code>G1001</code></param>
        public BettingMarket GetBettingMarketSportsbookGroup(string marketId, string sportsbookgroup)
        {
            return this.GetBettingMarketSportsbookGroupAsync(marketId, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Event Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventAsync(string eventId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingMarkets/{eventId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Event
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        public List<BettingMarket> GetBettingMarketsByEvent(string eventId)
        {
            return this.GetBettingMarketsByEventAsync(eventId).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Event [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<BettingMarket>> GetBettingMarketsByEventSportsbookGroupAsync(string eventId, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingMarketsByEvent/{eventId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Event [Sportsbook Group]
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<BettingMarket> GetBettingMarketsByEventSportsbookGroup(string eventId, string sportsbookgroup)
        {
            return this.GetBettingMarketsByEventSportsbookGroupAsync(eventId, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Game Asynchronous
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>1934</code></param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameAsync(int gameID)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameID", gameID.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingMarketsByGameID/{gameID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Game
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>1934</code></param>
        public List<BettingMarket> GetBettingMarketsByGame(int gameID)
        {
            return this.GetBettingMarketsByGameAsync(gameID).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Game [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>1934</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<BettingMarket>> GetBettingMarketsByGameSportsbookGroupAsync(int gameID, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameID", gameID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingMarketsByGameID/{gameID}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Game [Sportsbook Group]
        /// </summary>
        /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>1934</code></param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<BettingMarket> GetBettingMarketsByGameSportsbookGroup(int gameID, string sportsbookgroup)
        {
            return this.GetBettingMarketsByGameSportsbookGroupAsync(gameID, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Market Type
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        public List<BettingMarket> GetBettingMarketsByMarketType(string eventId, string marketTypeID)
        {
            return this.GetBettingMarketsByMarketTypeAsync(eventId, marketTypeID).Result;
        }

        /// <summary>
        /// Get Betting Markets - by Market Type [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeSportsbookGroupAsync(string eventId, string marketTypeID, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("eventId", eventId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("marketTypeID", marketTypeID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Markets - by Market Type [Sportsbook Group]
        /// </summary>
        /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>12</code>, <code>8</code>, etc.</param>
        /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<BettingMarket> GetBettingMarketsByMarketTypeSportsbookGroup(string eventId, string marketTypeID, string sportsbookgroup)
        {
            return this.GetBettingMarketsByMarketTypeSportsbookGroupAsync(eventId, marketTypeID, sportsbookgroup).Result;
        }

        /// <summary>
        /// Get Betting Metadata Asynchronous
        /// </summary>
        public Task<BettingEntityMetadataCollection> GetBettingMetadataAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<BettingEntityMetadataCollection>(() =>
                base.Get<BettingEntityMetadataCollection>("/v3/wnba/scores/{format}/BettingMetadata", parameters)
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
        /// Get Betting Player Props - by Game Asynchronous
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameAsync(int gameId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingPlayerPropsByGameID/{gameId}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props - by Game
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        public List<BettingMarket> GetBettingPlayerPropsByGame(int gameId)
        {
            return this.GetBettingPlayerPropsByGameAsync(gameId).Result;
        }

        /// <summary>
        /// Get Betting Player Props - by Game [Sportsbook Group] Asynchronous
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public Task<List<BettingMarket>> GetBettingPlayerPropsByGameSportsbookGroupAsync(int gameId, string sportsbookgroup)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameId", gameId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("sportsbookgroup", sportsbookgroup.ToString()));
            return Task.Run<List<BettingMarket>>(() =>
                base.Get<List<BettingMarket>>("/v3/wnba/scores/{format}/BettingPlayerPropsByGameID/{gameId}/{sportsbookgroup}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Player Props - by Game [Sportsbook Group]
        /// </summary>
        /// <param name="gameId">The unique GameID of the game in question.</param>
        /// <param name="sportsbookgroup">The name of the Sportsbook grouping. Examples: <code>G1100</code></param>
        public List<BettingMarket> GetBettingPlayerPropsByGameSportsbookGroup(int gameId, string sportsbookgroup)
        {
            return this.GetBettingPlayerPropsByGameSportsbookGroupAsync(gameId, sportsbookgroup).Result;
        }

    }
}

