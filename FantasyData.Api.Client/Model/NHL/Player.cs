using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The first name of the player.
        /// </summary>
        [Description("The first name of the player.")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the player.
        /// </summary>
        [Description("The last name of the player.")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// Indicates the player's status of being on an active roster. Possible values include: Active, Inactive
        /// </summary>
        [Description("Indicates the player's status of being on an active roster. Possible values include: Active, Inactive")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The TeamID of the team this player is employed by.
        /// </summary>
        [Description("The TeamID of the team this player is employed by.")]
        [DataMember(Name = "TeamID", Order = 5)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The key/abbreviation of the team this player is employed by.
        /// </summary>
        [Description("The key/abbreviation of the team this player is employed by.")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C, RW, LW, D, or G.
        /// </summary>
        [Description("The player's primary position. Possible values: C, RW, LW, D, or G.")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 8)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The hand in which the player catches the puck (right or left).
        /// </summary>
        [Description("The hand in which the player catches the puck (right or left).")]
        [DataMember(Name = "Catches", Order = 9)]
        public string Catches { get; set; }

        /// <summary>
        /// The hand the player shoots the puck with (right or left).
        /// </summary>
        [Description("The hand the player shoots the puck with (right or left).")]
        [DataMember(Name = "Shoots", Order = 10)]
        public string Shoots { get; set; }

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
        /// The URL of the player's headshot photo.
        /// </summary>
        [Description("The URL of the player's headshot photo.")]
        [DataMember(Name = "PhotoUrl", Order = 16)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportRadar API.
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportRadar API.")]
        [DataMember(Name = "SportRadarPlayerID", Order = 17)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the Rotoworld news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the Rotoworld news feed.")]
        [DataMember(Name = "RotoworldPlayerID", Order = 18)]
        public int? RotoworldPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the RotoWire news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the RotoWire news feed.")]
        [DataMember(Name = "RotoWirePlayerID", Order = 19)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the FantasyAlarm news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the FantasyAlarm news feed.")]
        [DataMember(Name = "FantasyAlarmPlayerID", Order = 20)]
        public int? FantasyAlarmPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the STATS data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to the STATS data feeds.")]
        [DataMember(Name = "StatsPlayerID", Order = 21)]
        public int? StatsPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportsDirect data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportsDirect data feeds.")]
        [DataMember(Name = "SportsDirectPlayerID", Order = 22)]
        public int? SportsDirectPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the XML Team data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to the XML Team data feeds.")]
        [DataMember(Name = "XmlTeamPlayerID", Order = 23)]
        public int? XmlTeamPlayerID { get; set; }

        /// <summary>
        /// Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out
        /// </summary>
        [Description("Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out")]
        [DataMember(Name = "InjuryStatus", Order = 24)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 25)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered.
        /// </summary>
        [Description("The day that the injury started or first discovered.")]
        [DataMember(Name = "InjuryStartDate", Order = 26)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Brief description of the player's injury and expected availability.
        /// </summary>
        [Description("Brief description of the player's injury and expected availability.")]
        [DataMember(Name = "InjuryNotes", Order = 27)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to FanDuel.
        /// </summary>
        [Description("The player's cross reference PlayerID to FanDuel.")]
        [DataMember(Name = "FanDuelPlayerID", Order = 28)]
        public int? FanDuelPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to DraftKings.
        /// </summary>
        [Description("The player's cross reference PlayerID to DraftKings.")]
        [DataMember(Name = "DraftKingsPlayerID", Order = 29)]
        public int? DraftKingsPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to Yahoo Daily Fantasy Sports Contests.
        /// </summary>
        [Description("The player's cross reference PlayerID to Yahoo Daily Fantasy Sports Contests.")]
        [DataMember(Name = "YahooPlayerID", Order = 30)]
        public int? YahooPlayerID { get; set; }

        /// <summary>
        /// The player's full name in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FanDuelName", Order = 31)]
        public string FanDuelName { get; set; }

        /// <summary>
        /// The player's full name in DraftKings' daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in DraftKings' daily fantasy sports platform.")]
        [DataMember(Name = "DraftKingsName", Order = 32)]
        public string DraftKingsName { get; set; }

        /// <summary>
        /// The player's full name in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooName", Order = 33)]
        public string YahooName { get; set; }

        /// <summary>
        /// The position of the player on the depth chart.
        /// </summary>
        [Description("The position of the player on the depth chart.")]
        [DataMember(Name = "DepthChartPosition", Order = 34)]
        public string DepthChartPosition { get; set; }

        /// <summary>
        /// The order of the player on the depth chart.
        /// </summary>
        [Description("The order of the player on the depth chart.")]
        [DataMember(Name = "DepthChartOrder", Order = 35)]
        public int? DepthChartOrder { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 36)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's full name in FantasyDraft's daily fantasy sports platform.
        /// </summary>
        [Description("The player's full name in FantasyDraft's daily fantasy sports platform.")]
        [DataMember(Name = "FantasyDraftName", Order = 37)]
        public string FantasyDraftName { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to Fantasy Draft.
        /// </summary>
        [Description("The player's cross reference PlayerID to Fantasy Draft.")]
        [DataMember(Name = "FantasyDraftPlayerID", Order = 38)]
        public int? FantasyDraftPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds.")]
        [DataMember(Name = "UsaTodayPlayerID", Order = 39)]
        public int? UsaTodayPlayerID { get; set; }

        /// <summary>
        /// The player's headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUrl", Order = 40)]
        public string UsaTodayHeadshotUrl { get; set; }

        /// <summary>
        /// The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUrl", Order = 41)]
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }

    }
}

