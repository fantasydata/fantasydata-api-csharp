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
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO tied to this scoring detail. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO tied to this scoring detail. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The season during which the score happened
        /// </summary>
        [Description("The season during which the score happened")]
        [DataMember(Name = "Season", Order = 5)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
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
        /// Unique ID of this scoring detail
        /// </summary>
        [Description("Unique ID of this scoring detail")]
        [DataMember(Name = "ScoringDetailID", Order = 9)]
        public int ScoringDetailID { get; set; }

        /// <summary>
        /// Unique ID of the PlayerGame record tied to this scoring detail
        /// </summary>
        [Description("Unique ID of the PlayerGame record tied to this scoring detail")]
        [DataMember(Name = "PlayerGameID", Order = 10)]
        public int PlayerGameID { get; set; }

        /// <summary>
        /// Unique ID of the scoring play
        /// </summary>
        [Description("Unique ID of the scoring play")]
        [DataMember(Name = "ScoringPlayID", Order = 11)]
        public int? ScoringPlayID { get; set; }

    }
}

