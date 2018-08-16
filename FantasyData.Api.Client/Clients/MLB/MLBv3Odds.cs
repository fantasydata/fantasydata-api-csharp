using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3OddsClient : BaseClient
    {
        public MLBv3OddsClient(string apiKey) : base(apiKey) { }
        public MLBv3OddsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Pre-Game Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-06-20</code>, <code>2018-06-23</code>.</param>
        public Task<List<GameInfo>> GetGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/mlb/odds/{format}/GameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-06-20</code>, <code>2018-06-23</code>.</param>
        public List<GameInfo> GetGameOddsByDate(string date)
        {
            return this.GetGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>51735</code> or <code>51745</code></param>
        public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/mlb/odds/{format}/GameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>51735</code> or <code>51745</code></param>
        public List<GameInfo> GetGameOddsLineMovement(int gameid)
        {
            return this.GetGameOddsLineMovementAsync(gameid).Result;
        }

        /// <summary>
        /// Get Live Game Odds by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-06-20</code>, <code>2018-06-23</code>.</param>
        public Task<List<GameInfo>> GetLiveGameOddsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/mlb/odds/{format}/LiveGameOddsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Live Game Odds by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-06-20</code>, <code>2018-06-23</code>.</param>
        public List<GameInfo> GetLiveGameOddsByDate(string date)
        {
            return this.GetLiveGameOddsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Live Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>51735</code> or <code>51745</code></param>
        public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/mlb/odds/{format}/LiveGameOddsLineMovement/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Live Game Odds Line Movement
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>51735</code> or <code>51745</code></param>
        public List<GameInfo> GetLiveGameOddsLineMovement(int gameid)
        {
            return this.GetLiveGameOddsLineMovementAsync(gameid).Result;
        }

    }
}

