using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerKicking")]
    [Serializable]
    public partial class PlayerKicking
    {
        /// <summary>
        /// Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.
        /// </summary>
        [Description("Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.")]
        [DataMember(Name = "PlayerGameID", Order = 1)]
        public int? PlayerGameID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// A shortened version of the player's full name (C.Newton, A.Rodgers)
        /// </summary>
        [Description("A shortened version of the player's full name (C.Newton, A.Rodgers)")]
        [DataMember(Name = "ShortName", Order = 3)]
        public string ShortName { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 6)]
        public int Number { get; set; }

        /// <summary>
        /// Player's position for this particular game or season. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR
        /// </summary>
        [Description("Player's position for this particular game or season. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// Abbreviation of either Offense, Defense or Special Teams (OFF, DEF, ST)
        /// </summary>
        [Description("Abbreviation of either Offense, Defense or Special Teams (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 8)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL")]
        [DataMember(Name = "FantasyPosition", Order = 9)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)")]
        [DataMember(Name = "FantasyPoints", Order = 10)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The date and time that this player game was last updated (US Eastern Time)
        /// </summary>
        [Description("The date and time that this player game was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Number of successful extra points
        /// </summary>
        [Description("Number of successful extra points")]
        [DataMember(Name = "ExtraPointsMade", Order = 12)]
        public int ExtraPointsMade { get; set; }

        /// <summary>
        /// Extra point kicks attempted
        /// </summary>
        [Description("Extra point kicks attempted")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 13)]
        public int ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Number of successful field goal attempts
        /// </summary>
        [Description("Number of successful field goal attempts")]
        [DataMember(Name = "FieldGoalsMade", Order = 14)]
        public int FieldGoalsMade { get; set; }

        /// <summary>
        /// Number of field goal attempts
        /// </summary>
        [Description("Number of field goal attempts")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 15)]
        public int FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Longest successful field goal attempt
        /// </summary>
        [Description("Longest successful field goal attempt")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 16)]
        public int FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Percentage of Field Goal attempts that we successful
        /// </summary>
        [Description("Percentage of Field Goal attempts that we successful")]
        [DataMember(Name = "FieldGoalPercentage", Order = 17)]
        public decimal FieldGoalPercentage { get; set; }

        /// <summary>
        /// Field goals made of 0 to 19 yards
        /// </summary>
        [Description("Field goals made of 0 to 19 yards")]
        [DataMember(Name = "FieldGoalsMade0to19", Order = 18)]
        public int FieldGoalsMade0to19 { get; set; }

        /// <summary>
        /// Field goals made of 20 to 29 yards
        /// </summary>
        [Description("Field goals made of 20 to 29 yards")]
        [DataMember(Name = "FieldGoalsMade20to29", Order = 19)]
        public int FieldGoalsMade20to29 { get; set; }

        /// <summary>
        /// Field goals made of 30 to 39 yards
        /// </summary>
        [Description("Field goals made of 30 to 39 yards")]
        [DataMember(Name = "FieldGoalsMade30to39", Order = 20)]
        public int FieldGoalsMade30to39 { get; set; }

        /// <summary>
        /// Field goals made of 40 to 49 yards
        /// </summary>
        [Description("Field goals made of 40 to 49 yards")]
        [DataMember(Name = "FieldGoalsMade40to49", Order = 21)]
        public int FieldGoalsMade40to49 { get; set; }

        /// <summary>
        /// Field goals made of 50+ yards
        /// </summary>
        [Description("Field goals made of 50+ yards")]
        [DataMember(Name = "FieldGoalsMade50Plus", Order = 22)]
        public int FieldGoalsMade50Plus { get; set; }

    }
}

