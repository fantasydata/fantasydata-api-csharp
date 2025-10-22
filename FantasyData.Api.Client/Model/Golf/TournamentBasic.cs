using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="TournamentBasic")]
    [Serializable]
    public partial class TournamentBasic
    {
        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The name of the tournament
        /// </summary>
        [Description("The name of the tournament")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The start date of this tournament
        /// </summary>
        [Description("The start date of this tournament")]
        [DataMember(Name = "StartDate", Order = 3)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of this tournament
        /// </summary>
        [Description("The end date of this tournament")]
        [DataMember(Name = "EndDate", Order = 4)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates whether this tournament is over
        /// </summary>
        [Description("Indicates whether this tournament is over")]
        [DataMember(Name = "IsOver", Order = 5)]
        public bool IsOver { get; set; }

    }
}

