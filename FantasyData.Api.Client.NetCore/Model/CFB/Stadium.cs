using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CFB
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
        /// Whether or not this stadium is the home venue for an active team
        /// </summary>
        [Description("Whether or not this stadium is the home venue for an active team")]
        [DataMember(Name = "Active", Order = 2)]
        public bool Active { get; set; }

        /// <summary>
        /// The full name of the stadium
        /// </summary>
        [Description("The full name of the stadium")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether this stadium is a dome
        /// </summary>
        [Description("Indicates whether this stadium is a dome")]
        [DataMember(Name = "Dome", Order = 4)]
        public bool Dome { get; set; }

        /// <summary>
        /// The city where the stadium is located
        /// </summary>
        [Description("The city where the stadium is located")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// The US state where the stadium is located (if Stadium is outside US, this value is NULL)
        /// </summary>
        [Description("The US state where the stadium is located (if Stadium is outside US, this value is NULL)")]
        [DataMember(Name = "State", Order = 6)]
        public string State { get; set; }

    }
}

