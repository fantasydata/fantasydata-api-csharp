using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Bye")]
    [Serializable]
    public partial class Bye
    {
        /// <summary>
        /// The NFL season during this bye week
        /// </summary>
        [Description("The NFL season during this bye week")]
        [DataMember(Name = "Season", Order = 1)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week during this bye week
        /// </summary>
        [Description("The NFL week during this bye week")]
        [DataMember(Name = "Week", Order = 2)]
        public int Week { get; set; }

        /// <summary>
        /// The NFL team who is on bye during this week
        /// </summary>
        [Description("The NFL team who is on bye during this week")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

    }
}

