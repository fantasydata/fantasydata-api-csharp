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
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career.")]
        [DataMember(Name = "PlayerId", Order = 1)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The player's first name
        /// </summary>
        [Description("The player's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the player
        /// </summary>
        [Description("The last name of the player")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The player's common name
        /// </summary>
        [Description("The player's common name")]
        [DataMember(Name = "CommonName", Order = 4)]
        public string CommonName { get; set; }

        /// <summary>
        /// The short name of the player
        /// </summary>
        [Description("The short name of the player")]
        [DataMember(Name = "ShortName", Order = 5)]
        public string ShortName { get; set; }

        /// <summary>
        /// The position of the player. Possible values include: A (Attacker), M (Midfielder), D (Defender), GK (Goalkeeper).
        /// </summary>
        [Description("The position of the player. Possible values include: A (Attacker), M (Midfielder), D (Defender), GK (Goalkeeper).")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// The player's position category
        /// </summary>
        [Description("The player's position category")]
        [DataMember(Name = "PositionCategory", Order = 7)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's jersey number
        /// </summary>
        [Description("The player's jersey number")]
        [DataMember(Name = "Jersey", Order = 8)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The primary foot of the player. Possible values: left or right.
        /// </summary>
        [Description("The primary foot of the player. Possible values: left or right.")]
        [DataMember(Name = "Foot", Order = 9)]
        public string Foot { get; set; }

        /// <summary>
        /// The height of the player in centimeters (cm)
        /// </summary>
        [Description("The height of the player in centimeters (cm)")]
        [DataMember(Name = "Height", Order = 10)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in kilograms (kg)
        /// </summary>
        [Description("The player's weight in kilograms (kg)")]
        [DataMember(Name = "Weight", Order = 11)]
        public int? Weight { get; set; }

        /// <summary>
        /// The gender of this player on the team. Possible Values: Male; Female.
        /// </summary>
        [Description("The gender of this player on the team. Possible Values: Male; Female.")]
        [DataMember(Name = "Gender", Order = 12)]
        public string Gender { get; set; }

        /// <summary>
        /// The player's date of birth
        /// </summary>
        [Description("The player's date of birth")]
        [DataMember(Name = "BirthDate", Order = 13)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born
        /// </summary>
        [Description("The city in which the player was born")]
        [DataMember(Name = "BirthCity", Order = 14)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The country in which the player was born
        /// </summary>
        [Description("The country in which the player was born")]
        [DataMember(Name = "BirthCountry", Order = 15)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The nationality of the player
        /// </summary>
        [Description("The nationality of the player")]
        [DataMember(Name = "Nationality", Order = 16)]
        public string Nationality { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 17)]
        public DateTime? Updated { get; set; }

    }
}

