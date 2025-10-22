using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        public int? GameID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NBA season of the game
        /// </summary>
        [Description("The NBA season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int? Season { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// Abbreviation [Key] of the opponent team (e.g. LAL; PHI; BOS; CHI; etc.)
        /// </summary>
        [Description("Abbreviation [Key] of the opponent team (e.g. LAL; PHI; BOS; CHI; etc.)")]
        [DataMember(Name = "Opponent", Order = 8)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 9)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The player's jersey number
        /// </summary>
        [Description("The player's jersey number")]
        [DataMember(Name = "Jersey", Order = 10)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 11)]
        public string Name { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: PG; SG; SF; PF; C
        /// </summary>
        [Description("The player's primary position. Possible values: PG; SG; SF; PF; C")]
        [DataMember(Name = "Position", Order = 12)]
        public string Position { get; set; }

        /// <summary>
        /// The player's position category. Possible values: C, F, G
        /// </summary>
        [Description("The player's position category. Possible values: C, F, G")]
        [DataMember(Name = "PositionCategory", Order = 13)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The number of games played by the player in the game Note: this will be one or zero for single game feeds
        /// </summary>
        [Description("The number of games played by the player in the game Note: this will be one or zero for single game feeds")]
        [DataMember(Name = "Games", Order = 14)]
        public int? Games { get; set; }

        /// <summary>
        /// Indicates whether or not the player started the game Note: this will be one or zero for single game feeds
        /// </summary>
        [Description("Indicates whether or not the player started the game Note: this will be one or zero for single game feeds")]
        [DataMember(Name = "Started", Order = 15)]
        public int? Started { get; set; }

        /// <summary>
        /// Total fantasy points by the player in the game
        /// </summary>
        [Description("Total fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPoints", Order = 16)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 17)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// Total FanDuel daily fantasy points scored
        /// </summary>
        [Description("Total FanDuel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 18)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 19)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total DraftKings daily fantasy points scored
        /// </summary>
        [Description("Total DraftKings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 20)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FandDuelPosition", Order = 21)]
        public string FandDuelPosition { get; set; }

        /// <summary>
        /// The player's eligible position in DraftKings' daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in DraftKings' daily fantasy sports platform.")]
        [DataMember(Name = "DraftKingsPosition", Order = 22)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's eligible position in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooPosition", Order = 23)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentRank", Order = 24)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentPositionRank", Order = 25)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 26)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 27)]
        public DateTime? Updated { get; set; }

    }
}

