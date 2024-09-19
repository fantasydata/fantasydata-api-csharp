using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client
{
    public partial class CBBv3StatsClient : BaseClient
    {
        public CBBv3StatsClient(string apiKey) : base(apiKey) { }
        public CBBv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/cbb/stats/{format}/AreAnyGamesInProgress", parameters)
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
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<BoxScore> GetBoxScoreLiveFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/cbb/stats/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Live & Final]
        /// </summary>
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScoreLiveFinal(int gameid)
        {
            return this.GetBoxScoreLiveFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cbb/stats/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateLiveFinal(string date)
        {
            return this.GetBoxScoresByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores Delta - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaByDateAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cbb/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Delta - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetBoxScoresDeltaByDate(string date, string minutes)
        {
            return this.GetBoxScoresDeltaByDateAsync(date, minutes).Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<Season> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/cbb/stats/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season Current
        /// </summary>
        public Season GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<Game>> GetGamesByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/cbb/stats/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<Game> GetGamesByDateLiveFinal(string date)
        {
            return this.GetGamesByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get League Hierarchy Asynchronous
        /// </summary>
        public Task<List<Conference>> GetLeagueHierarchyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Conference>>(() =>
                base.Get<List<Conference>>("/v3/cbb/stats/{format}/LeagueHierarchy", parameters)
            );
        }

        /// <summary>
        /// Get League Hierarchy
        /// </summary>
        public List<Conference> GetLeagueHierarchy()
        {
            return this.GetLeagueHierarchyAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/cbb/stats/{format}/Players", parameters)
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
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public Task<Player> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/cbb/stats/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public Player GetPlayerDetailsByPlayer(int playerid)
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
                base.Get<List<Player>>("/v3/cbb/stats/{format}/Players/{team}", parameters)
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
        /// Get Player Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cbb/stats/{format}/PlayerGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDateLiveFinal(string date)
        {
            return this.GetPlayerGameStatsByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public Task<PlayerGame> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGame>(() =>
                base.Get<PlayerGame>("/v3/cbb/stats/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/cbb/stats/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public Task<PlayerSeason> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerSeason>(() =>
                base.Get<PlayerSeason>("/v3/cbb/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Player
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/cbb/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/cbb/stats/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public Task<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGameProjection>(() =>
                base.Get<PlayerGameProjection>("/v3/cbb/stats/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
        public PlayerGameProjection GetProjectedPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(date, playerid).Result;
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
                base.Get<List<Game>>("/v3/cbb/stats/{format}/Games/{season}", parameters)
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
        /// Get Team Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cbb/stats/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateLiveFinal(string date)
        {
            return this.GetTeamGameStatsByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/cbb/stats/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            return this.GetTeamSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Team Profiles - All Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/cbb/stats/{format}/teams", parameters)
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
        /// Get Games - by Season [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        public Task<Tournament> GetGamesBySeasonLiveFinalAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<Tournament>(() =>
                base.Get<Tournament>("/v3/cbb/stats/{format}/Tournament/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Season [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
        public Tournament GetGamesBySeasonLiveFinal(string season)
        {
            return this.GetGamesBySeasonLiveFinalAsync(season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/cbb/stats/{format}/Stadiums", parameters)
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
        /// Get Player Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID.Example:<code>60008094</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<PlayerGame>> GetPlayerGameLogsBySeasonAsync(string season, int playerid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cbb/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID.Example:<code>60008094</code>.</param>
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
                base.Get<List<Player>>("/v3/cbb/stats/{format}/InjuredPlayers", parameters)
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
                base.Get<List<TeamGame>>("/v3/cbb/stats/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
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
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<BoxScore> GetBoxScoreFinalAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/cbb/stats/{format}/BoxScoreFinal/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Final]
        /// </summary>
        /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScoreFinal(int gameid)
        {
            return this.GetBoxScoreFinalAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/cbb/stats/{format}/BoxScoresFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateFinal(string date)
        {
            return this.GetBoxScoresByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/cbb/stats/{format}/PlayerGameStatsByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDateFinal(string date)
        {
            return this.GetPlayerGameStatsByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/cbb/stats/{format}/TeamGameStatsByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateFinal(string date)
        {
            return this.GetTeamGameStatsByDateFinalAsync(date).Result;
        }

    }
}

