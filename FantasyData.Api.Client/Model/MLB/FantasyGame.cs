using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="FantasyGame")]
    [Serializable]
    public partial class FantasyGame
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The MLB season of the game
        /// </summary>
        [Description("The MLB season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int? Season { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// The name [Key] of the player's opponent in the game
        /// </summary>
        [Description("The name [Key] of the player's opponent in the game")]
        [DataMember(Name = "Opponent", Order = 8)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 9)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 10)]
        public int? Jersey { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 11)]
        public string Name { get; set; }

        /// <summary>
        /// The player's position associated with the given game or season. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS
        /// </summary>
        [Description("The player's position associated with the given game or season. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS")]
        [DataMember(Name = "Position", Order = 12)]
        public string Position { get; set; }

        /// <summary>
        /// The player's position category. Possible values: DH; IF; OF; P; PH; PR
        /// </summary>
        [Description("The player's position category. Possible values: DH; IF; OF; P; PH; PR")]
        [DataMember(Name = "PositionCategory", Order = 13)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The number of games played by the player. Note: for game feeds this will always = 1
        /// </summary>
        [Description("The number of games played by the player. Note: for game feeds this will always = 1")]
        [DataMember(Name = "Games", Order = 14)]
        public int? Games { get; set; }

        /// <summary>
        /// Whether the player started in the game. Note: started = 1 and not starting = 0
        /// </summary>
        [Description("Whether the player started in the game. Note: started = 1 and not starting = 0")]
        [DataMember(Name = "Started", Order = 15)]
        public int? Started { get; set; }

        /// <summary>
        /// Total fantasy points by the player during the game
        /// </summary>
        [Description("Total fantasy points by the player during the game")]
        [DataMember(Name = "FantasyPoints", Order = 16)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total batting fantasy points by the player in the game
        /// </summary>
        [Description("Total batting fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPointsBatting", Order = 17)]
        public decimal? FantasyPointsBatting { get; set; }

        /// <summary>
        /// Total pitching fantasy points by the player in the game
        /// </summary>
        [Description("Total pitching fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPointsPitching", Order = 18)]
        public decimal? FantasyPointsPitching { get; set; }

        /// <summary>
        /// Whether or not the game is over (returns ture/false)
        /// </summary>
        [Description("Whether or not the game is over (returns ture/false)")]
        [DataMember(Name = "IsGameOver", Order = 19)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Total FanDuel fantasy points by the player in the game
        /// </summary>
        [Description("Total FanDuel fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 20)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points by the player in the game
        /// </summary>
        [Description("Total Yahoo fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 21)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total DraftKings fantasy points by the player in the game
        /// </summary>
        [Description("Total DraftKings fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 22)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FanDuelPosition", Order = 23)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The player's eligible position in DraftKings' daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in DraftKings' daily fantasy sports platform.")]
        [DataMember(Name = "DraftKingsPosition", Order = 24)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's eligible position in Yahoo's daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform")]
        [DataMember(Name = "YahooPosition", Order = 25)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed")]
        [DataMember(Name = "OpponentRank", Order = 26)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed")]
        [DataMember(Name = "OppositionPositionRank", Order = 27)]
        public int? OppositionPositionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 28)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The date and time of the late update made to this record (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the late update made to this record (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 29)]
        public DateTime? Updated { get; set; }

    }
}

