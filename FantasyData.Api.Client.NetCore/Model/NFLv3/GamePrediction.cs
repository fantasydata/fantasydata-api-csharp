using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="GamePrediction")]
    [Serializable]
    public partial class GamePrediction
    {
        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 1)]
        public int ScoreID { get; set; }

        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 2)]
        public string GameKey { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season, 2=Preseason, 3=Postseason).
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season, 2=Preseason, 3=Postseason).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 5)]
        public int Week { get; set; }

        /// <summary>
        /// The date/time of the game
        /// </summary>
        [Description("The date/time of the game")]
        [DataMember(Name = "Date", Order = 6)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 7)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team 
        /// </summary>
        [Description("The unique ID of the home team ")]
        [DataMember(Name = "HomeTeamID", Order = 8)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 9)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 10)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 11)]
        public string Status { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team
        /// </summary>
        [Description("Money line from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 12)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team
        /// </summary>
        [Description("Money line from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 13)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 14)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under (O/U) at game start
        /// </summary>
        [Description("The oddsmaker Over/Under (O/U) at game start")]
        [DataMember(Name = "OverUnder", Order = 15)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Percentage chance the Away Team covers the spread
        /// </summary>
        [Description("Percentage chance the Away Team covers the spread")]
        [DataMember(Name = "AwayTeamCoverSpreadChance", Order = 16)]
        public decimal? AwayTeamCoverSpreadChance { get; set; }

        /// <summary>
        /// Percentage chance the Home Team covers the spread
        /// </summary>
        [Description("Percentage chance the Home Team covers the spread")]
        [DataMember(Name = "HomeTeamCoverSpreadChance", Order = 17)]
        public decimal? HomeTeamCoverSpreadChance { get; set; }

        /// <summary>
        /// Percentage chance the total points scored is over the O/U (i.e. O/U is 45, total points scored 49)
        /// </summary>
        [Description("Percentage chance the total points scored is over the O/U (i.e. O/U is 45, total points scored 49)")]
        [DataMember(Name = "OverChance", Order = 18)]
        public decimal? OverChance { get; set; }

        /// <summary>
        /// Percentage chance the total points scored is under the O/U (i.e. O/U is 45, total points scored 42)
        /// </summary>
        [Description("Percentage chance the total points scored is under the O/U (i.e. O/U is 45, total points scored 42)")]
        [DataMember(Name = "UnderChance", Order = 19)]
        public decimal? UnderChance { get; set; }

        /// <summary>
        /// Percentage chance the Away team wins
        /// </summary>
        [Description("Percentage chance the Away team wins")]
        [DataMember(Name = "AwayTeamWinChance", Order = 20)]
        public decimal? AwayTeamWinChance { get; set; }

        /// <summary>
        /// Percentage chance the Home team wins
        /// </summary>
        [Description("Percentage chance the Home team wins")]
        [DataMember(Name = "HomeTeamWinChance", Order = 21)]
        public decimal? HomeTeamWinChance { get; set; }

    }
}

