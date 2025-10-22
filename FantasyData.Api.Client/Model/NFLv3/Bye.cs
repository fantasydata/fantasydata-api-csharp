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
        /// The NFL season during which this bye week occurs.
        /// </summary>
        [Description("The NFL season during which this bye week occurs.")]
        [DataMember(Name = "Season", Order = 1)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week during this bye week (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week during this bye week (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 2)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team who is on a bye
        /// </summary>
        [Description("The abbreviation [Key] of the team who is on a bye")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

    }
}

