﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="TeamGame")]
    [Serializable]
    public partial class TeamGame
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int? Season { get; set; }

        /// <summary>
        /// The team's full name (ex. Minnesota Wild; New York Islanders)
        /// </summary>
        [Description("The team's full name (ex. Minnesota Wild; New York Islanders)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// Total number of wins by the team in the game. NOTE: this will be one for single game feeds
        /// </summary>
        [Description("Total number of wins by the team in the game. NOTE: this will be one for single game feeds")]
        [DataMember(Name = "Wins", Order = 7)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total losses for the team in the game. NOTE: this will be a maximum of one for single game feeds
        /// </summary>
        [Description("Total losses for the team in the game. NOTE: this will be a maximum of one for single game feeds")]
        [DataMember(Name = "Losses", Order = 8)]
        public int? Losses { get; set; }

        /// <summary>
        /// Total overtime losses by the team in the game
        /// </summary>
        [Description("Total overtime losses by the team in the game")]
        [DataMember(Name = "OvertimeLosses", Order = 9)]
        public int? OvertimeLosses { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 10)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 11)]
        public int? GameID { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentID", Order = 12)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 13)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 14)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 15)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 16)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 17)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 18)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 19)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 20)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 21)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 22)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total FanDuel daily fantasy points scored
        /// </summary>
        [Description("Total FanDuel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 23)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings daily fantasy points scored
        /// </summary>
        [Description("Total DraftKings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 24)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 25)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 26)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 27)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of goals scored
        /// </summary>
        [Description("Total number of goals scored")]
        [DataMember(Name = "Goals", Order = 28)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total number of assists
        /// </summary>
        [Description("Total number of assists")]
        [DataMember(Name = "Assists", Order = 29)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total number of shots on goal
        /// </summary>
        [Description("Total number of shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 30)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total number of power play goals
        /// </summary>
        [Description("Total number of power play goals")]
        [DataMember(Name = "PowerPlayGoals", Order = 31)]
        public decimal? PowerPlayGoals { get; set; }

        /// <summary>
        /// Total number of short handed goals
        /// </summary>
        [Description("Total number of short handed goals")]
        [DataMember(Name = "ShortHandedGoals", Order = 32)]
        public decimal? ShortHandedGoals { get; set; }

        /// <summary>
        /// Total number of empty net goals
        /// </summary>
        [Description("Total number of empty net goals")]
        [DataMember(Name = "EmptyNetGoals", Order = 33)]
        public decimal? EmptyNetGoals { get; set; }

        /// <summary>
        /// Total number of power play assists
        /// </summary>
        [Description("Total number of power play assists")]
        [DataMember(Name = "PowerPlayAssists", Order = 34)]
        public decimal? PowerPlayAssists { get; set; }

        /// <summary>
        /// Total number of short handed assists
        /// </summary>
        [Description("Total number of short handed assists")]
        [DataMember(Name = "ShortHandedAssists", Order = 35)]
        public decimal? ShortHandedAssists { get; set; }

        /// <summary>
        /// Total number of hat tricks
        /// </summary>
        [Description("Total number of hat tricks")]
        [DataMember(Name = "HatTricks", Order = 36)]
        public decimal? HatTricks { get; set; }

        /// <summary>
        /// Total number of shootout goals
        /// </summary>
        [Description("Total number of shootout goals")]
        [DataMember(Name = "ShootoutGoals", Order = 37)]
        public decimal? ShootoutGoals { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 38)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total pentalty minutes
        /// </summary>
        [Description("Total pentalty minutes")]
        [DataMember(Name = "PenaltyMinutes", Order = 39)]
        public decimal? PenaltyMinutes { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "Blocks", Order = 40)]
        public decimal? Blocks { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 41)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total takeaways
        /// </summary>
        [Description("Total takeaways")]
        [DataMember(Name = "Takeaways", Order = 42)]
        public decimal? Takeaways { get; set; }

        /// <summary>
        /// Total giveaways
        /// </summary>
        [Description("Total giveaways")]
        [DataMember(Name = "Giveaways", Order = 43)]
        public decimal? Giveaways { get; set; }

        /// <summary>
        /// Total faceoffs won
        /// </summary>
        [Description("Total faceoffs won")]
        [DataMember(Name = "FaceoffsWon", Order = 44)]
        public decimal? FaceoffsWon { get; set; }

        /// <summary>
        /// Total faceoffs lost
        /// </summary>
        [Description("Total faceoffs lost")]
        [DataMember(Name = "FaceoffsLost", Order = 45)]
        public decimal? FaceoffsLost { get; set; }

        /// <summary>
        /// Total shifts
        /// </summary>
        [Description("Total shifts")]
        [DataMember(Name = "Shifts", Order = 46)]
        public decimal? Shifts { get; set; }

        /// <summary>
        /// Total goaltending minutes
        /// </summary>
        [Description("Total goaltending minutes")]
        [DataMember(Name = "GoaltendingMinutes", Order = 47)]
        public int? GoaltendingMinutes { get; set; }

        /// <summary>
        /// Total goaltending seconds
        /// </summary>
        [Description("Total goaltending seconds")]
        [DataMember(Name = "GoaltendingSeconds", Order = 48)]
        public int? GoaltendingSeconds { get; set; }

        /// <summary>
        /// Total goaltending shots against
        /// </summary>
        [Description("Total goaltending shots against")]
        [DataMember(Name = "GoaltendingShotsAgainst", Order = 49)]
        public decimal? GoaltendingShotsAgainst { get; set; }

        /// <summary>
        /// Total goaltending goals against
        /// </summary>
        [Description("Total goaltending goals against")]
        [DataMember(Name = "GoaltendingGoalsAgainst", Order = 50)]
        public decimal? GoaltendingGoalsAgainst { get; set; }

        /// <summary>
        /// Total goaltending saves
        /// </summary>
        [Description("Total goaltending saves")]
        [DataMember(Name = "GoaltendingSaves", Order = 51)]
        public decimal? GoaltendingSaves { get; set; }

        /// <summary>
        /// Total goaltending wins
        /// </summary>
        [Description("Total goaltending wins")]
        [DataMember(Name = "GoaltendingWins", Order = 52)]
        public decimal? GoaltendingWins { get; set; }

        /// <summary>
        /// Total goaltendings losses
        /// </summary>
        [Description("Total goaltendings losses")]
        [DataMember(Name = "GoaltendingLosses", Order = 53)]
        public decimal? GoaltendingLosses { get; set; }

        /// <summary>
        /// Total goaltendings shutouts
        /// </summary>
        [Description("Total goaltendings shutouts")]
        [DataMember(Name = "GoaltendingShutouts", Order = 54)]
        public decimal? GoaltendingShutouts { get; set; }

        /// <summary>
        /// Total games started
        /// </summary>
        [Description("Total games started")]
        [DataMember(Name = "Started", Order = 55)]
        public int? Started { get; set; }

        /// <summary>
        /// Total bench pentalty minutes
        /// </summary>
        [Description("Total bench pentalty minutes")]
        [DataMember(Name = "BenchPenaltyMinutes", Order = 56)]
        public decimal? BenchPenaltyMinutes { get; set; }

        /// <summary>
        /// Total goaltending overtime losses
        /// </summary>
        [Description("Total goaltending overtime losses")]
        [DataMember(Name = "GoaltendingOvertimeLosses", Order = 57)]
        public decimal? GoaltendingOvertimeLosses { get; set; }

        /// <summary>
        /// Total FantasyDraft daily fantasy points scored
        /// </summary>
        [Description("Total FantasyDraft daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 58)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

    }
}

