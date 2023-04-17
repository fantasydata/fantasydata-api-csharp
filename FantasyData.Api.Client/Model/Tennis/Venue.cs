using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Venue")]
    [Serializable]
    public partial class Venue
    {
        /// <summary>
        /// The unique ID of the venue
        /// </summary>
        [Description("The unique ID of the venue")]
        [DataMember(Name = "VenueId", Order = 1)]
        public int VenueId { get; set; }

        /// <summary>
        /// The full name of the venue
        /// </summary>
        [Description("The full name of the venue")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The city where the venue is located
        /// </summary>
        [Description("The city where the venue is located")]
        [DataMember(Name = "City", Order = 3)]
        public string City { get; set; }

    }
}

