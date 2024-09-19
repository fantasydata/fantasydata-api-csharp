using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client
{
    public partial class CFBv3StatsClient : BaseClient
    {
        public CFBv3StatsClient(string apiKey) : base(apiKey) { }
        public CFBv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/cfb/stats/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Box Score [Live & Final] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>1148</code> or <code>1149</code></param>
        public Task<List<BoxScore>> GetBoxScoreLiveFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Live & Final]
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>1148</code> or <code>1149</code></param>
        public List<BoxScore> GetBoxScoreLiveFinal(int gameid)
        {
            return this.GetBoxScoreLiveFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-JAN-01</code>, <code>2017-JAN-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-JAN-01</code>, <code>2017-JAN-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateLiveFinal(string date)
        {
            return this.GetBoxScoresByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<BoxScore>> GetBoxScoresByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
        public List<BoxScore> GetBoxScoresByWeekLiveFinal(string season, int week)
        {
            return this.GetBoxScoresByWeekLiveFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Box Scores Delta - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaByWeekAsync(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeekDelta/{season}/{week}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Delta - by Week
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetBoxScoresDeltaByWeek(string season, int week, string minutes)
        {
            return this.GetBoxScoresDeltaByWeekAsync(season, week, minutes).Result;
        }

        /// <summary>
        /// Get Conference Hierarchy Asynchronous
        /// </summary>
        public Task<List<Conference>> GetConferenceHierarchyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Conference>>(() =>
                base.Get<List<Conference>>("/v3/cfb/stats/{format}/LeagueHierarchy", parameters)
            );
        }

        /// <summary>
        /// Get Conference Hierarchy
        /// </summary>
        public List<Conference> GetConferenceHierarchy()
        {
            return this.GetConferenceHierarchyAsync().Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<int> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int>(() =>
                base.Get<int>("/v3/cfb/stats/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Current
        /// </summary>
        public int GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Week Current Asynchronous
        /// </summary>
        public Task<int?> GetWeekCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<int?>(() =>
                base.Get<int?>("/v3/cfb/stats/{format}/CurrentWeek", parameters)
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
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public Task<List<Game>> GetGamesByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/stats/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
        public List<Game> GetGamesByDateLiveFinal(string date)
        {
            return this.GetGamesByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Games - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<Game>> GetGamesByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/stats/{format}/GamesByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<Game> GetGamesByWeekLiveFinal(string season, int week)
        {
            return this.GetGamesByWeekLiveFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Details - by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/stats/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Active
        /// </summary>
        public List<Player> GetPlayerDetailsByActive()
        {
            return this.GetPlayerDetailsByActiveAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public Task<List<Player>> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/stats/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<Player> GetPlayerDetailsByPlayer(int playerid)
        {
            return this.GetPlayerDetailsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details - by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<Player>> GetPlayerDetailsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/stats/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayerDetailsByTeam(string team)
        {
            return this.GetPlayerDetailsByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Player [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByPlayerLiveFinalAsync(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsByPlayer/{season}/{week}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Player [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByPlayerLiveFinal(string season, int week, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerLiveFinalAsync(season, week, playerid).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<PlayerGame> GetPlayerGameStatsByWeekLiveFinal(string season, int week)
        {
            return this.GetPlayerGameStatsByWeekLiveFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Player
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Game>> GetSchedulesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cfb/stats/{format}/Games/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Game> GetSchedules(string season)
        {
            return this.GetSchedulesAsync(season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/cfb/stats/{format}/Stadiums", parameters)
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
        /// Get Team Game Stats - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cfb/stats/{format}/TeamGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<TeamGame> GetTeamGameStatsByWeekLiveFinal(string season, int week)
        {
            return this.GetTeamGameStatsByWeekLiveFinalAsync(season, week).Result;
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
                base.Get<List<TeamSeason>>("/v3/cfb/stats/{format}/TeamSeasonStats/{season}", parameters)
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
        /// Get Team Profiles - All Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/cfb/stats/{format}/Teams", parameters)
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
        /// Get Season Type - Current Asynchronous
        /// </summary>
        public Task<string> GetSeasonTypeCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<string>(() =>
                base.Get<string>("/v3/cfb/stats/{format}/CurrentSeasonType", parameters)
            );
        }

        /// <summary>
        /// Get Season Type - Current
        /// </summary>
        public string GetSeasonTypeCurrent()
        {
            return this.GetSeasonTypeCurrentAsync().Result;
        }

        /// <summary>
        /// Get Season Current - Details Asynchronous
        /// </summary>
        public Task<Season> GetSeasonCurrentDetailsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/cfb/stats/{format}/CurrentSeasonDetails", parameters)
            );
        }

        /// <summary>
        /// Get Season Current - Details
        /// </summary>
        public Season GetSeasonCurrentDetails()
        {
            return this.GetSeasonCurrentDetailsAsync().Result;
        }

        /// <summary>
        /// Get Player Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50036283</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<PlayerGame>> GetPlayerGameLogsBySeasonAsync(string season, int playerid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50036283</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<PlayerGame> GetPlayerGameLogsBySeason(string season, int playerid, string numberofgames)
        {
            return this.GetPlayerGameLogsBySeasonAsync(season, playerid, numberofgames).Result;
        }

        /// <summary>
        /// Get Player Details - by Injured Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByInjuredAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cfb/stats/{format}/InjuredPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Injured
        /// </summary>
        public List<Player> GetPlayerDetailsByInjured()
        {
            return this.GetPlayerDetailsByInjuredAsync().Result;
        }

        /// <summary>
        /// Get Team Game Logs - by Season Asynchronous
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
                base.Get<List<TeamGame>>("/v3/cfb/stats/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 1 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Box Score [Final] Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>1148</code> or <code>1149</code></param>
        public Task<List<BoxScore>> GetBoxScoreFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoreFinal/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Final]
        /// </summary>
        /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>1148</code> or <code>1149</code></param>
        public List<BoxScore> GetBoxScoreFinal(int gameid)
        {
            return this.GetBoxScoreFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-JAN-01</code>, <code>2017-JAN-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-JAN-01</code>, <code>2017-JAN-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateFinal(string date)
        {
            return this.GetBoxScoresByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<BoxScore>> GetBoxScoresByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeekFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
        public List<BoxScore> GetBoxScoresByWeekFinal(string season, int week)
        {
            return this.GetBoxScoresByWeekFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsByWeekFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<PlayerGame> GetPlayerGameStatsByWeekFinal(string season, int week)
        {
            return this.GetPlayerGameStatsByWeekFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cfb/stats/{format}/TeamGameStatsByWeekFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
        /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
        public List<TeamGame> GetTeamGameStatsByWeekFinal(string season, int week)
        {
            return this.GetTeamGameStatsByWeekFinalAsync(season, week).Result;
        }

    }
}

