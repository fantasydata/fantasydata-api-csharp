using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="GameStat")]
    [Serializable]
    public partial class GameStat
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 1)]
        public int? GameId { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentId", Order = 2)]
        public int? OpponentId { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 3)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 6)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 7)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 8)]
        public int? GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentId", Order = 9)]
        public int? GlobalOpponentId { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 11)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 12)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 13)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total Fan Duel daily fantasy points scored
        /// </summary>
        [Description("Total Fan Duel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 14)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Draft Kings daily fantasy points scored
        /// </summary>
        [Description("Total Draft Kings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 15)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 16)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total Mondogoal fantasy points scored
        /// </summary>
        [Description("Total Mondogoal fantasy points scored")]
        [DataMember(Name = "FantasyPointsMondogoal", Order = 17)]
        public decimal? FantasyPointsMondogoal { get; set; }

        /// <summary>
        /// Total minutes
        /// </summary>
        [Description("Total minutes")]
        [DataMember(Name = "Minutes", Order = 18)]
        public decimal? Minutes { get; set; }

        /// <summary>
        /// Total goals
        /// </summary>
        [Description("Total goals")]
        [DataMember(Name = "Goals", Order = 19)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 20)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots
        /// </summary>
        [Description("Total shots")]
        [DataMember(Name = "Shots", Order = 21)]
        public decimal? Shots { get; set; }

        /// <summary>
        /// Total shots on goal
        /// </summary>
        [Description("Total shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 22)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total yellow cards
        /// </summary>
        [Description("Total yellow cards")]
        [DataMember(Name = "YellowCards", Order = 23)]
        public decimal? YellowCards { get; set; }

        /// <summary>
        /// Total red cards
        /// </summary>
        [Description("Total red cards")]
        [DataMember(Name = "RedCards", Order = 24)]
        public decimal? RedCards { get; set; }

        /// <summary>
        /// Total yellow red cards
        /// </summary>
        [Description("Total yellow red cards")]
        [DataMember(Name = "YellowRedCards", Order = 25)]
        public decimal? YellowRedCards { get; set; }

        /// <summary>
        /// Total crosses
        /// </summary>
        [Description("Total crosses")]
        [DataMember(Name = "Crosses", Order = 26)]
        public decimal? Crosses { get; set; }

        /// <summary>
        /// Total tackles won
        /// </summary>
        [Description("Total tackles won")]
        [DataMember(Name = "TacklesWon", Order = 27)]
        public decimal? TacklesWon { get; set; }

        /// <summary>
        /// Total interceptions
        /// </summary>
        [Description("Total interceptions")]
        [DataMember(Name = "Interceptions", Order = 28)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total own goals
        /// </summary>
        [Description("Total own goals")]
        [DataMember(Name = "OwnGoals", Order = 29)]
        public decimal? OwnGoals { get; set; }

        /// <summary>
        /// Total foul
        /// </summary>
        [Description("Total foul")]
        [DataMember(Name = "Fouls", Order = 30)]
        public decimal? Fouls { get; set; }

        /// <summary>
        /// Total times fouled
        /// </summary>
        [Description("Total times fouled")]
        [DataMember(Name = "Fouled", Order = 31)]
        public decimal? Fouled { get; set; }

        /// <summary>
        /// Total offsides
        /// </summary>
        [Description("Total offsides")]
        [DataMember(Name = "Offsides", Order = 32)]
        public decimal? Offsides { get; set; }

        /// <summary>
        /// Total passes
        /// </summary>
        [Description("Total passes")]
        [DataMember(Name = "Passes", Order = 33)]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Total passes completed
        /// </summary>
        [Description("Total passes completed")]
        [DataMember(Name = "PassesCompleted", Order = 34)]
        public decimal? PassesCompleted { get; set; }

        /// <summary>
        /// Total last man tackle
        /// </summary>
        [Description("Total last man tackle")]
        [DataMember(Name = "LastManTackle", Order = 35)]
        public decimal? LastManTackle { get; set; }

        /// <summary>
        /// Total corners won
        /// </summary>
        [Description("Total corners won")]
        [DataMember(Name = "CornersWon", Order = 36)]
        public decimal? CornersWon { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 37)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total touches
        /// </summary>
        [Description("Total touches")]
        [DataMember(Name = "Touches", Order = 38)]
        public decimal? Touches { get; set; }

        /// <summary>
        /// Total defender clean sheets
        /// </summary>
        [Description("Total defender clean sheets")]
        [DataMember(Name = "DefenderCleanSheets", Order = 39)]
        public decimal? DefenderCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper saves
        /// </summary>
        [Description("Total goalkeeper saves")]
        [DataMember(Name = "GoalkeeperSaves", Order = 40)]
        public decimal? GoalkeeperSaves { get; set; }

        /// <summary>
        /// Total goalkeeper goals against
        /// </summary>
        [Description("Total goalkeeper goals against")]
        [DataMember(Name = "GoalkeeperGoalsAgainst", Order = 41)]
        public decimal? GoalkeeperGoalsAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper single goal against
        /// </summary>
        [Description("Total goalkeeper single goal against")]
        [DataMember(Name = "GoalkeeperSingleGoalAgainst", Order = 42)]
        public decimal? GoalkeeperSingleGoalAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper clean sheets
        /// </summary>
        [Description("Total goalkeeper clean sheets")]
        [DataMember(Name = "GoalkeeperCleanSheets", Order = 43)]
        public decimal? GoalkeeperCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper wins
        /// </summary>
        [Description("Total goalkeeper wins")]
        [DataMember(Name = "GoalkeeperWins", Order = 44)]
        public decimal? GoalkeeperWins { get; set; }

        /// <summary>
        /// Total penalty kick goals
        /// </summary>
        [Description("Total penalty kick goals")]
        [DataMember(Name = "PenaltyKickGoals", Order = 45)]
        public decimal? PenaltyKickGoals { get; set; }

        /// <summary>
        /// Total penalty kick misses
        /// </summary>
        [Description("Total penalty kick misses")]
        [DataMember(Name = "PenaltyKickMisses", Order = 46)]
        public decimal? PenaltyKickMisses { get; set; }

        /// <summary>
        /// Total penalty kick saves
        /// </summary>
        [Description("Total penalty kick saves")]
        [DataMember(Name = "PenaltyKickSaves", Order = 47)]
        public decimal? PenaltyKickSaves { get; set; }

        /// <summary>
        /// Total penalties won
        /// </summary>
        [Description("Total penalties won")]
        [DataMember(Name = "PenaltiesWon", Order = 48)]
        public decimal? PenaltiesWon { get; set; }

        /// <summary>
        /// Total penalties conceded 
        /// </summary>
        [Description("Total penalties conceded ")]
        [DataMember(Name = "PenaltiesConceded", Order = 49)]
        public decimal? PenaltiesConceded { get; set; }

        /// <summary>
        /// Team goals scored
        /// </summary>
        [Description("Team goals scored")]
        [DataMember(Name = "Score", Order = 50)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Opponents goals scored
        /// </summary>
        [Description("Opponents goals scored")]
        [DataMember(Name = "OpponentScore", Order = 51)]
        public decimal? OpponentScore { get; set; }

    }
}

