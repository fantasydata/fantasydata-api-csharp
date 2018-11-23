using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="PlayerGame")]
    [Serializable]
    public partial class PlayerGame
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
        /// The soccer season of the game
        /// </summary>
        [Description("The soccer season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The unique ID of the round
        /// </summary>
        [Description("The unique ID of the round")]
        [DataMember(Name = "RoundId", Order = 4)]
        public int? RoundId { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
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
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 12)]
        public int? Jersey { get; set; }

        /// <summary>
        /// Number of games the player started
        /// </summary>
        [Description("Number of games the player started")]
        [DataMember(Name = "Started", Order = 13)]
        public int? Started { get; set; }

        /// <summary>
        /// Whether the player is a captain (true/false
        /// </summary>
        [Description("Whether the player is a captain (true/false")]
        [DataMember(Name = "Captain", Order = 14)]
        public bool? Captain { get; set; }

        /// <summary>
        /// Whether the player is suspended (true/false)
        /// </summary>
        [Description("Whether the player is suspended (true/false)")]
        [DataMember(Name = "Suspension", Order = 15)]
        public bool? Suspension { get; set; }

        /// <summary>
        /// The reason for the suspension
        /// </summary>
        [Description("The reason for the suspension")]
        [DataMember(Name = "SuspensionReason", Order = 16)]
        public string SuspensionReason { get; set; }

        /// <summary>
        /// The player's salary for FanDuel daily fantasy contests.
        /// </summary>
        [Description("The player's salary for FanDuel daily fantasy contests.")]
        [DataMember(Name = "FanDuelSalary", Order = 17)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The player's salary for DraftKings daily fantasy contests.
        /// </summary>
        [Description("The player's salary for DraftKings daily fantasy contests.")]
        [DataMember(Name = "DraftKingsSalary", Order = 18)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests.")]
        [DataMember(Name = "YahooSalary", Order = 19)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// The player's salary for Mondogoal daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Mondogoal daily fantasy contests.")]
        [DataMember(Name = "MondogoalSalary", Order = 20)]
        public int? MondogoalSalary { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FanDuelPosition", Order = 21)]
        public string FanDuelPosition { get; set; }

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
        /// The player's eligible position in Mondogoal's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Mondogoal's daily fantasy sports platform.")]
        [DataMember(Name = "MondogoalPosition", Order = 24)]
        public string MondogoalPosition { get; set; }

        /// <summary>
        /// Indicates the player's injury status. Possible values include: Questionable, Out
        /// </summary>
        [Description("Indicates the player's injury status. Possible values include: Questionable, Out")]
        [DataMember(Name = "InjuryStatus", Order = 25)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 26)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Not yet supported, will be null.
        /// </summary>
        [Description("Not yet supported, will be null.")]
        [DataMember(Name = "InjuryNotes", Order = 27)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered.
        /// </summary>
        [Description("The day that the injury started or first discovered.")]
        [DataMember(Name = "InjuryStartDate", Order = 28)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamId", Order = 29)]
        public int? GlobalTeamId { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 30)]
        public int? GameId { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentId", Order = 31)]
        public int? OpponentId { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 32)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 33)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (UTC)
        /// </summary>
        [Description("The date and time of the game (UTC)")]
        [DataMember(Name = "DateTime", Order = 34)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 35)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 36)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 37)]
        public int? GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentId", Order = 38)]
        public int? GlobalOpponentId { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 39)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 40)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 41)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 42)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total Fan Duel daily fantasy points scored
        /// </summary>
        [Description("Total Fan Duel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 43)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Draft Kings daily fantasy points scored
        /// </summary>
        [Description("Total Draft Kings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 44)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 45)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total Mondogoal fantasy points scored
        /// </summary>
        [Description("Total Mondogoal fantasy points scored")]
        [DataMember(Name = "FantasyPointsMondogoal", Order = 46)]
        public decimal? FantasyPointsMondogoal { get; set; }

        /// <summary>
        /// Total minutes played
        /// </summary>
        [Description("Total minutes played")]
        [DataMember(Name = "Minutes", Order = 47)]
        public decimal? Minutes { get; set; }

        /// <summary>
        /// Total goals scored
        /// </summary>
        [Description("Total goals scored")]
        [DataMember(Name = "Goals", Order = 48)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists scored
        /// </summary>
        [Description("Total assists scored")]
        [DataMember(Name = "Assists", Order = 49)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots attempted
        /// </summary>
        [Description("Total shots attempted")]
        [DataMember(Name = "Shots", Order = 50)]
        public decimal? Shots { get; set; }

        /// <summary>
        /// Total shots on goal attempted
        /// </summary>
        [Description("Total shots on goal attempted")]
        [DataMember(Name = "ShotsOnGoal", Order = 51)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total yellow cards against
        /// </summary>
        [Description("Total yellow cards against")]
        [DataMember(Name = "YellowCards", Order = 52)]
        public decimal? YellowCards { get; set; }

        /// <summary>
        /// Total red cards against
        /// </summary>
        [Description("Total red cards against")]
        [DataMember(Name = "RedCards", Order = 53)]
        public decimal? RedCards { get; set; }

        /// <summary>
        /// Total double yellow cards against (which result in a red card)
        /// </summary>
        [Description("Total double yellow cards against (which result in a red card)")]
        [DataMember(Name = "YellowRedCards", Order = 54)]
        public decimal? YellowRedCards { get; set; }

        /// <summary>
        /// Total passes from a wide area of the field towards the center of the field near the opponent's goal
        /// </summary>
        [Description("Total passes from a wide area of the field towards the center of the field near the opponent's goal")]
        [DataMember(Name = "Crosses", Order = 55)]
        public decimal? Crosses { get; set; }

        /// <summary>
        /// Total tackles won
        /// </summary>
        [Description("Total tackles won")]
        [DataMember(Name = "TacklesWon", Order = 56)]
        public decimal? TacklesWon { get; set; }

        /// <summary>
        /// Total interceptions made
        /// </summary>
        [Description("Total interceptions made")]
        [DataMember(Name = "Interceptions", Order = 57)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total goals scored against own team (accidentally)
        /// </summary>
        [Description("Total goals scored against own team (accidentally)")]
        [DataMember(Name = "OwnGoals", Order = 58)]
        public decimal? OwnGoals { get; set; }

        /// <summary>
        /// Total fouls made
        /// </summary>
        [Description("Total fouls made")]
        [DataMember(Name = "Fouls", Order = 59)]
        public decimal? Fouls { get; set; }

        /// <summary>
        /// Total times fouled
        /// </summary>
        [Description("Total times fouled")]
        [DataMember(Name = "Fouled", Order = 60)]
        public decimal? Fouled { get; set; }

        /// <summary>
        /// Total offsides against
        /// </summary>
        [Description("Total offsides against")]
        [DataMember(Name = "Offsides", Order = 61)]
        public decimal? Offsides { get; set; }

        /// <summary>
        /// Total passes attempted
        /// </summary>
        [Description("Total passes attempted")]
        [DataMember(Name = "Passes", Order = 62)]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Total passes completed successfully to teammate
        /// </summary>
        [Description("Total passes completed successfully to teammate")]
        [DataMember(Name = "PassesCompleted", Order = 63)]
        public decimal? PassesCompleted { get; set; }

        /// <summary>
        /// Total tackles made when there is no one else available to stop the opponent from scoring (this can be the goalkeeper)
        /// </summary>
        [Description("Total tackles made when there is no one else available to stop the opponent from scoring (this can be the goalkeeper)")]
        [DataMember(Name = "LastManTackle", Order = 64)]
        public decimal? LastManTackle { get; set; }

        /// <summary>
        /// Total corner kicks awarded
        /// </summary>
        [Description("Total corner kicks awarded")]
        [DataMember(Name = "CornersWon", Order = 65)]
        public decimal? CornersWon { get; set; }

        /// <summary>
        /// Total shots blocked
        /// </summary>
        [Description("Total shots blocked")]
        [DataMember(Name = "BlockedShots", Order = 66)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total times this player touched the ball
        /// </summary>
        [Description("Total times this player touched the ball")]
        [DataMember(Name = "Touches", Order = 67)]
        public decimal? Touches { get; set; }

        /// <summary>
        /// Total defender clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)
        /// </summary>
        [Description("Total defender clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)")]
        [DataMember(Name = "DefenderCleanSheets", Order = 68)]
        public decimal? DefenderCleanSheets { get; set; }

        /// <summary>
        /// Total saves made by goalkeeper
        /// </summary>
        [Description("Total saves made by goalkeeper")]
        [DataMember(Name = "GoalkeeperSaves", Order = 69)]
        public decimal? GoalkeeperSaves { get; set; }

        /// <summary>
        /// Total goals allowed by goalkeeper
        /// </summary>
        [Description("Total goals allowed by goalkeeper")]
        [DataMember(Name = "GoalkeeperGoalsAgainst", Order = 70)]
        public decimal? GoalkeeperGoalsAgainst { get; set; }

        /// <summary>
        /// Total games where this goalkeeper allowed exactly one goal
        /// </summary>
        [Description("Total games where this goalkeeper allowed exactly one goal")]
        [DataMember(Name = "GoalkeeperSingleGoalAgainst", Order = 71)]
        public decimal? GoalkeeperSingleGoalAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)
        /// </summary>
        [Description("Total goalkeeper clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)")]
        [DataMember(Name = "GoalkeeperCleanSheets", Order = 72)]
        public decimal? GoalkeeperCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper wins (awarded when zero goals were allowed to the opponent and the player played at least 45 minutes)
        /// </summary>
        [Description("Total goalkeeper wins (awarded when zero goals were allowed to the opponent and the player played at least 45 minutes)")]
        [DataMember(Name = "GoalkeeperWins", Order = 73)]
        public decimal? GoalkeeperWins { get; set; }

        /// <summary>
        /// Total penalty kick goals
        /// </summary>
        [Description("Total penalty kick goals")]
        [DataMember(Name = "PenaltyKickGoals", Order = 74)]
        public decimal? PenaltyKickGoals { get; set; }

        /// <summary>
        /// Total penalty kick misses
        /// </summary>
        [Description("Total penalty kick misses")]
        [DataMember(Name = "PenaltyKickMisses", Order = 75)]
        public decimal? PenaltyKickMisses { get; set; }

        /// <summary>
        /// Total penalty kick saves
        /// </summary>
        [Description("Total penalty kick saves")]
        [DataMember(Name = "PenaltyKickSaves", Order = 76)]
        public decimal? PenaltyKickSaves { get; set; }

        /// <summary>
        /// Total penalties won
        /// </summary>
        [Description("Total penalties won")]
        [DataMember(Name = "PenaltiesWon", Order = 77)]
        public decimal? PenaltiesWon { get; set; }

        /// <summary>
        /// Total penalties conceded 
        /// </summary>
        [Description("Total penalties conceded ")]
        [DataMember(Name = "PenaltiesConceded", Order = 78)]
        public decimal? PenaltiesConceded { get; set; }

        /// <summary>
        /// Goals scored by entire team
        /// </summary>
        [Description("Goals scored by entire team")]
        [DataMember(Name = "Score", Order = 79)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Goals allowed to opponent
        /// </summary>
        [Description("Goals allowed to opponent")]
        [DataMember(Name = "OpponentScore", Order = 80)]
        public decimal? OpponentScore { get; set; }

    }
}

