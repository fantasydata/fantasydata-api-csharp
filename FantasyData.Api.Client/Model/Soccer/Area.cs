using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Area")]
    [Serializable]
    public partial class Area
    {
        /// <summary>
        /// The unique ID of the area
        /// </summary>
        [Description("The unique ID of the area")]
        [DataMember(Name = "AreaId", Order = 1)]
        public int AreaId { get; set; }

        /// <summary>
        /// The country code of the area
        /// </summary>
        [Description("The country code of the area")]
        [DataMember(Name = "CountryCode", Order = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The display name of the area
        /// </summary>
        [Description("The display name of the area")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The competitions that are associated with and/or played in the area
        /// </summary>
        [Description("The competitions that are associated with and/or played in the area")]
        [DataMember(Name = "Competitions", Order = 20004)]
        public Competition[] Competitions { get; set; }

    }
}

