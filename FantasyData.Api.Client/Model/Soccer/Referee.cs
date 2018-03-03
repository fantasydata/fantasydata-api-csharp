using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Referee")]
    [Serializable]
    public partial class Referee
    {
        /// <summary>
        /// The unique ID of the referee
        /// </summary>
        [Description("The unique ID of the referee")]
        [DataMember(Name = "RefereeId", Order = 1)]
        public int RefereeId { get; set; }

        /// <summary>
        /// Referee's first name
        /// </summary>
        [Description("Referee's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// Referee's last name
        /// </summary>
        [Description("Referee's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// Referee's short name
        /// </summary>
        [Description("Referee's short name")]
        [DataMember(Name = "ShortName", Order = 4)]
        public string ShortName { get; set; }

        /// <summary>
        /// Referee's nationality
        /// </summary>
        [Description("Referee's nationality")]
        [DataMember(Name = "Nationality", Order = 5)]
        public string Nationality { get; set; }

    }
}

