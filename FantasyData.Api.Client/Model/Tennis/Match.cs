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
        /// The unique ID of the match
        /// </summary>
        [Description("The unique ID of the match")]
        [DataMember(Name = "MatchId", Order = 1)]
        public int MatchId { get; set; }

        /// <summary>
        /// The ID of the round that the match takes place within
        /// </summary>
        [Description("The ID of the round that the match takes place within")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// The venue where the match is played
        /// </summary>
        [Description("The venue where the match is played")]
        [DataMember(Name = "VenueDetails", Order = 10003)]
        public Venue VenueDetails { get; set; }

        /// <summary>
        /// Day that the Match is scheduled to be played
        /// </summary>
        [Description("Day that the Match is scheduled to be played")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// Date and time that the Match is scheduled to be played (in US Eastern Time)
        /// </summary>
        [Description("Date and time that the Match is scheduled to be played (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The unique ID of contestant A
        /// </summary>
        [Description("The unique ID of contestant A")]
        [DataMember(Name = "ContestantAID", Order = 6)]
        public int ContestantAID { get; set; }

        /// <summary>
        /// The name of the first (or single) player of contestant A
        /// </summary>
        [Description("The name of the first (or single) player of contestant A")]
        [DataMember(Name = "ContestantA1Name", Order = 7)]
        public string ContestantA1Name { get; set; }

        /// <summary>
        /// The name of the second player (if doubles) of contestant A
        /// </summary>
        [Description("The name of the second player (if doubles) of contestant A")]
        [DataMember(Name = "ContestantA2Name", Order = 8)]
        public string ContestantA2Name { get; set; }

        /// <summary>
        /// The unique ID of contestant B
        /// </summary>
        [Description("The unique ID of contestant B")]
        [DataMember(Name = "ContestantBID", Order = 9)]
        public int ContestantBID { get; set; }

        /// <summary>
        /// The name of the first (or single) player of contestant B
        /// </summary>
        [Description("The name of the first (or single) player of contestant B")]
        [DataMember(Name = "ContestantB1Name", Order = 10)]
        public string ContestantB1Name { get; set; }

        /// <summary>
        /// The name of the second player (if doubles) of contestant B
        /// </summary>
        [Description("The name of the second player (if doubles) of contestant B")]
        [DataMember(Name = "ContestantB2Name", Order = 11)]
        public string ContestantB2Name { get; set; }

        /// <summary>
        /// Status of the match. For a complete list of statuses, see <a href="https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status" target="_blank">here</a>.
        /// </summary>
        [Description("Status of the match. For a complete list of statuses, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status\" target=\"_blank\">here</a>.")]
        [DataMember(Name = "Status", Order = 12)]
        public string Status { get; set; }

        /// <summary>
        /// The contestant ID of the match winner
        /// </summary>
        [Description("The contestant ID of the match winner")]
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
        /// Timestamp of the last update of this record (in US Eastern Time)
        /// </summary>
        [Description("Timestamp of the last update of this record (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 18)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Timestamp of this record's creation (in US Eastern Time)
        /// </summary>
        [Description("Timestamp of this record's creation (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 19)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Latest Odds for this Match
        /// </summary>
        [Description("Latest Odds for this Match")]
        [DataMember(Name = "MatchOdds", Order = 20020)]
        public MatchOdd[] MatchOdds { get; set; }

        /// <summary>
        /// A globally unique ID for this match. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this match. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalMatchId", Order = 21)]
        public int GlobalMatchId { get; set; }

    }
}

