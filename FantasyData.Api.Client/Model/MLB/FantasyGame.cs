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
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)
        /// </summary>
        [Description("The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)")]
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
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// The name of the opponent
        /// </summary>
        [Description("The name of the opponent")]
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
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 11)]
        public string Name { get; set; }

        /// <summary>
        /// The player's position associated with the given game or season. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS
        /// </summary>
        [Description("The player's position associated with the given game or season. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS")]
        [DataMember(Name = "Position", Order = 12)]
        public string Position { get; set; }

        /// <summary>
        /// The category (P, C, 1B, OF, SS) of the players position
        /// </summary>
        [Description("The category (P, C, 1B, OF, SS) of the players position")]
        [DataMember(Name = "PositionCategory", Order = 13)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 14)]
        public int? Games { get; set; }

        /// <summary>
        /// Whether the player started
        /// </summary>
        [Description("Whether the player started")]
        [DataMember(Name = "Started", Order = 15)]
        public int? Started { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 16)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total batting fantasy points
        /// </summary>
        [Description("Total batting fantasy points")]
        [DataMember(Name = "FantasyPointsBatting", Order = 17)]
        public decimal? FantasyPointsBatting { get; set; }

        /// <summary>
        /// Total pitching fantasy points
        /// </summary>
        [Description("Total pitching fantasy points")]
        [DataMember(Name = "FantasyPointsPitching", Order = 18)]
        public decimal? FantasyPointsPitching { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 19)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Total FanDuel fantasy points
        /// </summary>
        [Description("Total FanDuel fantasy points")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 20)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points
        /// </summary>
        [Description("Total Yahoo fantasy points")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 21)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total DraftKings fantasy points
        /// </summary>
        [Description("Total DraftKings fantasy points")]
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
        /// The player's eligible position in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooPosition", Order = 25)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentRank", Order = 26)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed.")]
        [DataMember(Name = "OppositionPositionRank", Order = 27)]
        public int? OppositionPositionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 28)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 29)]
        public DateTime? Updated { get; set; }

    }
}

