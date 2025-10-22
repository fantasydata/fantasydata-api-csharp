using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="TeamGameTrends")]
    [Serializable]
    public partial class TeamGameTrends
    {
        /// <summary>
        /// The type of Trend (e.g. Last 5 games, Last 10 games, Last 5 home games, etc.)
        /// </summary>
        [Description("The type of Trend (e.g. Last 5 games, Last 10 games, Last 5 home games, etc.)")]
        [DataMember(Name = "Scope", Order = 1)]
        public string Scope { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentID", Order = 4)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The abreviation [Key] of the opponent team
        /// </summary>
        [Description("The abreviation [Key] of the opponent team")]
        [DataMember(Name = "Opponent", Order = 5)]
        public string Opponent { get; set; }

        /// <summary>
        /// Total number of wins by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total number of wins by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "Wins", Order = 6)]
        public int Wins { get; set; }

        /// <summary>
        /// The total number of losses by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("The total number of losses by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "Losses", Order = 7)]
        public int Losses { get; set; }

        /// <summary>
        /// Total number of ties by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total number of ties by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "Ties", Order = 8)]
        public int Ties { get; set; }

        /// <summary>
        /// Total number of wins against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total number of wins against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "WinsAgainstTheSpread", Order = 9)]
        public int? WinsAgainstTheSpread { get; set; }

        /// <summary>
        /// Losses by the team against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Losses by the team against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "LossesAgainstTheSpread", Order = 10)]
        public int? LossesAgainstTheSpread { get; set; }

        /// <summary>
        /// Total number of pushes against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total number of pushes against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "PushesAgainstTheSpread", Order = 11)]
        public int? PushesAgainstTheSpread { get; set; }

        /// <summary>
        /// Amount of times the total score goes over the total points line
        /// </summary>
        [Description("Amount of times the total score goes over the total points line")]
        [DataMember(Name = "Overs", Order = 12)]
        public int? Overs { get; set; }

        /// <summary>
        /// Amount of times the total score goes under the total points line
        /// </summary>
        [Description("Amount of times the total score goes under the total points line")]
        [DataMember(Name = "Unders", Order = 13)]
        public int? Unders { get; set; }

        /// <summary>
        /// Amount of times the total score pushes the total points line
        /// </summary>
        [Description("Amount of times the total score pushes the total points line")]
        [DataMember(Name = "OverUnderPushes", Order = 14)]
        public int? OverUnderPushes { get; set; }

        /// <summary>
        /// The average points scored by the team
        /// </summary>
        [Description("The average points scored by the team")]
        [DataMember(Name = "AverageScore", Order = 15)]
        public decimal? AverageScore { get; set; }

        /// <summary>
        /// The average points scored by the opposing team
        /// </summary>
        [Description("The average points scored by the opposing team")]
        [DataMember(Name = "AverageOpponentScore", Order = 16)]
        public decimal? AverageOpponentScore { get; set; }

    }
}

