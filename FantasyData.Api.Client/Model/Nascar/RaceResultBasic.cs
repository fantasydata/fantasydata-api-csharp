using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceResultBasic")]
    [Serializable]
    public partial class RaceResultBasic
    {
        /// <summary>
        /// RaceBasic object (Includes basic information such as RaceID, Day, DateTime, Updated, and Created)
        /// </summary>
        [Description("RaceBasic object (Includes basic information such as RaceID, Day, DateTime, Updated, and Created)")]
        [DataMember(Name = "Race", Order = 10001)]
        public RaceBasic Race { get; set; }

        /// <summary>
        /// StatBasic object (includes basic information on the drivers race performance such as DriveID, Season, Driver's Name, Start and Final positions, Lap information, etc.)
        /// </summary>
        [Description("StatBasic object (includes basic information on the drivers race performance such as DriveID, Season, Driver's Name, Start and Final positions, Lap information, etc.)")]
        [DataMember(Name = "DriverRaces", Order = 20002)]
        public DriverRaceBasic[] DriverRaces { get; set; }

    }
}

