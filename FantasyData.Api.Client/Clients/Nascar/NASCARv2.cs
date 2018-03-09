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
        /// Get Driver Details Asynchronous
        /// </summary>
        /// <param name="driverid">Unique FantasyData Driver ID. Example:<code>80000268</code>.</param>
        public Task<Driver> GetDriverAsync(int driverid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("driverid", driverid.ToString()));
            return Task.Run<Driver>(() =>
                base.Get<Driver>("/nascar/v2/{format}/driver/{driverid}", parameters)
            );
        }

        /// <summary>
        /// Get Driver Details
        /// </summary>
        /// <param name="driverid">Unique FantasyData Driver ID. Example:<code>80000268</code>.</param>
        public Driver GetDriver(int driverid)
        {
            return this.GetDriverAsync(driverid).Result;
        }

        /// <summary>
        /// Get Driver Race Projections (Entry List) Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<List<DriverRaceProjection>> GetDriverRaceProjectionsAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<List<DriverRaceProjection>>(() =>
                base.Get<List<DriverRaceProjection>>("/nascar/v2/{format}/DriverRaceProjections/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Driver Race Projections (Entry List)
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public List<DriverRaceProjection> GetDriverRaceProjections(int raceid)
        {
            return this.GetDriverRaceProjectionsAsync(raceid).Result;
        }

        /// <summary>
        /// Get Drivers Asynchronous
        /// </summary>
        public Task<List<Driver>> GetDriversAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Driver>>(() =>
                base.Get<List<Driver>>("/nascar/v2/{format}/drivers", parameters)
            );
        }

        /// <summary>
        /// Get Drivers
        /// </summary>
        public List<Driver> GetDrivers()
        {
            return this.GetDriversAsync().Result;
        }

        /// <summary>
        /// Get Race Results Asynchronous
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public Task<RaceResult> GetRaceresultAsync(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return Task.Run<RaceResult>(() =>
                base.Get<RaceResult>("/nascar/v2/{format}/raceresult/{raceid}", parameters)
            );
        }

        /// <summary>
        /// Get Race Results
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceResult GetRaceresult(int raceid)
        {
            return this.GetRaceresultAsync(raceid).Result;
        }

        /// <summary>
        /// Get Races / Schedule Asynchronous
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public Task<List<Race>> GetRacesAsync(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return Task.Run<List<Race>>(() =>
                base.Get<List<Race>>("/nascar/v2/{format}/races/{season}", parameters)
            );
        }

        /// <summary>
        /// Get Races / Schedule
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Race> GetRaces(string season)
        {
            return this.GetRacesAsync(season).Result;
        }

        /// <summary>
        /// Get Series Asynchronous
        /// </summary>
        public Task<List<Series>> GetSeriesAsync()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return Task.Run<List<Series>>(() =>
                base.Get<List<Series>>("/nascar/v2/{format}/series", parameters)
            );
        }

        /// <summary>
        /// Get Series
        /// </summary>
        public List<Series> GetSeries()
        {
            return this.GetSeriesAsync().Result;
        }

    }
}

