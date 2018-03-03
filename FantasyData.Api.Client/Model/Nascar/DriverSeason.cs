using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="DriverSeason")]
    [Serializable]
    public partial class DriverSeason
    {
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        [DataMember(Name = "DriverID", Order = 2)]
        public int DriverID { get; set; }

        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        [DataMember(Name = "Races", Order = 5)]
        public int Races { get; set; }

        [DataMember(Name = "Updated", Order = 6)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        [DataMember(Name = "FantasyPoints", Order = 8)]
        public decimal? FantasyPoints { get; set; }

        [DataMember(Name = "FantasyPointsDraftKings", Order = 9)]
        public decimal? FantasyPointsDraftKings { get; set; }

        [DataMember(Name = "QualifyingSpeed", Order = 10)]
        public decimal? QualifyingSpeed { get; set; }

        [DataMember(Name = "PoleFinalPosition", Order = 11)]
        public decimal? PoleFinalPosition { get; set; }

        [DataMember(Name = "StartPosition", Order = 12)]
        public decimal? StartPosition { get; set; }

        [DataMember(Name = "FinalPosition", Order = 13)]
        public decimal? FinalPosition { get; set; }

        [DataMember(Name = "PositionDifferential", Order = 14)]
        public decimal? PositionDifferential { get; set; }

        [DataMember(Name = "Laps", Order = 15)]
        public decimal? Laps { get; set; }

        [DataMember(Name = "LapsLed", Order = 16)]
        public decimal? LapsLed { get; set; }

        [DataMember(Name = "FastestLaps", Order = 17)]
        public decimal? FastestLaps { get; set; }

        [DataMember(Name = "Points", Order = 18)]
        public decimal? Points { get; set; }

        [DataMember(Name = "Bonus", Order = 19)]
        public decimal? Bonus { get; set; }

        [DataMember(Name = "Penalty", Order = 20)]
        public decimal? Penalty { get; set; }

        [DataMember(Name = "Wins", Order = 21)]
        public decimal? Wins { get; set; }

        [DataMember(Name = "Poles", Order = 22)]
        public decimal? Poles { get; set; }

    }
}

