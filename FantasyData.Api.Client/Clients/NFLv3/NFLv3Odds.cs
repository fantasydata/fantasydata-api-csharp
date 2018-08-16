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
        /// Get Live Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetLiveGameOddsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/LiveGameOddsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Live Game Odds by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<GameInfo> GetLiveGameOddsByWeek(string season, int week)
        {
            return this.GetLiveGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Live Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return Task.Run<List<GameInfo>>(() =>
                base.Get<List<GameInfo>>("/v3/nfl/odds/{format}/LiveGameOddsLineMovement/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Live Game Odds Line Movement
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public List<GameInfo> GetLiveGameOddsLineMovement(int scoreid)
        {
            return this.GetLiveGameOddsLineMovementAsync(scoreid).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<GameInfo>> GetGameOddsByWeekAsync(string season, int week)
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
        public List<GameInfo> GetGameOddsByWeek(string season, int week)
        {
            return this.GetGameOddsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Pre-Game Odds Line Movement Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
        public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int scoreid)
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
        public List<GameInfo> GetGameOddsLineMovement(int scoreid)
        {
            return this.GetGameOddsLineMovementAsync(scoreid).Result;
        }

    }
}

