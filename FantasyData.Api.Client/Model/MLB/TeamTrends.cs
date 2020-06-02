using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="TeamTrends")]
    [Serializable]
    public partial class TeamTrends
    {
        /// <summary>
        /// Abbreviation of the team (e.g. LAD, PHI, BOS, CHC, etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. LAD, PHI, BOS, CHC, etc.)")]
        [DataMember(Name = "Team", Order = 1)]
        public string Team { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Team
        /// </summary>
        [Description("The auto-generated unique ID of the Team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Upcoming game for this team
        /// </summary>
        [Description("Upcoming game for this team")]
        [DataMember(Name = "UpcomingGame", Order = 10003)]
        public Game UpcomingGame { get; set; }

        /// <summary>
        /// The collection of Game Trends for this team
        /// </summary>
        [Description("The collection of Game Trends for this team")]
        [DataMember(Name = "TeamGameTrends", Order = 20004)]
        public TeamGameTrends[] TeamGameTrends { get; set; }

    }
}

