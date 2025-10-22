using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
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
        /// The position of the player. Possible values include: A (Attacker); M (Midfielder); D (Defender); GK (Goalkeeper).
        /// </summary>
        [Description("The position of the player. Possible values include: A (Attacker); M (Midfielder); D (Defender); GK (Goalkeeper).")]
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
        /// Indicates the player's injury status. Possible values: Questionable; Out.
        /// </summary>
        [Description("Indicates the player's injury status. Possible values: Questionable; Out.")]
        [DataMember(Name = "InjuryStatus", Order = 17)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part of the player that is injured (Knee; Groin; Calf; Hamstring; etc.)
        /// </summary>
        [Description("The body part of the player that is injured (Knee; Groin; Calf; Hamstring; etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 18)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Not yet supported; will be null
        /// </summary>
        [Description("Not yet supported; will be null")]
        [DataMember(Name = "InjuryNotes", Order = 19)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The date that the injury started or was first discovered
        /// </summary>
        [Description("The date that the injury started or was first discovered")]
        [DataMember(Name = "InjuryStartDate", Order = 20)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 21)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// This field is deprecated. Note: Photos are no longer available through this field. Headshots are now delivered through IMAGN. Please see our Headshots products for further information.
        /// </summary>
        [Description("This field is deprecated. Note: Photos are no longer available through this field. Headshots are now delivered through IMAGN. Please see our Headshots products for further information.")]
        [DataMember(Name = "PhotoUrl", Order = 22)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the RotoWire news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the RotoWire news feed.")]
        [DataMember(Name = "RotoWirePlayerID", Order = 23)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The position of the player according to DraftKings
        /// </summary>
        [Description("The position of the player according to DraftKings")]
        [DataMember(Name = "DraftKingsPosition", Order = 24)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds")]
        [DataMember(Name = "UsaTodayPlayerID", Order = 25)]
        public int? UsaTodayPlayerID { get; set; }

        /// <summary>
        /// The player's headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUrl", Order = 26)]
        public string UsaTodayHeadshotUrl { get; set; }

        /// <summary>
        /// The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUrl", Order = 27)]
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }

        /// <summary>
        /// The last updated timestamp of the player's headshot as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The last updated timestamp of the player's headshot as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUpdated", Order = 28)]
        public DateTime? UsaTodayHeadshotUpdated { get; set; }

        /// <summary>
        /// The last updated timestamp of the player's transparent background headshot as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The last updated timestamp of the player's transparent background headshot as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUpdated", Order = 29)]
        public DateTime? UsaTodayHeadshotNoBackgroundUpdated { get; set; }

    }
}

