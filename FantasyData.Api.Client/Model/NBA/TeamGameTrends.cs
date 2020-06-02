using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        /// The auto-generated unique ID of the Team
        /// </summary>
        [Description("The auto-generated unique ID of the Team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// Abbreviation of the Team (e.g. LAL, PHI, BOS, CHI, etc.)
        /// </summary>
        [Description("Abbreviation of the Team (e.g. LAL, PHI, BOS, CHI, etc.)")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Opponent Team
        /// </summary>
        [Description("The auto-generated unique ID of the Opponent Team")]
        [DataMember(Name = "OpponentID", Order = 4)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// Abbreviation of the Opponent Team (e.g. LAL, PHI, BOS, CHI, etc.)
        /// </summary>
        [Description("Abbreviation of the Opponent Team (e.g. LAL, PHI, BOS, CHI, etc.)")]
        [DataMember(Name = "Opponent", Order = 5)]
        public string Opponent { get; set; }

        /// <summary>
        /// Wins relating to the scope
        /// </summary>
        [Description("Wins relating to the scope")]
        [DataMember(Name = "Wins", Order = 6)]
        public int Wins { get; set; }

        /// <summary>
        /// Losses relating to the scope
        /// </summary>
        [Description("Losses relating to the scope")]
        [DataMember(Name = "Losses", Order = 7)]
        public int Losses { get; set; }

        /// <summary>
        /// Ties relating to the scope
        /// </summary>
        [Description("Ties relating to the scope")]
        [DataMember(Name = "Ties", Order = 8)]
        public int Ties { get; set; }

        /// <summary>
        /// Wins against the spread relating to the scope
        /// </summary>
        [Description("Wins against the spread relating to the scope")]
        [DataMember(Name = "WinsAgainstTheSpread", Order = 9)]
        public int? WinsAgainstTheSpread { get; set; }

        /// <summary>
        /// Losses against the spread relating to the scope
        /// </summary>
        [Description("Losses against the spread relating to the scope")]
        [DataMember(Name = "LossesAgainstTheSpread", Order = 10)]
        public int? LossesAgainstTheSpread { get; set; }

        /// <summary>
        /// Pushes against the spread relating to the scope
        /// </summary>
        [Description("Pushes against the spread relating to the scope")]
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
        /// Amount of times the total score pushes the OverUnder
        /// </summary>
        [Description("Amount of times the total score pushes the OverUnder")]
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

