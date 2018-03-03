using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Race")]
    [Serializable]
    public partial class Race
    {
        [DataMember(Name = "RaceID", Order = 1)]
        public int RaceID { get; set; }

        [DataMember(Name = "SeriesID", Order = 2)]
        public int SeriesID { get; set; }

        [DataMember(Name = "SeriesName", Order = 3)]
        public string SeriesName { get; set; }

        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        [DataMember(Name = "Day", Order = 6)]
        public DateTime Day { get; set; }

        [DataMember(Name = "DateTime", Order = 7)]
        public DateTime? DateTime { get; set; }

        [DataMember(Name = "Track", Order = 8)]
        public string Track { get; set; }

        [DataMember(Name = "Broadcast", Order = 9)]
        public string Broadcast { get; set; }

        [DataMember(Name = "WinnerID", Order = 10)]
        public int? WinnerID { get; set; }

        [DataMember(Name = "PoleWinnerID", Order = 11)]
        public int? PoleWinnerID { get; set; }

        [DataMember(Name = "IsInProgress", Order = 12)]
        public bool IsInProgress { get; set; }

        [DataMember(Name = "IsOver", Order = 13)]
        public bool IsOver { get; set; }

        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "Created", Order = 15)]
        public DateTime? Created { get; set; }

        [DataMember(Name = "RescheduledDay", Order = 16)]
        public DateTime RescheduledDay { get; set; }

        [DataMember(Name = "RescheduledDateTime", Order = 17)]
        public DateTime? RescheduledDateTime { get; set; }

    }
}

