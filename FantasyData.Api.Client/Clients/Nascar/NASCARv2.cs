using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Nascar;

namespace FantasyData.Api.Client
{
    public partial class NASCARv2Client : BaseClient
    {
        public NASCARv2Client(string apiKey) : base(apiKey) { }
        public NASCARv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Driver Profiles - by Driver Asynchronous
        /// </summary>
        /// <param name="driverid">Unique FantasyData Driver ID. Example:<code>80000268</code>.</param>
        public Task<Driver> GetDriverProfilesByDriverAsync(int driverid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("driverid", driverid.ToString()));
            return Task.Run<Driver>(() =>
                base.Get<Driver>("/nascar/v2/{format}/driver/{driverid}", parameters)
            );
        }

        /// <summary>
        /// Get Driver Profiles - by Driver
        /// </summary>
        /// <param name="driverid">Unique FantasyData Driver ID. Example:<code>80000268</code>.</param>
        public Driver GetDriverProfilesByDriver(int driverid)
        {
            return this.GetDriverProfilesByDriverAsync(driverid).Result;
        }

        /// <summary>
        /// Get Projected Player Race Stats - by Race Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<List<DriverRaceProjection>> GetProjectedPlayerRaceStatsByRaceAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<List<DriverRaceProjection>>(() =>
                base.Get<List<DriverRaceProjection>>("/nascar/v2/{format}/DriverRaceProjections/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Race Stats - by Race
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public List<DriverRaceProjection> GetProjectedPlayerRaceStatsByRace(int raceid)
        {
            return this.GetProjectedPlayerRaceStatsByRaceAsync(raceid).Result;
        }

        /// <summary>
        /// Get Driver Profiles - All Asynchronous
        /// </summary>
        public Task<List<Driver>> GetDriverProfilesAllAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Driver>>(() =>
                base.Get<List<Driver>>("/nascar/v2/{format}/drivers", parameters)
            );
        }

        /// <summary>
        /// Get Driver Profiles - All
        /// </summary>
        public List<Driver> GetDriverProfilesAll()
        {
            return this.GetDriverProfilesAllAsync().Result;
        }

        /// <summary>
        /// Get Leaderboard [Live & Final] Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceResult> GetLeaderboardLiveFinalAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<RaceResult>(() =>
                base.Get<RaceResult>("/nascar/v2/{format}/raceresult/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard [Live & Final]
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceResult GetLeaderboardLiveFinal(int raceid)
        {
            return this.GetLeaderboardLiveFinalAsync(raceid).Result;
        }

        /// <summary>
        /// Get Schedules Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<Race>> GetSchedulesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Race>>(() =>
                base.Get<List<Race>>("/nascar/v2/{format}/races/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Race> GetSchedules(string season)
        {
            return this.GetSchedulesAsync(season).Result;
        }

        /// <summary>
        /// Get Season Current Asynchronous
        /// </summary>
        public Task<List<Series>> GetSeasonCurrentAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Series>>(() =>
                base.Get<List<Series>>("/nascar/v2/{format}/series", parameters)
            );
        }

        /// <summary>
        /// Get Season Current
        /// </summary>
        public List<Series> GetSeasonCurrent()
        {
            return this.GetSeasonCurrentAsync().Result;
        }

        /// <summary>
        /// Get Drivers - by Active Asynchronous
        /// </summary>
        public Task<List<DriverBasic>> GetDriversByActiveAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<DriverBasic>>(() =>
                base.Get<List<DriverBasic>>("/nascar/v2/{format}/driversbyactive", parameters)
            );
        }

        /// <summary>
        /// Get Drivers - by Active
        /// </summary>
        public List<DriverBasic> GetDriversByActive()
        {
            return this.GetDriversByActiveAsync().Result;
        }

        /// <summary>
        /// Get Entry List - by Race Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<List<DriverRaceBasic>> GetEntryListByRaceAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<List<DriverRaceBasic>>(() =>
                base.Get<List<DriverRaceBasic>>("/nascar/v2/{format}/EntryListbyRace/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Entry List - by Race
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public List<DriverRaceBasic> GetEntryListByRace(int raceid)
        {
            return this.GetEntryListByRaceAsync(raceid).Result;
        }

        /// <summary>
        /// Get Leaderboard [Final] Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceResult> GetLeaderboardFinalAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<RaceResult>(() =>
                base.Get<RaceResult>("/nascar/v2/{format}/raceresultfinal/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard [Final]
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceResult GetLeaderboardFinal(int raceid)
        {
            return this.GetLeaderboardFinalAsync(raceid).Result;
        }

        /// <summary>
        /// Get Tracks Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<Tracks>> GetTracksAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Tracks>>(() =>
                base.Get<List<Tracks>>("/nascar/v2/{format}/tracks/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Tracks
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Tracks> GetTracks(string season)
        {
            return this.GetTracksAsync(season).Result;
        }

        /// <summary>
        /// Get Fantasy Points - by Race Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<FantasyRace> GetFantasyPointsByRaceAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<FantasyRace>(() =>
                base.Get<FantasyRace>("/nascar/v2/{format}/FantasyGameStatsByRace/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Fantasy Points - by Race
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public FantasyRace GetFantasyPointsByRace(int raceid)
        {
            return this.GetFantasyPointsByRaceAsync(raceid).Result;
        }

        /// <summary>
        /// Get Leaderboard (Basic) Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceResultBasic> GetLeaderboardBasicAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<RaceResultBasic>(() =>
                base.Get<RaceResultBasic>("/nascar/v2/{format}/LeaderboardBasic/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard (Basic)
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceResultBasic GetLeaderboardBasic(int raceid)
        {
            return this.GetLeaderboardBasicAsync(raceid).Result;
        }

        /// <summary>
        /// Get Leaderboard (Basic) [Final] Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceResultBasic> GetLeaderboardBasicFinalAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<RaceResultBasic>(() =>
                base.Get<RaceResultBasic>("/nascar/v2/{format}/LeaderboardBasicFinal/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Leaderboard (Basic) [Final]
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceResultBasic GetLeaderboardBasicFinal(int raceid)
        {
            return this.GetLeaderboardBasicFinalAsync(raceid).Result;
        }

    }
}

