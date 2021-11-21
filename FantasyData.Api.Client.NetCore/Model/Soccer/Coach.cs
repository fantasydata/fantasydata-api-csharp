using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Soccer
{
    [DataContract(Namespace="", Name="Coach")]
    [Serializable]
    public partial class Coach
    {
        /// <summary>
        /// The unique ID of the coach
        /// </summary>
        [Description("The unique ID of the coach")]
        [DataMember(Name = "CoachId", Order = 1)]
        public int CoachId { get; set; }

        /// <summary>
        /// Coach's first name
        /// </summary>
        [Description("Coach's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// Coach's last name
        /// </summary>
        [Description("Coach's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// Coach's short name
        /// </summary>
        [Description("Coach's short name")]
        [DataMember(Name = "ShortName", Order = 4)]
        public string ShortName { get; set; }

        /// <summary>
        /// Coach's nationality
        /// </summary>
        [Description("Coach's nationality")]
        [DataMember(Name = "Nationality", Order = 5)]
        public string Nationality { get; set; }

    }
}

