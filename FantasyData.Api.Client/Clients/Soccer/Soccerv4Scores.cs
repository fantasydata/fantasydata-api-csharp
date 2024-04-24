using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv4ScoresClient : BaseClient
    {
        public Soccerv4ScoresClient(string apiKey) : base(apiKey) { }
        public Soccerv4ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Areas (Countries) Asynchronous
        /// </summary>
        public Task<List<Area>> GetAreasCountriesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Area>>(() =>
                base.Get<List<Area>>("/v4/soccer/scores/{format}/Areas", parameters)
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
        /// Get Canceled Memberships Asynchronous
        /// </summary>
        public Task<CanceledMembership> GetCanceledMembershipsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<CanceledMembership>(() =>
                base.Get<CanceledMembership>("/v4/soccer/scores/{format}/CanceledMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Canceled Memberships
        /// </summary>
        public CanceledMembership GetCanceledMemberships()
        {
            return this.GetCanceledMembershipsAsync().Result;
        }

        /// <summary>
        /// Get Competition Fixtures (League Details) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<CompetitionDetail> GetCompetitionFixturesLeagueDetailsAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<CompetitionDetail>(() =>
                base.Get<CompetitionDetail>("/v4/soccer/scores/{format}/CompetitionDetails/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Competition Fixtures (League Details)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public CompetitionDetail GetCompetitionFixturesLeagueDetails(string competition)
        {
            return this.GetCompetitionFixturesLeagueDetailsAsync(competition).Result;
        }

        /// <summary>
        /// Get Competitions (Leagues) Asynchronous
        /// </summary>
        public Task<List<Competition>> GetCompetitionsLeaguesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Competition>>(() =>
                base.Get<List<Competition>>("/v4/soccer/scores/{format}/Competitions", parameters)
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
        /// Get Games by Date - Legacy Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<Game>> GetGamesByDateLegacyAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v4/soccer/scores/{format}/GamesByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date - Legacy
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<Game> GetGamesByDateLegacy(string competition, string date)
        {
            return this.GetGamesByDateLegacyAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Memberships (Active) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<Membership>> GetMembershipsActiveAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v4/soccer/scores/{format}/ActiveMemberships/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Active)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<Membership> GetMembershipsActive(string competition)
        {
            return this.GetMembershipsActiveAsync(competition).Result;
        }

        /// <summary>
        /// Get Memberships (Recently Changed) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="days">The number of days since memberships were updated. For example, if you pass <code>3</code>, you'll receive all memberships that have been updated in the past 3 days. Valid entries are: <code>1</code>, <code>2</code> ... <code>30</code></param>
        public Task<List<Membership>> GetMembershipsRecentlyChangedAsync(string competition, string days)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("days", days.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v4/soccer/scores/{format}/RecentlyChangedMemberships/{competition}/{days}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Recently Changed)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="days">The number of days since memberships were updated. For example, if you pass <code>3</code>, you'll receive all memberships that have been updated in the past 3 days. Valid entries are: <code>1</code>, <code>2</code> ... <code>30</code></param>
        public List<Membership> GetMembershipsRecentlyChanged(string competition, string days)
        {
            return this.GetMembershipsRecentlyChangedAsync(competition, days).Result;
        }

        /// <summary>
        /// Get Memberships by Team (Historical) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Membership>> GetMembershipsByTeamHistoricalAsync(string competition, int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v4/soccer/scores/{format}/HistoricalMembershipsByTeam/{competition}/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Historical)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetMembershipsByTeamHistorical(string competition, int teamid)
        {
            return this.GetMembershipsByTeamHistoricalAsync(competition, teamid).Result;
        }

        /// <summary>
        /// Get Players by Team - Legacy Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Player>> GetPlayersByTeamLegacyAsync(string competition, int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v4/soccer/scores/{format}/PlayersByTeam/{competition}/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team - Legacy
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Player> GetPlayersByTeamLegacy(string competition, int teamid)
        {
            return this.GetPlayersByTeamLegacyAsync(competition, teamid).Result;
        }

        /// <summary>
        /// Get Schedule - Legacy Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<Round>> GetScheduleLegacyAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Round>>(() =>
                base.Get<List<Round>>("/v4/soccer/scores/{format}/Schedule/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule - Legacy
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<Round> GetScheduleLegacy(string competition, string season)
        {
            return this.GetScheduleLegacyAsync(competition, season).Result;
        }

        /// <summary>
        /// Get Season Teams Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<SeasonTeam>> GetSeasonTeamsAsync(string competition, int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<SeasonTeam>>(() =>
                base.Get<List<SeasonTeam>>("/v4/soccer/scores/{format}/SeasonTeams/{competition}/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Season Teams
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<SeasonTeam> GetSeasonTeams(string competition, int seasonid)
        {
            return this.GetSeasonTeamsAsync(competition, seasonid).Result;
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
                base.Get<List<Round>>("/v4/soccer/scores/{format}/Standings/{competition}/{season}", parameters)
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
        /// Get Team Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/v4/soccer/scores/{format}/TeamGameStatsByDate/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string competition, string date)
        {
            return this.GetTeamGameStatsByDateAsync(competition, date).Result;
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
                base.Get<List<Round>>("/v4/soccer/scores/{format}/TeamSeasonStats/{competition}/{season}", parameters)
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
        /// Get Teams Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<Team>> GetTeamsAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v4/soccer/scores/{format}/Teams/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Teams
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<Team> GetTeams(string competition)
        {
            return this.GetTeamsAsync(competition).Result;
        }

        /// <summary>
        /// Get Venues Asynchronous
        /// </summary>
        public Task<List<Venue>> GetVenuesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Venue>>(() =>
                base.Get<List<Venue>>("/v4/soccer/scores/{format}/Venues", parameters)
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
        /// Get Scores by Date Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<ScoreBasic>> GetScoresByDateAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<ScoreBasic>>(() =>
                base.Get<List<ScoreBasic>>("/v4/soccer/scores/{format}/ScoresBasic/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Scores by Date
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<ScoreBasic> GetScoresByDate(string competition, string date)
        {
            return this.GetScoresByDateAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<PlayerBasic>> GetPlayersByTeamAsync(string competition, int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<PlayerBasic>>(() =>
                base.Get<List<PlayerBasic>>("/v4/soccer/scores/{format}/PlayersByTeamBasic/{competition}/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<PlayerBasic> GetPlayersByTeam(string competition, int teamid)
        {
            return this.GetPlayersByTeamAsync(competition, teamid).Result;
        }

        /// <summary>
        /// Get Schedule Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public Task<List<ScheduleBasic>> GetScheduleAsync(string competition, string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<ScheduleBasic>>(() =>
                base.Get<List<ScheduleBasic>>("/v4/soccer/scores/{format}/SchedulesBasic/{competition}/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
        public List<ScheduleBasic> GetSchedule(string competition, string season)
        {
            return this.GetScheduleAsync(competition, season).Result;
        }

    }
}

