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
        /// The last name of the referee
        /// </summary>
        [Description("The last name of the referee")]
        [DataMember(Name = "RefereeId", Order = 1)]
        public int RefereeId { get; set; }

        /// <summary>
        /// The first name of the referee
        /// </summary>
        [Description("The first name of the referee")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the referee
        /// </summary>
        [Description("The last name of the referee")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The short name of the referee
        /// </summary>
        [Description("The short name of the referee")]
        [DataMember(Name = "ShortName", Order = 4)]
        public string ShortName { get; set; }

        /// <summary>
        /// The nationality of the referee
        /// </summary>
        [Description("The nationality of the referee")]
        [DataMember(Name = "Nationality", Order = 5)]
        public string Nationality { get; set; }

    }
}

