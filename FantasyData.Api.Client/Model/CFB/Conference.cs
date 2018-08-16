using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Conference")]
    [Serializable]
    public partial class Conference
    {
        /// <summary>
        /// The ID of the team's conference
        /// </summary>
        [Description("The ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 1)]
        public int ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's conference
        /// </summary>
        [Description("The name of the team's conference")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The teams that play within this conference
        /// </summary>
        [Description("The teams that play within this conference")]
        [DataMember(Name = "Teams", Order = 20003)]
        public Team[] Teams { get; set; }

        /// <summary>
        /// The name of the team's parent conference (e.g. SEC, Big Ten, etc)
        /// </summary>
        [Description("The name of the team's parent conference (e.g. SEC, Big Ten, etc)")]
        [DataMember(Name = "ConferenceName", Order = 4)]
        public string ConferenceName { get; set; }

        /// <summary>
        /// The name of the team's division (e.g. East, West, Atlantic, etc)
        /// </summary>
        [Description("The name of the team's division (e.g. East, West, Atlantic, etc)")]
        [DataMember(Name = "DivisionName", Order = 5)]
        public string DivisionName { get; set; }

    }
}

