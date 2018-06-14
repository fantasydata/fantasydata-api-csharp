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
        public Task<bool> GetAreAnyGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/nfl/scores/{format}/AreAnyGamesInProgress", parameters)
            );
        }

        /// <summary>
        /// Get Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            return this.GetAreAnyGamesInProgressAsync().Result;
        }

        /// <summary>
        /// Get Bye Weeks Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Bye>> GetByesAsync(string season)
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
        public List<Bye> GetByes(string season)
        {
            return this.GetByesAsync(season).Result;
        }

        /// <summary>
        /// Get Game Stats by Season (Deprecated, use Team Game Stats instead) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Game>> GetGameStatsAsync(string season)
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
        public List<Game> GetGameStats(string season)
        {
            return this.GetGameStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Game Stats by Week (Deprecated, use Team Game Stats instead) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Game>> GetGameStatsByWeekAsync(string season, int week)
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
        public List<Game> GetGameStatsByWeek(string season, int week)
        {
            return this.GetGameStatsByWeekAsync(season, week).Result;
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
        public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
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
        public List<News> GetNewsByPlayerID(int playerid)
        {
            return this.GetNewsByPlayerIDAsync(playerid).Result;
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
        /// Get Schedule Asynchronous
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
        /// Get Schedule
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Schedule> GetSchedules(string season)
        {
            return this.GetSchedulesAsync(season).Result;
        }

        /// <summary>
        /// Get Scores by Season  Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Score>> GetScoresAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/Scores/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Season 
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Score> GetScores(string season)
        {
            return this.GetScoresAsync(season).Result;
        }

        /// <summary>
        /// Get Scores by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Score>> GetScoresByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/scores/{format}/ScoresByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Score> GetScoresByWeek(string season, int week)
        {
            return this.GetScoresByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<int?> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Current
        /// </summary>
        public int? GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

        /// <summary>
        /// Get Season Last Completed Asynchronous
        /// </summary>
        public Task<int?> GetLastCompletedSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Last Completed
        /// </summary>
        public int? GetLastCompletedSeason()
        {
            return this.GetLastCompletedSeasonAsync().Result;
        }

        /// <summary>
        /// Get Season Upcoming Asynchronous
        /// </summary>
        public Task<int?> GetUpcomingSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/UpcomingSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Upcoming
        /// </summary>
        public int? GetUpcomingSeason()
        {
            return this.GetUpcomingSeasonAsync().Result;
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
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

        /// <summary>
        /// Get Teams (All) Asynchronous
        /// </summary>
        public Task<List<Team>> GetAllTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/nfl/scores/{format}/AllTeams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            return this.GetAllTeamsAsync().Result;
        }

        /// <summary>
        /// Get Teams by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<Team>> GetTeamsAsync(string season)
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
        public List<Team> GetTeams(string season)
        {
            return this.GetTeamsAsync(season).Result;
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
        public Task<int?> GetCurrentWeekAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/CurrentWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week Current
        /// </summary>
        public int? GetCurrentWeek()
        {
            return this.GetCurrentWeekAsync().Result;
        }

        /// <summary>
        /// Get Week Last Completed Asynchronous
        /// </summary>
        public Task<int?> GetLastCompletedWeekAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/LastCompletedWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week Last Completed
        /// </summary>
        public int? GetLastCompletedWeek()
        {
            return this.GetLastCompletedWeekAsync().Result;
        }

        /// <summary>
        /// Get Week Upcoming Asynchronous
        /// </summary>
        public Task<int?> GetUpcomingWeekAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/nfl/scores/{format}/UpcomingWeek", parameters)
            );
        }

        /// <summary>
        /// Get Week Upcoming
        /// </summary>
        public int? GetUpcomingWeek()
        {
            return this.GetUpcomingWeekAsync().Result;
        }

        /// <summary>
        /// Get Scores by Week Simulation Asynchronous
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public Task<List<Score>> GetSimulatedScoresAsync(string numberofplays)
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
        public List<Score> GetSimulatedScores(string numberofplays)
        {
            return this.GetSimulatedScoresAsync(numberofplays).Result;
        }

    }
}

