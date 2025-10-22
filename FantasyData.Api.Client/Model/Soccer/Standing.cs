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
        /// The unique ID of the standing
        /// </summary>
        [Description("The unique ID of the standing")]
        [DataMember(Name = "StandingId", Order = 1)]
        public int StandingId { get; set; }

        /// <summary>
        /// The unique ID of the round that this team is associated with
        /// </summary>
        [Description("The unique ID of the round that this team is associated with")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The team's full name
        /// </summary>
        [Description("The team's full name")]
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
        /// The order of the teams in the standing (e.g 1; 2; 3; 4; etc.)
        /// </summary>
        [Description("The order of the teams in the standing (e.g 1; 2; 3; 4; etc.)")]
        [DataMember(Name = "Order", Order = 7)]
        public int? Order { get; set; }

        /// <summary>
        /// Total number of games played by the team in the season
        /// </summary>
        [Description("Total number of games played by the team in the season")]
        [DataMember(Name = "Games", Order = 8)]
        public int? Games { get; set; }

        /// <summary>
        /// Number of wins by the team in the season
        /// </summary>
        [Description("Number of wins by the team in the season")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// The number of losses for the team
        /// </summary>
        [Description("The number of losses for the team")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// Number of draws by the team in the season
        /// </summary>
        [Description("Number of draws by the team in the season")]
        [DataMember(Name = "Draws", Order = 11)]
        public int? Draws { get; set; }

        /// <summary>
        /// Total number of goals scored by the team in the season
        /// </summary>
        [Description("Total number of goals scored by the team in the season")]
        [DataMember(Name = "GoalsScored", Order = 12)]
        public int? GoalsScored { get; set; }

        /// <summary>
        /// Total number of goals against by the team in the season
        /// </summary>
        [Description("Total number of goals against by the team in the season")]
        [DataMember(Name = "GoalsAgainst", Order = 13)]
        public int? GoalsAgainst { get; set; }

        /// <summary>
        /// The goal differential of the team in the season. Note: GoalDifferential = GoalsScored - GoalsAgainst
        /// </summary>
        [Description("The goal differential of the team in the season. Note: GoalDifferential = GoalsScored - GoalsAgainst")]
        [DataMember(Name = "GoalsDifferential", Order = 14)]
        public int? GoalsDifferential { get; set; }

        /// <summary>
        /// Total points accumulated by the team
        /// </summary>
        [Description("Total points accumulated by the team")]
        [DataMember(Name = "Points", Order = 15)]
        public int? Points { get; set; }

        /// <summary>
        /// The name of the group (when applicable)
        /// </summary>
        [Description("The name of the group (when applicable)")]
        [DataMember(Name = "Group", Order = 16)]
        public string Group { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 17)]
        public int? GlobalTeamID { get; set; }

    }
}

