using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerBasic")]
    [Serializable]
    public partial class PlayerBasic
    {
        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The abbreviation of the team this player is employed by, or if currently unemployed, the most recent team this player was employed by.
        /// </summary>
        [Description("The abbreviation of the team this player is employed by, or if currently unemployed, the most recent team this player was employed by.")]
        [DataMember(Name = "Team", Order = 2)]
        public string Team { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 3)]
        public int? Number { get; set; }

        /// <summary>
        /// Player's first name
        /// </summary>
        [Description("Player's first name")]
        [DataMember(Name = "FirstName", Order = 4)]
        public string FirstName { get; set; }

        /// <summary>
        /// Player's last name
        /// </summary>
        [Description("Player's last name")]
        [DataMember(Name = "LastName", Order = 5)]
        public string LastName { get; set; }

        /// <summary>
        /// Player's primary position. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR
        /// </summary>
        [Description("Player's primary position. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.
        /// </summary>
        [Description("The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.")]
        [DataMember(Name = "Status", Order = 7)]
        public string Status { get; set; }

        /// <summary>
        /// Height in feet, inches
        /// </summary>
        [Description("Height in feet, inches")]
        [DataMember(Name = "Height", Order = 8)]
        public string Height { get; set; }

        /// <summary>
        /// Weight in pounds
        /// </summary>
        [Description("Weight in pounds")]
        [DataMember(Name = "Weight", Order = 9)]
        public int? Weight { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [Description("Date of birth")]
        [DataMember(Name = "BirthDate", Order = 10)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// College
        /// </summary>
        [Description("College")]
        [DataMember(Name = "College", Order = 11)]
        public string College { get; set; }

        /// <summary>
        /// Number of years experience.  This number is incremented every year, in the Spring, when we load the rookies following the NFL Draft.  Rookies will have Experience = Zero, while second year players will have Experience = 2.
        /// </summary>
        [Description("Number of years experience.  This number is incremented every year, in the Spring, when we load the rookies following the NFL Draft.  Rookies will have Experience = Zero, while second year players will have Experience = 2.")]
        [DataMember(Name = "Experience", Order = 12)]
        public int? Experience { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL")]
        [DataMember(Name = "FantasyPosition", Order = 13)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Whether the player is currently under contract with an NFL team
        /// </summary>
        [Description("Whether the player is currently under contract with an NFL team")]
        [DataMember(Name = "Active", Order = 14)]
        public bool? Active { get; set; }

        /// <summary>
        /// The category (Offense, Defense or Special Teams) of the players position (OFF, DEF, ST)
        /// </summary>
        [Description("The category (Offense, Defense or Special Teams) of the players position (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 15)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Full name of the player (Cam Newton, Aaron Rodgers, etc.)
        /// </summary>
        [Description("Full name of the player (Cam Newton, Aaron Rodgers, etc.)")]
        [DataMember(Name = "Name", Order = 16)]
        public string Name { get; set; }

        /// <summary>
        /// The player's current age
        /// </summary>
        [Description("The player's current age")]
        [DataMember(Name = "Age", Order = 17)]
        public int? Age { get; set; }

        /// <summary>
        /// A shortened version of the player's full name (C.Newton, A.Rodgers)
        /// </summary>
        [Description("A shortened version of the player's full name (C.Newton, A.Rodgers)")]
        [DataMember(Name = "ShortName", Order = 18)]
        public string ShortName { get; set; }

        /// <summary>
        /// The feet component of a player's height (if player is 6'3", then this value would be 6)
        /// </summary>
        [Description("The feet component of a player's height (if player is 6'3\", then this value would be 6)")]
        [DataMember(Name = "HeightFeet", Order = 19)]
        public int? HeightFeet { get; set; }

        /// <summary>
        /// The inches component of a player's height (if player is 6'3", then this value would be 3)
        /// </summary>
        [Description("The inches component of a player's height (if player is 6'3\", then this value would be 3)")]
        [DataMember(Name = "HeightInches", Order = 20)]
        public int? HeightInches { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 21)]
        public int? TeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 22)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds.")]
        [DataMember(Name = "UsaTodayPlayerID", Order = 23)]
        public int? UsaTodayPlayerID { get; set; }

        /// <summary>
        /// The player's headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUrl", Order = 24)]
        public string UsaTodayHeadshotUrl { get; set; }

        /// <summary>
        /// The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUrl", Order = 25)]
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }

        /// <summary>
        /// The last updated date of the player's headshot as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The last updated date of the player's headshot as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUpdated", Order = 26)]
        public DateTime? UsaTodayHeadshotUpdated { get; set; }

        /// <summary>
        /// The last updated date of the player's transparent background headshot as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The last updated date of the player's transparent background headshot as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUpdated", Order = 27)]
        public DateTime? UsaTodayHeadshotNoBackgroundUpdated { get; set; }

    }
}

