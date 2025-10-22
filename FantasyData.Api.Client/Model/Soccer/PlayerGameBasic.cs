using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="PlayerGameBasic")]
    [Serializable]
    public partial class PlayerGameBasic
    {
        /// <summary>
        /// The timestamp of when the record was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (in UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (in UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 2)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// Total number of games played by the player in the game
        /// </summary>
        [Description("Total number of games played by the player in the game")]
        [DataMember(Name = "Games", Order = 3)]
        public int? Games { get; set; }

        /// <summary>
        /// Total minutes played by the player in the game
        /// </summary>
        [Description("Total minutes played by the player in the game")]
        [DataMember(Name = "Minutes", Order = 4)]
        public decimal? Minutes { get; set; }

        /// <summary>
        /// Total goals scored by the player in the game
        /// </summary>
        [Description("Total goals scored by the player in the game")]
        [DataMember(Name = "Goals", Order = 5)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists scored by the player in the game
        /// </summary>
        [Description("Total assists scored by the player in the game")]
        [DataMember(Name = "Assists", Order = 6)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots attempted by the player in the game
        /// </summary>
        [Description("Total shots attempted by the player in the game")]
        [DataMember(Name = "Shots", Order = 7)]
        public decimal? Shots { get; set; }

        /// <summary>
        /// Total shots on goal attempted by the player in the game
        /// </summary>
        [Description("Total shots on goal attempted by the player in the game")]
        [DataMember(Name = "ShotsOnGoal", Order = 8)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total yellow cards against the player in the game
        /// </summary>
        [Description("Total yellow cards against the player in the game")]
        [DataMember(Name = "YellowCards", Order = 9)]
        public decimal? YellowCards { get; set; }

        /// <summary>
        /// Total red cards against by the player in the game
        /// </summary>
        [Description("Total red cards against by the player in the game")]
        [DataMember(Name = "RedCards", Order = 10)]
        public decimal? RedCards { get; set; }

        /// <summary>
        /// Total double yellow cards against the player in the game. Note: A double yellow card results in a red card
        /// </summary>
        [Description("Total double yellow cards against the player in the game. Note: A double yellow card results in a red card")]
        [DataMember(Name = "YellowRedCards", Order = 11)]
        public decimal? YellowRedCards { get; set; }

        /// <summary>
        /// Total crosses by the player in the game. Note: a cross means a pass from a wide area of the field towards the center of the field near the opponent's goal.
        /// </summary>
        [Description("Total crosses by the player in the game. Note: a cross means a pass from a wide area of the field towards the center of the field near the opponent's goal.")]
        [DataMember(Name = "Crosses", Order = 12)]
        public decimal? Crosses { get; set; }

        /// <summary>
        /// Total tackles won by the player in the game
        /// </summary>
        [Description("Total tackles won by the player in the game")]
        [DataMember(Name = "TacklesWon", Order = 13)]
        public decimal? TacklesWon { get; set; }

        /// <summary>
        /// Total interceptions made by the player in the game
        /// </summary>
        [Description("Total interceptions made by the player in the game")]
        [DataMember(Name = "Interceptions", Order = 14)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total goals scored against own team (accidentally)
        /// </summary>
        [Description("Total goals scored against own team (accidentally)")]
        [DataMember(Name = "OwnGoals", Order = 15)]
        public decimal? OwnGoals { get; set; }

        /// <summary>
        /// Total fouls made by the player in the game
        /// </summary>
        [Description("Total fouls made by the player in the game")]
        [DataMember(Name = "Fouls", Order = 16)]
        public decimal? Fouls { get; set; }

        /// <summary>
        /// Total times the player was fouled in the game
        /// </summary>
        [Description("Total times the player was fouled in the game")]
        [DataMember(Name = "Fouled", Order = 17)]
        public decimal? Fouled { get; set; }

        /// <summary>
        /// Total offsides against by the player in the game
        /// </summary>
        [Description("Total offsides against by the player in the game")]
        [DataMember(Name = "Offsides", Order = 18)]
        public decimal? Offsides { get; set; }

        /// <summary>
        /// Total passes attempted by the player in the game
        /// </summary>
        [Description("Total passes attempted by the player in the game")]
        [DataMember(Name = "Passes", Order = 19)]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Total passes completed by the player in the game
        /// </summary>
        [Description("Total passes completed by the player in the game")]
        [DataMember(Name = "PassesCompleted", Order = 20)]
        public decimal? PassesCompleted { get; set; }

        /// <summary>
        /// Total tackles made by the player when there is no one else available to stop the opponent from scoring in the game
        /// </summary>
        [Description("Total tackles made by the player when there is no one else available to stop the opponent from scoring in the game")]
        [DataMember(Name = "LastManTackle", Order = 21)]
        public decimal? LastManTackle { get; set; }

        /// <summary>
        /// Total corner kicks awarded to the player in the game
        /// </summary>
        [Description("Total corner kicks awarded to the player in the game")]
        [DataMember(Name = "CornersWon", Order = 22)]
        public decimal? CornersWon { get; set; }

        /// <summary>
        /// Total shots blocked by the player in the game
        /// </summary>
        [Description("Total shots blocked by the player in the game")]
        [DataMember(Name = "BlockedShots", Order = 23)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total times the player touched the ball in the game
        /// </summary>
        [Description("Total times the player touched the ball in the game")]
        [DataMember(Name = "Touches", Order = 24)]
        public decimal? Touches { get; set; }

        /// <summary>
        /// Total defender clean sheets by the player in the game. Note: clean sheets are awarded when zero goals were allowed to the opponent and the player played at least 60 minutes).
        /// </summary>
        [Description("Total defender clean sheets by the player in the game. Note: clean sheets are awarded when zero goals were allowed to the opponent and the player played at least 60 minutes).")]
        [DataMember(Name = "DefenderCleanSheets", Order = 25)]
        public decimal? DefenderCleanSheets { get; set; }

        /// <summary>
        /// Total saves made by goalkeeper in the game
        /// </summary>
        [Description("Total saves made by goalkeeper in the game")]
        [DataMember(Name = "GoalkeeperSaves", Order = 26)]
        public decimal? GoalkeeperSaves { get; set; }

        /// <summary>
        /// Total goals allowed by goalkeeper in the game
        /// </summary>
        [Description("Total goals allowed by goalkeeper in the game")]
        [DataMember(Name = "GoalkeeperGoalsAgainst", Order = 27)]
        public decimal? GoalkeeperGoalsAgainst { get; set; }

        /// <summary>
        /// Total games where the goalkeeper allowed exactly one goal in the game
        /// </summary>
        [Description("Total games where the goalkeeper allowed exactly one goal in the game")]
        [DataMember(Name = "GoalkeeperSingleGoalAgainst", Order = 28)]
        public decimal? GoalkeeperSingleGoalAgainst { get; set; }

        /// <summary>
        /// Total number of clean sheets by the goalkeeper in the game. Note: Awarded when zero goals were allowed to the opponent and the player played at least 60 minutes
        /// </summary>
        [Description("Total number of clean sheets by the goalkeeper in the game. Note: Awarded when zero goals were allowed to the opponent and the player played at least 60 minutes")]
        [DataMember(Name = "GoalkeeperCleanSheets", Order = 29)]
        public decimal? GoalkeeperCleanSheets { get; set; }

        /// <summary>
        /// Total wins by the goalkeeper in the game
        /// </summary>
        [Description("Total wins by the goalkeeper in the game")]
        [DataMember(Name = "GoalkeeperWins", Order = 30)]
        public decimal? GoalkeeperWins { get; set; }

        /// <summary>
        /// Total penalty kick goals scored by the player in the game
        /// </summary>
        [Description("Total penalty kick goals scored by the player in the game")]
        [DataMember(Name = "PenaltyKickGoals", Order = 31)]
        public decimal? PenaltyKickGoals { get; set; }

        /// <summary>
        /// Total penalty kicks missed by the player in the game
        /// </summary>
        [Description("Total penalty kicks missed by the player in the game")]
        [DataMember(Name = "PenaltyKickMisses", Order = 32)]
        public decimal? PenaltyKickMisses { get; set; }

        /// <summary>
        /// Total penalty kicks saved by the player in the game
        /// </summary>
        [Description("Total penalty kicks saved by the player in the game")]
        [DataMember(Name = "PenaltyKickSaves", Order = 33)]
        public decimal? PenaltyKickSaves { get; set; }

        /// <summary>
        /// Total penalties won by the player in the game
        /// </summary>
        [Description("Total penalties won by the player in the game")]
        [DataMember(Name = "PenaltiesWon", Order = 34)]
        public decimal? PenaltiesWon { get; set; }

        /// <summary>
        /// Total penalties conceded by the player in the game
        /// </summary>
        [Description("Total penalties conceded by the player in the game")]
        [DataMember(Name = "PenaltiesConceded", Order = 35)]
        public decimal? PenaltiesConceded { get; set; }

        /// <summary>
        /// Total goals scored by the player's team in the game
        /// </summary>
        [Description("Total goals scored by the player's team in the game")]
        [DataMember(Name = "Score", Order = 36)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Total goals scored against own team by the player in the game
        /// </summary>
        [Description("Total goals scored against own team by the player in the game")]
        [DataMember(Name = "OpponentScore", Order = 37)]
        public decimal? OpponentScore { get; set; }

        /// <summary>
        /// Total tackles by the player in the game
        /// </summary>
        [Description("Total tackles by the player in the game")]
        [DataMember(Name = "Tackles", Order = 38)]
        public decimal? Tackles { get; set; }

        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameId", Order = 39)]
        public int? GameId { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentId", Order = 40)]
        public int? OpponentId { get; set; }

        /// <summary>
        /// The name of the opponent team
        /// </summary>
        [Description("The name of the opponent team")]
        [DataMember(Name = "Opponent", Order = 41)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 42)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in UTC)
        /// </summary>
        [Description("The date and time of the game (in UTC)")]
        [DataMember(Name = "DateTime", Order = 43)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is the home team or away team
        /// </summary>
        [Description("Whether the team is the home team or away team")]
        [DataMember(Name = "HomeOrAway", Order = 44)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true) or not (false)
        /// </summary>
        [Description("Whether the game is over (true) or not (false)")]
        [DataMember(Name = "IsGameOver", Order = 45)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 46)]
        public int? GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentId", Order = 47)]
        public int? GlobalOpponentId { get; set; }

        /// <summary>
        /// The unique ID of the stat associated with this player
        /// </summary>
        [Description("The unique ID of the stat associated with this player")]
        [DataMember(Name = "StatId", Order = 48)]
        public int StatId { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 49)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The soccer regular season for which these totals apply
        /// </summary>
        [Description("The soccer regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 50)]
        public int Season { get; set; }

        /// <summary>
        /// The unique ID of the round that this player is associated with
        /// </summary>
        [Description("The unique ID of the round that this player is associated with")]
        [DataMember(Name = "RoundId", Order = 51)]
        public int? RoundId { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 52)]
        public int? TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career")]
        [DataMember(Name = "PlayerId", Order = 53)]
        public int? PlayerId { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 54)]
        public string Name { get; set; }

        /// <summary>
        /// The short name of the player
        /// </summary>
        [Description("The short name of the player")]
        [DataMember(Name = "ShortName", Order = 55)]
        public string ShortName { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the player's team
        /// </summary>
        [Description("The abbreviation [Key] of the player's team")]
        [DataMember(Name = "Team", Order = 56)]
        public string Team { get; set; }

        /// <summary>
        /// The player's position category
        /// </summary>
        [Description("The player's position category")]
        [DataMember(Name = "PositionCategory", Order = 57)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The position of the player. Possible values include: A (Attacker); M (Midfielder); D (Defender); GK (Goalkeeper)
        /// </summary>
        [Description("The position of the player. Possible values include: A (Attacker); M (Midfielder); D (Defender); GK (Goalkeeper)")]
        [DataMember(Name = "Position", Order = 58)]
        public string Position { get; set; }

        /// <summary>
        /// The player's jersey number
        /// </summary>
        [Description("The player's jersey number")]
        [DataMember(Name = "Jersey", Order = 59)]
        public int Jersey { get; set; }

        /// <summary>
        /// The total number of games the player started
        /// </summary>
        [Description("The total number of games the player started")]
        [DataMember(Name = "Started", Order = 60)]
        public int? Started { get; set; }

        /// <summary>
        /// Whether the player is a captain (true/false)
        /// </summary>
        [Description("Whether the player is a captain (true/false)")]
        [DataMember(Name = "Captain", Order = 61)]
        public bool? Captain { get; set; }

        /// <summary>
        /// Whether the player is suspended or not (true/false)
        /// </summary>
        [Description("Whether the player is suspended or not (true/false)")]
        [DataMember(Name = "Suspension", Order = 62)]
        public bool? Suspension { get; set; }

        /// <summary>
        /// The reason given for the player's suspension
        /// </summary>
        [Description("The reason given for the player's suspension")]
        [DataMember(Name = "SuspensionReason", Order = 63)]
        public string SuspensionReason { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamId", Order = 64)]
        public int? GlobalTeamId { get; set; }

    }
}

