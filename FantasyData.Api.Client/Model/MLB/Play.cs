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
        /// The unique ID of the play assigned by SportsDataIO
        /// </summary>
        [Description("The unique ID of the play assigned by SportsDataIO")]
        [DataMember(Name = "PlayID", Order = 1)]
        public int PlayID { get; set; }

        /// <summary>
        /// The unique ID associated with this specific inning in which the play occurred
        /// </summary>
        [Description("The unique ID associated with this specific inning in which the play occurred")]
        [DataMember(Name = "InningID", Order = 2)]
        public int InningID { get; set; }

        /// <summary>
        /// The inning number in which the particular play occurred
        /// </summary>
        [Description("The inning number in which the particular play occurred")]
        [DataMember(Name = "InningNumber", Order = 3)]
        public int? InningNumber { get; set; }

        /// <summary>
        /// The inning half that the game is currently in; or the inning half in which the game ended (possible values: T; B; E: M: NULL)
        /// </summary>
        [Description("The inning half that the game is currently in; or the inning half in which the game ended (possible values: T; B; E: M: NULL)")]
        [DataMember(Name = "InningHalf", Order = 4)]
        public string InningHalf { get; set; }

        /// <summary>
        /// The order in which plays occurred in a game
        /// </summary>
        [Description("The order in which plays occurred in a game")]
        [DataMember(Name = "PlayNumber", Order = 5)]
        public int? PlayNumber { get; set; }

        /// <summary>
        /// The batter number in the inning where the play occurred.
        /// </summary>
        [Description("The batter number in the inning where the play occurred.")]
        [DataMember(Name = "InningBatterNumber", Order = 6)]
        public int? InningBatterNumber { get; set; }

        /// <summary>
        /// Number of runs scored by the away team on this specific play
        /// </summary>
        [Description("Number of runs scored by the away team on this specific play")]
        [DataMember(Name = "AwayTeamRuns", Order = 7)]
        public int? AwayTeamRuns { get; set; }

        /// <summary>
        /// Number of runs scored by the home team on this specific play
        /// </summary>
        [Description("Number of runs scored by the home team on this specific play")]
        [DataMember(Name = "HomeTeamRuns", Order = 8)]
        public int? HomeTeamRuns { get; set; }

        /// <summary>
        /// The unique PlayerID of the hitter involved with the play
        /// </summary>
        [Description("The unique PlayerID of the hitter involved with the play")]
        [DataMember(Name = "HitterID", Order = 9)]
        public int? HitterID { get; set; }

        /// <summary>
        /// The PlayerID of the pitcher involved in the play
        /// </summary>
        [Description("The PlayerID of the pitcher involved in the play")]
        [DataMember(Name = "PitcherID", Order = 10)]
        public int? PitcherID { get; set; }

        /// <summary>
        /// The TeamID of the hitter's team.
        /// </summary>
        [Description("The TeamID of the hitter's team.")]
        [DataMember(Name = "HitterTeamID", Order = 11)]
        public int? HitterTeamID { get; set; }

        /// <summary>
        /// The ID of the pitcher's team
        /// </summary>
        [Description("The ID of the pitcher's team")]
        [DataMember(Name = "PitcherTeamID", Order = 12)]
        public int? PitcherTeamID { get; set; }

        /// <summary>
        /// The first and last name of the hitter involved in the play
        /// </summary>
        [Description("The first and last name of the hitter involved in the play")]
        [DataMember(Name = "HitterName", Order = 13)]
        public string HitterName { get; set; }

        /// <summary>
        /// The full name of the pitcher involved in the play
        /// </summary>
        [Description("The full name of the pitcher involved in the play")]
        [DataMember(Name = "PitcherName", Order = 14)]
        public string PitcherName { get; set; }

        /// <summary>
        /// The throwing hand of the pitcher in which the play occurred. (right or left)
        /// </summary>
        [Description("The throwing hand of the pitcher in which the play occurred. (right or left)")]
        [DataMember(Name = "PitcherThrowHand", Order = 15)]
        public string PitcherThrowHand { get; set; }

        /// <summary>
        /// The batter's handedness for which the play occurred. (R; L; S)
        /// </summary>
        [Description("The batter's handedness for which the play occurred. (R; L; S)")]
        [DataMember(Name = "HitterBatHand", Order = 16)]
        public string HitterBatHand { get; set; }

        /// <summary>
        /// TheÂ position of the player in which the play occrred. (e.g. P;C;1B; SS; OF)
        /// </summary>
        [Description("TheÂ position of the player in which the play occrred. (e.g. P;C;1B; SS; OF)")]
        [DataMember(Name = "HitterPosition", Order = 17)]
        public string HitterPosition { get; set; }

        /// <summary>
        /// The number of outs in which the play occurred
        /// </summary>
        [Description("The number of outs in which the play occurred")]
        [DataMember(Name = "Outs", Order = 18)]
        public int? Outs { get; set; }

        /// <summary>
        /// The number of balls in the count in which the play occurred
        /// </summary>
        [Description("The number of balls in the count in which the play occurred")]
        [DataMember(Name = "Balls", Order = 19)]
        public int? Balls { get; set; }

        /// <summary>
        /// The number of strikes in the count in which the play occurred
        /// </summary>
        [Description("The number of strikes in the count in which the play occurred")]
        [DataMember(Name = "Strikes", Order = 20)]
        public int? Strikes { get; set; }

        /// <summary>
        /// The number of pitches in the at bat in which the play occurred
        /// </summary>
        [Description("The number of pitches in the at bat in which the play occurred")]
        [DataMember(Name = "PitchNumberThisAtBat", Order = 21)]
        public int? PitchNumberThisAtBat { get; set; }

        /// <summary>
        /// The result of the play. Possible values include: Batter's Interference, Bunted into Double Play, Catcher's Interference, Double, Error, Fielder's Choice, Fly into Double Play, Fly Out, Foul Out, Fouled into Double Play, Ground into Double Play, Ground Out, Hit by Pitch, Home Run, Infield Fly Out, Intentional Walk, Line into Double Play, Lineout, Pop Out, Popped into Double Play, Sacrifice, Sacrifice Fly, Single, Strikeout Bunting, Strikeout Looking, Strikeout Swinging, Triple, Triple Play, Walk, Stolen Base, Caught Stealing, Passed Ball, Wild Pitch, Pick Off, Balk, Error, Fielders Indifference
        /// </summary>
        [Description("The result of the play. Possible values include: Batter's Interference, Bunted into Double Play, Catcher's Interference, Double, Error, Fielder's Choice, Fly into Double Play, Fly Out, Foul Out, Fouled into Double Play, Ground into Double Play, Ground Out, Hit by Pitch, Home Run, Infield Fly Out, Intentional Walk, Line into Double Play, Lineout, Pop Out, Popped into Double Play, Sacrifice, Sacrifice Fly, Single, Strikeout Bunting, Strikeout Looking, Strikeout Swinging, Triple, Triple Play, Walk, Stolen Base, Caught Stealing, Passed Ball, Wild Pitch, Pick Off, Balk, Error, Fielders Indifference")]
        [DataMember(Name = "Result", Order = 22)]
        public string Result { get; set; }

        /// <summary>
        /// The number of outs recorded on the play
        /// </summary>
        [Description("The number of outs recorded on the play")]
        [DataMember(Name = "NumberOfOutsOnPlay", Order = 23)]
        public int? NumberOfOutsOnPlay { get; set; }

        /// <summary>
        /// The number of runs batted in on the play
        /// </summary>
        [Description("The number of runs batted in on the play")]
        [DataMember(Name = "RunsBattedIn", Order = 24)]
        public int? RunsBattedIn { get; set; }

        /// <summary>
        /// Whether this plate appearance resulted in an at bat
        /// </summary>
        [Description("Whether this plate appearance resulted in an at bat")]
        [DataMember(Name = "AtBat", Order = 25)]
        public bool? AtBat { get; set; }

        /// <summary>
        /// Whether the play resulted with a strikeout (returns true/false)
        /// </summary>
        [Description("Whether the play resulted with a strikeout (returns true/false)")]
        [DataMember(Name = "Strikeout", Order = 26)]
        public bool? Strikeout { get; set; }

        /// <summary>
        /// Indicates whether the play resulted in a walk for the hitter (returns true/false)
        /// </summary>
        [Description("Indicates whether the play resulted in a walk for the hitter (returns true/false)")]
        [DataMember(Name = "Walk", Order = 27)]
        public bool? Walk { get; set; }

        /// <summary>
        /// Whether this play resulted in a hit (true/false)
        /// </summary>
        [Description("Whether this play resulted in a hit (true/false)")]
        [DataMember(Name = "Hit", Order = 28)]
        public bool? Hit { get; set; }

        /// <summary>
        /// Whether this play resutled in an out (true/false)
        /// </summary>
        [Description("Whether this play resutled in an out (true/false)")]
        [DataMember(Name = "Out", Order = 29)]
        public bool? Out { get; set; }

        /// <summary>
        /// Whether the play resulted in a sacrifice (returns true/false)
        /// </summary>
        [Description("Whether the play resulted in a sacrifice (returns true/false)")]
        [DataMember(Name = "Sacrifice", Order = 30)]
        public bool? Sacrifice { get; set; }

        /// <summary>
        /// Whether this play resulted in an error (true/false)
        /// </summary>
        [Description("Whether this play resulted in an error (true/false)")]
        [DataMember(Name = "Error", Order = 31)]
        public bool? Error { get; set; }

        /// <summary>
        /// The database generated timestamp of when this record was last updated (in US Eastern Time)
        /// </summary>
        [Description("The database generated timestamp of when this record was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 32)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The description of the play for display purposes
        /// </summary>
        [Description("The description of the play for display purposes")]
        [DataMember(Name = "Description", Order = 33)]
        public string Description { get; set; }

        /// <summary>
        /// The details of the pitches associated with this play
        /// </summary>
        [Description("The details of the pitches associated with this play")]
        [DataMember(Name = "Pitches", Order = 20034)]
        public Pitch[] Pitches { get; set; }

        /// <summary>
        /// The PlayerID of the player on first as a result of the play (post-play)
        /// </summary>
        [Description("The PlayerID of the player on first as a result of the play (post-play)")]
        [DataMember(Name = "Runner1ID", Order = 35)]
        public int? Runner1ID { get; set; }

        /// <summary>
        /// The PlayerID of the player on second as a result of the play (post-play)
        /// </summary>
        [Description("The PlayerID of the player on second as a result of the play (post-play)")]
        [DataMember(Name = "Runner2ID", Order = 36)]
        public int? Runner2ID { get; set; }

        /// <summary>
        /// The PlayerID of the player on third as a result of the play (post-play)
        /// </summary>
        [Description("The PlayerID of the player on third as a result of the play (post-play)")]
        [DataMember(Name = "Runner3ID", Order = 37)]
        public int? Runner3ID { get; set; }

    }
}

