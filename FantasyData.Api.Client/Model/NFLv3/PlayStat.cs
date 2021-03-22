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
        /// Unique identifier for each PlayStat.
        /// </summary>
        [Description("Unique identifier for each PlayStat.")]
        [DataMember(Name = "PlayStatID", Order = 1)]
        public int PlayStatID { get; set; }

        /// <summary>
        /// The PlayID of the Play record, in which this PlayStat occurred.
        /// </summary>
        [Description("The PlayID of the Play record, in which this PlayStat occurred.")]
        [DataMember(Name = "PlayID", Order = 2)]
        public int PlayID { get; set; }

        /// <summary>
        /// The order in which the PlayStat was registered to the Play.
        /// </summary>
        [Description("The order in which the PlayStat was registered to the Play.")]
        [DataMember(Name = "Sequence", Order = 3)]
        public int Sequence { get; set; }

        /// <summary>
        /// The PlayerID of the Player whose stats this represents.
        /// </summary>
        [Description("The PlayerID of the Player whose stats this represents.")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The Name of the Player whose stats this represents.
        /// </summary>
        [Description("The Name of the Player whose stats this represents.")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The Team of the Player.
        /// </summary>
        [Description("The Team of the Player.")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The Opponent of the Player.
        /// </summary>
        [Description("The Opponent of the Player.")]
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
        /// The database generated timestamp of when this PlayStat was last updated.
        /// </summary>
        [Description("The database generated timestamp of when this PlayStat was last updated.")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this PlayStat was first created.
        /// </summary>
        [Description("The database generated timestamp of when this PlayStat was first created.")]
        [DataMember(Name = "Created", Order = 11)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Passing attempts on the play
        /// </summary>
        [Description("Passing attempts on the play")]
        [DataMember(Name = "PassingAttempts", Order = 12)]
        public int? PassingAttempts { get; set; }

        /// <summary>
        /// Passing completions on the play
        /// </summary>
        [Description("Passing completions on the play")]
        [DataMember(Name = "PassingCompletions", Order = 13)]
        public int? PassingCompletions { get; set; }

        /// <summary>
        /// Passing yards on the play
        /// </summary>
        [Description("Passing yards on the play")]
        [DataMember(Name = "PassingYards", Order = 14)]
        public int? PassingYards { get; set; }

        /// <summary>
        /// Passing touchdowns thrown on the play
        /// </summary>
        [Description("Passing touchdowns thrown on the play")]
        [DataMember(Name = "PassingTouchdowns", Order = 15)]
        public int? PassingTouchdowns { get; set; }

        /// <summary>
        /// Passing interceptions thrown on the play
        /// </summary>
        [Description("Passing interceptions thrown on the play")]
        [DataMember(Name = "PassingInterceptions", Order = 16)]
        public int? PassingInterceptions { get; set; }

        /// <summary>
        /// Times sacked on the play
        /// </summary>
        [Description("Times sacked on the play")]
        [DataMember(Name = "PassingSacks", Order = 17)]
        public int? PassingSacks { get; set; }

        /// <summary>
        /// Yards lost from being sacked on the play
        /// </summary>
        [Description("Yards lost from being sacked on the play")]
        [DataMember(Name = "PassingSackYards", Order = 18)]
        public int? PassingSackYards { get; set; }

        /// <summary>
        /// Rushing attempts on the play
        /// </summary>
        [Description("Rushing attempts on the play")]
        [DataMember(Name = "RushingAttempts", Order = 19)]
        public int? RushingAttempts { get; set; }

        /// <summary>
        /// Rushing yards on the play
        /// </summary>
        [Description("Rushing yards on the play")]
        [DataMember(Name = "RushingYards", Order = 20)]
        public int? RushingYards { get; set; }

        /// <summary>
        /// Rushing touchdowns on the play
        /// </summary>
        [Description("Rushing touchdowns on the play")]
        [DataMember(Name = "RushingTouchdowns", Order = 21)]
        public int? RushingTouchdowns { get; set; }

        /// <summary>
        /// Receiving targets on the play
        /// </summary>
        [Description("Receiving targets on the play")]
        [DataMember(Name = "ReceivingTargets", Order = 22)]
        public int? ReceivingTargets { get; set; }

        /// <summary>
        /// Receptions on the play
        /// </summary>
        [Description("Receptions on the play")]
        [DataMember(Name = "Receptions", Order = 23)]
        public int? Receptions { get; set; }

        /// <summary>
        /// Receiving yards on the play
        /// </summary>
        [Description("Receiving yards on the play")]
        [DataMember(Name = "ReceivingYards", Order = 24)]
        public int? ReceivingYards { get; set; }

        /// <summary>
        /// Receiving touchdowns on the play
        /// </summary>
        [Description("Receiving touchdowns on the play")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 25)]
        public int? ReceivingTouchdowns { get; set; }

        /// <summary>
        /// Times fumbled on the play
        /// </summary>
        [Description("Times fumbled on the play")]
        [DataMember(Name = "Fumbles", Order = 26)]
        public int? Fumbles { get; set; }

        /// <summary>
        /// Fumbles lost on the play
        /// </summary>
        [Description("Fumbles lost on the play")]
        [DataMember(Name = "FumblesLost", Order = 27)]
        public int? FumblesLost { get; set; }

        /// <summary>
        /// Two point conversion attempts on the play
        /// </summary>
        [Description("Two point conversion attempts on the play")]
        [DataMember(Name = "TwoPointConversionAttempts", Order = 28)]
        public int? TwoPointConversionAttempts { get; set; }

        /// <summary>
        /// Two point conversion passes on the play
        /// </summary>
        [Description("Two point conversion passes on the play")]
        [DataMember(Name = "TwoPointConversionPasses", Order = 29)]
        public int? TwoPointConversionPasses { get; set; }

        /// <summary>
        /// Two point conversion runs on the play
        /// </summary>
        [Description("Two point conversion runs on the play")]
        [DataMember(Name = "TwoPointConversionRuns", Order = 30)]
        public int? TwoPointConversionRuns { get; set; }

        /// <summary>
        /// Two point conversion receptions on the play
        /// </summary>
        [Description("Two point conversion receptions on the play")]
        [DataMember(Name = "TwoPointConversionReceptions", Order = 31)]
        public int? TwoPointConversionReceptions { get; set; }

        /// <summary>
        /// Two point conversion returns on the play
        /// </summary>
        [Description("Two point conversion returns on the play")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 32)]
        public int? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Solo tackles on the play
        /// </summary>
        [Description("Solo tackles on the play")]
        [DataMember(Name = "SoloTackles", Order = 33)]
        public int? SoloTackles { get; set; }

        /// <summary>
        /// Assisted tackles on the play
        /// </summary>
        [Description("Assisted tackles on the play")]
        [DataMember(Name = "AssistedTackles", Order = 34)]
        public int? AssistedTackles { get; set; }

        /// <summary>
        /// Tackles for loss of yards on the play
        /// </summary>
        [Description("Tackles for loss of yards on the play")]
        [DataMember(Name = "TacklesForLoss", Order = 35)]
        public int? TacklesForLoss { get; set; }

        /// <summary>
        /// Sacks by this player on the play
        /// </summary>
        [Description("Sacks by this player on the play")]
        [DataMember(Name = "Sacks", Order = 36)]
        public decimal? Sacks { get; set; }

        /// <summary>
        /// Sack yards by this player on the play
        /// </summary>
        [Description("Sack yards by this player on the play")]
        [DataMember(Name = "SackYards", Order = 37)]
        public decimal? SackYards { get; set; }

        /// <summary>
        /// Passes defended on the play
        /// </summary>
        [Description("Passes defended on the play")]
        [DataMember(Name = "PassesDefended", Order = 38)]
        public int? PassesDefended { get; set; }

        /// <summary>
        /// Safeties scored by this player on the play
        /// </summary>
        [Description("Safeties scored by this player on the play")]
        [DataMember(Name = "Safeties", Order = 39)]
        public int? Safeties { get; set; }

        /// <summary>
        /// Fumbles forced on the play
        /// </summary>
        [Description("Fumbles forced on the play")]
        [DataMember(Name = "FumblesForced", Order = 40)]
        public int? FumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered on the play
        /// </summary>
        [Description("Fumbles recovered on the play")]
        [DataMember(Name = "FumblesRecovered", Order = 41)]
        public int? FumblesRecovered { get; set; }

        /// <summary>
        /// Fumble recovery return yards on the play
        /// </summary>
        [Description("Fumble recovery return yards on the play")]
        [DataMember(Name = "FumbleReturnYards", Order = 42)]
        public int? FumbleReturnYards { get; set; }

        /// <summary>
        /// Fumble recoveries returned for touchdowns on the play
        /// </summary>
        [Description("Fumble recoveries returned for touchdowns on the play")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 43)]
        public int? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Interceptions made on the play
        /// </summary>
        [Description("Interceptions made on the play")]
        [DataMember(Name = "Interceptions", Order = 44)]
        public int? Interceptions { get; set; }

        /// <summary>
        /// Interception return yards on the play
        /// </summary>
        [Description("Interception return yards on the play")]
        [DataMember(Name = "InterceptionReturnYards", Order = 45)]
        public int? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Interception return touchdowns on the play
        /// </summary>
        [Description("Interception return touchdowns on the play")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 46)]
        public int? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Punts returned on the play
        /// </summary>
        [Description("Punts returned on the play")]
        [DataMember(Name = "PuntReturns", Order = 47)]
        public int? PuntReturns { get; set; }

        /// <summary>
        /// Punt return yards on the play
        /// </summary>
        [Description("Punt return yards on the play")]
        [DataMember(Name = "PuntReturnYards", Order = 48)]
        public int? PuntReturnYards { get; set; }

        /// <summary>
        /// Punt returns for touchdowns on the play
        /// </summary>
        [Description("Punt returns for touchdowns on the play")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 49)]
        public int? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Kicks returned on the play
        /// </summary>
        [Description("Kicks returned on the play")]
        [DataMember(Name = "KickReturns", Order = 50)]
        public int? KickReturns { get; set; }

        /// <summary>
        /// Kick return yards on the play
        /// </summary>
        [Description("Kick return yards on the play")]
        [DataMember(Name = "KickReturnYards", Order = 51)]
        public int? KickReturnYards { get; set; }

        /// <summary>
        /// Kick return touchdowns on the play
        /// </summary>
        [Description("Kick return touchdowns on the play")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 52)]
        public int? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Blocked kicks on the play
        /// </summary>
        [Description("Blocked kicks on the play")]
        [DataMember(Name = "BlockedKicks", Order = 53)]
        public int? BlockedKicks { get; set; }

        /// <summary>
        /// Blocked kick returns on the play
        /// </summary>
        [Description("Blocked kick returns on the play")]
        [DataMember(Name = "BlockedKickReturns", Order = 54)]
        public int? BlockedKickReturns { get; set; }

        /// <summary>
        /// Blocked kick return yards on the play
        /// </summary>
        [Description("Blocked kick return yards on the play")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 55)]
        public int? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Blocked kick return touchdowns on the play
        /// </summary>
        [Description("Blocked kick return touchdowns on the play")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 56)]
        public int? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal returns on the play
        /// </summary>
        [Description("Field goal returns on the play")]
        [DataMember(Name = "FieldGoalReturns", Order = 57)]
        public int? FieldGoalReturns { get; set; }

        /// <summary>
        /// Field goal return yards on the play
        /// </summary>
        [Description("Field goal return yards on the play")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 58)]
        public int? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Field goal return touchdowns on the play
        /// </summary>
        [Description("Field goal return touchdowns on the play")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 59)]
        public int? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Kickoffs by this player on the play
        /// </summary>
        [Description("Kickoffs by this player on the play")]
        [DataMember(Name = "Kickoffs", Order = 60)]
        public int? Kickoffs { get; set; }

        /// <summary>
        /// Gross kickoff yards by this player on the play
        /// </summary>
        [Description("Gross kickoff yards by this player on the play")]
        [DataMember(Name = "KickoffYards", Order = 61)]
        public int? KickoffYards { get; set; }

        /// <summary>
        /// Kickoff touchbacks on the play
        /// </summary>
        [Description("Kickoff touchbacks on the play")]
        [DataMember(Name = "KickoffTouchbacks", Order = 62)]
        public int? KickoffTouchbacks { get; set; }

        /// <summary>
        /// Punts by this player on the play
        /// </summary>
        [Description("Punts by this player on the play")]
        [DataMember(Name = "Punts", Order = 63)]
        public int? Punts { get; set; }

        /// <summary>
        /// Gross punt yards by this player on the play
        /// </summary>
        [Description("Gross punt yards by this player on the play")]
        [DataMember(Name = "PuntYards", Order = 64)]
        public int? PuntYards { get; set; }

        /// <summary>
        /// Punt touchbacks by this player on the play
        /// </summary>
        [Description("Punt touchbacks by this player on the play")]
        [DataMember(Name = "PuntTouchbacks", Order = 65)]
        public int? PuntTouchbacks { get; set; }

        /// <summary>
        /// Punts by this player that were blocked on the play
        /// </summary>
        [Description("Punts by this player that were blocked on the play")]
        [DataMember(Name = "PuntsHadBlocked", Order = 66)]
        public int? PuntsHadBlocked { get; set; }

        /// <summary>
        /// Field goals attempted on the play
        /// </summary>
        [Description("Field goals attempted on the play")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 67)]
        public int? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Field goals made on the play
        /// </summary>
        [Description("Field goals made on the play")]
        [DataMember(Name = "FieldGoalsMade", Order = 68)]
        public int? FieldGoalsMade { get; set; }

        /// <summary>
        /// Field goal yards attempted on the play
        /// </summary>
        [Description("Field goal yards attempted on the play")]
        [DataMember(Name = "FieldGoalsYards", Order = 69)]
        public int? FieldGoalsYards { get; set; }

        /// <summary>
        /// Field goals attempted by this player that were blocked on the play
        /// </summary>
        [Description("Field goals attempted by this player that were blocked on the play")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 70)]
        public int? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Extra points attempted by this player on the play
        /// </summary>
        [Description("Extra points attempted by this player on the play")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 71)]
        public int? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Extra points made by this player on the play
        /// </summary>
        [Description("Extra points made by this player on the play")]
        [DataMember(Name = "ExtraPointsMade", Order = 72)]
        public int? ExtraPointsMade { get; set; }

        /// <summary>
        /// Extra point attempts by this player that were blocked on the play
        /// </summary>
        [Description("Extra point attempts by this player that were blocked on the play")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 73)]
        public int? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Penalties enforced against this player on the play (placeholder for data intended to be added in the future)
        /// </summary>
        [Description("Penalties enforced against this player on the play (placeholder for data intended to be added in the future)")]
        [DataMember(Name = "Penalties", Order = 74)]
        public int? Penalties { get; set; }

        /// <summary>
        /// Penalty yards enforced against this player on the play (placeholder for data intended to be added in the future)
        /// </summary>
        [Description("Penalty yards enforced against this player on the play (placeholder for data intended to be added in the future)")]
        [DataMember(Name = "PenaltyYards", Order = 75)]
        public int? PenaltyYards { get; set; }

    }
}

