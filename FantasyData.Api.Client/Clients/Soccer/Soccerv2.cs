using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv2Client : BaseClient
    {
        public Soccerv2Client(string apiKey) : base(apiKey) { }
        public Soccerv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Areas (Countries)
        /// </summary>
        public List<Area> GetAreas()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Area>>("/soccer/v2/{format}/Areas", parameters);
        }

        /// <summary>
        /// Box Score
        /// </summary>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public BoxScore GetBoxScore(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return base.Get<BoxScore>("/soccer/v2/{format}/BoxScore/{gameid}", parameters);
        }

        /// <summary>
        /// Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScores/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Date by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<BoxScore> GetBoxScoresByCompetition(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScoresByCompetition/{competition}/{date}", parameters);
        }

        /// <summary>
        /// Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Box Scores Delta by Date by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDeltaByCompetition(string competition, string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScoresDeltaByCompetition/{competition}/{date}/{minutes}", parameters);
        }

        /// <summary>
        /// Competition Fixtures (League Details)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public CompetitionDetail GetCompetitionDetails(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return base.Get<CompetitionDetail>("/soccer/v2/{format}/CompetitionDetails/{competition}", parameters);
        }

        /// <summary>
        /// Competition Hierarchy (League Hierarchy)
        /// </summary>
        public List<Area> GetCompetitionHierarchy()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Area>>("/soccer/v2/{format}/CompetitionHierarchy", parameters);
        }

        /// <summary>
        /// Competitions (Leagues)
        /// </summary>
        public List<Competition> GetCompetitions()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Competition>>("/soccer/v2/{format}/Competitions", parameters);
        }

        /// <summary>
        /// Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<Game>>("/soccer/v2/{format}/GamesByDate/{date}", parameters);
        }

        /// <summary>
        /// Memberships (Active)
        /// </summary>
        public List<Membership> GetActiveMemberships()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Membership>>("/soccer/v2/{format}/ActiveMemberships", parameters);
        }

        /// <summary>
        /// Memberships (Historical)
        /// </summary>
        public List<Membership> GetHistoricalMemberships()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Membership>>("/soccer/v2/{format}/HistoricalMemberships", parameters);
        }

        /// <summary>
        /// Memberships by Team (Active)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetMembershipsByTeam(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return base.Get<List<Membership>>("/soccer/v2/{format}/MembershipsByTeam/{teamid}", parameters);
        }

        /// <summary>
        /// Memberships by Team (Historical)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetHistoricalMembershipsByTeam(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return base.Get<List<Membership>>("/soccer/v2/{format}/HistoricalMembershipsByTeam/{teamid}", parameters);
        }

        /// <summary>
        /// Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Player GetPlayer(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<Player>("/soccer/v2/{format}/Player/{playerid}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGame>>("/soccer/v2/{format}/PlayerGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<PlayerGame>>("/soccer/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<PlayerSeason> GetPlayerSeasonStats(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStats/{roundid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Player
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByPlayer(int roundid, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStatsByPlayer/{roundid}/{playerid}", parameters);
        }

        /// <summary>
        /// Player Season Stats by Team
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        /// <param name="team">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(int roundid, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return base.Get<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStatsByTeam/{roundid}/{team}", parameters);
        }

        /// <summary>
        /// Players
        /// </summary>
        public List<Player> GetPlayers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Player>>("/soccer/v2/{format}/Players", parameters);
        }

        /// <summary>
        /// Players by Team
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Player> GetPlayersByTeam(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return base.Get<List<Player>>("/soccer/v2/{format}/PlayersByTeam/{teamid}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Competition (w/ DFS Salaries)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByCompetition(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByCompetition/{competition}/{date}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Date (w/ DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Projected Player Game Stats by Player (w/ DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return base.Get<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
        }

        /// <summary>
        /// Schedule
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<Game> GetSchedule(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<Game>>("/soccer/v2/{format}/Schedule/{roundid}", parameters);
        }

        /// <summary>
        /// Season Teams
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<SeasonTeam> GetSeasonTeams(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return base.Get<List<SeasonTeam>>("/soccer/v2/{format}/SeasonTeams/{seasonid}", parameters);
        }

        /// <summary>
        /// Standings
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<Standing> GetStandings(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<Standing>>("/soccer/v2/{format}/Standings/{roundid}", parameters);
        }

        /// <summary>
        /// Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return base.Get<List<TeamGame>>("/soccer/v2/{format}/TeamGameStatsByDate/{date}", parameters);
        }

        /// <summary>
        /// Team Season Stats
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<TeamSeason> GetTeamSeasonStats(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return base.Get<List<TeamSeason>>("/soccer/v2/{format}/TeamSeasonStats/{roundid}", parameters);
        }

        /// <summary>
        /// Teams
        /// </summary>
        public List<Team> GetTeams()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Team>>("/soccer/v2/{format}/Teams", parameters);
        }

        /// <summary>
        /// Venues
        /// </summary>
        public List<Venue> GetVenues()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Venue>>("/soccer/v2/{format}/Venues", parameters);
        }

    }
}

