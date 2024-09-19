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
        /// RaceBasic Object
        /// </summary>
        [Description("RaceBasic Object")]
        [DataMember(Name = "Race", Order = 10001)]
        public RaceBasic Race { get; set; }

        /// <summary>
        /// StatBasic Object
        /// </summary>
        [Description("StatBasic Object")]
        [DataMember(Name = "DriverRaces", Order = 20002)]
        public DriverRaceBasic[] DriverRaces { get; set; }

    }
}

