using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Lol;

namespace FantasyData.Api.Client
{
    public partial class Lolv3ScoresClient : BaseClient
    {
        public Lolv3ScoresClient(string apiKey) : base(apiKey) { }
        public Lolv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Areas (Countries) Asynchronous
        /// </summary>
        public Task<List<Area>> GetAreasCountriesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Area>>(() =>
                base.Get<List<Area>>("/v3/lol/scores/{format}/Areas", parameters)
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
        /// Get Competition Fixtures (League Details) Asynchronous
        /// </summary>
        /// <param name="competitionid">A LoL competition/league unique CompetitionId. Possible values include: <code>100000009</code>, etc.</param>
        public Task<CompetitionDetail> GetCompetitionFixturesLeagueDetailsAsync(string competitionid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competitionid", competitionid.ToString()));
            return Task.Run<CompetitionDetail>(() =>
                base.Get<CompetitionDetail>("/v3/lol/scores/{format}/CompetitionDetails/{competitionid}", parameters)
            );
        }

        /// <summary>
        /// Get Competition Fixtures (League Details)
        /// </summary>
        /// <param name="competitionid">A LoL competition/league unique CompetitionId. Possible values include: <code>100000009</code>, etc.</param>
        public CompetitionDetail GetCompetitionFixturesLeagueDetails(string competitionid)
        {
            return this.GetCompetitionFixturesLeagueDetailsAsync(competitionid).Result;
        }

        /// <summary>
        /// Get Competitions (Leagues) Asynchronous
        /// </summary>
        public Task<List<Competition>> GetCompetitionsLeaguesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Competition>>(() =>
                base.Get<List<Competition>>("/v3/lol/scores/{format}/Competitions", parameters)
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
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/lol/scores/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Memberships (Active) Asynchronous
        /// </summary>
        public Task<List<Membership>> GetMembershipsActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/scores/{format}/ActiveMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Active)
        /// </summary>
        public List<Membership> GetMembershipsActive()
        {
            return this.GetMembershipsActiveAsync().Result;
        }

        /// <summary>
        /// Get Memberships (Historical) Asynchronous
        /// </summary>
        public Task<List<Membership>> GetMembershipsHistoricalAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/scores/{format}/HistoricalMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Historical)
        /// </summary>
        public List<Membership> GetMembershipsHistorical()
        {
            return this.GetMembershipsHistoricalAsync().Result;
        }

        /// <summary>
        /// Get Memberships by Team (Active) Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
        public Task<List<Membership>> GetMembershipsByTeamActiveAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/scores/{format}/MembershipsByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Active)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
        public List<Membership> GetMembershipsByTeamActive(int teamid)
        {
            return this.GetMembershipsByTeamActiveAsync(teamid).Result;
        }

        /// <summary>
        /// Get Memberships by Team (Historical) Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
        public Task<List<Membership>> GetMembershipsByTeamHistoricalAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/v3/lol/scores/{format}/HistoricalMembershipsByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Historical)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
        public List<Membership> GetMembershipsByTeamHistorical(int teamid)
        {
            return this.GetMembershipsByTeamHistoricalAsync(teamid).Result;
        }

        /// <summary>
        /// Get Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
        public Task<Player> GetPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/lol/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
        public Player GetPlayer(int playerid)
        {
            return this.GetPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Players Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/lol/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Players
        /// </summary>
        public List<Player> GetPlayers()
        {
            return this.GetPlayersAsync().Result;
        }

        /// <summary>
        /// Get Players by Team Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
        public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/lol/scores/{format}/PlayersByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
        public List<Player> GetPlayersByTeam(int teamid)
        {
            return this.GetPlayersByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Schedule Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000138</code>, <code>1000001412</code>, etc</param>
        public Task<List<Game>> GetScheduleAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/v3/lol/scores/{format}/Schedule/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000138</code>, <code>1000001412</code>, etc</param>
        public List<Game> GetSchedule(int roundid)
        {
            return this.GetScheduleAsync(roundid).Result;
        }

        /// <summary>
        /// Get Season Teams Asynchronous
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000023</code>, <code>100000024</code>, etc</param>
        public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<SeasonTeam>>(() =>
                base.Get<List<SeasonTeam>>("/v3/lol/scores/{format}/SeasonTeams/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Season Teams
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000023</code>, <code>100000024</code>, etc</param>
        public List<SeasonTeam> GetSeasonTeams(int seasonid)
        {
            return this.GetSeasonTeamsAsync(seasonid).Result;
        }

        /// <summary>
        /// Get Standings Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000138</code>, etc</param>
        public Task<List<Standing>> GetStandingsAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/v3/lol/scores/{format}/Standings/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000138</code>, etc</param>
        public List<Standing> GetStandings(int roundid)
        {
            return this.GetStandingsAsync(roundid).Result;
        }

        /// <summary>
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/v3/lol/scores/{format}/Teams", parameters)
            );
        }

        /// <summary>
        /// Get Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            return this.GetTeamsAsync().Result;
        }

        /// <summary>
        /// Get Venues Asynchronous
        /// </summary>
        public Task<List<Venue>> GetVenuesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Venue>>(() =>
                base.Get<List<Venue>>("/v3/lol/scores/{format}/Venues", parameters)
            );
        }

        /// <summary>
        /// Get Venues
        /// </summary>
        public List<Venue> GetVenues()
        {
            return this.GetVenuesAsync().Result;
        }

    }
}

