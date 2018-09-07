using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Stat")]
    [Serializable]
    public partial class Stat
    {
        /// <summary>
        /// The updated date and time of the stat.
        /// </summary>
        [Description("The updated date and time of the stat.")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date and time of the created stat.
        /// </summary>
        [Description("The date and time of the created stat.")]
        [DataMember(Name = "Created", Order = 2)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Total games
        /// </summary>
        [Description("Total games")]
        [DataMember(Name = "Games", Order = 3)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 4)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total passing attempts
        /// </summary>
        [Description("Total passing attempts")]
        [DataMember(Name = "PassingAttempts", Order = 5)]
        public decimal? PassingAttempts { get; set; }

        /// <summary>
        /// Total passing completions
        /// </summary>
        [Description("Total passing completions")]
        [DataMember(Name = "PassingCompletions", Order = 6)]
        public decimal? PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards
        /// </summary>
        [Description("Total passing yards")]
        [DataMember(Name = "PassingYards", Order = 7)]
        public decimal? PassingYards { get; set; }

        /// <summary>
        /// Total passing completion percentage
        /// </summary>
        [Description("Total passing completion percentage")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 8)]
        public decimal? PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Total passing yards per attempts
        /// </summary>
        [Description("Total passing yards per attempts")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 9)]
        public decimal? PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total passing yards per completion
        /// </summary>
        [Description("Total passing yards per completion")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 10)]
        public decimal? PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total passing touchdowns
        /// </summary>
        [Description("Total passing touchdowns")]
        [DataMember(Name = "PassingTouchdowns", Order = 11)]
        public decimal? PassingTouchdowns { get; set; }

        /// <summary>
        /// Total passing interceptions
        /// </summary>
        [Description("Total passing interceptions")]
        [DataMember(Name = "PassingInterceptions", Order = 12)]
        public decimal? PassingInterceptions { get; set; }

        /// <summary>
        /// Total passing rating
        /// </summary>
        [Description("Total passing rating")]
        [DataMember(Name = "PassingRating", Order = 13)]
        public decimal? PassingRating { get; set; }

        /// <summary>
        /// Total rushing attempts
        /// </summary>
        [Description("Total rushing attempts")]
        [DataMember(Name = "RushingAttempts", Order = 14)]
        public decimal? RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards
        /// </summary>
        [Description("Total rushing yards")]
        [DataMember(Name = "RushingYards", Order = 15)]
        public decimal? RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt
        /// </summary>
        [Description("Total rushing yards per attempt")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 16)]
        public decimal? RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns
        /// </summary>
        [Description("Total rushing touchdowns")]
        [DataMember(Name = "RushingTouchdowns", Order = 17)]
        public decimal? RushingTouchdowns { get; set; }

        /// <summary>
        /// Longest rushing attempt
        /// </summary>
        [Description("Longest rushing attempt")]
        [DataMember(Name = "RushingLong", Order = 18)]
        public decimal? RushingLong { get; set; }

        /// <summary>
        /// Total receptions
        /// </summary>
        [Description("Total receptions")]
        [DataMember(Name = "Receptions", Order = 19)]
        public decimal? Receptions { get; set; }

        /// <summary>
        /// Total receiving yards
        /// </summary>
        [Description("Total receiving yards")]
        [DataMember(Name = "ReceivingYards", Order = 20)]
        public decimal? ReceivingYards { get; set; }

        /// <summary>
        /// Total receiving yards per reception
        /// </summary>
        [Description("Total receiving yards per reception")]
        [DataMember(Name = "ReceivingYardsPerReception", Order = 21)]
        public decimal? ReceivingYardsPerReception { get; set; }

        /// <summary>
        /// Total receiving touchdowns
        /// </summary>
        [Description("Total receiving touchdowns")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 22)]
        public decimal? ReceivingTouchdowns { get; set; }

        /// <summary>
        /// Long receiving reception
        /// </summary>
        [Description("Long receiving reception")]
        [DataMember(Name = "ReceivingLong", Order = 23)]
        public decimal? ReceivingLong { get; set; }

        /// <summary>
        /// Total punt returns
        /// </summary>
        [Description("Total punt returns")]
        [DataMember(Name = "PuntReturns", Order = 24)]
        public decimal? PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards
        /// </summary>
        [Description("Total punt return yards")]
        [DataMember(Name = "PuntReturnYards", Order = 25)]
        public decimal? PuntReturnYards { get; set; }

        /// <summary>
        /// Total punt return yards per attempt
        /// </summary>
        [Description("Total punt return yards per attempt")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 26)]
        public decimal? PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total punt return touchdowns
        /// </summary>
        [Description("Total punt return touchdowns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 27)]
        public decimal? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 28)]
        public decimal? PuntReturnLong { get; set; }

        /// <summary>
        /// Total kick returns
        /// </summary>
        [Description("Total kick returns")]
        [DataMember(Name = "KickReturns", Order = 29)]
        public decimal? KickReturns { get; set; }

        /// <summary>
        /// Total kick return yards
        /// </summary>
        [Description("Total kick return yards")]
        [DataMember(Name = "KickReturnYards", Order = 30)]
        public decimal? KickReturnYards { get; set; }

        /// <summary>
        /// Total kick return yards per attempt
        /// </summary>
        [Description("Total kick return yards per attempt")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 31)]
        public decimal? KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total kick return touchdowns
        /// </summary>
        [Description("Total kick return touchdowns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 32)]
        public decimal? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return 
        /// </summary>
        [Description("Longest kick return ")]
        [DataMember(Name = "KickReturnLong", Order = 33)]
        public decimal? KickReturnLong { get; set; }

        /// <summary>
        /// Total punts
        /// </summary>
        [Description("Total punts")]
        [DataMember(Name = "Punts", Order = 34)]
        public decimal? Punts { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "PuntYards", Order = 35)]
        public decimal? PuntYards { get; set; }

        /// <summary>
        /// Total punt average
        /// </summary>
        [Description("Total punt average")]
        [DataMember(Name = "PuntAverage", Order = 36)]
        public decimal? PuntAverage { get; set; }

        /// <summary>
        /// Longest punt
        /// </summary>
        [Description("Longest punt")]
        [DataMember(Name = "PuntLong", Order = 37)]
        public decimal? PuntLong { get; set; }

        /// <summary>
        /// Total field goals attempted
        /// </summary>
        [Description("Total field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 38)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goals made
        /// </summary>
        [Description("Total field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 39)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalPercentage", Order = 40)]
        public decimal? FieldGoalPercentage { get; set; }

        /// <summary>
        /// Longest field goal made
        /// </summary>
        [Description("Longest field goal made")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 41)]
        public decimal? FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Total extra points attempted
        /// </summary>
        [Description("Total extra points attempted")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 42)]
        public decimal? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Total extra points made
        /// </summary>
        [Description("Total extra points made")]
        [DataMember(Name = "ExtraPointsMade", Order = 43)]
        public decimal? ExtraPointsMade { get; set; }

        /// <summary>
        /// Total interceptions
        /// </summary>
        [Description("Total interceptions")]
        [DataMember(Name = "Interceptions", Order = 44)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total interception return yards
        /// </summary>
        [Description("Total interception return yards")]
        [DataMember(Name = "InterceptionReturnYards", Order = 45)]
        public decimal? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total interception return touchdowns
        /// </summary>
        [Description("Total interception return touchdowns")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 46)]
        public decimal? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total Solo Tackles
        /// </summary>
        [Description("Total Solo Tackles")]
        [DataMember(Name = "SoloTackles", Order = 47)]
        public decimal? SoloTackles { get; set; }

        /// <summary>
        /// Total Assisted Tackles
        /// </summary>
        [Description("Total Assisted Tackles")]
        [DataMember(Name = "AssistedTackles", Order = 48)]
        public decimal? AssistedTackles { get; set; }

        /// <summary>
        /// Total Tackles for a loss of yardage
        /// </summary>
        [Description("Total Tackles for a loss of yardage")]
        [DataMember(Name = "TacklesForLoss", Order = 49)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total Quarterback Sacks
        /// </summary>
        [Description("Total Quarterback Sacks")]
        [DataMember(Name = "Sacks", Order = 50)]
        public decimal? Sacks { get; set; }

        /// <summary>
        /// Total Passes Defended
        /// </summary>
        [Description("Total Passes Defended")]
        [DataMember(Name = "PassesDefended", Order = 51)]
        public decimal? PassesDefended { get; set; }

        /// <summary>
        /// Total Fumble Recoveries
        /// </summary>
        [Description("Total Fumble Recoveries")]
        [DataMember(Name = "FumblesRecovered", Order = 52)]
        public decimal? FumblesRecovered { get; set; }

        /// <summary>
        /// Total Fumbles Recovered and returned for a touchdown
        /// </summary>
        [Description("Total Fumbles Recovered and returned for a touchdown")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 53)]
        public decimal? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total Quarterback Hurries
        /// </summary>
        [Description("Total Quarterback Hurries")]
        [DataMember(Name = "QuarterbackHurries", Order = 54)]
        public decimal? QuarterbackHurries { get; set; }

        /// <summary>
        /// Total Fumbles
        /// </summary>
        [Description("Total Fumbles")]
        [DataMember(Name = "Fumbles", Order = 55)]
        public decimal? Fumbles { get; set; }

        /// <summary>
        /// Total Fumbles Lost
        /// </summary>
        [Description("Total Fumbles Lost")]
        [DataMember(Name = "FumblesLost", Order = 56)]
        public decimal? FumblesLost { get; set; }

    }
}

