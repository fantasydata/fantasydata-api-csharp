using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Lol
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by FantasyData.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by FantasyData.")]
        [DataMember(Name = "PlayerId", Order = 1)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The player's first name.
        /// </summary>
        [Description("The player's first name.")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name.
        /// </summary>
        [Description("The player's last name.")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The player's common name.
        /// </summary>
        [Description("The player's common name.")]
        [DataMember(Name = "CommonName", Order = 4)]
        public string CommonName { get; set; }

        /// <summary>
        /// The player's match name.
        /// </summary>
        [Description("The player's match name.")]
        [DataMember(Name = "MatchName", Order = 5)]
        public string MatchName { get; set; }

        /// <summary>
        /// The position of the player. Possible values include: ADC, Jungle, Mid, Support, Top
        /// </summary>
        [Description("The position of the player. Possible values include: ADC, Jungle, Mid, Support, Top")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// The gender of the player.
        /// </summary>
        [Description("The gender of the player.")]
        [DataMember(Name = "Gender", Order = 7)]
        public string Gender { get; set; }

        /// <summary>
        /// The player's date of birth.
        /// </summary>
        [Description("The player's date of birth.")]
        [DataMember(Name = "BirthDate", Order = 8)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born.
        /// </summary>
        [Description("The city in which the player was born.")]
        [DataMember(Name = "BirthCity", Order = 9)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The country in which the player was born.
        /// </summary>
        [Description("The country in which the player was born.")]
        [DataMember(Name = "BirthCountry", Order = 10)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The nationality of the player.
        /// </summary>
        [Description("The nationality of the player.")]
        [DataMember(Name = "Nationality", Order = 11)]
        public string Nationality { get; set; }

        /// <summary>
        /// The date and time the player's status was updated. (EST/EDT)
        /// </summary>
        [Description("The date and time the player's status was updated. (EST/EDT)")]
        [DataMember(Name = "Updated", Order = 12)]
        public DateTime? Updated { get; set; }

    }
}

