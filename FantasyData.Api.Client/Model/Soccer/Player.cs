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
        [Description("The player's position category. ")]
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
        /// Indicates the player's injury status. Possible values include: Questionable, Out
        /// </summary>
        [Description("Indicates the player's injury status. Possible values include: Questionable, Out")]
        [DataMember(Name = "InjuryStatus", Order = 17)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 18)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Not yet supported, will be null.
        /// </summary>
        [Description("Not yet supported, will be null.")]
        [DataMember(Name = "InjuryNotes", Order = 19)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered.
        /// </summary>
        [Description("The day that the injury started or first discovered.")]
        [DataMember(Name = "InjuryStartDate", Order = 20)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// The date and time the player's status was updated. (EST/EDT)
        /// </summary>
        [Description("The date and time the player's status was updated. (EST/EDT)")]
        [DataMember(Name = "Updated", Order = 21)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The url of the player's photo.
        /// </summary>
        [Description("The url of the player's photo.")]
        [DataMember(Name = "PhotoUrl", Order = 22)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the RotoWire news feed.
        /// </summary>
        [Description("The player's cross reference PlayerID to the RotoWire news feed.")]
        [DataMember(Name = "RotoWirePlayerID", Order = 23)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The position of the player according to DraftKings.
        /// </summary>
        [Description("The position of the player according to DraftKings.")]
        [DataMember(Name = "DraftKingsPosition", Order = 24)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds.
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds.")]
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

    }
}

