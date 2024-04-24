using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3ScoresClient : BaseClient
    {
        public CFBv3ScoresClient(string apiKey) : base(apiKey) { }
        public CFBv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/cfb/scores/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Conference Hierarchy (with Teams) Asynchronous
        /// </summary>
        public Task<List<Conference>> GetConferenceHierarchyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Conference>>(() =>
                base.Get<List<Conference>>("/v3/cfb/scores/{format}/LeagueHierarchy", parameters)
            );
        }

        /// <summary>
        /// Get Conference Hierarchy (with Teams)
        /// </summary>
        public List<Conference> GetConferenceHierarchy()
        {
            return this.GetConferenceHierarchyAsync().Result;
        }

        /// <summary>
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<int> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int>(() =>
                base.Get<int>("/v3/cfb/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Current Season
        /// </summary>
        public int GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

        /// <summary>
        /// Get Current Week Asynchronous
        /// </summary>
        public Task<int?> GetCurrentWeekAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/cfb/scores/{format}/CurrentWeek", parameters)
            );
        }

        /// <summary>
        /// Get Current Week
        /// </summary>
        public int? GetCurrentWeek()
        {
            return this.GetCurrentWeekAsync().Result;
        }

        /// <summary>
        /// Get Games by Date - Legacy Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public Task<List<Game>> GetGamesByDateLegacyAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date - Legacy
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public List<Game> GetGamesByDateLegacy(string date)
        {
            return this.GetGamesByDateLegacyAsync(date).Result;
        }

        /// <summary>
        /// Get Games by Week - Legacy Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<Game>> GetGamesByWeekLegacyAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/scores/{format}/GamesByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Week - Legacy
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<Game> GetGamesByWeekLegacy(string season, int week)
        {
            return this.GetGamesByWeekLegacyAsync(season, week).Result;
        }

        /// <summary>
        /// Get Schedules - Legacy Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Game>> GetSchedulesLegacyAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/scores/{format}/Games/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules - Legacy
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Game> GetSchedulesLegacy(string season)
        {
            return this.GetSchedulesLegacyAsync(season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/cfb/scores/{format}/Stadiums", parameters)
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
        /// Get Team Game Stats by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cfb/scores/{format}/TeamGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<TeamGame> GetTeamGameStatsByWeek(string season, int week)
        {
            return this.GetTeamGameStatsByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Team Season Stats & Standings Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsStandingsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/cfb/scores/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats & Standings
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<TeamSeason> GetTeamSeasonStatsStandings(string season)
        {
            return this.GetTeamSeasonStatsStandingsAsync(season).Result;
        }

        /// <summary>
        /// Get Teams  - Legacy Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsLegacyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/cfb/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams  - Legacy
        /// </summary>
        public List<Team> GetTeamsLegacy()
        {
            return this.GetTeamsLegacyAsync().Result;
        }

        /// <summary>
        /// Get Current SeasonType Asynchronous
        /// </summary>
        public Task<string> GetCurrentSeasonTypeAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<string>(() =>
                base.Get<string>("/v3/cfb/scores/{format}/CurrentSeasonType", parameters)
            );
        }

        /// <summary>
        /// Get Current SeasonType
        /// </summary>
        public string GetCurrentSeasonType()
        {
            return this.GetCurrentSeasonTypeAsync().Result;
        }

        /// <summary>
        /// Get Current Season Details Asynchronous
        /// </summary>
        public Task<Season> GetCurrentSeasonDetailsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/cfb/scores/{format}/CurrentSeasonDetails", parameters)
            );
        }

        /// <summary>
        /// Get Current Season Details
        /// </summary>
        public Season GetCurrentSeasonDetails()
        {
            return this.GetCurrentSeasonDetailsAsync().Result;
        }

        /// <summary>
        /// Get Player Details By Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details By Active
        /// </summary>
        public List<Player> GetPlayerDetailsByActive()
        {
            return this.GetPlayerDetailsByActiveAsync().Result;
        }

        /// <summary>
        /// Get Player Details By Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public Task<List<Player>> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details By Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<Player> GetPlayerDetailsByPlayer(int playerid)
        {
            return this.GetPlayerDetailsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<Player>> GetPlayerDetailsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/scores/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayerDetailsByTeam(string team)
        {
            return this.GetPlayerDetailsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Injured Players Asynchronous
        /// </summary>
        public Task<List<Player>> GetInjuredPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/scores/{format}/InjuredPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Injured Players
        /// </summary>
        public List<Player> GetInjuredPlayers()
        {
            return this.GetInjuredPlayersAsync().Result;
        }

        /// <summary>
        /// Get Team Game Logs By Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 1 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<TeamGame>> GetTeamGameLogsBySeasonAsync(string season, int teamid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cfb/scores/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs By Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 1 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerBasic>> GetPlayersByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/cfb/scores/{format}/PlayersBasic/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerBasic> GetPlayersByTeam(string team)
        {
            return this.GetPlayersByTeamAsync(team).Result;
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
                base.Get<List<ScheduleBasic>>("/v3/cfb/scores/{format}/SchedulesBasic/{season}", parameters)
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
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<TeamBasic>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamBasic>>(() =>
                base.Get<List<TeamBasic>>("/v3/cfb/scores/{format}/TeamsBasic", parameters)
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
        /// Get Scores by Date Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<ScoreBasic>> GetScoresByDateAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/cfb/scores/{format}/ScoresBasic/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Date
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<ScoreBasic> GetScoresByDate(string season, int week)
        {
            return this.GetScoresByDateAsync(season, week).Result;
        }

        /// <summary>
        /// Get Players By Active Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayersByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/cfb/scores/{format}/PlayersByActive", parameters)
            );
        }

        /// <summary>
        /// Get Players By Active
        /// </summary>
        public List<PlayerBasic> GetPlayersByActive()
        {
            return this.GetPlayersByActiveAsync().Result;
        }

    }
}

