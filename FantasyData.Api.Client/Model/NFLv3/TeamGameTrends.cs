using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
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
        /// The unique ID of the opponent team
        /// </summary>
        [Description("The unique ID of the opponent team")]
        [DataMember(Name = "OpponentID", Order = 4)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team")]
        [DataMember(Name = "Opponent", Order = 5)]
        public string Opponent { get; set; }

        /// <summary>
        /// Total number of wins relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total number of wins relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "Wins", Order = 6)]
        public int Wins { get; set; }

        /// <summary>
        /// Losses relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Losses relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "Losses", Order = 7)]
        public int Losses { get; set; }

        /// <summary>
        /// Total ties by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total ties by the team relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "Ties", Order = 8)]
        public int Ties { get; set; }

        /// <summary>
        /// Total number of wins against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Total number of wins against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "WinsAgainstTheSpread", Order = 9)]
        public int? WinsAgainstTheSpread { get; set; }

        /// <summary>
        /// Losses against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Losses against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "LossesAgainstTheSpread", Order = 10)]
        public int? LossesAgainstTheSpread { get; set; }

        /// <summary>
        /// Pushes against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.
        /// </summary>
        [Description("Pushes against the spread relating to the scope. Examples of scopes include: Last 3 Games, Last 5 Home Games, Last 10 Games as Favorite, etc.")]
        [DataMember(Name = "PushesAgainstTheSpread", Order = 11)]
        public int? PushesAgainstTheSpread { get; set; }

        /// <summary>
        /// Amount of times the total score goes over the total points line (over/under)
        /// </summary>
        [Description("Amount of times the total score goes over the total points line (over/under)")]
        [DataMember(Name = "Overs", Order = 12)]
        public int? Overs { get; set; }

        /// <summary>
        /// Amount of times the total score goes under the total points line (over/under)
        /// </summary>
        [Description("Amount of times the total score goes under the total points line (over/under)")]
        [DataMember(Name = "Unders", Order = 13)]
        public int? Unders { get; set; }

        /// <summary>
        /// Amount of times the total score pushes the total point line (over/under)
        /// </summary>
        [Description("Amount of times the total score pushes the total point line (over/under)")]
        [DataMember(Name = "OverUnderPushes", Order = 14)]
        public int? OverUnderPushes { get; set; }

        /// <summary>
        /// Average score of team
        /// </summary>
        [Description("Average score of team")]
        [DataMember(Name = "AverageScore", Order = 15)]
        public decimal? AverageScore { get; set; }

        /// <summary>
        /// Average score of opponent
        /// </summary>
        [Description("Average score of opponent")]
        [DataMember(Name = "AverageOpponentScore", Order = 16)]
        public decimal? AverageOpponentScore { get; set; }

    }
}

