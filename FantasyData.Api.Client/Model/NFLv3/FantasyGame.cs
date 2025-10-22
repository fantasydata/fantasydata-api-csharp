using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
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
        /// The unique PlayerID of the player as assigned by SportsDataIO tied to this FantasyGame record Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO tied to this FantasyGame record Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).
        /// </summary>
        [Description("The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 7)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 8)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team")]
        [DataMember(Name = "Opponent", Order = 9)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 10)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 11)]
        public int Number { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 12)]
        public string Name { get; set; }

        /// <summary>
        /// The primary position of the player Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR
        /// </summary>
        [Description("The primary position of the player Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR")]
        [DataMember(Name = "Position", Order = 13)]
        public string Position { get; set; }

        /// <summary>
        /// The category of the player's position (OFF; DEF; ST)
        /// </summary>
        [Description("The category of the player's position (OFF; DEF; ST)")]
        [DataMember(Name = "PositionCategory", Order = 14)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Whether or not the player was active for the game
        /// </summary>
        [Description("Whether or not the player was active for the game")]
        [DataMember(Name = "Activated", Order = 15)]
        public int Activated { get; set; }

        /// <summary>
        /// Whether the player played at least one snap in the game Note: Will return "1" if player played at least one snap and "0" if they did not
        /// </summary>
        [Description("Whether the player played at least one snap in the game Note: Will return \"1\" if player played at least one snap and \"0\" if they did not")]
        [DataMember(Name = "Played", Order = 16)]
        public int Played { get; set; }

        /// <summary>
        /// Whether the player started the game (on offensive or defense) Note: Started = 1 / Did Not Start = 0
        /// </summary>
        [Description("Whether the player started the game (on offensive or defense) Note: Started = 1 / Did Not Start = 0")]
        [DataMember(Name = "Started", Order = 17)]
        public int Started { get; set; }

        /// <summary>
        /// Total fantasy points by the player in the game
        /// </summary>
        [Description("Total fantasy points by the player in the game")]
        [DataMember(Name = "FantasyPoints", Order = 18)]
        public decimal FantasyPoints { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic PPR fantasy scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points scored based on basic PPR fantasy scoring system by the player in the game")]
        [DataMember(Name = "FantasyPointsPPR", Order = 19)]
        public decimal FantasyPointsPPR { get; set; }

        /// <summary>
        /// The player's fantasy football position Possible values: QB; RB; WR; TE; DL; LB; DB; K; P; OL
        /// </summary>
        [Description("The player's fantasy football position Possible values: QB; RB; WR; TE; DL; LB; DB; K; P; OL")]
        [DataMember(Name = "FantasyPosition", Order = 20)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 21)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system by the player in the game")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 22)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system by the player in the game")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 23)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total DraftKings daily fantasy points scored by the player in the game
        /// </summary>
        [Description("Total DraftKings daily fantasy points scored by the player in the game")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 24)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform")]
        [DataMember(Name = "FanDuelPosition", Order = 25)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The player's eligible position in DraftKings' daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in DraftKings' daily fantasy sports platform")]
        [DataMember(Name = "DraftKingsPosition", Order = 26)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's eligible position in Yahoo's daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform")]
        [DataMember(Name = "YahooPosition", Order = 27)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed")]
        [DataMember(Name = "OpponentRank", Order = 28)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed")]
        [DataMember(Name = "OpponentPositionRank", Order = 29)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 30)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// Time of last sync (in US Eastern time) Note: this does not indicate that stats changed
        /// </summary>
        [Description("Time of last sync (in US Eastern time) Note: this does not indicate that stats changed")]
        [DataMember(Name = "Updated", Order = 31)]
        public DateTime? Updated { get; set; }

    }
}

