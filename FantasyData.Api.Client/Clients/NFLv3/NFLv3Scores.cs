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
        /// Get News - by Date Asynchronous
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
        /// Get News - by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News - by Player Asynchronous
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
        /// Get News - by Player
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public List<News> GetNewsByPlayer(int playerid)
        {
            return this.GetNewsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get News - by Team Asynchronous
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
        /// Get News - by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetNewsByTeam(string team)
        {
            return this.GetNewsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Schedule>> GetSchedulesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Schedule>>(() =>
                base.Get<List<Schedule>>("/v3/nfl/scores/{format}/Schedules/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Schedule> GetSchedules(string season)
        {
            return this.GetSchedulesAsync(season).Result;
        }

        /// <summary>
        /// Get Games - by Season [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Score>> GetGamesBySeasonLiveFinalAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/Scores/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Season [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Score> GetGamesBySeasonLiveFinal(string season)
        {
            return this.GetGamesBySeasonLiveFinalAsync(season).Result;
        }

        /// <summary>
        /// Get Games - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Score>> GetGamesByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Score> GetGamesByWeekLiveFinal(string season, int week)
        {
            return this.GetGamesByWeekLiveFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Season - Current Asynchronous
        /// </summary>
        public Task<int?> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season - Current
        /// </summary>
        public int? GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Season - Last Completed Asynchronous
        /// </summary>
        public Task<int?> GetSeasonLastCompletedAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season - Last Completed
        /// </summary>
        public int? GetSeasonLastCompleted()
        {
            return this.GetSeasonLastCompletedAsync().Result;
        }

        /// <summary>
        /// Get Season - Upcoming Asynchronous
        /// </summary>
        public Task<int?> GetSeasonUpcomingAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/UpcomingSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season - Upcoming
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
        /// Get Team Game Stats [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<TeamGame>> GetTeamGameStatsLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nfl/scores/{format}/TeamGameStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<TeamGame> GetTeamGameStatsLiveFinal(string season, int week)
        {
            return this.GetTeamGameStatsLiveFinalAsync(season, week).Result;
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
        /// Get Team Profiles - by Active Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - by Active
        /// </summary>
        public List<Team> GetTeamProfilesByActive()
        {
            return this.GetTeamProfilesByActiveAsync().Result;
        }

        /// <summary>
        /// Get Team Profiles - All Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/AllTeams", parameters)
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
        /// Get Team Profiles - by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Team>> GetTeamProfilesBySeasonAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - by Season
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Team> GetTeamProfilesBySeason(string season)
        {
            return this.GetTeamProfilesBySeasonAsync(season).Result;
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
        /// Get Week - Current Asynchronous
        /// </summary>
        public Task<int?> GetWeekCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/CurrentWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week - Current
        /// </summary>
        public int? GetWeekCurrent()
        {
            return this.GetWeekCurrentAsync().Result;
        }

        /// <summary>
        /// Get Week - Last Completed Asynchronous
        /// </summary>
        public Task<int?> GetWeekLastCompletedAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week - Last Completed
        /// </summary>
        public int? GetWeekLastCompleted()
        {
            return this.GetWeekLastCompletedAsync().Result;
        }

        /// <summary>
        /// Get Week - Upcoming Asynchronous
        /// </summary>
        public Task<int?> GetWeekUpcomingAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/UpcomingWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week - Upcoming
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
        /// Get Player Details - All Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - All
        /// </summary>
        public List<Player> GetPlayerDetailsAll()
        {
            return this.GetPlayerDetailsAllAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Free Agents Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/scores/{format}/FreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Free Agents
        /// </summary>
        public List<Player> GetPlayerDetailsByFreeAgents()
        {
            return this.GetPlayerDetailsByFreeAgentsAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<PlayerDetail> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerDetail>(() =>
                base.Get<PlayerDetail>("/v3/nfl/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Player
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public PlayerDetail GetPlayerDetailsByPlayer(int playerid)
        {
            return this.GetPlayerDetailsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details - by Team Asynchronous
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
        /// Get Player Details - by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerDetail> GetPlayerDetailsByTeam(string team)
        {
            return this.GetPlayerDetailsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Player Details - by Rookie Draft Year Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public Task<List<Player>> GetPlayerDetailsByRookieDraftYearAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/scores/{format}/Rookies/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Rookie Draft Year
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public List<Player> GetPlayerDetailsByRookieDraftYear(string season)
        {
            return this.GetPlayerDetailsByRookieDraftYearAsync(season).Result;
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
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
        public Task<List<Score>> GetGamesByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
        public List<Score> GetGamesByDateLiveFinal(string date)
        {
            return this.GetGamesByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<TeamGame>> GetPlayerGameLogsBySeasonAsync(string season, int teamid, string numberofgames)
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
        /// Get Player Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetPlayerGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetPlayerGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
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
        /// Get Schedules (Basic) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<ScheduleBasic>> GetSchedulesBasicAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<ScheduleBasic>>(() =>
                base.Get<List<ScheduleBasic>>("/v3/nfl/scores/{format}/SchedulesBasic/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules (Basic)
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<ScheduleBasic> GetSchedulesBasic(string season)
        {
            return this.GetSchedulesBasicAsync(season).Result;
        }

        /// <summary>
        /// Get Games (Basic) - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<ScoreBasic>> GetGamesBasicByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/nfl/scores/{format}/ScoresBasic/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games (Basic) - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<ScoreBasic> GetGamesBasicByWeekLiveFinal(string season, int week)
        {
            return this.GetGamesBasicByWeekLiveFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Team Profiles (Basic) - All Asynchronous
        /// </summary>
        public Task<List<TeamBasic>> GetTeamProfilesBasicAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamBasic>>(() =>
                base.Get<List<TeamBasic>>("/v3/nfl/scores/{format}/TeamsBasic", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles (Basic) - All
        /// </summary>
        public List<TeamBasic> GetTeamProfilesBasicAll()
        {
            return this.GetTeamProfilesBasicAllAsync().Result;
        }

        /// <summary>
        /// Get Player Profiles - by Team Asynchronous
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerBasic>> GetPlayerProfilesByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersBasic/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerBasic> GetPlayerProfilesByTeam(string team)
        {
            return this.GetPlayerProfilesByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Player Profiles - All Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayerProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersByAvailable", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - All
        /// </summary>
        public List<PlayerBasic> GetPlayerProfilesAll()
        {
            return this.GetPlayerProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Player Profiles - by Free Agent Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayerProfilesByFreeAgentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersByFreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - by Free Agent
        /// </summary>
        public List<PlayerBasic> GetPlayerProfilesByFreeAgent()
        {
            return this.GetPlayerProfilesByFreeAgentAsync().Result;
        }

        /// <summary>
        /// Get Player Profiles - by Rookie Draft Year Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public Task<List<PlayerBasic>> GetPlayerProfilesByRookieDraftYearAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nfl/scores/{format}/PlayersByRookieDraftYear/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - by Rookie Draft Year
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
        public List<PlayerBasic> GetPlayerProfilesByRookieDraftYear(string season)
        {
            return this.GetPlayerProfilesByRookieDraftYearAsync(season).Result;
        }

        /// <summary>
        /// Get Transactions - by Date Asynchronous
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
        /// Get Transactions - by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Transaction> GetTransactionsByDate(string date)
        {
            return this.GetTransactionsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Games - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
        public Task<List<Score>> GetGamesByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
        public List<Score> GetGamesByDateFinal(string date)
        {
            return this.GetGamesByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Games (Basic) - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<ScoreBasic>> GetGamesBasicByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/nfl/scores/{format}/ScoresBasicFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games (Basic) - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<ScoreBasic> GetGamesBasicByWeekFinal(string season, int week)
        {
            return this.GetGamesBasicByWeekFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Games - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Score>> GetGamesByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByWeekFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Score> GetGamesByWeekFinal(string season, int week)
        {
            return this.GetGamesByWeekFinalAsync(season, week).Result;
        }

    }
}

