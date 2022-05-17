using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO.")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The player's first name.
        /// </summary>
        [Description("The player's first name.")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name.
        /// </summary>
        [Description("The player's last name.")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The TeamID of the team this player is employed by.
        /// </summary>
        [Description("The TeamID of the team this player is employed by.")]
        [DataMember(Name = "TeamID", Order = 4)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The key/abbreviation of the team this player is employed by.
        /// </summary>
        [Description("The key/abbreviation of the team this player is employed by.")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 6)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's eligible position(s). Possible values: C, F, F-C, G, G-F
        /// </summary>
        [Description("The player's eligible position(s). Possible values: C, F, F-C, G, G-F")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The class of the year (e.g. Freshman, Sophomore, Junior, or Senior)
        /// </summary>
        [Description("The class of the year (e.g. Freshman, Sophomore, Junior, or Senior)")]
        [DataMember(Name = "Class", Order = 8)]
        public string Class { get; set; }

        /// <summary>
        /// The player's height in inches.
        /// </summary>
        [Description("The player's height in inches.")]
        [DataMember(Name = "Height", Order = 9)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs).
        /// </summary>
        [Description("The player's weight in pounds (lbs).")]
        [DataMember(Name = "Weight", Order = 10)]
        public int? Weight { get; set; }

        /// <summary>
        /// The city in which the player was born.
        /// </summary>
        [Description("The city in which the player was born.")]
        [DataMember(Name = "BirthCity", Order = 11)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born.
        /// </summary>
        [Description("The state in which the player was born.")]
        [DataMember(Name = "BirthState", Order = 12)]
        public string BirthState { get; set; }

        /// <summary>
        /// The high school that the player attended.
        /// </summary>
        [Description("The high school that the player attended.")]
        [DataMember(Name = "HighSchool", Order = 13)]
        public string HighSchool { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportRadar API.
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportRadar API.")]
        [DataMember(Name = "SportRadarPlayerID", Order = 14)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the Rotoworld news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the Rotoworld news feed.")]
        [DataMember(Name = "RotoworldPlayerID", Order = 15)]
        public int? RotoworldPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the RotoWire news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the RotoWire news feed.")]
        [DataMember(Name = "RotoWirePlayerID", Order = 16)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the FantasyAlarm news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the FantasyAlarm news feed.")]
        [DataMember(Name = "FantasyAlarmPlayerID", Order = 17)]
        public int? FantasyAlarmPlayerID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 18)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Injury status (Questionable, Out, etc)
        /// </summary>
        [Description("Injury status (Questionable, Out, etc)")]
        [DataMember(Name = "InjuryStatus", Order = 19)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// Body part injured
        /// </summary>
        [Description("Body part injured")]
        [DataMember(Name = "InjuryBodyPart", Order = 20)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Injury description and expected availability
        /// </summary>
        [Description("Injury description and expected availability")]
        [DataMember(Name = "InjuryNotes", Order = 21)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// Date on which injury occurred
        /// </summary>
        [Description("Date on which injury occurred")]
        [DataMember(Name = "InjuryStartDate", Order = 22)]
        public DateTime? InjuryStartDate { get; set; }

    }
}

