using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Injury")]
    [Serializable]
    public partial class Injury
    {
        /// <summary>
        /// Unique ID of the injury status
        /// </summary>
        [Description("Unique ID of the injury status")]
        [DataMember(Name = "InjuryID", Order = 1)]
        public int InjuryID { get; set; }

        /// <summary>
        /// The PlayerID of the injured player
        /// </summary>
        [Description("The PlayerID of the injured player")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The full name of the injured player
        /// </summary>
        [Description("The full name of the injured player")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not the player is active (true/false)
        /// </summary>
        [Description("Whether or not the player is active (true/false)")]
        [DataMember(Name = "Active", Order = 4)]
        public bool Active { get; set; }

        /// <summary>
        /// Indicates the start date of the player's injury
        /// </summary>
        [Description("Indicates the start date of the player's injury")]
        [DataMember(Name = "StartDate", Order = 5)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Likelihood that player plays (Probable, Questionable, Doubtful, Out)
        /// </summary>
        [Description("Likelihood that player plays (Probable, Questionable, Doubtful, Out)")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "BodyPart", Order = 7)]
        public string BodyPart { get; set; }

        /// <summary>
        /// When the player is expected to return
        /// </summary>
        [Description("When the player is expected to return")]
        [DataMember(Name = "ExpectedReturn", Order = 8)]
        public string ExpectedReturn { get; set; }

    }
}

