using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The unique ID of the player as assigned by SportsDataIO. Note: this ID remains with the player their entire collegiate career
        /// </summary>
        [Description("The unique ID of the player as assigned by SportsDataIO. Note: this ID remains with the player their entire collegiate career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The player's first name
        /// </summary>
        [Description("The player's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name
        /// </summary>
        [Description("The player's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The unique ID of the team associated with this player
        /// </summary>
        [Description("The unique ID of the team associated with this player")]
        [DataMember(Name = "TeamID", Order = 4)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The player's jersey number
        /// </summary>
        [Description("The player's jersey number")]
        [DataMember(Name = "Jersey", Order = 6)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; CB; DB; DE; DL; DT; FB; G; K; KR; LB; LS; NT; OL; OLB; OT; P; PR; QB; RB; S; SS; TE; WR
        /// </summary>
        [Description("The player's primary position. Possible values: C; CB; DB; DE; DL; DT; FB; G; K; KR; LB; LS; NT; OL; OLB; OT; P; PR; QB; RB; S; SS; TE; WR")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The category (Offense, Defense or Special Teams) of the players position (OFF, DEF, ST)
        /// </summary>
        [Description("The category (Offense, Defense or Special Teams) of the players position (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 8)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The class of the player.  Possible values: Freshman; Sophomore; Junior; Senior; Graduate Student; as well as Redshirt for all classes
        /// </summary>
        [Description("The class of the player.  Possible values: Freshman; Sophomore; Junior; Senior; Graduate Student; as well as Redshirt for all classes")]
        [DataMember(Name = "Class", Order = 9)]
        public string Class { get; set; }

        /// <summary>
        /// The player's height in inches
        /// </summary>
        [Description("The player's height in inches")]
        [DataMember(Name = "Height", Order = 10)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs)
        /// </summary>
        [Description("The player's weight in pounds (lbs)")]
        [DataMember(Name = "Weight", Order = 11)]
        public int? Weight { get; set; }

        /// <summary>
        /// The city in which the player was born
        /// </summary>
        [Description("The city in which the player was born")]
        [DataMember(Name = "BirthCity", Order = 12)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born
        /// </summary>
        [Description("The state in which the player was born")]
        [DataMember(Name = "BirthState", Order = 13)]
        public string BirthState { get; set; }

        /// <summary>
        /// The timestamp of when this player was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this player was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The updated date and time of the player
        /// </summary>
        [Description("The updated date and time of the player")]
        [DataMember(Name = "Created", Order = 15)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// A globally unique ID for the player's team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the player's team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 16)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Indicates the player's injury status (possible values include: Probable, Questionable, Doubtful, Out)
        /// </summary>
        [Description("Indicates the player's injury status (possible values include: Probable, Questionable, Doubtful, Out)")]
        [DataMember(Name = "InjuryStatus", Order = 17)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 18)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered
        /// </summary>
        [Description("The day that the injury started or first discovered")]
        [DataMember(Name = "InjuryStartDate", Order = 19)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Brief description of the player's injury and expected availability
        /// </summary>
        [Description("Brief description of the player's injury and expected availability")]
        [DataMember(Name = "InjuryNotes", Order = 20)]
        public string InjuryNotes { get; set; }

    }
}

