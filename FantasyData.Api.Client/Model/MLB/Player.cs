using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by FantasyData.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by FantasyData.")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Deprecated. Use SportRadarPlayerID instead.
        /// </summary>
        [Description("Deprecated. Use SportRadarPlayerID instead.")]
        [DataMember(Name = "SportsDataID", Order = 2)]
        public string SportsDataID { get; set; }

        /// <summary>
        /// Indicates the player's status of being on an Major League Active Roster. Possible values include: Active, 40 Man Active, Non-Roster Invitee, Minors, Inactive, 7 Day Disabled List, 10 Day Disabled List, 15 Day Disabled List, 60 Day Disabled List
        /// </summary>
        [Description("Indicates the player's status of being on an Major League Active Roster. Possible values include: Active, 40 Man Active, Non-Roster Invitee, Minors, Inactive, 7 Day Disabled List, 10 Day Disabled List, 15 Day Disabled List, 60 Day Disabled List")]
        [DataMember(Name = "Status", Order = 3)]
        public string Status { get; set; }

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
        /// The player's position category. Possible values: DH, IF, OF, P, PH, PR
        /// </summary>
        [Description("The player's position category. Possible values: DH, IF, OF, P, PH, PR")]
        [DataMember(Name = "PositionCategory", Order = 7)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS
        /// </summary>
        [Description("The player's primary position. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with MLB AM.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with MLB AM.")]
        [DataMember(Name = "MLBAMID", Order = 9)]
        public int? MLBAMID { get; set; }

        /// <summary>
        /// The player's first name.
        /// </summary>
        [Description("The player's first name.")]
        [DataMember(Name = "FirstName", Order = 10)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name.
        /// </summary>
        [Description("The player's last name.")]
        [DataMember(Name = "LastName", Order = 11)]
        public string LastName { get; set; }

        /// <summary>
        /// The player's batting hand. Possible values: R, L, S
        /// </summary>
        [Description("The player's batting hand. Possible values: R, L, S")]
        [DataMember(Name = "BatHand", Order = 12)]
        public string BatHand { get; set; }

        /// <summary>
        /// The player's throwing hand. Possible values: R, L, S
        /// </summary>
        [Description("The player's throwing hand. Possible values: R, L, S")]
        [DataMember(Name = "ThrowHand", Order = 13)]
        public string ThrowHand { get; set; }

        /// <summary>
        /// The player's height in inches.
        /// </summary>
        [Description("The player's height in inches.")]
        [DataMember(Name = "Height", Order = 14)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs).
        /// </summary>
        [Description("The player's weight in pounds (lbs).")]
        [DataMember(Name = "Weight", Order = 15)]
        public int? Weight { get; set; }

        /// <summary>
        /// The player's date of birth.
        /// </summary>
        [Description("The player's date of birth.")]
        [DataMember(Name = "BirthDate", Order = 16)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born.
        /// </summary>
        [Description("The city in which the player was born.")]
        [DataMember(Name = "BirthCity", Order = 17)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born.
        /// </summary>
        [Description("The state in which the player was born.")]
        [DataMember(Name = "BirthState", Order = 18)]
        public string BirthState { get; set; }

        /// <summary>
        /// The country in which the player was born.
        /// </summary>
        [Description("The country in which the player was born.")]
        [DataMember(Name = "BirthCountry", Order = 19)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The high school that the player attended.
        /// </summary>
        [Description("The high school that the player attended.")]
        [DataMember(Name = "HighSchool", Order = 20)]
        public string HighSchool { get; set; }

        /// <summary>
        /// The college that the player attended.
        /// </summary>
        [Description("The college that the player attended.")]
        [DataMember(Name = "College", Order = 21)]
        public string College { get; set; }

        /// <summary>
        /// The date that this player made his MLB debut.
        /// </summary>
        [Description("The date that this player made his MLB debut.")]
        [DataMember(Name = "ProDebut", Order = 22)]
        public DateTime? ProDebut { get; set; }

        /// <summary>
        /// The player's salary for the current season.
        /// </summary>
        [Description("The player's salary for the current season.")]
        [DataMember(Name = "Salary", Order = 23)]
        public int? Salary { get; set; }

        /// <summary>
        /// The URL of the player's headshot photo.
        /// </summary>
        [Description("The URL of the player's headshot photo.")]
        [DataMember(Name = "PhotoUrl", Order = 24)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// This player's unique ID for cross reference use with the SportRadar API.
        /// </summary>
        [Description("This player's unique ID for cross reference use with the SportRadar API.")]
        [DataMember(Name = "SportRadarPlayerID", Order = 25)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Rotoworld.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Rotoworld.")]
        [DataMember(Name = "RotoworldPlayerID", Order = 26)]
        public int? RotoworldPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with RotoWire.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with RotoWire.")]
        [DataMember(Name = "RotoWirePlayerID", Order = 27)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with FantasyAlarm.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with FantasyAlarm.")]
        [DataMember(Name = "FantasyAlarmPlayerID", Order = 28)]
        public int? FantasyAlarmPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Stats Player.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Stats Player.")]
        [DataMember(Name = "StatsPlayerID", Order = 29)]
        public int? StatsPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Sports Direct.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Sports Direct.")]
        [DataMember(Name = "SportsDirectPlayerID", Order = 30)]
        public int? SportsDirectPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Xml Team.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Xml Team.")]
        [DataMember(Name = "XmlTeamPlayerID", Order = 31)]
        public int? XmlTeamPlayerID { get; set; }

        /// <summary>
        /// Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out, 7 Day Disabled List, 15 Day Disabled List, 60 Day Disabled List
        /// </summary>
        [Description("Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out, 7 Day Disabled List, 15 Day Disabled List, 60 Day Disabled List")]
        [DataMember(Name = "InjuryStatus", Order = 32)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// Indicates the player's injured body part. (e.g. ankle, knee, etc.) 
        /// </summary>
        [Description("Indicates the player's injured body part. (e.g. ankle, knee, etc.) ")]
        [DataMember(Name = "InjuryBodyPart", Order = 33)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Indicates the start date of the player's injury.
        /// </summary>
        [Description("Indicates the start date of the player's injury.")]
        [DataMember(Name = "InjuryStartDate", Order = 34)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Inidcates any notes about the player's injury.
        /// </summary>
        [Description("Inidcates any notes about the player's injury.")]
        [DataMember(Name = "InjuryNotes", Order = 35)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Fan Duel.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Fan Duel.")]
        [DataMember(Name = "FanDuelPlayerID", Order = 36)]
        public int? FanDuelPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Draft Kings.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Draft Kings.")]
        [DataMember(Name = "DraftKingsPlayerID", Order = 37)]
        public int? DraftKingsPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Yahoo.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Yahoo.")]
        [DataMember(Name = "YahooPlayerID", Order = 38)]
        public int? YahooPlayerID { get; set; }

        /// <summary>
        /// The GameID of this player's upcoming game.
        /// </summary>
        [Description("The GameID of this player's upcoming game.")]
        [DataMember(Name = "UpcomingGameID", Order = 39)]
        public int? UpcomingGameID { get; set; }

        /// <summary>
        /// The player's name on FanDuel.
        /// </summary>
        [Description("The player's name on FanDuel.")]
        [DataMember(Name = "FanDuelName", Order = 40)]
        public string FanDuelName { get; set; }

        /// <summary>
        /// The player's name on Fan Draft Kings.
        /// </summary>
        [Description("The player's name on Fan Draft Kings.")]
        [DataMember(Name = "DraftKingsName", Order = 41)]
        public string DraftKingsName { get; set; }

        /// <summary>
        /// The player's name on Yahoo.
        /// </summary>
        [Description("The player's name on Yahoo.")]
        [DataMember(Name = "YahooName", Order = 42)]
        public string YahooName { get; set; }

        /// <summary>
        /// A globally unique ID for this player. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this player. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 43)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's name on Fantasy Draft.
        /// </summary>
        [Description("The player's name on Fantasy Draft.")]
        [DataMember(Name = "FantasyDraftName", Order = 44)]
        public string FantasyDraftName { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Fantasy Draft.
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Fantasy Draft.")]
        [DataMember(Name = "FantasyDraftPlayerID", Order = 45)]
        public int? FantasyDraftPlayerID { get; set; }

        /// <summary>
        /// The player's years of experience
        /// </summary>
        [Description("The player's years of experience")]
        [DataMember(Name = "Experience", Order = 46)]
        public string Experience { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds.")]
        [DataMember(Name = "UsaTodayPlayerID", Order = 47)]
        public int? UsaTodayPlayerID { get; set; }

        /// <summary>
        /// The player's headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUrl", Order = 48)]
        public string UsaTodayHeadshotUrl { get; set; }

        /// <summary>
        /// The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUrl", Order = 49)]
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }

    }
}

