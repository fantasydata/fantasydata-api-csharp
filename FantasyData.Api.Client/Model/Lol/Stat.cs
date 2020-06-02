using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="Stat")]
    [Serializable]
    public partial class Stat
    {
        /// <summary>
        /// The last update time of the record
        /// </summary>
        [Description("The last update time of the record")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 2)]
        public int Games { get; set; }

        /// <summary>
        /// The number of matches played
        /// </summary>
        [Description("The number of matches played")]
        [DataMember(Name = "Matches", Order = 3)]
        public int Matches { get; set; }

        /// <summary>
        /// Indicates whether the stats for this player have been loaded and are final
        /// </summary>
        [Description("Indicates whether the stats for this player have been loaded and are final")]
        [DataMember(Name = "IsClosed", Order = 4)]
        public bool IsClosed { get; set; }

    }
}

