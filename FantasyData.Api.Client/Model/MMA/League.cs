﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="League")]
    [Serializable]
    public partial class League
    {
        /// <summary>
        /// The unique ID of the MMA league
        /// </summary>
        [Description("The unique ID of the MMA league")]
        [DataMember(Name = "LeagueId", Order = 1)]
        public int LeagueId { get; set; }

        /// <summary>
        /// The name of this MMA league
        /// </summary>
        [Description("The name of this MMA league")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The league abbreviation of the MMA league
        /// </summary>
        [Description("The league abbreviation of the MMA league")]
        [DataMember(Name = "Key", Order = 3)]
        public string Key { get; set; }

    }
}

