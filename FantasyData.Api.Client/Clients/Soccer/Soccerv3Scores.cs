using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv3ScoresClient : BaseClient
    {
        public Soccerv3ScoresClient(string apiKey) : base(apiKey) { }
        public Soccerv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Areas (Countries)
        /// </summary>
        public List<Area> GetAreas()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Area>>("/v3/soccer/scores/{format}/Areas", parameters);
        }

        /// <summary>
        /// Competition Fixtures (League Details)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public CompetitionDetail GetCompetitionDetails(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return base.Get<CompetitionDetail>("/v3/soccer/scores/{format}/CompetitionDetails/{competition}", parameters);
        }

        /// <summary>
        /// Competition Hierarchy (League Hierarchy)
        /// </summary>
        public List<Area> GetCompetitionHierarchy()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Area>>("/v3/soccer/scores/{format}/CompetitionHierarchy", parameters);
        }

        /// <summary>
        /// Competitions (Leagues)
        /// </summary>
        public List<Competition> GetCompetitions()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Competition>>("/v3/soccer/scores/{format}/Competitions", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/v3/soccer/scores/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// Memberships (Active)
        /// </summary>
        public List<Membership> GetActiveMemberships()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Membership>>("/v3/soccer/scores/{format}/ActiveMemberships", parameters);
        }

        /// <summary>
        /// Memberships (Historical)
        /// </summary>
        public List<Membership> GetHistoricalMemberships()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Membership>>("/v3/soccer/scores/{format}/HistoricalMemberships", parameters);
        }

        /// <summary>
        /// Memberships by Team (Active)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetMembershipsByTeam(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return base.Get<List<Membership>>("/v3/soccer/scores/{format}/MembershipsByTeam/{teamid}", parameters);
        }

        /// <summary>
        /// Memberships by Team (Historical)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetHistoricalMembershipsByTeam(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return base.Get<List<Membership>>("/v3/soccer/scores/{format}/HistoricalMembershipsByTeam/{teamid}", parameters);
        }

        /// <summary>
        /// Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/v3/soccer/scores/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Players
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/v3/soccer/scores/{format}/Players", parameters);
        }

        /// <summary>
        /// Players by Team
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Player> GetPlayersByTeam(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return base.Get<List<Player>>("/v3/soccer/scores/{format}/PlayersByTeam/{teamid}", parameters);
        }

        /// <summary>
        /// Schedule
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<Game> GetSchedule(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<Game>>("/v3/soccer/scores/{format}/Schedule/{roundid}", parameters);
        }

        /// <summary>
        /// Season Teams
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<SeasonTeam> GetSeasonTeams(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return base.Get<List<SeasonTeam>>("/v3/soccer/scores/{format}/SeasonTeams/{seasonid}", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<Standing> GetStandings(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<Standing>>("/v3/soccer/scores/{format}/Standings/{roundid}", parameters);
        }

        /// <summary>
        /// Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<TeamGame>>("/v3/soccer/scores/{format}/TeamGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<TeamSeason> GetTeamSeasonStats(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<TeamSeason>>("/v3/soccer/scores/{format}/TeamSeasonStats/{roundid}", parameters);
        }

        /// <summary>
        /// Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/v3/soccer/scores/{format}/Teams", parameters);
        }

        /// <summary>
        /// Venues
        /// </summary>
        public List<Venue> GetVenues()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Venue>>("/v3/soccer/scores/{format}/Venues", parameters);
        }

    }
}

