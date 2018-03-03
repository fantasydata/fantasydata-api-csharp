using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="DriverRaceProjection")]
    [Serializable]
    public partial class DriverRaceProjection
    {
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        [DataMember(Name = "DriverID", Order = 2)]
        public int DriverID { get; set; }

        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        [DataMember(Name = "Number", Order = 5)]
        public int? Number { get; set; }

        [DataMember(Name = "Manufacturer", Order = 6)]
        public string Manufacturer { get; set; }

        [DataMember(Name = "DraftKingsSalary", Order = 7)]
        public int? DraftKingsSalary { get; set; }

        [DataMember(Name = "RaceID", Order = 8)]
        public int? RaceID { get; set; }

        [DataMember(Name = "Day", Order = 9)]
        public DateTime Day { get; set; }

        [DataMember(Name = "DateTime", Order = 10)]
        public DateTime? DateTime { get; set; }

        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        [DataMember(Name = "FantasyPoints", Order = 13)]
        public decimal? FantasyPoints { get; set; }

        [DataMember(Name = "FantasyPointsDraftKings", Order = 14)]
        public decimal? FantasyPointsDraftKings { get; set; }

        [DataMember(Name = "QualifyingSpeed", Order = 15)]
        public decimal? QualifyingSpeed { get; set; }

        [DataMember(Name = "PoleFinalPosition", Order = 16)]
        public decimal? PoleFinalPosition { get; set; }

        [DataMember(Name = "StartPosition", Order = 17)]
        public decimal? StartPosition { get; set; }

        [DataMember(Name = "FinalPosition", Order = 18)]
        public decimal? FinalPosition { get; set; }

        [DataMember(Name = "PositionDifferential", Order = 19)]
        public decimal? PositionDifferential { get; set; }

        [DataMember(Name = "Laps", Order = 20)]
        public decimal? Laps { get; set; }

        [DataMember(Name = "LapsLed", Order = 21)]
        public decimal? LapsLed { get; set; }

        [DataMember(Name = "FastestLaps", Order = 22)]
        public decimal? FastestLaps { get; set; }

        [DataMember(Name = "Points", Order = 23)]
        public decimal? Points { get; set; }

        [DataMember(Name = "Bonus", Order = 24)]
        public decimal? Bonus { get; set; }

        [DataMember(Name = "Penalty", Order = 25)]
        public decimal? Penalty { get; set; }

        [DataMember(Name = "Wins", Order = 26)]
        public decimal? Wins { get; set; }

        [DataMember(Name = "Poles", Order = 27)]
        public decimal? Poles { get; set; }

    }
}

