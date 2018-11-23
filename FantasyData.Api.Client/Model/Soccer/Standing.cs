using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Standing")]
    [Serializable]
    public partial class Standing
    {
        /// <summary>
        /// The unique ID of the standing
        /// </summary>
        [Description("The unique ID of the standing")]
        [DataMember(Name = "StandingId", Order = 1)]
        public int StandingId { get; set; }

        /// <summary>
        /// The unique ID of the round
        /// </summary>
        [Description("The unique ID of the round")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The short name of the team
        /// </summary>
        [Description("The short name of the team")]
        [DataMember(Name = "ShortName", Order = 5)]
        public string ShortName { get; set; }

        /// <summary>
        /// The scope of the standing (possible values: Total, Away, Home)
        /// </summary>
        [Description("The scope of the standing (possible values: Total, Away, Home)")]
        [DataMember(Name = "Scope", Order = 6)]
        public string Scope { get; set; }

        /// <summary>
        /// The order of the teams in the standing (e.g 1, 2, 3, 4, etc.)
        /// </summary>
        [Description("The order of the teams in the standing (e.g 1, 2, 3, 4, etc.)")]
        [DataMember(Name = "Order", Order = 7)]
        public int? Order { get; set; }

        /// <summary>
        /// Number of games played
        /// </summary>
        [Description("Number of games played")]
        [DataMember(Name = "Games", Order = 8)]
        public int? Games { get; set; }

        /// <summary>
        /// Number of wins
        /// </summary>
        [Description("Number of wins")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// Number of losses
        /// </summary>
        [Description("Number of losses")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// Number of draws
        /// </summary>
        [Description("Number of draws")]
        [DataMember(Name = "Draws", Order = 11)]
        public int? Draws { get; set; }

        /// <summary>
        /// Number of goals scored
        /// </summary>
        [Description("Number of goals scored")]
        [DataMember(Name = "GoalsScored", Order = 12)]
        public int? GoalsScored { get; set; }

        /// <summary>
        /// Number of goals against
        /// </summary>
        [Description("Number of goals against")]
        [DataMember(Name = "GoalsAgainst", Order = 13)]
        public int? GoalsAgainst { get; set; }

        /// <summary>
        /// Total goal differential
        /// </summary>
        [Description("Total goal differential")]
        [DataMember(Name = "GoalsDifferential", Order = 14)]
        public int? GoalsDifferential { get; set; }

        /// <summary>
        /// Total points accumulated
        /// </summary>
        [Description("Total points accumulated")]
        [DataMember(Name = "Points", Order = 15)]
        public int? Points { get; set; }

        /// <summary>
        /// The name of the group (when applicable)
        /// </summary>
        [Description("The name of the group (when applicable)")]
        [DataMember(Name = "Group", Order = 16)]
        public string Group { get; set; }

    }
}

