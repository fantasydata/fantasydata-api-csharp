using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="TeamSeason")]
    [Serializable]
    public partial class TeamSeason
    {
        /// <summary>
        /// The unique ID of the stats associated with the team in this season
        /// </summary>
        [Description("The unique ID of the stats associated with the team in this season")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The college football season of the game
        /// </summary>
        [Description("The college football season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int? Season { get; set; }

        /// <summary>
        /// The team's full name
        /// </summary>
        [Description("The team's full name")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// Total number of wins by the team in the season
        /// </summary>
        [Description("Total number of wins by the team in the season")]
        [DataMember(Name = "Wins", Order = 7)]
        public int? Wins { get; set; }

        /// <summary>
        /// The total number of losses by the team in the season
        /// </summary>
        [Description("The total number of losses by the team in the season")]
        [DataMember(Name = "Losses", Order = 8)]
        public int? Losses { get; set; }

        /// <summary>
        /// Total points scored by the team in the season
        /// </summary>
        [Description("Total points scored by the team in the season")]
        [DataMember(Name = "PointsFor", Order = 9)]
        public int? PointsFor { get; set; }

        /// <summary>
        /// Total points scored against the team in the season
        /// </summary>
        [Description("Total points scored against the team in the season")]
        [DataMember(Name = "PointsAgainst", Order = 10)]
        public int? PointsAgainst { get; set; }

        /// <summary>
        /// The total number of conference wins by the team
        /// </summary>
        [Description("The total number of conference wins by the team")]
        [DataMember(Name = "ConferenceWins", Order = 11)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// The total number of conference losses by the team
        /// </summary>
        [Description("The total number of conference losses by the team")]
        [DataMember(Name = "ConferenceLosses", Order = 12)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// Total conference points scored by the team
        /// </summary>
        [Description("Total conference points scored by the team")]
        [DataMember(Name = "ConferencePointsFor", Order = 13)]
        public int? ConferencePointsFor { get; set; }

        /// <summary>
        /// Total conference points against the team
        /// </summary>
        [Description("Total conference points against the team")]
        [DataMember(Name = "ConferencePointsAgainst", Order = 14)]
        public int? ConferencePointsAgainst { get; set; }

        /// <summary>
        /// Total home wins by the team in the season
        /// </summary>
        [Description("Total home wins by the team in the season")]
        [DataMember(Name = "HomeWins", Order = 15)]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Total home losses by the team in the season
        /// </summary>
        [Description("Total home losses by the team in the season")]
        [DataMember(Name = "HomeLosses", Order = 16)]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Total road wins by the team in the season
        /// </summary>
        [Description("Total road wins by the team in the season")]
        [DataMember(Name = "RoadWins", Order = 17)]
        public int? RoadWins { get; set; }

        /// <summary>
        /// Total road losses by the team in the season
        /// </summary>
        [Description("Total road losses by the team in the season")]
        [DataMember(Name = "RoadLosses", Order = 18)]
        public int? RoadLosses { get; set; }

        /// <summary>
        /// The current winning or losing streak of the team in the season. A positive number indicates a winning streak, and a negative number indicates a losing streak.
        /// </summary>
        [Description("The current winning or losing streak of the team in the season. A positive number indicates a winning streak, and a negative number indicates a losing streak.")]
        [DataMember(Name = "Streak", Order = 19)]
        public int? Streak { get; set; }

        /// <summary>
        /// Total points scored by the team in the season
        /// </summary>
        [Description("Total points scored by the team in the season")]
        [DataMember(Name = "Score", Order = 20)]
        public int? Score { get; set; }

        /// <summary>
        /// Total points scored by the opponent team
        /// </summary>
        [Description("Total points scored by the opponent team")]
        [DataMember(Name = "OpponentScore", Order = 21)]
        public int? OpponentScore { get; set; }

        /// <summary>
        /// Total first downs converted by the team in the season
        /// </summary>
        [Description("Total first downs converted by the team in the season")]
        [DataMember(Name = "FirstDowns", Order = 22)]
        public int? FirstDowns { get; set; }

        /// <summary>
        /// Total third down conversions by the team in the season
        /// </summary>
        [Description("Total third down conversions by the team in the season")]
        [DataMember(Name = "ThirdDownConversions", Order = 23)]
        public int? ThirdDownConversions { get; set; }

        /// <summary>
        /// Total third down attempts by the team in the season
        /// </summary>
        [Description("Total third down attempts by the team in the season")]
        [DataMember(Name = "ThirdDownAttempts", Order = 24)]
        public int? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Total fourth down conversions by the team in the season
        /// </summary>
        [Description("Total fourth down conversions by the team in the season")]
        [DataMember(Name = "FourthDownConversions", Order = 25)]
        public int? FourthDownConversions { get; set; }

        /// <summary>
        /// Total fourth down attempts by the team in the season
        /// </summary>
        [Description("Total fourth down attempts by the team in the season")]
        [DataMember(Name = "FourthDownAttempts", Order = 26)]
        public int? FourthDownAttempts { get; set; }

        /// <summary>
        /// Total penalties committed by the team in the season
        /// </summary>
        [Description("Total penalties committed by the team in the season")]
        [DataMember(Name = "Penalties", Order = 27)]
        public int? Penalties { get; set; }

        /// <summary>
        /// Total penalties yards enforced against the team in the season
        /// </summary>
        [Description("Total penalties yards enforced against the team in the season")]
        [DataMember(Name = "PenaltyYards", Order = 28)]
        public int? PenaltyYards { get; set; }

        /// <summary>
        /// Total number of minutes the team possessed the ball for in the season
        /// </summary>
        [Description("Total number of minutes the team possessed the ball for in the season")]
        [DataMember(Name = "TimeOfPossessionMinutes", Order = 29)]
        public int? TimeOfPossessionMinutes { get; set; }

        /// <summary>
        /// Total number of seconds the team possessed the ball for in the season
        /// </summary>
        [Description("Total number of seconds the team possessed the ball for in the season")]
        [DataMember(Name = "TimeOfPossessionSeconds", Order = 30)]
        public int? TimeOfPossessionSeconds { get; set; }

        /// <summary>
        /// A globally unique ID for the team. Note: This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the team. Note: This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 31)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// This field is deprecated.
        /// </summary>
        [Description("This field is deprecated.")]
        [DataMember(Name = "ConferenceRank", Order = 32)]
        public int? ConferenceRank { get; set; }

        /// <summary>
        /// This field is deprecated.
        /// </summary>
        [Description("This field is deprecated.")]
        [DataMember(Name = "DivisionRank", Order = 33)]
        public int? DivisionRank { get; set; }

        /// <summary>
        /// The updated date and time of the stat.
        /// </summary>
        [Description("The updated date and time of the stat.")]
        [DataMember(Name = "Updated", Order = 34)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date and time of the created stat.
        /// </summary>
        [Description("The date and time of the created stat.")]
        [DataMember(Name = "Created", Order = 35)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Indicates whether or not a player has recorded any stats for a given game.
        /// </summary>
        [Description("Indicates whether or not a player has recorded any stats for a given game.")]
        [DataMember(Name = "Games", Order = 36)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 37)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total passing attempts
        /// </summary>
        [Description("Total passing attempts")]
        [DataMember(Name = "PassingAttempts", Order = 38)]
        public decimal? PassingAttempts { get; set; }

        /// <summary>
        /// Total passing completions
        /// </summary>
        [Description("Total passing completions")]
        [DataMember(Name = "PassingCompletions", Order = 39)]
        public decimal? PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards
        /// </summary>
        [Description("Total passing yards")]
        [DataMember(Name = "PassingYards", Order = 40)]
        public decimal? PassingYards { get; set; }

        /// <summary>
        /// Total passing completion percentage
        /// </summary>
        [Description("Total passing completion percentage")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 41)]
        public decimal? PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Total passing yards per attempts
        /// </summary>
        [Description("Total passing yards per attempts")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 42)]
        public decimal? PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total passing yards per completion
        /// </summary>
        [Description("Total passing yards per completion")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 43)]
        public decimal? PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total passing touchdowns
        /// </summary>
        [Description("Total passing touchdowns")]
        [DataMember(Name = "PassingTouchdowns", Order = 44)]
        public decimal? PassingTouchdowns { get; set; }

        /// <summary>
        /// Total passing interceptions
        /// </summary>
        [Description("Total passing interceptions")]
        [DataMember(Name = "PassingInterceptions", Order = 45)]
        public decimal? PassingInterceptions { get; set; }

        /// <summary>
        /// Total passing rating
        /// </summary>
        [Description("Total passing rating")]
        [DataMember(Name = "PassingRating", Order = 46)]
        public decimal? PassingRating { get; set; }

        /// <summary>
        /// Total rushing attempts
        /// </summary>
        [Description("Total rushing attempts")]
        [DataMember(Name = "RushingAttempts", Order = 47)]
        public decimal? RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards
        /// </summary>
        [Description("Total rushing yards")]
        [DataMember(Name = "RushingYards", Order = 48)]
        public decimal? RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt
        /// </summary>
        [Description("Total rushing yards per attempt")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 49)]
        public decimal? RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns
        /// </summary>
        [Description("Total rushing touchdowns")]
        [DataMember(Name = "RushingTouchdowns", Order = 50)]
        public decimal? RushingTouchdowns { get; set; }

        /// <summary>
        /// Longest rushing attempt
        /// </summary>
        [Description("Longest rushing attempt")]
        [DataMember(Name = "RushingLong", Order = 51)]
        public decimal? RushingLong { get; set; }

        /// <summary>
        /// Total receptions
        /// </summary>
        [Description("Total receptions")]
        [DataMember(Name = "Receptions", Order = 52)]
        public decimal? Receptions { get; set; }

        /// <summary>
        /// Total receiving yards
        /// </summary>
        [Description("Total receiving yards")]
        [DataMember(Name = "ReceivingYards", Order = 53)]
        public decimal? ReceivingYards { get; set; }

        /// <summary>
        /// Total receiving yards per reception
        /// </summary>
        [Description("Total receiving yards per reception")]
        [DataMember(Name = "ReceivingYardsPerReception", Order = 54)]
        public decimal? ReceivingYardsPerReception { get; set; }

        /// <summary>
        /// Total receiving touchdowns
        /// </summary>
        [Description("Total receiving touchdowns")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 55)]
        public decimal? ReceivingTouchdowns { get; set; }

        /// <summary>
        /// Long receiving reception
        /// </summary>
        [Description("Long receiving reception")]
        [DataMember(Name = "ReceivingLong", Order = 56)]
        public decimal? ReceivingLong { get; set; }

        /// <summary>
        /// Total punt returns
        /// </summary>
        [Description("Total punt returns")]
        [DataMember(Name = "PuntReturns", Order = 57)]
        public decimal? PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards
        /// </summary>
        [Description("Total punt return yards")]
        [DataMember(Name = "PuntReturnYards", Order = 58)]
        public decimal? PuntReturnYards { get; set; }

        /// <summary>
        /// Total punt return yards per attempt
        /// </summary>
        [Description("Total punt return yards per attempt")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 59)]
        public decimal? PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total punt return touchdowns
        /// </summary>
        [Description("Total punt return touchdowns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 60)]
        public decimal? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 61)]
        public decimal? PuntReturnLong { get; set; }

        /// <summary>
        /// Total kick returns
        /// </summary>
        [Description("Total kick returns")]
        [DataMember(Name = "KickReturns", Order = 62)]
        public decimal? KickReturns { get; set; }

        /// <summary>
        /// Total kick return yards
        /// </summary>
        [Description("Total kick return yards")]
        [DataMember(Name = "KickReturnYards", Order = 63)]
        public decimal? KickReturnYards { get; set; }

        /// <summary>
        /// Total kick return yards per attempt
        /// </summary>
        [Description("Total kick return yards per attempt")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 64)]
        public decimal? KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total kick return touchdowns
        /// </summary>
        [Description("Total kick return touchdowns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 65)]
        public decimal? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return 
        /// </summary>
        [Description("Longest kick return ")]
        [DataMember(Name = "KickReturnLong", Order = 66)]
        public decimal? KickReturnLong { get; set; }

        /// <summary>
        /// Total punts
        /// </summary>
        [Description("Total punts")]
        [DataMember(Name = "Punts", Order = 67)]
        public decimal? Punts { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "PuntYards", Order = 68)]
        public decimal? PuntYards { get; set; }

        /// <summary>
        /// Total punt average
        /// </summary>
        [Description("Total punt average")]
        [DataMember(Name = "PuntAverage", Order = 69)]
        public decimal? PuntAverage { get; set; }

        /// <summary>
        /// Longest punt
        /// </summary>
        [Description("Longest punt")]
        [DataMember(Name = "PuntLong", Order = 70)]
        public decimal? PuntLong { get; set; }

        /// <summary>
        /// Total field goals attempted
        /// </summary>
        [Description("Total field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 71)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goals made
        /// </summary>
        [Description("Total field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 72)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalPercentage", Order = 73)]
        public decimal? FieldGoalPercentage { get; set; }

        /// <summary>
        /// Longest field goal made
        /// </summary>
        [Description("Longest field goal made")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 74)]
        public decimal? FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Total extra points attempted
        /// </summary>
        [Description("Total extra points attempted")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 75)]
        public decimal? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Total extra points made
        /// </summary>
        [Description("Total extra points made")]
        [DataMember(Name = "ExtraPointsMade", Order = 76)]
        public decimal? ExtraPointsMade { get; set; }

        /// <summary>
        /// Total interceptions
        /// </summary>
        [Description("Total interceptions")]
        [DataMember(Name = "Interceptions", Order = 77)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total interception return yards
        /// </summary>
        [Description("Total interception return yards")]
        [DataMember(Name = "InterceptionReturnYards", Order = 78)]
        public decimal? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total interception return touchdowns
        /// </summary>
        [Description("Total interception return touchdowns")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 79)]
        public decimal? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total Solo Tackles
        /// </summary>
        [Description("Total Solo Tackles")]
        [DataMember(Name = "SoloTackles", Order = 80)]
        public decimal? SoloTackles { get; set; }

        /// <summary>
        /// Total Assisted Tackles
        /// </summary>
        [Description("Total Assisted Tackles")]
        [DataMember(Name = "AssistedTackles", Order = 81)]
        public decimal? AssistedTackles { get; set; }

        /// <summary>
        /// Total Tackles for a loss of yardage
        /// </summary>
        [Description("Total Tackles for a loss of yardage")]
        [DataMember(Name = "TacklesForLoss", Order = 82)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total Quarterback Sacks
        /// </summary>
        [Description("Total Quarterback Sacks")]
        [DataMember(Name = "Sacks", Order = 83)]
        public decimal? Sacks { get; set; }

        /// <summary>
        /// Total Passes Defended
        /// </summary>
        [Description("Total Passes Defended")]
        [DataMember(Name = "PassesDefended", Order = 84)]
        public decimal? PassesDefended { get; set; }

        /// <summary>
        /// Total Fumble Recoveries
        /// </summary>
        [Description("Total Fumble Recoveries")]
        [DataMember(Name = "FumblesRecovered", Order = 85)]
        public decimal? FumblesRecovered { get; set; }

        /// <summary>
        /// Total Fumbles Recovered and returned for a touchdown
        /// </summary>
        [Description("Total Fumbles Recovered and returned for a touchdown")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 86)]
        public decimal? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total Quarterback Hurries. NOTE: This field is deprecated as of 2021.
        /// </summary>
        [Description("Total Quarterback Hurries. NOTE: This field is deprecated as of 2021.")]
        [DataMember(Name = "QuarterbackHurries", Order = 87)]
        public decimal? QuarterbackHurries { get; set; }

        /// <summary>
        /// Total Fumbles
        /// </summary>
        [Description("Total Fumbles")]
        [DataMember(Name = "Fumbles", Order = 88)]
        public decimal? Fumbles { get; set; }

        /// <summary>
        /// Total Fumbles Lost
        /// </summary>
        [Description("Total Fumbles Lost")]
        [DataMember(Name = "FumblesLost", Order = 89)]
        public decimal? FumblesLost { get; set; }

    }
}

