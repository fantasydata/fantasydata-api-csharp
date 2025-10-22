using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player through their career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player through their career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

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
        /// Indicates the player's status of being on an active roster. Possible values include: Active; Inactive; Suspended; Maternity; Bereavement
        /// </summary>
        [Description("Indicates the player's status of being on an active roster. Possible values include: Active; Inactive; Suspended; Maternity; Bereavement")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The timestamp of when this record was last updated (in US Eastern time)
        /// </summary>
        [Description("The timestamp of when this record was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 5)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Designates whether or not the player is available (returns true/false)
        /// </summary>
        [Description("Designates whether or not the player is available (returns true/false)")]
        [DataMember(Name = "Available", Order = 6)]
        public bool? Available { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 7)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 8)]
        public string Team { get; set; }

        /// <summary>
        /// The jersey number of the player
        /// </summary>
        [Description("The jersey number of the player")]
        [DataMember(Name = "Jersey", Order = 9)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: PG; SG; SF; PF; C
        /// </summary>
        [Description("The player's primary position. Possible values: PG; SG; SF; PF; C")]
        [DataMember(Name = "Position", Order = 10)]
        public string Position { get; set; }

        /// <summary>
        /// The height of the player in inches
        /// </summary>
        [Description("The height of the player in inches")]
        [DataMember(Name = "Height", Order = 11)]
        public int? Height { get; set; }

        /// <summary>
        /// The weight of the player in pounds (lbs.)
        /// </summary>
        [Description("The weight of the player in pounds (lbs.)")]
        [DataMember(Name = "Weight", Order = 12)]
        public int? Weight { get; set; }

        /// <summary>
        /// The date (MM/DD/YYYY) the player was born
        /// </summary>
        [Description("The date (MM/DD/YYYY) the player was born")]
        [DataMember(Name = "BirthDate", Order = 13)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born
        /// </summary>
        [Description("The city in which the player was born")]
        [DataMember(Name = "BirthCity", Order = 14)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born (2-letter abbreviation). Note: If the player was born outside of North America or Australia, this field will be blank
        /// </summary>
        [Description("The state in which the player was born (2-letter abbreviation). Note: If the player was born outside of North America or Australia, this field will be blank")]
        [DataMember(Name = "BirthState", Order = 15)]
        public string BirthState { get; set; }

        /// <summary>
        /// The country in which the player was born
        /// </summary>
        [Description("The country in which the player was born")]
        [DataMember(Name = "BirthCountry", Order = 16)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The last college attened by the player. Note: If the player did not attend a college, this field will be "None"
        /// </summary>
        [Description("The last college attened by the player. Note: If the player did not attend a college, this field will be \"None\"")]
        [DataMember(Name = "College", Order = 17)]
        public string College { get; set; }

        /// <summary>
        /// Injury status used to project availability Statuses: Probable; Questionable; Doubtful; Out. If a player has a NULL injury status, they are healthy/available to play
        /// </summary>
        [Description("Injury status used to project availability Statuses: Probable; Questionable; Doubtful; Out. If a player has a NULL injury status, they are healthy/available to play")]
        [DataMember(Name = "InjuryStatus", Order = 18)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The player's body part(s) that are injured (e.g. Knee; Groin; Calf; Hamstring; etc.)  Note: if a player has multiple injured body parts they will appear as such - Hamstring/Ankle
        /// </summary>
        [Description("The player's body part(s) that are injured (e.g. Knee; Groin; Calf; Hamstring; etc.)  Note: if a player has multiple injured body parts they will appear as such - Hamstring/Ankle")]
        [DataMember(Name = "InjuryBodyPart", Order = 19)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Short description of injury involving injured body part(s), game status, player name, team name, and other extra news necessary. Notes are custom and can be unique
        /// </summary>
        [Description("Short description of injury involving injured body part(s), game status, player name, team name, and other extra news necessary. Notes are custom and can be unique")]
        [DataMember(Name = "InjuryNotes", Order = 20)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The date that the injury occurred, was first discovered, or was freshly updated
        /// </summary>
        [Description("The date that the injury occurred, was first discovered, or was freshly updated")]
        [DataMember(Name = "InjuryStartDate", Order = 21)]
        public DateTime? InjuryStartDate { get; set; }

    }
}

