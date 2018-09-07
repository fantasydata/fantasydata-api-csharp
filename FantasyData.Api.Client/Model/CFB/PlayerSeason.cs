using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="PlayerSeason")]
    [Serializable]
    public partial class PlayerSeason
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The college football regular season for which these totals apply
        /// </summary>
        [Description("The college football regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// Player's position in the starting lineup (if started), otherwise the position he substituted for
        /// </summary>
        [Description("Player's position in the starting lineup (if started), otherwise the position he substituted for")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The category (Offense, Defense or Special Teams) of the players position (OFF, DEF, ST)
        /// </summary>
        [Description("The category (Offense, Defense or Special Teams) of the players position (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 9)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// A globally unique ID for this player's team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this player's team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 10)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The updated date and time of the stat.
        /// </summary>
        [Description("The updated date and time of the stat.")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date and time of the created stat.
        /// </summary>
        [Description("The date and time of the created stat.")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Total games
        /// </summary>
        [Description("Total games")]
        [DataMember(Name = "Games", Order = 13)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 14)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total passing attempts
        /// </summary>
        [Description("Total passing attempts")]
        [DataMember(Name = "PassingAttempts", Order = 15)]
        public decimal? PassingAttempts { get; set; }

        /// <summary>
        /// Total passing completions
        /// </summary>
        [Description("Total passing completions")]
        [DataMember(Name = "PassingCompletions", Order = 16)]
        public decimal? PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards
        /// </summary>
        [Description("Total passing yards")]
        [DataMember(Name = "PassingYards", Order = 17)]
        public decimal? PassingYards { get; set; }

        /// <summary>
        /// Total passing completion percentage
        /// </summary>
        [Description("Total passing completion percentage")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 18)]
        public decimal? PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Total passing yards per attempts
        /// </summary>
        [Description("Total passing yards per attempts")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 19)]
        public decimal? PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total passing yards per completion
        /// </summary>
        [Description("Total passing yards per completion")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 20)]
        public decimal? PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total passing touchdowns
        /// </summary>
        [Description("Total passing touchdowns")]
        [DataMember(Name = "PassingTouchdowns", Order = 21)]
        public decimal? PassingTouchdowns { get; set; }

        /// <summary>
        /// Total passing interceptions
        /// </summary>
        [Description("Total passing interceptions")]
        [DataMember(Name = "PassingInterceptions", Order = 22)]
        public decimal? PassingInterceptions { get; set; }

        /// <summary>
        /// Total passing rating
        /// </summary>
        [Description("Total passing rating")]
        [DataMember(Name = "PassingRating", Order = 23)]
        public decimal? PassingRating { get; set; }

        /// <summary>
        /// Total rushing attempts
        /// </summary>
        [Description("Total rushing attempts")]
        [DataMember(Name = "RushingAttempts", Order = 24)]
        public decimal? RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards
        /// </summary>
        [Description("Total rushing yards")]
        [DataMember(Name = "RushingYards", Order = 25)]
        public decimal? RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt
        /// </summary>
        [Description("Total rushing yards per attempt")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 26)]
        public decimal? RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns
        /// </summary>
        [Description("Total rushing touchdowns")]
        [DataMember(Name = "RushingTouchdowns", Order = 27)]
        public decimal? RushingTouchdowns { get; set; }

        /// <summary>
        /// Longest rushing attempt
        /// </summary>
        [Description("Longest rushing attempt")]
        [DataMember(Name = "RushingLong", Order = 28)]
        public decimal? RushingLong { get; set; }

        /// <summary>
        /// Total receptions
        /// </summary>
        [Description("Total receptions")]
        [DataMember(Name = "Receptions", Order = 29)]
        public decimal? Receptions { get; set; }

        /// <summary>
        /// Total receiving yards
        /// </summary>
        [Description("Total receiving yards")]
        [DataMember(Name = "ReceivingYards", Order = 30)]
        public decimal? ReceivingYards { get; set; }

        /// <summary>
        /// Total receiving yards per reception
        /// </summary>
        [Description("Total receiving yards per reception")]
        [DataMember(Name = "ReceivingYardsPerReception", Order = 31)]
        public decimal? ReceivingYardsPerReception { get; set; }

        /// <summary>
        /// Total receiving touchdowns
        /// </summary>
        [Description("Total receiving touchdowns")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 32)]
        public decimal? ReceivingTouchdowns { get; set; }

        /// <summary>
        /// Long receiving reception
        /// </summary>
        [Description("Long receiving reception")]
        [DataMember(Name = "ReceivingLong", Order = 33)]
        public decimal? ReceivingLong { get; set; }

        /// <summary>
        /// Total punt returns
        /// </summary>
        [Description("Total punt returns")]
        [DataMember(Name = "PuntReturns", Order = 34)]
        public decimal? PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards
        /// </summary>
        [Description("Total punt return yards")]
        [DataMember(Name = "PuntReturnYards", Order = 35)]
        public decimal? PuntReturnYards { get; set; }

        /// <summary>
        /// Total punt return yards per attempt
        /// </summary>
        [Description("Total punt return yards per attempt")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 36)]
        public decimal? PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total punt return touchdowns
        /// </summary>
        [Description("Total punt return touchdowns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 37)]
        public decimal? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 38)]
        public decimal? PuntReturnLong { get; set; }

        /// <summary>
        /// Total kick returns
        /// </summary>
        [Description("Total kick returns")]
        [DataMember(Name = "KickReturns", Order = 39)]
        public decimal? KickReturns { get; set; }

        /// <summary>
        /// Total kick return yards
        /// </summary>
        [Description("Total kick return yards")]
        [DataMember(Name = "KickReturnYards", Order = 40)]
        public decimal? KickReturnYards { get; set; }

        /// <summary>
        /// Total kick return yards per attempt
        /// </summary>
        [Description("Total kick return yards per attempt")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 41)]
        public decimal? KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total kick return touchdowns
        /// </summary>
        [Description("Total kick return touchdowns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 42)]
        public decimal? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return 
        /// </summary>
        [Description("Longest kick return ")]
        [DataMember(Name = "KickReturnLong", Order = 43)]
        public decimal? KickReturnLong { get; set; }

        /// <summary>
        /// Total punts
        /// </summary>
        [Description("Total punts")]
        [DataMember(Name = "Punts", Order = 44)]
        public decimal? Punts { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "PuntYards", Order = 45)]
        public decimal? PuntYards { get; set; }

        /// <summary>
        /// Total punt average
        /// </summary>
        [Description("Total punt average")]
        [DataMember(Name = "PuntAverage", Order = 46)]
        public decimal? PuntAverage { get; set; }

        /// <summary>
        /// Longest punt
        /// </summary>
        [Description("Longest punt")]
        [DataMember(Name = "PuntLong", Order = 47)]
        public decimal? PuntLong { get; set; }

        /// <summary>
        /// Total field goals attempted
        /// </summary>
        [Description("Total field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 48)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goals made
        /// </summary>
        [Description("Total field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 49)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalPercentage", Order = 50)]
        public decimal? FieldGoalPercentage { get; set; }

        /// <summary>
        /// Longest field goal made
        /// </summary>
        [Description("Longest field goal made")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 51)]
        public decimal? FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Total extra points attempted
        /// </summary>
        [Description("Total extra points attempted")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 52)]
        public decimal? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Total extra points made
        /// </summary>
        [Description("Total extra points made")]
        [DataMember(Name = "ExtraPointsMade", Order = 53)]
        public decimal? ExtraPointsMade { get; set; }

        /// <summary>
        /// Total interceptions
        /// </summary>
        [Description("Total interceptions")]
        [DataMember(Name = "Interceptions", Order = 54)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total interception return yards
        /// </summary>
        [Description("Total interception return yards")]
        [DataMember(Name = "InterceptionReturnYards", Order = 55)]
        public decimal? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total interception return touchdowns
        /// </summary>
        [Description("Total interception return touchdowns")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 56)]
        public decimal? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total Solo Tackles
        /// </summary>
        [Description("Total Solo Tackles")]
        [DataMember(Name = "SoloTackles", Order = 57)]
        public decimal? SoloTackles { get; set; }

        /// <summary>
        /// Total Assisted Tackles
        /// </summary>
        [Description("Total Assisted Tackles")]
        [DataMember(Name = "AssistedTackles", Order = 58)]
        public decimal? AssistedTackles { get; set; }

        /// <summary>
        /// Total Tackles for a loss of yardage
        /// </summary>
        [Description("Total Tackles for a loss of yardage")]
        [DataMember(Name = "TacklesForLoss", Order = 59)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total Quarterback Sacks
        /// </summary>
        [Description("Total Quarterback Sacks")]
        [DataMember(Name = "Sacks", Order = 60)]
        public decimal? Sacks { get; set; }

        /// <summary>
        /// Total Passes Defended
        /// </summary>
        [Description("Total Passes Defended")]
        [DataMember(Name = "PassesDefended", Order = 61)]
        public decimal? PassesDefended { get; set; }

        /// <summary>
        /// Total Fumble Recoveries
        /// </summary>
        [Description("Total Fumble Recoveries")]
        [DataMember(Name = "FumblesRecovered", Order = 62)]
        public decimal? FumblesRecovered { get; set; }

        /// <summary>
        /// Total Fumbles Recovered and returned for a touchdown
        /// </summary>
        [Description("Total Fumbles Recovered and returned for a touchdown")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 63)]
        public decimal? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total Quarterback Hurries
        /// </summary>
        [Description("Total Quarterback Hurries")]
        [DataMember(Name = "QuarterbackHurries", Order = 64)]
        public decimal? QuarterbackHurries { get; set; }

        /// <summary>
        /// Total Fumbles
        /// </summary>
        [Description("Total Fumbles")]
        [DataMember(Name = "Fumbles", Order = 65)]
        public decimal? Fumbles { get; set; }

        /// <summary>
        /// Total Fumbles Lost
        /// </summary>
        [Description("Total Fumbles Lost")]
        [DataMember(Name = "FumblesLost", Order = 66)]
        public decimal? FumblesLost { get; set; }

    }
}

