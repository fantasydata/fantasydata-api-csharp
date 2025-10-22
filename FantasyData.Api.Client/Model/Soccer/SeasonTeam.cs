using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="SeasonTeam")]
    [Serializable]
    public partial class SeasonTeam
    {
        /// <summary>
        /// Unique ID of this season/team combination
        /// </summary>
        [Description("Unique ID of this season/team combination")]
        [DataMember(Name = "SeasonTeamId", Order = 1)]
        public int SeasonTeamId { get; set; }

        /// <summary>
        /// The unique ID of the season this record is associated with
        /// </summary>
        [Description("The unique ID of the season this record is associated with")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The name of the team associated with this record
        /// </summary>
        [Description("The name of the team associated with this record")]
        [DataMember(Name = "TeamName", Order = 4)]
        public string TeamName { get; set; }

        /// <summary>
        /// Whether this team is actively associated with this season (true/false)
        /// </summary>
        [Description("Whether this team is actively associated with this season (true/false)")]
        [DataMember(Name = "Active", Order = 5)]
        public bool Active { get; set; }

        /// <summary>
        /// The gender of the players on the team. Possible Values: Male; Female
        /// </summary>
        [Description("The gender of the players on the team. Possible Values: Male; Female")]
        [DataMember(Name = "Gender", Order = 6)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of season/team. Possible values: Club; National
        /// </summary>
        [Description("The type of season/team. Possible values: Club; National")]
        [DataMember(Name = "Type", Order = 7)]
        public string Type { get; set; }

        /// <summary>
        /// The details of the team for the given season/team association
        /// </summary>
        [Description("The details of the team for the given season/team association")]
        [DataMember(Name = "Team", Order = 10008)]
        public Team Team { get; set; }

    }
}

