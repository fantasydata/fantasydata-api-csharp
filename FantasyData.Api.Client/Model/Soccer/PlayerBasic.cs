using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="PlayerBasic")]
    [Serializable]
    public partial class PlayerBasic
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO.")]
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
        /// The player's short name.
        /// </summary>
        [Description("The player's short name.")]
        [DataMember(Name = "ShortName", Order = 5)]
        public string ShortName { get; set; }

        /// <summary>
        /// The position of the player. Possible values include: A (Attacker), M (Midfielder), D (Defender), GK (Goalkeeper)
        /// </summary>
        [Description("The position of the player. Possible values include: A (Attacker), M (Midfielder), D (Defender), GK (Goalkeeper)")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// The player's position category.
        /// </summary>
        [Description("The player's position category.")]
        [DataMember(Name = "PositionCategory", Order = 7)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 8)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The primary foot of the player. Possible values: left or right
        /// </summary>
        [Description("The primary foot of the player. Possible values: left or right")]
        [DataMember(Name = "Foot", Order = 9)]
        public string Foot { get; set; }

        /// <summary>
        /// The player's height in cm.
        /// </summary>
        [Description("The player's height in cm.")]
        [DataMember(Name = "Height", Order = 10)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in kg.
        /// </summary>
        [Description("The player's weight in kg.")]
        [DataMember(Name = "Weight", Order = 11)]
        public int? Weight { get; set; }

        /// <summary>
        /// The gender of the player.
        /// </summary>
        [Description("The gender of the player.")]
        [DataMember(Name = "Gender", Order = 12)]
        public string Gender { get; set; }

        /// <summary>
        /// The player's date of birth.
        /// </summary>
        [Description("The player's date of birth.")]
        [DataMember(Name = "BirthDate", Order = 13)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born.
        /// </summary>
        [Description("The city in which the player was born.")]
        [DataMember(Name = "BirthCity", Order = 14)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The country in which the player was born.
        /// </summary>
        [Description("The country in which the player was born.")]
        [DataMember(Name = "BirthCountry", Order = 15)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The nationality of the player.
        /// </summary>
        [Description("The nationality of the player.")]
        [DataMember(Name = "Nationality", Order = 16)]
        public string Nationality { get; set; }

        /// <summary>
        /// The date and time the player's status was updated. (EST/EDT)
        /// </summary>
        [Description("The date and time the player's status was updated. (EST/EDT)")]
        [DataMember(Name = "Updated", Order = 17)]
        public DateTime? Updated { get; set; }

    }
}

