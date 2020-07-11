using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.NetCore.Model.CFB;

namespace FantasyData.Api.Client.NetCore
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
        /// Get Player Props by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example: <code>50002016</code></param>
        public Task<List<PlayerProp>> GetPlayerPropsByPlayerIDAsync(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/cfb/odds/{format}/PlayerPropsByPlayerID/{season}/{week}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Props by Player
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example: <code>50002016</code></param>
        public List<PlayerProp> GetPlayerPropsByPlayerID(string season, int week, int playerid)
        {
            return this.GetPlayerPropsByPlayerIDAsync(season, week, playerid).Result;
        }

        /// <summary>
        /// Get Player Props by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        public Task<List<PlayerProp>> GetPlayerPropsByTeamAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/cfb/odds/{format}/PlayerPropsByTeam/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Props by Team
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>ND</code>, <code>PITT</code>, etc.</param>
        public List<PlayerProp> GetPlayerPropsByTeam(string season, int week, string team)
        {
            return this.GetPlayerPropsByTeamAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get Player Props by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<PlayerProp>> GetPlayerPropsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerProp>>(() =>
                base.Get<List<PlayerProp>>("/v3/cfb/odds/{format}/PlayerPropsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Props by Week
        /// </summary>
        /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, etc.</param>
        public List<PlayerProp> GetPlayerPropsByWeek(string season, int week)
        {
            return this.GetPlayerPropsByWeekAsync(season, week).Result;
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

    }
}

