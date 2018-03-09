using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv2Client : BaseClient
    {
        public Soccerv2Client(string apiKey) : base(apiKey) { }
        public Soccerv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Areas (Countries) Asynchronous
        /// </summary>
        public Task<List<Area>> GetAreasAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Area>>(() =>
                base.Get<List<Area>>("/soccer/v2/{format}/Areas", parameters)
            );
        }

        /// <summary>
        /// Get Areas (Countries)
        /// </summary>
        public List<Area> GetAreas()
        {
            return this.GetAreasAsync().Result;
        }

        /// <summary>
        /// Get Box Score Asynchronous
        /// </summary>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public Task<BoxScore> GetBoxScoreAsync(int gameid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("gameid", gameid.ToString()));
            return Task.Run<BoxScore>(() =>
                base.Get<BoxScore>("/soccer/v2/{format}/BoxScore/{gameid}", parameters)
            );
        }

        /// <summary>
        /// Get Box Score
        /// </summary>
        /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
        public BoxScore GetBoxScore(int gameid)
        {
            return this.GetBoxScoreAsync(gameid).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScores/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<BoxScore> GetBoxScores(string date)
        {
            return this.GetBoxScoresAsync(date).Result;
        }

        /// <summary>
        /// Get Box Scores by Date by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScoresByCompetition/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<BoxScore> GetBoxScoresByCompetition(string competition, string date)
        {
            return this.GetBoxScoresByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Box Scores by Date Delta Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores by Date Delta
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDelta(string date, string minutes)
        {
            return this.GetBoxScoresDeltaAsync(date, minutes).Result;
        }

        /// <summary>
        /// Get Box Scores Delta by Date by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public Task<List<BoxScore>> GetBoxScoresDeltaByCompetitionAsync(string competition, string date, string minutes)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("minutes", minutes.ToString()));
            return Task.Run<List<BoxScore>>(() =>
                base.Get<List<BoxScore>>("/soccer/v2/{format}/BoxScoresDeltaByCompetition/{competition}/{date}/{minutes}", parameters)
            );
        }

        /// <summary>
        /// Get Box Scores Delta by Date by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
        public List<BoxScore> GetBoxScoresDeltaByCompetition(string competition, string date, string minutes)
        {
            return this.GetBoxScoresDeltaByCompetitionAsync(competition, date, minutes).Result;
        }

        /// <summary>
        /// Get Competition Fixtures (League Details) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<CompetitionDetail>(() =>
                base.Get<CompetitionDetail>("/soccer/v2/{format}/CompetitionDetails/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Competition Fixtures (League Details)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public CompetitionDetail GetCompetitionDetails(string competition)
        {
            return this.GetCompetitionDetailsAsync(competition).Result;
        }

        /// <summary>
        /// Get Competition Hierarchy (League Hierarchy) Asynchronous
        /// </summary>
        public Task<List<Area>> GetCompetitionHierarchyAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Area>>(() =>
                base.Get<List<Area>>("/soccer/v2/{format}/CompetitionHierarchy", parameters)
            );
        }

        /// <summary>
        /// Get Competition Hierarchy (League Hierarchy)
        /// </summary>
        public List<Area> GetCompetitionHierarchy()
        {
            return this.GetCompetitionHierarchyAsync().Result;
        }

        /// <summary>
        /// Get Competitions (Leagues) Asynchronous
        /// </summary>
        public Task<List<Competition>> GetCompetitionsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Competition>>(() =>
                base.Get<List<Competition>>("/soccer/v2/{format}/Competitions", parameters)
            );
        }

        /// <summary>
        /// Get Competitions (Leagues)
        /// </summary>
        public List<Competition> GetCompetitions()
        {
            return this.GetCompetitionsAsync().Result;
        }

        /// <summary>
        /// Get Games by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<Game>> GetGamesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/soccer/v2/{format}/GamesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Games by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<Game> GetGamesByDate(string date)
        {
            return this.GetGamesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Memberships (Active) Asynchronous
        /// </summary>
        public Task<List<Membership>> GetActiveMembershipsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/soccer/v2/{format}/ActiveMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Active)
        /// </summary>
        public List<Membership> GetActiveMemberships()
        {
            return this.GetActiveMembershipsAsync().Result;
        }

        /// <summary>
        /// Get Memberships (Historical) Asynchronous
        /// </summary>
        public Task<List<Membership>> GetHistoricalMembershipsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/soccer/v2/{format}/HistoricalMemberships", parameters)
            );
        }

        /// <summary>
        /// Get Memberships (Historical)
        /// </summary>
        public List<Membership> GetHistoricalMemberships()
        {
            return this.GetHistoricalMembershipsAsync().Result;
        }

        /// <summary>
        /// Get Memberships by Team (Active) Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/soccer/v2/{format}/MembershipsByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Active)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetMembershipsByTeam(int teamid)
        {
            return this.GetMembershipsByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Memberships by Team (Historical) Asynchronous
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Membership>>(() =>
                base.Get<List<Membership>>("/soccer/v2/{format}/HistoricalMembershipsByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Memberships by Team (Historical)
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Membership> GetHistoricalMembershipsByTeam(int teamid)
        {
            return this.GetHistoricalMembershipsByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Player Asynchronous
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Task<Player> GetPlayerAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/soccer/v2/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player
        /// </summary>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Player GetPlayer(int playerid)
        {
            return this.GetPlayerAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/soccer/v2/{format}/PlayerGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByDate(string date)
        {
            return this.GetPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Player Game Stats by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Task<List<PlayerGame>> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGame>>(() =>
                base.Get<List<PlayerGame>>("/soccer/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Game Stats by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerGame> GetPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStats/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<PlayerSeason> GetPlayerSeasonStats(int roundid)
        {
            return this.GetPlayerSeasonStatsAsync(roundid).Result;
        }

        /// <summary>
        /// Get Player Season Stats by Player Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByPlayerAsync(int roundid, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStatsByPlayer/{roundid}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats by Player
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByPlayer(int roundid, int playerid)
        {
            return this.GetPlayerSeasonStatsByPlayerAsync(roundid, playerid).Result;
        }

        /// <summary>
        /// Get Player Season Stats by Team Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        /// <param name="team">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(int roundid, string team)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("team", team.ToString()));
            return Task.Run<List<PlayerSeason>>(() =>
                base.Get<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStatsByTeam/{roundid}/{team}", parameters)
            );
        }

        /// <summary>
        /// Get Player Season Stats by Team
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        /// <param name="team">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<PlayerSeason> GetPlayerSeasonStatsByTeam(int roundid, string team)
        {
            return this.GetPlayerSeasonStatsByTeamAsync(roundid, team).Result;
        }

        /// <summary>
        /// Get Players Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/soccer/v2/{format}/Players", parameters)
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
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("teamid", teamid.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/soccer/v2/{format}/PlayersByTeam/{teamid}", parameters)
            );
        }

        /// <summary>
        /// Get Players by Team
        /// </summary>
        /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
        public List<Player> GetPlayersByTeam(int teamid)
        {
            return this.GetPlayersByTeamAsync(teamid).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Competition (w/ DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByCompetition/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Competition (w/ DFS Salaries)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByCompetition(string competition, string date)
        {
            return this.GetPlayerGameProjectionStatsByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            return this.GetPlayerGameProjectionStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameProjectionStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Schedule Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<Game>> GetScheduleAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Game>>(() =>
                base.Get<List<Game>>("/soccer/v2/{format}/Schedule/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<Game> GetSchedule(int roundid)
        {
            return this.GetScheduleAsync(roundid).Result;
        }

        /// <summary>
        /// Get Season Teams Asynchronous
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<SeasonTeam>>(() =>
                base.Get<List<SeasonTeam>>("/soccer/v2/{format}/SeasonTeams/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Season Teams
        /// </summary>
        /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<SeasonTeam> GetSeasonTeams(int seasonid)
        {
            return this.GetSeasonTeamsAsync(seasonid).Result;
        }

        /// <summary>
        /// Get Standings Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<Standing>> GetStandingsAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Standing>>(() =>
                base.Get<List<Standing>>("/soccer/v2/{format}/Standings/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Standings
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<Standing> GetStandings(int roundid)
        {
            return this.GetStandingsAsync(roundid).Result;
        }

        /// <summary>
        /// Get Team Game Stats by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<TeamGame>>(() =>
                base.Get<List<TeamGame>>("/soccer/v2/{format}/TeamGameStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Team Game Stats by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
        public List<TeamGame> GetTeamGameStatsByDate(string date)
        {
            return this.GetTeamGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Team Season Stats Asynchronous
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<TeamSeason>>(() =>
                base.Get<List<TeamSeason>>("/soccer/v2/{format}/TeamSeasonStats/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Team Season Stats
        /// </summary>
        /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
        public List<TeamSeason> GetTeamSeasonStats(int roundid)
        {
            return this.GetTeamSeasonStatsAsync(roundid).Result;
        }

        /// <summary>
        /// Get Teams Asynchronous
        /// </summary>
        public Task<List<Team>> GetTeamsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Team>>(() =>
                base.Get<List<Team>>("/soccer/v2/{format}/Teams", parameters)
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
                base.Get<List<Venue>>("/soccer/v2/{format}/Venues", parameters)
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

