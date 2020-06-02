using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3AdvancedMetricsClient : BaseClient
    {
        public NFLv3AdvancedMetricsClient(string apiKey) : base(apiKey) { }
        public NFLv3AdvancedMetricsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Advanced Player Game Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<AdvancedPlayerGame>> GetAdvancedPlayerGameStatsAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<AdvancedPlayerGame>>(() =>
                base.Get<List<AdvancedPlayerGame>>("/v3/nfl/advanced-metrics/{format}/AdvancedPlayerGameStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Advanced Player Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<AdvancedPlayerGame> GetAdvancedPlayerGameStats(string season, int week)
        {
            return this.GetAdvancedPlayerGameStatsAsync(season, week).Result;
        }

        /// <summary>
        /// Get Advanced Player Game Stats by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<List<AdvancedPlayerGame>> GetAdvancedPlayerGameStatsByPlayerIDAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<AdvancedPlayerGame>>(() =>
                base.Get<List<AdvancedPlayerGame>>("/v3/nfl/advanced-metrics/{format}/AdvancedPlayerGameStatsByPlayerID/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Advanced Player Game Stats by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public List<AdvancedPlayerGame> GetAdvancedPlayerGameStatsByPlayerID(string season, int playerid)
        {
            return this.GetAdvancedPlayerGameStatsByPlayerIDAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Advanced Player Info Asynchronous
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<List<AdvancedPlayer>> GetAdvancedPlayerInfoAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<AdvancedPlayer>>(() =>
                base.Get<List<AdvancedPlayer>>("/v3/nfl/advanced-metrics/{format}/AdvancedPlayerInfo/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Advanced Player Info
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public List<AdvancedPlayer> GetAdvancedPlayerInfo(int playerid)
        {
            return this.GetAdvancedPlayerInfoAsync(playerid).Result;
        }

        /// <summary>
        /// Get Advanced Player Season Stats by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<List<AdvancedPlayerSeason>> GetAdvancedPlayerSeasonStatsByPlayerIDAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<AdvancedPlayerSeason>>(() =>
                base.Get<List<AdvancedPlayerSeason>>("/v3/nfl/advanced-metrics/{format}/AdvancedPlayerSeasonStatsByPlayerID/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Advanced Player Season Stats by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public List<AdvancedPlayerSeason> GetAdvancedPlayerSeasonStatsByPlayerID(string season, int playerid)
        {
            return this.GetAdvancedPlayerSeasonStatsByPlayerIDAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Advanced Player Season Stats by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<AdvancedPlayerSeason>> GetAdvancedPlayerSeasonStatsAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<AdvancedPlayerSeason>>(() =>
                base.Get<List<AdvancedPlayerSeason>>("/v3/nfl/advanced-metrics/{format}/AdvancedPlayerSeasonStats/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Advanced Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<AdvancedPlayerSeason> GetAdvancedPlayerSeasonStats(string season, string team)
        {
            return this.GetAdvancedPlayerSeasonStatsAsync(season, team).Result;
        }

        /// <summary>
        /// Get Advanced Players Asynchronous
        /// </summary>
        public Task<List<PlayerInfo>> GetAdvancedPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerInfo>>(() =>
                base.Get<List<PlayerInfo>>("/v3/nfl/advanced-metrics/{format}/AdvancedPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Advanced Players
        /// </summary>
        public List<PlayerInfo> GetAdvancedPlayers()
        {
            return this.GetAdvancedPlayersAsync().Result;
        }

    }
}

