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
        /// Get Player Props by Date Asynchronous
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
        /// Get Player Props by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        public List<PlayerProp> GetPlayerPropsByDate(string date)
        {
            return this.GetPlayerPropsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Player Props by Player Asynchronous
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
        /// Get Player Props by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code></param>
        public List<PlayerProp> GetPlayerPropsByPlayerID(string date, int playerid)
        {
            return this.GetPlayerPropsByPlayerIDAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Player Props by Team Asynchronous
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
        /// Get Player Props by Team
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

    }
}

