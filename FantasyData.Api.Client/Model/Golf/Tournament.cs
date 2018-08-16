using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Tournament")]
    [Serializable]
    public partial class Tournament
    {
        /// <summary>
        /// The unique ID of this tournament
        /// </summary>
        [Description("The unique ID of this tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The name of this tournament
        /// </summary>
        [Description("The name of this tournament")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The start date of this tournament
        /// </summary>
        [Description("The start date of this tournament")]
        [DataMember(Name = "StartDate", Order = 3)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of this tournament
        /// </summary>
        [Description("The end date of this tournament")]
        [DataMember(Name = "EndDate", Order = 4)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates whether this tournament is over
        /// </summary>
        [Description("Indicates whether this tournament is over")]
        [DataMember(Name = "IsOver", Order = 5)]
        public bool IsOver { get; set; }

        /// <summary>
        /// Indicates whether this tournament is in progress
        /// </summary>
        [Description("Indicates whether this tournament is in progress")]
        [DataMember(Name = "IsInProgress", Order = 6)]
        public bool IsInProgress { get; set; }

        /// <summary>
        /// The name of the venue where this tournament takes place
        /// </summary>
        [Description("The name of the venue where this tournament takes place")]
        [DataMember(Name = "Venue", Order = 7)]
        public string Venue { get; set; }

        /// <summary>
        /// The physical location of this tournament
        /// </summary>
        [Description("The physical location of this tournament")]
        [DataMember(Name = "Location", Order = 8)]
        public string Location { get; set; }

        /// <summary>
        /// The 18-hole par of this course
        /// </summary>
        [Description("The 18-hole par of this course")]
        [DataMember(Name = "Par", Order = 9)]
        public int? Par { get; set; }

        /// <summary>
        /// The total yards of all 18 holes of this course
        /// </summary>
        [Description("The total yards of all 18 holes of this course")]
        [DataMember(Name = "Yards", Order = 10)]
        public int? Yards { get; set; }

        /// <summary>
        /// The total prize money of this tournament
        /// </summary>
        [Description("The total prize money of this tournament")]
        [DataMember(Name = "Purse", Order = 11)]
        public decimal? Purse { get; set; }

        /// <summary>
        /// The first tee time of the upcoming round of this tournament
        /// </summary>
        [Description("The first tee time of the upcoming round of this tournament")]
        [DataMember(Name = "StartDateTime", Order = 12)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Indicates whether this tournament is canceled
        /// </summary>
        [Description("Indicates whether this tournament is canceled")]
        [DataMember(Name = "Canceled", Order = 13)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// Indicates whether this tournament is covered (only stroke format tournaments are covered)
        /// </summary>
        [Description("Indicates whether this tournament is covered (only stroke format tournaments are covered)")]
        [DataMember(Name = "Covered", Order = 14)]
        public bool? Covered { get; set; }

        /// <summary>
        /// The city where this course is located
        /// </summary>
        [Description("The city where this course is located")]
        [DataMember(Name = "City", Order = 15)]
        public string City { get; set; }

        /// <summary>
        /// The state where this course is located
        /// </summary>
        [Description("The state where this course is located")]
        [DataMember(Name = "State", Order = 16)]
        public string State { get; set; }

        /// <summary>
        /// The zip code where this course is located
        /// </summary>
        [Description("The zip code where this course is located")]
        [DataMember(Name = "ZipCode", Order = 17)]
        public string ZipCode { get; set; }

        /// <summary>
        /// The country where this course is located
        /// </summary>
        [Description("The country where this course is located")]
        [DataMember(Name = "Country", Order = 18)]
        public string Country { get; set; }

        /// <summary>
        /// The description of the time zone in which the course is located
        /// </summary>
        [Description("The description of the time zone in which the course is located")]
        [DataMember(Name = "TimeZone", Order = 19)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The format of the tournament (possible values: Stroke, Match, Team, Stableford)
        /// </summary>
        [Description("The format of the tournament (possible values: Stroke, Match, Team, Stableford)")]
        [DataMember(Name = "Format", Order = 20)]
        public string Format { get; set; }

        /// <summary>
        /// The details of the rounds of this tournament
        /// </summary>
        [Description("The details of the rounds of this tournament")]
        [DataMember(Name = "Rounds", Order = 20021)]
        public Round[] Rounds { get; set; }

        /// <summary>
        /// The unique ID of this tournament in the SportRadar API
        /// </summary>
        [Description("The unique ID of this tournament in the SportRadar API")]
        [DataMember(Name = "SportRadarTournamentID", Order = 22)]
        public string SportRadarTournamentID { get; set; }

    }
}

