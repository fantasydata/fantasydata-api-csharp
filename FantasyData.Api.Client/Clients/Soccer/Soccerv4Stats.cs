using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv4StatsClient : BaseClient
    {
        public Soccerv4StatsClient(string apiKey) : base(apiKey) { }
        public Soccerv4StatsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Areas (Countries) Asynchronous
        /// </summary>
        public Task<List<Area>> GetAreasCountriesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Area>>(() =>
                base.Get<List<Area>>("/v4/soccer/stats/{format}/Areas", parameters)
            );
        }

        /// <summary>
        /// Get Areas (Countries)
        /// </summary>
        public List<Area> GetAreasCountries()
        {
            return this.GetAreasCountriesAsync().Result;
        }

        /// <summary>
        /// Get Box Score [Live & Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public Task<List<BoxScore>> GetBoxScoreLiveFinalAsync(string competition, int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v4/soccer/stats/{format}/BoxScore/{competition}/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Live & Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public List<BoxScore> GetBoxScoreLiveFinal(string competition, int gameid)
        {
            return this.GetBoxScoreLiveFinalAsync(competition, gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateLiveFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v4/soccer/stats/{format}/BoxScoresByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Live & Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateLiveFinal(string competition, string date)
        {
            return this.GetBoxScoresByDateLiveFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Box Scores Delta - by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaByDateAsync(string competition, string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v4/soccer/stats/{format}/BoxScoresDeltaByDate/{competition}/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Delta - by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDeltaByDate(string competition, string date, string minutes)
        {
            return this.GetBoxScoresDeltaByDateAsync(competition, date, minutes).Result;
        }

        /// <summary>
        /// Get Games - by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<CompetitionDetail> GetGamesByCompetitionAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<CompetitionDetail>(() =>
                base.Get<CompetitionDetail>("/v4/soccer/stats/{format}/CompetitionDetails/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public CompetitionDetail GetGamesByCompetition(string competition)
        {
            return this.GetGamesByCompetitionAsync(competition).Result;
        }

        /// <summary>
        /// Get Competitions (Leagues) Asynchronous
        /// </summary>
        public Task<List<Competition>> GetCompetitionsLeaguesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Competition>>(() =>
                base.Get<List<Competition>>("/v4/soccer/stats/{format}/Competitions", parameters)
            );
        }

        /// <summary>
        /// Get Competitions (Leagues)
        /// </summary>
        public List<Competition> GetCompetitionsLeagues()
        {
            return this.GetCompetitionsLeaguesAsync().Result;
        }

        /// <summary>
        /// Get DFS Slates - by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
        public Task<List<DfsSlate>> GetDFSSlatesByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v4/soccer/stats/{format}/DfsSlatesByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates - by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
        public List<DfsSlate> GetDFSSlatesByDate(string competition, string date)
        {
            return this.GetDFSSlatesByDateAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Games - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<Game>> GetGamesByDateLiveFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v4/soccer/stats/{format}/GamesByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games - by Date [Live & Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<Game> GetGamesByDateLiveFinal(string competition, string date)
        {
            return this.GetGamesByDateLiveFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Memberships - by Active Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<Membership>> GetMembershipsByActiveAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v4/soccer/stats/{format}/ActiveMemberships/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships - by Active
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<Membership> GetMembershipsByActive(string competition)
        {
            return this.GetMembershipsByActiveAsync(competition).Result;
        }

        /// <summary>
        /// Get Memberships - by Recently Changed Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="days">The number of days since memberships were updated. For example, if you pass <code>3</code>, you'll receive all memberships that have been updated in the past 3 days. Valid entries are: <code>1</code>, <code>2</code> ... <code>30</code></param>
        public Task<List<Membership>> GetMembershipsByRecentlyChangedAsync(string competition, string days)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("days", days.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v4/soccer/stats/{format}/RecentlyChangedMemberships/{competition}/{days}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships - by Recently Changed
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="days">The number of days since memberships were updated. For example, if you pass <code>3</code>, you'll receive all memberships that have been updated in the past 3 days. Valid entries are: <code>1</code>, <code>2</code> ... <code>30</code></param>
        public List<Membership> GetMembershipsByRecentlyChanged(string competition, string days)
        {
            return this.GetMembershipsByRecentlyChangedAsync(competition, days).Result;
        }

        /// <summary>
        /// Get Memberships Historical - By Team Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Membership>> GetMembershipsHistoricalByTeamAsync(string competition, int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v4/soccer/stats/{format}/HistoricalMembershipsByTeam/{competition}/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships Historical - By Team
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetMembershipsHistoricalByTeam(string competition, int teamid)
        {
            return this.GetMembershipsHistoricalByTeamAsync(competition, teamid).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateLiveFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v4/soccer/stats/{format}/PlayerGameStatsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDateLiveFinal(string competition, string date)
        {
            return this.GetPlayerGameStatsByDateLiveFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<Round>> GetPlayerSeasonStatsAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Round>>(() =>
                base.Get<List<Round>>("/v4/soccer/stats/{format}/PlayerSeasonStats/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<Round> GetPlayerSeasonStats(string competition, string season)
        {
            return this.GetPlayerSeasonStatsAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Player Details - by Team Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Player>> GetPlayerDetailsByTeamAsync(string competition, int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v4/soccer/stats/{format}/PlayersByTeam/{competition}/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Details - by Team
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Player> GetPlayerDetailsByTeam(string competition, int teamid)
        {
            return this.GetPlayerDetailsByTeamAsync(competition, teamid).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<Round>> GetSchedulesAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Round>>(() =>
                base.Get<List<Round>>("/v4/soccer/stats/{format}/Schedule/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<Round> GetSchedules(string competition, string season)
        {
            return this.GetSchedulesAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Team Profiles - by Season Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<SeasonTeam>> GetTeamProfilesBySeasonAsync(string competition, int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<SeasonTeam>>(() =>
                base.Get<List<SeasonTeam>>("/v4/soccer/stats/{format}/SeasonTeams/{competition}/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - by Season
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<SeasonTeam> GetTeamProfilesBySeason(string competition, int seasonid)
        {
            return this.GetTeamProfilesBySeasonAsync(competition, seasonid).Result;
        }

        /// <summary>
        /// Get Standings Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<Round>> GetStandingsAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Round>>(() =>
                base.Get<List<Round>>("/v4/soccer/stats/{format}/Standings/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<Round> GetStandings(string competition, string season)
        {
            return this.GetStandingsAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateLiveFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v4/soccer/stats/{format}/TeamGameStatsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Live & Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateLiveFinal(string competition, string date)
        {
            return this.GetTeamGameStatsByDateLiveFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<Round>> GetTeamSeasonStatsAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Round>>(() =>
                base.Get<List<Round>>("/v4/soccer/stats/{format}/TeamSeasonStats/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<Round> GetTeamSeasonStats(string competition, string season)
        {
            return this.GetTeamSeasonStatsAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Team Profiles - by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<Team>> GetTeamProfilesByCompetitionAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v4/soccer/stats/{format}/Teams/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Team Profiles - by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<Team> GetTeamProfilesByCompetition(string competition)
        {
            return this.GetTeamProfilesByCompetitionAsync(competition).Result;
        }

        /// <summary>
        /// Get Upcoming DFS Slates - by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<DfsSlate>> GetUpcomingDFSSlatesByCompetitionAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v4/soccer/stats/{format}/UpcomingDfsSlatesByCompetition/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Upcoming DFS Slates - by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<DfsSlate> GetUpcomingDFSSlatesByCompetition(string competition)
        {
            return this.GetUpcomingDFSSlatesByCompetitionAsync(competition).Result;
        }

        /// <summary>
        /// Get Venues Asynchronous
        /// </summary>
        public Task<List<Venue>> GetVenuesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Venue>>(() =>
                base.Get<List<Venue>>("/v4/soccer/stats/{format}/Venues", parameters)
            );
        }

        /// <summary>
        /// Get Venues
        /// </summary>
        public List<Venue> GetVenues()
        {
            return this.GetVenuesAsync().Result;
        }

        /// <summary>
        /// Get Box Score [Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public Task<List<BoxScore>> GetBoxScoreFinalAsync(string competition, int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v4/soccer/stats/{format}/BoxScoreFinal/{competition}/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score [Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public List<BoxScore> GetBoxScoreFinal(string competition, int gameid)
        {
            return this.GetBoxScoreFinalAsync(competition, gameid).Result;
        }

        /// <summary>
        /// Get Box Scores - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByDateFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/v4/soccer/stats/{format}/BoxScoresFinal/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores - by Date [Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<BoxScore> GetBoxScoresByDateFinal(string competition, string date)
        {
            return this.GetBoxScoresByDateFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Lineups - by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGameBasic>> GetLineupsByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameBasic>>(() =>
                base.Get<List<PlayerGameBasic>>("/v4/soccer/stats/{format}/LineupsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Lineups - by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGameBasic> GetLineupsByDate(string competition, string date)
        {
            return this.GetLineupsByDateAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/v4/soccer/stats/{format}/PlayerGameStatsByDateFinal/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats - by Date [Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDateFinal(string competition, string date)
        {
            return this.GetPlayerGameStatsByDateFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final] Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateFinalAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v4/soccer/stats/{format}/TeamGameStatsByDateFinal/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats - by Date [Final]
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDateFinal(string competition, string date)
        {
            return this.GetTeamGameStatsByDateFinalAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Fantasy Points - by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<FantasyGame>> GetFantasyPointsByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<FantasyGame>>(() =>
                base.Get<List<FantasyGame>>("/v4/soccer/stats/{format}/FantasyGameStatsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Points - by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<FantasyGame> GetFantasyPointsByDate(string competition, string date)
        {
            return this.GetFantasyPointsByDateAsync(competition, date).Result;
        }

    }
}

