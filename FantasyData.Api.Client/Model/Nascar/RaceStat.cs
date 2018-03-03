using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceStat")]
    [Serializable]
    public partial class RaceStat
    {
        [DataMember(Name = "RaceID", Order = 1)]
        public int? RaceID { get; set; }

        [DataMember(Name = "Day", Order = 2)]
        public DateTime Day { get; set; }

        [DataMember(Name = "DateTime", Order = 3)]
        public DateTime? DateTime { get; set; }

        [DataMember(Name = "Updated", Order = 4)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "Created", Order = 5)]
        public DateTime? Created { get; set; }

        [DataMember(Name = "FantasyPoints", Order = 6)]
        public decimal? FantasyPoints { get; set; }

        [DataMember(Name = "FantasyPointsDraftKings", Order = 7)]
        public decimal? FantasyPointsDraftKings { get; set; }

        [DataMember(Name = "QualifyingSpeed", Order = 8)]
        public decimal? QualifyingSpeed { get; set; }

        [DataMember(Name = "PoleFinalPosition", Order = 9)]
        public decimal? PoleFinalPosition { get; set; }

        [DataMember(Name = "StartPosition", Order = 10)]
        public decimal? StartPosition { get; set; }

        [DataMember(Name = "FinalPosition", Order = 11)]
        public decimal? FinalPosition { get; set; }

        [DataMember(Name = "PositionDifferential", Order = 12)]
        public decimal? PositionDifferential { get; set; }

        [DataMember(Name = "Laps", Order = 13)]
        public decimal? Laps { get; set; }

        [DataMember(Name = "LapsLed", Order = 14)]
        public decimal? LapsLed { get; set; }

        [DataMember(Name = "FastestLaps", Order = 15)]
        public decimal? FastestLaps { get; set; }

        [DataMember(Name = "Points", Order = 16)]
        public decimal? Points { get; set; }

        [DataMember(Name = "Bonus", Order = 17)]
        public decimal? Bonus { get; set; }

        [DataMember(Name = "Penalty", Order = 18)]
        public decimal? Penalty { get; set; }

        [DataMember(Name = "Wins", Order = 19)]
        public decimal? Wins { get; set; }

        [DataMember(Name = "Poles", Order = 20)]
        public decimal? Poles { get; set; }

    }
}

