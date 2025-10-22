using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayStat")]
    [Serializable]
    public partial class PlayStat
    {
        /// <summary>
        /// The unique ID of the PlayStat on the play
        /// </summary>
        [Description("The unique ID of the PlayStat on the play")]
        [DataMember(Name = "PlayStatID", Order = 1)]
        public int PlayStatID { get; set; }

        /// <summary>
        /// The unique ID of the play in which the PlayStat occurred
        /// </summary>
        [Description("The unique ID of the play in which the PlayStat occurred")]
        [DataMember(Name = "PlayID", Order = 2)]
        public int PlayID { get; set; }

        /// <summary>
        /// The order in which the play stat was registered to the Play.
        /// </summary>
        [Description("The order in which the play stat was registered to the Play.")]
        [DataMember(Name = "Sequence", Order = 3)]
        public int Sequence { get; set; }

        /// <summary>
        /// The unique PlayerID of the player whose stats are tied to the play. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player whose stats are tied to the play. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The Name of the Player whose stats this represents.
        /// </summary>
        [Description("The Name of the Player whose stats this represents.")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team the player belongs to
        /// </summary>
        [Description("The abbreviation [Key] of the team the player belongs to")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team of the player who recorded the stat
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team of the player who recorded the stat")]
        [DataMember(Name = "Opponent", Order = 7)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the Player was Home or Away (possible values: HOME, AWAY)
        /// </summary>
        [Description("Whether the Player was Home or Away (possible values: HOME, AWAY)")]
        [DataMember(Name = "HomeOrAway", Order = 8)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The Direction this Play occurred (possible values: Left, Middle, Right)
        /// </summary>
        [Description("The Direction this Play occurred (possible values: Left, Middle, Right)")]
        [DataMember(Name = "Direction", Order = 9)]
        public string Direction { get; set; }

        /// <summary>
        /// The database generated timestamp of when this PlayStat was last updated (in US Eastern time)
        /// </summary>
        [Description("The database generated timestamp of when this PlayStat was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this PlayStat was first created (in US Eastern Time)
        /// </summary>
        [Description("The database generated timestamp of when this PlayStat was first created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 11)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Total passes thrown by the player on the play
        /// </summary>
        [Description("Total passes thrown by the player on the play")]
        [DataMember(Name = "PassingAttempts", Order = 12)]
        public int? PassingAttempts { get; set; }

        /// <summary>
        /// Total passing completions by the player on the play
        /// </summary>
        [Description("Total passing completions by the player on the play")]
        [DataMember(Name = "PassingCompletions", Order = 13)]
        public int? PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the player on the play
        /// </summary>
        [Description("Total passing yards by the player on the play")]
        [DataMember(Name = "PassingYards", Order = 14)]
        public int? PassingYards { get; set; }

        /// <summary>
        /// Total passing touchdowns thrown by the player on the play
        /// </summary>
        [Description("Total passing touchdowns thrown by the player on the play")]
        [DataMember(Name = "PassingTouchdowns", Order = 15)]
        public int? PassingTouchdowns { get; set; }

        /// <summary>
        /// Total interceptions thrown by the player on the play
        /// </summary>
        [Description("Total interceptions thrown by the player on the play")]
        [DataMember(Name = "PassingInterceptions", Order = 16)]
        public int? PassingInterceptions { get; set; }

        /// <summary>
        /// The total number of times the player was sacked on the play
        /// </summary>
        [Description("The total number of times the player was sacked on the play")]
        [DataMember(Name = "PassingSacks", Order = 17)]
        public int? PassingSacks { get; set; }

        /// <summary>
        /// Total yards lost by the player as a result of being sacked on the play
        /// </summary>
        [Description("Total yards lost by the player as a result of being sacked on the play")]
        [DataMember(Name = "PassingSackYards", Order = 18)]
        public int? PassingSackYards { get; set; }

        /// <summary>
        /// Rushing attempts by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Rushing attempts by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "RushingAttempts", Order = 19)]
        public int? RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the player on the play
        /// </summary>
        [Description("Total rushing yards by the player on the play")]
        [DataMember(Name = "RushingYards", Order = 20)]
        public int? RushingYards { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total rushing touchdowns by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "RushingTouchdowns", Order = 21)]
        public int? RushingTouchdowns { get; set; }

        /// <summary>
        /// Total receiving targets by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total receiving targets by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "ReceivingTargets", Order = 22)]
        public int? ReceivingTargets { get; set; }

        /// <summary>
        /// Total receptions by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total receptions by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "Receptions", Order = 23)]
        public int? Receptions { get; set; }

        /// <summary>
        /// Total receiving yards by the player on the play
        /// </summary>
        [Description("Total receiving yards by the player on the play")]
        [DataMember(Name = "ReceivingYards", Order = 24)]
        public int? ReceivingYards { get; set; }

        /// <summary>
        /// Total receiving touchdowns by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total receiving touchdowns by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 25)]
        public int? ReceivingTouchdowns { get; set; }

        /// <summary>
        /// Times the player fumbled on the play
        /// </summary>
        [Description("Times the player fumbled on the play")]
        [DataMember(Name = "Fumbles", Order = 26)]
        public int? Fumbles { get; set; }

        /// <summary>
        /// Fumbles lost by the player on the play
        /// </summary>
        [Description("Fumbles lost by the player on the play")]
        [DataMember(Name = "FumblesLost", Order = 27)]
        public int? FumblesLost { get; set; }

        /// <summary>
        /// Total two point conversion attempts by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total two point conversion attempts by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "TwoPointConversionAttempts", Order = 28)]
        public int? TwoPointConversionAttempts { get; set; }

        /// <summary>
        /// Total successful two point conversion passes by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total successful two point conversion passes by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "TwoPointConversionPasses", Order = 29)]
        public int? TwoPointConversionPasses { get; set; }

        /// <summary>
        /// Total two point conversion rushes by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total two point conversion rushes by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "TwoPointConversionRuns", Order = 30)]
        public int? TwoPointConversionRuns { get; set; }

        /// <summary>
        /// Total successful two point conversion receptions by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total successful two point conversion receptions by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "TwoPointConversionReceptions", Order = 31)]
        public int? TwoPointConversionReceptions { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total successful two point conversion returns by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 32)]
        public int? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "SoloTackles", Order = 33)]
        public int? SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the player on the play
        /// </summary>
        [Description("Total defensive assisted tackles by the player on the play")]
        [DataMember(Name = "AssistedTackles", Order = 34)]
        public int? AssistedTackles { get; set; }

        /// <summary>
        /// Tackles for loss of yards by the player on the play. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks) - also this field is expected to be 1 or 0
        /// </summary>
        [Description("Tackles for loss of yards by the player on the play. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks) - also this field is expected to be 1 or 0")]
        [DataMember(Name = "TacklesForLoss", Order = 35)]
        public int? TacklesForLoss { get; set; }

        /// <summary>
        /// Total Sacks by this player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total Sacks by this player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "Sacks", Order = 36)]
        public decimal? Sacks { get; set; }

        /// <summary>
        /// Total sack yards by this player on the play
        /// </summary>
        [Description("Total sack yards by this player on the play")]
        [DataMember(Name = "SackYards", Order = 37)]
        public decimal? SackYards { get; set; }

        /// <summary>
        /// Total passes defended by the player on the play
        /// </summary>
        [Description("Total passes defended by the player on the play")]
        [DataMember(Name = "PassesDefended", Order = 38)]
        public int? PassesDefended { get; set; }

        /// <summary>
        /// Total defensive safeties by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total defensive safeties by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "Safeties", Order = 39)]
        public int? Safeties { get; set; }

        /// <summary>
        /// Fumbles forced by the player on the play
        /// </summary>
        [Description("Fumbles forced by the player on the play")]
        [DataMember(Name = "FumblesForced", Order = 40)]
        public int? FumblesForced { get; set; }

        /// <summary>
        /// Defensive fumbles recovered by the player on the play
        /// </summary>
        [Description("Defensive fumbles recovered by the player on the play")]
        [DataMember(Name = "FumblesRecovered", Order = 41)]
        public int? FumblesRecovered { get; set; }

        /// <summary>
        /// Fumble recoveries returned yards by the player on the play
        /// </summary>
        [Description("Fumble recoveries returned yards by the player on the play")]
        [DataMember(Name = "FumbleReturnYards", Order = 42)]
        public int? FumbleReturnYards { get; set; }

        /// <summary>
        /// Fumble recoveries returned for touchdowns by the player on the play
        /// </summary>
        [Description("Fumble recoveries returned for touchdowns by the player on the play")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 43)]
        public int? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Interceptions by the player on the play
        /// </summary>
        [Description("Interceptions by the player on the play")]
        [DataMember(Name = "Interceptions", Order = 44)]
        public int? Interceptions { get; set; }

        /// <summary>
        /// Interception return yards by the player on the play
        /// </summary>
        [Description("Interception return yards by the player on the play")]
        [DataMember(Name = "InterceptionReturnYards", Order = 45)]
        public int? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Interception return touchdowns by the player on the play
        /// </summary>
        [Description("Interception return touchdowns by the player on the play")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 46)]
        public int? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total punts returned by the player on the play
        /// </summary>
        [Description("Total punts returned by the player on the play")]
        [DataMember(Name = "PuntReturns", Order = 47)]
        public int? PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the player on the play
        /// </summary>
        [Description("Total punt return yards by the player on the play")]
        [DataMember(Name = "PuntReturnYards", Order = 48)]
        public int? PuntReturnYards { get; set; }

        /// <summary>
        /// Punt returns for touchdowns by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Punt returns for touchdowns by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 49)]
        public int? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Kicks returned by the player on the play
        /// </summary>
        [Description("Kicks returned by the player on the play")]
        [DataMember(Name = "KickReturns", Order = 50)]
        public int? KickReturns { get; set; }

        /// <summary>
        /// Kicks return yards by the player on the play
        /// </summary>
        [Description("Kicks return yards by the player on the play")]
        [DataMember(Name = "KickReturnYards", Order = 51)]
        public int? KickReturnYards { get; set; }

        /// <summary>
        /// Kicks returned for touchdowns by the player on the play
        /// </summary>
        [Description("Kicks returned for touchdowns by the player on the play")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 52)]
        public int? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Blocked kicks by the player on the play. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Blocked kicks by the player on the play. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 53)]
        public int? BlockedKicks { get; set; }

        /// <summary>
        /// Blocked kick recovery returns by the player on the play
        /// </summary>
        [Description("Blocked kick recovery returns by the player on the play")]
        [DataMember(Name = "BlockedKickReturns", Order = 54)]
        public int? BlockedKickReturns { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards by the player on the play
        /// </summary>
        [Description("Blocked kick recovery return yards by the player on the play")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 55)]
        public int? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Blocked kick recovery return touchdowns by the player on the play
        /// </summary>
        [Description("Blocked kick recovery return touchdowns by the player on the play")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 56)]
        public int? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal returns by the player on the play
        /// </summary>
        [Description("Field goal returns by the player on the play")]
        [DataMember(Name = "FieldGoalReturns", Order = 57)]
        public int? FieldGoalReturns { get; set; }

        /// <summary>
        /// Field goal return yards by the player on the play. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Field goal return yards by the player on the play. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 58)]
        public int? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Field goal return touchdowns by the player on the play. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Field goal return touchdowns by the player on the play. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 59)]
        public int? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Total kickoffs by this player on the play
        /// </summary>
        [Description("Total kickoffs by this player on the play")]
        [DataMember(Name = "Kickoffs", Order = 60)]
        public int? Kickoffs { get; set; }

        /// <summary>
        /// Gross kickoff yards by the player on the play
        /// </summary>
        [Description("Gross kickoff yards by the player on the play")]
        [DataMember(Name = "KickoffYards", Order = 61)]
        public int? KickoffYards { get; set; }

        /// <summary>
        /// Kickoff touchbacks by the player on the play
        /// </summary>
        [Description("Kickoff touchbacks by the player on the play")]
        [DataMember(Name = "KickoffTouchbacks", Order = 62)]
        public int? KickoffTouchbacks { get; set; }

        /// <summary>
        /// Total number of punts by the player on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total number of punts by the player on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "Punts", Order = 63)]
        public int? Punts { get; set; }

        /// <summary>
        /// Total gross punt yards by the player on the play
        /// </summary>
        [Description("Total gross punt yards by the player on the play")]
        [DataMember(Name = "PuntYards", Order = 64)]
        public int? PuntYards { get; set; }

        /// <summary>
        /// Total punt touchbacks by the player on the play. Note: this field is expected to be either 1 or 0
        /// </summary>
        [Description("Total punt touchbacks by the player on the play. Note: this field is expected to be either 1 or 0")]
        [DataMember(Name = "PuntTouchbacks", Order = 65)]
        public int? PuntTouchbacks { get; set; }

        /// <summary>
        /// Total punts by the player that were blocked on the play. Note: this field is expected to be 1 or 0
        /// </summary>
        [Description("Total punts by the player that were blocked on the play. Note: this field is expected to be 1 or 0")]
        [DataMember(Name = "PuntsHadBlocked", Order = 66)]
        public int? PuntsHadBlocked { get; set; }

        /// <summary>
        /// Field goals attempted by the player on the play
        /// </summary>
        [Description("Field goals attempted by the player on the play")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 67)]
        public int? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Field goals made by the player on the play
        /// </summary>
        [Description("Field goals made by the player on the play")]
        [DataMember(Name = "FieldGoalsMade", Order = 68)]
        public int? FieldGoalsMade { get; set; }

        /// <summary>
        /// Field goal yards attempted by the player on the play
        /// </summary>
        [Description("Field goal yards attempted by the player on the play")]
        [DataMember(Name = "FieldGoalsYards", Order = 69)]
        public int? FieldGoalsYards { get; set; }

        /// <summary>
        /// Field goals attempted by the player that were blocked on the play
        /// </summary>
        [Description("Field goals attempted by the player that were blocked on the play")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 70)]
        public int? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Extra points attempted by the player on the play
        /// </summary>
        [Description("Extra points attempted by the player on the play")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 71)]
        public int? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Extra points made by the player on the play
        /// </summary>
        [Description("Extra points made by the player on the play")]
        [DataMember(Name = "ExtraPointsMade", Order = 72)]
        public int? ExtraPointsMade { get; set; }

        /// <summary>
        /// Extra point attempts by the player that were blocked on the play
        /// </summary>
        [Description("Extra point attempts by the player that were blocked on the play")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 73)]
        public int? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Indicates the number of penalties against a player on a play. Note: This serves as a placeholder for data intended to be added in the future
        /// </summary>
        [Description("Indicates the number of penalties against a player on a play. Note: This serves as a placeholder for data intended to be added in the future")]
        [DataMember(Name = "Penalties", Order = 74)]
        public int? Penalties { get; set; }

        /// <summary>
        /// Total penalty yards enforced against the player on the play
        /// </summary>
        [Description("Total penalty yards enforced against the player on the play")]
        [DataMember(Name = "PenaltyYards", Order = 75)]
        public int? PenaltyYards { get; set; }

    }
}

