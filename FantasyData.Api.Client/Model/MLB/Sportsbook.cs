using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Sportsbook")]
    [Serializable]
    public partial class Sportsbook
    {
        /// <summary>
        /// Unique ID of the sportsbook
        /// </summary>
        [Description("Unique ID of the sportsbook")]
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

