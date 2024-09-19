using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client
{
    public partial class NFLv3StatsClient : BaseClient
    {
        public NFLv3StatsClient(string apiKey) : base(apiKey) { }
        public NFLv3StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Are Games In Progress Asynchronous
        /// </summary>
        public Task<bool> GetAreGamesInProgressAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<bool>(() =>
                base.Get<bool>("/v3/nfl/stats/{format}/AreAnyGamesInProgress", parameters)
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
        /// <param name="scoreid">The ScoreID of the game. Possible values include: <code>16247</code>, <code>16245</code>, etc.</param>
        public Task<BoxScoreV3> GetBoxScoreLiveFinalAsync(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return Task.Run<BoxScoreV3>(() =>
                base.Get<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreByScoreIDV3/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Live & Final]
        /// </summary>
        /// <param name="scoreid">The ScoreID of the game. Possible values include: <code>16247</code>, <code>16245</code>, etc.</param>
        public BoxScoreV3 GetBoxScoreLiveFinal(int scoreid)
        {
            return this.GetBoxScoreLiveFinalAsync(scoreid).Result;
        }

        /// <summary>
        /// Get Box Score - by Team [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of a team playing in this game. Example: <code>WAS</code>.</param>
        public Task<BoxScoreV3> GetBoxScoreByTeamLiveFinalAsync(string season, int week, string hometeam)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("hometeam", hometeam.ToString()));
            return Task.Run<BoxScoreV3>(() =>
                base.Get<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreV3/{season}/{week}/{hometeam}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score - by Team [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of a team playing in this game. Example: <code>WAS</code>.</param>
        public BoxScoreV3 GetBoxScoreByTeamLiveFinal(string season, int week, string hometeam)
        {
            return this.GetBoxScoreByTeamLiveFinalAsync(season, week, hometeam).Result;
        }

        /// <summary>
        /// Get Box Scores Delta - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerstoinclude">The subcategory of players to include in the returned PlayerGame records. Possible values include: <code>all</code> Returns all players <code>fantasy</code> Returns traditional fantasy players (QB, RB, WR, TE, K, DST) <code>idp</code> Returns traditional fantasy players and IDP players.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code>, etc.</param>
        public Task<List<BoxScoreV3>> GetBoxScoresDeltaByWeekAsync(string season, int week, string playerstoinclude, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerstoinclude", playerstoinclude.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScoreV3>>(() =>
                base.Get<List<BoxScoreV3>>("/v3/nfl/stats/{format}/BoxScoresDeltaV3/{season}/{week}/{playerstoinclude}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Delta - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerstoinclude">The subcategory of players to include in the returned PlayerGame records. Possible values include: <code>all</code> Returns all players <code>fantasy</code> Returns traditional fantasy players (QB, RB, WR, TE, K, DST) <code>idp</code> Returns traditional fantasy players and IDP players.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code>, etc.</param>
        public List<BoxScoreV3> GetBoxScoresDeltaByWeek(string season, int week, string playerstoinclude, string minutes)
        {
            return this.GetBoxScoresDeltaByWeekAsync(season, week, playerstoinclude, minutes).Result;
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
                base.Get<List<Bye>>("/v3/nfl/stats/{format}/Byes/{season}", parameters)
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
        /// Get Daily Fantasy Players Asynchronous
        /// </summary>
        /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
        public Task<List<DailyFantasyPlayer>> GetDailyFantasyPlayersAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DailyFantasyPlayer>>(() =>
                base.Get<List<DailyFantasyPlayer>>("/v3/nfl/stats/{format}/DailyFantasyPlayers/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Daily Fantasy Players
        /// </summary>
        /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
        public List<DailyFantasyPlayer> GetDailyFantasyPlayers(string date)
        {
            return this.GetDailyFantasyPlayersAsync(date).Result;
        }

        /// <summary>
        /// Get Daily Fantasy Scoring Asynchronous
        /// </summary>
        /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
        public Task<List<DailyFantasyScoring>> GetDailyFantasyScoringAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DailyFantasyScoring>>(() =>
                base.Get<List<DailyFantasyScoring>>("/v3/nfl/stats/{format}/DailyFantasyPoints/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Daily Fantasy Scoring
        /// </summary>
        /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
        public List<DailyFantasyScoring> GetDailyFantasyScoring(string date)
        {
            return this.GetDailyFantasyScoringAsync(date).Result;
        }

        /// <summary>
        /// Get DFS Slates - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/nfl/stats/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Date
        /// </summary>
        /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
        public List<DfsSlate> GetDFSSlatesByDate(string date)
        {
            return this.GetDFSSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get DFS Slates - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<DfsSlate>> GetDFSSlatesByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/nfl/stats/{format}/DfsSlatesByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<DfsSlate> GetDFSSlatesByWeek(string season, int week)
        {
            return this.GetDFSSlatesByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Fantasy Defense Game Stats - All Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<FantasyDefenseGame>> GetFantasyDefenseGameStatsAllAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<FantasyDefenseGame>>(() =>
                base.Get<List<FantasyDefenseGame>>("/v3/nfl/stats/{format}/FantasyDefenseByGame/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Defense Game Stats - All
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<FantasyDefenseGame> GetFantasyDefenseGameStatsAll(string season, int week)
        {
            return this.GetFantasyDefenseGameStatsAllAsync(season, week).Result;
        }

        /// <summary>
        /// Get Fantasy Defense Game Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<FantasyDefenseGame> GetFantasyDefenseGameStatsByTeamAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<FantasyDefenseGame>(() =>
                base.Get<FantasyDefenseGame>("/v3/nfl/stats/{format}/FantasyDefenseByGameByTeam/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Defense Game Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public FantasyDefenseGame GetFantasyDefenseGameStatsByTeam(string season, int week, string team)
        {
            return this.GetFantasyDefenseGameStatsByTeamAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get Fantasy Defense Season Stats - All Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<FantasyDefenseSeason>> GetFantasyDefenseSeasonStatsAllAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<FantasyDefenseSeason>>(() =>
                base.Get<List<FantasyDefenseSeason>>("/v3/nfl/stats/{format}/FantasyDefenseBySeason/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Defense Season Stats - All
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<FantasyDefenseSeason> GetFantasyDefenseSeasonStatsAll(string season)
        {
            return this.GetFantasyDefenseSeasonStatsAllAsync(season).Result;
        }

        /// <summary>
        /// Get Fantasy Defense Season Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<FantasyDefenseSeason> GetFantasyDefenseSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<FantasyDefenseSeason>(() =>
                base.Get<FantasyDefenseSeason>("/v3/nfl/stats/{format}/FantasyDefenseBySeasonByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Defense Season Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public FantasyDefenseSeason GetFantasyDefenseSeasonStatsByTeam(string season, string team)
        {
            return this.GetFantasyDefenseSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Fantasy Player Ownership Percentages (Season-Long) - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerOwnership>> GetFantasyPlayerOwnershipPercentagesSeasonLongByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerOwnership>>(() =>
                base.Get<List<PlayerOwnership>>("/v3/nfl/stats/{format}/PlayerOwnership/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Player Ownership Percentages (Season-Long) - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerOwnership> GetFantasyPlayerOwnershipPercentagesSeasonLongByWeek(string season, int week)
        {
            return this.GetFantasyPlayerOwnershipPercentagesSeasonLongByWeekAsync(season, week).Result;
        }

        /// <summary>
        /// Get Fantasy Players - with ADP Asynchronous
        /// </summary>
        public Task<List<FantasyPlayer>> GetFantasyPlayersWithADPAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<FantasyPlayer>>(() =>
                base.Get<List<FantasyPlayer>>("/v3/nfl/stats/{format}/FantasyPlayers", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Players - with ADP
        /// </summary>
        public List<FantasyPlayer> GetFantasyPlayersWithADP()
        {
            return this.GetFantasyPlayersWithADPAsync().Result;
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
                base.Get<List<Game>>("/v3/nfl/stats/{format}/GameStats/{season}", parameters)
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
                base.Get<List<Game>>("/v3/nfl/stats/{format}/GameStatsByWeek/{season}/{week}", parameters)
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
        /// Get IDP Fantasy Players with ADP Asynchronous
        /// </summary>
        public Task<List<FantasyPlayer>> GetIDPFantasyPlayersWithADPAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<FantasyPlayer>>(() =>
                base.Get<List<FantasyPlayer>>("/v3/nfl/stats/{format}/FantasyPlayersIDP", parameters)
            );
        }

        /// <summary>
        /// Get IDP Fantasy Players with ADP
        /// </summary>
        public List<FantasyPlayer> GetIDPFantasyPlayersWithADP()
        {
            return this.GetIDPFantasyPlayersWithADPAsync().Result;
        }

        /// <summary>
        /// Get Injuries - All Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<Injury>> GetInjuriesAllAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<Injury>>(() =>
                base.Get<List<Injury>>("/v3/nfl/stats/{format}/Injuries/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Injuries - All
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<Injury> GetInjuriesAll(string season, int week)
        {
            return this.GetInjuriesAllAsync(season, week).Result;
        }

        /// <summary>
        /// Get Injuries - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<Injury>> GetInjuriesByTeamAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<Injury>>(() =>
                base.Get<List<Injury>>("/v3/nfl/stats/{format}/Injuries/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Injuries - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<Injury> GetInjuriesByTeam(string season, int week, string team)
        {
            return this.GetInjuriesByTeamAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get League Leaders by Season Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="position">Player’s position that you would like to filter by.</param>
        /// <param name="column">Response member you would like results sorted by.</param>
        public Task<List<PlayerSeason>> GetLeagueLeadersBySeasonAsync(string season, string position, string column)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("position", position.ToString()));
            parameters.Add(new KeyValuePair<string, string>("column", column.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/SeasonLeagueLeaders/{season}/{position}/{column}", parameters)
            );
        }

        /// <summary>
        /// Get League Leaders by Season
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="position">Player’s position that you would like to filter by.</param>
        /// <param name="column">Response member you would like results sorted by.</param>
        public List<PlayerSeason> GetLeagueLeadersBySeason(string season, string position, string column)
        {
            return this.GetLeagueLeadersBySeasonAsync(season, position, column).Result;
        }

        /// <summary>
        /// Get League Leaders by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="position">Player’s position that you would like to filter by.</param>
        /// <param name="column">Response member you would like results sorted by.</param>
        public Task<List<PlayerGame>> GetLeagueLeadersByWeekAsync(string season, int week, string position, string column)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("position", position.ToString()));
            parameters.Add(new KeyValuePair<string, string>("column", column.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/GameLeagueLeaders/{season}/{week}/{position}/{column}", parameters)
            );
        }

        /// <summary>
        /// Get League Leaders by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="position">Player’s position that you would like to filter by.</param>
        /// <param name="column">Response member you would like results sorted by.</param>
        public List<PlayerGame> GetLeagueLeadersByWeek(string season, int week, string position, string column)
        {
            return this.GetLeagueLeadersByWeekAsync(season, week, position, column).Result;
        }

        /// <summary>
        /// Get Legacy Box Score Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of the home team. Example: <code>WAS</code>.</param>
        public Task<BoxScore> GetLegacyBoxScoreAsync(string season, int week, string hometeam)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("hometeam", hometeam.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/v3/nfl/stats/{format}/BoxScore/{season}/{week}/{hometeam}", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Score
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of the home team. Example: <code>WAS</code>.</param>
        public BoxScore GetLegacyBoxScore(string season, int week, string hometeam)
        {
            return this.GetLegacyBoxScoreAsync(season, week, hometeam).Result;
        }

        /// <summary>
        /// Get Legacy Box Scores Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<BoxScore>> GetLegacyBoxScoresAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScores/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Scores
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<BoxScore> GetLegacyBoxScores(string season, int week)
        {
            return this.GetLegacyBoxScoresAsync(season, week).Result;
        }

        /// <summary>
        /// Get Legacy Box Scores Active Asynchronous
        /// </summary>
        public Task<List<BoxScore>> GetLegacyBoxScoresActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/ActiveBoxScores", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Scores Active
        /// </summary>
        public List<BoxScore> GetLegacyBoxScoresActive()
        {
            return this.GetLegacyBoxScoresActiveAsync().Result;
        }

        /// <summary>
        /// Get Legacy Box Scores Delta Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public Task<List<BoxScore>> GetLegacyBoxScoresDeltaAsync(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScoresDelta/{season}/{week}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Scores Delta
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetLegacyBoxScoresDelta(string season, int week, string minutes)
        {
            return this.GetLegacyBoxScoresDeltaAsync(season, week, minutes).Result;
        }

        /// <summary>
        /// Get Legacy Box Scores Delta (Current Week) Asynchronous
        /// </summary>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public Task<List<BoxScore>> GetLegacyBoxScoresDeltaCurrentWeekAsync(string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/RecentlyUpdatedBoxScores/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Scores Delta (Current Week)
        /// </summary>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<BoxScore> GetLegacyBoxScoresDeltaCurrentWeek(string minutes)
        {
            return this.GetLegacyBoxScoresDeltaCurrentWeekAsync(minutes).Result;
        }

        /// <summary>
        /// Get Legacy Box Scores Final Asynchronous
        /// </summary>
        public Task<List<BoxScore>> GetLegacyBoxScoresFinalAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/FinalBoxScores", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Scores Final
        /// </summary>
        public List<BoxScore> GetLegacyBoxScoresFinal()
        {
            return this.GetLegacyBoxScoresFinalAsync().Result;
        }

        /// <summary>
        /// Get Legacy Box Scores Live Asynchronous
        /// </summary>
        public Task<List<BoxScore>> GetLegacyBoxScoresLiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v3/nfl/stats/{format}/LiveBoxScores", parameters)
            );
        }

        /// <summary>
        /// Get Legacy Box Scores Live
        /// </summary>
        public List<BoxScore> GetLegacyBoxScoresLive()
        {
            return this.GetLegacyBoxScoresLiveAsync().Result;
        }

        /// <summary>
        /// Get News Asynchronous
        /// </summary>
        public Task<List<News>> GetNewsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<News>>(() =>
                base.Get<List<News>>("/v3/nfl/stats/{format}/News", parameters)
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
                base.Get<List<News>>("/v3/nfl/stats/{format}/NewsByDate/{date}", parameters)
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
                base.Get<List<News>>("/v3/nfl/stats/{format}/NewsByPlayerID/{playerid}", parameters)
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
                base.Get<List<News>>("/v3/nfl/stats/{format}/NewsByTeam/{team}", parameters)
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
        /// Get Player Details - by Available Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByAvailableAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/stats/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Available
        /// </summary>
        public List<Player> GetPlayerDetailsByAvailable()
        {
            return this.GetPlayerDetailsByAvailableAsync().Result;
        }

        /// <summary>
        /// Get Player Details - by Free Agents Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerDetailsByFreeAgentsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/nfl/stats/{format}/FreeAgents", parameters)
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
                base.Get<PlayerDetail>("/v3/nfl/stats/{format}/Player/{playerid}", parameters)
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
                base.Get<List<PlayerDetail>>("/v3/nfl/stats/{format}/Players/{team}", parameters)
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
        /// Get Player Game Red Zone Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGameRedZone>> GetPlayerGameRedZoneStatsAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameRedZone>>(() =>
                base.Get<List<PlayerGameRedZone>>("/v3/nfl/stats/{format}/PlayerGameRedZoneStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Red Zone Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameRedZone> GetPlayerGameRedZoneStats(string season, int week)
        {
            return this.GetPlayerGameRedZoneStatsAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<PlayerGame> GetPlayerGameStatsByPlayerAsync(string season, int week, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGame>(() =>
                base.Get<PlayerGame>("/v3/nfl/stats/{format}/PlayerGameStatsByPlayerID/{season}/{week}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public PlayerGame GetPlayerGameStatsByPlayer(string season, int week, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerAsync(season, week, playerid).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Team [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByTeamLiveFinalAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByTeam/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Team [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByTeamLiveFinal(string season, int week, string team)
        {
            return this.GetPlayerGameStatsByTeamLiveFinalAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByWeekLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGame> GetPlayerGameStatsByWeekLiveFinal(string season, int week)
        {
            return this.GetPlayerGameStatsByWeekLiveFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Game Stats Delta - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsDeltaByWeekAsync(string season, int week, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByWeekDelta/{season}/{week}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats Delta - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsDeltaByWeek(string season, int week, string minutes)
        {
            return this.GetPlayerGameStatsDeltaByWeekAsync(season, week, minutes).Result;
        }

        /// <summary>
        /// Get Player Game Stats Delta Asynchronous
        /// </summary>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsDeltaAsync(string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsDelta/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats Delta
        /// </summary>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsDelta(string minutes)
        {
            return this.GetPlayerGameStatsDeltaAsync(minutes).Result;
        }

        /// <summary>
        /// Get Player Season Red Zone Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<PlayerSeasonRedZone>> GetPlayerSeasonRedZoneStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonRedZone>>(() =>
                base.Get<List<PlayerSeasonRedZone>>("/v3/nfl/stats/{format}/PlayerSeasonRedZoneStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Red Zone Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonRedZone> GetPlayerSeasonRedZoneStats(string season)
        {
            return this.GetPlayerSeasonRedZoneStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStats(string season)
        {
            return this.GetPlayerSeasonStatsAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Player Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStatsByPlayerID/{season}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Player
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByPlayer(string season, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(season, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats - by Team Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats - by Team
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(string season, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(season, team).Result;
        }

        /// <summary>
        /// Get Player Season Third Down Stats Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<PlayerSeasonThirdDown>> GetPlayerSeasonThirdDownStatsAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonThirdDown>>(() =>
                base.Get<List<PlayerSeasonThirdDown>>("/v3/nfl/stats/{format}/PlayerSeasonThirdDownStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Third Down Stats
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonThirdDown> GetPlayerSeasonThirdDownStats(string season)
        {
            return this.GetPlayerSeasonThirdDownStatsAsync(season).Result;
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
                base.Get<List<Schedule>>("/v3/nfl/stats/{format}/Schedules/{season}", parameters)
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
                base.Get<List<Score>>("/v3/nfl/stats/{format}/Scores/{season}", parameters)
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
                base.Get<List<Score>>("/v3/nfl/stats/{format}/ScoresByWeek/{season}/{week}", parameters)
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
                base.Get<int?>("/v3/nfl/stats/{format}/CurrentSeason", parameters)
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
                base.Get<int?>("/v3/nfl/stats/{format}/LastCompletedSeason", parameters)
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
                base.Get<int?>("/v3/nfl/stats/{format}/UpcomingSeason", parameters)
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
                base.Get<List<Stadium>>("/v3/nfl/stats/{format}/Stadiums", parameters)
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
                base.Get<List<Standing>>("/v3/nfl/stats/{format}/Standings/{season}", parameters)
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
        /// Get Team Game Stats - by Game [Live & Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<TeamGame>> GetTeamGameStatsByGameLiveFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nfl/stats/{format}/TeamGameStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Game [Live & Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<TeamGame> GetTeamGameStatsByGameLiveFinal(string season, int week)
        {
            return this.GetTeamGameStatsByGameLiveFinalAsync(season, week).Result;
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
                base.Get<List<TeamSeason>>("/v3/nfl/stats/{format}/TeamSeasonStats/{season}", parameters)
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
                base.Get<List<Team>>("/v3/nfl/stats/{format}/Teams", parameters)
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
                base.Get<List<Team>>("/v3/nfl/stats/{format}/AllTeams", parameters)
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
                base.Get<List<Team>>("/v3/nfl/stats/{format}/Teams/{season}", parameters)
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
                base.Get<List<Timeframe>>("/v3/nfl/stats/{format}/Timeframes/{type}", parameters)
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
                base.Get<int?>("/v3/nfl/stats/{format}/CurrentWeek", parameters)
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
                base.Get<int?>("/v3/nfl/stats/{format}/LastCompletedWeek", parameters)
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
                base.Get<int?>("/v3/nfl/stats/{format}/UpcomingWeek", parameters)
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
        /// Get Pro Bowlers Asynchronous
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2016</code>, <code>2017</code></param>
        public Task<List<PlayerInfo>> GetProBowlersAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerInfo>>(() =>
                base.Get<List<PlayerInfo>>("/v3/nfl/stats/{format}/ProBowlers/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Pro Bowlers
        /// </summary>
        /// <param name="season">Year of the season Examples: <code>2016</code>, <code>2017</code></param>
        public List<PlayerInfo> GetProBowlers(string season)
        {
            return this.GetProBowlersAsync(season).Result;
        }

        /// <summary>
        /// Get Box Scores Simulation Asynchronous
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public Task<List<BoxScoreV3>> GetBoxScoresSimulationAsync(string numberofplays)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("numberofplays", numberofplays.ToString()));
            return Task.Run<List<BoxScoreV3>>(() =>
                base.Get<List<BoxScoreV3>>("/v3/nfl/stats/{format}/SimulatedBoxScoresV3/{numberofplays}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Simulation
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public List<BoxScoreV3> GetBoxScoresSimulation(string numberofplays)
        {
            return this.GetBoxScoresSimulationAsync(numberofplays).Result;
        }

        /// <summary>
        /// Get Games by Week Simulation (formerly Scores by Week Simulation) Asynchronous
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public Task<List<Score>> GetGamesByWeekSimulationFormerlyScoresByWeekSimulationAsync(string numberofplays)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("numberofplays", numberofplays.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/stats/{format}/SimulatedScores/{numberofplays}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Week Simulation (formerly Scores by Week Simulation)
        /// </summary>
        /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
        public List<Score> GetGamesByWeekSimulationFormerlyScoresByWeekSimulation(string numberofplays)
        {
            return this.GetGamesByWeekSimulationFormerlyScoresByWeekSimulationAsync(numberofplays).Result;
        }

        /// <summary>
        /// Get Player Game Red Zone Stats (Inside Five) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGameRedZone>> GetPlayerGameRedZoneStatsInsideFiveAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameRedZone>>(() =>
                base.Get<List<PlayerGameRedZone>>("/v3/nfl/stats/{format}/PlayerGameRedZoneInsideFiveStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Red Zone Stats (Inside Five)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameRedZone> GetPlayerGameRedZoneStatsInsideFive(string season, int week)
        {
            return this.GetPlayerGameRedZoneStatsInsideFiveAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Game Red Zone Stats (Inside Ten) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGameRedZone>> GetPlayerGameRedZoneStatsInsideTenAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGameRedZone>>(() =>
                base.Get<List<PlayerGameRedZone>>("/v3/nfl/stats/{format}/PlayerGameRedZoneInsideTenStats/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Red Zone Stats (Inside Ten)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGameRedZone> GetPlayerGameRedZoneStatsInsideTen(string season, int week)
        {
            return this.GetPlayerGameRedZoneStatsInsideTenAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Season Red Zone Stats (Inside Five) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<PlayerSeasonRedZone>> GetPlayerSeasonRedZoneStatsInsideFiveAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonRedZone>>(() =>
                base.Get<List<PlayerSeasonRedZone>>("/v3/nfl/stats/{format}/PlayerSeasonRedZoneInsideFiveStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Red Zone Stats (Inside Five)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonRedZone> GetPlayerSeasonRedZoneStatsInsideFive(string season)
        {
            return this.GetPlayerSeasonRedZoneStatsInsideFiveAsync(season).Result;
        }

        /// <summary>
        /// Get Player Season Red Zone Stats (Inside Ten) Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public Task<List<PlayerSeasonRedZone>> GetPlayerSeasonRedZoneStatsInsideTenAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<PlayerSeasonRedZone>>(() =>
                base.Get<List<PlayerSeasonRedZone>>("/v3/nfl/stats/{format}/PlayerSeasonRedZoneInsideTenStats/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Red Zone Stats (Inside Ten)
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        public List<PlayerSeasonRedZone> GetPlayerSeasonRedZoneStatsInsideTen(string season)
        {
            return this.GetPlayerSeasonRedZoneStatsInsideTenAsync(season).Result;
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
                base.Get<List<Player>>("/v3/nfl/stats/{format}/Rookies/{season}", parameters)
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
        /// Get Player Game Logs - by Season Asynchronous
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>17920</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public Task<List<PlayerGame>> GetPlayerGameLogsBySeasonAsync(string season, int playerid, string numberofgames)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("numberofgames", numberofgames.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>17920</code>.</param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<PlayerGame> GetPlayerGameLogsBySeason(string season, int playerid, string numberofgames)
        {
            return this.GetPlayerGameLogsBySeasonAsync(season, playerid, numberofgames).Result;
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
                base.Get<List<Score>>("/v3/nfl/stats/{format}/ScoresByDate/{date}", parameters)
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
        /// Get Team Game Logs - by Season Asynchronous
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
                base.Get<List<TeamGame>>("/v3/nfl/stats/{format}/TeamGameStatsBySeason/{season}/{teamid}/{numberofgames}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Logs - by Season
        /// </summary>
        /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
        /// <param name="teamid">Unique ID of team. Example <code> 8 </code></param>
        /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
        public List<TeamGame> GetTeamGameLogsBySeason(string season, int teamid, string numberofgames)
        {
            return this.GetTeamGameLogsBySeasonAsync(season, teamid, numberofgames).Result;
        }

        /// <summary>
        /// Get Box Score [Final] Asynchronous
        /// </summary>
        /// <param name="scoreid">The ScoreID of the game. Possible values include: <code>16247</code>, <code>16245</code>, etc.</param>
        public Task<BoxScoreV3> GetBoxScoreFinalAsync(int scoreid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("scoreid", scoreid.ToString()));
            return Task.Run<BoxScoreV3>(() =>
                base.Get<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreFinal/{scoreid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Final]
        /// </summary>
        /// <param name="scoreid">The ScoreID of the game. Possible values include: <code>16247</code>, <code>16245</code>, etc.</param>
        public BoxScoreV3 GetBoxScoreFinal(int scoreid)
        {
            return this.GetBoxScoreFinalAsync(scoreid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<BoxScoreV3>> GetBoxScoresByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<BoxScoreV3>>(() =>
                base.Get<List<BoxScoreV3>>("/v3/nfl/stats/{format}/BoxScoresFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<BoxScoreV3> GetBoxScoresByWeekFinal(string season, int week)
        {
            return this.GetBoxScoresByWeekFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByWeekFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByWeekFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Week [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<PlayerGame> GetPlayerGameStatsByWeekFinal(string season, int week)
        {
            return this.GetPlayerGameStatsByWeekFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Game [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<TeamGame>> GetTeamGameStatsByGameFinalAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v3/nfl/stats/{format}/TeamGameStatsFinal/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Game [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<TeamGame> GetTeamGameStatsByGameFinal(string season, int week)
        {
            return this.GetTeamGameStatsByGameFinalAsync(season, week).Result;
        }

        /// <summary>
        /// Get Games - by Season [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public Task<List<Score>> GetGamesBySeasonFinalAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Score>>(() =>
                base.Get<List<Score>>("/v3/nfl/stats/{format}/ScoresFinal/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Season [Final]
        /// </summary>
        /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
        public List<Score> GetGamesBySeasonFinal(string season)
        {
            return this.GetGamesBySeasonFinalAsync(season).Result;
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
                base.Get<List<Score>>("/v3/nfl/stats/{format}/ScoresByWeekFinal/{season}/{week}", parameters)
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

        /// <summary>
        /// Get Player Game Stats - by Team [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByTeamFinalAsync(string season, int week, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByTeamFinal/{season}/{week}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Team [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByTeamFinal(string season, int week, string team)
        {
            return this.GetPlayerGameStatsByTeamFinalAsync(season, week, team).Result;
        }

        /// <summary>
        /// Get Box Score - by Team [Final] Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of a team playing in this game. Example: <code>WAS</code>.</param>
        public Task<BoxScoreV3> GetBoxScoreByTeamFinalAsync(string season, int week, string hometeam)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            parameters.Add(new KeyValuePair<string, string>("hometeam", hometeam.ToString()));
            return Task.Run<BoxScoreV3>(() =>
                base.Get<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreByTeamFinal/{season}/{week}/{hometeam}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score - by Team [Final]
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        /// <param name="hometeam">Abbreviation of a team playing in this game. Example: <code>WAS</code>.</param>
        public BoxScoreV3 GetBoxScoreByTeamFinal(string season, int week, string hometeam)
        {
            return this.GetBoxScoreByTeamFinalAsync(season, week, hometeam).Result;
        }

        /// <summary>
        /// Get Fantasy Points - by Week Asynchronous
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public Task<List<FantasyGame>> GetFantasyPointsByWeekAsync(string season, int week)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            parameters.Add(new KeyValuePair<string, string>("week", week.ToString()));
            return Task.Run<List<FantasyGame>>(() =>
                base.Get<List<FantasyGame>>("/v3/nfl/stats/{format}/FantasyGameStatsByWeek/{season}/{week}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Points - by Week
        /// </summary>
        /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
        /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
        public List<FantasyGame> GetFantasyPointsByWeek(string season, int week)
        {
            return this.GetFantasyPointsByWeekAsync(season, week).Result;
        }

    }
}

