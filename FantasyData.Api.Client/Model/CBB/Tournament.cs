using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="Tournament")]
    [Serializable]
    public partial class Tournament
    {
        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The college basketball season of the tournament
        /// </summary>
        [Description("The college basketball season of the tournament")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The name of the tournament
        /// </summary>
        [Description("The name of the tournament")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The location of the tournament
        /// </summary>
        [Description("The location of the tournament")]
        [DataMember(Name = "Location", Order = 4)]
        public string Location { get; set; }

        /// <summary>
        /// The games of this tournament
        /// </summary>
        [Description("The games of this tournament")]
        [DataMember(Name = "Games", Order = 20005)]
        public Game[] Games { get; set; }

    }
}

