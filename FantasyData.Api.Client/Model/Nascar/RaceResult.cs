using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceResult")]
    [Serializable]
    public partial class RaceResult
    {
        [DataMember(Name = "Race", Order = 10001)]
        public Race Race { get; set; }

        [DataMember(Name = "DriverRaces", Order = 20002)]
        public DriverRace[] DriverRaces { get; set; }

    }
}

