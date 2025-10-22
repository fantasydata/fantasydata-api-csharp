using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="PlayerBasic")]
    [Serializable]
    public partial class PlayerBasic
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their collegiate career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their collegiate career")]
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
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 4)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the player's team
        /// </summary>
        [Description("The abbreviation [Key] of the player's team")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The player's jersey number (0-99)
        /// </summary>
        [Description("The player's jersey number (0-99)")]
        [DataMember(Name = "Jersey", Order = 6)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's eligible position(s). Possible values: C; F; F-C; G; G-F, PG, SG, SF, PF
        /// </summary>
        [Description("The player's eligible position(s). Possible values: C; F; F-C; G; G-F, PG, SG, SF, PF")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The class of the year (e.g. Freshman; Sophomore; Junior; Senior; Graduate Student). Note: Redshirt classes available for Freshman, Sophomore, Junior, Senior
        /// </summary>
        [Description("The class of the year (e.g. Freshman; Sophomore; Junior; Senior; Graduate Student). Note: Redshirt classes available for Freshman, Sophomore, Junior, Senior")]
        [DataMember(Name = "Class", Order = 8)]
        public string Class { get; set; }

        /// <summary>
        /// The player's height in inches
        /// </summary>
        [Description("The player's height in inches")]
        [DataMember(Name = "Height", Order = 9)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs)
        /// </summary>
        [Description("The player's weight in pounds (lbs)")]
        [DataMember(Name = "Weight", Order = 10)]
        public int? Weight { get; set; }

        /// <summary>
        /// The city in which the player was born
        /// </summary>
        [Description("The city in which the player was born")]
        [DataMember(Name = "BirthCity", Order = 11)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born (two letter abbreviation)
        /// </summary>
        [Description("The state in which the player was born (two letter abbreviation)")]
        [DataMember(Name = "BirthState", Order = 12)]
        public string BirthState { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 13)]
        public int? GlobalTeamID { get; set; }

    }
}

