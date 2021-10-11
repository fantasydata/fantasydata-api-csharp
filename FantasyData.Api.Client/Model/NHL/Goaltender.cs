using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="Goaltender")]
    [Serializable]
    public partial class Goaltender
    {
        /// <summary>
        /// Unique ID of Player
        /// </summary>
        [Description("Unique ID of Player")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// Name of Team
        /// </summary>
        [Description("Name of Team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// Goaltender First Name
        /// </summary>
        [Description("Goaltender First Name")]
        [DataMember(Name = "FirstName", Order = 4)]
        public string FirstName { get; set; }

        /// <summary>
        /// Goaltender Last Name
        /// </summary>
        [Description("Goaltender Last Name")]
        [DataMember(Name = "LastName", Order = 5)]
        public string LastName { get; set; }

        /// <summary>
        /// Goaltender Jersey Number
        /// </summary>
        [Description("Goaltender Jersey Number")]
        [DataMember(Name = "Jersey", Order = 6)]
        public int Jersey { get; set; }

        /// <summary>
        /// Indicates whether the starting goaltender is projected or confirmed
        /// </summary>
        [Description("Indicates whether the starting goaltender is projected or confirmed")]
        [DataMember(Name = "Confirmed", Order = 7)]
        public bool Confirmed { get; set; }

    }
}

