using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3ScoresClient : BaseClient
    {
        public NFLv3ScoresClient(string apiKey) : base(apiKey) { }
        public NFLv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/nfl/scores/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Bye Weeks Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Bye>> GetByeWeeksAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Bye>>(() =>
                base.Get<List<Bye>>("/v3/nfl/scores/{format}/Byes/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Bye Weeks
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Bye> GetByeWeeks(string season)
        {
            return this.GetByeWeeksAsync(season).Result;
        }

        /// <summary>
        /// Get Game Stats by Season (Deprecated, use Team Game Stats instead) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Game>> GetGameStatsBySeasonDeprecatedUseTeamGameStatsInsteadAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/nfl/scores/{format}/GameStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Game Stats by Season (Deprecated, use Team Game Stats instead)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Game> GetGameStatsBySeasonDeprecatedUseTeamGameStatsInstead(string season)
        {
            return this.GetGameStatsBySeasonDeprecatedUseTeamGameStatsInsteadAsync(season).Result;
        }

        /// <summary>
        /// Get Game Stats by Week (Deprecated, use Team Game Stats instead) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Game>> GetGameStatsByWeekDeprecatedUseTeamGameStatsInsteadAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/nfl/scores/{format}/GameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Game Stats by Week (Deprecated, use Team Game Stats instead)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Game> GetGameStatsByWeekDeprecatedUseTeamGameStatsInstead(string season, int week)
        {
            return this.GetGameStatsByWeekDeprecatedUseTeamGameStatsInsteadAsync(season, week).Result;
        }

        /// <summary>
        /// Get News Asynchronous
        /// </summary>
        public Task<List<News>> GetNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/scores/{format}/News", parameters)
            );
        }

        /// <summary>
        /// Get News
        /// </summary>
        public List<News> GetNews()
        {
            return this.GetNewsAsync().Result;
        }

        /// <summary>
        /// Get News by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<News>> GetNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/scores/{format}/NewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public Task<List<News>> GetNewsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/scores/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News by Player
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public List<News> GetNewsByPlayer(int playerid)
        {
            return this.GetNewsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get News by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<News>> GetNewsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/scores/{format}/NewsByTeam/{team}", parameters)
            );
        }

        /// <summary>
        /// Get News by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetNewsByTeam(string team)
        {
            return this.GetNewsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Schedules - Legacy Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Schedule>> GetSchedulesLegacyAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Schedule>>(() =>
                base.Get<List<Schedule>>("/v3/nfl/scores/{format}/Schedules/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules - Legacy
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Schedule> GetSchedulesLegacy(string season)
        {
            return this.GetSchedulesLegacyAsync(season).Result;
        }

        /// <summary>
        /// Get Scores by Season - Legacy Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Score>> GetScoresBySeasonLegacyAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/Scores/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Season - Legacy
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Score> GetScoresBySeasonLegacy(string season)
        {
            return this.GetScoresBySeasonLegacyAsync(season).Result;
        }

        /// <summary>
        /// Get Scores by Week - Legacy Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Score>> GetScoresByWeekLegacyAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Week - Legacy
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Score> GetScoresByWeekLegacy(string season, int week)
        {
            return this.GetScoresByWeekLegacyAsync(season, week).Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<int?> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Current
        /// </summary>
        public int? GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Season Last Completed Asynchronous
        /// </summary>
        public Task<int?> GetSeasonLastCompletedAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Last Completed
        /// </summary>
        public int? GetSeasonLastCompleted()
        {
            return this.GetSeasonLastCompletedAsync().Result;
        }

        /// <summary>
        /// Get Season Upcoming Asynchronous
        /// </summary>
        public Task<int?> GetSeasonUpcomingAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/UpcomingSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Upcoming
        /// </summary>
        public int? GetSeasonUpcoming()
        {
            return this.GetSeasonUpcomingAsync().Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/nfl/scores/{format}/Stadiums", parameters)
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
        /// Get Standings Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Standing>> GetStandingsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/v3/nfl/scores/{format}/Standings/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            return this.GetStandingsAsync(season).Result;
        }

        /// <summary>
        /// Get Team Game Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<TeamGame>> GetTeamGameStatsAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nfl/scores/{format}/TeamGameStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<TeamGame> GetTeamGameStats(string season, int week)
        {
            return this.GetTeamGameStatsAsync(season, week).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/nfl/scores/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            return this.GetTeamSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Teams (Active) Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (Active)
        /// </summary>
        public List<Team> GetTeamsActive()
        {
            return this.GetTeamsActiveAsync().Result;
        }

        /// <summary>
        /// Get Teams (All) Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/AllTeams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (All)
        /// </summary>
        public List<Team> GetTeamsAll()
        {
            return this.GetTeamsAllAsync().Result;
        }

        /// <summary>
        /// Get Teams by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Team>> GetTeamsBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Teams by Season
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Team> GetTeamsBySeason(string season)
        {
            return this.GetTeamsBySeasonAsync(season).Result;
        }

        /// <summary>
        /// Get Timeframes Asynchronous
        /// </summary>
        /// <param name="type">The type of timeframes to return. Valid entries are <code>current</code> or <code>upcoming</code> or <code>completed</code> or <code>recent</code> or <code>all</code>.</param>
        public Task<List<Timeframe>> GetTimeframesAsync(string type)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("type", type.ToString()));
            return Task.Run<List<Timeframe>>(() =>
                base.Get<List<Timeframe>>("/v3/nfl/scores/{format}/Timeframes/{type}", parameters)
            );
        }

        /// <summary>
        /// Get Timeframes
        /// </summary>
        /// <param name="type">The type of timeframes to return. Valid entries are <code>current</code> or <code>upcoming</code> or <code>completed</code> or <code>recent</code> or <code>all</code>.</param>
        public List<Timeframe> GetTimeframes(string type)
        {
            return this.GetTimeframesAsync(type).Result;
        }

        /// <summary>
        /// Get Week Current Asynchronous
        /// </summary>
        public Task<int?> GetWeekCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/CurrentWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week Current
        /// </summary>
        public int? GetWeekCurrent()
        {
            return this.GetWeekCurrentAsync().Result;
        }

        /// <summary>
        /// Get Week Last Completed Asynchronous
        /// </summary>
        public Task<int?> GetWeekLastCompletedAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week Last Completed
        /// </summary>
        public int? GetWeekLastCompleted()
        {
            return this.GetWeekLastCompletedAsync().Result;
        }

        /// <summary>
        /// Get Week Upcoming Asynchronous
        /// </summary>
        public Task<int?> GetWeekUpcomingAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/UpcomingWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week Upcoming
        /// </summary>
        public int? GetWeekUpcoming()
        {
            return this.GetWeekUpcomingAsync().Result;
        }

        /// <summary>
        /// Get Scores by Week Simulation Asynchronous
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public Task<List<Score>> GetScoresByWeekSimulationAsync(string numberofplays)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("numberofplays", numberofplays.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/SimulatedScores/{numberofplays}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Week Simulation
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public List<Score> GetScoresByWeekSimulation(string numberofplays)
        {
            return this.GetScoresByWeekSimulationAsync(numberofplays).Result;
        }

        /// <summary>
        /// Get Player Details by Available - Legacy Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByAvailableLegacyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Available - Legacy
        /// </summary>
        public List<Player> GetPlayerDetailsByAvailableLegacy()
        {
            return this.GetPlayerDetailsByAvailableLegacyAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Free Agents - Legacy Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByFreeAgentsLegacyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/scores/{format}/FreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Free Agents - Legacy
        /// </summary>
        public List<Player> GetPlayerDetailsByFreeAgentsLegacy()
        {
            return this.GetPlayerDetailsByFreeAgentsLegacyAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Player - Legacy Asynchronous
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<PlayerDetail> GetPlayerDetailsByPlayerLegacyAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerDetail>(() =>
                base.Get<PlayerDetail>("/v3/nfl/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Player - Legacy
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public PlayerDetail GetPlayerDetailsByPlayerLegacy(int playerid)
        {
            return this.GetPlayerDetailsByPlayerLegacyAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerDetail>> GetPlayerDetailsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerDetail>>(() =>
                base.Get<List<PlayerDetail>>("/v3/nfl/scores/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerDetail> GetPlayerDetailsByTeam(string team)
        {
            return this.GetPlayerDetailsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Player Details by Rookie Draft Year - Legacy Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public Task<List<Player>> GetPlayerDetailsByRookieDraftYearLegacyAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/scores/{format}/Rookies/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Rookie Draft Year - Legacy
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public List<Player> GetPlayerDetailsByRookieDraftYearLegacy(string season)
        {
            return this.GetPlayerDetailsByRookieDraftYearLegacyAsync(season).Result;
        }

        /// <summary>
        /// Get Referees Asynchronous
        /// </summary>
        public Task<List<Referee>> GetRefereesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Referee>>(() =>
                base.Get<List<Referee>>("/v3/nfl/scores/{format}/Referees", parameters)
            );
        }

        /// <summary>
        /// Get Referees
        /// </summary>
        public List<Referee> GetReferees()
        {
            return this.GetRefereesAsync().Result;
        }

        /// <summary>
        /// Get Scores by Date - Legacy Asynchronous
        /// </summary>
        /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
        public Task<List<Score>> GetScoresByDateLegacyAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Date - Legacy
        /// </summary>
        /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
        public List<Score> GetScoresByDateLegacy(string date)
        {
            return this.GetScoresByDateLegacyAsync(date).Result;
        }

        /// <summary>
        /// Get Team Game Logs By Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<TeamGame>> GetTeamGameLogsBySeasonAsync(string season, int teamid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nfl/scores/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs By Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Depth Charts Asynchronous
        /// </summary>
        public Task<List<TeamDepthChart>> GetDepthChartsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamDepthChart>>(() =>
                base.Get<List<TeamDepthChart>>("/v3/nfl/scores/{format}/DepthCharts", parameters)
            );
        }

        /// <summary>
        /// Get Depth Charts
        /// </summary>
        public List<TeamDepthChart> GetDepthCharts()
        {
            return this.GetDepthChartsAsync().Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<ScheduleBasic>> GetSchedulesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<ScheduleBasic>>(() =>
                base.Get<List<ScheduleBasic>>("/v3/nfl/scores/{format}/SchedulesBasic/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<ScheduleBasic> GetSchedules(string season)
        {
            return this.GetSchedulesAsync(season).Result;
        }

        /// <summary>
        /// Get Scores by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<ScoreBasic>> GetScoresByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/nfl/scores/{format}/ScoresBasic/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<ScoreBasic> GetScoresByWeek(string season, int week)
        {
            return this.GetScoresByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<TeamBasic>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamBasic>>(() =>
                base.Get<List<TeamBasic>>("/v3/nfl/scores/{format}/TeamsBasic", parameters)
            );
        }

        /// <summary>
        /// Get Teams
        /// </summary>
        public List<TeamBasic> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerBasic>> GetPlayersByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersBasic/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerBasic> GetPlayersByTeam(string team)
        {
            return this.GetPlayersByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Players by Available Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayersByAvailableAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersByAvailable", parameters)
            );
        }

        /// <summary>
        /// Get Players by Available
        /// </summary>
        public List<PlayerBasic> GetPlayersByAvailable()
        {
            return this.GetPlayersByAvailableAsync().Result;
        }

        /// <summary>
        /// Get Players by Free Agent Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayersByFreeAgentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersByFreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Players by Free Agent
        /// </summary>
        public List<PlayerBasic> GetPlayersByFreeAgent()
        {
            return this.GetPlayersByFreeAgentAsync().Result;
        }

        /// <summary>
        /// Get Players by Rookie Draft Year Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public Task<List<PlayerBasic>> GetPlayersByRookieDraftYearAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersByRookieDraftYear/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Rookie Draft Year
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public List<PlayerBasic> GetPlayersByRookieDraftYear(string season)
        {
            return this.GetPlayersByRookieDraftYearAsync(season).Result;
        }

        /// <summary>
        /// Get Transactions By Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<Transaction>> GetTransactionsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Transaction>>(() =>
                base.Get<List<Transaction>>("/v3/nfl/scores/{format}/TransactionsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Transactions By Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Transaction> GetTransactionsByDate(string date)
        {
            return this.GetTransactionsByDateAsync(date).Result;
        }

    }
}

