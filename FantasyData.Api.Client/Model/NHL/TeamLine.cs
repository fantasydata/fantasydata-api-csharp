using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="TeamLine")]
    [Serializable]
    public partial class TeamLine
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// "The abbreviation [Key] of the team associated with this market (Ex. BOS, EDM, LAK)"
        /// </summary>
        [Description("\"The abbreviation [Key] of the team associated with this market (Ex. BOS, EDM, LAK)\"")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// The team's full name (ex. Minnesota Wild; New York Islanders)
        /// </summary>
        [Description("The team's full name (ex. Minnesota Wild; New York Islanders)")]
        [DataMember(Name = "FullName", Order = 3)]
        public string FullName { get; set; }

        /// <summary>
        /// The even strength lines for this team
        /// </summary>
        [Description("The even strength lines for this team")]
        [DataMember(Name = "EvenStrengthLines", Order = 20004)]
        public PlayerLine[] EvenStrengthLines { get; set; }

        /// <summary>
        /// The power play lines for a given team
        /// </summary>
        [Description("The power play lines for a given team")]
        [DataMember(Name = "PowerPlayLines", Order = 20005)]
        public PlayerLine[] PowerPlayLines { get; set; }

        /// <summary>
        /// The short-handed/penalty-kill lines for this team
        /// </summary>
        [Description("The short-handed/penalty-kill lines for this team")]
        [DataMember(Name = "ShortHandedLines", Order = 20006)]
        public PlayerLine[] ShortHandedLines { get; set; }

    }
}

