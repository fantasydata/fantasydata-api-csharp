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
        /// The unique id of the game
        /// </summary>
        [Description("The unique id of the game")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The period of the score
        /// </summary>
        [Description("The period of the score")]
        [DataMember(Name = "Period", Order = 3)]
        public string Period { get; set; }

        /// <summary>
        /// The time remaining in minutes of the given period. Will be empty in OTs.
        /// </summary>
        [Description("The time remaining in minutes of the given period. Will be empty in OTs.")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 4)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// The time remaining in seconds of the given period. Will be empty in OTs.
        /// </summary>
        [Description("The time remaining in seconds of the given period. Will be empty in OTs.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 5)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The description of the play.
        /// </summary>
        [Description("The description of the play.")]
        [DataMember(Name = "Description", Order = 6)]
        public string Description { get; set; }

        /// <summary>
        /// The summary of the drive in plays, yards and time taken
        /// </summary>
        [Description("The summary of the drive in plays, yards and time taken")]
        [DataMember(Name = "DriveSummary", Order = 7)]
        public string DriveSummary { get; set; }

        /// <summary>
        /// The score of the home team after the play
        /// </summary>
        [Description("The score of the home team after the play")]
        [DataMember(Name = "HomeTeamScore", Order = 8)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The score of the away team after the play
        /// </summary>
        [Description("The score of the away team after the play")]
        [DataMember(Name = "AwayTeamScore", Order = 9)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The id of the team who scored
        /// </summary>
        [Description("The id of the team who scored")]
        [DataMember(Name = "ScoringTeamID", Order = 10)]
        public int? ScoringTeamID { get; set; }

        /// <summary>
        /// The type of score (ex TD, FG, SF, D2P for Touchdown, Field Goal, Safety, Defensive 2pt conversion respectively)
        /// </summary>
        [Description("The type of score (ex TD, FG, SF, D2P for Touchdown, Field Goal, Safety, Defensive 2pt conversion respectively)")]
        [DataMember(Name = "ScoringType", Order = 11)]
        public string ScoringType { get; set; }

        /// <summary>
        /// The order in which the scoring plays happened.
        /// </summary>
        [Description("The order in which the scoring plays happened.")]
        [DataMember(Name = "Sequence", Order = 12)]
        public int Sequence { get; set; }

    }
}

