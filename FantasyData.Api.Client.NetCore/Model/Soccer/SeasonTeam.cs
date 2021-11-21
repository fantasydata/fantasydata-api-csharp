using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Soccer
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
        /// Unique ID of the season associated with this record
        /// </summary>
        [Description("Unique ID of the season associated with this record")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// Unique ID of the team associated with this record
        /// </summary>
        [Description("Unique ID of the team associated with this record")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The name of the team associated with this record
        /// </summary>
        [Description("The name of the team associated with this record")]
        [DataMember(Name = "TeamName", Order = 4)]
        public string TeamName { get; set; }

        /// <summary>
        /// Whether this team is actively associated with this season
        /// </summary>
        [Description("Whether this team is actively associated with this season")]
        [DataMember(Name = "Active", Order = 5)]
        public bool Active { get; set; }

        /// <summary>
        /// Indicates the gender of the players on this team (possible values: Make, Female)
        /// </summary>
        [Description("Indicates the gender of the players on this team (possible values: Make, Female)")]
        [DataMember(Name = "Gender", Order = 6)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of this season/team (possible values: Club, National)
        /// </summary>
        [Description("The type of this season/team (possible values: Club, National)")]
        [DataMember(Name = "Type", Order = 7)]
        public string Type { get; set; }

        /// <summary>
        /// The team details of this season/team association
        /// </summary>
        [Description("The team details of this season/team association")]
        [DataMember(Name = "Team", Order = 10008)]
        public Team Team { get; set; }

    }
}

