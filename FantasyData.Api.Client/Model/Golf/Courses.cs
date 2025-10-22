using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Courses")]
    [Serializable]
    public partial class Courses
    {
        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The name of the tournament that is being played at this course
        /// </summary>
        [Description("The name of the tournament that is being played at this course")]
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
        /// The name of the venue where this tournament takes place
        /// </summary>
        [Description("The name of the venue where this tournament takes place")]
        [DataMember(Name = "Venue", Order = 5)]
        public string Venue { get; set; }

        /// <summary>
        /// The location of this course
        /// </summary>
        [Description("The location of this course")]
        [DataMember(Name = "Location", Order = 6)]
        public string Location { get; set; }

        /// <summary>
        /// The 18-hole par of this course
        /// </summary>
        [Description("The 18-hole par of this course")]
        [DataMember(Name = "Par", Order = 7)]
        public int? Par { get; set; }

        /// <summary>
        /// The total course yardage
        /// </summary>
        [Description("The total course yardage")]
        [DataMember(Name = "Yards", Order = 8)]
        public int? Yards { get; set; }

        /// <summary>
        /// The total prize money of this tournament
        /// </summary>
        [Description("The total prize money of this tournament")]
        [DataMember(Name = "Purse", Order = 9)]
        public decimal? Purse { get; set; }

        /// <summary>
        /// The city where this course is located
        /// </summary>
        [Description("The city where this course is located")]
        [DataMember(Name = "City", Order = 10)]
        public string City { get; set; }

        /// <summary>
        /// The state where this course is located
        /// </summary>
        [Description("The state where this course is located")]
        [DataMember(Name = "State", Order = 11)]
        public string State { get; set; }

        /// <summary>
        /// The zip code where this course is located
        /// </summary>
        [Description("The zip code where this course is located")]
        [DataMember(Name = "ZipCode", Order = 12)]
        public string ZipCode { get; set; }

        /// <summary>
        /// The country where this course is located
        /// </summary>
        [Description("The country where this course is located")]
        [DataMember(Name = "Country", Order = 13)]
        public string Country { get; set; }

        /// <summary>
        /// The description of the time zone in which the course is located
        /// </summary>
        [Description("The description of the time zone in which the course is located")]
        [DataMember(Name = "TimeZone", Order = 14)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The format of the tournament (possible values: Stroke, Match, Team, Stableford)
        /// </summary>
        [Description("The format of the tournament (possible values: Stroke, Match, Team, Stableford)")]
        [DataMember(Name = "Format", Order = 15)]
        public string Format { get; set; }

    }
}

