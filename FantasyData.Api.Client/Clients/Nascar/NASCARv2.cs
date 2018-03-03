using System;
using System.Collections.Generic;
using FantasyData.Api.Client.Model.Nascar;

namespace FantasyData.Api.Client
{
    public partial class NASCARv2Client : BaseClient
    {
        public NASCARv2Client(string apiKey) : base(apiKey) { }
        public NASCARv2Client(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Driver Details
        /// </summary>
        /// <param name="driverid">Unique FantasyData Driver ID. Example:<code>80000268</code>.</param>
        public Driver GetDriver(int driverid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("driverid", driverid.ToString()));
            return base.Get<Driver>("/nascar/v2/{format}/driver/{driverid}", parameters);
        }

        /// <summary>
        /// Driver Race Projections (Entry List)
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public List<DriverRaceProjection> GetDriverRaceProjections(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return base.Get<List<DriverRaceProjection>>("/nascar/v2/{format}/DriverRaceProjections/{raceid}", parameters);
        }

        /// <summary>
        /// Drivers
        /// </summary>
        public List<Driver> GetDrivers()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Driver>>("/nascar/v2/{format}/drivers", parameters);
        }

        /// <summary>
        /// Race Results
        /// </summary>
        /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
        public RaceResult GetRaceresult(int raceid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("raceid", raceid.ToString()));
            return base.Get<RaceResult>("/nascar/v2/{format}/raceresult/{raceid}", parameters);
        }

        /// <summary>
        /// Races / Schedule
        /// </summary>
        /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
        public List<Race> GetRaces(string season)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("season", season.ToString()));
            return base.Get<List<Race>>("/nascar/v2/{format}/races/{season}", parameters);
        }

        /// <summary>
        /// Series
        /// </summary>
        public List<Series> GetSeries()
        {
            var parameters = new List<KeyValuePair<string, string>>();
            return base.Get<List<Series>>("/nascar/v2/{format}/series", parameters);
        }

    }
}

