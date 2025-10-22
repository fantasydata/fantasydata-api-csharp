using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Injury")]
    [Serializable]
    public partial class Injury
    {
        /// <summary>
        /// The unique ID of the injury record for the player
        /// </summary>
        [Description("The unique ID of the injury record for the player")]
        [DataMember(Name = "InjuryID", Order = 1)]
        public int InjuryID { get; set; }

        /// <summary>
        /// The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The season of the game that this injury leads up to
        /// </summary>
        [Description("The season of the game that this injury leads up to")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game that this injury leads up to (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons prior to 2021 will have 3 preseason weeks.
        /// </summary>
        [Description("The NFL week of the game that this injury leads up to (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons prior to 2021 will have 3 preseason weeks.")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career.
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career.")]
        [DataMember(Name = "PlayerID", Order = 5)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR.
        /// </summary>
        [Description("The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR.")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 8)]
        public int Number { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL.
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL.")]
        [DataMember(Name = "Team", Order = 9)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team of the injured player
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team of the injured player")]
        [DataMember(Name = "Opponent", Order = 10)]
        public string Opponent { get; set; }

        /// <summary>
        /// The body part that is injured (Knee; Groin; Calf; Hamstring; etc.)
        /// </summary>
        [Description("The body part that is injured (Knee; Groin; Calf; Hamstring; etc.)")]
        [DataMember(Name = "BodyPart", Order = 11)]
        public string BodyPart { get; set; }

        /// <summary>
        /// The injury designation assigned to the player (Probable; Questionable; Doubtful; Out)
        /// </summary>
        [Description("The injury designation assigned to the player (Probable; Questionable; Doubtful; Out)")]
        [DataMember(Name = "Status", Order = 12)]
        public string Status { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "Practice", Order = 13)]
        public string Practice { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "PracticeDescription", Order = 14)]
        public string PracticeDescription { get; set; }

        /// <summary>
        /// The date/time the injury status was updated (in US Eastern time)
        /// </summary>
        [Description("The date/time the injury status was updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 15)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Whether the player has been declared inactive. This value is updated in the hours leading up to game start time; as teams announce their inactive players. Note: This is only updated for offensive skill position players (QB; RB; WR; TE).
        /// </summary>
        [Description("Whether the player has been declared inactive. This value is updated in the hours leading up to game start time; as teams announce their inactive players. Note: This is only updated for offensive skill position players (QB; RB; WR; TE).")]
        [DataMember(Name = "DeclaredInactive", Order = 16)]
        public bool? DeclaredInactive { get; set; }

        /// <summary>
        /// The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL.
        /// </summary>
        [Description("The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL.")]
        [DataMember(Name = "TeamID", Order = 17)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The unique ID of the opponent this player played on during this game
        /// </summary>
        [Description("The unique ID of the opponent this player played on during this game")]
        [DataMember(Name = "OpponentID", Order = 18)]
        public int? OpponentID { get; set; }

    }
}

