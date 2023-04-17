using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The unique ID of this player
        /// </summary>
        [Description("The unique ID of this player")]
        [DataMember(Name = "PlayerId", Order = 1)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The player's first name
        /// </summary>
        [Description("The player's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name
        /// </summary>
        [Description("The player's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The player's common name
        /// </summary>
        [Description("The player's common name")]
        [DataMember(Name = "CommonName", Order = 4)]
        public string CommonName { get; set; }

        /// <summary>
        /// The player's short name
        /// </summary>
        [Description("The player's short name")]
        [DataMember(Name = "ShortName", Order = 5)]
        public string ShortName { get; set; }

        /// <summary>
        /// The player's gender
        /// </summary>
        [Description("The player's gender")]
        [DataMember(Name = "Gender", Order = 6)]
        public string Gender { get; set; }

        /// <summary>
        /// The player's birthdate
        /// </summary>
        [Description("The player's birthdate")]
        [DataMember(Name = "BirthDate", Order = 7)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The player's birth city
        /// </summary>
        [Description("The player's birth city")]
        [DataMember(Name = "BirthCity", Order = 8)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The player's birth country
        /// </summary>
        [Description("The player's birth country")]
        [DataMember(Name = "BirthCountry", Order = 9)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The player's nationality
        /// </summary>
        [Description("The player's nationality")]
        [DataMember(Name = "Nationality", Order = 10)]
        public string Nationality { get; set; }

        /// <summary>
        /// The player's height in centimeters
        /// </summary>
        [Description("The player's height in centimeters")]
        [DataMember(Name = "Height", Order = 11)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in kilograms
        /// </summary>
        [Description("The player's weight in kilograms")]
        [DataMember(Name = "Weight", Order = 12)]
        public int? Weight { get; set; }

        /// <summary>
        /// The player's status
        /// </summary>
        [Description("The player's status")]
        [DataMember(Name = "Status", Order = 13)]
        public string Status { get; set; }

        /// <summary>
        /// The player's hand
        /// </summary>
        [Description("The player's hand")]
        [DataMember(Name = "Hand", Order = 14)]
        public string Hand { get; set; }

        /// <summary>
        /// The year the player went pro
        /// </summary>
        [Description("The year the player went pro")]
        [DataMember(Name = "YearPro", Order = 15)]
        public int? YearPro { get; set; }

        /// <summary>
        /// Player's singles world rank
        /// </summary>
        [Description("Player's singles world rank")]
        [DataMember(Name = "SinglesWorldRank", Order = 16)]
        public int? SinglesWorldRank { get; set; }

        /// <summary>
        /// Player's doubles world rank
        /// </summary>
        [Description("Player's doubles world rank")]
        [DataMember(Name = "DoublesWorldRank", Order = 17)]
        public int? DoublesWorldRank { get; set; }

    }
}

