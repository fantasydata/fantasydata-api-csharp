using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceResult")]
    [Serializable]
    public partial class RaceResult
    {
        /// <summary>
        /// The details of the race
        /// </summary>
        [Description("The details of the race")]
        [DataMember(Name = "Race", Order = 10001)]
        public Race Race { get; set; }

        /// <summary>
        /// The details of the drivers in this race
        /// </summary>
        [Description("The details of the drivers in this race")]
        [DataMember(Name = "DriverRaces", Order = 20002)]
        public DriverRace[] DriverRaces { get; set; }

    }
}

