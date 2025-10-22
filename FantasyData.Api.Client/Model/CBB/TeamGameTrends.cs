using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="TeamGameTrends")]
    [Serializable]
    public partial class TeamGameTrends
    {
        /// <summary>
        /// The range in which the trend shows data for (e.g. Last 5 games; Last 10 games; Last 5 home games; etc.)
        /// </summary>
        [Description("The range in which the trend shows data for (e.g. Last 5 games; Last 10 games; Last 5 home games; etc.)")]
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
        /// The total number of wins by the team relating to the scope (conference & non-conference)
        /// </summary>
        [Description("The total number of wins by the team relating to the scope (conference & non-conference)")]
        [DataMember(Name = "Wins", Order = 6)]
        public int Wins { get; set; }

        /// <summary>
        /// The total number of losses by the team relating to the scope (conference & non-conference)
        /// </summary>
        [Description("The total number of losses by the team relating to the scope (conference & non-conference)")]
        [DataMember(Name = "Losses", Order = 7)]
        public int Losses { get; set; }

        /// <summary>
        /// The total number of ties by the team relating to the scope (conference & non-conference)
        /// </summary>
        [Description("The total number of ties by the team relating to the scope (conference & non-conference)")]
        [DataMember(Name = "Ties", Order = 8)]
        public int Ties { get; set; }

        /// <summary>
        /// How many games the given team has covered the spread in relating to the scope of the search
        /// </summary>
        [Description("How many games the given team has covered the spread in relating to the scope of the search")]
        [DataMember(Name = "WinsAgainstTheSpread", Order = 9)]
        public int? WinsAgainstTheSpread { get; set; }

        /// <summary>
        /// The total number of losses against the point spread by the team relating to the scope (conference & non-conference
        /// </summary>
        [Description("The total number of losses against the point spread by the team relating to the scope (conference & non-conference")]
        [DataMember(Name = "LossesAgainstTheSpread", Order = 10)]
        public int? LossesAgainstTheSpread { get; set; }

        /// <summary>
        /// The amount of times a given team's final score of their game has pushed the point spread (a push is neither a win nor a loss)
        /// </summary>
        [Description("The amount of times a given team's final score of their game has pushed the point spread (a push is neither a win nor a loss)")]
        [DataMember(Name = "PushesAgainstTheSpread", Order = 11)]
        public int? PushesAgainstTheSpread { get; set; }

        /// <summary>
        /// The amount of times a given team's final score of their game has gone over the point total (Over/Under) relating to the scope
        /// </summary>
        [Description("The amount of times a given team's final score of their game has gone over the point total (Over/Under) relating to the scope")]
        [DataMember(Name = "Overs", Order = 12)]
        public int? Overs { get; set; }

        /// <summary>
        /// Amount of times the total score goes under the OverUnder
        /// </summary>
        [Description("Amount of times the total score goes under the OverUnder")]
        [DataMember(Name = "Unders", Order = 13)]
        public int? Unders { get; set; }

        /// <summary>
        /// The amount of times a given team's final score of their game has pushed the total points line (a push is neither a win nor a loss)
        /// </summary>
        [Description("The amount of times a given team's final score of their game has pushed the total points line (a push is neither a win nor a loss)")]
        [DataMember(Name = "OverUnderPushes", Order = 14)]
        public int? OverUnderPushes { get; set; }

        /// <summary>
        /// The average points per game scored by the given team over a certain scope (Last 3 Games, Last 5 Games, Last 10 Games, etc.)
        /// </summary>
        [Description("The average points per game scored by the given team over a certain scope (Last 3 Games, Last 5 Games, Last 10 Games, etc.)")]
        [DataMember(Name = "AverageScore", Order = 15)]
        public decimal? AverageScore { get; set; }

        /// <summary>
        /// The average points per game scored by the opposing teams of a given team over a certain scope (Last 3 Games, Last 5 Games, Last 10 Games, etc.)
        /// </summary>
        [Description("The average points per game scored by the opposing teams of a given team over a certain scope (Last 3 Games, Last 5 Games, Last 10 Games, etc.)")]
        [DataMember(Name = "AverageOpponentScore", Order = 16)]
        public decimal? AverageOpponentScore { get; set; }

    }
}

