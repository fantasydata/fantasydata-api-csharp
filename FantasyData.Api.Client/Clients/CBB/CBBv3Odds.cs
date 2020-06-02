using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client
{
    public partial class CBBv3OddsClient : BaseClient
    {
        public CBBv3OddsClient(string apiKey) : base(apiKey) { }
        public CBBv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get In-Game Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public Task<List<GameInfo>> GetLiveGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cbb/odds/{format}/LiveGameOddsByDate/{date}", parameters)
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
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
        public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cbb/odds/{format}/LiveGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get In-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
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
                base.Get<List<GameInfo>>("/v3/cbb/odds/{format}/GameOddsByDate/{date}", parameters)
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
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
        public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cbb/odds/{format}/GameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
        public List<GameInfo> GetGameOddsLineMovement(int gameid)
        {
            return this.GetGameOddsLineMovementAsync(gameid).Result;
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
                base.Get<List<GameInfo>>("/v3/cbb/odds/{format}/AlternateMarketGameOddsByDate/{date}", parameters)
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
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
        public Task<List<GameInfo>> GetAlternateMarketGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/cbb/odds/{format}/AlternateMarketGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Alternate Market Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
        public List<GameInfo> GetAlternateMarketGameOddsLineMovement(int gameid)
        {
            return this.GetAlternateMarketGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Betting Trends By Matchup Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>OU</code>, <code>UK</code>.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>OU</code>, <code>UK</code>.</param>
        public Task<MatchupTrends> GetMatchupTrendsAsync(string team, string opponent)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            parameters.Add(new KeyValuePair<string, string>("opponent", opponent.ToString()));
            return Task.Run<MatchupTrends>(() =>
                base.Get<MatchupTrends>("/v3/cbb/odds/{format}/MatchupTrends/{team}/{opponent}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends By Matchup
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>OU</code>, <code>UK</code>.</param>
        /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>OU</code>, <code>UK</code>.</param>
        public MatchupTrends GetMatchupTrends(string team, string opponent)
        {
            return this.GetMatchupTrendsAsync(team, opponent).Result;
        }

        /// <summary>
        /// Get Betting Trends By Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>OU</code>, <code>UK</code>.</param>
        public Task<TeamTrends> GetTeamTrendsAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<TeamTrends>(() =>
                base.Get<TeamTrends>("/v3/cbb/odds/{format}/TeamTrends/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Betting Trends By Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>OU</code>, <code>UK</code>.</param>
        public TeamTrends GetTeamTrends(string team)
        {
            return this.GetTeamTrendsAsync(team).Result;
        }

    }
}

