using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Play")]
    [Serializable]
    public partial class Play
    {
        /// <summary>
        /// Unique ID for each Play.
        /// </summary>
        [Description("Unique ID for each Play.")]
        [DataMember(Name = "PlayID", Order = 1)]
        public int PlayID { get; set; }

        /// <summary>
        /// The InningID of the Inning record, in which this Play occurred.
        /// </summary>
        [Description("The InningID of the Inning record, in which this Play occurred.")]
        [DataMember(Name = "InningID", Order = 2)]
        public int InningID { get; set; }

        /// <summary>
        /// The inning in which the play occurred.
        /// </summary>
        [Description("The inning in which the play occurred.")]
        [DataMember(Name = "InningNumber", Order = 3)]
        public int? InningNumber { get; set; }

        /// <summary>
        /// The inning half in which the play occurred.
        /// </summary>
        [Description("The inning half in which the play occurred.")]
        [DataMember(Name = "InningHalf", Order = 4)]
        public string InningHalf { get; set; }

        /// <summary>
        /// The order in which this play occurred.
        /// </summary>
        [Description("The order in which this play occurred.")]
        [DataMember(Name = "PlayNumber", Order = 5)]
        public int? PlayNumber { get; set; }

        /// <summary>
        /// The batter number in the inning where the play occurred.
        /// </summary>
        [Description("The batter number in the inning where the play occurred.")]
        [DataMember(Name = "InningBatterNumber", Order = 6)]
        public int? InningBatterNumber { get; set; }

        /// <summary>
        /// Number of away team runs in the inning
        /// </summary>
        [Description("Number of away team runs in the inning")]
        [DataMember(Name = "AwayTeamRuns", Order = 7)]
        public int? AwayTeamRuns { get; set; }

        /// <summary>
        /// Number of home team runs in the inning.
        /// </summary>
        [Description("Number of home team runs in the inning.")]
        [DataMember(Name = "HomeTeamRuns", Order = 8)]
        public int? HomeTeamRuns { get; set; }

        /// <summary>
        /// The HitterID who represents the play.
        /// </summary>
        [Description("The HitterID who represents the play.")]
        [DataMember(Name = "HitterID", Order = 9)]
        public int? HitterID { get; set; }

        /// <summary>
        /// The PitcherID who represents the play.
        /// </summary>
        [Description("The PitcherID who represents the play.")]
        [DataMember(Name = "PitcherID", Order = 10)]
        public int? PitcherID { get; set; }

        /// <summary>
        /// The ID of the hitter's team.
        /// </summary>
        [Description("The ID of the hitter's team.")]
        [DataMember(Name = "HitterTeamID", Order = 11)]
        public int? HitterTeamID { get; set; }

        /// <summary>
        /// The ID of the pitcher's team.
        /// </summary>
        [Description("The ID of the pitcher's team.")]
        [DataMember(Name = "PitcherTeamID", Order = 12)]
        public int? PitcherTeamID { get; set; }

        /// <summary>
        /// The name of the hitter in the play.
        /// </summary>
        [Description("The name of the hitter in the play.")]
        [DataMember(Name = "HitterName", Order = 13)]
        public string HitterName { get; set; }

        /// <summary>
        /// The name of the pitcher in the play.
        /// </summary>
        [Description("The name of the pitcher in the play.")]
        [DataMember(Name = "PitcherName", Order = 14)]
        public string PitcherName { get; set; }

        /// <summary>
        /// The throwing hand of the pitcher in which the play occurred. (right or left)
        /// </summary>
        [Description("The throwing hand of the pitcher in which the play occurred. (right or left)")]
        [DataMember(Name = "PitcherThrowHand", Order = 15)]
        public string PitcherThrowHand { get; set; }

        /// <summary>
        /// The hand of the batter in which the play occurred. (right, left, or switch)
        /// </summary>
        [Description("The hand of the batter in which the play occurred. (right, left, or switch)")]
        [DataMember(Name = "HitterBatHand", Order = 16)]
        public string HitterBatHand { get; set; }

        /// <summary>
        /// The position of the player in which the play occrred. (P,C,1B, SS, OF)
        /// </summary>
        [Description("The position of the player in which the play occrred. (P,C,1B, SS, OF)")]
        [DataMember(Name = "HitterPosition", Order = 17)]
        public string HitterPosition { get; set; }

        /// <summary>
        /// The number of outs in which the play occurred.
        /// </summary>
        [Description("The number of outs in which the play occurred.")]
        [DataMember(Name = "Outs", Order = 18)]
        public int? Outs { get; set; }

        /// <summary>
        /// The number of balls in the count in which the play occurred.
        /// </summary>
        [Description("The number of balls in the count in which the play occurred.")]
        [DataMember(Name = "Balls", Order = 19)]
        public int? Balls { get; set; }

        /// <summary>
        /// The number of strikes in the count in which the play occurred.
        /// </summary>
        [Description("The number of strikes in the count in which the play occurred.")]
        [DataMember(Name = "Strikes", Order = 20)]
        public int? Strikes { get; set; }

        /// <summary>
        /// The number of pitchers in the at bat in which the play occurred.
        /// </summary>
        [Description("The number of pitchers in the at bat in which the play occurred.")]
        [DataMember(Name = "PitchNumberThisAtBat", Order = 21)]
        public int? PitchNumberThisAtBat { get; set; }

        /// <summary>
        /// The result of the play. Possible values include: Batter's Interference, Bunted into Double Play, Catcher's Interference, Double, Error, Fielder's Choice, Fly into Double Play, Fly Out, Foul Out, Fouled into Double Play, Ground into Double Play, Ground Out, Hit by Pitch, Home Run, Infield Fly Out, Intentional Walk, Line into Double Play, Lineout, Pop Out, Popped into Double Play, Sacrifice, Sacrifice Fly, Single, Strikeout Bunting, Strikeout Looking, Strikeout Swinging, Triple, Triple Play, Walk
        /// </summary>
        [Description("The result of the play. Possible values include: Batter's Interference, Bunted into Double Play, Catcher's Interference, Double, Error, Fielder's Choice, Fly into Double Play, Fly Out, Foul Out, Fouled into Double Play, Ground into Double Play, Ground Out, Hit by Pitch, Home Run, Infield Fly Out, Intentional Walk, Line into Double Play, Lineout, Pop Out, Popped into Double Play, Sacrifice, Sacrifice Fly, Single, Strikeout Bunting, Strikeout Looking, Strikeout Swinging, Triple, Triple Play, Walk")]
        [DataMember(Name = "Result", Order = 22)]
        public string Result { get; set; }

        /// <summary>
        /// The number of outs recorded on the play.
        /// </summary>
        [Description("The number of outs recorded on the play.")]
        [DataMember(Name = "NumberOfOutsOnPlay", Order = 23)]
        public int? NumberOfOutsOnPlay { get; set; }

        /// <summary>
        /// The number of runs batted in on the play.
        /// </summary>
        [Description("The number of runs batted in on the play.")]
        [DataMember(Name = "RunsBattedIn", Order = 24)]
        public int? RunsBattedIn { get; set; }

        /// <summary>
        /// Whether this play resulted in an at bat. (true/false)
        /// </summary>
        [Description("Whether this play resulted in an at bat. (true/false)")]
        [DataMember(Name = "AtBat", Order = 25)]
        public bool? AtBat { get; set; }

        /// <summary>
        /// Whether this play resulted in a strikeout. (true/false)
        /// </summary>
        [Description("Whether this play resulted in a strikeout. (true/false)")]
        [DataMember(Name = "Strikeout", Order = 26)]
        public bool? Strikeout { get; set; }

        /// <summary>
        /// Whether this play resulted in a walk. (true/false)
        /// </summary>
        [Description("Whether this play resulted in a walk. (true/false)")]
        [DataMember(Name = "Walk", Order = 27)]
        public bool? Walk { get; set; }

        /// <summary>
        /// Whether this play resulted in a hit. (true/false)
        /// </summary>
        [Description("Whether this play resulted in a hit. (true/false)")]
        [DataMember(Name = "Hit", Order = 28)]
        public bool? Hit { get; set; }

        /// <summary>
        /// Whether this play resutled in an out. (true/false)
        /// </summary>
        [Description("Whether this play resutled in an out. (true/false)")]
        [DataMember(Name = "Out", Order = 29)]
        public bool? Out { get; set; }

        /// <summary>
        /// Whether this play resulted in a sacrifice. (true/false)
        /// </summary>
        [Description("Whether this play resulted in a sacrifice. (true/false)")]
        [DataMember(Name = "Sacrifice", Order = 30)]
        public bool? Sacrifice { get; set; }

        /// <summary>
        /// Whether this play resulted in an error. (true/false)
        /// </summary>
        [Description("Whether this play resulted in an error. (true/false)")]
        [DataMember(Name = "Error", Order = 31)]
        public bool? Error { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was last updated.
        /// </summary>
        [Description("The database generated timestamp of when this Play was last updated.")]
        [DataMember(Name = "Updated", Order = 32)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The description of the play for display purposes
        /// </summary>
        [Description("The description of the play for display purposes")]
        [DataMember(Name = "Description", Order = 33)]
        public string Description { get; set; }

        /// <summary>
        /// The details of the pitches associated with this Play
        /// </summary>
        [Description("The details of the pitches associated with this Play")]
        [DataMember(Name = "Pitches", Order = 20034)]
        public Pitch[] Pitches { get; set; }

    }
}

