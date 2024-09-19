using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerBasic")]
    [Serializable]
    public partial class PlayerBasic
    {
        /// <summary>
        /// The unique ID of this golfer
        /// </summary>
        [Description("The unique ID of this golfer")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The first name of this golfer
        /// </summary>
        [Description("The first name of this golfer")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this golfer
        /// </summary>
        [Description("The last name of this golfer")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The golfer's weight (in pounds)
        /// </summary>
        [Description("The golfer's weight (in pounds)")]
        [DataMember(Name = "Weight", Order = 4)]
        public int? Weight { get; set; }

        /// <summary>
        /// Indicates whether this golfer is right-handed or left-handed (Possible values: R, L)
        /// </summary>
        [Description("Indicates whether this golfer is right-handed or left-handed (Possible values: R, L)")]
        [DataMember(Name = "Swings", Order = 5)]
        public string Swings { get; set; }

        /// <summary>
        /// The year that this golfer made his PGA debut
        /// </summary>
        [Description("The year that this golfer made his PGA debut")]
        [DataMember(Name = "PgaDebut", Order = 6)]
        public int? PgaDebut { get; set; }

        /// <summary>
        /// The country where this golfer is from
        /// </summary>
        [Description("The country where this golfer is from")]
        [DataMember(Name = "Country", Order = 7)]
        public string Country { get; set; }

        /// <summary>
        /// The birthday of this golfer
        /// </summary>
        [Description("The birthday of this golfer")]
        [DataMember(Name = "BirthDate", Order = 8)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city where this golfer was born
        /// </summary>
        [Description("The city where this golfer was born")]
        [DataMember(Name = "BirthCity", Order = 9)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state where this golfer was born
        /// </summary>
        [Description("The state where this golfer was born")]
        [DataMember(Name = "BirthState", Order = 10)]
        public string BirthState { get; set; }

        /// <summary>
        /// The college that this golfer attended
        /// </summary>
        [Description("The college that this golfer attended")]
        [DataMember(Name = "College", Order = 11)]
        public string College { get; set; }

    }
}

