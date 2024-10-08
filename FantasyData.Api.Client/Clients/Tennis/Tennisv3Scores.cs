﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Tennis;

namespace FantasyData.Api.Client
{
    public partial class Tennisv3ScoresClient : BaseClient
    {
        public Tennisv3ScoresClient(string apiKey) : base(apiKey) { }
        public Tennisv3ScoresClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Competitions Asynchronous
        /// </summary>
        public Task<List<Competition>> GetCompetitionsAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Competition>>(() =>
                base.Get<List<Competition>>("/v3/tennis/scores/{format}/Competitions", parameters)
            );
        }

        /// <summary>
        /// Get Competitions
        /// </summary>
        public List<Competition> GetCompetitions()
        {
            return this.GetCompetitionsAsync().Result;
        }

        /// <summary>
        /// Get Contestants - by Season Asynchronous
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to pull Contestants. Ex: <code>27</code></param>
        public Task<List<Contestant>> GetContestantsBySeasonAsync(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<Contestant>>(() =>
                base.Get<List<Contestant>>("/v3/tennis/scores/{format}/ContestantsBySeason/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Contestants - by Season
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to pull Contestants. Ex: <code>27</code></param>
        public List<Contestant> GetContestantsBySeason(int seasonid)
        {
            return this.GetContestantsBySeasonAsync(seasonid).Result;
        }

        /// <summary>
        /// Get Contestants by Discipline and Gender - by Season Asynchronous
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to pull Contestants. Ex: <code>27</code></param>
        /// <param name="discipline">The Discipline for which to pull Contestants. Valid Entries are <code> 1, 2, 3, singles, doubles, mixed </code>.</param>
        /// <param name="gender">The Gender for which to pull Contestants. Valid entries are <code> m, male, men, f, female, women, mixed </code>.</param>
        public Task<List<Contestant>> GetContestantsByDisciplineAndGenderBySeasonAsync(int seasonid, string discipline, string gender)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("discipline", discipline.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gender", gender.ToString()));
            return Task.Run<List<Contestant>>(() =>
                base.Get<List<Contestant>>("/v3/tennis/scores/{format}/ContestantsBySeason/{seasonid}/{discipline}/{gender}", parameters)
            );
        }

        /// <summary>
        /// Get Contestants by Discipline and Gender - by Season
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to pull Contestants. Ex: <code>27</code></param>
        /// <param name="discipline">The Discipline for which to pull Contestants. Valid Entries are <code> 1, 2, 3, singles, doubles, mixed </code>.</param>
        /// <param name="gender">The Gender for which to pull Contestants. Valid entries are <code> m, male, men, f, female, women, mixed </code>.</param>
        public List<Contestant> GetContestantsByDisciplineAndGenderBySeason(int seasonid, string discipline, string gender)
        {
            return this.GetContestantsByDisciplineAndGenderBySeasonAsync(seasonid, discipline, gender).Result;
        }

        /// <summary>
        /// Get Disciplines Asynchronous
        /// </summary>
        public Task<List<Discipline>> GetDisciplinesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Discipline>>(() =>
                base.Get<List<Discipline>>("/v3/tennis/scores/{format}/Disciplines", parameters)
            );
        }

        /// <summary>
        /// Get Disciplines
        /// </summary>
        public List<Discipline> GetDisciplines()
        {
            return this.GetDisciplinesAsync().Result;
        }

        /// <summary>
        /// Get Scores - by Match [Live & Final] Asynchronous
        /// </summary>
        /// <param name="matchid">The MatchId for which to pull details. Ex: <code> 2 </code></param>
        public Task<Match> GetScoresByMatchLiveFinalAsync(string matchid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("matchid", matchid.ToString()));
            return Task.Run<Match>(() =>
                base.Get<Match>("/v3/tennis/scores/{format}/Match/{matchid}", parameters)
            );
        }

        /// <summary>
        /// Get Scores - by Match [Live & Final]
        /// </summary>
        /// <param name="matchid">The MatchId for which to pull details. Ex: <code> 2 </code></param>
        public Match GetScoresByMatchLiveFinal(string matchid)
        {
            return this.GetScoresByMatchLiveFinalAsync(matchid).Result;
        }

        /// <summary>
        /// Get Schedule by Matches - by Round Asynchronous
        /// </summary>
        /// <param name="roundid">The RoundId for which to pull the schedule. Ex. <code> 1 </code></param>
        public Task<List<Match>> GetScheduleByMatchesByRoundAsync(int roundid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("roundid", roundid.ToString()));
            return Task.Run<List<Match>>(() =>
                base.Get<List<Match>>("/v3/tennis/scores/{format}/MatchesByRound/{roundid}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule by Matches - by Round
        /// </summary>
        /// <param name="roundid">The RoundId for which to pull the schedule. Ex. <code> 1 </code></param>
        public List<Match> GetScheduleByMatchesByRound(int roundid)
        {
            return this.GetScheduleByMatchesByRoundAsync(roundid).Result;
        }

        /// <summary>
        /// Get Schedule by Season - by Date Asynchronous
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to pull matches. Ex: <code>27</code></param>
        /// <param name="date">The date for which to pull matches. Ex: <code> 2022-06-03 </code></param>
        public Task<List<Match>> GetScheduleBySeasonByDateAsync(int seasonid, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<Match>>(() =>
                base.Get<List<Match>>("/v3/tennis/scores/{format}/MatchesBySeasonAndDate/{seasonid}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Schedule by Season - by Date
        /// </summary>
        /// <param name="seasonid">The SeasonId for which to pull matches. Ex: <code>27</code></param>
        /// <param name="date">The date for which to pull matches. Ex: <code> 2022-06-03 </code></param>
        public List<Match> GetScheduleBySeasonByDate(int seasonid, string date)
        {
            return this.GetScheduleBySeasonByDateAsync(seasonid, date).Result;
        }

        /// <summary>
        /// Get Player Profile Asynchronous
        /// </summary>
        /// <param name="playerid">The unique PlayerId of the player to pull details. Ex. <code>160000001</code></param>
        public Task<Player> GetPlayerProfileAsync(int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<Player>(() =>
                base.Get<Player>("/v3/tennis/scores/{format}/Player/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Player Profile
        /// </summary>
        /// <param name="playerid">The unique PlayerId of the player to pull details. Ex. <code>160000001</code></param>
        public Player GetPlayerProfile(int playerid)
        {
            return this.GetPlayerProfileAsync(playerid).Result;
        }

        /// <summary>
        /// Get Player Profiles - All Asynchronous
        /// </summary>
        public Task<List<Player>> GetPlayerProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/tennis/scores/{format}/Players", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - All
        /// </summary>
        public List<Player> GetPlayerProfilesAll()
        {
            return this.GetPlayerProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Player Profiles - by Rank Asynchronous
        /// </summary>
        /// <param name="discipline">The Discipline for which to pull player rankings. Valid Entries are <code> 1, 2, 3, singles, doubles, mixed <code>.</param>
        /// <param name="gender">The gender for which to pull player rankings. Valid entries are <code> m, male, men, f, female, women, mixed <code>.</param>
        public Task<List<Player>> GetPlayerProfilesByRankAsync(string discipline, string gender)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("discipline", discipline.ToString()));
            parameters.Add(new KeyValuePair<string, string>("gender", gender.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/tennis/scores/{format}/PlayersByRank/{discipline}/{gender}", parameters)
            );
        }

        /// <summary>
        /// Get Player Profiles - by Rank
        /// </summary>
        /// <param name="discipline">The Discipline for which to pull player rankings. Valid Entries are <code> 1, 2, 3, singles, doubles, mixed <code>.</param>
        /// <param name="gender">The gender for which to pull player rankings. Valid entries are <code> m, male, men, f, female, women, mixed <code>.</param>
        public List<Player> GetPlayerProfilesByRank(string discipline, string gender)
        {
            return this.GetPlayerProfilesByRankAsync(discipline, gender).Result;
        }

        /// <summary>
        /// Get Rounds - by Season Asynchronous
        /// </summary>
        /// <param name="seasonid">The SeasonID for which to pull Round records. Ex: <code>27</code></param>
        public Task<List<Round>> GetRoundsBySeasonAsync(int seasonid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("seasonid", seasonid.ToString()));
            return Task.Run<List<Round>>(() =>
                base.Get<List<Round>>("/v3/tennis/scores/{format}/RoundsBySeason/{seasonid}", parameters)
            );
        }

        /// <summary>
        /// Get Rounds - by Season
        /// </summary>
        /// <param name="seasonid">The SeasonID for which to pull Round records. Ex: <code>27</code></param>
        public List<Round> GetRoundsBySeason(int seasonid)
        {
            return this.GetRoundsBySeasonAsync(seasonid).Result;
        }

        /// <summary>
        /// Get Seasons - by Competition Asynchronous
        /// </summary>
        /// <param name="competitionId">The CompetitionId for which to pull Season records. Ex: <code> 28 </code></param>
        public Task<List<Season>> GetSeasonsByCompetitionAsync(string competitionId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competitionId", competitionId.ToString()));
            return Task.Run<List<Season>>(() =>
                base.Get<List<Season>>("/v3/tennis/scores/{format}/SeasonsByCompetition/{competitionId}", parameters)
            );
        }

        /// <summary>
        /// Get Seasons - by Competition
        /// </summary>
        /// <param name="competitionId">The CompetitionId for which to pull Season records. Ex: <code> 28 </code></param>
        public List<Season> GetSeasonsByCompetition(string competitionId)
        {
            return this.GetSeasonsByCompetitionAsync(competitionId).Result;
        }

        /// <summary>
        /// Get Seasons - by Tour Season Asynchronous
        /// </summary>
        /// <param name="tourSeasonId">The TourSeasonId for which to pull Seasons by TourSeason. Ex: <code> 1 </code></param>
        public Task<List<Season>> GetSeasonsByTourSeasonAsync(string tourSeasonId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("tourSeasonId", tourSeasonId.ToString()));
            return Task.Run<List<Season>>(() =>
                base.Get<List<Season>>("/v3/tennis/scores/{format}/SeasonsByTourSeason/{tourSeasonId}", parameters)
            );
        }

        /// <summary>
        /// Get Seasons - by Tour Season
        /// </summary>
        /// <param name="tourSeasonId">The TourSeasonId for which to pull Seasons by TourSeason. Ex: <code> 1 </code></param>
        public List<Season> GetSeasonsByTourSeason(string tourSeasonId)
        {
            return this.GetSeasonsByTourSeasonAsync(tourSeasonId).Result;
        }

        /// <summary>
        /// Get Seasons - by Year Asynchronous
        /// </summary>
        /// <param name="year">The year for which to pull Season records. Ex: <code>2022</code></param>
        public Task<List<Season>> GetSeasonsByYearAsync(string year)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("year", year.ToString()));
            return Task.Run<List<Season>>(() =>
                base.Get<List<Season>>("/v3/tennis/scores/{format}/SeasonsByYear/{year}", parameters)
            );
        }

        /// <summary>
        /// Get Seasons - by Year
        /// </summary>
        /// <param name="year">The year for which to pull Season records. Ex: <code>2022</code></param>
        public List<Season> GetSeasonsByYear(string year)
        {
            return this.GetSeasonsByYearAsync(year).Result;
        }

        /// <summary>
        /// Get Tours Asynchronous
        /// </summary>
        public Task<List<Tour>> GetToursAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Tour>>(() =>
                base.Get<List<Tour>>("/v3/tennis/scores/{format}/Tours", parameters)
            );
        }

        /// <summary>
        /// Get Tours
        /// </summary>
        public List<Tour> GetTours()
        {
            return this.GetToursAsync().Result;
        }

        /// <summary>
        /// Get Venues Asynchronous
        /// </summary>
        public Task<List<Venue>> GetVenuesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Venue>>(() =>
                base.Get<List<Venue>>("/v3/tennis/scores/{format}/Venues", parameters)
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
        /// Get Scores - by Match [Final] Asynchronous
        /// </summary>
        /// <param name="matchid">The MatchId for which to pull details. Ex: <code> 2 </code></param>
        public Task<Match> GetScoresByMatchFinalAsync(string matchid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("matchid", matchid.ToString()));
            return Task.Run<Match>(() =>
                base.Get<Match>("/v3/tennis/scores/{format}/MatchFinal/{matchid}", parameters)
            );
        }

        /// <summary>
        /// Get Scores - by Match [Final]
        /// </summary>
        /// <param name="matchid">The MatchId for which to pull details. Ex: <code> 2 </code></param>
        public Match GetScoresByMatchFinal(string matchid)
        {
            return this.GetScoresByMatchFinalAsync(matchid).Result;
        }

    }
}

