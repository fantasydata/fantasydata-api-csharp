﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CWBB
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
        /// The name of the team's conference
        /// </summary>
        [Description("The name of the team's conference")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The college teams within this conference
        /// </summary>
        [Description("The college teams within this conference")]
        [DataMember(Name = "Teams", Order = 20003)]
        public Team[] Teams { get; set; }

    }
}

