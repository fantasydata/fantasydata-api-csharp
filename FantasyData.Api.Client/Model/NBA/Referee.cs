using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="Referee")]
    [Serializable]
    public partial class Referee
    {
        /// <summary>
        /// Unique ID of Referee
        /// </summary>
        [Description("Unique ID of Referee")]
        [DataMember(Name = "RefereeID", Order = 1)]
        public int RefereeID { get; set; }

        /// <summary>
        /// Name of Referee
        /// </summary>
        [Description("Name of Referee")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Number of Referee
        /// </summary>
        [Description("Number of Referee")]
        [DataMember(Name = "Number", Order = 3)]
        public int? Number { get; set; }

        /// <summary>
        /// Position of Referee
        /// </summary>
        [Description("Position of Referee")]
        [DataMember(Name = "Position", Order = 4)]
        public string Position { get; set; }

        /// <summary>
        /// College of Referee
        /// </summary>
        [Description("College of Referee")]
        [DataMember(Name = "College", Order = 5)]
        public string College { get; set; }

        /// <summary>
        /// Years of Experience of Referee
        /// </summary>
        [Description("Years of Experience of Referee")]
        [DataMember(Name = "Experience", Order = 6)]
        public int? Experience { get; set; }

    }
}

