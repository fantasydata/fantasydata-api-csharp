using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Round")]
    [Serializable]
    public partial class Round
    {
        /// <summary>
        /// The unique ID of the round of this tournament
        /// </summary>
        [Description("The unique ID of the round of this tournament")]
        [DataMember(Name = "RoundID", Order = 1)]
        public int RoundID { get; set; }

        /// <summary>
        /// The round number of this round
        /// </summary>
        [Description("The round number of this round")]
        [DataMember(Name = "Number", Order = 2)]
        public int? Number { get; set; }

        /// <summary>
        /// The date that this round is played
        /// </summary>
        [Description("The date that this round is played")]
        [DataMember(Name = "Day", Order = 3)]
        public DateTime? Day { get; set; }

    }
}

