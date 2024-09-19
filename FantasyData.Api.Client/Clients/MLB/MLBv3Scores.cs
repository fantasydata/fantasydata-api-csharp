using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv3ScoresClient : BaseClient
    {
        public MLBv3ScoresClient(string apiKey) : base(apiKey) { }
        public MLBv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/mlb/scores/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Season - Current Asynchronous
        /// </summary>
        public Task<Season> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/v3/mlb/scores/{format}/CurrentSeason", parameters)
            );
        }

        /// <summary>
        /// Get Season - Current
        /// </summary>
        public Season GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<Game>> GetGamesByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/mlb/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Game> GetGamesByDateLiveFinal(string date)
        {
            return this.GetGamesByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get News Asynchronous
        /// </summary>
        public Task<List<News>> GetNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/mlb/scores/{format}/News", parameters)
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
                base.Get<List<News>>("/v3/mlb/scores/{format}/NewsByDate/{date}", parameters)
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
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<News>> GetNewsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/mlb/scores/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayer(int playerid)
        {
            return this.GetNewsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Details - by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/scores/{format}/Players", parameters)
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
        /// Get Player Details - by Free Agents Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/scores/{format}/FreeAgents", parameters)
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
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<Player> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/mlb/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Player GetPlayerDetailsByPlayer(int playerid)
        {
            return this.GetPlayerDetailsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Players Details - by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<Player>> GetPlayersDetailsByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/mlb/scores/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players Details - by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayersDetailsByTeam(string team)
        {
            return this.GetPlayersDetailsByTeamAsync(team).Result;
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
                base.Get<List<Game>>("/v3/mlb/scores/{format}/Games/{season}", parameters)
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
                base.Get<List<Stadium>>("/v3/mlb/scores/{format}/Stadiums", parameters)
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
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<Standing>> GetStandingsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/v3/mlb/scores/{format}/Standings/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            return this.GetStandingsAsync(season).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/scores/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateLiveFinal(string date)
        {
            return this.GetTeamGameStatsByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/v3/mlb/scores/{format}/TeamSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
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
                base.Get<List<Team>>("/v3/mlb/scores/{format}/teams", parameters)
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
                base.Get<List<Team>>("/v3/mlb/scores/{format}/AllTeams", parameters)
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
        /// Get Team Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 12 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<TeamGame>> GetTeamGameLogsBySeasonAsync(string season, int teamid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/scores/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 12 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<ScoreBasic>> GetGamesBasicByDateLiveFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/mlb/scores/{format}/ScoresBasic/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Live & Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<ScoreBasic> GetGamesBasicByDateLiveFinal(string date)
        {
            return this.GetGamesBasicByDateLiveFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Player Profiles (Basic) - by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerBasic>> GetPlayerProfilesBasicByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/mlb/scores/{format}/PlayersBasic/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles (Basic) - by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerBasic> GetPlayerProfilesBasicByTeam(string team)
        {
            return this.GetPlayerProfilesBasicByTeamAsync(team).Result;
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
                base.Get<List<ScheduleBasic>>("/v3/mlb/scores/{format}/SchedulesBasic/{season}", parameters)
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
        /// Get Player Details - by Active Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayerDetailsByActive_1459Async()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/mlb/scores/{format}/PlayersByActive", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Active
        /// </summary>
        public List<PlayerBasic> GetPlayerDetailsByActive_1459()
        {
            return this.GetPlayerDetailsByActive_1459Async().Result;
        }

        /// <summary>
        /// Get Player Details - by Free Agents Asynchronous
        /// </summary>
        public Task<List<PlayerBasic>> GetPlayerDetailsByFreeAgents_1460Async()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v3/mlb/scores/{format}/PlayersByFreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Free Agents
        /// </summary>
        public List<PlayerBasic> GetPlayerDetailsByFreeAgents_1460()
        {
            return this.GetPlayerDetailsByFreeAgents_1460Async().Result;
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
                base.Get<List<Team>>("/v3/mlb/scores/{format}/teams/{season}", parameters)
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
        /// Get Transactions Asynchronous
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<Transaction>> GetTransactionsAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Transaction>>(() =>
                base.Get<List<Transaction>>("/v3/mlb/scores/{format}/TransactionsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Transactions
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<Transaction> GetTransactions(string date)
        {
            return this.GetTransactionsAsync(date).Result;
        }

        /// <summary>
        /// Get Games - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<Game>> GetGamesByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/mlb/scores/{format}/GamesByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<Game> GetGamesByDateFinal(string date)
        {
            return this.GetGamesByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<ScoreBasic>> GetGamesBasicByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v3/mlb/scores/{format}/ScoresBasicFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games (Basic) - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<ScoreBasic> GetGamesBasicByDateFinal(string date)
        {
            return this.GetGamesBasicByDateFinalAsync(date).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateFinalAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/mlb/scores/{format}/TeamGameStatsByDateFinal/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final]
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateFinal(string date)
        {
            return this.GetTeamGameStatsByDateFinalAsync(date).Result;
        }

    }
}

