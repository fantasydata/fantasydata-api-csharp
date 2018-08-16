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
        /// Unique identifier for each Play.
        /// </summary>
        [Description("Unique identifier for each Play.")]
        [DataMember(Name = "PlayID", Order = 1)]
        public int PlayID { get; set; }

        /// <summary>
        /// The QuarterID of the Quarter record, in which this Play occurred.
        /// </summary>
        [Description("The QuarterID of the Quarter record, in which this Play occurred.")]
        [DataMember(Name = "QuarterID", Order = 2)]
        public int QuarterID { get; set; }

        /// <summary>
        /// The Name of the Quarter, in which this Play occurred.
        /// </summary>
        [Description("The Name of the Quarter, in which this Play occurred.")]
        [DataMember(Name = "QuarterName", Order = 3)]
        public string QuarterName { get; set; }

        /// <summary>
        /// The order in which this Play / Event happened over the course of the Game.
        /// </summary>
        [Description("The order in which this Play / Event happened over the course of the Game.")]
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
        /// The estimated timestamp of when this Play occurred on the field. Please note that we do not have scouts at the venue, so this is an estimate based on our TV feed and estimated TV feed delay.
        /// </summary>
        [Description("The estimated timestamp of when this Play occurred on the field. Please note that we do not have scouts at the venue, so this is an estimate based on our TV feed and estimated TV feed delay.")]
        [DataMember(Name = "PlayTime", Order = 7)]
        public DateTime? PlayTime { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was last updated.
        /// </summary>
        [Description("The database generated timestamp of when this Play was last updated.")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was first created.
        /// </summary>
        [Description("The database generated timestamp of when this Play was first created.")]
        [DataMember(Name = "Created", Order = 9)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The abbreviation of the Team that this Play was executed by.
        /// </summary>
        [Description("The abbreviation of the Team that this Play was executed by.")]
        [DataMember(Name = "Team", Order = 10)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation of the Opponent of the Team that this Play was executed by.
        /// </summary>
        [Description("The abbreviation of the Opponent of the Team that this Play was executed by.")]
        [DataMember(Name = "Opponent", Order = 11)]
        public string Opponent { get; set; }

        /// <summary>
        /// The Down when this Play occurred.
        /// </summary>
        [Description("The Down when this Play occurred.")]
        [DataMember(Name = "Down", Order = 12)]
        public int? Down { get; set; }

        /// <summary>
        /// The Distance when this Play occurred.
        /// </summary>
        [Description("The Distance when this Play occurred.")]
        [DataMember(Name = "Distance", Order = 13)]
        public int? Distance { get; set; }

        /// <summary>
        /// The Yard Line of where this Play occurred.
        /// </summary>
        [Description("The Yard Line of where this Play occurred.")]
        [DataMember(Name = "YardLine", Order = 14)]
        public int? YardLine { get; set; }

        /// <summary>
        /// The Territory of the Yard Line of where this Play occurred.
        /// </summary>
        [Description("The Territory of the Yard Line of where this Play occurred.")]
        [DataMember(Name = "YardLineTerritory", Order = 15)]
        public string YardLineTerritory { get; set; }

        /// <summary>
        /// The number of yards to go to reach the end zone at the start of the Play.
        /// </summary>
        [Description("The number of yards to go to reach the end zone at the start of the Play.")]
        [DataMember(Name = "YardsToEndZone", Order = 16)]
        public int? YardsToEndZone { get; set; }

        /// <summary>
        /// The Type of Play that occurred (possible values: Rush, PassCompleted, PassIncomplete, PassIntercepted, TwoPointConversion, Punt, Kickoff, FieldGoal, ExtraPoint, Fumble, Penalty, Sack, Timeout, Period)
        /// </summary>
        [Description("The Type of Play that occurred (possible values: Rush, PassCompleted, PassIncomplete, PassIntercepted, TwoPointConversion, Punt, Kickoff, FieldGoal, ExtraPoint, Fumble, Penalty, Sack, Timeout, Period)")]
        [DataMember(Name = "Type", Order = 17)]
        public string Type { get; set; }

        /// <summary>
        /// The yards gained or lost on the play
        /// </summary>
        [Description("The yards gained or lost on the play")]
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
        /// The player stats accumulated during this play.
        /// </summary>
        [Description("The player stats accumulated during this play.")]
        [DataMember(Name = "PlayStats", Order = 20022)]
        public PlayStat[] PlayStats { get; set; }

    }
}

