using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client
{
    public partial class NBAv3ScoresClient : BaseClient
    {
        public NBAv3ScoresClient(string apiKey) : base(apiKey) { }
        public NBAv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreAnyGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/nba/scores/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<Season> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/nba/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Current Season
        /// </summary>
        public Season GetCurrentSeason()
        {
            return this.GetCurrentSeasonAsync().Result;
        }

        /// <summary>
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/nba/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News Asynchronous
        /// </summary>
        public Task<List<News>> GetNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nba/scores/{format}/News", parameters)
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
        /// <param name="date">The date of the news. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<News>> GetNewsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nba/scores/{format}/NewsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            return this.GetNewsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get News by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nba/scores/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            return this.GetNewsByPlayerIDAsync(playerid).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Game>> GetGamesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/nba/scores/{format}/Games/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Game> GetGames(string season)
        {
            return this.GetGamesAsync(season).Result;
        }

        /// <summary>
        /// Get Stadiums Asynchronous
        /// </summary>
        public Task<List<Stadium>> GetStadiumsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Stadium>>(() =>
                base.Get<List<Stadium>>("/v3/nba/scores/{format}/Stadiums", parameters)
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
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<Standing>> GetStandingsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/v3/nba/scores/{format}/Standings/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            return this.GetStandingsAsync(season).Result;
        }

        /// <summary>
        /// Get Team Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nba/scores/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            return this.GetTeamGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/nba/scores/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
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
                base.Get<List<Team>>("/v3/nba/scores/{format}/teams", parameters)
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
                base.Get<List<Team>>("/v3/nba/scores/{format}/AllTeams", parameters)
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
        /// Get Player Details by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nba/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Active
        /// </summary>
        public List<Player> GetPlayers()
        {
            return this.GetPlayersAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Free Agent Asynchronous
        /// </summary>
        public Task<List<Player>> GetFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nba/scores/{format}/FreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Free Agent
        /// </summary>
        public List<Player> GetFreeAgents()
        {
            return this.GetFreeAgentsAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public Task<Player> GetPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/nba/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
        public Player GetPlayer(int playerid)
        {
            return this.GetPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Referees Asynchronous
        /// </summary>
        public Task<List<Referee>> GetRefereesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Referee>>(() =>
                base.Get<List<Referee>>("/v3/nba/scores/{format}/Referees", parameters)
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
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>BKN</code>.</param>
        public Task<List<Player>> GetPlayersAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nba/scores/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>BKN</code>.</param>
        public List<Player> GetPlayers(string team)
        {
            return this.GetPlayersAsync(team).Result;
        }

        /// <summary>
        /// Get Team Game Logs By Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<TeamGame>> GetTeamGameStatsBySeasonAsync(string season, int teamid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nba/scores/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs By Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameStatsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameStatsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Depth Charts Asynchronous
        /// </summary>
        public Task<List<TeamDepthChart>> GetDepthChartsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<TeamDepthChart>>(() =>
                base.Get<List<TeamDepthChart>>("/v3/nba/scores/{format}/DepthCharts", parameters)
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
        /// Get Games by Date (Basic) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<ScoreBasic>> GetScoresBasicAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/nba/scores/{format}/ScoresBasic/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date (Basic)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<ScoreBasic> GetScoresBasic(string date)
        {
            return this.GetScoresBasicAsync(date).Result;
        }

        /// <summary>
        /// Get Players by Team (Basic) Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>BKN</code>.</param>
        public Task<List<PlayerBasic>> GetPlayersBasicAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/nba/scores/{format}/PlayersBasic/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team (Basic)
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>BKN</code>.</param>
        public List<PlayerBasic> GetPlayersBasic(string team)
        {
            return this.GetPlayersBasicAsync(team).Result;
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
                base.Get<List<ScheduleBasic>>("/v3/nba/scores/{format}/SchedulesBasic/{season}", parameters)
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

    }
}

