﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client
{
    public partial class Soccerv3ProjectionsClient : BaseClient
    {
        public Soccerv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public Soccerv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Projected Player Game Stats - by Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/soccer/projections/{format}/PlayerGameProjectionStatsByCompetition/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByCompetition(string competition, string date)
        {
            return this.GetProjectedPlayerGameStatsByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/soccer/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByDate(string date)
        {
            return this.GetProjectedPlayerGameStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Player Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Task<List<PlayerGameProjection>> GetProjectedPlayerGameStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/soccer/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats - by Player
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerGameProjection> GetProjectedPlayerGameStatsByPlayer(string date, int playerid)
        {
            return this.GetProjectedPlayerGameStatsByPlayerAsync(date, playerid).Result;
        }

        /// <summary>
        /// Get Dfs Slates By Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
        public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/soccer/projections/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Dfs Slates By Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            return this.GetDfsSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Upcoming Dfs Slates By Competition Asynchronous
        /// </summary>
        /// <param name="competitionId">The Competition Id. Examples: <code>3</code></param>
        public Task<List<DfsSlate>> GetUpcomingDfsSlatesByCompetitionAsync(string competitionId)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competitionId", competitionId.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/soccer/projections/{format}/UpcomingDfsSlatesByCompetition/{competitionId}", parameters)
            );
        }

        /// <summary>
        /// Get Upcoming Dfs Slates By Competition
        /// </summary>
        /// <param name="competitionId">The Competition Id. Examples: <code>3</code></param>
        public List<DfsSlate> GetUpcomingDfsSlatesByCompetition(string competitionId)
        {
            return this.GetUpcomingDfsSlatesByCompetitionAsync(competitionId).Result;
        }

        /// <summary>
        /// Get Injured Players By Competition Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public Task<List<Player>> GetInjuredPlayersByCompetitionAsync(string competition)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            return Task.Run<List<Player>>(() =>
                base.Get<List<Player>>("/v3/soccer/projections/{format}/InjuredPlayers/{competition}", parameters)
            );
        }

        /// <summary>
        /// Get Injured Players By Competition
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        public List<Player> GetInjuredPlayersByCompetition(string competition)
        {
            return this.GetInjuredPlayersByCompetitionAsync(competition).Result;
        }

    }
}

