using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Play")]
    [Serializable]
    public partial class Play
    {
        /// <summary>
        /// The unique ID of the play
        /// </summary>
        [Description("The unique ID of the play")]
        [DataMember(Name = "PlayID", Order = 1)]
        public int PlayID { get; set; }

        /// <summary>
        /// The unique ID of the quarter in which the play occurred
        /// </summary>
        [Description("The unique ID of the quarter in which the play occurred")]
        [DataMember(Name = "QuarterID", Order = 2)]
        public int QuarterID { get; set; }

        /// <summary>
        /// The name of the quarter in which the play occurred
        /// </summary>
        [Description("The name of the quarter in which the play occurred")]
        [DataMember(Name = "QuarterName", Order = 3)]
        public string QuarterName { get; set; }

        /// <summary>
        /// The order in which this play and/or event happened over the course of the game
        /// </summary>
        [Description("The order in which this play and/or event happened over the course of the game")]
        [DataMember(Name = "Sequence", Order = 4)]
        public int? Sequence { get; set; }

        /// <summary>
        /// The minutes of the time remaining in the Quarter, when this play occurred.
        /// </summary>
        [Description("The minutes of the time remaining in the Quarter, when this play occurred.")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 5)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// The seconds of the time remaining in the Quarter, when this play occurred.
        /// </summary>
        [Description("The seconds of the time remaining in the Quarter, when this play occurred.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 6)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The estimated timestamp of when this Play occurred on the field. Please note that we do not have scouts at the venue; so this is an estimate based on our TV feed and estimated TV feed delay
        /// </summary>
        [Description("The estimated timestamp of when this Play occurred on the field. Please note that we do not have scouts at the venue; so this is an estimate based on our TV feed and estimated TV feed delay")]
        [DataMember(Name = "PlayTime", Order = 7)]
        public DateTime? PlayTime { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was last updated (in US Eastern time)
        /// </summary>
        [Description("The database generated timestamp of when this Play was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was first created (in US Eastern Time)
        /// </summary>
        [Description("The database generated timestamp of when this Play was first created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 9)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that completed the play
        /// </summary>
        [Description("The abbreviation [Key] of the team that completed the play")]
        [DataMember(Name = "Team", Order = 10)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent of the team that this play relates to
        /// </summary>
        [Description("The abbreviation [Key] of the opponent of the team that this play relates to")]
        [DataMember(Name = "Opponent", Order = 11)]
        public string Opponent { get; set; }

        /// <summary>
        /// The Down when this Play occurred.
        /// </summary>
        [Description("The Down when this Play occurred.")]
        [DataMember(Name = "Down", Order = 12)]
        public int? Down { get; set; }

        /// <summary>
        /// The yards to go for a first down. Note: this can be any positive number or "Goal"
        /// </summary>
        [Description("The yards to go for a first down. Note: this can be any positive number or \"Goal\"")]
        [DataMember(Name = "Distance", Order = 13)]
        public int? Distance { get; set; }

        /// <summary>
        /// the yard line of the ball's current position on the field when this play occurred
        /// </summary>
        [Description("the yard line of the ball's current position on the field when this play occurred")]
        [DataMember(Name = "YardLine", Order = 14)]
        public int? YardLine { get; set; }

        /// <summary>
        /// The team's side of the field that the ball is on when the play occurred
        /// </summary>
        [Description("The team's side of the field that the ball is on when the play occurred")]
        [DataMember(Name = "YardLineTerritory", Order = 15)]
        public string YardLineTerritory { get; set; }

        /// <summary>
        /// The number of yards to go to reach the end zone at the start of the play
        /// </summary>
        [Description("The number of yards to go to reach the end zone at the start of the play")]
        [DataMember(Name = "YardsToEndZone", Order = 16)]
        public int? YardsToEndZone { get; set; }

        /// <summary>
        /// The Type of Play that occurred (possible values: Rush, PassCompleted, PassIncomplete, PassIntercepted, TwoPointConversion, Punt, Kickoff, FieldGoal, ExtraPoint, Fumble, Penalty, Sack, Timeout, Period)
        /// </summary>
        [Description("The Type of Play that occurred (possible values: Rush, PassCompleted, PassIncomplete, PassIntercepted, TwoPointConversion, Punt, Kickoff, FieldGoal, ExtraPoint, Fumble, Penalty, Sack, Timeout, Period)")]
        [DataMember(Name = "Type", Order = 17)]
        public string Type { get; set; }

        /// <summary>
        /// The number of yards gained or lost on the play
        /// </summary>
        [Description("The number of yards gained or lost on the play")]
        [DataMember(Name = "YardsGained", Order = 18)]
        public int? YardsGained { get; set; }

        /// <summary>
        /// The description of the Play.
        /// </summary>
        [Description("The description of the Play.")]
        [DataMember(Name = "Description", Order = 19)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether this Play was a scoring play.
        /// </summary>
        [Description("Indicates whether this Play was a scoring play.")]
        [DataMember(Name = "IsScoringPlay", Order = 20)]
        public bool? IsScoringPlay { get; set; }

        /// <summary>
        /// The details of the scoring play attached to this play (if any).
        /// </summary>
        [Description("The details of the scoring play attached to this play (if any).")]
        [DataMember(Name = "ScoringPlay", Order = 10021)]
        public ScoringPlay ScoringPlay { get; set; }

        /// <summary>
        /// The list of player stats accumulated during the play
        /// </summary>
        [Description("The list of player stats accumulated during the play")]
        [DataMember(Name = "PlayStats", Order = 20022)]
        public PlayStat[] PlayStats { get; set; }

    }
}

