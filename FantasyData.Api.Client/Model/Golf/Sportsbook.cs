using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Sportsbook")]
    [Serializable]
    public partial class Sportsbook
    {
        /// <summary>
        /// The unique ID of the sportsbook(s)
        /// </summary>
        [Description("The unique ID of the sportsbook(s)")]
        [DataMember(Name = "SportsbookID", Order = 1)]
        public int SportsbookID { get; set; }

        /// <summary>
        /// The name of the sportsbook(s)
        /// </summary>
        [Description("The name of the sportsbook(s)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

