using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3StatsClient : BaseClient
    {
        public NFLv3StatsClient(string apiKey) : base(apiKey) { }
        public NFLv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Are Games In Progress
        /// </summary>
        public bool GetAreAnyGamesInProgress()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<bool>("/v3/nfl/stats/{format}/AreAnyGamesInProgress", parameters);
        }

        /// <summary>
        /// Box Score by ScoreID V3
        /// </summary>
        /// <param name="scoreid">The ScoreID of the game. Possible values include: <code>16247</code>, <code>16245</code>, etc.</param>
        public BoxScoreV3 GetBoxScoreByScoreIDV3(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return base.Get<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreByScoreIDV3/{scoreid}", parameters);
        }

        /// <summary>
        /// Box Score V3
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of a team playing in this game. Example: <code>WAS</code>.</param>
        public BoxScoreV3 GetBoxScoreV3(string season, int week, string hometeam)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("hometeam", hometeam.ToString()));
            return base.Get<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreV3/{season}/{week}/{hometeam}", parameters);
        }

        /// <summary>
        /// Box Scores Delta V3
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerstoinclude">The subcategory of players to include in the returned PlayerGame records. Possible values include: <code>all</code> Returns all players <code>fantasy</code> Returns traditional fantasy players (QB, RB, WR, TE, K, DST) <code>idp</code> Returns traditional fantasy players and IDP players.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code>, etc.</param>
        public List<BoxScoreV3> GetBoxScoresDeltaV3(string season, int week, string playerstoinclude, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerstoinclude", playerstoinclude.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScoreV3>>("/v3/nfl/stats/{format}/BoxScoresDeltaV3/{season}/{week}/{playerstoinclude}/{minutes}", parameters);
        }

        /// <summary>
        /// Bye Weeks
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Bye> GetByes(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Bye>>("/v3/nfl/stats/{format}/Byes/{season}", parameters);
        }

        /// <summary>
        /// Daily Fantasy Players
        /// </summary>
        /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
        public List<DailyFantasyPlayer> GetDailyFantasyPlayers(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DailyFantasyPlayer>>("/v3/nfl/stats/{format}/DailyFantasyPlayers/{date}", parameters);
        }

        /// <summary>
        /// Daily Fantasy Scoring
        /// </summary>
        /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
        public List<DailyFantasyScoring> GetDailyFantasyPoints(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DailyFantasyScoring>>("/v3/nfl/stats/{format}/DailyFantasyPoints/{date}", parameters);
        }

        /// <summary>
        /// DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<DfsSlate>>("/v3/nfl/stats/{format}/DfsSlatesByDate/{date}", parameters);
        }

        /// <summary>
        /// DFS Slates by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<DfsSlate> GetDfsSlatesByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<DfsSlate>>("/v3/nfl/stats/{format}/DfsSlatesByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Fantasy Defense Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<FantasyDefenseGame> GetFantasyDefenseByGame(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<FantasyDefenseGame>>("/v3/nfl/stats/{format}/FantasyDefenseByGame/{season}/{week}", parameters);
        }

        /// <summary>
        /// Fantasy Defense Game Stats by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public FantasyDefenseGame GetFantasyDefenseByGameByTeam(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<FantasyDefenseGame>("/v3/nfl/stats/{format}/FantasyDefenseByGameByTeam/{season}/{week}/{team}", parameters);
        }

        /// <summary>
        /// Fantasy Defense Season Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<FantasyDefenseSeason> GetFantasyDefenseBySeason(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<FantasyDefenseSeason>>("/v3/nfl/stats/{format}/FantasyDefenseBySeason/{season}", parameters);
        }

        /// <summary>
        /// Fantasy Defense Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public FantasyDefenseSeason GetFantasyDefenseBySeasonByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<FantasyDefenseSeason>("/v3/nfl/stats/{format}/FantasyDefenseBySeasonByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Fantasy Player Ownership Percentages (Season-Long)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerOwnership> GetPlayerOwnership(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<PlayerOwnership>>("/v3/nfl/stats/{format}/PlayerOwnership/{season}/{week}", parameters);
        }

        /// <summary>
        /// Fantasy Players with ADP
        /// </summary>
        public List<FantasyPlayer> GetFantasyPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<FantasyPlayer>>("/v3/nfl/stats/{format}/FantasyPlayers", parameters);
        }

        /// <summary>
        /// Game Stats by Season (Deprecated, use Team Game Stats instead)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Game> GetGameStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Game>>("/v3/nfl/stats/{format}/GameStats/{season}", parameters);
        }

        /// <summary>
        /// Game Stats by Week (Deprecated, use Team Game Stats instead)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Game> GetGameStatsByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<Game>>("/v3/nfl/stats/{format}/GameStatsByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// IDP Fantasy Players with ADP
        /// </summary>
        public List<FantasyPlayer> GetFantasyPlayersIDP()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<FantasyPlayer>>("/v3/nfl/stats/{format}/FantasyPlayersIDP", parameters);
        }

        /// <summary>
        /// Injuries
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Injury> GetInjuries(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<Injury>>("/v3/nfl/stats/{format}/Injuries/{season}/{week}", parameters);
        }

        /// <summary>
        /// Injuries by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<Injury> GetInjuries(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<Injury>>("/v3/nfl/stats/{format}/Injuries/{season}/{week}/{team}", parameters);
        }

        /// <summary>
        /// League Leaders by Season
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="position">Player’s position that you would like to filter by.</param>
        /// <param name="column">Response member you would like results sorted by.</param>
        public List<PlayerSeason> GetSeasonLeagueLeaders(string season, string position, string column)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("position", position.ToString()));
            parameters.Add(new KeyValuePair<string, string>("column", column.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/SeasonLeagueLeaders/{season}/{position}/{column}", parameters);
        }

        /// <summary>
        /// League Leaders by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="position">Player’s position that you would like to filter by.</param>
        /// <param name="column">Response member you would like results sorted by.</param>
        public List<PlayerGame> GetGameLeagueLeaders(string season, int week, string position, string column)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("position", position.ToString()));
            parameters.Add(new KeyValuePair<string, string>("column", column.ToString()));
            return base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/GameLeagueLeaders/{season}/{week}/{position}/{column}", parameters);
        }

        /// <summary>
        /// Legacy Box Score
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of the home team. Example: <code>WAS</code>.</param>
        public BoxScore GetBoxScore(string season, int week, string hometeam)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("hometeam", hometeam.ToString()));
            return base.Get<BoxScore>("/v3/nfl/stats/{format}/BoxScore/{season}/{week}/{hometeam}", parameters);
        }

        /// <summary>
        /// Legacy Box Scores
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<BoxScore> GetBoxScores(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScores/{season}/{week}", parameters);
        }

        /// <summary>
        /// Legacy Box Scores Active
        /// </summary>
        public List<BoxScore> GetActiveBoxScores()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/ActiveBoxScores", parameters);
        }

        /// <summary>
        /// Legacy Box Scores Delta
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScoresDelta/{season}/{week}/{minutes}", parameters);
        }

        /// <summary>
        /// Legacy Box Scores Delta (Current Week)
        /// </summary>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetRecentlyUpdatedBoxScores(string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/RecentlyUpdatedBoxScores/{minutes}", parameters);
        }

        /// <summary>
        /// Legacy Box Scores Final
        /// </summary>
        public List<BoxScore> GetFinalBoxScores()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/FinalBoxScores", parameters);
        }

        /// <summary>
        /// Legacy Box Scores Live
        /// </summary>
        public List<BoxScore> GetLiveBoxScores()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/LiveBoxScores", parameters);
        }

        /// <summary>
        /// News
        /// </summary>
        public List<News> GetNews()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<News>>("/v3/nfl/stats/{format}/News", parameters);
        }

        /// <summary>
        /// News by Date
        /// </summary>
        /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
        public List<News> GetNewsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<News>>("/v3/nfl/stats/{format}/NewsByDate/{date}", parameters);
        }

        /// <summary>
        /// News by Player
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
        public List<News> GetNewsByPlayerID(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<News>>("/v3/nfl/stats/{format}/NewsByPlayerID/{playerid}", parameters);
        }

        /// <summary>
        /// News by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<News> GetNewsByTeam(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<News>>("/v3/nfl/stats/{format}/NewsByTeam/{team}", parameters);
        }

        /// <summary>
        /// Player Details by Available
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/nfl/stats/{format}/Players", parameters);
        }

        /// <summary>
        /// Player Details by Free Agents
        /// </summary>
        public List<Player> GetFreeAgents()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/nfl/stats/{format}/FreeAgents", parameters);
        }

        /// <summary>
        /// Player Details by Player
        /// </summary>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public PlayerDetail GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerDetail>("/v3/nfl/stats/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Details by Team
        /// </summary>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerDetail> GetPlayers(string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerDetail>>("/v3/nfl/stats/{format}/Players/{team}", parameters);
        }

        /// <summary>
        /// Player Game Red Zone Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameRedZone> GetPlayerGameRedZoneStats(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<PlayerGameRedZone>>("/v3/nfl/stats/{format}/PlayerGameRedZoneStats/{season}/{week}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayerID(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerGame>("/v3/nfl/stats/{format}/PlayerGameStatsByPlayerID/{season}/{week}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByTeam(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByTeam/{season}/{week}/{team}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGame> GetPlayerGameStatsByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Week Delta
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByWeekDelta(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByWeekDelta/{season}/{week}/{minutes}", parameters);
        }

        /// <summary>
        /// Player Game Stats Delta
        /// </summary>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsDelta(string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsDelta/{minutes}", parameters);
        }

        /// <summary>
        /// Player Season Red Zone Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonRedZone> GetPlayerSeasonRedZoneStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeasonRedZone>>("/v3/nfl/stats/{format}/PlayerSeasonRedZoneStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public PlayerSeason GetPlayerSeasonStatsByPlayerID(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<PlayerSeason>("/v3/nfl/stats/{format}/PlayerSeasonStatsByPlayerID/{season}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters);
        }

        /// <summary>
        /// Player Season Third Down Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonThirdDown> GetPlayerSeasonThirdDownStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerSeasonThirdDown>>("/v3/nfl/stats/{format}/PlayerSeasonThirdDownStats/{season}", parameters);
        }

        /// <summary>
        /// Schedule
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Schedule> GetSchedules(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Schedule>>("/v3/nfl/stats/{format}/Schedules/{season}", parameters);
        }

        /// <summary>
        /// Scores by Season 
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Score> GetScores(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Score>>("/v3/nfl/stats/{format}/Scores/{season}", parameters);
        }

        /// <summary>
        /// Scores by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Score> GetScoresByWeek(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<Score>>("/v3/nfl/stats/{format}/ScoresByWeek/{season}/{week}", parameters);
        }

        /// <summary>
        /// Season Current
        /// </summary>
        public int? GetCurrentSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/stats/{format}/CurrentSeason", parameters);
        }

        /// <summary>
        /// Season Last Completed
        /// </summary>
        public int? GetLastCompletedSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/stats/{format}/LastCompletedSeason", parameters);
        }

        /// <summary>
        /// Season Upcoming
        /// </summary>
        public int? GetUpcomingSeason()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/stats/{format}/UpcomingSeason", parameters);
        }

        /// <summary>
        /// Stadiums
        /// </summary>
        public List<Stadium> GetStadiums()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Stadium>>("/v3/nfl/stats/{format}/Stadiums", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Standing> GetStandings(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Standing>>("/v3/nfl/stats/{format}/Standings/{season}", parameters);
        }

        /// <summary>
        /// Team Game Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<TeamGame> GetTeamGameStats(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return base.Get<List<TeamGame>>("/v3/nfl/stats/{format}/TeamGameStats/{season}/{week}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<TeamSeason> GetTeamSeasonStats(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<TeamSeason>>("/v3/nfl/stats/{format}/TeamSeasonStats/{season}", parameters);
        }

        /// <summary>
        /// Teams (Active)
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/nfl/stats/{format}/Teams", parameters);
        }

        /// <summary>
        /// Teams (All)
        /// </summary>
        public List<Team> GetAllTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/nfl/stats/{format}/AllTeams", parameters);
        }

        /// <summary>
        /// Teams by Season
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<Team> GetTeams(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Team>>("/v3/nfl/stats/{format}/Teams/{season}", parameters);
        }

        /// <summary>
        /// Timeframes
        /// </summary>
        /// <param name="type">The type of timeframes to return. Valid entries are <code>current</code> or <code>upcoming</code> or <code>completed</code> or <code>recent</code> or <code>all</code>.</param>
        public List<Timeframe> GetTimeframes(string type)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("type", type.ToString()));
            return base.Get<List<Timeframe>>("/v3/nfl/stats/{format}/Timeframes/{type}", parameters);
        }

        /// <summary>
        /// Week Current
        /// </summary>
        public int? GetCurrentWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/stats/{format}/CurrentWeek", parameters);
        }

        /// <summary>
        /// Week Last Completed
        /// </summary>
        public int? GetLastCompletedWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/stats/{format}/LastCompletedWeek", parameters);
        }

        /// <summary>
        /// Week Upcoming
        /// </summary>
        public int? GetUpcomingWeek()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<int?>("/v3/nfl/stats/{format}/UpcomingWeek", parameters);
        }

        /// <summary>
        /// Pro Bowlers
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2016</code>, <code>2017</code></param>
        public List<PlayerInfo> GetProBowlers(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<PlayerInfo>>("/v3/nfl/stats/{format}/ProBowlers/{season}", parameters);
        }

    }
}

