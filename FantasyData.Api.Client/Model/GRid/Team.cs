using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="Team")]
    [Serializable]
    public partial class Team
    {
        /// <summary>
        /// The GUID/UUID of the team in the GRid system
        /// </summary>
        [Description("The GUID/UUID of the team in the GRid system")]
        [DataMember(Name = "TeamGRid", Order = 1)]
        public string TeamGRid { get; set; }

        /// <summary>
        /// The location of the team (or school for NCAA)
        /// </summary>
        [Description("The location of the team (or school for NCAA)")]
        [DataMember(Name = "Location", Order = 2)]
        public string Location { get; set; }

        /// <summary>
        /// The teams name
        /// </summary>
        [Description("The teams name")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// When this team was first created in GRid
        /// </summary>
        [Description("When this team was first created in GRid")]
        [DataMember(Name = "Created", Order = 4)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The list of originator's id mappings
        /// </summary>
        [Description("The list of originator's id mappings")]
        [DataMember(Name = "Mappings", Order = 20005)]
        public TeamMapping[] Mappings { get; set; }

    }
}

