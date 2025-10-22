using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="ScoringPlay")]
    [Serializable]
    public partial class ScoringPlay
    {
        /// <summary>
        /// The unique id of the scoring play
        /// </summary>
        [Description("The unique id of the scoring play")]
        [DataMember(Name = "ScoringPlayID", Order = 1)]
        public int ScoringPlayID { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The period of the score
        /// </summary>
        [Description("The period of the score")]
        [DataMember(Name = "Period", Order = 3)]
        public string Period { get; set; }

        /// <summary>
        /// Total number of minutes remaining in the quarter when the scoring play happened
        /// </summary>
        [Description("Total number of minutes remaining in the quarter when the scoring play happened")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 4)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Total number of seconds remaining in the quarter when the scoring play happened
        /// </summary>
        [Description("Total number of seconds remaining in the quarter when the scoring play happened")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 5)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The description of the play
        /// </summary>
        [Description("The description of the play")]
        [DataMember(Name = "Description", Order = 6)]
        public string Description { get; set; }

        /// <summary>
        /// The summary of the drive in plays, yards and time elapsed
        /// </summary>
        [Description("The summary of the drive in plays, yards and time elapsed")]
        [DataMember(Name = "DriveSummary", Order = 7)]
        public string DriveSummary { get; set; }

        /// <summary>
        /// The score of the home team after the play
        /// </summary>
        [Description("The score of the home team after the play")]
        [DataMember(Name = "HomeTeamScore", Order = 8)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Total number of points of the away team after the play
        /// </summary>
        [Description("Total number of points of the away team after the play")]
        [DataMember(Name = "AwayTeamScore", Order = 9)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The ID of the team who scord on the play
        /// </summary>
        [Description("The ID of the team who scord on the play")]
        [DataMember(Name = "ScoringTeamID", Order = 10)]
        public int? ScoringTeamID { get; set; }

        /// <summary>
        /// The type of score on the play (ex. TD; FG; SF; D2P for Touchdown; Field Goal; Safety; Defensive 2pt conversion respectively)
        /// </summary>
        [Description("The type of score on the play (ex. TD; FG; SF; D2P for Touchdown; Field Goal; Safety; Defensive 2pt conversion respectively)")]
        [DataMember(Name = "ScoringType", Order = 11)]
        public string ScoringType { get; set; }

        /// <summary>
        /// The order in which the scoring plays happened
        /// </summary>
        [Description("The order in which the scoring plays happened")]
        [DataMember(Name = "Sequence", Order = 12)]
        public int Sequence { get; set; }

    }
}

