using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NHL
{
    [DataContract(Namespace="", Name="Play")]
    [Serializable]
    public partial class Play
    {
        /// <summary>
        /// The unique identifier of the play.
        /// </summary>
        [Description("The unique identifier of the play.")]
        [DataMember(Name = "PlayID", Order = 1)]
        public int PlayID { get; set; }

        /// <summary>
        /// The unique identifier of the Period that this play occurred in.
        /// </summary>
        [Description("The unique identifier of the Period that this play occurred in.")]
        [DataMember(Name = "PeriodID", Order = 2)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The name of the Period that this play occurred in.
        /// </summary>
        [Description("The name of the Period that this play occurred in.")]
        [DataMember(Name = "PeriodName", Order = 3)]
        public string PeriodName { get; set; }

        /// <summary>
        /// The order in which this play happened over the course of the game.
        /// </summary>
        [Description("The order in which this play happened over the course of the game.")]
        [DataMember(Name = "Sequence", Order = 4)]
        public int Sequence { get; set; }

        /// <summary>
        /// The number of minutes passed in the Period when this play completed.
        /// </summary>
        [Description("The number of minutes passed in the Period when this play completed.")]
        [DataMember(Name = "ClockMinutes", Order = 5)]
        public int? ClockMinutes { get; set; }

        /// <summary>
        /// The number of seconds passed in the Period when this play completed.
        /// </summary>
        [Description("The number of seconds passed in the Period when this play completed.")]
        [DataMember(Name = "ClockSeconds", Order = 6)]
        public int? ClockSeconds { get; set; }

        /// <summary>
        /// The score of the away team after this play completed.
        /// </summary>
        [Description("The score of the away team after this play completed.")]
        [DataMember(Name = "AwayTeamScore", Order = 7)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The score of the home team after this play completed.
        /// </summary>
        [Description("The score of the home team after this play completed.")]
        [DataMember(Name = "HomeTeamScore", Order = 8)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The TeamID of the team associated with this play.
        /// </summary>
        [Description("The TeamID of the team associated with this play.")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The Team Key of the team associated with this play.
        /// </summary>
        [Description("The Team Key of the team associated with this play.")]
        [DataMember(Name = "Team", Order = 10)]
        public string Team { get; set; }

        /// <summary>
        /// The TeamID of the opponent associated with this play.
        /// </summary>
        [Description("The TeamID of the opponent associated with this play.")]
        [DataMember(Name = "OpponentID", Order = 11)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The Team Key of the opponent associated with this play.
        /// </summary>
        [Description("The Team Key of the opponent associated with this play.")]
        [DataMember(Name = "Opponent", Order = 12)]
        public string Opponent { get; set; }

        /// <summary>
        /// The category the play. Possible values: Block, Faceoff, Goal, Hit, Penalty, Period, Shootout, Shot, Stoppage, Turnover
        /// </summary>
        [Description("The category the play. Possible values: Block, Faceoff, Goal, Hit, Penalty, Period, Shootout, Shot, Stoppage, Turnover")]
        [DataMember(Name = "Category", Order = 13)]
        public string Category { get; set; }

        /// <summary>
        /// The type of the play. Possible values: AwayTeamTimeout, Block, Boarding, Charging, CheckToTheHead, Clipping, ClosingHandOnThePuck, CrossChecking, DelayOfGame, Elbowing, Faceoff, Fighting, GameMisconduct, Giveaway, Goal, GoalieStopped, HandPass, HighSticking, HighStickOnPuck, Hit, Holding, HoldingTheStick, HomeTeamTimeout, Hooking, Icing, IllegalEquipment, Interference, Kneeing, MinorPenalty, Misconduct, NetOffPost, ObjectsOnIce, Offside, Period, PeriodEnd, PlayerEquipment, PlayerInjury, PowerPlayGoal, PuckFrozen, PuckInBench, PuckInCrowd, PuckInNetting, Referee, RinkRepair, Roughing, ShootoutGoal, ShootoutMiss, ShootoutSave, ShotMissed, ShotOnGoal, Slashing, Stoppage, Takeaway, TooManyMen, Tripping, TvTimeout, Unsportsmanlike, VideoReview
        /// </summary>
        [Description("The type of the play. Possible values: AwayTeamTimeout, Block, Boarding, Charging, CheckToTheHead, Clipping, ClosingHandOnThePuck, CrossChecking, DelayOfGame, Elbowing, Faceoff, Fighting, GameMisconduct, Giveaway, Goal, GoalieStopped, HandPass, HighSticking, HighStickOnPuck, Hit, Holding, HoldingTheStick, HomeTeamTimeout, Hooking, Icing, IllegalEquipment, Interference, Kneeing, MinorPenalty, Misconduct, NetOffPost, ObjectsOnIce, Offside, Period, PeriodEnd, PlayerEquipment, PlayerInjury, PowerPlayGoal, PuckFrozen, PuckInBench, PuckInCrowd, PuckInNetting, Referee, RinkRepair, Roughing, ShootoutGoal, ShootoutMiss, ShootoutSave, ShotMissed, ShotOnGoal, Slashing, Stoppage, Takeaway, TooManyMen, Tripping, TvTimeout, Unsportsmanlike, VideoReview")]
        [DataMember(Name = "Type", Order = 14)]
        public string Type { get; set; }

        /// <summary>
        /// The description of the play (example: Sidney Crosby won faceoff against Nicklas Backstrom)
        /// </summary>
        [Description("The description of the play (example: Sidney Crosby won faceoff against Nicklas Backstrom)")]
        [DataMember(Name = "Description", Order = 15)]
        public string Description { get; set; }

        /// <summary>
        /// The PlayerID of the primary player on this play (if any).
        /// </summary>
        [Description("The PlayerID of the primary player on this play (if any).")]
        [DataMember(Name = "PlayerID", Order = 16)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was last updated.
        /// </summary>
        [Description("The database generated timestamp of when this Play was last updated.")]
        [DataMember(Name = "Updated", Order = 17)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was first created.
        /// </summary>
        [Description("The database generated timestamp of when this Play was first created.")]
        [DataMember(Name = "Created", Order = 18)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The PlayerID of the player who got the first assist on this play (if any).
        /// </summary>
        [Description("The PlayerID of the player who got the first assist on this play (if any).")]
        [DataMember(Name = "FirstAssistedByPlayerID", Order = 19)]
        public int? FirstAssistedByPlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who got the second assist on this play (if any).
        /// </summary>
        [Description("The PlayerID of the player who got the second assist on this play (if any).")]
        [DataMember(Name = "SecondAssistedByPlayerID", Order = 20)]
        public int? SecondAssistedByPlayerID { get; set; }

        /// <summary>
        /// The TeamID of the team on the power play this play (if any).
        /// </summary>
        [Description("The TeamID of the team on the power play this play (if any).")]
        [DataMember(Name = "PowerPlayTeamID", Order = 21)]
        public int? PowerPlayTeamID { get; set; }

        /// <summary>
        /// The TeamKey of the team on the power play this play (if any).
        /// </summary>
        [Description("The TeamKey of the team on the power play this play (if any).")]
        [DataMember(Name = "PowerPlayTeam", Order = 22)]
        public string PowerPlayTeam { get; set; }

        /// <summary>
        /// The PlayerID of the player involved in the play on the opposing team.
        /// </summary>
        [Description("The PlayerID of the player involved in the play on the opposing team.")]
        [DataMember(Name = "OpposingPlayerID", Order = 23)]
        public int? OpposingPlayerID { get; set; }

    }
}

