using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3ProjectionsClient : BaseClient
    {
        public NFLv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public NFLv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get DFS Slates - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/nfl/projections/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
        public List<DfsSlate> GetDFSSlatesByDate(string date)
        {
            return this.GetDFSSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get DFS Slates - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<DfsSlate>> GetDFSSlatesByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/nfl/projections/{format}/DfsSlatesByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code></param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<DfsSlate> GetDFSSlatesByWeek(string season, int week)
        {
            return this.GetDFSSlatesByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Projected Fantasy Defense Game Stats With DFS Salaries Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<FantasyDefenseGameProjection>> GetProjectedFantasyDefenseGameStatsWithDFSSalariesAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<FantasyDefenseGameProjection>>(() =>
                base.Get<List<FantasyDefenseGameProjection>>("/v3/nfl/projections/{format}/FantasyDefenseProjectionsByGame/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Fantasy Defense Game Stats With DFS Salaries
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<FantasyDefenseGameProjection> GetProjectedFantasyDefenseGameStatsWithDFSSalaries(string season, int week)
        {
            return this.GetProjectedFantasyDefenseGameStatsWithDFSSalariesAsync(season, week).Result;
        }

        /// <summary>
        /// Get Projected Fantasy Defense Season Stats With ADP Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<FantasyDefenseSeasonProjection>> GetProjectedFantasyDefenseSeasonStatsWithADPAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<FantasyDefenseSeasonProjection>>(() =>
                base.Get<List<FantasyDefenseSeasonProjection>>("/v3/nfl/projections/{format}/FantasyDefenseProjectionsBySeason/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Fantasy Defense Season Stats With ADP
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<FantasyDefenseSeasonProjection> GetProjectedFantasyDefenseSeasonStatsWithADP(string season)
        {
            return this.GetProjectedFantasyDefenseSeasonStatsWithADPAsync(season).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public Task<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayerAsync(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGameProjection>(() =>
                base.Get<PlayerGameProjection>("/v3/nfl/projections/{format}/PlayerGameProjectionStatsByPlayerID/{season}/{week}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public PlayerGameProjection GetProjectedPlayerGameStatsByPlayer(string season, int week, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(season, week, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByTeamAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/nfl/projections/{format}/PlayerGameProjectionStatsByTeam/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByTeam(string season, int week, string team)
        {
            return this.GetProjectedPlayerGameStatsByTeamAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/nfl/projections/{format}/PlayerGameProjectionStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByWeek(string season, int week)
        {
            return this.GetProjectedPlayerGameStatsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<PlayerSeasonProjection>> GetProjectedPlayerSeasonStatsWithADPAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonProjection>>(() =>
                base.Get<List<PlayerSeasonProjection>>("/v3/nfl/projections/{format}/PlayerSeasonProjectionStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonProjection> GetProjectedPlayerSeasonStatsWithADP(string season)
        {
            return this.GetProjectedPlayerSeasonStatsWithADPAsync(season).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public Task<PlayerSeasonProjection> GetProjectedPlayerSeasonStatsWithADPByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerSeasonProjection>(() =>
                base.Get<PlayerSeasonProjection>("/v3/nfl/projections/{format}/PlayerSeasonProjectionStatsByPlayerID/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP - by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public PlayerSeasonProjection GetProjectedPlayerSeasonStatsWithADPByPlayer(string season, int playerid)
        {
            return this.GetProjectedPlayerSeasonStatsWithADPByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerSeasonProjection>> GetProjectedPlayerSeasonStatsWithADPByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeasonProjection>>(() =>
                base.Get<List<PlayerSeasonProjection>>("/v3/nfl/projections/{format}/PlayerSeasonProjectionStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats With ADP - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerSeasonProjection> GetProjectedPlayerSeasonStatsWithADPByTeam(string season, string team)
        {
            return this.GetProjectedPlayerSeasonStatsWithADPByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get IDP Projected Player Game Stats - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public Task<PlayerGameProjection> GetIDPProjectedPlayerGameStatsByPlayerAsync(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGameProjection>(() =>
                base.Get<PlayerGameProjection>("/v3/nfl/projections/{format}/IdpPlayerGameProjectionStatsByPlayerID/{season}/{week}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get IDP Projected Player Game Stats - by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public PlayerGameProjection GetIDPProjectedPlayerGameStatsByPlayer(string season, int week, int playerid)
        {
            return this.GetIDPProjectedPlayerGameStatsByPlayerAsync(season, week, playerid).Result;
        }

        /// <summary>
        /// Get IDP Projected Player Game Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerGameProjection>> GetIDPProjectedPlayerGameStatsByTeamAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/nfl/projections/{format}/IdpPlayerGameProjectionStatsByTeam/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get IDP Projected Player Game Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerGameProjection> GetIDPProjectedPlayerGameStatsByTeam(string season, int week, string team)
        {
            return this.GetIDPProjectedPlayerGameStatsByTeamAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get IDP Projected Player Game Stats - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGameProjection>> GetIDPProjectedPlayerGameStatsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/nfl/projections/{format}/IdpPlayerGameProjectionStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get IDP Projected Player Game Stats - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameProjection> GetIDPProjectedPlayerGameStatsByWeek(string season, int week)
        {
            return this.GetIDPProjectedPlayerGameStatsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get DFS Slate Ownership Projections - by Slate Asynchronous
        /// </summary>
        /// <param name="slateId">SlateID of the DFS Slate you wish to get ownership projections for. Will have an empty SlateOwnershipProjections if this slate was not projected</param>
        public Task<DfsSlateWithOwnershipProjection> GetDFSSlateOwnershipProjectionsBySlateAsync(string slateId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("slateId", slateId.ToString()));
            return Task.Run<DfsSlateWithOwnershipProjection>(() =>
                base.Get<DfsSlateWithOwnershipProjection>("/v3/nfl/projections/{format}/DfsSlateOwnershipProjectionsBySlateID/{slateId}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slate Ownership Projections - by Slate
        /// </summary>
        /// <param name="slateId">SlateID of the DFS Slate you wish to get ownership projections for. Will have an empty SlateOwnershipProjections if this slate was not projected</param>
        public DfsSlateWithOwnershipProjection GetDFSSlateOwnershipProjectionsBySlate(string slateId)
        {
            return this.GetDFSSlateOwnershipProjectionsBySlateAsync(slateId).Result;
        }

        /// <summary>
        /// Get DFS Slate Ownership Projections - Upcoming Asynchronous
        /// </summary>
        public Task<List<DfsSlateWithOwnershipProjection>> GetDFSSlateOwnershipProjectionsUpcomingAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<DfsSlateWithOwnershipProjection>>(() =>
                base.Get<List<DfsSlateWithOwnershipProjection>>("/v3/nfl/projections/{format}/UpcomingDfsSlateOwnershipProjections", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slate Ownership Projections - Upcoming
        /// </summary>
        public List<DfsSlateWithOwnershipProjection> GetDFSSlateOwnershipProjectionsUpcoming()
        {
            return this.GetDFSSlateOwnershipProjectionsUpcomingAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Injured Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByInjuredAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/projections/{format}/InjuredPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Injured
        /// </summary>
        public List<Player> GetPlayerDetailsByInjured()
        {
            return this.GetPlayerDetailsByInjuredAsync().Result;
        }

    }
}

