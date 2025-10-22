using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="TeamGameTrends")]
    [Serializable]
    public partial class TeamGameTrends
    {
        /// <summary>
        /// The type of trend (e.g. Last 5 games; Last 10 games; Last 5 home games; etc.)
        /// </summary>
        [Description("The type of trend (e.g. Last 5 games; Last 10 games; Last 5 home games; etc.)")]
        [DataMember(Name = "Scope", Order = 1)]
        public string Scope { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The TeamID of the opposing team related to the scop of the search
        /// </summary>
        [Description("The TeamID of the opposing team related to the scop of the search")]
        [DataMember(Name = "OpponentID", Order = 4)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The name [Key] of the team's opponent related to the scop of the search
        /// </summary>
        [Description("The name [Key] of the team's opponent related to the scop of the search")]
        [DataMember(Name = "Opponent", Order = 5)]
        public string Opponent { get; set; }

        /// <summary>
        /// The total number of wins by the team relating to the scope
        /// </summary>
        [Description("The total number of wins by the team relating to the scope")]
        [DataMember(Name = "Wins", Order = 6)]
        public int Wins { get; set; }

        /// <summary>
        /// Team losses relating to the scope
        /// </summary>
        [Description("Team losses relating to the scope")]
        [DataMember(Name = "Losses", Order = 7)]
        public int Losses { get; set; }

        /// <summary>
        /// Ties by a team relating to the scope of the search
        /// </summary>
        [Description("Ties by a team relating to the scope of the search")]
        [DataMember(Name = "Ties", Order = 8)]
        public int Ties { get; set; }

        /// <summary>
        /// Total number of wins against the run line relating to the scope
        /// </summary>
        [Description("Total number of wins against the run line relating to the scope")]
        [DataMember(Name = "WinsAgainstTheSpread", Order = 9)]
        public int? WinsAgainstTheSpread { get; set; }

        /// <summary>
        /// Team losses against the run line relating to the scope
        /// </summary>
        [Description("Team losses against the run line relating to the scope")]
        [DataMember(Name = "LossesAgainstTheSpread", Order = 10)]
        public int? LossesAgainstTheSpread { get; set; }

        /// <summary>
        /// The amount of times a given team's final score of their game has pushed the run line (a push is neither a win nor a loss)
        /// </summary>
        [Description("The amount of times a given team's final score of their game has pushed the run line (a push is neither a win nor a loss)")]
        [DataMember(Name = "PushesAgainstTheSpread", Order = 11)]
        public int? PushesAgainstTheSpread { get; set; }

        /// <summary>
        /// Amount of times the total score goes over the OverUnder
        /// </summary>
        [Description("Amount of times the total score goes over the OverUnder")]
        [DataMember(Name = "Overs", Order = 12)]
        public int? Overs { get; set; }

        /// <summary>
        /// Amount of times the total score goes under the OverUnder
        /// </summary>
        [Description("Amount of times the total score goes under the OverUnder")]
        [DataMember(Name = "Unders", Order = 13)]
        public int? Unders { get; set; }

        /// <summary>
        /// The amount of times a given team's final score of their game has pushed the point total (a push is neither a win nor a loss)
        /// </summary>
        [Description("The amount of times a given team's final score of their game has pushed the point total (a push is neither a win nor a loss)")]
        [DataMember(Name = "OverUnderPushes", Order = 14)]
        public int? OverUnderPushes { get; set; }

        /// <summary>
        /// Average score of team
        /// </summary>
        [Description("Average score of team")]
        [DataMember(Name = "AverageScore", Order = 15)]
        public decimal? AverageScore { get; set; }

        /// <summary>
        /// Average score of the opposing team
        /// </summary>
        [Description("Average score of the opposing team")]
        [DataMember(Name = "AverageOpponentScore", Order = 16)]
        public decimal? AverageOpponentScore { get; set; }

    }
}

