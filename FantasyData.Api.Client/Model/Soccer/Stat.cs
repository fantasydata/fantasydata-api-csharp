using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Stat")]
    [Serializable]
    public partial class Stat
    {
        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 2)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 3)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 4)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total Fan Duel daily fantasy points scored
        /// </summary>
        [Description("Total Fan Duel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 5)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Draft Kings daily fantasy points scored
        /// </summary>
        [Description("Total Draft Kings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 6)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 7)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total Mondogoal fantasy points scored
        /// </summary>
        [Description("Total Mondogoal fantasy points scored")]
        [DataMember(Name = "FantasyPointsMondogoal", Order = 8)]
        public decimal? FantasyPointsMondogoal { get; set; }

        /// <summary>
        /// Total minutes
        /// </summary>
        [Description("Total minutes")]
        [DataMember(Name = "Minutes", Order = 9)]
        public decimal? Minutes { get; set; }

        /// <summary>
        /// Total goals
        /// </summary>
        [Description("Total goals")]
        [DataMember(Name = "Goals", Order = 10)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 11)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots
        /// </summary>
        [Description("Total shots")]
        [DataMember(Name = "Shots", Order = 12)]
        public decimal? Shots { get; set; }

        /// <summary>
        /// Total shots on goal
        /// </summary>
        [Description("Total shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 13)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total yellow cards
        /// </summary>
        [Description("Total yellow cards")]
        [DataMember(Name = "YellowCards", Order = 14)]
        public decimal? YellowCards { get; set; }

        /// <summary>
        /// Total red cards
        /// </summary>
        [Description("Total red cards")]
        [DataMember(Name = "RedCards", Order = 15)]
        public decimal? RedCards { get; set; }

        /// <summary>
        /// Total yellow red cards
        /// </summary>
        [Description("Total yellow red cards")]
        [DataMember(Name = "YellowRedCards", Order = 16)]
        public decimal? YellowRedCards { get; set; }

        /// <summary>
        /// Total crosses
        /// </summary>
        [Description("Total crosses")]
        [DataMember(Name = "Crosses", Order = 17)]
        public decimal? Crosses { get; set; }

        /// <summary>
        /// Total tackles won
        /// </summary>
        [Description("Total tackles won")]
        [DataMember(Name = "TacklesWon", Order = 18)]
        public decimal? TacklesWon { get; set; }

        /// <summary>
        /// Total interceptions
        /// </summary>
        [Description("Total interceptions")]
        [DataMember(Name = "Interceptions", Order = 19)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total own goals
        /// </summary>
        [Description("Total own goals")]
        [DataMember(Name = "OwnGoals", Order = 20)]
        public decimal? OwnGoals { get; set; }

        /// <summary>
        /// Total foul
        /// </summary>
        [Description("Total foul")]
        [DataMember(Name = "Fouls", Order = 21)]
        public decimal? Fouls { get; set; }

        /// <summary>
        /// Total times fouled
        /// </summary>
        [Description("Total times fouled")]
        [DataMember(Name = "Fouled", Order = 22)]
        public decimal? Fouled { get; set; }

        /// <summary>
        /// Total offsides
        /// </summary>
        [Description("Total offsides")]
        [DataMember(Name = "Offsides", Order = 23)]
        public decimal? Offsides { get; set; }

        /// <summary>
        /// Total passes
        /// </summary>
        [Description("Total passes")]
        [DataMember(Name = "Passes", Order = 24)]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Total passes completed
        /// </summary>
        [Description("Total passes completed")]
        [DataMember(Name = "PassesCompleted", Order = 25)]
        public decimal? PassesCompleted { get; set; }

        /// <summary>
        /// Total last man tackle
        /// </summary>
        [Description("Total last man tackle")]
        [DataMember(Name = "LastManTackle", Order = 26)]
        public decimal? LastManTackle { get; set; }

        /// <summary>
        /// Total corners won
        /// </summary>
        [Description("Total corners won")]
        [DataMember(Name = "CornersWon", Order = 27)]
        public decimal? CornersWon { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 28)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total touches
        /// </summary>
        [Description("Total touches")]
        [DataMember(Name = "Touches", Order = 29)]
        public decimal? Touches { get; set; }

        /// <summary>
        /// Total defender clean sheets
        /// </summary>
        [Description("Total defender clean sheets")]
        [DataMember(Name = "DefenderCleanSheets", Order = 30)]
        public decimal? DefenderCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper saves
        /// </summary>
        [Description("Total goalkeeper saves")]
        [DataMember(Name = "GoalkeeperSaves", Order = 31)]
        public decimal? GoalkeeperSaves { get; set; }

        /// <summary>
        /// Total goalkeeper goals against
        /// </summary>
        [Description("Total goalkeeper goals against")]
        [DataMember(Name = "GoalkeeperGoalsAgainst", Order = 32)]
        public decimal? GoalkeeperGoalsAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper single goal against
        /// </summary>
        [Description("Total goalkeeper single goal against")]
        [DataMember(Name = "GoalkeeperSingleGoalAgainst", Order = 33)]
        public decimal? GoalkeeperSingleGoalAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper clean sheets
        /// </summary>
        [Description("Total goalkeeper clean sheets")]
        [DataMember(Name = "GoalkeeperCleanSheets", Order = 34)]
        public decimal? GoalkeeperCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper wins
        /// </summary>
        [Description("Total goalkeeper wins")]
        [DataMember(Name = "GoalkeeperWins", Order = 35)]
        public decimal? GoalkeeperWins { get; set; }

        /// <summary>
        /// Total penalty kick goals
        /// </summary>
        [Description("Total penalty kick goals")]
        [DataMember(Name = "PenaltyKickGoals", Order = 36)]
        public decimal? PenaltyKickGoals { get; set; }

        /// <summary>
        /// Total penalty kick misses
        /// </summary>
        [Description("Total penalty kick misses")]
        [DataMember(Name = "PenaltyKickMisses", Order = 37)]
        public decimal? PenaltyKickMisses { get; set; }

        /// <summary>
        /// Total penalty kick saves
        /// </summary>
        [Description("Total penalty kick saves")]
        [DataMember(Name = "PenaltyKickSaves", Order = 38)]
        public decimal? PenaltyKickSaves { get; set; }

        /// <summary>
        /// Total penalties won
        /// </summary>
        [Description("Total penalties won")]
        [DataMember(Name = "PenaltiesWon", Order = 39)]
        public decimal? PenaltiesWon { get; set; }

        /// <summary>
        /// Total penalties conceded 
        /// </summary>
        [Description("Total penalties conceded ")]
        [DataMember(Name = "PenaltiesConceded", Order = 40)]
        public decimal? PenaltiesConceded { get; set; }

        /// <summary>
        /// Team goals scored
        /// </summary>
        [Description("Team goals scored")]
        [DataMember(Name = "Score", Order = 41)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Opponents goals scored
        /// </summary>
        [Description("Opponents goals scored")]
        [DataMember(Name = "OpponentScore", Order = 42)]
        public decimal? OpponentScore { get; set; }

    }
}

