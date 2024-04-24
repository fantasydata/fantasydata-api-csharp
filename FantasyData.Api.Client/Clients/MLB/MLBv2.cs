﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client
{
    public partial class MLBv2Client : BaseClient
    {
        public MLBv2Client(string apiKey) : base(apiKey) { }
        public MLBv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/mlb/v2/{format}/AreAnyGamesInProgress", parameters)
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
        /// Get Batter vs. Pitcher Stats Asynchronous
        /// </summary>
        /// <param name="hitterid">Unique FantasyData Player ID. Example:<code>10000031</code>.</param>
        /// <param name="pitcherid">Unique FantasyData Player ID. Example:<code>10000618</code>.</param>
        public Task<List<PlayerSeason>> GetBatterVsPitcherStatsAsync(int hitterid, int pitcherid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("hitterid", hitterid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("pitcherid", pitcherid.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/HitterVsPitcher/{hitterid}/{pitcherid}", parameters)
            );
        }

        /// <summary>
        /// Get Batter vs. Pitcher Stats
        /// </summary>
        /// <param name="hitterid">Unique FantasyData Player ID. Example:<code>10000031</code>.</param>
        /// <param name="pitcherid">Unique FantasyData Player ID. Example:<code>10000618</code>.</param>
        public List<PlayerSeason> GetBatterVsPitcherStats(int hitterid, int pitcherid)
        {
            return this.GetBatterVsPitcherStatsAsync(hitterid, pitcherid).Result;
        }

        /// <summary>
        /// Get Box Score Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<BoxScore> GetBoxScoreAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/mlb/v2/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public BoxScore GetBoxScore(int gameid)
        {
            return this.GetBoxScoreAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/mlb/v2/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDate(string date)
        {
            return this.GetBoxScoresByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Delta Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateDeltaAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/mlb/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresByDateDelta(string date, string minutes)
        {
            return this.GetBoxScoresByDateDeltaAsync(date, minutes).Result;
        }

        /// <summary>
        /// Get Current Season Asynchronous
        /// </summary>
        public Task<Season> GetCurrentSeasonAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<Season>(() =>
                base.Get<Season>("/mlb/v2/{format}/CurrentSeason", parameters)
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
        /// Get DFS Slates by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/mlb/v2/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<DfsSlate> GetDFSSlatesByDate(string date)
        {
            return this.GetDFSSlatesByDateAsync(date).Result;
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
                base.Get<List<Game>>("/mlb/v2/{format}/GamesByDate/{date}", parameters)
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
                base.Get<List<News>>("/mlb/v2/{format}/News", parameters)
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
                base.Get<List<News>>("/mlb/v2/{format}/NewsByDate/{date}", parameters)
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
        public Task<List<News>> GetNewsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/mlb/v2/{format}/NewsByPlayerID/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get News by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<News> GetNewsByPlayer(int playerid)
        {
            return this.GetNewsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Play By Play Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public Task<PlayByPlay> GetPlayByPlayAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<PlayByPlay>(() =>
                base.Get<PlayByPlay>("/mlb/v2/{format}/PlayByPlay/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Play By Play
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        public PlayByPlay GetPlayByPlay(int gameid)
        {
            return this.GetPlayByPlayAsync(gameid).Result;
        }

        /// <summary>
        /// Get Play By Play Delta Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<PlayByPlay>> GetPlayByPlayDeltaAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<PlayByPlay>>(() =>
                base.Get<List<PlayByPlay>>("/mlb/v2/{format}/PlayByPlayDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Play By Play Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="minutes">Only returns plays that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<PlayByPlay> GetPlayByPlayDelta(string date, string minutes)
        {
            return this.GetPlayByPlayDeltaAsync(date, minutes).Result;
        }

        /// <summary>
        /// Get Player Details by Active Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/mlb/v2/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Active
        /// </summary>
        public List<Player> GetPlayerDetailsByActive()
        {
            return this.GetPlayerDetailsByActiveAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Free Agents Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/mlb/v2/{format}/FreeAgents", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Free Agents
        /// </summary>
        public List<Player> GetPlayerDetailsByFreeAgents()
        {
            return this.GetPlayerDetailsByFreeAgentsAsync().Result;
        }

        /// <summary>
        /// Get Player Details by Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<Player> GetPlayerDetailsByPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/mlb/v2/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details by Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Player GetPlayerDetailsByPlayer(int playerid)
        {
            return this.GetPlayerDetailsByPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/mlb/v2/{format}/PlayerGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            return this.GetPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<PlayerGame> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGame>(() =>
                base.Get<PlayerGame>("/mlb/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Away Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonAwayStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonAwayStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Away Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonAwayStats(string season)
        {
            return this.GetPlayerSeasonAwayStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Home Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonHomeStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonHomeStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Home Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonHomeStats(string season)
        {
            return this.GetPlayerSeasonHomeStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Split Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="split">The desired split of stats. Currently, we support vs. Left/Right/Switch handed pitchers/hitters. Possible values are: <code>L</code>, <code>R</code> and <code>S</code></param>
        public Task<List<PlayerSeason>> GetPlayerSeasonSplitStatsAsync(string season, string split)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("split", split.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonSplitStats/{season}/{split}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Split Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="split">The desired split of stats. Currently, we support vs. Left/Right/Switch handed pitchers/hitters. Possible values are: <code>L</code>, <code>R</code> and <code>S</code></param>
        public List<PlayerSeason> GetPlayerSeasonSplitStats(string season, string split)
        {
            return this.GetPlayerSeasonSplitStatsAsync(season, split).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats By Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<PlayerSeason> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerSeason>(() =>
                base.Get<PlayerSeason>("/mlb/v2/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats By Player
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Player Season Stats Split By Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsSplitByTeamAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/PlayerSeasonStatsSplitByTeam/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats Split By Team
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsSplitByTeam(string season)
        {
            return this.GetPlayerSeasonStatsSplitByTeamAsync(season).Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<Player>> GetPlayersByTeamAsync(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/mlb/v2/{format}/Players/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<Player> GetPlayersByTeam(string team)
        {
            return this.GetPlayersByTeamAsync(team).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/mlb/v2/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/mlb/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Projected Player Season Stats (with ADP) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<PlayerSeasonProjection>> GetProjectedPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonProjection>>(() =>
                base.Get<List<PlayerSeasonProjection>>("/mlb/v2/{format}/PlayerSeasonProjectionStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Season Stats (with ADP)
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<PlayerSeasonProjection> GetProjectedPlayerSeasonStats(string season)
        {
            return this.GetProjectedPlayerSeasonStatsAsync(season).Result;
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
                base.Get<List<Game>>("/mlb/v2/{format}/Games/{season}", parameters)
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
                base.Get<List<Stadium>>("/mlb/v2/{format}/Stadiums", parameters)
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
                base.Get<List<Standing>>("/mlb/v2/{format}/Standings/{season}", parameters)
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
                base.Get<List<TeamGame>>("/mlb/v2/{format}/TeamGameStatsByDate/{date}", parameters)
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
        /// Get Team Hitting vs. Starting Pitcher Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public Task<List<PlayerSeason>> GetTeamHittingVsStartingPitcherAsync(int gameid, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/mlb/v2/{format}/TeamHittersVsPitcher/{gameid}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Team Hitting vs. Starting Pitcher
        /// </summary>
        /// <param name="gameid">The GameID of an MLB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
        /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
        public List<PlayerSeason> GetTeamHittingVsStartingPitcher(int gameid, string team)
        {
            return this.GetTeamHittingVsStartingPitcherAsync(gameid, team).Result;
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
                base.Get<List<TeamSeason>>("/mlb/v2/{format}/TeamSeasonStats/{season}", parameters)
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
        public Task<List<Team>> GetTeamsActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/mlb/v2/{format}/teams", parameters)
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
                base.Get<List<Team>>("/mlb/v2/{format}/AllTeams", parameters)
            );
        }

        /// <summary>
        /// Get Teams (All)
        /// </summary>
        public List<Team> GetTeamsAll()
        {
            return this.GetTeamsAllAsync().Result;
        }

    }
}

