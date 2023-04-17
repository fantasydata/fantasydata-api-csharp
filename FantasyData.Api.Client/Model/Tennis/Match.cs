using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Match")]
    [Serializable]
    public partial class Match
    {
        /// <summary>
        /// Unique ID of the Match
        /// </summary>
        [Description("Unique ID of the Match")]
        [DataMember(Name = "MatchId", Order = 1)]
        public int MatchId { get; set; }

        /// <summary>
        /// ID of the Round that the Match takes place within
        /// </summary>
        [Description("ID of the Round that the Match takes place within")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// Venue where the Match is played
        /// </summary>
        [Description("Venue where the Match is played")]
        [DataMember(Name = "VenueDetails", Order = 10003)]
        public Venue VenueDetails { get; set; }

        /// <summary>
        /// Day that the Match is scheduled to be played (UTC)
        /// </summary>
        [Description("Day that the Match is scheduled to be played (UTC)")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// Date and time that the Match is scheduled to be played (UTC)
        /// </summary>
        [Description("Date and time that the Match is scheduled to be played (UTC)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// ID of Contestant A
        /// </summary>
        [Description("ID of Contestant A")]
        [DataMember(Name = "ContestantAID", Order = 6)]
        public int ContestantAID { get; set; }

        /// <summary>
        /// Name of the first player of Contestant A
        /// </summary>
        [Description("Name of the first player of Contestant A")]
        [DataMember(Name = "ContestantA1Name", Order = 7)]
        public string ContestantA1Name { get; set; }

        /// <summary>
        /// Name of the second player of Contestant A
        /// </summary>
        [Description("Name of the second player of Contestant A")]
        [DataMember(Name = "ContestantA2Name", Order = 8)]
        public string ContestantA2Name { get; set; }

        /// <summary>
        /// ID of Contestant B
        /// </summary>
        [Description("ID of Contestant B")]
        [DataMember(Name = "ContestantBID", Order = 9)]
        public int ContestantBID { get; set; }

        /// <summary>
        /// Name of the first player of Contestant B
        /// </summary>
        [Description("Name of the first player of Contestant B")]
        [DataMember(Name = "ContestantB1Name", Order = 10)]
        public string ContestantB1Name { get; set; }

        /// <summary>
        /// Name of the second player of Contestant B
        /// </summary>
        [Description("Name of the second player of Contestant B")]
        [DataMember(Name = "ContestantB2Name", Order = 11)]
        public string ContestantB2Name { get; set; }

        /// <summary>
        /// Status of the Match
        /// </summary>
        [Description("Status of the Match")]
        [DataMember(Name = "Status", Order = 12)]
        public string Status { get; set; }

        /// <summary>
        /// Contestant ID of the Match winner
        /// </summary>
        [Description("Contestant ID of the Match winner")]
        [DataMember(Name = "WinnerContestantId", Order = 13)]
        public int WinnerContestantId { get; set; }

        /// <summary>
        /// Score of Contestant A, representing number of won sets
        /// </summary>
        [Description("Score of Contestant A, representing number of won sets")]
        [DataMember(Name = "ScoreA", Order = 14)]
        public int ScoreA { get; set; }

        /// <summary>
        /// Score of Contestant B, representing number of won sets
        /// </summary>
        [Description("Score of Contestant B, representing number of won sets")]
        [DataMember(Name = "ScoreB", Order = 15)]
        public int ScoreB { get; set; }

        /// <summary>
        /// Duration of the Match, in hours and minutes (hh:mm)
        /// </summary>
        [Description("Duration of the Match, in hours and minutes (hh:mm)")]
        [DataMember(Name = "Duration", Order = 16)]
        public string Duration { get; set; }

        /// <summary>
        /// List of the Periods (sets), including tiebreaks
        /// </summary>
        [Description("List of the Periods (sets), including tiebreaks")]
        [DataMember(Name = "Periods", Order = 20017)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// Timestamp of the last update of this record (ET)
        /// </summary>
        [Description("Timestamp of the last update of this record (ET)")]
        [DataMember(Name = "Updated", Order = 18)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Timestamp of this record's creation (ET)
        /// </summary>
        [Description("Timestamp of this record's creation (ET)")]
        [DataMember(Name = "Created", Order = 19)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Latest Odds for this Match
        /// </summary>
        [Description("Latest Odds for this Match")]
        [DataMember(Name = "MatchOdds", Order = 20020)]
        public MatchOdd[] MatchOdds { get; set; }

    }
}

