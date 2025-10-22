using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="InjuredPlayer")]
    [Serializable]
    public partial class InjuredPlayer
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO (if applicable). Note: this ID will stay with the player throughout their collegiate career.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO (if applicable). Note: this ID will stay with the player throughout their collegiate career.")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Injured player's full name (first and last)
        /// </summary>
        [Description("Injured player's full name (first and last)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the player's team
        /// </summary>
        [Description("The abbreviation [Key] of the player's team")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The player's eligible position(s). Possible values: C; F; F-C; G; G-F, PG, SG, SF, PF.
        /// </summary>
        [Description("The player's eligible position(s). Possible values: C; F; F-C; G; G-F, PG, SG, SF, PF.")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// Injury status used to project availability. Statuses: Probable; Questionable; Doubtful; Out.
        /// </summary>
        [Description("Injury status used to project availability. Statuses: Probable; Questionable; Doubtful; Out.")]
        [DataMember(Name = "InjuryStatus", Order = 6)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The player's body part(s) that are injured (e.g. Knee; Groin; Calf; Hamstring; etc.). Note: if a player has multiple injured body parts they will appear as such - Hamstring/Ankle.
        /// </summary>
        [Description("The player's body part(s) that are injured (e.g. Knee; Groin; Calf; Hamstring; etc.). Note: if a player has multiple injured body parts they will appear as such - Hamstring/Ankle.")]
        [DataMember(Name = "InjuryBodyPart", Order = 7)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Short description of injury involving injured body part(s), game status, player name, team name, and other extra news necessary. Notes are custom and can be unique.
        /// </summary>
        [Description("Short description of injury involving injured body part(s), game status, player name, team name, and other extra news necessary. Notes are custom and can be unique.")]
        [DataMember(Name = "InjuryNotes", Order = 8)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The date that the injury occurred, was first discovered, or was freshly updated
        /// </summary>
        [Description("The date that the injury occurred, was first discovered, or was freshly updated")]
        [DataMember(Name = "InjuryStartDate", Order = 9)]
        public DateTime? InjuryStartDate { get; set; }

    }
}

