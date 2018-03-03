using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="ScoringDetail")]
    [Serializable]
    public partial class ScoringDetail
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// PlayerID of the player who scored
        /// </summary>
        [Description("PlayerID of the player who scored")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The team who the player played for
        /// </summary>
        [Description("The team who the player played for")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The season during which the score happened
        /// </summary>
        [Description("The season during which the score happened")]
        [DataMember(Name = "Season", Order = 5)]
        public int Season { get; set; }

        /// <summary>
        /// The week during which the score happened
        /// </summary>
        [Description("The week during which the score happened")]
        [DataMember(Name = "Week", Order = 6)]
        public int Week { get; set; }

        /// <summary>
        /// The type of scoring play (e.g. BlockedFieldGoalReturnTouchdown, BlockedPuntReturnTouchdown, FieldGoalMade, FieldGoalReturnTouchdown, FumbleReturnTouchdown, InterceptionReturnTouchdown, KickoffReturnTouchdown, PassingTouchdown, PuntReturnTouchdown, ReceivingTouchdown, RushingTouchdown, Safety)
        /// </summary>
        [Description("The type of scoring play (e.g. BlockedFieldGoalReturnTouchdown, BlockedPuntReturnTouchdown, FieldGoalMade, FieldGoalReturnTouchdown, FumbleReturnTouchdown, InterceptionReturnTouchdown, KickoffReturnTouchdown, PassingTouchdown, PuntReturnTouchdown, ReceivingTouchdown, RushingTouchdown, Safety)")]
        [DataMember(Name = "ScoringType", Order = 7)]
        public string ScoringType { get; set; }

        /// <summary>
        /// The length in yards of the score
        /// </summary>
        [Description("The length in yards of the score")]
        [DataMember(Name = "Length", Order = 8)]
        public int Length { get; set; }

        /// <summary>
        /// Unique identifier of this scoring detail
        /// </summary>
        [Description("Unique identifier of this scoring detail")]
        [DataMember(Name = "ScoringDetailID", Order = 9)]
        public int ScoringDetailID { get; set; }

        /// <summary>
        /// PlayerGameID of the game that this scoring detail occurred
        /// </summary>
        [Description("PlayerGameID of the game that this scoring detail occurred")]
        [DataMember(Name = "PlayerGameID", Order = 10)]
        public int PlayerGameID { get; set; }

    }
}

