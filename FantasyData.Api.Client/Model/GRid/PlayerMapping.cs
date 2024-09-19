using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="PlayerMapping")]
    [Serializable]
    public partial class PlayerMapping
    {
        /// <summary>
        /// Id of the Player in the GRid system
        /// </summary>
        [Description("Id of the Player in the GRid system")]
        [DataMember(Name = "PlayerGRid", Order = 1)]
        public string PlayerGRid { get; set; }

        /// <summary>
        /// The Id of the Originator (which source the OriginatorPlayerId maps to).
        /// </summary>
        [Description("The Id of the Originator (which source the OriginatorPlayerId maps to).")]
        [DataMember(Name = "OriginatorGRid", Order = 2)]
        public string OriginatorGRid { get; set; }

        /// <summary>
        /// The Id of the player in the originator's system
        /// </summary>
        [Description("The Id of the player in the originator's system")]
        [DataMember(Name = "OriginatorPlayerId", Order = 3)]
        public string OriginatorPlayerId { get; set; }

        /// <summary>
        /// The Id of the competition this mapping relates to in the GRid system. Players may have multiple Ids for a given originator across different competitions (e.g. one for CFB and one for the NFL).
        /// </summary>
        [Description("The Id of the competition this mapping relates to in the GRid system. Players may have multiple Ids for a given originator across different competitions (e.g. one for CFB and one for the NFL).")]
        [DataMember(Name = "CompetitionGRid", Order = 4)]
        public string CompetitionGRid { get; set; }

        /// <summary>
        /// Timestamp in UTC of the mappings initial creation/match in the GRid system
        /// </summary>
        [Description("Timestamp in UTC of the mappings initial creation/match in the GRid system")]
        [DataMember(Name = "Created", Order = 5)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The name of the originator
        /// </summary>
        [Description("The name of the originator")]
        [DataMember(Name = "OriginatorName", Order = 6)]
        public string OriginatorName { get; set; }

        /// <summary>
        /// The name of the competition
        /// </summary>
        [Description("The name of the competition")]
        [DataMember(Name = "CompetitionName", Order = 7)]
        public string CompetitionName { get; set; }

    }
}

