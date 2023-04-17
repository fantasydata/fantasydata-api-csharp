using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        /// The unique identifier of the Quarter that this play occurred in.
        /// </summary>
        [Description("The unique identifier of the Quarter that this play occurred in.")]
        [DataMember(Name = "QuarterID", Order = 2)]
        public int QuarterID { get; set; }

        /// <summary>
        /// The name of the Quarter that this play occurred in.
        /// </summary>
        [Description("The name of the Quarter that this play occurred in.")]
        [DataMember(Name = "QuarterName", Order = 3)]
        public string QuarterName { get; set; }

        /// <summary>
        /// The order in which this play happened over the course of the game.
        /// </summary>
        [Description("The order in which this play happened over the course of the game.")]
        [DataMember(Name = "Sequence", Order = 4)]
        public int Sequence { get; set; }

        /// <summary>
        /// The number of minutes remaining in the Quarter when this play completed.
        /// </summary>
        [Description("The number of minutes remaining in the Quarter when this play completed.")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 5)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// The number of seconds remaining in the Quarter when this play completed.
        /// </summary>
        [Description("The number of seconds remaining in the Quarter when this play completed.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 6)]
        public int? TimeRemainingSeconds { get; set; }

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
        /// The points that would have been potentially scored by the shot attempt (if any).
        /// </summary>
        [Description("The points that would have been potentially scored by the shot attempt (if any).")]
        [DataMember(Name = "PotentialPoints", Order = 9)]
        public int? PotentialPoints { get; set; }

        /// <summary>
        /// The points scores by the shot attempt (if any).
        /// </summary>
        [Description("The points scores by the shot attempt (if any).")]
        [DataMember(Name = "Points", Order = 10)]
        public int? Points { get; set; }

        /// <summary>
        /// Whether the shot was made (if any).
        /// </summary>
        [Description("Whether the shot was made (if any).")]
        [DataMember(Name = "ShotMade", Order = 11)]
        public bool? ShotMade { get; set; }

        /// <summary>
        /// The category the play. Possible values: Period, Timeout, JumpBall, Shot, Rebound, Foul, Substitution, Turnover
        /// </summary>
        [Description("The category the play. Possible values: Period, Timeout, JumpBall, Shot, Rebound, Foul, Substitution, Turnover")]
        [DataMember(Name = "Category", Order = 12)]
        public string Category { get; set; }

        /// <summary>
        /// The type of the play. Possible values: None, Period, Timeout, JumpBall, FieldGoalMade, FieldGoalMissed, FreeThrowMade, FreeThrowMissed, Rebound, Steal, Turnover, Foul, PersonalFoul, ShootingFoul, OffensiveFoul, LooseBallFoul, TechnicalFoul, FlagrantFoul, Traveling, Palming, Goaltending, KickedBall, LaneViolation, DelayOfGame, Substitution, Ejection, and Challenge.
        /// </summary>
        [Description("The type of the play. Possible values: None, Period, Timeout, JumpBall, FieldGoalMade, FieldGoalMissed, FreeThrowMade, FreeThrowMissed, Rebound, Steal, Turnover, Foul, PersonalFoul, ShootingFoul, OffensiveFoul, LooseBallFoul, TechnicalFoul, FlagrantFoul, Traveling, Palming, Goaltending, KickedBall, LaneViolation, DelayOfGame, Substitution, Ejection, and Challenge.")]
        [DataMember(Name = "Type", Order = 13)]
        public string Type { get; set; }

        /// <summary>
        /// The TeamID of the team associated with this play.
        /// </summary>
        [Description("The TeamID of the team associated with this play.")]
        [DataMember(Name = "TeamID", Order = 14)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The Team Key of the team associated with this play.
        /// </summary>
        [Description("The Team Key of the team associated with this play.")]
        [DataMember(Name = "Team", Order = 15)]
        public string Team { get; set; }

        /// <summary>
        /// The TeamID of the opponent associated with this play.
        /// </summary>
        [Description("The TeamID of the opponent associated with this play.")]
        [DataMember(Name = "OpponentID", Order = 16)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The Team Key of the opponent associated with this play.
        /// </summary>
        [Description("The Team Key of the opponent associated with this play.")]
        [DataMember(Name = "Opponent", Order = 17)]
        public string Opponent { get; set; }

        /// <summary>
        /// The TeamID of the team that won the jump ball.
        /// </summary>
        [Description("The TeamID of the team that won the jump ball.")]
        [DataMember(Name = "ReceivingTeamID", Order = 18)]
        public int? ReceivingTeamID { get; set; }

        /// <summary>
        /// The Team Key of the team that won the jump ball.
        /// </summary>
        [Description("The Team Key of the team that won the jump ball.")]
        [DataMember(Name = "ReceivingTeam", Order = 19)]
        public string ReceivingTeam { get; set; }

        /// <summary>
        /// The description of the play.
        /// </summary>
        [Description("The description of the play.")]
        [DataMember(Name = "Description", Order = 20)]
        public string Description { get; set; }

        /// <summary>
        /// The PlayerID of the primary player on this play (if any).
        /// </summary>
        [Description("The PlayerID of the primary player on this play (if any).")]
        [DataMember(Name = "PlayerID", Order = 21)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who got a field goal assist on this play (if any).
        /// </summary>
        [Description("The PlayerID of the player who got a field goal assist on this play (if any).")]
        [DataMember(Name = "AssistedByPlayerID", Order = 22)]
        public int? AssistedByPlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who blocked the field goal attempt on this play (if any).
        /// </summary>
        [Description("The PlayerID of the player who blocked the field goal attempt on this play (if any).")]
        [DataMember(Name = "BlockedByPlayerID", Order = 23)]
        public int? BlockedByPlayerID { get; set; }

        /// <summary>
        /// Indicates whether this play happened on a fast break.
        /// </summary>
        [Description("Indicates whether this play happened on a fast break.")]
        [DataMember(Name = "FastBreak", Order = 24)]
        public bool? FastBreak { get; set; }

        /// <summary>
        /// The side of the basket that the field goal was attempted from (if any). Possible values: L, R
        /// </summary>
        [Description("The side of the basket that the field goal was attempted from (if any). Possible values: L, R")]
        [DataMember(Name = "SideOfBasket", Order = 25)]
        public string SideOfBasket { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was last updated.
        /// </summary>
        [Description("The database generated timestamp of when this Play was last updated.")]
        [DataMember(Name = "Updated", Order = 26)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Play was first created.
        /// </summary>
        [Description("The database generated timestamp of when this Play was first created.")]
        [DataMember(Name = "Created", Order = 27)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The PlayerID of the player who substituted into the game.
        /// </summary>
        [Description("The PlayerID of the player who substituted into the game.")]
        [DataMember(Name = "SubstituteInPlayerID", Order = 28)]
        public int? SubstituteInPlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who substituted out of the game.
        /// </summary>
        [Description("The PlayerID of the player who substituted out of the game.")]
        [DataMember(Name = "SubstituteOutPlayerID", Order = 29)]
        public int? SubstituteOutPlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who is involved in the play from the away team
        /// </summary>
        [Description("The PlayerID of the player who is involved in the play from the away team")]
        [DataMember(Name = "AwayPlayerID", Order = 30)]
        public int? AwayPlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who is involved in the play from the home team
        /// </summary>
        [Description("The PlayerID of the player who is involved in the play from the home team")]
        [DataMember(Name = "HomePlayerID", Order = 31)]
        public int? HomePlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who received the ball
        /// </summary>
        [Description("The PlayerID of the player who received the ball")]
        [DataMember(Name = "ReceivingPlayerID", Order = 32)]
        public int? ReceivingPlayerID { get; set; }

        /// <summary>
        /// The baseline offset percentage of where the ball was shot/passed
        /// </summary>
        [Description("The baseline offset percentage of where the ball was shot/passed")]
        [DataMember(Name = "BaselineOffsetPercentage", Order = 33)]
        public decimal? BaselineOffsetPercentage { get; set; }

        /// <summary>
        /// The sideline offset percentage of where the ball was shot/passed
        /// </summary>
        [Description("The sideline offset percentage of where the ball was shot/passed")]
        [DataMember(Name = "SidelineOffsetPercentage", Order = 34)]
        public decimal? SidelineOffsetPercentage { get; set; }

        /// <summary>
        /// The x/y coordinates of where the ball was shot/passed
        /// </summary>
        [Description("The x/y coordinates of where the ball was shot/passed")]
        [DataMember(Name = "Coordinates", Order = 35)]
        public string Coordinates { get; set; }

        /// <summary>
        /// The PlayerId of the player which stole the ball (if applicable).
        /// </summary>
        [Description("The PlayerId of the player which stole the ball (if applicable).")]
        [DataMember(Name = "StolenByPlayerID", Order = 36)]
        public int? StolenByPlayerID { get; set; }

    }
}

