using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="Stadium")]
    [Serializable]
    public partial class Stadium
    {
        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 1)]
        public int StadiumID { get; set; }

        /// <summary>
        /// Whether or not this team is active. Note: Active = True & Inactive = False
        /// </summary>
        [Description("Whether or not this team is active. Note: Active = True & Inactive = False")]
        [DataMember(Name = "Active", Order = 2)]
        public bool Active { get; set; }

        /// <summary>
        /// The full name of the stadium
        /// </summary>
        [Description("The full name of the stadium")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The city in which the stadium is located
        /// </summary>
        [Description("The city in which the stadium is located")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The state where the stadium is located (only US and Canadian stadiums will have values)
        /// </summary>
        [Description("The state where the stadium is located (only US and Canadian stadiums will have values)")]
        [DataMember(Name = "State", Order = 5)]
        public string State { get; set; }

        /// <summary>
        /// The 2-digit country code where the stadium is located
        /// </summary>
        [Description("The 2-digit country code where the stadium is located")]
        [DataMember(Name = "Country", Order = 6)]
        public string Country { get; set; }

    }
}

