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
        /// Unique ID of player
        /// </summary>
        [Description("Unique ID of player")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Full name of player
        /// </summary>
        [Description("Full name of player")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of team
        /// </summary>
        [Description("Unique ID of team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// Team name abbreviation
        /// </summary>
        [Description("Team name abbreviation")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// Position of player
        /// </summary>
        [Description("Position of player")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// Injury status (Questionable, Out, etc)
        /// </summary>
        [Description("Injury status (Questionable, Out, etc)")]
        [DataMember(Name = "InjuryStatus", Order = 6)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// Body part injured
        /// </summary>
        [Description("Body part injured")]
        [DataMember(Name = "InjuryBodyPart", Order = 7)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// Injury description
        /// </summary>
        [Description("Injury description")]
        [DataMember(Name = "InjuryNotes", Order = 8)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// Date on which injury occurred
        /// </summary>
        [Description("Date on which injury occurred")]
        [DataMember(Name = "InjuryStartDate", Order = 9)]
        public DateTime? InjuryStartDate { get; set; }

    }
}

