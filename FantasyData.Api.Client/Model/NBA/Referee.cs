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
        /// The referee's full name
        /// </summary>
        [Description("The referee's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the referee
        /// </summary>
        [Description("The number of the referee")]
        [DataMember(Name = "Number", Order = 3)]
        public int? Number { get; set; }

        /// <summary>
        /// The position of the referee in the crew
        /// </summary>
        [Description("The position of the referee in the crew")]
        [DataMember(Name = "Position", Order = 4)]
        public string Position { get; set; }

        /// <summary>
        /// The college of the referee
        /// </summary>
        [Description("The college of the referee")]
        [DataMember(Name = "College", Order = 5)]
        public string College { get; set; }

        /// <summary>
        /// The number of years experience the referee has in the NBA.
        /// </summary>
        [Description("The number of years experience the referee has in the NBA.")]
        [DataMember(Name = "Experience", Order = 6)]
        public int? Experience { get; set; }

    }
}

