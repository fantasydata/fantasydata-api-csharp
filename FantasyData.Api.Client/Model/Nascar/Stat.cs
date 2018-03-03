using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Stat")]
    [Serializable]
    public partial class Stat
    {
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "Created", Order = 2)]
        public DateTime? Created { get; set; }

        [DataMember(Name = "FantasyPoints", Order = 3)]
        public decimal? FantasyPoints { get; set; }

        [DataMember(Name = "FantasyPointsDraftKings", Order = 4)]
        public decimal? FantasyPointsDraftKings { get; set; }

        [DataMember(Name = "QualifyingSpeed", Order = 5)]
        public decimal? QualifyingSpeed { get; set; }

        [DataMember(Name = "PoleFinalPosition", Order = 6)]
        public decimal? PoleFinalPosition { get; set; }

        [DataMember(Name = "StartPosition", Order = 7)]
        public decimal? StartPosition { get; set; }

        [DataMember(Name = "FinalPosition", Order = 8)]
        public decimal? FinalPosition { get; set; }

        [DataMember(Name = "PositionDifferential", Order = 9)]
        public decimal? PositionDifferential { get; set; }

        [DataMember(Name = "Laps", Order = 10)]
        public decimal? Laps { get; set; }

        [DataMember(Name = "LapsLed", Order = 11)]
        public decimal? LapsLed { get; set; }

        [DataMember(Name = "FastestLaps", Order = 12)]
        public decimal? FastestLaps { get; set; }

        [DataMember(Name = "Points", Order = 13)]
        public decimal? Points { get; set; }

        [DataMember(Name = "Bonus", Order = 14)]
        public decimal? Bonus { get; set; }

        [DataMember(Name = "Penalty", Order = 15)]
        public decimal? Penalty { get; set; }

        [DataMember(Name = "Wins", Order = 16)]
        public decimal? Wins { get; set; }

        [DataMember(Name = "Poles", Order = 17)]
        public decimal? Poles { get; set; }

    }
}

