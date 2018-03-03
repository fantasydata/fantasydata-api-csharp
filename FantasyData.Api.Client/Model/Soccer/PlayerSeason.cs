using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="PlayerSeason")]
    [Serializable]
    public partial class PlayerSeason
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatId", Order = 1)]
        public int StatId { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The soccer regular season for which these totals apply
        /// </summary>
        [Description("The soccer regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The unique ID of the round
        /// </summary>
        [Description("The unique ID of the round")]
        [DataMember(Name = "RoundId", Order = 4)]
        public int? RoundId { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamId", Order = 5)]
        public int? TeamId { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerId", Order = 6)]
        public int? PlayerId { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 7)]
        public string Name { get; set; }

        /// <summary>
        /// The short name of the player
        /// </summary>
        [Description("The short name of the player")]
        [DataMember(Name = "ShortName", Order = 8)]
        public string ShortName { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 9)]
        public string Team { get; set; }

        /// <summary>
        /// The player's position category. 
        /// </summary>
        [Description("The player's position category. ")]
        [DataMember(Name = "PositionCategory", Order = 10)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The position of the player. Possible values include: A (Attacker), M (Midfielder), D (Defender), GK (Goalkeeper)
        /// </summary>
        [Description("The position of the player. Possible values include: A (Attacker), M (Midfielder), D (Defender), GK (Goalkeeper)")]
        [DataMember(Name = "Position", Order = 11)]
        public string Position { get; set; }

        /// <summary>
        /// Number of games started
        /// </summary>
        [Description("Number of games started")]
        [DataMember(Name = "Started", Order = 12)]
        public int? Started { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamId", Order = 13)]
        public int? GlobalTeamId { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 15)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 16)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 17)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total Fan Duel daily fantasy points scored
        /// </summary>
        [Description("Total Fan Duel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 18)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Draft Kings daily fantasy points scored
        /// </summary>
        [Description("Total Draft Kings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 19)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 20)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total Mondogoal fantasy points scored
        /// </summary>
        [Description("Total Mondogoal fantasy points scored")]
        [DataMember(Name = "FantasyPointsMondogoal", Order = 21)]
        public decimal? FantasyPointsMondogoal { get; set; }

        /// <summary>
        /// Total minutes
        /// </summary>
        [Description("Total minutes")]
        [DataMember(Name = "Minutes", Order = 22)]
        public decimal? Minutes { get; set; }

        /// <summary>
        /// Total goals
        /// </summary>
        [Description("Total goals")]
        [DataMember(Name = "Goals", Order = 23)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 24)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots
        /// </summary>
        [Description("Total shots")]
        [DataMember(Name = "Shots", Order = 25)]
        public decimal? Shots { get; set; }

        /// <summary>
        /// Total shots on goal
        /// </summary>
        [Description("Total shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 26)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total yellow cards
        /// </summary>
        [Description("Total yellow cards")]
        [DataMember(Name = "YellowCards", Order = 27)]
        public decimal? YellowCards { get; set; }

        /// <summary>
        /// Total red cards
        /// </summary>
        [Description("Total red cards")]
        [DataMember(Name = "RedCards", Order = 28)]
        public decimal? RedCards { get; set; }

        /// <summary>
        /// Total yellow red cards
        /// </summary>
        [Description("Total yellow red cards")]
        [DataMember(Name = "YellowRedCards", Order = 29)]
        public decimal? YellowRedCards { get; set; }

        /// <summary>
        /// Total crosses
        /// </summary>
        [Description("Total crosses")]
        [DataMember(Name = "Crosses", Order = 30)]
        public decimal? Crosses { get; set; }

        /// <summary>
        /// Total tackles won
        /// </summary>
        [Description("Total tackles won")]
        [DataMember(Name = "TacklesWon", Order = 31)]
        public decimal? TacklesWon { get; set; }

        /// <summary>
        /// Total interceptions
        /// </summary>
        [Description("Total interceptions")]
        [DataMember(Name = "Interceptions", Order = 32)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total own goals
        /// </summary>
        [Description("Total own goals")]
        [DataMember(Name = "OwnGoals", Order = 33)]
        public decimal? OwnGoals { get; set; }

        /// <summary>
        /// Total foul
        /// </summary>
        [Description("Total foul")]
        [DataMember(Name = "Fouls", Order = 34)]
        public decimal? Fouls { get; set; }

        /// <summary>
        /// Total times fouled
        /// </summary>
        [Description("Total times fouled")]
        [DataMember(Name = "Fouled", Order = 35)]
        public decimal? Fouled { get; set; }

        /// <summary>
        /// Total offsides
        /// </summary>
        [Description("Total offsides")]
        [DataMember(Name = "Offsides", Order = 36)]
        public decimal? Offsides { get; set; }

        /// <summary>
        /// Total passes
        /// </summary>
        [Description("Total passes")]
        [DataMember(Name = "Passes", Order = 37)]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Total passes completed
        /// </summary>
        [Description("Total passes completed")]
        [DataMember(Name = "PassesCompleted", Order = 38)]
        public decimal? PassesCompleted { get; set; }

        /// <summary>
        /// Total last man tackle
        /// </summary>
        [Description("Total last man tackle")]
        [DataMember(Name = "LastManTackle", Order = 39)]
        public decimal? LastManTackle { get; set; }

        /// <summary>
        /// Total corners won
        /// </summary>
        [Description("Total corners won")]
        [DataMember(Name = "CornersWon", Order = 40)]
        public decimal? CornersWon { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 41)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total touches
        /// </summary>
        [Description("Total touches")]
        [DataMember(Name = "Touches", Order = 42)]
        public decimal? Touches { get; set; }

        /// <summary>
        /// Total defender clean sheets
        /// </summary>
        [Description("Total defender clean sheets")]
        [DataMember(Name = "DefenderCleanSheets", Order = 43)]
        public decimal? DefenderCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper saves
        /// </summary>
        [Description("Total goalkeeper saves")]
        [DataMember(Name = "GoalkeeperSaves", Order = 44)]
        public decimal? GoalkeeperSaves { get; set; }

        /// <summary>
        /// Total goalkeeper goals against
        /// </summary>
        [Description("Total goalkeeper goals against")]
        [DataMember(Name = "GoalkeeperGoalsAgainst", Order = 45)]
        public decimal? GoalkeeperGoalsAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper single goal against
        /// </summary>
        [Description("Total goalkeeper single goal against")]
        [DataMember(Name = "GoalkeeperSingleGoalAgainst", Order = 46)]
        public decimal? GoalkeeperSingleGoalAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper clean sheets
        /// </summary>
        [Description("Total goalkeeper clean sheets")]
        [DataMember(Name = "GoalkeeperCleanSheets", Order = 47)]
        public decimal? GoalkeeperCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper wins
        /// </summary>
        [Description("Total goalkeeper wins")]
        [DataMember(Name = "GoalkeeperWins", Order = 48)]
        public decimal? GoalkeeperWins { get; set; }

        /// <summary>
        /// Total penalty kick goals
        /// </summary>
        [Description("Total penalty kick goals")]
        [DataMember(Name = "PenaltyKickGoals", Order = 49)]
        public decimal? PenaltyKickGoals { get; set; }

        /// <summary>
        /// Total penalty kick misses
        /// </summary>
        [Description("Total penalty kick misses")]
        [DataMember(Name = "PenaltyKickMisses", Order = 50)]
        public decimal? PenaltyKickMisses { get; set; }

        /// <summary>
        /// Total penalty kick saves
        /// </summary>
        [Description("Total penalty kick saves")]
        [DataMember(Name = "PenaltyKickSaves", Order = 51)]
        public decimal? PenaltyKickSaves { get; set; }

        /// <summary>
        /// Total penalties won
        /// </summary>
        [Description("Total penalties won")]
        [DataMember(Name = "PenaltiesWon", Order = 52)]
        public decimal? PenaltiesWon { get; set; }

        /// <summary>
        /// Total penalties conceded 
        /// </summary>
        [Description("Total penalties conceded ")]
        [DataMember(Name = "PenaltiesConceded", Order = 53)]
        public decimal? PenaltiesConceded { get; set; }

        /// <summary>
        /// Team goals scored
        /// </summary>
        [Description("Team goals scored")]
        [DataMember(Name = "Score", Order = 54)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Opponents goals scored
        /// </summary>
        [Description("Opponents goals scored")]
        [DataMember(Name = "OpponentScore", Order = 55)]
        public decimal? OpponentScore { get; set; }

    }
}

