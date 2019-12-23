using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NHL
{
    [DataContract(Namespace="", Name="TeamLine")]
    [Serializable]
    public partial class TeamLine
    {
        /// <summary>
        /// The unique ID for the team
        /// </summary>
        [Description("The unique ID for the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// Whether or not the team is active
        /// </summary>
        [Description("Whether or not the team is active")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// The full team name
        /// </summary>
        [Description("The full team name")]
        [DataMember(Name = "FullName", Order = 3)]
        public string FullName { get; set; }

        /// <summary>
        /// The even strength lines for this team
        /// </summary>
        [Description("The even strength lines for this team")]
        [DataMember(Name = "EvenStrengthLines", Order = 20004)]
        public PlayerLine[] EvenStrengthLines { get; set; }

        /// <summary>
        /// The power play lines for this team
        /// </summary>
        [Description("The power play lines for this team")]
        [DataMember(Name = "PowerPlayLines", Order = 20005)]
        public PlayerLine[] PowerPlayLines { get; set; }

    }
}

