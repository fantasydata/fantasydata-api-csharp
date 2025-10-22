using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Referee")]
    [Serializable]
    public partial class Referee
    {
        /// <summary>
        /// The unique ID of the referee
        /// </summary>
        [Description("The unique ID of the referee")]
        [DataMember(Name = "RefereeID", Order = 1)]
        public int RefereeID { get; set; }

        /// <summary>
        /// The name of the referee
        /// </summary>
        [Description("The name of the referee")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The referee's number
        /// </summary>
        [Description("The referee's number")]
        [DataMember(Name = "Number", Order = 3)]
        public int Number { get; set; }

        /// <summary>
        /// The referee's position
        /// </summary>
        [Description("The referee's position")]
        [DataMember(Name = "Position", Order = 4)]
        public string Position { get; set; }

        /// <summary>
        /// The referee's college
        /// </summary>
        [Description("The referee's college")]
        [DataMember(Name = "College", Order = 5)]
        public string College { get; set; }

        /// <summary>
        /// The referee's years of experience
        /// </summary>
        [Description("The referee's years of experience")]
        [DataMember(Name = "Experience", Order = 6)]
        public int Experience { get; set; }

    }
}

