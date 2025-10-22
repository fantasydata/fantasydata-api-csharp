using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Sportsbook")]
    [Serializable]
    public partial class Sportsbook
    {
        /// <summary>
        /// The unique ID of the sportsbook
        /// </summary>
        [Description("The unique ID of the sportsbook")]
        [DataMember(Name = "SportsbookID", Order = 1)]
        public int SportsbookID { get; set; }

        /// <summary>
        /// The name of the sportsbooks
        /// </summary>
        [Description("The name of the sportsbooks")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

