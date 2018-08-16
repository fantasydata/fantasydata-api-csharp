using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        /// Indicates the player's status of being on an active roster. Possible values include: Active, Inactive
        /// </summary>
        [Description("Indicates the player's status of being on an active roster. Possible values include: Active, Inactive")]
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
        /// The player's position category. Possible values: C, F, G
        /// </summary>
        [Description("The player's position category. Possible values: C, F, G")]
        [DataMember(Name = "PositionCategory", Order = 7)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C, PF, PG, SF, SG
        /// </summary>
        [Description("The player's primary position. Possible values: C, PF, PG, SF, SG")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The player's first name.
        /// </summary>
        [Description("The player's first name.")]
        [DataMember(Name = "FirstName", Order = 9)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name.
        /// </summary>
        [Description("The player's last name.")]
        [DataMember(Name = "LastName", Order = 10)]
        public string LastName { get; set; }

        /// <summary>
        /// The player's height in inches.
        /// </summary>
        [Description("The player's height in inches.")]
        [DataMember(Name = "Height", Order = 11)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs).
        /// </summary>
        [Description("The player's weight in pounds (lbs).")]
        [DataMember(Name = "Weight", Order = 12)]
        public int? Weight { get; set; }

        /// <summary>
        /// The player's date of birth.
        /// </summary>
        [Description("The player's date of birth.")]
        [DataMember(Name = "BirthDate", Order = 13)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born.
        /// </summary>
        [Description("The city in which the player was born.")]
        [DataMember(Name = "BirthCity", Order = 14)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born.
        /// </summary>
        [Description("The state in which the player was born.")]
        [DataMember(Name = "BirthState", Order = 15)]
        public string BirthState { get; set; }

        /// <summary>
        /// The country in which the player was born.
        /// </summary>
        [Description("The country in which the player was born.")]
        [DataMember(Name = "BirthCountry", Order = 16)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The high school that the player attended.
        /// </summary>
        [Description("The high school that the player attended.")]
        [DataMember(Name = "HighSchool", Order = 17)]
        public string HighSchool { get; set; }

        /// <summary>
        /// The college that the player attended.
        /// </summary>
        [Description("The college that the player attended.")]
        [DataMember(Name = "College", Order = 18)]
        public string College { get; set; }

        /// <summary>
        /// The player's salary for the current season.
        /// </summary>
        [Description("The player's salary for the current season.")]
        [DataMember(Name = "Salary", Order = 19)]
        public int? Salary { get; set; }

        /// <summary>
        /// The URL of the player's headshot photo.
        /// </summary>
        [Description("The URL of the player's headshot photo.")]
        [DataMember(Name = "PhotoUrl", Order = 20)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The number of years experience the player has in the NBA.
        /// </summary>
        [Description("The number of years experience the player has in the NBA.")]
        [DataMember(Name = "Experience", Order = 21)]
        public int? Experience { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportRadar API.
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportRadar API.")]
        [DataMember(Name = "SportRadarPlayerID", Order = 22)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the Rotoworld news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the Rotoworld news feed.")]
        [DataMember(Name = "RotoworldPlayerID", Order = 23)]
        public int? RotoworldPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the RotoWire news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the RotoWire news feed.")]
        [DataMember(Name = "RotoWirePlayerID", Order = 24)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the FantasyAlarm news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the FantasyAlarm news feed.")]
        [DataMember(Name = "FantasyAlarmPlayerID", Order = 25)]
        public int? FantasyAlarmPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the STATS data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to the STATS data feeds.")]
        [DataMember(Name = "StatsPlayerID", Order = 26)]
        public int? StatsPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportsDirect data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportsDirect data feeds.")]
        [DataMember(Name = "SportsDirectPlayerID", Order = 27)]
        public int? SportsDirectPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the XML Team data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to the XML Team data feeds.")]
        [DataMember(Name = "XmlTeamPlayerID", Order = 28)]
        public int? XmlTeamPlayerID { get; set; }

        /// <summary>
        /// Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out
        /// </summary>
        [Description("Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out")]
        [DataMember(Name = "InjuryStatus", Order = 29)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 30)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered.
        /// </summary>
        [Description("The day that the injury started or first discovered.")]
        [DataMember(Name = "InjuryStartDate", Order = 31)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Brief description of the player's injury and expected availability.
        /// </summary>
        [Description("Brief description of the player's injury and expected availability.")]
        [DataMember(Name = "InjuryNotes", Order = 32)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to FanDuel.
        /// </summary>
        [Description("The player's cross reference PlayerID to FanDuel.")]
        [DataMember(Name = "FanDuelPlayerID", Order = 33)]
        public int? FanDuelPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to DraftKings.
        /// </summary>
        [Description("The player's cross reference PlayerID to DraftKings.")]
        [DataMember(Name = "DraftKingsPlayerID", Order = 34)]
        public int? DraftKingsPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to Yahoo Daily Fantasy Sports Contests.
        /// </summary>
        [Description("The player's cross reference PlayerID to Yahoo Daily Fantasy Sports Contests.")]
        [DataMember(Name = "YahooPlayerID", Order = 35)]
        public int? YahooPlayerID { get; set; }

        /// <summary>
        /// The player's full name in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FanDuelName", Order = 36)]
        public string FanDuelName { get; set; }

        /// <summary>
        /// The player's full name in DraftKings' daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in DraftKings' daily fantasy sports platform.")]
        [DataMember(Name = "DraftKingsName", Order = 37)]
        public string DraftKingsName { get; set; }

        /// <summary>
        /// The player's full name in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooName", Order = 38)]
        public string YahooName { get; set; }

        /// <summary>
        /// The position of the player on the depth chart.
        /// </summary>
        [Description("The position of the player on the depth chart.")]
        [DataMember(Name = "DepthChartPosition", Order = 39)]
        public string DepthChartPosition { get; set; }

        /// <summary>
        /// The order of the player on the depth chart.
        /// </summary>
        [Description("The order of the player on the depth chart.")]
        [DataMember(Name = "DepthChartOrder", Order = 40)]
        public int? DepthChartOrder { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 41)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's full name in FantasyDraft's daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in FantasyDraft's daily fantasy sports platform.")]
        [DataMember(Name = "FantasyDraftName", Order = 42)]
        public string FantasyDraftName { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to Fantasy Draft.
        /// </summary>
        [Description("The player's cross reference PlayerID to Fantasy Draft.")]
        [DataMember(Name = "FantasyDraftPlayerID", Order = 43)]
        public int? FantasyDraftPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds.")]
        [DataMember(Name = "UsaTodayPlayerID", Order = 44)]
        public int? UsaTodayPlayerID { get; set; }

        /// <summary>
        /// The player's headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUrl", Order = 45)]
        public string UsaTodayHeadshotUrl { get; set; }

        /// <summary>
        /// The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUrl", Order = 46)]
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }

    }
}

